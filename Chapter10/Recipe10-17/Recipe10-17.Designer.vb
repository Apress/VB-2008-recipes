<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe10_17
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
        Me.printPreviewControl = New System.Windows.Forms.PrintPreviewControl
        Me.lstZoom = New System.Windows.Forms.ListBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'printPreviewControl
        '
        Me.printPreviewControl.Location = New System.Drawing.Point(13, 13)
        Me.printPreviewControl.Margin = New System.Windows.Forms.Padding(4)
        Me.printPreviewControl.Name = "printPreviewControl"
        Me.printPreviewControl.Size = New System.Drawing.Size(328, 262)
        Me.printPreviewControl.TabIndex = 10
        '
        'lstZoom
        '
        Me.lstZoom.FormattingEnabled = True
        Me.lstZoom.ItemHeight = 16
        Me.lstZoom.Location = New System.Drawing.Point(349, 13)
        Me.lstZoom.Margin = New System.Windows.Forms.Padding(4)
        Me.lstZoom.Name = "lstZoom"
        Me.lstZoom.Size = New System.Drawing.Size(117, 260)
        Me.lstZoom.TabIndex = 9
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(177, 282)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(127, 28)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "Print Preview"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'Recipe10_17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 325)
        Me.Controls.Add(Me.printPreviewControl)
        Me.Controls.Add(Me.lstZoom)
        Me.Controls.Add(Me.cmdPrint)
        Me.Name = "Recipe10_17"
        Me.Text = "Print Preview"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents printPreviewControl As System.Windows.Forms.PrintPreviewControl
    Private WithEvents lstZoom As System.Windows.Forms.ListBox
    Private WithEvents cmdPrint As System.Windows.Forms.Button

End Class
