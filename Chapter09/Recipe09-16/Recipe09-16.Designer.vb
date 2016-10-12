<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_16
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
        Me.components = New System.ComponentModel.Container
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        Me.errProvider.DataMember = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(76, 21)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(220, 22)
        Me.txtEmail.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 24)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "OK"
        '
        'Recipe09_16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 126)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Recipe09_16"
        Me.Text = "Recipe09-16"
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents errProvider As System.Windows.Forms.ErrorProvider
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button

End Class
