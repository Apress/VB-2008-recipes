Imports System

Namespace Apress.VisualBasicRecipes.Chapter01

    Public Class Recipe01_07

        Public Shared Sub Main(ByVal args As String())

            '  Step trhough the command-line arguments
            For Each s As String In args
                Console.WriteLine(s)
            Next

            '  Alternatively, access the command=line argumnets directly.
            Console.WriteLine(Environment.CommandLine)

            For Each s As String In Environment.GetCommandLineArgs()
                Console.WriteLine(s)
            Next

            '  Wait to continue
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
