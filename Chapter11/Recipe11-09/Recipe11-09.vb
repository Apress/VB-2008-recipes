Imports System
Imports System.Net.NetworkInformation
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_09

        Public Shared Sub Main(ByVal args As String())

            '  Create an instance of the {ing class.
            Using png As New Ping
                Console.WriteLine("Pinging:")

                For Each comp As String In args

                    Try
                        Console.Write("    {0}...", comp)

                        '  Ping the specified computer with a time-out of 100ms.
                        Dim reply As PingReply = png.Send(comp, 100)

                        If reply.Status = IPStatus.Success Then
                            Console.WriteLine("Success - IP Address:{0} Time:{1}ms", reply.Address, reply.RoundtripTime)
                        Else
                            Console.WriteLine(reply.Status.ToString)
                        End If

                    Catch ex As Exception
                        Console.WriteLine("Error ({0})", ex.InnerException.Message)
                    End Try

                Next

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace

