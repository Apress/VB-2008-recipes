Imports System
Imports System.Reflection
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_15

        Public Shared Sub Main(ByVal args As String())

            '  Ensure there is an argument, we assume it is a valid
            '  filename.
            If Not args.Length = 1 Then Exit Sub

            '  Register a new TCP Remoting channel to communicate with
            '  the remote object.
            ChannelServices.RegisterChannel(New TcpChannel(19080), False)

            '  Get the registered Remoting channel.
            Dim channel As TcpChannel = DirectCast(ChannelServices.RegisteredChannels(0), TcpChannel)

            '  Create an Assembly object representing the assembly
            '  where remotable classes are defined.
            Dim remoteAssembly As Assembly = Assembly.LoadFrom(args(0))

            '  Process all the public types in the specified assembly.
            For Each remType As Type In remoteAssembly.GetExportedTypes()

                '  Check if type is remotable.
                If remType.IsSubclassOf(GetType(MarshalByRefObject)) Then
                    '  Register each type using the type name as the URI.
                    Console.WriteLine("Registering {0}", remType.Name)
                    RemotingConfiguration.RegisterWellKnownServiceType(remType, remType.Name, WellKnownObjectMode.SingleCall)

                    '  Determine the URL where this type is published.
                    Dim urls As String() = channel.GetUrlsForUri(remType.Name)
                    Console.WriteLine("Url:  {0}", urls(0))
                End If

            Next

            '  As long as this application is running, the registered remote
            '  objects will be accessible.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Press Enter to shut down the host.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace
