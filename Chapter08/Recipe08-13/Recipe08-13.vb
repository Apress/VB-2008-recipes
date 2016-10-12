Imports System
Imports System.Data
Imports System.Data.Sql
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_13

        Public Shared Sub Main()

            '  Obtain the DataTable of SQL Server instances.
            Using sqlSources As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()

                '  Enumerate the set of SQL Servers and display details.
                Console.WriteLine("Discover SQL Server Instances:")

                For Each source As DataRow In sqlSources.Rows
                    Console.WriteLine(" Server Name:{0}", source("ServerName"))
                    Console.WriteLine(" Instance Name:{0}", source("InstanceName"))
                    Console.WriteLine(" Is Clustered:{0}", source("IsClustered"))
                    Console.WriteLine(" Version:{0}", source("Version"))
                    Console.WriteLine(Environment.NewLine)
                Next

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace