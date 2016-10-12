Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_08

        Public Shared Sub Main()

            '  Build the query to return information for all
            '  processes running on the current machine. The 
            '  Process.Threads collection, for each process, will
            '  be counted using the Count method.  The data will 
            '  be returned as anonymous types containing the name
            '  of the process and the number of threads.
            Dim query = From proc In Process.GetProcesses _
                        Order By proc.ProcessName _
                        Aggregate thread As ProcessThread In proc.Threads _
                        Into ThreadCount = Count(thread.Id) _
                        Select proc.ProcessName, ThreadCount

            '  Run the query generated above and iterate through
            '   the results.
            For Each proc In query
                Console.WriteLine("The {0} process has {1} threads.", proc.ProcessName, proc.ThreadCount.ToString)
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
