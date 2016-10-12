Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_11

        Public Shared Sub Main()

            '  Store a list of processes that will be monitored or
            '  that information should be gathered for.
            Dim processesToMonitor = New String() {"explorer", _
                                                   "iexplore", _
                                                   "lsass", _
                                                   "rundll32", _
                                                   "services", _
                                                   "winlogon", _
                                                   "svchost"}

            '  Build the query to return information for all of the
            '  processes that should be monitored by joining them to
            '  the list of all processes running on the current
            '  computer.  The count, maximum and minimum values for each
            '  group are calculated and returned as properties of the
            '  anonymous type.  Data is only returned for groups that
            '  have more then one process.
            Dim query = From proc In Process.GetProcesses _
                        Order By proc.ProcessName _
                        Join myProc In processesToMonitor _
                        On proc.ProcessName Equals myProc _
                        Select Name = proc.ProcessName, proc.Id, PhysicalMemory = proc.WorkingSet64


            '  Run the query generated above and iterate through the
            '  results.
            For Each proc In query
                Console.WriteLine("{0,-10} ({1,5}) - Allocated Physical Memory:  {2,5} MB", proc.Name, proc.Id, (proc.PhysicalMemory / (1024 * 1024)).ToString("#.00"))
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
