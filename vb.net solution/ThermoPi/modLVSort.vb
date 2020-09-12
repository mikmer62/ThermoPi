Imports System.Runtime.InteropServices

'This file is composed of a module and a class
'  Module contains functions to set the sort icon
'  Class contains functions to do the sort on subitems

Module modLVSort
  'Constants for SendMessage API
  Const HDI_FORMAT As Int32 = 4
  Const HDI_IMAGE As Int32 = 32
  Const HDF_LEFT As Int32 = 0
  Const HDF_RIGHT As Int32 = 1
  Const HDF_CENTER As Int32 = 2
  Const HDF_STRING As Int32 = 16384
  Const HDF_BITMAP_ON_RIGHT As Int32 = 4096
  Const HDF_IMAGE As Int32 = 2048
  Const LVM_FIRST As Int32 = 4096
  Const LVM_GETHEADER As Int32 = LVM_FIRST + 31
  Const HDM_FIRST As Int32 = 4608
  Const HDM_SETIMAGELIST As Int32 = HDM_FIRST + 8
  Const HDM_SETITEM As Int32 = HDM_FIRST + 12

  'Image List for Sort Icon
  Public LVSortImg As New ImageList

  'Structure for API SendMessage to set Sort Icon
  Public Structure hdItem
    Public mask As Int32
    Public cxy As Int32
    Public pszText As String
    Public hbm As IntPtr
    Public cchTextMax As Int32
    Public fmt As Int32
    Public lParam As Int32
    Public iImage As Int32
    Public iOrder As Int32
  End Structure

  'SendMessage
  <DllImport("User32.dll")> _
  Public Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
  End Function

  <DllImport("User32", CharSet:=CharSet.Auto)> _
  Public Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByRef lParam As hdItem) As IntPtr
  End Function

  'Image List Initialization
  'This function is called automatically if needed
  Public Sub LVInitSortImg()
    Dim bmp As Bitmap
    Dim grafx As Graphics

    LVSortImg.ImageSize = New Size(8, 8)
    'Add Up Arrow to Image List
    bmp = New Bitmap(8, 8)
    grafx = Graphics.FromImage(bmp)
    grafx.FillRectangle(System.Drawing.Brushes.Transparent, 0, 0, 8, 8)
    grafx.DrawLine(SystemPens.ControlLightLight, 0, 7, 7, 7)
    grafx.DrawLine(SystemPens.ControlLightLight, 7, 7, 4, 0)
    grafx.DrawLine(SystemPens.ControlDark, 3, 0, 0, 7)
    grafx.Dispose()
    LVSortImg.Images.Add(bmp)
    'Add Down Arrow to Image List
    bmp = New Bitmap(8, 8)
    grafx = Graphics.FromImage(bmp)
    grafx.FillRectangle(System.Drawing.Brushes.Transparent, 0, 0, 8, 8)
    grafx.DrawLine(SystemPens.ControlLightLight, 4, 7, 7, 0)
    grafx.DrawLine(SystemPens.ControlDark, 3, 7, 0, 0)
    grafx.DrawLine(SystemPens.ControlDark, 0, 0, 7, 0)
    grafx.Dispose()
    LVSortImg.Images.Add(bmp)
  End Sub

  'Set Sort Icon for a specific column
  'May be used to set or clear the icon
  'This function may be called separately from the comparer
  Public Sub LVSetOneSortIcon(ByRef ListV As ListView, ByVal ColNum As Integer, ByVal SortOrd As SortOrder)
    Dim hwnd As IntPtr
    Dim hd As hdItem

    If LVSortImg.Images.Count = 0 Then LVInitSortImg()
    If ColNum <= ListV.Columns.Count - 1 Then
      hwnd = SendMessage(ListV.Handle, LVM_GETHEADER, 0, 0)
      SendMessage(hwnd, HDM_SETIMAGELIST, 0, (LVSortImg.Handle).ToInt32)
      hd = New hdItem
      hd.mask = HDI_IMAGE Or HDI_FORMAT
      Select Case ListV.Columns(ColNum).TextAlign
        Case HorizontalAlignment.Left
          'Or HDF_BITMAP_ON_RIGHT may be removed if you always wish the icon to be on the left
          hd.fmt = HDF_LEFT Or HDF_STRING Or HDF_BITMAP_ON_RIGHT
        Case HorizontalAlignment.Center
          hd.fmt = HDF_CENTER Or HDF_STRING Or HDF_BITMAP_ON_RIGHT
        Case HorizontalAlignment.Right
          hd.fmt = HDF_RIGHT Or HDF_STRING
      End Select
      If Not (SortOrd = SortOrder.None) Then
        hd.fmt = hd.fmt Or (HDF_IMAGE)
      End If
      hd.iImage = CType(SortOrd, Integer) - 1
      SendMessage(hwnd, HDM_SETITEM, ColNum, hd)
      hd = Nothing
    End If
  End Sub

  'Set Sort Icon for the whole ListView
  'Clear the icon for all columns
  'Then Set the icon for the right column
  'This function may be called separately from the comparer
  Public Sub LVSetSortIcon(ByRef ListV As ListView, ByVal ColNum As Integer, ByVal SortOrd As SortOrder)

    LVClrSortIcon(ListV)
    LVSetOneSortIcon(ListV, ColNum, SortOrd)
  End Sub

  'Function to clear Sort Icon of all columns
  'This function may be called separately from the comparer
  Public Sub LVClrSortIcon(ByRef ListV As ListView)
    Dim i As Integer

    For i = 0 To ListV.Columns.Count - 1
      LVSetOneSortIcon(ListV, i, SortOrder.None)
    Next i
  End Sub

End Module

Public Class LVSortComparer
  Implements IComparer

  Public Enum SortTypeEnum
    SortTypeText = 0
    SortTypeInteger = 1
    SortTypeReal = 2
    SortTypeDate = 3
  End Enum

  Private ReadOnly _LVSortCol As Integer
  Private ReadOnly _LVSortType As SortTypeEnum

  Public ReadOnly Property LVSortCol() As Integer
    Get
      LVSortCol = _LVSortCol
    End Get
  End Property

  Public ReadOnly Property LVSortType() As SortTypeEnum
    Get
      LVSortType = _LVSortType
    End Get
  End Property

  'Explicit initialization
  'Needed if column data is not text
  Public Sub New(ByRef ListV As ListView, ByVal ColNum As Integer, ByVal SortType As SortTypeEnum, ByVal SortOrd As SortOrder, Optional ByVal InitIcon As Boolean = True)
    _LVSortCol = ColNum
    _LVSortType = SortType
    ListV.Sorting = SortOrd
    If InitIcon Then LVSetSortIcon(ListV, _LVSortCol, SortOrd)
  End Sub

  'Compare the items in the appropriate column
  'Try Catch structure used just in case...
  Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
    Dim LVIx As ListViewItem = DirectCast(x, ListViewItem)
    Dim LVIy As ListViewItem = DirectCast(y, ListViewItem)
    Dim RetVal As Integer

    If LVIx.ListView.Sorting = SortOrder.None Then
      Return 0
      Exit Function
    End If

    Dim sx As String = LVIx.SubItems(_LVSortCol).Text
    Dim sy As String = LVIy.SubItems(_LVSortCol).Text

    Select Case _LVSortType

      Case SortTypeEnum.SortTypeText
        'Sort on Text items
        RetVal = String.Compare(sx, sy)

      Case SortTypeEnum.SortTypeInteger
        'Sort on numeric items
        If IsNumeric(sx) = False And IsNumeric(sy) = False Then
          RetVal = 0
        ElseIf IsNumeric(sx) = False And IsNumeric(sy) Then
          RetVal = -1
        ElseIf IsNumeric(sx) And IsNumeric(sy) = False Then
          RetVal = 1
        Else
          Dim rx As Long = CLng(sx)
          Dim ry As Long = CLng(sy)
          If rx > ry Then
            RetVal = 1
          ElseIf rx < ry Then
            RetVal = -1
          Else
            RetVal = 0
          End If
        End If

      Case SortTypeEnum.SortTypeReal
        'Sort on numeric real items
        sx = sx.Trim("%"c).Trim("°"c)
        sy = sy.Trim("%"c).Trim("°"c)
        If IsNumeric(sx) = False And IsNumeric(sy) = False Then
          RetVal = 0
        ElseIf IsNumeric(sx) = False And IsNumeric(sy) Then
          RetVal = -1
        ElseIf IsNumeric(sx) And IsNumeric(sy) = False Then
          RetVal = 1
        Else
          Dim rx As Double = CDbl(sx)
          Dim ry As Double = CDbl(sy)
          If rx > ry Then
            RetVal = 1
          ElseIf rx < ry Then
            RetVal = -1
          Else
            RetVal = 0
          End If
        End If

      Case SortTypeEnum.SortTypeDate
        'Sort on Date Items
        If IsDate(sx) = False And IsDate(sy) = False Then
          RetVal = 0
        ElseIf IsDate(sx) = False And IsDate(sy) Then
          RetVal = -1
        ElseIf IsDate(sx) And IsDate(sy) = False Then
          RetVal = 1
        Else
          Dim dx As Date = Date.Parse(sx)
          Dim dy As Date = Date.Parse(sy)
          If dx.Ticks > dy.Ticks Then
            RetVal = 1
          ElseIf dx.Ticks < dy.Ticks Then
            RetVal = -1
          Else
            RetVal = 0
          End If
        End If

    End Select

    If LVIx.ListView.Sorting = SortOrder.Descending Then RetVal = -RetVal
    Return RetVal

  End Function

End Class