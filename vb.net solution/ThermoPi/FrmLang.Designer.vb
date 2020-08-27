<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLang
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLang))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbFlagFr = New System.Windows.Forms.RadioButton()
        Me.RbFlagEn = New System.Windows.Forms.RadioButton()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbFlagFr)
        Me.Panel1.Controls.Add(Me.RbFlagEn)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 76)
        Me.Panel1.TabIndex = 65
        '
        'RbFlagFr
        '
        Me.RbFlagFr.AutoSize = True
        Me.RbFlagFr.Image = Global.ThermoPi.My.Resources.Resources.fr_flag_48
        Me.RbFlagFr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbFlagFr.Location = New System.Drawing.Point(43, 3)
        Me.RbFlagFr.Name = "RbFlagFr"
        Me.RbFlagFr.Size = New System.Drawing.Size(62, 31)
        Me.RbFlagFr.TabIndex = 62
        Me.RbFlagFr.TabStop = True
        Me.RbFlagFr.UseVisualStyleBackColor = True
        '
        'RbFlagEn
        '
        Me.RbFlagEn.AutoSize = True
        Me.RbFlagEn.Image = Global.ThermoPi.My.Resources.Resources.gb_flag_48
        Me.RbFlagEn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbFlagEn.Location = New System.Drawing.Point(43, 40)
        Me.RbFlagEn.Name = "RbFlagEn"
        Me.RbFlagEn.Size = New System.Drawing.Size(62, 34)
        Me.RbFlagEn.TabIndex = 63
        Me.RbFlagEn.TabStop = True
        Me.RbFlagEn.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(12, 104)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(149, 23)
        Me.BtnOK.TabIndex = 66
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'FrmLang
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(176, 142)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThermoPi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbFlagFr As RadioButton
    Friend WithEvents RbFlagEn As RadioButton
    Friend WithEvents BtnOK As Button
End Class
