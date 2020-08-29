Imports System.IO
Imports System.Drawing

Public Class FrmPrefs

  Dim newPrefs As ThermoPI.Preferences

  Private Sub ChkLaunchAtStartup_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLaunchAtStartup.CheckedChanged
    newPrefs.StartupLaunch = ChkLaunchAtStartup.Checked
  End Sub

  Private Sub RbFlagFr_CheckedChanged(sender As Object, e As EventArgs) Handles RbFlagFr.CheckedChanged
    If RbFlagFr.Checked Then
      newPrefs.Lang = "fr"
      RbJMA.Checked = True
    Else
      newPrefs.Lang = "en"
    End If
  End Sub

  Private Sub RbFlagEn_CheckedChanged(sender As Object, e As EventArgs) Handles RbFlagEn.CheckedChanged
    If RbFlagEn.Checked Then
      newPrefs.Lang = "en"
      RbMJA.Checked = True
    Else
      newPrefs.Lang = "fr"
    End If
  End Sub

  Private Sub RbJMA_CheckedChanged(sender As Object, e As EventArgs) Handles RbJMA.CheckedChanged
    If RbJMA.Checked Then
      newPrefs.DateFormat = "fr"
    Else
      newPrefs.DateFormat = "en"
    End If
  End Sub

  Private Sub RbMJA_CheckedChanged(sender As Object, e As EventArgs) Handles RbMJA.CheckedChanged
    If RbMJA.Checked Then
      newPrefs.DateFormat = "en"
    Else
      newPrefs.DateFormat = "fr"
    End If
  End Sub

  Private Sub BtnOpenRaspSharedDir_Click(sender As Object, e As EventArgs) Handles BtnOpenRaspSharedDir.Click
    Process.Start("explorer.exe", newPrefs.RaspSharedDir)
  End Sub

  Private Sub BtnHistFile_Click(sender As Object, e As EventArgs) Handles BtnHistFile.Click
    FolderBrowserDialog.SelectedPath = newPrefs.RaspSharedDir
    If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
      newPrefs.RaspSharedDir = FolderBrowserDialog.SelectedPath
      lblRaspSharedDir.Text = FolderBrowserDialog.SelectedPath
    End If
  End Sub

  Private Sub NumInterval_ValueChanged(sender As Object, e As EventArgs) Handles NumInterval.ValueChanged
    newPrefs.Interval = NumInterval.Value
  End Sub

  Private Sub CboFonts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFonts.SelectedIndexChanged
    newPrefs.DispFont = CboFonts.Text
    drawText()
  End Sub

  Private Sub NumFontSize_ValueChanged(sender As Object, e As EventArgs) Handles NumFontSize.ValueChanged
    newPrefs.DispFontSize = NumFontSize.Value
    drawText()
  End Sub

  Private Sub ChkFontBold_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFontBold.CheckedChanged
    If ChkFontBold.Checked Then
      newPrefs.DispFontStyle = FontStyle.Bold
    Else
      newPrefs.DispFontStyle = FontStyle.Regular
    End If
    drawText()
  End Sub

  Private Sub NumDispOffsetH_ValueChanged(sender As Object, e As EventArgs) Handles NumDispOffsetH.ValueChanged
    newPrefs.DispOffsetH = NumDispOffsetH.Value
    drawText()
  End Sub

  Private Sub NumDispOffsetV_ValueChanged(sender As Object, e As EventArgs) Handles NumDispOffsetV.ValueChanged
    newPrefs.DispOffsetV = NumDispOffsetV.Value
    drawText()
  End Sub

  Private Sub BtnForeColor1_Click(sender As Object, e As EventArgs) Handles BtnForeColor1.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispForeColor1 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnBackColor1_Click(sender As Object, e As EventArgs) Handles BtnBackColor1.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispBackColor1 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnForeColor2_Click(sender As Object, e As EventArgs) Handles BtnForeColor2.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispForeColor2 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnBackColor2_Click(sender As Object, e As EventArgs) Handles BtnBackColor2.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispBackColor2 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnForeColor3_Click(sender As Object, e As EventArgs) Handles BtnForeColor3.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispForeColor3 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnBackColor3_Click(sender As Object, e As EventArgs) Handles BtnBackColor3.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispBackColor3 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnForeColor4_Click(sender As Object, e As EventArgs) Handles BtnForeColor4.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispForeColor4 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnBackColor4_Click(sender As Object, e As EventArgs) Handles BtnBackColor4.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispBackColor4 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnForeColor5_Click(sender As Object, e As EventArgs) Handles BtnForeColor5.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispForeColor5 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnBackColor5_Click(sender As Object, e As EventArgs) Handles BtnBackColor5.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispBackColor5 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnForeColor6_Click(sender As Object, e As EventArgs) Handles BtnForeColor6.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispForeColor6 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnBackColor6_Click(sender As Object, e As EventArgs) Handles BtnBackColor6.Click
    If ColorDialog.ShowDialog = DialogResult.OK Then
      newPrefs.DispBackColor6 = ColorDialog.Color
      drawText()
    End If
  End Sub

  Private Sub BtnDefaultFont_Click(sender As Object, e As EventArgs) Handles BtnDefaultFont.Click
    With newPrefs
      .DispFont = "Segoe UI"
      CboFonts.Text = .DispFont
      .DispFontSize = 13
      NumFontSize.Value = .DispFontSize
      .DispFontStyle = FontStyle.Bold
      ChkFontBold.Checked = True
      .DispOffsetH = -1
      NumDispOffsetH.Value = .DispOffsetH
      .DispOffsetV = -1
      NumDispOffsetV.Value = .DispOffsetV
    End With
    'drawText()
  End Sub

  Private Sub BtnDefaultColor_Click(sender As Object, e As EventArgs) Handles BtnDefaultColor.Click
    With newPrefs
      .DispForeColor1 = System.Drawing.ColorTranslator.FromHtml("#FF0000FF")
      .DispBackColor1 = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF")

      .DispForeColor2 = System.Drawing.ColorTranslator.FromHtml("#FF008000")
      .DispBackColor2 = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF")

      .DispForeColor3 = System.Drawing.ColorTranslator.FromHtml("#FFFFA500")
      .DispBackColor3 = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF")

      .DispForeColor4 = System.Drawing.ColorTranslator.FromHtml("#FFFF0000")
      .DispBackColor4 = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF")

      .DispForeColor5 = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF")
      .DispBackColor5 = System.Drawing.ColorTranslator.FromHtml("#FFFFA500")

      .DispForeColor6 = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF")
      .DispBackColor6 = System.Drawing.ColorTranslator.FromHtml("#FFFF0000")
    End With
    drawText()
  End Sub

  Private Sub DrawText()
    Dim fontToUse As Font
    Dim brushToUse As Brush
    Dim g As Graphics

    With newPrefs
      fontToUse = New Font(.DispFont, .DispFontSize, .DispFontStyle, GraphicsUnit.Pixel)

      'Affichage graphiques témoins / Display test areas
      picDisp1.Image = New Bitmap(16, 16)
      g = System.Drawing.Graphics.FromImage(picDisp1.Image)
      g.Clear(.DispBackColor1)
      brushToUse = New SolidBrush(.DispForeColor1)
      g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
      g.DrawString("41", fontToUse, brushToUse, .DispOffsetH, .DispOffsetV)
      brushToUse.Dispose()
      g.Dispose()

      picDisp2.Image = New Bitmap(16, 16)
      g = System.Drawing.Graphics.FromImage(picDisp2.Image)
      g.Clear(.DispBackColor2)
      brushToUse = New SolidBrush(.DispForeColor2)
      g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
      g.DrawString("48", fontToUse, brushToUse, .DispOffsetH, .DispOffsetV)
      brushToUse.Dispose()
      g.Dispose()

      picDisp3.Image = New Bitmap(16, 16)
      g = System.Drawing.Graphics.FromImage(picDisp3.Image)
      g.Clear(.DispBackColor3)
      brushToUse = New SolidBrush(.DispForeColor3)
      g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
      g.DrawString("52", fontToUse, brushToUse, .DispOffsetH, .DispOffsetV)
      brushToUse.Dispose()
      g.Dispose()

      picDisp4.Image = New Bitmap(16, 16)
      g = System.Drawing.Graphics.FromImage(picDisp4.Image)
      g.Clear(.DispBackColor4)
      brushToUse = New SolidBrush(.DispForeColor4)
      g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
      g.DrawString("58", fontToUse, brushToUse, .DispOffsetH, .DispOffsetV)
      brushToUse.Dispose()
      g.Dispose()

      picDisp5.Image = New Bitmap(16, 16)
      g = System.Drawing.Graphics.FromImage(picDisp5.Image)
      g.Clear(.DispBackColor5)
      brushToUse = New SolidBrush(.DispForeColor5)
      g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
      g.DrawString("61", fontToUse, brushToUse, .DispOffsetH, .DispOffsetV)
      brushToUse.Dispose()
      g.Dispose()

      picDisp6.Image = New Bitmap(16, 16)
      g = System.Drawing.Graphics.FromImage(picDisp6.Image)
      g.Clear(.DispBackColor6)
      brushToUse = New SolidBrush(.DispForeColor6)
      g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
      g.DrawString("67", fontToUse, brushToUse, .DispOffsetH, .DispOffsetV)
      brushToUse.Dispose()
      g.Dispose()

      fontToUse.Dispose()
    End With
  End Sub

  Private Function HexColor(col As Color) As String
    Return String.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", col.A, col.R, col.G, col.B)
  End Function

  Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
    Dim regkey As Microsoft.Win32.RegistryKey

    'Démarrage / Startup
    regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
    If newPrefs.StartupLaunch Then
      regkey.SetValue(My.Application.Info.AssemblyName, Application.ExecutablePath)
    Else
      regkey.DeleteValue(My.Application.Info.AssemblyName)
    End If
    SaveSetting("ThermoPi", "Prefs", "StartupLaunch", newPrefs.StartupLaunch.ToString)

    'Langue interface / User language
    SaveSetting("ThermoPi", "Prefs", "Lang", newPrefs.Lang)

    'Format date / Date format
    SaveSetting("ThermoPi", "Prefs", "DateFormat", newPrefs.DateFormat)

    'Répertoire partagé par le Raspberry / Raspberry shared dir
    SaveSetting("ThermoPi", "Prefs", "SharedDir", newPrefs.RaspSharedDir)

    'Intervalle de mise à jour en secondes / Update interval in seconds
    SaveSetting("ThermoPi", "Prefs", "Interval", newPrefs.Interval)

    'Caractères / Font
    SaveSetting("ThermoPi", "Prefs", "Font", newPrefs.DispFont)
    SaveSetting("ThermoPi", "Prefs", "FontSize", newPrefs.DispFontSize)
    If newPrefs.DispFontStyle = FontStyle.Bold Then
      SaveSetting("ThermoPi", "Prefs", "Bold", "True")
    Else
      SaveSetting("ThermoPi", "Prefs", "Bold", "False")
    End If

    SaveSetting("ThermoPi", "Prefs", "OffsetH", newPrefs.DispOffsetH)
    SaveSetting("ThermoPi", "Prefs", "OffsetV", newPrefs.DispOffsetV)

    'Couleurs / Colors
    SaveSetting("ThermoPi", "Prefs", "HexForeColor1", HexColor(newPrefs.DispForeColor1))
    SaveSetting("ThermoPi", "Prefs", "HexBackColor1", HexColor(newPrefs.DispBackColor1))

    SaveSetting("ThermoPi", "Prefs", "HexForeColor2", HexColor(newPrefs.DispForeColor2))
    SaveSetting("ThermoPi", "Prefs", "HexBackColor2", HexColor(newPrefs.DispBackColor2))

    SaveSetting("ThermoPi", "Prefs", "HexForeColor3", HexColor(newPrefs.DispForeColor3))
    SaveSetting("ThermoPi", "Prefs", "HexBackColor3", HexColor(newPrefs.DispBackColor3))

    SaveSetting("ThermoPi", "Prefs", "HexForeColor4", HexColor(newPrefs.DispForeColor4))
    SaveSetting("ThermoPi", "Prefs", "HexBackColor4", HexColor(newPrefs.DispBackColor4))

    SaveSetting("ThermoPi", "Prefs", "HexForeColor5", HexColor(newPrefs.DispForeColor5))
    SaveSetting("ThermoPi", "Prefs", "HexBackColor5", HexColor(newPrefs.DispBackColor5))

    SaveSetting("ThermoPi", "Prefs", "HexForeColor6", HexColor(newPrefs.DispForeColor6))
    SaveSetting("ThermoPi", "Prefs", "HexBackColor6", HexColor(newPrefs.DispBackColor6))

    Me.Close()
  End Sub

  Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    Me.Close()
  End Sub

  Private Sub FrmPrefs_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim fi As FileInfo
    Dim fonts As Text.InstalledFontCollection

    ChkLaunchAtStartup.Checked = ThermoPI.prefs.StartupLaunch
    newPrefs.StartupLaunch = ThermoPI.prefs.StartupLaunch

    fi = New FileInfo(Application.StartupPath & "\en\ThermoPi.resources.dll")
    If fi.Exists = False Then
      RbFlagEn.Enabled = False
    End If

    If ThermoPI.prefs.Lang = "fr" Then
      RbFlagFr.Checked = True
    Else
      RbFlagEn.Checked = True
    End If
    newPrefs.Lang = ThermoPI.prefs.Lang

    If ThermoPI.prefs.DateFormat = "fr" Then
      RbJMA.Checked = True
    Else
      RbMJA.Checked = True
    End If
    newPrefs.DateFormat = ThermoPI.prefs.DateFormat

    lblRaspSharedDir.Text = ThermoPI.prefs.RaspSharedDir
    newPrefs.RaspSharedDir = ThermoPI.prefs.RaspSharedDir

    NumInterval.Minimum = 1
    NumInterval.Maximum = 60
    NumInterval.Value = ThermoPI.prefs.Interval
    newPrefs.Interval = ThermoPI.prefs.Interval

    CboFonts.Items.Clear()
    fonts = New Text.InstalledFontCollection()
    For Each font As FontFamily In fonts.Families
      CboFonts.Items.Add(font.Name)
    Next font
    fonts.Dispose()
    CboFonts.Text = ThermoPI.prefs.DispFont
    newPrefs.DispFont = ThermoPI.prefs.DispFont

    NumFontSize.Minimum = 7
    NumFontSize.Maximum = 18
    NumFontSize.Value = ThermoPI.prefs.DispFontSize
    newPrefs.DispFontSize = ThermoPI.prefs.DispFontSize

    If ThermoPI.prefs.DispFontStyle = FontStyle.Bold Then
      ChkFontBold.Checked = True
    Else
      ChkFontBold.Checked = False
    End If
    newPrefs.DispFontStyle = ThermoPI.prefs.DispFontStyle

    NumDispOffsetH.Minimum = -5
    NumDispOffsetH.Maximum = 5
    NumDispOffsetH.Value = ThermoPI.prefs.DispOffsetH
    newPrefs.DispOffsetH = ThermoPI.prefs.DispOffsetH

    NumDispOffsetV.Minimum = -5
    NumDispOffsetV.Maximum = 5
    NumDispOffsetV.Value = ThermoPI.prefs.DispOffsetV
    newPrefs.DispOffsetV = ThermoPI.prefs.DispOffsetV

    newPrefs.DispForeColor1 = ThermoPI.prefs.DispForeColor1
    newPrefs.DispBackColor1 = ThermoPI.prefs.DispBackColor1
    newPrefs.DispForeColor2 = ThermoPI.prefs.DispForeColor2
    newPrefs.DispBackColor2 = ThermoPI.prefs.DispBackColor2
    newPrefs.DispForeColor3 = ThermoPI.prefs.DispForeColor3
    newPrefs.DispBackColor3 = ThermoPI.prefs.DispBackColor3
    newPrefs.DispForeColor4 = ThermoPI.prefs.DispForeColor4
    newPrefs.DispBackColor4 = ThermoPI.prefs.DispBackColor4
    newPrefs.DispForeColor5 = ThermoPI.prefs.DispForeColor5
    newPrefs.DispBackColor5 = ThermoPI.prefs.DispBackColor5
    newPrefs.DispForeColor6 = ThermoPI.prefs.DispForeColor6
    newPrefs.DispBackColor6 = ThermoPI.prefs.DispBackColor6

    DrawText()
  End Sub


End Class