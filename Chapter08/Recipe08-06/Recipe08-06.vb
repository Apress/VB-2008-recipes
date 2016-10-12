Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_06

        Public Shared Sub ParameterizedCommandExample(ByVal con As SqlConnection, ByVal employeeID As Integer, ByVal title As String)

            '  Create and configure a new command containing 2 named parameters.
            Using com As SqlCommand = con.CreateCommand

                com.CommandType = CommandType.Text
                com.CommandText = "UPDATE HumanResources.Employee SET Title = @title WHERE EmployeeID = @id;"

                '  Create a SqlParameter object for the title parameter.
                Dim p1 As SqlParameter = com.CreateParameter
                p1.ParameterName = "@title"
                p1.SqlDbType = SqlDbType.VarChar
                p1.Value = title
                com.Parameters.Add(p1)

                '  Use a shorthand syntax to add the id parameter.
                com.Parameters.Add("@id", SqlDbType.Int).Value = employeeID

                '  Execute the command and process the result.
                Dim result As Integer = com.ExecuteNonQuery

                If result = 1 Then
                    Console.WriteLine("Employee {0} title updated to {1}", employeeID, title)
                ElseIf result > 1 Then
                    '  Indicates multiple records were affected.
                    Console.WriteLine("{0} records for employee {1} had the title updated to {2}", result, employeeID, title)
                Else
                    Console.WriteLine("Employee {0} title not updated.", employeeID)
                End If

            End Using

        End Sub
        Public Shared Sub StoredProcedureExample(ByVal con As SqlConnection, ByVal managerID As Integer)

            '  Create and configure a new command containing 2 named parameters.
            Using com As SqlCommand = con.CreateCommand

                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "uspGetManagerEmployees"

                '  Create the required SqlParameter object.
                com.Parameters.Add("@ManagerID", SqlDbType.Int).Value = managerID

                '  Execute the command and process the result.
                Dim result As Integer = com.ExecuteNonQuery

                Using reader As SqlDataReader = com.ExecuteReader
                    Console.WriteLine("Employees managed by manager #{0}.", managerID.ToString)

                    While reader.Read
                        '  Display the product details.
                        Console.WriteLine("  {0}, {1} ({2})", reader("LastName"), reader("FirstName"), reader("employeeID"))
                    End While

                End Using

            End Using

        End Sub
        Public Shared Sub Main()

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"

                '  Open the database connection and execute the example
                '  commands through the connection.
                con.Open()

                ParameterizedCommandExample(con, 16, "Production Technician")
                Console.WriteLine(Environment.NewLine)

                StoredProcedureExample(con, 185)
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