﻿Imports System
Imports System.Windows.Forms
Imports System.Media
'  All designed code is stored in the autogenerated partial
'  class called Recipe10-10.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe10_10

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click

        '  Allow the user to choose a file.
        Dim openDialog As New OpenFileDialog

        openDialog.Filter = "WAV Files|*.wav|All Files|*.*"

        If openDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim player As New SoundPlayer(openDialog.FileName)

            Try
                player.Play()
            Catch ex As Exception
                MessageBox.Show("An error occurred while playing media.")
            Finally
                player.Dispose()
            End Try

        End If

    End Sub

End Class