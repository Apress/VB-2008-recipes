Imports System
Imports System.Linq
Imports System.Diagnostics
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_01

        Public Shared Sub Main()

            '  Build the query to return information for all
            '  processes running on the current machine.  The
            '  data will be returned as instances of the Process
            '  class.
            Dim procsQuery = From proc In Process.GetProcesses

            '  Run the query generated above and iterate
            '  through the results.
            For Each proc In procsQuery
                Console.WriteLine(proc.ProcessName)
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace