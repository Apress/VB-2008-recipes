<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_07
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
        Me.cmdTest = New System.Windows.Forms.Button
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(35, 242)
        Me.cmdTest.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(176, 34)
        Me.cmdTest.TabIndex = 5
        Me.cmdTest.Text = "Test Scroll"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 16
        Me.listBox1.Location = New System.Drawing.Point(30, 26)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(329, 196)
        Me.listBox1.TabIndex = 4
        '
        'Recipe09_07
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 303)
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.listBox1)
        Me.Name = "Recipe09_07"
        Me.Text = "Recipe09-07"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdTest As System.Windows.Forms.Button
    Private WithEvents listBox1 As System.Windows.Forms.ListBox

End Class
