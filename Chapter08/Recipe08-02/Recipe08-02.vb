Imports System
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_02

        Public Shared Sub Main()

            '  Obtain a pooled connection.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;Min Pool Size=5;Max Pool Size=15;Connection Reset=True;Connection Lifetime=600;"

                '  Open the database connection.
                con.Open()

                '  Access the database...

                '  Close the database connection.
                '  This returns the connection to the pool for reuse.
                con.Close()

                '  At the end of the using block, the Dispose calls Close
                '  which returns the connection to the pool for reuse.
            End Using

            '  Obtain a non-pooled connection.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;Pooling=False;"

                '  Open the database connection.
                con.Open()

                '  Access the database...

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