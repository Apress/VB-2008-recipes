Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.IO.Pipes

Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_13Server

        Public Shared Sub Main()

            Dim namedPipeServer As NamedPipeServerStream = Nothing
            Dim w As StreamWriter = Nothing
            Dim r As StreamReader = Nothing

            Try
                '  Create the named server pipe and configure it to support both
                '  input and output.
                namedPipeServer = New NamedPipeServerStream("TestPipeServer", PipeDirection.InOut)
                Console.WriteLine("Waiting for client connection...")

                '  Wait for clients to connect to the named pipe.
                namedPipeServer.WaitForConnection()
                Console.WriteLine("Connection established with client.")

                '  Create a StreamReader for reading from the stream.
                r = New StreamReader(namedPipeServer)

                '  Create a StreamWriter for writing to the stream.
                w = New StreamWriter(namedPipeServer)
                w.AutoFlush = True

                Console.WriteLine("From Client:  {0}", r.ReadLine())

                '  Send a couple messages to the client pipe.
                w.WriteLine("Welcome to the server.  Please send me some information.")
                w.WriteLine("Send the string 'DONE' when you are done.")

                '  Keep reading information from the pipe until the text
                '  "DONE" is sent.
                Dim msg As String
                Do
                    msg = r.ReadLine()
                    Console.WriteLine("From Client:  {0}", msg)

                Loop Until msg.ToUpper() = "DONE"
                Console.WriteLine("The server has been disconnected.")
            Catch ex As Exception
                '  Display any errors to the screen.
                Console.WriteLine(ex.ToString)
            Finally
                '  Close up the streams and make sure the pipe is shutdown.
                w.Close()
                r.Close()

                If namedPipeServer.IsConnected = True Then namedPipeServer.Disconnect()
                namedPipeServer.Close()
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
