<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirectoryTree
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
        Me.treeDirectory = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        '
        'treeDirectory
        '
        Me.treeDirectory.Location = New System.Drawing.Point(12, 12)
        Me.treeDirectory.Name = "treeDirectory"
        Me.treeDirectory.Size = New System.Drawing.Size(264, 344)
        Me.treeDirectory.TabIndex = 0
        '
        'DirectoryTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 368)
        Me.Controls.Add(Me.treeDirectory)
        Me.Name = "DirectoryTree"
        Me.Text = "DirectoryTree"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents treeDirectory As System.Windows.Forms.TreeView
End Class
