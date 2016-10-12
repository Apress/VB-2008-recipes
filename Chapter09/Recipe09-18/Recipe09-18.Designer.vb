<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_18
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
        Me.helpProvider1 = New System.Windows.Forms.HelpProvider
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'helpProvider1
        '
        Me.helpProvider1.HelpNamespace = "C:\WINDOWS\Help\common.chm"
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(267, 51)
        Me.checkBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(98, 21)
        Me.checkBox1.TabIndex = 5
        Me.checkBox1.Text = "checkBox1"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 16
        Me.listBox1.Location = New System.Drawing.Point(24, 22)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(205, 164)
        Me.listBox1.TabIndex = 4
        '
        'Recipe09_18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 208)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.listBox1)
        Me.helpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Name = "Recipe09_18"
        Me.helpProvider1.SetShowHelp(Me, True)
        Me.Text = "Recipe09-18"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents helpProvider1 As System.Windows.Forms.HelpProvider
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents listBox1 As System.Windows.Forms.ListBox

End Class
