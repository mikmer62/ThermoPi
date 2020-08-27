<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrefs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrefs))
    Me.NumInterval = New System.Windows.Forms.NumericUpDown()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.BtnOK = New System.Windows.Forms.Button()
    Me.BtnBackColor5 = New System.Windows.Forms.Button()
    Me.BtnBackColor4 = New System.Windows.Forms.Button()
    Me.BtnBackColor3 = New System.Windows.Forms.Button()
    Me.BtnBackColor2 = New System.Windows.Forms.Button()
    Me.BtnBackColor1 = New System.Windows.Forms.Button()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.BtnForeColor5 = New System.Windows.Forms.Button()
    Me.BtnForeColor4 = New System.Windows.Forms.Button()
    Me.BtnForeColor3 = New System.Windows.Forms.Button()
    Me.BtnForeColor2 = New System.Windows.Forms.Button()
    Me.BtnForeColor1 = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.CboFonts = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.NumFontSize = New System.Windows.Forms.NumericUpDown()
    Me.ChkFontBold = New System.Windows.Forms.CheckBox()
    Me.picDisp1 = New System.Windows.Forms.PictureBox()
    Me.picDisp2 = New System.Windows.Forms.PictureBox()
    Me.picDisp3 = New System.Windows.Forms.PictureBox()
    Me.picDisp4 = New System.Windows.Forms.PictureBox()
    Me.picDisp5 = New System.Windows.Forms.PictureBox()
    Me.ColorDialog = New System.Windows.Forms.ColorDialog()
    Me.BtnDefaultFont = New System.Windows.Forms.Button()
    Me.BtnCancel = New System.Windows.Forms.Button()
    Me.BtnHistFile = New System.Windows.Forms.Button()
    Me.lblRaspSharedDir = New System.Windows.Forms.Label()
    Me.BtnBackColor6 = New System.Windows.Forms.Button()
    Me.BtnForeColor6 = New System.Windows.Forms.Button()
    Me.BtnOpenRaspSharedDir = New System.Windows.Forms.Button()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.NumDispOffsetH = New System.Windows.Forms.NumericUpDown()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.NumDispOffsetV = New System.Windows.Forms.NumericUpDown()
    Me.picDisp6 = New System.Windows.Forms.PictureBox()
    Me.BtnDefaultColor = New System.Windows.Forms.Button()
    Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
    Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RbJMA = New System.Windows.Forms.RadioButton()
        Me.RbMJA = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbFlagFr = New System.Windows.Forms.RadioButton()
        Me.RbFlagEn = New System.Windows.Forms.RadioButton()
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisp3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisp4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisp5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDispOffsetH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDispOffsetV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisp6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumInterval
        '
        Me.NumInterval.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.NumInterval, "NumInterval")
        Me.NumInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumInterval.Name = "NumInterval"
        Me.NumInterval.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'BtnOK
        '
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        resources.ApplyResources(Me.BtnOK, "BtnOK")
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnBackColor5
        '
        resources.ApplyResources(Me.BtnBackColor5, "BtnBackColor5")
        Me.BtnBackColor5.Name = "BtnBackColor5"
        Me.BtnBackColor5.UseVisualStyleBackColor = True
        '
        'BtnBackColor4
        '
        resources.ApplyResources(Me.BtnBackColor4, "BtnBackColor4")
        Me.BtnBackColor4.Name = "BtnBackColor4"
        Me.BtnBackColor4.UseVisualStyleBackColor = True
        '
        'BtnBackColor3
        '
        resources.ApplyResources(Me.BtnBackColor3, "BtnBackColor3")
        Me.BtnBackColor3.Name = "BtnBackColor3"
        Me.BtnBackColor3.UseVisualStyleBackColor = True
        '
        'BtnBackColor2
        '
        resources.ApplyResources(Me.BtnBackColor2, "BtnBackColor2")
        Me.BtnBackColor2.Name = "BtnBackColor2"
        Me.BtnBackColor2.UseVisualStyleBackColor = True
        '
        'BtnBackColor1
        '
        resources.ApplyResources(Me.BtnBackColor1, "BtnBackColor1")
        Me.BtnBackColor1.Name = "BtnBackColor1"
        Me.BtnBackColor1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'BtnForeColor5
        '
        resources.ApplyResources(Me.BtnForeColor5, "BtnForeColor5")
        Me.BtnForeColor5.Name = "BtnForeColor5"
        Me.BtnForeColor5.UseVisualStyleBackColor = True
        '
        'BtnForeColor4
        '
        resources.ApplyResources(Me.BtnForeColor4, "BtnForeColor4")
        Me.BtnForeColor4.Name = "BtnForeColor4"
        Me.BtnForeColor4.UseVisualStyleBackColor = True
        '
        'BtnForeColor3
        '
        resources.ApplyResources(Me.BtnForeColor3, "BtnForeColor3")
        Me.BtnForeColor3.Name = "BtnForeColor3"
        Me.BtnForeColor3.UseVisualStyleBackColor = True
        '
        'BtnForeColor2
        '
        resources.ApplyResources(Me.BtnForeColor2, "BtnForeColor2")
        Me.BtnForeColor2.Name = "BtnForeColor2"
        Me.BtnForeColor2.UseVisualStyleBackColor = True
        '
        'BtnForeColor1
        '
        resources.ApplyResources(Me.BtnForeColor1, "BtnForeColor1")
        Me.BtnForeColor1.Name = "BtnForeColor1"
        Me.BtnForeColor1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'CboFonts
        '
        Me.CboFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFonts.FormattingEnabled = True
        resources.ApplyResources(Me.CboFonts, "CboFonts")
        Me.CboFonts.Name = "CboFonts"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'NumFontSize
        '
        resources.ApplyResources(Me.NumFontSize, "NumFontSize")
        Me.NumFontSize.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.NumFontSize.Minimum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.NumFontSize.Name = "NumFontSize"
        Me.NumFontSize.TabStop = False
        Me.NumFontSize.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'ChkFontBold
        '
        resources.ApplyResources(Me.ChkFontBold, "ChkFontBold")
        Me.ChkFontBold.Name = "ChkFontBold"
        Me.ChkFontBold.UseVisualStyleBackColor = True
        '
        'picDisp1
        '
        resources.ApplyResources(Me.picDisp1, "picDisp1")
        Me.picDisp1.Name = "picDisp1"
        Me.picDisp1.TabStop = False
        '
        'picDisp2
        '
        resources.ApplyResources(Me.picDisp2, "picDisp2")
        Me.picDisp2.Name = "picDisp2"
        Me.picDisp2.TabStop = False
        '
        'picDisp3
        '
        resources.ApplyResources(Me.picDisp3, "picDisp3")
        Me.picDisp3.Name = "picDisp3"
        Me.picDisp3.TabStop = False
        '
        'picDisp4
        '
        resources.ApplyResources(Me.picDisp4, "picDisp4")
        Me.picDisp4.Name = "picDisp4"
        Me.picDisp4.TabStop = False
        '
        'picDisp5
        '
        resources.ApplyResources(Me.picDisp5, "picDisp5")
        Me.picDisp5.Name = "picDisp5"
        Me.picDisp5.TabStop = False
        '
        'BtnDefaultFont
        '
        resources.ApplyResources(Me.BtnDefaultFont, "BtnDefaultFont")
        Me.BtnDefaultFont.Name = "BtnDefaultFont"
        Me.BtnDefaultFont.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnHistFile
        '
        resources.ApplyResources(Me.BtnHistFile, "BtnHistFile")
        Me.BtnHistFile.Name = "BtnHistFile"
        Me.BtnHistFile.UseVisualStyleBackColor = True
        '
        'lblRaspSharedDir
        '
        Me.lblRaspSharedDir.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.lblRaspSharedDir, "lblRaspSharedDir")
        Me.lblRaspSharedDir.Name = "lblRaspSharedDir"
        '
        'BtnBackColor6
        '
        resources.ApplyResources(Me.BtnBackColor6, "BtnBackColor6")
        Me.BtnBackColor6.Name = "BtnBackColor6"
        Me.BtnBackColor6.UseVisualStyleBackColor = True
        '
        'BtnForeColor6
        '
        resources.ApplyResources(Me.BtnForeColor6, "BtnForeColor6")
        Me.BtnForeColor6.Name = "BtnForeColor6"
        Me.BtnForeColor6.UseVisualStyleBackColor = True
        '
        'BtnOpenRaspSharedDir
        '
        resources.ApplyResources(Me.BtnOpenRaspSharedDir, "BtnOpenRaspSharedDir")
        Me.BtnOpenRaspSharedDir.Name = "BtnOpenRaspSharedDir"
        Me.BtnOpenRaspSharedDir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'NumDispOffsetH
        '
        resources.ApplyResources(Me.NumDispOffsetH, "NumDispOffsetH")
        Me.NumDispOffsetH.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumDispOffsetH.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.NumDispOffsetH.Name = "NumDispOffsetH"
        Me.NumDispOffsetH.TabStop = False
        Me.NumDispOffsetH.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'NumDispOffsetV
        '
        resources.ApplyResources(Me.NumDispOffsetV, "NumDispOffsetV")
        Me.NumDispOffsetV.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumDispOffsetV.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.NumDispOffsetV.Name = "NumDispOffsetV"
        Me.NumDispOffsetV.TabStop = False
        Me.NumDispOffsetV.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'picDisp6
        '
        resources.ApplyResources(Me.picDisp6, "picDisp6")
        Me.picDisp6.Name = "picDisp6"
        Me.picDisp6.TabStop = False
        '
        'BtnDefaultColor
        '
        resources.ApplyResources(Me.BtnDefaultColor, "BtnDefaultColor")
        Me.BtnDefaultColor.Name = "BtnDefaultColor"
        Me.BtnDefaultColor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.CboFonts)
        Me.GroupBox1.Controls.Add(Me.ChkFontBold)
        Me.GroupBox1.Controls.Add(Me.NumFontSize)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.picDisp6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NumDispOffsetV)
        Me.GroupBox1.Controls.Add(Me.BtnForeColor1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BtnForeColor2)
        Me.GroupBox1.Controls.Add(Me.NumDispOffsetH)
        Me.GroupBox1.Controls.Add(Me.BtnForeColor3)
        Me.GroupBox1.Controls.Add(Me.BtnForeColor4)
        Me.GroupBox1.Controls.Add(Me.BtnBackColor6)
        Me.GroupBox1.Controls.Add(Me.BtnForeColor5)
        Me.GroupBox1.Controls.Add(Me.BtnForeColor6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BtnBackColor1)
        Me.GroupBox1.Controls.Add(Me.BtnBackColor2)
        Me.GroupBox1.Controls.Add(Me.BtnBackColor3)
        Me.GroupBox1.Controls.Add(Me.BtnBackColor4)
        Me.GroupBox1.Controls.Add(Me.picDisp5)
        Me.GroupBox1.Controls.Add(Me.BtnBackColor5)
        Me.GroupBox1.Controls.Add(Me.picDisp4)
        Me.GroupBox1.Controls.Add(Me.picDisp1)
        Me.GroupBox1.Controls.Add(Me.picDisp3)
        Me.GroupBox1.Controls.Add(Me.picDisp2)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.NumInterval)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblRaspSharedDir)
        Me.GroupBox2.Controls.Add(Me.BtnHistFile)
        Me.GroupBox2.Controls.Add(Me.BtnOpenRaspSharedDir)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.RbJMA)
        Me.Panel2.Controls.Add(Me.RbMJA)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'RbJMA
        '
        resources.ApplyResources(Me.RbJMA, "RbJMA")
        Me.RbJMA.Name = "RbJMA"
        Me.RbJMA.TabStop = True
        Me.RbJMA.UseVisualStyleBackColor = True
        '
        'RbMJA
        '
        resources.ApplyResources(Me.RbMJA, "RbMJA")
        Me.RbMJA.Name = "RbMJA"
        Me.RbMJA.TabStop = True
        Me.RbMJA.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbFlagFr)
        Me.Panel1.Controls.Add(Me.RbFlagEn)
        Me.Panel1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'RbFlagFr
        '
        resources.ApplyResources(Me.RbFlagFr, "RbFlagFr")
        Me.RbFlagFr.Image = Global.ThermoPi.My.Resources.Resources.fr_flag_48
        Me.RbFlagFr.Name = "RbFlagFr"
        Me.RbFlagFr.TabStop = True
        Me.RbFlagFr.UseVisualStyleBackColor = True
        '
        'RbFlagEn
        '
        resources.ApplyResources(Me.RbFlagEn, "RbFlagEn")
        Me.RbFlagEn.Image = Global.ThermoPi.My.Resources.Resources.gb_flag_48
        Me.RbFlagEn.Name = "RbFlagEn"
        Me.RbFlagEn.TabStop = True
        Me.RbFlagEn.UseVisualStyleBackColor = True
        '
        'FrmPrefs
        '
        Me.AcceptButton = Me.BtnOK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CancelButton = Me.BtnCancel
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnDefaultColor)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnDefaultFont)
        Me.Controls.Add(Me.BtnOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPrefs"
        Me.ShowInTaskbar = False
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisp3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisp4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisp5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDispOffsetH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDispOffsetV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisp6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NumInterval As NumericUpDown
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents BtnOK As Button
  Friend WithEvents BtnBackColor5 As Button
  Friend WithEvents BtnBackColor4 As Button
  Friend WithEvents BtnBackColor3 As Button
  Friend WithEvents BtnBackColor2 As Button
  Friend WithEvents BtnBackColor1 As Button
  Friend WithEvents Label8 As Label
  Friend WithEvents BtnForeColor5 As Button
  Friend WithEvents BtnForeColor4 As Button
  Friend WithEvents BtnForeColor3 As Button
  Friend WithEvents BtnForeColor2 As Button
  Friend WithEvents BtnForeColor1 As Button
  Friend WithEvents Label7 As Label
  Friend WithEvents CboFonts As ComboBox
  Friend WithEvents Label6 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents NumFontSize As NumericUpDown
  Friend WithEvents ChkFontBold As CheckBox
  Friend WithEvents picDisp1 As PictureBox
  Friend WithEvents picDisp2 As PictureBox
  Friend WithEvents picDisp3 As PictureBox
  Friend WithEvents picDisp4 As PictureBox
  Friend WithEvents picDisp5 As PictureBox
  Friend WithEvents ColorDialog As ColorDialog
  Friend WithEvents BtnDefaultFont As Button
  Friend WithEvents BtnCancel As Button
  Friend WithEvents BtnHistFile As Button
  Friend WithEvents lblRaspSharedDir As Label
  Friend WithEvents BtnBackColor6 As Button
  Friend WithEvents BtnForeColor6 As Button
  Friend WithEvents BtnOpenRaspSharedDir As Button
  Friend WithEvents Label10 As Label
  Friend WithEvents NumDispOffsetH As NumericUpDown
  Friend WithEvents Label11 As Label
  Friend WithEvents NumDispOffsetV As NumericUpDown
  Friend WithEvents picDisp6 As PictureBox
  Friend WithEvents BtnDefaultColor As Button
  Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
  Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbFlagEn As RadioButton
    Friend WithEvents RbFlagFr As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents RbJMA As RadioButton
    Friend WithEvents RbMJA As RadioButton
    Friend WithEvents Panel1 As Panel
End Class
