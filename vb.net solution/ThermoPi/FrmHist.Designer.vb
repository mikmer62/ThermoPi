<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHist))
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.LvHist = New System.Windows.Forms.ListView()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.lblRaspName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        resources.ApplyResources(Me.BtnOK, "BtnOK")
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'LvHist
        '
        Me.LvHist.FullRowSelect = True
        Me.LvHist.GridLines = True
        Me.LvHist.HideSelection = False
        resources.ApplyResources(Me.LvHist, "LvHist")
        Me.LvHist.MultiSelect = False
        Me.LvHist.Name = "LvHist"
        Me.LvHist.UseCompatibleStateImageBehavior = False
        Me.LvHist.View = System.Windows.Forms.View.Details
        '
        'BtnRefresh
        '
        resources.ApplyResources(Me.BtnRefresh, "BtnRefresh")
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'lblRaspName
        '
        resources.ApplyResources(Me.lblRaspName, "lblRaspName")
        Me.lblRaspName.Name = "lblRaspName"
        '
        'FrmHist
        '
        Me.AcceptButton = Me.BtnOK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CancelButton = Me.BtnOK
        Me.Controls.Add(Me.lblRaspName)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.LvHist)
        Me.Controls.Add(Me.BtnOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHist"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents LvHist As ListView
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents lblRaspName As Label
End Class
