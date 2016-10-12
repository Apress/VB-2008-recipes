Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_09

        Public Shared Sub Main()

            '  Build the query to return the minimum and maximum
            '  physical memory allocated by all of the processes
            '  running on the current machine.  The data is returned 
            '  as an anonymous types that contains the aggregate data.
            Dim aggregateData = Aggregate proc In Process.GetProcesses _
                                Into MinMemory = Min(proc.WorkingSet64), _
                                     MaxMemory = Max(proc.WorkingSet64)

            '  Display the results on the console.
            Console.WriteLine("Minimum Allocated Physical Memory:  {0,6} MB", (aggregateData.MinMemory / (1024 * 1024)).ToString("#.00"))
            Console.WriteLine("Maximum Allocated Physical Memory:  {0,6} MB", (aggregateData.MaxMemory / (1024 * 1024)).ToString("#.00"))

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
