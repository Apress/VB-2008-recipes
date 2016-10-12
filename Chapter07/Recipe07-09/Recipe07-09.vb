Imports System
Imports System.Xml.Linq
Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_09

        Public Shared Sub Main()

            '  Load the Employees.xml and Tasks.xml files
            '  and store the contents into XElement objects.
            Dim employees As XElement = XElement.Load("Employees.xml")
            Dim tasks As XElement = XElement.Load("Tasks.xml")

            '  Build a query to join the two XML trees on the employee's
            '  Id.
            Dim query = From emp In employees.<Employee> _
                        Group Join task In tasks.<Task> _
                        On emp.@id Equals task.@empId _
                        Into TaskList = Group _
                        Select EmployeeName = emp.<Name>.Value, _
                               TaskList

            '  Execute the query and loop through the results, displaying
            '  them on the console.
            For Each emp In query
                '  Display the employee's name.
                Console.WriteLine("Tasks for {0}:", emp.EmployeeName)

                '  Now loop through the task list
                For Each task In emp.TaskList
                    Console.WriteLine("{0} - {1}", task.<Name>.Value, task.<Status>.Value)
                Next
                Console.WriteLine()
            Next
            Console.WriteLine()

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace

