<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThermoPI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThermoPI))
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuHist = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuPrefs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.NotifyMenuStrip
        resources.ApplyResources(Me.NotifyIcon, "NotifyIcon")
        '
        'NotifyMenuStrip
        '
        Me.NotifyMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuAbout, Me.ToolStripMenuItem3, Me.MnuHist, Me.ToolStripMenuItem2, Me.MnuPrefs, Me.ToolStripMenuItem1, Me.MnuQuit})
        Me.NotifyMenuStrip.Name = "NotifyMenuStrip"
        resources.ApplyResources(Me.NotifyMenuStrip, "NotifyMenuStrip")
        '
        'MnuAbout
        '
        Me.MnuAbout.Name = "MnuAbout"
        resources.ApplyResources(Me.MnuAbout, "MnuAbout")
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        '
        'MnuHist
        '
        Me.MnuHist.Name = "MnuHist"
        resources.ApplyResources(Me.MnuHist, "MnuHist")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'MnuPrefs
        '
        Me.MnuPrefs.Name = "MnuPrefs"
        resources.ApplyResources(Me.MnuPrefs, "MnuPrefs")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'MnuQuit
        '
        Me.MnuQuit.Name = "MnuQuit"
        resources.ApplyResources(Me.MnuQuit, "MnuQuit")
        '
        'Timer
        '
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ThermoPI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThermoPI"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.NotifyMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents NotifyMenuStrip As ContextMenuStrip
    Friend WithEvents MnuHist As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents MnuPrefs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents MnuQuit As ToolStripMenuItem
    Friend WithEvents Timer As Timer
    Friend WithEvents MnuAbout As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents Label1 As Label
End Class
