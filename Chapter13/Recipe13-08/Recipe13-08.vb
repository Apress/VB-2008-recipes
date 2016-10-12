Imports System
Imports Microsoft.Office.Interop
Namespace Apress.VisualBasicRecipes.Chapter13

    '  This recipe requires a refernce to Word and
    '  Microsoft.Office.Core.
    Public Class Recipe13_08

        Private Shared n As Object = Type.Missing
        Public Shared Sub Main()

            '  Start Word in the background.
            Dim app As New Word.Application
            app.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone

            Console.WriteLine()
            Console.WriteLine("Creating new document.")
            Console.WriteLine()

            '  Create a new document (this is not visible to the user).
            Dim doc As Word.Document = app.Documents.Add(n, n, n, n)

            '  Add a heading and two lines of text.
            Dim range As Word.Range = doc.Paragraphs.Add(n).Range

            range.InsertBefore("Test Document")
            range.Style = "Heading 1"

            range = doc.Paragraphs.Add(n).Range
            range.InsertBefore("Line one." & ControlChars.CrLf & "Line two.")
            range.Font.Bold = 1

            '  Show a print preview, and make Word visible.
            doc.PrintPreview()
            app.Visible = True

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
