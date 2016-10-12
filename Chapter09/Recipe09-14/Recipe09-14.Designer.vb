<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_14
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
        Me.cmdClose = New System.Windows.Forms.Button
        Me.lblDrag = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(96, 201)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 30)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "Close"
        '
        'lblDrag
        '
        Me.lblDrag.BackColor = System.Drawing.Color.Navy
        Me.lblDrag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDrag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrag.ForeColor = System.Drawing.Color.White
        Me.lblDrag.Location = New System.Drawing.Point(87, 147)
        Me.lblDrag.Name = "lblDrag"
        Me.lblDrag.Size = New System.Drawing.Size(96, 36)
        Me.lblDrag.TabIndex = 10
        Me.lblDrag.Text = "Click here to move the form!"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 100)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "This form has a control-style border, but no maximize box, minimize box, control " & _
            "box, or text caption."
        '
        'Recipe09_14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 257)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblDrag)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Recipe09_14"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents lblDrag As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label

End Class
