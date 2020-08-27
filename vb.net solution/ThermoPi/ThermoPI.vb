Imports System.IO
Imports System.Threading

Public Class ThermoPI

  <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
  Private Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
  End Function

  Public Structure Preferences
    Dim Lang As String
    Dim DateFormat As String
    Dim RaspSharedDir As String
    Dim Interval As Integer
    Dim DispFont As String
    Dim DispFontSize As Integer
    Dim DispFontStyle As FontStyle
    Dim DispOffsetH, DispOffsetV As Integer
    Dim DispForeColor1, DispForeColor2, DispForeColor3, DispForeColor4, DispForeColor5, DispForeColor6 As Color
    Dim DispBackColor1, DispBackColor2, DispBackColor3, DispBackColor4, DispBackColor5, DispBackColor6 As Color
  End Structure

  Public prefs As Preferences
  Dim sensor() As String
  Dim workdir As String
  Public RaspName As String


  '----- Mise à jour de la température / Update temperature

  Private Sub GetTemp()
    Dim fi As FileInfo
    Dim tempInt As Integer
    Dim tempDbl As Double
    Dim fontToUse As Font
    Dim brushToUse As Brush
    Dim g As Graphics
    Dim bitmapText As Bitmap
    Dim hIcon As IntPtr
    Dim readOK As Boolean

    With prefs
      If .RaspSharedDir <> "" Then
        fi = New FileInfo(.RaspSharedDir & "\ThermoPi.txt")
        If fi.Exists Then
          readOK = False
          'Lecture température dans fichier partagé par le Raspberry / Get temp in Raspberry shared file
          While readOK = False
            Using fs As New FileStream(.RaspSharedDir & "\ThermoPi.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
              Using sr As New StreamReader(fs)
                Try
                  sensor = sr.ReadLine.Split(";")
                  readOK = True
                Catch ex As Exception
                End Try
              End Using
            End Using
          End While
          'Température
          'Temperature
          tempInt = CInt(sensor(3).ToString.Substring(0, 2))
          tempDbl = CDbl(sensor(3).ToString) / 1000

          'Affichage nom du Raspberry + température exacte en tooltip / Display Raspberry name + exact temp in tooltip
          RaspName = sensor(0)
          NotifyIcon.Text = sensor(0) & "   " & sensor(2) & "   " & tempDbl.ToString("0.0°")

          'Affichage température dans la zone de notification / Display temp in notification area
          bitmapText = New Bitmap(16, 16)
            g = System.Drawing.Graphics.FromImage(bitmapText)
            fontToUse = New Font(.DispFont, .DispFontSize, .DispFontStyle, GraphicsUnit.Pixel)
            If tempInt <= 45 Then
              g.Clear(.DispBackColor1)
              brushToUse = New SolidBrush(.DispForeColor1)
            ElseIf tempInt <= 50 Then
              g.Clear(.DispBackColor2)
              brushToUse = New SolidBrush(.DispForeColor2)
            ElseIf tempInt <= 55 Then
              g.Clear(.DispBackColor3)
              brushToUse = New SolidBrush(.DispForeColor3)
            ElseIf tempInt <= 60 Then
              g.Clear(.DispBackColor4)
              brushToUse = New SolidBrush(.DispForeColor4)
            ElseIf tempInt <= 65 Then
              g.Clear(.DispBackColor5)
              brushToUse = New SolidBrush(.DispForeColor5)
            Else
              g.Clear(.DispBackColor6)
              brushToUse = New SolidBrush(.DispForeColor6)
            End If

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
            g.DrawString(tempInt, fontToUse, brushToUse, .DispOffsetH, .DispOffsetV)
            hIcon = bitmapText.GetHicon
            NotifyIcon.Icon = Icon.FromHandle(hIcon)
            DestroyIcon(hIcon)

            fontToUse.Dispose()
            brushToUse.Dispose()
            g.Dispose()
            bitmapText.Dispose()
          Else
            'Les fichiers d'échange n'existent pas ou ont été supprimés / Raspberry shared files doesnt exist or have been moved
            NotifyIcon.Text = "Fichiers Raspberry introuvables !"
          NotifyIcon.Icon = My.Resources.ThermoPi_Icon
        End If
      Else
        'Le dossier partagé n'existe pas ou a été supprimé / Raspberry shared dir doesnt exist or has been moved
        NotifyIcon.Text = "Dossier partagé introuvable !"
        NotifyIcon.Icon = My.Resources.ThermoPi_Icon
      End If
    End With
  End Sub


  '----- Préférences

  Public Sub GetPrefs()
    'Récupération des préférences / Load preferences
    With prefs
      'Langue / Language
      .Lang = GetSetting("ThermoPi", "Prefs", "Lang", Globalization.CultureInfo.CurrentCulture.Parent.ToString)

      'Format date / Date format
      .DateFormat = GetSetting("ThermoPi", "Prefs", "DateFormat", Globalization.CultureInfo.CurrentCulture.Parent.ToString)

      'Chemin du fichier température partagé par le Raspberry / Temp path of Raspberry shared file
      .RaspSharedDir = GetSetting("ThermoPi", "Prefs", "SharedDir", "\\Raspberry\ThermoPi")

      'Intervalle de mise à jour en secondes / Refresh interval in seconds
      .Interval = CInt(GetSetting("ThermoPi", "Prefs", "Interval", "3"))
      Timer.Interval = .Interval * 1000

      'Caractères
      .DispFont = GetSetting("ThermoPi", "Prefs", "Font", "Segoe UI")
      .DispFontSize = CInt(GetSetting("ThermoPi", "Prefs", "FontSize", "13"))
      If GetSetting("ThermoPi", "Prefs", "Bold", "True") = "True" Then
        .DispFontStyle = FontStyle.Bold
      Else
        .DispFontStyle = FontStyle.Regular
      End If
      .DispOffsetH = CInt(GetSetting("ThermoPi", "Prefs", "OffsetH", "-1"))
      .DispOffsetV = CInt(GetSetting("ThermoPi", "Prefs", "OffsetV", "-1"))

      'Couleurs
      .DispForeColor1 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexForeColor1", "#FF0000FF"))
      .DispBackColor1 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexBackColor1", "#FFFFFFFF"))

      .DispForeColor2 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexForeColor2", "#FF008000"))
      .DispBackColor2 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexBackColor2", "#FFFFFFFF"))

      .DispForeColor3 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexForeColor3", "#FFFFA500"))
      .DispBackColor3 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexBackColor3", "#FFFFFFFF"))

      .DispForeColor4 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexForeColor4", "#FFFF0000"))
      .DispBackColor4 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexBackColor4", "#FFFFFFFF"))

      .DispForeColor5 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexForeColor5", "#FFFFFFFF"))
      .DispBackColor5 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexBackColor5", "#FFFFA500"))

      .DispForeColor6 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexForeColor6", "#FFFFFFFF"))
      .DispBackColor6 = System.Drawing.ColorTranslator.FromHtml(GetSetting("ThermoPi", "Prefs", "HexBackColor6", "#FFFF0000"))
    End With
  End Sub


  '----- Menus

  Private Sub MnuAbout_Click(sender As Object, e As EventArgs) Handles MnuAbout.Click
    If FrmAPropos.Visible = False Then
      FrmAPropos.ShowDialog()
    Else
      FrmAPropos.BringToFront()
    End If
  End Sub

  Private Sub MnuHist_Click(sender As Object, e As EventArgs) Handles MnuHist.Click
    If FrmHist.Visible = False Then
      FrmHist.ShowDialog()
    Else
      FrmHist.BringToFront()
    End If
  End Sub

  Private Sub MnuPrefs_Click(sender As Object, e As EventArgs) Handles MnuPrefs.Click
    Dim oldLang As String

    oldLang = prefs.Lang

    If FrmPrefs.Visible = False Then
      FrmPrefs.ShowDialog()
    Else
      FrmPrefs.BringToFront()
    End If

    GetPrefs()

    If prefs.Lang <> oldLang Then
      If prefs.Lang = "fr" Then
        MessageBox.Show("ThermoPi doit quitter et redémarrer pour changer de langue !", "ThermoPi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Else
        MessageBox.Show("ThermoPi must quit and restart to apply new language !", "ThermoPi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If
      Application.Restart()
    End If
  End Sub


  Private Sub MnuQuit_Click(sender As Object, e As EventArgs) Handles MnuQuit.Click
    Application.Exit()
  End Sub

  Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
    getTemp()
  End Sub

  Private Sub ThermoPi_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim fi As FileInfo

    Me.Hide()

    fi = New FileInfo(Application.StartupPath & "\en\ThermoPi.resources.dll")
    If fi.Exists Then
      If GetSetting("ThermoPi", "Prefs", "Lang", "") = "" Then FrmLang.ShowDialog()
    End If

    GetPrefs()

    If prefs.Lang = "fr" Then
      Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("fr")
      Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("fr")
    Else
      Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en")
      Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en")
    End If

    InitializeComponent()

    Me.NotifyMenuStrip.Refresh()

    Timer.Enabled = True

    'Exécution initiale - est ensuite exécuté à intervalle défini par le timer / First call - call is then done regularly at interval defined by timer
    GetTemp()
  End Sub


End Class
