<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_04
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
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnNewForm = New System.Windows.Forms.Button
        Me.txtFormName = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.listForms = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(129, 282)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(127, 30)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "&Refresh List"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnNewForm
        '
        Me.btnNewForm.Location = New System.Drawing.Point(267, 238)
        Me.btnNewForm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewForm.Name = "btnNewForm"
        Me.btnNewForm.Size = New System.Drawing.Size(105, 23)
        Me.btnNewForm.TabIndex = 18
        Me.btnNewForm.Text = "&New Form"
        Me.btnNewForm.UseVisualStyleBackColor = True
        '
        'txtFormName
        '
        Me.txtFormName.Location = New System.Drawing.Point(16, 238)
        Me.txtFormName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(225, 22)
        Me.txtFormName.TabIndex = 17
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 14)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 17)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Forms:"
        '
        'listForms
        '
        Me.listForms.FormattingEnabled = True
        Me.listForms.ItemHeight = 16
        Me.listForms.Location = New System.Drawing.Point(16, 33)
        Me.listForms.Margin = New System.Windows.Forms.Padding(4)
        Me.listForms.Name = "listForms"
        Me.listForms.Size = New System.Drawing.Size(356, 196)
        Me.listForms.TabIndex = 15
        '
        'Recipe09_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 327)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnNewForm)
        Me.Controls.Add(Me.txtFormName)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listForms)
        Me.Name = "Recipe09_04"
        Me.Text = "Recipe09-04"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnRefresh As System.Windows.Forms.Button
    Private WithEvents btnNewForm As System.Windows.Forms.Button
    Private WithEvents txtFormName As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents listForms As System.Windows.Forms.ListBox

End Class
