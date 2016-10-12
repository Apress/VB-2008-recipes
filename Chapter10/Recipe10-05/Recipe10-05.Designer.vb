<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe10_05
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
        Me.panel1 = New System.Windows.Forms.Panel
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.AutoScroll = True
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Location = New System.Drawing.Point(13, 13)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(357, 297)
        Me.panel1.TabIndex = 3
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(148, 177)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'Recipe10_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 326)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Recipe10_05"
        Me.Text = "Scrollable Image"
        Me.panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox

End Class
