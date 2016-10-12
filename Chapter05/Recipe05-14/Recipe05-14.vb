Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_14

        Public Shared Sub Main(ByVal args As String())

            For Each arg As String In args
                Console.Write(arg)

                If Directory.Exists(arg) Then
                    Console.WriteLine(" is a directory.")
                ElseIf File.Exists(arg) Then
                    Console.WriteLine(" is a file.")
                Else
                    Console.WriteLine(" does not exist.")
                End If

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete. Press Enter.")
                Console.ReadLine()

            Next

        End Sub

    End Class

End Namespace