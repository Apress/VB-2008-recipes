Imports System
Imports System.Text
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_12

        Private Shared localPort As Integer
        Public Shared Sub Main()

            '  Define the endpoint where messages are sent.
            Console.Write("Connect to IP: ")
            Dim ip As String = Console.ReadLine
            Console.Write("Connect to port: ")
            Dim port As Integer = Int32.Parse(Console.ReadLine)

            Dim remoteEndPoint As New IPEndPoint(IPAddress.Parse(ip), port)

            '  Define the local endpoint (where messages are received).
            Console.Write("Local port for listening: ")
            localPort = Int32.Parse(Console.ReadLine)

            '  Create a new thread for receiving incoming messages.
            Dim receiveThread As New Thread(AddressOf ReceiveData)
            receiveThread.IsBackground = True
            receiveThread.Start()

            Using client As New UdpClient
                Console.WriteLine("Type message and press Enter to send:")

                Try
                    Dim txt As String

                    Do
                        txt = Console.ReadLine

                        '  Send the text to the remote client.
                        If Not txt.Length = 0 Then
                            '  Encode the data to binary using UTF8 encoding.
                            Dim data As Byte() = Encoding.UTF8.GetBytes(txt)

                            '  Send the text to the remote client.
                            client.Send(data, data.Length, remoteEndPoint)
                        End If
                    Loop While Not txt.Length = 0
                Catch ex As Exception
                    Console.WriteLine(ex.ToString)
                Finally
                    client.Close()
                End Try
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        Private Shared Sub ReceiveData()

            Using client As New UdpClient(localPort)
                '  This is an endless loop, but since it is running in
                '  a background thread, it will be destroyed when the 
                '  application (the main thread) ends.
                While True

                    Try
                        '  Receive bytes.
                        Dim anyIP As New IPEndPoint(IPAddress.Any, 0)
                        Dim data As Byte() = client.Receive(anyIP)

                        '  Convert bytes to text using UTF8 encoding.
                        Dim txt As String = Encoding.UTF8.GetString(data)

                        '  Display the retrieved text.
                        Console.WriteLine(">> " & txt)

                    Catch ex As Exception
                        Console.WriteLine(ex.ToString)
                    End Try

                End While
            End Using

        End Sub

    End Class
End Namespace