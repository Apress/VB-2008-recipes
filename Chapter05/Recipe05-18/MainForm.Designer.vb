<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.rtDoc = New System.Windows.Forms.RichTextBox
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtDoc
        '
        Me.rtDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtDoc.Location = New System.Drawing.Point(0, 28)
        Me.rtDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.rtDoc.Name = "rtDoc"
        Me.rtDoc.Size = New System.Drawing.Size(415, 278)
        Me.rtDoc.TabIndex = 3
        Me.rtDoc.Text = ""
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(415, 28)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.toolStripSeparator, Me.mnuSave, Me.toolStripSeparator1, Me.mnuExit})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = CType(resources.GetObject("mnuOpen.Image"), System.Drawing.Image)
        Me.mnuOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(167, 24)
        Me.mnuOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(164, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(167, 24)
        Me.mnuSave.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(167, 24)
        Me.mnuExit.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 306)
        Me.Controls.Add(Me.rtDoc)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "MainForm"
        Me.Text = "Common File Dialog Boxes"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents rtDoc As System.Windows.Forms.RichTextBox
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
