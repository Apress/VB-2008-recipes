'  class called Recipe09-04Child.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe09_04Child

    '  A button click event handler to close the child form.
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub
    '  Display the name of the form when it is painted.
    Private Sub Recipe09_04Child_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        '  Display the name of the form.
        lblFormName.Text = Name

    End Sub

End Class