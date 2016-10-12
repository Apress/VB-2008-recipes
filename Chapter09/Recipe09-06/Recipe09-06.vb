﻿Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe09-06.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe09_06

    Private Sub Recipe09_06_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Size = My.Settings.Size

    End Sub
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redButton.Click, blueButton.Click, greenButton.Click

        '  Change the color of the textbox depending on which button
        '  was pressed.
        Dim btn As Button = TryCast(sender, Button)

        If btn IsNot Nothing Then
            '  Set the background color of the textbox to the ForeColor
            '  of the button.
            textBox1.BackColor = btn.ForeColor

            '  Update the application settings with the new value.
            My.Settings.Color = textBox1.BackColor

        End If

    End Sub
    Private Sub Recipe09_06_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        '  Update the application settings for Form.
        My.Settings.Size = Me.Size

        '  Store all application settings.
        My.Settings.Save()

    End Sub

End Class
