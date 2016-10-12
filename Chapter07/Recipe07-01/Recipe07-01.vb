Imports System
Imports System.Xml.Linq
Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_01

        Public Class Employee
            Public EmployeeID As Integer
            Public FirstName As String
            Public LastName As String
            Public Title As String
            Public HireDate As DateTime
            Public HourlyWage As Double
        End Class
        Public Shared Sub Main()

            '  Create a List to hold employees
            Dim employeeList = New Employee() _
                    {New Employee With {.EmployeeID = 1, _
                                       .FirstName = "Joed", _
                                       .LastName = "McCormick", _
                                       .Title = "Airline Pilot", _
                                       .HireDate = DateTime.Now.AddDays(-25), _
                                       .HourlyWage = 100.0}, _
                    New Employee With {.EmployeeID = 2, _
                                       .FirstName = "Kai", _
                                       .LastName = "Nakamura", _
                                       .Title = "Super Genius", _
                                       .HireDate = DateTime.Now.AddYears(-10), _
                                       .HourlyWage = 999.99}, _
                    New Employee With {.EmployeeID = 3, _
                                       .FirstName = "Romi", _
                                       .LastName = "Doshi", _
                                       .Title = "Actress", _
                                       .HireDate = DateTime.Now.AddMonths(-15), _
                                       .HourlyWage = 120.0}, _
                    New Employee With {.EmployeeID = 4, _
                                       .FirstName = "Leah", _
                                       .LastName = "Clooney", _
                                       .Title = "Molecular Biologist", _
                                       .HireDate = DateTime.Now.AddMonths(-10), _
                                       .HourlyWage = 100.75}}

            '  Use XML literals to create the XML tree.
            '  Embedded expressions are used, with LINQ, to 
            '  query the employeeList collection and build
            '  each employee node.
            Dim employees = _
                <Employees>
                    <%= From emp In employeeList _
                        Select _
                        <Employee id=<%= emp.EmployeeID %>>
                            <Name><%= emp.FirstName & " " & emp.LastName %></Name>
                            <Title><%= emp.Title %></Title>
                            <HireDate><%= emp.HireDate.ToString("MM/dd/yyyy") %></HireDate>
                            <HourlyRate><%= emp.HourlyWage %></HourlyRate>
                        </Employee> _
                    %>
                </Employees>

            '  Save the XML tree to a file then display it on
            '  the screen.
            employees.Save("Employees.xml")
            Console.WriteLine(employees.ToString())

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
