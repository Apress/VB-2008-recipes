<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_08
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
        Me.btnPinNumber = New System.Windows.Forms.Button
        Me.btnDate = New System.Windows.Forms.Button
        Me.btnUKPost = New System.Windows.Forms.Button
        Me.btnDecimal = New System.Windows.Forms.Button
        Me.btnUSZip = New System.Windows.Forms.Button
        Me.btnTime = New System.Windows.Forms.Button
        Me.lblActiveMask = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.mskTextBox = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'btnPinNumber
        '
        Me.btnPinNumber.Location = New System.Drawing.Point(262, 172)
        Me.btnPinNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPinNumber.Name = "btnPinNumber"
        Me.btnPinNumber.Size = New System.Drawing.Size(111, 28)
        Me.btnPinNumber.TabIndex = 29
        Me.btnPinNumber.Text = "Secret PIN"
        Me.btnPinNumber.UseVisualStyleBackColor = True
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(262, 117)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(111, 28)
        Me.btnDate.TabIndex = 28
        Me.btnDate.Text = "Short Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnUKPost
        '
        Me.btnUKPost.Location = New System.Drawing.Point(138, 172)
        Me.btnUKPost.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUKPost.Name = "btnUKPost"
        Me.btnUKPost.Size = New System.Drawing.Size(116, 28)
        Me.btnUKPost.TabIndex = 27
        Me.btnUKPost.Text = "UK Postcode"
        Me.btnUKPost.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Location = New System.Drawing.Point(138, 117)
        Me.btnDecimal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(116, 28)
        Me.btnDecimal.TabIndex = 26
        Me.btnDecimal.Text = "Decimal"
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'btnUSZip
        '
        Me.btnUSZip.Location = New System.Drawing.Point(19, 172)
        Me.btnUSZip.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUSZip.Name = "btnUSZip"
        Me.btnUSZip.Size = New System.Drawing.Size(111, 28)
        Me.btnUSZip.TabIndex = 25
        Me.btnUSZip.Text = "US ZIP"
        Me.btnUSZip.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Location = New System.Drawing.Point(19, 117)
        Me.btnTime.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(111, 28)
        Me.btnTime.TabIndex = 24
        Me.btnTime.Text = "24-hour time"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'lblActiveMask
        '
        Me.lblActiveMask.AutoSize = True
        Me.lblActiveMask.Location = New System.Drawing.Point(148, 40)
        Me.lblActiveMask.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActiveMask.Name = "lblActiveMask"
        Me.lblActiveMask.Size = New System.Drawing.Size(67, 17)
        Me.lblActiveMask.TabIndex = 23
        Me.lblActiveMask.Text = "Any input"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 40)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 17)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Active input mask:"
        '
        'mskTextBox
        '
        Me.mskTextBox.BeepOnError = True
        Me.mskTextBox.Location = New System.Drawing.Point(19, 62)
        Me.mskTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.mskTextBox.Name = "mskTextBox"
        Me.mskTextBox.Size = New System.Drawing.Size(352, 22)
        Me.mskTextBox.TabIndex = 21
        '
        'Recipe09_08
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 241)
        Me.Controls.Add(Me.btnPinNumber)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.btnUKPost)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnUSZip)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.lblActiveMask)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.mskTextBox)
        Me.Name = "Recipe09_08"
        Me.Text = "Recipe09-08"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnPinNumber As System.Windows.Forms.Button
    Private WithEvents btnDate As System.Windows.Forms.Button
    Private WithEvents btnUKPost As System.Windows.Forms.Button
    Private WithEvents btnDecimal As System.Windows.Forms.Button
    Private WithEvents btnUSZip As System.Windows.Forms.Button
    Private WithEvents btnTime As System.Windows.Forms.Button
    Private WithEvents lblActiveMask As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents mskTextBox As System.Windows.Forms.MaskedTextBox

End Class
