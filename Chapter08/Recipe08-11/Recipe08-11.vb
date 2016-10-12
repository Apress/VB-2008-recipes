Imports System
Imports System.Data.Linq
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_11

        Shared Sub Main()

            '  Create an instance of the DataContext that was
            '  created by the O/R Designer.
            Dim dbContext = New AdventureWorksDataContext()

            '  Create a query to to return the name and HireDate for
            '  each employee that was hired prior to the year 2000.
            '  Note that you can easily access a related table (Contact)
            '  without having to perform any joins.
            Dim Query = From emp In dbContext.Employees _
                        Where emp.HireDate.Year < 2000 _
                        Select Name = emp.Contact.LastName & ", " & emp.Contact.FirstName, _
                               emp.HireDate _
                        Order By Name

            '  Execute the query and display the results.
            For Each emp In Query
                Console.WriteLine("{0} was hired on {1}", emp.Name, emp.HireDate.ToString("MM/dd/yyy"))
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace