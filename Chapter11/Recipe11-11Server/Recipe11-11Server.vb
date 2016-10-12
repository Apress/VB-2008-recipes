Imports System
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Net.Sockets
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_11Server

        '  A flag used to indicate whether the server is shutting down.
        Private Shared m_Terminate As Boolean
        Public Shared ReadOnly Property Terminate() As Boolean
            Get
                Return m_Terminate
            End Get
        End Property

        '  A variable to track the identity of each client connection.
        Private Shared ClientNumber As Integer = 0

        '  A single TcpListener will accept all incoming client connections.
        Private Shared listener As TcpListener
        Public Shared Sub Main()

            '  Create a 100kb test file for use in the example.  This file will
            '  be sent to clients that connect.
            Using fs As New FileStream("test.bin", FileMode.Create)
                fs.SetLength(100000)
            End Using

            Try
                '  Create a TcpListener that will accept incoming client
                '  connections on port 8000 of the local machine.
                listener = New TcpListener(IPAddress.Parse("127.0.0.1"), 8000)

                Console.WriteLine("Starting TcpListener...")

                '  Start the TcpListener accepting connections.
                m_Terminate = False
                listener.Start()

                '  Begin asynchronously listening for client connections.  When a 
                '  new connection is established, call the ConnectionHandler method
                '  to process the new connection.
                listener.BeginAcceptTcpClient(AddressOf ConnectionHandler, Nothing)

                '  Keep the server active until the user presses Enter.
                Console.WriteLine("Server awaiting connections.  Press Enter to stop server.")
                Console.ReadLine()

            Finally
                '  Shut down the TcpListener.  This will cause any outstanding
                '  asynchronous requests to stop and throw an exception in
                '  the ConnectionHandler when EndAcceptTcpClient is called.
                '  A More robust termination synchronization may be desired here,
                '  but for the purpose of this example, ClientHandler threads
                '  are all background threads and will terminate automatically when
                '  the main thread terminates.  This is a suitable for our needs.
                Console.WriteLine("Server stopping...")
                m_Terminate = True
                If listener IsNot Nothing Then listener.Stop()

            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        '  A method to handle the callback when a connection is established
        '  from a client.  This is a simple way to implement a dispatcher
        '  but lacks te control and scalability required when implementing
        '  full-blown asychnronous server applications.
        Private Shared Sub ConnectionHandler(ByVal result As IAsyncResult)

            Dim client As TcpClient = Nothing

            '  Always end the asynchronous operation to avoid leaks.
            Try
                '  Get the TcpClient that represents the new Client connection.
                client = listener.EndAcceptTcpClient(result)
            Catch ex As ObjectDisposedException
                '  The server is shutting down and the outstanding asynchronous
                '  request calls the completion method with this exception.
                '  The exception is thrown when EndAccptTcpClient is called.
                '  Do nothing and return.
                Exit Sub
            End Try

            Console.WriteLine("Dispatcher:  New connection accepted.")

            '  Begin asynchronously lsitening for the next client
            '  connection.
            listener.BeginAcceptTcpClient(AddressOf ConnectionHandler, Nothing)

            If client IsNot Nothing Then
                '  Determine the identifier for the new client connection.
                Interlocked.Increment(ClientNumber)

                Dim clientName As String = "Client " & ClientNumber.ToString

                Console.WriteLine("Dispatcher: Creating client handler ({0})", clientName)

                '  Create a new ClientHandler to handle this conenction.
                Dim blah As New ClientHandler(client, clientName)

            End If

        End Sub

    End Class
    '  A class that encapsulates the logic to handle a client connection.
    Public Class ClientHandler

        '  The TcpClient that represents the connection to the client.
        Private client As TcpClient

        '  A name that uniquely identifies this ClientHandler.
        Private clientName As String

        '  The amount of data that will be written in one block (2 KB).
        Private bufferSize As Integer = 2048

        '  The buffer that holds the data to write.
        Private buffer As Byte()

        '  Used to read data from the local file.
        Private testFile As FileStream

        '  A signal to stop sending data to the client.
        Private stopDataTransfer As Boolean
        Public Sub New(ByVal cli As TcpClient, ByVal cliID As String)

            Me.buffer = New Byte(bufferSize) {}
            Me.client = cli
            Me.clientName = cliID

            '  Create a new background thread to handle the client connection
            '  so that we do not consume a thread-pool thread for a long time
            '  and also so that it will be terminated when the main thread ends.
            Dim newThread As New Thread(AddressOf ProcessConnection)
            newThread.IsBackground = True
            newThread.Start()

        End Sub
        Private Sub ProcessConnection()

            Using client

                '  Create a BinaryReader to receive messages from the client.  At
                '  the end of the using block, it will close both the BinaryReader
                '  and the underlying NetworkStream.
                Using reader As New BinaryReader(client.GetStream)

                    If reader.ReadString = Recipe11_11Shared.RequestConnect Then

                        '  Create a BinaryWriter to send messages to the client.
                        '  At the end of the using blcok, it will close both the
                        '  BinaryWriter and the underlying NetworkStream.
                        Using writer As New BinaryWriter(client.GetStream)

                            writer.Write(Recipe11_11Shared.AcknowledgeOK)
                            Console.WriteLine(clientName & ": Connection established.")

                            Dim message As String = ""

                            While Not message = Recipe11_11Shared.Disconnect

                                Try
                                    '  Read the message from the client.
                                    message = reader.ReadString
                                Catch ex As Exception
                                    '  For the purpose of the example, any exception should be
                                    '  taked as a client disconnect.
                                    message = Recipe11_11Shared.Disconnect
                                End Try

                                If message = Recipe11_11Shared.RequestData Then

                                    Console.WriteLine(clientName & ": Requested data.", "Sending...")

                                    '  The filename could be supplied by the client,
                                    '  but in this example, a test file is hard-coded.
                                    testFile = New FileStream("test.bin", FileMode.Open, FileAccess.Read)

                                    '  Send the file-size--this is how the client
                                    '  knows how much to read.
                                    writer.Write(testFile.Length.ToString)

                                    '  Start an asynchronous send operation.
                                    stopDataTransfer = False
                                    StreamData(Nothing)
                                ElseIf message = Recipe11_11Shared.Disconnect Then
                                    Console.WriteLine(clientName & ": Client disconnecting...")
                                    stopDataTransfer = True
                                Else
                                    Console.WriteLine(clientName & ": Unknown command.")
                                End If
                            End While
                        End Using
                    Else
                        Console.WriteLine(clientName & ": Could not establish conenction.")
                    End If
                End Using
            End Using
            Console.WriteLine(clientName & ": Client connection closed.")

        End Sub
        Private Sub StreamData(ByVal asyncResult As IAsyncResult)

            '  Always complete outstanding asynchronous operations to avoid
            '  leaks.
            If asyncResult IsNot Nothing Then

                Try
                    client.GetStream.EndWrite(asyncResult)
                Catch ex As Exception
                    '  For the purpose of the example, any exception obtaining
                    '  or writing to the network should just terminate the
                    '  download.
                    testFile.Close()
                    Exit Sub
                End Try

            End If

            '  Check if the code has been triggerd to stop.
            If Not stopDataTransfer And Not Recipe11_11Server.Terminate Then
                '  Read the next block from the file.
                Dim bytesRead As Integer = testFile.Read(buffer, 0, buffer.Length)

                '  If no bytes are read, the stream is at the end of the file.
                If bytesRead > 0 Then
                    Console.WriteLine(clientName & ": Streaming next block.")

                    '  Write the next block to the network stream.
                    client.GetStream.BeginWrite(buffer, 0, buffer.Length, AddressOf StreamData, Nothing)
                Else
                    '  End the operation.
                    Console.WriteLine(clientName & ": File streaming complete.")
                    testFile.Close()
                End If
            Else
                '  Client disconnected.
                Console.WriteLine(clientName & ": Client disconnected.")
                testFile.Close()
            End If

        End Sub
    End Class

End Namespace