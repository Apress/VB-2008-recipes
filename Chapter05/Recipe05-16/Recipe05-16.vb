Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_16

        Public Shared Sub Main()

            Dim tempFile As String = Path.GetTempFileName

            Console.WriteLine("Using " & tempFile)

            Using fs As New FileStream(tempFile, FileMode.Open)
                '  Write some data
            End Using

            '  Now delete the file.
            File.Delete(tempFile)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
