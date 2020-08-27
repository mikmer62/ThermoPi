Public Class FrmLang

  Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
    If RbFlagFr.Checked = True Then
      SaveSetting("ThermoPi", "Prefs", "Lang", "fr")
      SaveSetting("ThermoPi", "Prefs", "DateFormat", "fr")
    Else
      SaveSetting("ThermoPi", "Prefs", "Lang", "en")
      SaveSetting("ThermoPi", "Prefs", "DateFormat", "en")
    End If
    Me.Close()
  End Sub

  Private Sub FrmLang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If System.Globalization.CultureInfo.CurrentCulture.Parent.ToString = "fr" Then
      RbFlagFr.Checked = True
    Else
      RbFlagEn.Checked = True
    End If
  End Sub

End Class