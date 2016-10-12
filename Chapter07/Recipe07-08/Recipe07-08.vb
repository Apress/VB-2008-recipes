Imports System
Imports System.Xml.Linq
Imports System.Xml.XPath
Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_08

        Public Shared Sub Main()

            '  Load the Employees.xml and store the contents into an
            '  XElement object.
            Dim employees As XElement = XElement.Load("EmployeesAndTasks.xml")

            '  Use XPath to get the tasks for each employee.
            Dim xpathQuery = employees.XPathSelectElements("/Employee/Tasks/Task")

            '  Loop through the query results and display the information
            '  to the screen.
            For Each task In xpathQuery
                Console.WriteLine("{0,-15} - {1} ({2})", task.Parent.Parent.<Name>.Value, task.<Name>.Value, task.<Description>.Value)
            Next
            Console.WriteLine()

            '  Use LINQ to get the tasks for each employee and order them
            '  by the employee's name.
            Dim linqQuery = From task In employees.<Employee>...<Task> _
                            Select EmployeeName = task.Parent.Parent.<Name>.Value, _
                                   TaskName = task.<Name>.Value, _
                                   task.<Description>.Value _
                            Order By EmployeeName


            '  Execute the query and loop through the results, displaying the
            '  Information to the screen.
            For Each task In linqQuery
                Console.WriteLine("{0,-15} - {1} ({2})", task.EmployeeName, task.TaskName, task.Description)
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace

