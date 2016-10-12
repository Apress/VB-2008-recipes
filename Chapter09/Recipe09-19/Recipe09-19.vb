﻿Imports System
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe09-19.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe09_19

    Private Sub goButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goButton.Click

        '  Navigate to the URL specified in the textbox.
        webBrowser1.Navigate(textURL.Text)

    End Sub
    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click

        '  Go to the previous page in the WebBrowser history.
        webBrowser1.GoBack()

    End Sub
    Private Sub homeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeButton.Click

        '  Navigate to the current user's home page.
        webBrowser1.GoHome()

    End Sub
    Private Sub forwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forwardButton.Click

        '  Go to the next page in the WebBrowser history.
        webBrowser1.GoForward()

    End Sub
    Private Sub Recipe09_19_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '  Navigate to the Apress home page when the application first
        '  loads.
        webBrowser1.Navigate("http://www.apress.com")

    End Sub
    '  Event handler to perform general interface maintenance once a
    '  document has been loaded into the WebBrowser.
    Private Sub webBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webBrowser1.DocumentCompleted

        '  Update the content of the TextBox to reflect the current URL.
        textURL.Text = webBrowser1.Url.ToString

        '  Enable or disable the Back button depending on whether the
        '  WebBrowser has back history
        If webBrowser1.CanGoBack Then
            backButton.Enabled = True
        Else
            backButton.Enabled = False
        End If

        '  Enable or disable the Forward button depending on whether the
        '  WebBrowser has forward history.
        If webBrowser1.CanGoForward Then
            forwardButton.Enabled = True
        Else
            forwardButton.Enabled = False
        End If

    End Sub

End Class