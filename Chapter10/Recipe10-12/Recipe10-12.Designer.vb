<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe10_12
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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdOpen = New System.Windows.Forms.Button
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Location = New System.Drawing.Point(20, 28)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(376, 270)
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'cmdOpen
        '
        Me.cmdOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOpen.Location = New System.Drawing.Point(101, 306)
        Me.cmdOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(209, 28)
        Me.cmdOpen.TabIndex = 3
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'Recipe10_12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 362)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.cmdOpen)
        Me.Name = "Recipe10_12"
        Me.Text = "Show Movie"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents cmdOpen As System.Windows.Forms.Button

End Class
