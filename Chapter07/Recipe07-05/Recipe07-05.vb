Imports System
Imports System.Xml.Linq

Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_05

        Public Shared Sub Main()

            '  Load the Employees.xml and store the contents into an
            '  XElement object.
            Dim employees As XElement = XElement.Load("Employees.xml")

            '  Remove the 4th Employee element.
            employees.<Employee>.ElementAt(3).Remove()

            '  Loop through all of the Employee elements and remove
            '  the HireDate element.
            For Each ele In employees.<Employee>.ToList
                ele.SetElementValue("HireDate", Nothing)
            Next

            Console.WriteLine(employees.ToString)

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
