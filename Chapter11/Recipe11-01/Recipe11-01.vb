Imports System
Imports System.Net.NetworkInformation
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_01

        Public Shared Sub Main()

            'Only proceed if there is a network available.
            If NetworkInterface.GetIsNetworkAvailable Then
                '  Get the set of all NetworkInterface objects for the local
                '  machine.
                Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces

                '  Iterate through the itnerfaces and display information.
                For Each ni As NetworkInterface In interfaces
                    '  Report basic interface information.
                    Console.WriteLine("Interface Name: {0}", ni.Name)
                    Console.WriteLine("    Description: {0}", ni.Description)
                    Console.WriteLine("    ID: {0}", ni.Id)
                    Console.WriteLine("    Type: {0}", ni.NetworkInterfaceType)
                    Console.WriteLine("    Speed: {0}", ni.Speed)
                    Console.WriteLine("    Status: {0}", ni.OperationalStatus)

                    '  Report physical address.
                    Console.WriteLine("    Physical Address: {0}", ni.GetPhysicalAddress().ToString)

                    '  Report network statistics for the interface.
                    Console.WriteLine("    Bytes Sent: {0}", ni.GetIPv4Statistics().BytesSent)
                    Console.WriteLine("    Bytes Received: {0}", ni.GetIPv4Statistics.BytesReceived)

                    '  Report IP configuration.
                    Console.WriteLine("    IP Addresses:")
                    For Each addr As UnicastIPAddressInformation In ni.GetIPProperties.UnicastAddresses
                        Console.WriteLine("        - {0} (lease expires {1})", addr.Address, DateTime.Now.AddSeconds(addr.DhcpLeaseLifetime))
                    Next
                    Console.WriteLine(Environment.NewLine)

                Next
            Else
                Console.WriteLine("No network available.")
            End If

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace