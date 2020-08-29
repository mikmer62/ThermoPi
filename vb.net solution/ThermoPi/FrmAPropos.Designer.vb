<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAPropos
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAPropos))
    Me.BtnOK = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblCopyright = New System.Windows.Forms.Label()
    Me.lblVersion = New System.Windows.Forms.Label()
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
    Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
    Me.SuspendLayout()
    '
    'BtnOK
    '
    resources.ApplyResources(Me.BtnOK, "BtnOK")
    Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.BtnOK.Name = "BtnOK"
    Me.BtnOK.UseVisualStyleBackColor = True
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'lblCopyright
    '
    resources.ApplyResources(Me.lblCopyright, "lblCopyright")
    Me.lblCopyright.Name = "lblCopyright"
    '
    'lblVersion
    '
    resources.ApplyResources(Me.lblVersion, "lblVersion")
    Me.lblVersion.Name = "lblVersion"
    '
    'LinkLabel1
    '
    resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.TabStop = True
    '
    'LinkLabel2
    '
    resources.ApplyResources(Me.LinkLabel2, "LinkLabel2")
    Me.LinkLabel2.Name = "LinkLabel2"
    Me.LinkLabel2.TabStop = True
    '
    'FrmAPropos
    '
    Me.AcceptButton = Me.BtnOK
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
    Me.CancelButton = Me.BtnOK
    Me.Controls.Add(Me.LinkLabel2)
    Me.Controls.Add(Me.LinkLabel1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lblCopyright)
    Me.Controls.Add(Me.lblVersion)
    Me.Controls.Add(Me.BtnOK)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmAPropos"
    Me.ShowInTaskbar = False
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BtnOK As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
