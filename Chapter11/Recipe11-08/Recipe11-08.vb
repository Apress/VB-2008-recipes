Imports System
Imports System.Net
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_08

        Public Shared Sub Main(ByVal args As String())

            For Each comp As String In args

                Try
                    '  Retrieve the DNS entry for the specified computer.
                    Dim dnsEntry As IPHostEntry = Dns.GetHostEntry(comp)

                    '  The DNS entry may contain more than one IP address.  Iterate
                    '  through them and display each one along with the type of 
                    '  address (AddressFamily).
                    For Each address As IPAddress In dnsEntry.AddressList
                        Console.WriteLine("{0} = {1} ({2})", comp, address, address.AddressFamily)
                    Next
                Catch ex As Exception
                    Console.WriteLine("{0} = Error ({1})", comp, ex.Message)
                End Try
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace