Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Lifetime
Namespace Apress.VisualBasicRecipes.Chapter11

    '  Define a class that extends MarshalByRefObject, making it remotable.
    Public Class Recipe11_17
        Inherits MarshalByRefObject
        Public Overrides Function InitializeLifetimeService() As Object

            Dim lease As ILease = DirectCast(MyBase.InitializeLifetimeService(), ILease)

            '  Lease can only be configured if it is in an initial state.
            If lease.CurrentState = LeaseState.Initial Then
                lease.InitialLeaseTime = TimeSpan.FromMinutes(10)
                lease.RenewOnCallTime = TimeSpan.FromMinutes(3)
            End If

            Return lease

        End Function
        Private Shared connectionString As String = "Data Source=.\sqlexpress;Initial Catalog=AdventureWorks;Integrated Security=SSPI;"

        '  The DataTable returned by this method is serializable, meaning that the
        '  data will be physically passed back to the caller across the network.
        Public Function GetContacts() As DataTable

            Dim SQL As String = "SELECT * FROM Person.Contact;"

            '  Create ADO.NET objects to execute the DB query.
            Dim con As New SqlConnection(connectionString)
            Dim com As New SqlCommand(SQL, con)
            Dim adapter As New SqlDataAdapter(com)
            Dim ds As New DataSet

            '  Execute the command.
            Try
                con.Open()
                adapter.Fill(ds, "Contacts")
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            Finally
                con.Close()
            End Try

            '  Return the first DataTable in the DataSet to the caller.
            Return ds.Tables(0)

        End Function
        '  This method allows you to verify that the object is running remotely.
        Public Function GetHostLocation() As String
            Return AppDomain.CurrentDomain.FriendlyName
        End Function

    End Class
End Namespace