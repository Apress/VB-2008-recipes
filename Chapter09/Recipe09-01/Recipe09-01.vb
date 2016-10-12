﻿Imports System
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe09-01.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe09_01

    Private Sub Recipe09_01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '  Create an array of strings to use as the labels for 
        '  the dynamic checkboxes.
        Dim colors As String() = {"Red", "Green", "Black", "Blue", "Purple", "Pink", "Orange", "Cyan"}

        '  Suspend the panel's layout logic while multiple controls
        '  are added.
        panel1.SuspendLayout()

        '  Specify the Y coordinate of the topmost checkbox in the list.
        Dim topPosition As Integer = 10

        '  Create one new checkbox for each name in the list of
        '  food types.
        For Each color As String In colors
            '  Create a new checkbox.
            Dim newCheckBox As New CheckBox

            '  Configure the new checkbox.
            newCheckBox.Top = topPosition
            newCheckBox.Left = 10
            newCheckBox.Text = color

            '  Set the Y coordinate of the next checkbox.
            topPosition += 30

            '  Add the checkbox to the panel contained by the form.
            panel1.Controls.Add(newCheckBox)
        Next

        '  Resume the form's layout logic now that all controls
        '  have been added.
        Me.ResumeLayout()

    End Sub

End Class
