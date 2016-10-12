<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_05Child
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
        Me.label = New System.Windows.Forms.Label
        Me.cmdShowAllWindows = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.Location = New System.Drawing.Point(26, 16)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(232, 24)
        Me.label.TabIndex = 5
        Me.label.Text = "label"
        '
        'cmdShowAllWindows
        '
        Me.cmdShowAllWindows.Location = New System.Drawing.Point(51, 64)
        Me.cmdShowAllWindows.Name = "cmdShowAllWindows"
        Me.cmdShowAllWindows.Size = New System.Drawing.Size(185, 43)
        Me.cmdShowAllWindows.TabIndex = 4
        Me.cmdShowAllWindows.Text = "Show Values From All Windows"
        '
        'Recipe09_05Child
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 122)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.cmdShowAllWindows)
        Me.Name = "Recipe09_05Child"
        Me.Text = "Recipe09-05Child"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label As System.Windows.Forms.Label
    Private WithEvents cmdShowAllWindows As System.Windows.Forms.Button

End Class
