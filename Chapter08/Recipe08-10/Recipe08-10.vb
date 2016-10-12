Imports System
Imports System.Data
Imports System.Data.Common
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_10

        Public Shared Sub Main()

            '  Obtain the list of ADO.NET data providers registered in the
            '  machine and application configuration file.
            Using providers As DataTable = DbProviderFactories.GetFactoryClasses

                '  Enumerate the set of data providers and display details.
                Console.WriteLine("Available ADO.NET Data Providers:")

                For Each prov As DataRow In providers.Rows
                    Console.WriteLine(" Name:{0}", prov("Name"))
                    Console.WriteLine("   Description:{0}", prov("Description"))
                    Console.WriteLine("   Invariant Name:{0}", prov("InvariantName"))
                Next

            End Using

            '  Obtain the DbProviderFactory for SQL Server.  The provider to use
            '  could be selected by the user or read from a configration file.
            '  In this case, we simply pass the invariant name.
            Dim factory As DbProviderFactory = DbProviderFactories.GetFactory("System.Data.SqlClient")

            '  Use the DbProviderFactory to create the initial IDbConnection, and
            '  then the data provider inteface factory methods for other objects.
            Using con As IDbConnection = factory.CreateConnection

                '  Normally, read the connection string from secure storage.
                '  See recipe 9-2.  In this case, use a default value.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"


                '  Create and configure a new command.
                Using com As IDbCommand = con.CreateCommand

                    com.CommandType = CommandType.Text
                    com.CommandText = "SET ROWCOUNT 10;SELECT prod.Name, inv.Quantity FROM Production.Product prod INNER JOIN Production.ProductInventory inv ON prod.ProductID = inv.ProductID ORDER BY inv.Quantity DESC;"

                    '  Open the connection.
                    con.Open()

                    '  Execute the command and process the results.
                    Using reader As IDataReader = com.ExecuteReader

                        Console.WriteLine(Environment.NewLine)
                        Console.WriteLine("Quantity of the Ten Most Stocked Products:")

                        While reader.Read
                            '  Display the product details.
                            Console.WriteLine("  {0} = {1}", reader("Name"), reader("Quantity"))
                        End While

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
