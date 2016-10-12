<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_15
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.timer = New System.Timers.Timer
        CType(Me.timer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'notifyIcon
        '
        Me.notifyIcon.Text = "notifyIcon1"
        Me.notifyIcon.Visible = True
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.SynchronizingObject = Me
        '
        'Recipe09_15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 214)
        Me.Name = "Recipe09_15"
        Me.Text = "Recipe09-15"
        CType(Me.timer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents notifyIcon As System.Windows.Forms.NotifyIcon
    Private WithEvents timer As System.Timers.Timer

End Class
