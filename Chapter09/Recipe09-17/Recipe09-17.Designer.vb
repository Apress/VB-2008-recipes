<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_17
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
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.AllowDrop = True
        Me.TextBox2.Location = New System.Drawing.Point(64, 174)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(260, 94)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "TextBox2"
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Location = New System.Drawing.Point(64, 59)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 94)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "TextBox1"
        '
        'Recipe09_16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 327)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Recipe09_16"
        Me.Text = "Recipe09-16"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
