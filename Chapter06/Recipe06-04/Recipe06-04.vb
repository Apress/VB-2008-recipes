Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_04

        Public Shared Sub Main()

            '  Build the query to return information for all
            '  processes running on the current machine.  The
            '  data will be returned in the form of anonymous
            '  types with Id and Name properties ordered by Name
            '  and by Id.
            Dim procInfoQuery = From proc In Process.GetProcesses _
                                Select proc.Id, Name = proc.ProcessName _
                                Order By Name, Id

            '  Run the query generated above and iterate
            '  through the results.
            For Each proc In procInfoQuery
                Console.WriteLine("{0,-20} [{1,5}]", proc.Name, proc.Id)
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
