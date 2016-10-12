<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe13_02
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
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.lblCurrent = New System.Windows.Forms.Label
        Me.lblHandle = New System.Windows.Forms.Label
        Me.lblCaption = New System.Windows.Forms.Label
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(17, 174)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(164, 17)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Is this window active?"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(17, 116)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(244, 17)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Handle of current active window:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(17, 50)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(248, 17)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Caption of current active window:"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(17, 190)
        Me.lblCurrent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(30, 17)
        Me.lblCurrent.TabIndex = 13
        Me.lblCurrent.Text = "null"
        '
        'lblHandle
        '
        Me.lblHandle.AutoSize = True
        Me.lblHandle.Location = New System.Drawing.Point(17, 132)
        Me.lblHandle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHandle.Name = "lblHandle"
        Me.lblHandle.Size = New System.Drawing.Size(30, 17)
        Me.lblHandle.TabIndex = 12
        Me.lblHandle.Text = "null"
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(17, 66)
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(30, 17)
        Me.lblCaption.TabIndex = 11
        Me.lblCaption.Text = "null"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        '
        'ActiveWindowInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 257)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblHandle)
        Me.Controls.Add(Me.lblCaption)
        Me.Name = "ActiveWindowInfo"
        Me.Text = "ActiveWindowInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblCurrent As System.Windows.Forms.Label
    Private WithEvents lblHandle As System.Windows.Forms.Label
    Private WithEvents lblCaption As System.Windows.Forms.Label
    Private WithEvents tmrRefresh As System.Windows.Forms.Timer

End Class
