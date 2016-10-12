Imports System
Imports System.Net.NetworkInformation
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_02

        ' Declare a method to handle NetworkAvailabilityChanged events.
        Private Shared Sub NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As NetworkAvailabilityEventArgs)

            '  Report whether the network is now available or unavailable.
            If e.IsAvailable Then
                Console.WriteLine("Network Available")
            Else
                Console.WriteLine("Network Unavailable")
            End If

        End Sub
        '  Declare a method to handle NetworkAddressChanged events.
        Private Shared Sub NetworkAddressChanged(ByVal sender As Object, ByVal e As EventArgs)

            Console.WriteLine("Current IP Addresses:")

            '  Iterate through the interfaces and display information.
            For Each ni As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
                For Each addr As UnicastIPAddressInformation In ni.GetIPProperties.UnicastAddresses
                    Console.WriteLine("        - {0} (lease expires {1})", addr.Address, DateTime.Now.AddSeconds(addr.DhcpLeaseLifetime))
                Next
            Next

        End Sub
        Public Shared Sub Main()

            '  Add the handlers to the NetworkChange events.
            AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf NetworkAvailabilityChanged
            AddHandler NetworkChange.NetworkAddressChanged, AddressOf NetworkAddressChanged


            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Press Enter to stop waiting for network events.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace