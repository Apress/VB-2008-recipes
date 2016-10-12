Imports System

Namespace Apress.VisualBasicRecipes.Chapter01

    Public Class HelloWorld

        Public Shared Sub Main()

            ConsoleUtils.WriteString("Hello, World")

            ConsoleUtils.WriteString(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace