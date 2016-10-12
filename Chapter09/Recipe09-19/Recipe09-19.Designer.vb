<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_19
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
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.label1 = New System.Windows.Forms.Label
        Me.textURL = New System.Windows.Forms.TextBox
        Me.goButton = New System.Windows.Forms.Button
        Me.backButton = New System.Windows.Forms.Button
        Me.homeButton = New System.Windows.Forms.Button
        Me.forwardButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top
        Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser1.Margin = New System.Windows.Forms.Padding(4)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(739, 250)
        Me.webBrowser1.TabIndex = 11
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(207, 277)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 23)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Go to:"
        '
        'textURL
        '
        Me.textURL.Location = New System.Drawing.Point(256, 274)
        Me.textURL.Margin = New System.Windows.Forms.Padding(4)
        Me.textURL.Name = "textURL"
        Me.textURL.Size = New System.Drawing.Size(180, 22)
        Me.textURL.TabIndex = 13
        Me.textURL.Text = "http://www.apress.com"
        '
        'goButton
        '
        Me.goButton.Location = New System.Drawing.Point(444, 274)
        Me.goButton.Margin = New System.Windows.Forms.Padding(4)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(75, 23)
        Me.goButton.TabIndex = 14
        Me.goButton.Text = "Go"
        '
        'backButton
        '
        Me.backButton.Enabled = False
        Me.backButton.Location = New System.Drawing.Point(225, 305)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 23)
        Me.backButton.TabIndex = 15
        Me.backButton.Text = "<< Back"
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(308, 305)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(75, 23)
        Me.homeButton.TabIndex = 16
        Me.homeButton.Text = "Home"
        '
        'forwardButton
        '
        Me.forwardButton.Enabled = False
        Me.forwardButton.Location = New System.Drawing.Point(391, 305)
        Me.forwardButton.Margin = New System.Windows.Forms.Padding(4)
        Me.forwardButton.Name = "forwardButton"
        Me.forwardButton.Size = New System.Drawing.Size(75, 23)
        Me.forwardButton.TabIndex = 17
        Me.forwardButton.Text = "Forward >>"
        '
        'Recipe09_19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 341)
        Me.Controls.Add(Me.forwardButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.goButton)
        Me.Controls.Add(Me.textURL)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.webBrowser1)
        Me.Name = "Recipe09_19"
        Me.Text = "Recipe09-19"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents textURL As System.Windows.Forms.TextBox
    Private WithEvents goButton As System.Windows.Forms.Button
    Private WithEvents backButton As System.Windows.Forms.Button
    Private WithEvents homeButton As System.Windows.Forms.Button
    Private WithEvents forwardButton As System.Windows.Forms.Button

End Class
