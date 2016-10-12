Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_07

        Public Shared Sub Main()

            '  Build the query to return the average and total
            '  physical memory used by all of the processes
            '  running on the current machine.  The data is returned 
            '  as an anonymous types that contains the aggregate data.
            Dim aggregateData = Aggregate proc In Process.GetProcesses _
                                Into AverageMemory = Average(proc.WorkingSet64), _
                                     TotalMemory = Sum(proc.WorkingSet64)

            '  Display the results on the console.
            Console.WriteLine("Average Allocated Physical Memory:  {0,6} MB", (aggregateData.AverageMemory / (1024 * 1024)).ToString("#.00"))
            Console.WriteLine("Total Allocated Physical Memory  :  {0,6} MB", (aggregateData.TotalMemory / (1024 * 1024)).ToString("#.00"))

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
