Imports System
Imports System.Linq
Imports System.Diagnostics
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_03

        Public Shared Sub Main()

            '  Build the query to return information for all
            '  processes running on the current machine.  The
            '  data will be returned in the form of anonymous
            '  types with Id, Name and MemUsed properties.
            Dim procInfoQuery = From proc In Process.GetProcesses _
                                Select proc.Id, Name = proc.ProcessName, MemUsed = proc.WorkingSet64

            '  Run the query generated above and iterate
            '  through the results.
            For Each proc In procInfoQuery
                Console.WriteLine("[{0,5}] {1,-20} - {2}", proc.Id, proc.Name, proc.MemUsed)
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
