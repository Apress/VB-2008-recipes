Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_01

        Public Shared Sub SqlConnectionExample()

            '  Configure an empty SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"

                '  Open the database connection.
                con.Open()

                '  Display the information about the connection.
                If con.State = ConnectionState.Open Then
                    Console.WriteLine("SqlConnection Information:")
                    Console.WriteLine("  Connection State = " & con.State)
                    Console.WriteLine("  Connection String = " & con.ConnectionString)
                    Console.WriteLine("  Database Source = " & con.DataSource)
                    Console.WriteLine("  Database = " & con.Database)
                    Console.WriteLine("  Server Version = " & con.ServerVersion)
                    Console.WriteLine("  Workstation Id = " & con.WorkstationId)
                    Console.WriteLine("  Timeout = " & con.ConnectionTimeout)
                    Console.WriteLine("  Packet Size = " & con.PacketSize)
                Else
                    Console.WriteLine("SqlConenction failed to open.")
                    Console.WriteLine("  Connection State = " & con.State)
                End If

                '  Close the database connection.
                con.Close()

            End Using

        End Sub
        Public Shared Sub OleDbConnectionExample()

            '  Configure an empty SqlConnection object.
            Using con As New OleDbConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Provider=SQLOLEDB;Data Source=.\sqlexpress;Initial Catalog=AdventureWorks;Integrated Security=SSPI;"

                '  Open the database connection.
                con.Open()

                '  Display the information about the connection.
                If con.State = ConnectionState.Open Then
                    Console.WriteLine("OleDbConnection Information:")
                    Console.WriteLine("  Connection State = " & con.State)
                    Console.WriteLine("  Connection String = " & con.ConnectionString)
                    Console.WriteLine("  Database Source = " & con.DataSource)
                    Console.WriteLine("  Database = " & con.Database)
                    Console.WriteLine("  Server Version = " & con.ServerVersion)
                    Console.WriteLine("  Timeout = " & con.ConnectionTimeout)
                Else
                    Console.WriteLine("OleDbConnection failed to open.")
                    Console.WriteLine("  Connection State = " & con.State)
                End If

                '  Close the database connection. 
                con.Close()

            End Using

        End Sub
        Public Shared Sub Main()

            '  Open connection using SqlConnection.
            SqlConnectionExample()
            Console.WriteLine(Environment.NewLine)

            '  Open connection using OleDbConnection.
            OleDbConnectionExample()
            Console.WriteLine(Environment.NewLine)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace