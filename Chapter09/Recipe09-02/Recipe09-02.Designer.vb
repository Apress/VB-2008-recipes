<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recipe09_02))
        Me.listView1 = New System.Windows.Forms.ListView
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'listView1
        '
        Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView1.LargeImageList = Me.imageList1
        Me.listView1.Location = New System.Drawing.Point(0, 0)
        Me.listView1.Margin = New System.Windows.Forms.Padding(4)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(340, 327)
        Me.listView1.TabIndex = 2
        Me.listView1.UseCompatibleStateImageBehavior = False
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "notepad.ico")
        '
        'Recipe09_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 327)
        Me.Controls.Add(Me.listView1)
        Me.Name = "Recipe09_02"
        Me.Text = "Recipe09-02"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents imageList1 As System.Windows.Forms.ImageList

End Class
