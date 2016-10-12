Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_10

        Public Shared Sub Main()

            '  Build the query to return information for all processes
            '  running on the current machine and group them based
            '  on the mathmatical floor of the allocated physical
            '  memory.  The count, maximum and minimum values for each
            '  group are calculated and returned as properties of the
            '  anonymous type.  Data is only returned for groups that
            '  have more then one process.
            Dim query = From proc In Process.GetProcesses _
                        Order By proc.ProcessName _
                        Group By MemGroup = Math.Floor((proc.WorkingSet64 / (1024 * 1024))) _
                        Into Count = Count(), Max = Max(proc.WorkingSet64), Min = Min(proc.WorkingSet64) _
                        Where Count > 1 _
                        Order By MemGroup

            '  Run the query generated above and iterate through the
            '  results.
            For Each result In query
                Console.WriteLine("Physical Allocated Memory Group:  {0} MB", result.MemGroup)
                Console.WriteLine("# of processes that have this amount of memory allocated:  {0}", result.Count)
                Console.WriteLine("Minimum amount of physical memory allocated:               {0} ({1})", result.Min, (result.Min / (1024 * 1024)).ToString("#.00"))
                Console.WriteLine("Maximum amount of physical memory allocated:               {0} ({1})", result.Max, (result.Max / (1024 * 1024)).ToString("#.00"))
                Console.WriteLine()
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
