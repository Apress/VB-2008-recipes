Imports System
Imports System.Xml.Linq

Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_06

        Public Shared Sub Main()

            '  Load the Employees.xml file and store the contents into
            '  an XElement object.
            Dim employees As XElement = XElement.Load("Employees.xml")

            '  Get the count of all employees hired this year.
            Dim cnt = Aggregate ele In employees.<Employee> _
                      Where CDate(ele.<HireDate>.Value).Year = Now.Year _
                      Into Count()

            Console.WriteLine("{0} employees were hired this year.", cnt)
            Console.WriteLine()

            '  Query for all of the employees that make (HourlyRate) more than
            '  $100 an hour.  An anonymous type is returned containing the
            '  Id, Name and Pay properties  which correspond to the id attribute
            '  and the Name and HourlyRate elements respectively.
            Dim query = From ele In employees.<Employee> _
                        Where CDbl(ele.<HourlyRate>.Value) >= 100 _
                        Select ele.@id, ele.<Name>.Value, Pay = CDbl(ele.<HourlyRate>.Value) _
                        Order By Name

            Console.WriteLine("Employees who make more than $100 an hour:")
            For Each emp In query
                Console.WriteLine("[{0,-2}] {1,-25} ${2,-6}", emp.id, emp.Name, emp.Pay.ToString("##.00"))
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
