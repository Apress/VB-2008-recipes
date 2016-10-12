﻿Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports QuartzTypeLib
'  All designed code is stored in the autogenerated partial
'  class called Recipe10-12.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe10_12

    '  Define the constants used for specifying the window style.
    Private Const WS_CHILD As Integer = &H40000000
    Private Const WS_CLIPCHILDREN As Integer = &H2000000

    '  Hold a form-level reference to the QuartzTypeLib.FilgraphManager
    '  object.
    Private graphManager As FilgraphManager

    '  Hold a form-level reference to the media control interface,
    '  so the code can control playback of the currently loaded
    '  movie.
    Private mc As IMediaControl = Nothing

    '  Hold a form-level reference to the video window in case it
    '  needs to be resized.
    Private videoWindow As IVideoWindow = Nothing
    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click

        '  Allow the user to choose a file.
        Dim openDialog As New OpenFileDialog

        openDialog.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3|All Files|*.*"

        If openDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            '  Stop the playback for the current movie, if it exists.
            If mc IsNot Nothing Then mc.Stop()

            '  Load the movie file.
            graphmanager = New FilgraphManager
            graphmanager.RenderFile(openDialog.FileName)

            '  Attach the view to a picture box on the form.
            Try
                videoWindow = DirectCast(graphmanager, IVideoWindow)
                videoWindow.Owner = pictureBox1.Handle.ToInt32
                videoWindow.WindowStyle = WS_CHILD Or WS_CLIPCHILDREN
                videoWindow.SetWindowPosition(pictureBox1.ClientRectangle.Left, pictureBox1.ClientRectangle.Top, pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height)
            Catch ex As Exception
                '  An error can occur if the file does not have a video
                '  source (for example, an MP3 file).
                '  You can ignore this error and still allow playback to
                '  continue (without any visualization).
            End Try

            '  Start the playback (asynchronously).
            mc = DirectCast(graphmanager, IMediaControl)
            mc.Run()

        End If

    End Sub
    Private Sub pictureBox1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictureBox1.SizeChanged

        If videoWindow IsNot Nothing Then

            Try
                videoWindow.SetWindowPosition(pictureBox1.ClientRectangle.Left, pictureBox1.ClientRectangle.Top, pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height)
            Catch ex As Exception
                '  Ignore the exception thrown when resizing the form
                '  when the file does not have a video source.
            End Try

        End If

    End Sub
    Private Sub Recipe10_12_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        '  Destroy the COM object (QuartzTypeLib) that we are using.
        If graphManager IsNot Nothing Then
            System.Runtime.InteropServices.Marshal.ReleaseComObject(graphManager)
        End If

    End Sub

End Class