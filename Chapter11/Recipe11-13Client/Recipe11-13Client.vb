Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.IO.Pipes

Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_13Client

        Public Shared Sub Main()

            Dim pipeClient As NamedPipeClientStream = Nothing
            Dim w As StreamWriter = Nothing
            Dim r As StreamReader = Nothing

            Try

                '  Create the named client pipe and configure it to support both
                '  input and output.
                pipeClient = New NamedPipeClientStream(".", "TestPipeServer", PipeDirection.InOut)

                Console.WriteLine("Connecting to TestPipeServer server...")

                '  Attempt to connect to the named server pipe.
                pipeClient.Connect()
                Console.WriteLine("Connection established with server.")

                '  Create a StreamWriter for writing to the stream.
                w = New StreamWriter(pipeClient)
                w.AutoFlush = True

                '  Create a StreamReader for reading from the stream.
                r = New StreamReader(pipeClient)

                '  Send some text to the server pipe.
                w.WriteLine("Hello Server.  I have some information to send.")

                '  Display text sent from the server pipe.
                Console.WriteLine("From Server:  {0}", r.ReadLine())
                Console.WriteLine("From Server:  {0}", r.ReadLine())

                '  Generate and send some sample information to the server pipe.
                Console.WriteLine("Sending some information to the server.")
                For i = 1 To 10
                    w.WriteLine(Guid.NewGuid().ToString())
                Next

                '  Send the text to trigger the server pipe to close.
                Console.WriteLine("Sending 'DONE' to the server.")
                w.WriteLine("Done")

            Catch ex As Exception
                '  Display any errors to the screen.
                Console.WriteLine(ex.ToString)
            Finally
                '  Close up the streams and make sure the pipe is shutdown.
                If w IsNot Nothing Then w.Close()
                If r IsNot Nothing Then r.Close()
                pipeClient.Close()
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()
        End Sub

    End Class

End Namespace
