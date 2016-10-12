Imports System
Imports System.Linq
Imports System.Diagnostics
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_13

        '  This field holds the size of our pages.
        Private Shared pageSize As Integer = 10
        Private Const FIVE_MB = 3 * (1024 * 1024)
        Public Shared Sub Main()

            '  Use LINQ to retrieve a IEnumerable(Of Process) List of
            '  processes that are using more then 5 MB of memory.  The
            '  ToList method is used to force the query to execute immediately
            '  and save the results in the procs variable so they can be reused.
            Dim procs = (From proc In Process.GetProcesses.ToList _
                         Where proc.WorkingSet64 > FIVE_MB _
                         Order By proc.ProcessName _
                         Select proc).ToList


            Dim totalPages As Integer

            '  Determine the exact number of pages of information
            '  available for display.
            totalPages = Math.Floor(procs.Count / pageSize)
            If procs.Count Mod pageSize > 0 Then totalPages += 1


            Console.WriteLine("LIST OF PROCESSES WITH MEMORY USAGE OVER 5 MB:")
            Console.WriteLine("")

            '  Loop and display each page of data.
            For i = 0 To totalPages - 1
                Console.WriteLine("PAGE {0} OF {1}", i + 1.ToString(), totalPages.ToString())

                '  Query the procs collection and return a single page
                '  of processes using the Skip and Take clauses.
                Dim currentPage = From proc In procs _
                                  Skip i * pageSize Take pageSize

                '  Loop through all the process records for the current page.
                For Each proc In currentPage
                    Console.WriteLine("{0,-20} - {1,6} MB", proc.ProcessName, (proc.WorkingSet64 / (1024 * 1024)).ToString("#.00"))
                Next

                '  Check if there are any more pages.
                If Not i = totalPages - 1 Then
                    Console.WriteLine("Press Enter for the next page.")
                    Console.ReadLine()
                End If
            Next

            Console.WriteLine("No more data available.  Press Enter to end.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace
