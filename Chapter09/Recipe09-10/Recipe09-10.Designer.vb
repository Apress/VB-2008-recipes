<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe09_10
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "B", "A"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2", "A", "E"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"3", "C", "B"}, -1)
        Me.listView1 = New System.Windows.Forms.ListView
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3})
        Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView1.GridLines = True
        Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.listView1.Location = New System.Drawing.Point(0, 0)
        Me.listView1.Margin = New System.Windows.Forms.Padding(4)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(389, 327)
        Me.listView1.TabIndex = 2
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Width = 101
        '
        'columnHeader2
        '
        Me.columnHeader2.Width = 103
        '
        'columnHeader3
        '
        Me.columnHeader3.Width = 104
        '
        'Recipe09_10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 327)
        Me.Controls.Add(Me.listView1)
        Me.Name = "Recipe09_10"
        Me.Text = "Recipe09-10"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader

End Class
