Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_10Server

        Public Shared Sub Main()

            '  Create a new listener on port 8000.
            Dim listener As New TcpListener(IPAddress.Parse("127.0.0.1"), 8000)

            Console.WriteLine("About to initialize port.")
            listener.Start()
            Console.WriteLine("Listening for a connection...")

            Try
                '  Wait for a connection request, and return a TcpClient
                '  initialized for communication.
                Using client As TcpClient = listener.AcceptTcpClient
                    Console.WriteLine("Connection accepted.")

                    '  Retrieve the network stream.
                    Dim stream As NetworkStream = client.GetStream()

                    '  Create a BinaryWriter for writing to the stream.
                    Using w As New BinaryWriter(stream)
                        '  Create a BinaryReader for reading from the stream.
                        Using r As New BinaryReader(stream)

                            If r.ReadString = Recipe11_10Shared.RequestConnect Then
                                w.Write(Recipe11_10Shared.AcknowledgeOK)
                                Console.WriteLine("Connection completed.")

                                While Not r.ReadString = Recipe11_10Shared.Disconnect
                                End While

                                Console.WriteLine(Environment.NewLine)
                                Console.WriteLine("Disconnect request received.")
                            Else
                                Console.WriteLine("Can't complete connection.")
                            End If

                        End Using
                    End Using
                End Using

                Console.WriteLine("Connection closed.")

            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            Finally
                '  Close the underlying socket (stop listening for a
                '  new requests).
                listener.Stop()
                Console.WriteLine("Listener stopped.")
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace