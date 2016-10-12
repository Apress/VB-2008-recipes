Imports System
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.Data
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_16

        Public Shared Sub Main()

            '  Register a new HTTP Remoting channel to communicate with the
            '  remote object.
            ChannelServices.RegisterChannel(New HttpChannel, False)

            '  Register the classes that will be accessed remotely.
            RemotingConfiguration.RegisterWellKnownClientType(GetType(Recipe11_14), "http://localhost/RemoteObjects/Recipe11-14.rem")

            '  Now any attempts to instantiate the Recipe11_14 class
            '  will actually create a proxy to a remote instance.

            '  Interact with the remote object through a proxy.
            Dim proxy As New Recipe11_14

            Try
                '  Display the name of the component host application domain
                '  where the object executes.
                Console.WriteLine("Object executing in: " & proxy.GetHostLocation)
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            End Try


            '  Get the datatable from the remote object and display its contents.
            Dim dt As DataTable = proxy.GetContacts

            For Each row As DataRow In dt.Rows
                Console.WriteLine("{0}, {1}", row("LastName"), row("FirstName"))
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace