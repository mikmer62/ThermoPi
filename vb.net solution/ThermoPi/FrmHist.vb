Imports System.IO
Imports System.Threading

Public Class FrmHist

  Private Sub SetLvColumnSize()
    Dim LvSize As Integer

    If LvHist.Columns.Count > 0 Then
      LvSize = LvHist.Size.Width - 25
      LvHist.Columns.Item(1).Width = Int(LvSize / 410 * 100)
      LvHist.Columns.Item(2).Width = Int(LvSize / 410 * 85)
      LvHist.Columns.Item(3).Width = Int(LvSize / 410 * 70)
      LvHist.Columns.Item(4).Width = Int(LvSize / 410 * 85)
      LvHist.Columns.Item(5).Width = Int(LvSize / 410 * 70)
    End If
  End Sub

  Private Sub LvHist_SizeChanged(sender As Object, e As EventArgs) Handles LvHist.SizeChanged
    SetLvColumnSize()
  End Sub

  Private Sub LvHist_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles LvHist.ColumnClick
    Dim LVSortComp As LVSortComparer
    Dim NewColNum As Integer
    Dim NewSortOrder As SortOrder

    LVSortComp = DirectCast(LvHist.ListViewItemSorter, LVSortComparer)
    NewColNum = e.Column
    If LVSortComp Is Nothing Then
      NewSortOrder = SortOrder.Ascending
    Else
      If LVSortComp.LVSortCol = NewColNum Then
        Select Case LvHist.Sorting
          Case SortOrder.None, SortOrder.Descending
            NewSortOrder = SortOrder.Ascending
          Case SortOrder.Ascending
            NewSortOrder = SortOrder.Descending
        End Select
      Else
        NewSortOrder = SortOrder.Ascending
      End If
    End If
    LvHist.SuspendLayout()
    LvHist.ListViewItemSorter = Nothing
    Select Case NewColNum
      Case 0
      Case 1
        LvHist.ListViewItemSorter = New LVSortComparer(LvHist, NewColNum, LVSortComparer.SortTypeEnum.SortTypeDate, NewSortOrder)
      Case 3, 5
        LvHist.ListViewItemSorter = New LVSortComparer(LvHist, NewColNum, LVSortComparer.SortTypeEnum.SortTypeReal, NewSortOrder)
      Case Else
        LvHist.ListViewItemSorter = New LVSortComparer(LvHist, NewColNum, LVSortComparer.SortTypeEnum.SortTypeText, NewSortOrder)
    End Select
    LvHist.ResumeLayout(False)
    If LvHist.SelectedItems.Count > 0 Then
      LvHist.SelectedItems(0).EnsureVisible()
    End If
  End Sub

  Private Sub DispHistory()
    Dim fi As FileInfo
    Dim lvi As ListViewItem
    Dim hist() As String
    Dim readOK As Boolean

    LvHist.Items.Clear()
    LvHist.Sorting = SortOrder.None
    LvHist.ListViewItemSorter = Nothing
    LVClrSortIcon(LvHist)
    LvHist.SelectedItems.Clear()

    With ThermoPI.prefs
      If .RaspSharedDir <> "" Then
        fi = New FileInfo(.RaspSharedDir & "\ThermoPi-Hist.txt")
        If fi.Exists Then
          'Récupère les historiques dans le dossier partagé / Get history in shared directory
          Using fs As New FileStream(.RaspSharedDir & "\ThermoPi-Hist.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Using sr As New StreamReader(fs)
              readOK = False
              While readOK = False
                Try
                  While sr.EndOfStream = False
                    hist = sr.ReadLine.Split(";")
                    lvi = New ListViewItem("")
                    If ThermoPI.prefs.DateFormat = "fr" Then
                      lvi.SubItems.Add(hist(0))
                    Else
                      lvi.SubItems.Add(hist(0).Substring(3, 2) & "/" & hist(0).Substring(0, 2) & "/" & hist(0).Substring(6, 4))
                    End If
                    lvi.SubItems.Add(hist(1))
                    lvi.SubItems.Add(CDbl(hist(2) / 1000).ToString("0.0"))
                    lvi.SubItems.Add(hist(3))
                    lvi.SubItems.Add(CDbl(hist(4) / 1000).ToString("0.0"))
                    LvHist.Items.Add(lvi)
                  End While
                  readOK = True
                Catch ex As Exception
                End Try
              End While
            End Using
          End Using
        End If
      End If
    End With
    LvHist.EnsureVisible(LvHist.Items.Count - 1)
    LvHist.Items(LvHist.Items.Count - 1).Selected = True
  End Sub

  Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
    DispHistory()
  End Sub

  Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
    Me.Close()
  End Sub

  Private Sub FrmHist_Load(sender As Object, e As EventArgs) Handles Me.Load
    lblRaspName.Text = ThermoPI.RaspName

    LvHist.Clear()
    LvHist.Columns.Add("0", 0, HorizontalAlignment.Center)
    LvHist.Columns.Add("Date", 100, HorizontalAlignment.Center)
    LvHist.Columns.Add("Heure", 85, HorizontalAlignment.Center)
    LvHist.Columns.Add("T° min", 70, HorizontalAlignment.Center)
    LvHist.Columns.Add("Heure", 85, HorizontalAlignment.Center)
    LvHist.Columns.Add("T° max", 70, HorizontalAlignment.Center)
    SetLvColumnSize()

    DispHistory()
  End Sub


End Class