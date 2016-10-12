Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_11

        Public Shared Sub Main(ByVal args As String())

            If args.Length = 2 Then
                Dim dir As New DirectoryInfo(args(0))
                Dim files As FileInfo() = dir.GetFiles(args(1))

                '  Display the name of all the files.
                For Each file As FileInfo In files
                    Console.Write("Name: " & file.Name + "  ")
                    Console.WriteLine("Size: " & file.Length.ToString)
                Next

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete. Press Enter.")
                Console.ReadLine()

            Else
                Console.WriteLine("USAGE:  Recipe05-11 [directory][filterExpression]")
            End If

        End Sub

    End Class

End Namespace