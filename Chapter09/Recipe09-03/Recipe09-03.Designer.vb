<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_03
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
        Me.cmdProcessAll = New System.Windows.Forms.Button
        Me.textBox4 = New System.Windows.Forms.TextBox
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmdProcessAll
        '
        Me.cmdProcessAll.Location = New System.Drawing.Point(24, 218)
        Me.cmdProcessAll.Name = "cmdProcessAll"
        Me.cmdProcessAll.Size = New System.Drawing.Size(116, 28)
        Me.cmdProcessAll.TabIndex = 14
        Me.cmdProcessAll.Text = "Process Text Boxes"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(20, 110)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(252, 22)
        Me.textBox4.TabIndex = 13
        Me.textBox4.Text = "textBox4"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(20, 78)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(252, 22)
        Me.textBox3.TabIndex = 12
        Me.textBox3.Text = "textBox3"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(20, 46)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(252, 22)
        Me.textBox2.TabIndex = 11
        Me.textBox2.Text = "textBox2"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(20, 14)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(252, 22)
        Me.textBox1.TabIndex = 10
        Me.textBox1.Text = "textBox1"
        '
        'Recipe09_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 260)
        Me.Controls.Add(Me.cmdProcessAll)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Recipe09_03"
        Me.Text = "Recipe09-03"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cmdProcessAll As System.Windows.Forms.Button
    Private WithEvents textBox4 As System.Windows.Forms.TextBox
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox

End Class
