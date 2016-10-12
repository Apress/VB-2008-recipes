Imports System
Imports System.Xml.Linq

Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_03

        Public Shared Sub Main()

            '  Load the Employees.xml and store the contents into an
            '  XElement object.
            Dim employees As XElement = XElement.Load("Employees.xml")

            '  Get the maximum value for the ID attribute.  The element
            '  axis property (<>) and the attribute axis property (@) are
            '  used to access the id attribute.
            Dim maxId As Integer = Aggregate ele In employees.<Employee> _
                                   Into Max(CInt(ele.@id))

            '  Create the new Employee node using functional construction.
            Dim newEmployee = <Employee id=<%= maxId + 1 %>>
                                  <Name>Robb Matthews</Name>
                                  <Title>Super Hero</Title>
                                  <HireDate>07/15/2006</HireDate>
                                  <HourlyRate>59.95</HourlyRate>
                              </Employee>

            '  Add the new node to the bottom of the XML tree.
            employees.Add(newEmployee)

            '  Loop through all the Employee nodes and insert
            '  the new 'TerminationDate' node and the 'Status' attribute.
            For Each ele In employees.<Employee>
                ele.Add(<TerminationDate></TerminationDate>)
                ele.Add(New XAttribute("Status", ""))
            Next

            '  Display the XML on the console.
            Console.WriteLine(employees.ToString())

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
