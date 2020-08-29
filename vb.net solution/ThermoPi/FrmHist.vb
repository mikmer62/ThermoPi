Imports System.IO
Imports System.Threading

Public Class FrmHist

  Private Sub DispHistory()
    Dim fi As FileInfo
    Dim lvi As ListViewItem
    Dim hist() As String
    Dim readOK As Boolean

    With ThermoPI.prefs

      LvHist.Clear()
      LvHist.Columns.Add("0", 0, HorizontalAlignment.Center)
      LvHist.Columns.Add("Date", 100, HorizontalAlignment.Center)
      LvHist.Columns.Add("Heure", 85, HorizontalAlignment.Center)
      LvHist.Columns.Add("T° min", 70, HorizontalAlignment.Center)
      LvHist.Columns.Add("Heure", 85, HorizontalAlignment.Center)
      LvHist.Columns.Add("T° max", 70, HorizontalAlignment.Center)

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
  End Sub

  Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
    DispHistory()
  End Sub

  Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
    Me.Close()
  End Sub

  Private Sub FrmHist_Load(sender As Object, e As EventArgs) Handles Me.Load
    lblRaspName.Text = ThermoPI.RaspName
    DispHistory()
  End Sub


End Class