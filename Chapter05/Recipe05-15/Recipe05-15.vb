Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_15

        Public Shared Sub Main()

            Console.WriteLine("Using: " & Directory.GetCurrentDirectory())
            Console.WriteLine("The relative path for 'file.txt' will automatically become: '" & Path.GetFullPath("file.txt") & "'")
            Console.WriteLine()

            Console.WriteLine("Changing current directory to c:\")
            Directory.SetCurrentDirectory("C:\")

            Console.WriteLine("Now the relative path for 'file.txt' will automatically become: '" & Path.GetFullPath("file.txt") & "'")

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace