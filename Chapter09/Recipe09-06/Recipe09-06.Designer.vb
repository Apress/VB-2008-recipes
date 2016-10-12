<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_06
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
        Me.greenButton = New System.Windows.Forms.Button
        Me.blueButton = New System.Windows.Forms.Button
        Me.redButton = New System.Windows.Forms.Button
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'greenButton
        '
        Me.greenButton.ForeColor = System.Drawing.Color.Green
        Me.greenButton.Location = New System.Drawing.Point(273, 284)
        Me.greenButton.Margin = New System.Windows.Forms.Padding(4)
        Me.greenButton.Name = "greenButton"
        Me.greenButton.Size = New System.Drawing.Size(100, 28)
        Me.greenButton.TabIndex = 11
        Me.greenButton.Text = "Green"
        '
        'blueButton
        '
        Me.blueButton.ForeColor = System.Drawing.Color.Blue
        Me.blueButton.Location = New System.Drawing.Point(144, 284)
        Me.blueButton.Margin = New System.Windows.Forms.Padding(4)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(100, 28)
        Me.blueButton.TabIndex = 10
        Me.blueButton.Text = "Blue"
        '
        'redButton
        '
        Me.redButton.ForeColor = System.Drawing.Color.Red
        Me.redButton.Location = New System.Drawing.Point(16, 284)
        Me.redButton.Margin = New System.Windows.Forms.Padding(4)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(100, 28)
        Me.redButton.TabIndex = 8
        Me.redButton.Text = "Red"
        '
        'textBox1
        '
        Me.textBox1.BackColor = Global.Apress.VisualBasicRecipes.Chapter09.My.MySettings.Default.Color
        Me.textBox1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Apress.VisualBasicRecipes.Chapter09.My.MySettings.Default, "Color", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.textBox1.Location = New System.Drawing.Point(16, 15)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(356, 261)
        Me.textBox1.TabIndex = 9
        Me.textBox1.Text = "This recipe demonstrates the use of .NET 2.0 Application Settings."
        '
        'Recipe09_06
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 327)
        Me.Controls.Add(Me.greenButton)
        Me.Controls.Add(Me.blueButton)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.redButton)
        Me.Name = "Recipe09_06"
        Me.Text = "Recipe09-06"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents greenButton As System.Windows.Forms.Button
    Private WithEvents blueButton As System.Windows.Forms.Button
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents redButton As System.Windows.Forms.Button

End Class
