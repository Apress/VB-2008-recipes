<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recipe09_12))
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.AccessibleDescription = Nothing
        Me.button1.AccessibleName = Nothing
        resources.ApplyResources(Me.button1, "button1")
        Me.button1.BackgroundImage = Nothing
        Me.button1.Font = Nothing
        Me.button1.Name = "button1"
        '
        'label1
        '
        Me.label1.AccessibleDescription = Nothing
        Me.label1.AccessibleName = Nothing
        resources.ApplyResources(Me.label1, "label1")
        Me.label1.Name = "label1"
        '
        'Recipe09_12
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "Recipe09_12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
