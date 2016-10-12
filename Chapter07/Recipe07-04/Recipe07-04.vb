Imports System
Imports System.Xml.Linq

Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_04

        Public Shared Sub Main()

            '  Load the Employees.xml and store the contents into an
            '  XElement object.
            Dim employees As XElement = XElement.Load("Employees.xml")

            '  Query the XML Tree and get the Name and Hourly Rate elements.
            Dim beforeQuery = From ele In employees.<Employee> _
                              Select Name = ele.<Name>.Value, Wage = CDbl(ele.<HourlyRate>.Value)

            '  Display the employee names and their hourly rate.
            Console.WriteLine("Original hourly wages:")
            For Each ele In beforeQuery
                Console.WriteLine("{0} gets paid ${1} an hour.", ele.Name, ele.Wage.ToString())
            Next
            Console.WriteLine()

            '  Loop through all the HourlyRate elements, setting them to
            '  the new payrate, which is the old rate * 5%. 
            Dim currentPayRate As Double = 0
            For Each ele In employees.<Employee>.<HourlyRate>
                currentPayRate = (ele.Value) + ((ele.Value) * 0.05)
                ele.SetValue(currentPayRate)
            Next

            '  Query the XML Tree and get the Name and Hourly Rate elements.
            Dim afterQuery = From ele In employees.<Employee> _
                             Select Name = ele.<Name>.Value, Wage = CDbl(ele.<HourlyRate>.Value)

            '  Display the employee names and their new hourly rate.
            Console.WriteLine("Hourly Wages after 5% increase:")
            For Each ele In afterQuery
                Console.WriteLine("{0} gets paid ${1} an hour.", ele.Name, ele.Wage.ToString("##.##"))
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
