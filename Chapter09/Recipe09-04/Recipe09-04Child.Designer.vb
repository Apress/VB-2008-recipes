<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_04Child
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
        Me.lblFormName = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.Location = New System.Drawing.Point(179, 37)
        Me.lblFormName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(0, 17)
        Me.lblFormName.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(196, 261)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(92, 37)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(85, 17)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Form Name:"
        '
        'Recipe09_04Child
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 327)
        Me.Controls.Add(Me.lblFormName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.label1)
        Me.Name = "Recipe09_04Child"
        Me.Text = "Recipe09-04Child"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblFormName As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
