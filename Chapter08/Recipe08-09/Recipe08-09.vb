Imports System
Imports System.Data
Imports System.Threading
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_09

        '  A method to handle asynchronous completion using callbacks.
        Public Shared Sub CallBackHandler(ByVal result As IAsyncResult)

            '  Obtain a reference to the SqlCommand used to initiate the
            '  asynchronous operation.
            Using cmd As SqlCommand = TryCast(result.AsyncState, SqlCommand)
                '  Obtain the result of the stored procedure.
                Using reader As SqlDataReader = cmd.EndExecuteReader(result)

                    '  Display the results of the stored procedure to the console.
                    '  To ensure the program is thread safe, SyncLock is used
                    '  to stop more than one thread from accessing the console
                    '  at the same time.
                    SyncLock Console.Out
                        Console.WriteLine("Bill of Materials:")
                        Console.WriteLine("ID     Description    Quantity    ListPrice")

                        While reader.Read
                            '  Display the record details.
                            Console.WriteLine("{0}   {1}   {2}   {3}", reader("ComponentID"), reader("ComponentDesc"), reader("TotalQuantity"), reader("ListPrice"))
                        End While

                    End SyncLock

                End Using
            End Using

        End Sub
        Public Shared Sub Main()

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                '  You must specify Asynchronous Processing=True to support
                '  asynchronous operations over the connection.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;Asynchronous Processing=true;"

                '  Create and configure a new command to run a stored procedure.
                Using cmd As SqlCommand = con.CreateCommand

                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "uspGetBillOfMaterials"

                    '  Create the required SqlParameter objects.
                    cmd.Parameters.Add("@StartProductID", SqlDbType.Int).Value = 771
                    cmd.Parameters.Add("@CheckDate", SqlDbType.DateTime).Value = DateTime.Parse("07/10/2000")

                    '  Open the database connection and execute the command
                    '  asynchronously.  Pass the reference to the SqlCommand
                    '  used to initiate the asynchronous operation.
                    con.Open()
                    cmd.BeginExecuteReader(AddressOf CallBackHandler, cmd)
                End Using

                '  Continue with other processing.
                For count As Integer = 1 To 10
                    SyncLock Console.Out
                        Console.WriteLine("{0} : Continue processing...", DateTime.Now.ToString("HH:mm:ss.ffff"))
                    End SyncLock
                    Thread.Sleep(500)
                Next

                '  Close the database connection.
                con.Close()

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete.  Press Enter.")
                Console.ReadLine()

            End Using
        End Sub
    End Class

End Namespace
