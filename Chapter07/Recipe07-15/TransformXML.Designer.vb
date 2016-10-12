<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransformXml
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
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(0, 0)
        Me.Browser.Margin = New System.Windows.Forms.Padding(4)
        Me.Browser.MinimumSize = New System.Drawing.Size(27, 25)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(571, 421)
        Me.Browser.TabIndex = 2
        '
        'TransformXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 421)
        Me.Controls.Add(Me.Browser)
        Me.Name = "TransformXML"
        Me.Text = "TransformXml"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Browser As System.Windows.Forms.WebBrowser

End Class
