<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe10_01
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
        Me.pnlFonts = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'pnlFonts
        '
        Me.pnlFonts.AutoScroll = True
        Me.pnlFonts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFonts.Location = New System.Drawing.Point(0, 0)
        Me.pnlFonts.Name = "pnlFonts"
        Me.pnlFonts.Size = New System.Drawing.Size(347, 309)
        Me.pnlFonts.TabIndex = 2
        '
        'Recipe10_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 309)
        Me.Controls.Add(Me.pnlFonts)
        Me.Name = "Recipe10_01"
        Me.Text = "List of Installed Fonts"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlFonts As System.Windows.Forms.Panel

End Class
