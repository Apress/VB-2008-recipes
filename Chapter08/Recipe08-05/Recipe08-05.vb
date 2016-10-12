Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_05

        Public Shared Sub ExecuteNonQueryExample(ByVal con As IDbConnection)

            '  Create and configure a new command.
            Dim com As IDbCommand = con.CreateCommand
            com.CommandType = CommandType.Text
            com.CommandText = "UPDATE HumanResources.Employee SET Title = 'Production Supervisor' WHERE EmployeeID = 24;"

            '  Execute the command and process the result.
            Dim result As Integer = com.ExecuteNonQuery

            If result = 1 Then
                Console.WriteLine("Employee title updated.")
            ElseIf result > 1 Then
                Console.WriteLine("{0} employee titles updated.", result)
            Else
                Console.WriteLine("Employee title not updated.")
            End If

        End Sub
        Public Shared Sub ExecuteReaderExample(ByVal con As IDbConnection)

            '  Create and configure a new command.
            Dim com As IDbCommand = con.CreateCommand
            com.CommandType = CommandType.Text
            com.CommandText = "SET ROWCOUNT 10;SELECT Production.Product.Name, Production.Product.ListPrice FROM Production.Product ORDER BY Production.Product.ListPrice DESC;SET ROWCOUNT 0;"

            '  Execute the command and process the results.
            Using reader As IDataReader = com.ExecuteReader

                While reader.Read
                    '  Display the product details.
                    Console.WriteLine("  {0} = {1}", reader("Name"), reader("ListPrice"))
                End While

            End Using

        End Sub
        Public Shared Sub ExecuteScalarExample(ByVal con As IDbConnection)

            '  Create and configure a new command.
            Dim com As IDbCommand = con.CreateCommand
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(*) FROM HumanResources.Employee;"

            '  Execute the command and cast the result.
            Dim result As Integer = CInt(com.ExecuteScalar)

            Console.WriteLine("Employee count = " & result)

        End Sub
        Public Shared Sub Main()

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"

                '  Open the database connection and execute the example
                '  commands through the connection.
                con.Open()

                ExecuteNonQueryExample(con)
                Console.WriteLine(Environment.NewLine)

                ExecuteReaderExample(con)
                Console.WriteLine(Environment.NewLine)

                ExecuteScalarExample(con)
                Console.WriteLine(Environment.NewLine)

                '  Close the database connection.
                con.Close()

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
