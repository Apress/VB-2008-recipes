﻿Imports System
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe09-04.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Public Class Recipe09_04

    Private Sub Recipe09_04_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  Refresh the list to display the initial set of forms.
        RefreshForms()

    End Sub
    '  A button click event handler to create a new child form.
    Private Sub btnNewForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewForm.Click

        '  Create a new child form and set its name as specified.
        '  If no name is specified, use a default name.
        Dim child As New Recipe09_04Child

        If Me.txtFormName.Text Is String.Empty Then
            child.Name = "Child Form"
        Else
            child.Name = txtFormName.Text
        End If

        '  Show the new child form.
        child.Show()

    End Sub
    '  List selection event handler to activate the selected form based on
    '  its name.
    Private Sub listForms_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listForms.SelectedIndexChanged

        '  Activate the selected form using its name as the index into the
        '  collection of active forms.  If there are duplicate forms with the
        '  same name, the first one found will be activated.
        Dim selectedForm As Form = Application.OpenForms(listForms.Text)

        '  If the form has been closed, using its name as an index into the
        '  FormColelction will return nothing.  In this instance, update the
        '  list of forms.
        If selectedForm IsNot Nothing Then
            '  Activate the selected form.
            selectedForm.Activate()
        Else
            '  Display a message and refresh the form list.
            MessageBox.Show("Form closed; refreshing list...", "Form Closed")
            RefreshForms()
        End If

    End Sub
    '  A button click event event handler to initiate a refresh of the list of
    '  active forms.
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        RefreshForms()

    End Sub
    '  A method to perform a refresh of the list of active forms.
    Private Sub RefreshForms()

        '  Clear the list and repopulate from the Application.OpenForms
        '  property.
        listForms.Items.Clear()

        For Each f As Form In Application.OpenForms
            listForms.Items.Add(f.Name)
        Next

    End Sub

End Class