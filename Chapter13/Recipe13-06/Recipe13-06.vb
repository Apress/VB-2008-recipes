Imports System
Namespace Apress.VisualBasicRecipes.Chapter13

    Public Class Recipe13_06

        '  Be sure to add a reference to ADODB (runtime version 1.1.4322)
        '  to the project.
        Public Shared Sub Main()

            '  This example assumes that you have the AdventureWorks
            '  sample database installed.  If you don't, you will need
            '  to change the connectionString accordingly.

            '  Create a new ADODB connection.
            Dim con As New ADODB.Connection
            Dim connectionString As String = "Provider=SQLOLEDB.1;Data Source=.\sqlexpress;Initial Catalog=AdventureWorks;Integrated Security=SSPI;"

            con.Open(connectionString, Nothing, Nothing, 0)

            '  Execute a SELECT query.
            Dim recordsAffected As Object = Nothing
            Dim rs As ADODB.Recordset = con.Execute("SELECT * FROM HumanResources.Employee;", recordsAffected, 0)

            '  Print out the results.
            While Not rs.EOF = True

                Console.WriteLine(rs.Fields("EmployeeID").Value)
                rs.MoveNext()

            End While

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
