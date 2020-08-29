Public Class FrmAPropos

  Private Sub FrmAPropos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim s As String

    With My.Application.Info.Version
      s = "ThermoPi version " & .Major.ToString & "." & .Minor.ToString
      If .Build <> 0 Then s = s & "." & .Build.ToString
      lblVersion.Text = s
    End With
  End Sub

  Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    System.Diagnostics.Process.Start(LinkLabel1.Text)
  End Sub

  Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
    System.Diagnostics.Process.Start(LinkLabel2.Text)
  End Sub

End Class