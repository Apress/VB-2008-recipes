Imports System
Imports System.Xml.Linq
Imports <xmlns:gfh="www.GenuisesForHire.com">
Imports <xmlns:tfh="www.TempsForHire.com">
Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_07

        Public Shared Sub Main()

            '  Load the Employees.xml file and store the contents into
            '  an XElement object.
            Dim employees As XElement = XElement.Load("EmployeesWithNS.xml")

            '  Build the query to get all nodes that are in the 
            '  www.GenuisesForHire.com namespace.
            Dim gfhEmployees = From ele In employees.Descendants _
                               Order By ele.<Name>.Value() _
                               Where (ele.Name.Namespace = GetXmlNamespace(gfh)) _
                               Select ele.<Name>.Value()

            '  Execute the query and display the results.
            Console.WriteLine("All 'Genuises For Hire' employees:")
            For Each emp In gfhEmployees
                Console.WriteLine(emp)
            Next
            Console.WriteLine()

            '  Build the query to get all nodes that are in the 
            '  www.TempsForHire.com namespace.
            Dim tfhEmployees = From ele In employees.Descendants _
                               Order By ele.<Name>.Value() _
                               Where (ele.Name.Namespace = GetXmlNamespace(tfh)) _
                               Select ele.<Name>.Value()

            '  Execute the query and display the results.
            Console.WriteLine("All 'Temps For Hire' employees:")
            For Each emp In tfhEmployees
                Console.WriteLine(emp)
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace

