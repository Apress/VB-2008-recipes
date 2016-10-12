<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_13
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "This form has no border at all."
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(90, 191)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 28)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Exit"
        '
        'Recipe09_13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 257)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Recipe09_13"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
