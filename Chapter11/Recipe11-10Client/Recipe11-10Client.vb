Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_10Client

        Public Shared Sub Main()

            Dim client As New TcpClient

            Try

                Console.WriteLine("Attempting to connect to the server on port 8000.")
                client.Connect(IPAddress.Parse("127.0.0.1"), 8000)
                Console.WriteLine("Connection established.")

                '  Retrieve the network stream.
                Dim stream As NetworkStream = client.GetStream

                '  Create a BinaryWriter for writing to the stream.
                Using w As New BinaryWriter(stream)
                    '  Create a BinaryReader for reading from the stream.
                    Using r As New BinaryReader(stream)
                        '  Start a dialogue.
                        w.Write(Recipe11_10Shared.RequestConnect)

                        If r.ReadString = Recipe11_10Shared.AcknowledgeOK Then
                            Console.WriteLine("Connected.")
                            Console.WriteLine("Press Enter to disconnect.")
                            Console.ReadLine()
                            Console.WriteLine("Disconnecting...")
                            w.Write(Recipe11_10Shared.Disconnect)
                        Else
                            Console.WriteLine("Connection not completed.")
                        End If

                    End Using
                End Using

            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            Finally
                '  Close the conenction socket.
                client.Close()
                Console.WriteLine("Port closed.")
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace