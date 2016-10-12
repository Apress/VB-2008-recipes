Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_07

        Public Shared Sub Main()

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI"

                '  Create and configure a new command.
                Using com As SqlCommand = con.CreateCommand

                    com.CommandType = CommandType.Text
                    com.CommandText = "SELECT e.BirthDate,c.FirstName,c.LastName FROM HumanResources.Employee e INNER JOIN Person.Contact c ON e.EmployeeID=c.ContactID ORDER BY e.BirthDate;SELECT * FROM HumanResources.Employee"

                    '  Open the database connection and execute the example
                    '  commands through the connection.
                    con.Open()

                    '  Execute the command and obtain a DataReader.
                    Using reader As SqlDataReader = com.ExecuteReader

                        '  Process the first set of results and display the
                        '  content of the result set.
                        Console.WriteLine("Employee Birthdays (By Age).")

                        While reader.Read
                            Console.WriteLine("  {0,18:D} - {1} {2}", reader.GetDateTime(0), reader("FirstName"), reader(2))
                        End While
                        Console.WriteLine(Environment.NewLine)

                        '  Process the second set of results and display details
                        '  about the columns and data types in the result set.
                        If (reader.NextResult()) Then
                            Console.WriteLine("Employee Table Metadata.")
                            For field As Integer = 0 To reader.FieldCount - 1
                                Console.WriteLine("  Column Name:{0}  Type:{1}", reader.GetName(field), reader.GetDataTypeName(field))
                            Next
                        End If

                    End Using

                    '  Close the database connection.
                    con.Close()

                End Using

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
