<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_05Parent
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
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuNew = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNew})
        Me.menuItem1.Text = "File"
        '
        'mnuNew
        '
        Me.mnuNew.Index = 0
        Me.mnuNew.Text = "New"
        '
        'Recipe09_05Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 379)
        Me.IsMdiContainer = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Recipe09_05Parent"
        Me.Text = "Recipe09-05Parent"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
    Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents mnuNew As System.Windows.Forms.MenuItem
End Class
