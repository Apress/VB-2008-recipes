<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe10_11
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
        Me.cmdOpen = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(113, 114)
        Me.cmdOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(100, 28)
        Me.cmdOpen.TabIndex = 2
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'Recipe10_11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 257)
        Me.Controls.Add(Me.cmdOpen)
        Me.Name = "Recipe10_11"
        Me.Text = "Play sound using Quartz"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdOpen As System.Windows.Forms.Button

End Class
