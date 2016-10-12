Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_11Client

        Public Shared Sub Main()

            Using client As New TcpClient

                Console.WriteLine("Attempting to connect to the server on port 8000.")

                '  Connect to the server.
                client.Connect(IPAddress.Parse("127.0.0.1"), 8000)

                '  Create a BinaryWriter for writing to the stream.
                Using writer As New BinaryWriter(client.GetStream)

                    '  Start a dialogue.
                    writer.Write(Recipe11_11Shared.RequestConnect)

                    '  Create a BinaryReader for reading from the stream.
                    Using reader As New BinaryReader(client.GetStream)

                        If reader.ReadString = Recipe11_11Shared.AcknowledgeOK Then
                            Console.WriteLine("Connection established.  Press Enter to download data.")
                            Console.ReadLine()

                            '  Send message requesting data to server.
                            writer.Write(Recipe11_11Shared.RequestData)

                            '  The server should respond with the size of
                            '  the data it will send.  Assume it does.
                            Dim fileSize As Integer = Integer.Parse(reader.ReadString())

                            '  Only get part of the data then carry out a 
                            '  premature disconnect.
                            For i As Integer = 1 To fileSize / 3
                                Console.Write(client.GetStream.ReadByte)
                            Next

                            Console.WriteLine(Environment.NewLine)
                            Console.WriteLine("Press Enter to disconnect.")
                            Console.ReadLine()
                            Console.WriteLine("Disconnecting...")

                            writer.Write(Recipe11_11Shared.Disconnect)
                        Else
                            Console.WriteLine("Connection not completed.")
                        End If

                    End Using
                End Using
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace