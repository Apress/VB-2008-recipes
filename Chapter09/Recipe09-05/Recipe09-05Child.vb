﻿Imports System
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe09-05Child.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe09_05Child

    '  A property to provide easy access to the label data.
    Public ReadOnly Property LabelText() As String
        Get
            Return label.Text
        End Get
    End Property
    '  When a button on any of the MDI child forms is clicked, display the
    '  contents of each form by enumerating the MdiChildren collection.
    Private Sub cmdShowAllWindows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowAllWindows.Click

        For Each frm As Form In Me.MdiParent.MdiChildren
            '  Cast the generic Form to the Recipe07_05Child derived class
            '  type.
            Dim child As Recipe09_05Child = DirectCast(frm, Recipe09_05Child)
            MessageBox.Show(child.LabelText, frm.Text)
        Next

    End Sub
    '  Set the MDI child form's label to the current date/time.
    Private Sub Recipe09_05Child_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        label.Text = DateTime.Now.ToString

    End Sub

End Class
