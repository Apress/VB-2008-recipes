Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_05
        '  Configure the maximum number of requests that can be
        '  handled concurrently.
        Private Shared maxRequestHandlers As Integer = 5

        '  An integer used to assign each HTTP request handler a unique
        '  identifier.
        Private Shared requestHandlerID As Integer = 0

        '  The HttpListener is the class that provides all the
        '  capabilities to receive and process HTTP requests.
        Private Shared listener As HttpListener
        Public Shared Sub Main()

            '  Quit gracefully if this feature is not supported.
            If Not HttpListener.IsSupported Then
                Console.WriteLine("You must be running this example on Windows XP SP2, Windows Server 2003, or higher to create an HttpListener.")

                Exit Sub
            End If

            '  Create the HttpListener.
            listener = New HttpListener

            '  Configure the URI prefixes that will map th the HttpListener.
            listener.Prefixes.Add("http://localhost:19080/VisualBasicRecipes/")
            listener.Prefixes.Add("http://localhost:20000/Recipe11-05/")

            '  Start the HttpListener before listening for incoming requests.
            Console.WriteLine("Starting HTTP Server")
            listener.Start()
            Console.WriteLine("HTTP Server started")
            Console.WriteLine(Environment.NewLine)

            '  Create a number of asynchronous request handlers up to
            '  the configurable maximum.  Give each a unique identifier.
            For count As Integer = 1 To maxRequestHandlers
                listener.BeginGetContext(AddressOf RequestHandler, "RequestHandler_" & Interlocked.Increment(requestHandlerID))
            Next

            '  Wait for the user to stop the HttpListener.
            Console.WriteLine("Press Enter to stop the HTTP Server.")
            Console.ReadLine()

            '  Stop accepting new requests.
            listener.Stop()

            '  Terminate the HttpListener without processing current requests.
            listener.Abort()

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        '  A method to asynchronously process individual requests
        '  and send responses.
        Private Shared Sub RequestHandler(ByVal result As IAsyncResult)

            Console.WriteLine("{0}: Activated.", result.AsyncState)

            Try
                '  Obtain the HttpListenerContext for the new request.
                Dim context As HttpListenerContext = listener.EndGetContext(result)

                Console.WriteLine("{0}: Processing HTTP Request from {1} ({2}).", result.AsyncState, context.Request.UserHostName, context.Request.RemoteEndPoint)

                '  Build the response using a StreamWriter feeding the
                '  Response.OutputStream.
                Dim sw As New StreamWriter(context.Response.OutputStream, Encoding.UTF8)

                sw.WriteLine("<html>")
                sw.WriteLine("<head>")
                sw.WriteLine("<title>Visual Basic Recipes</title>")
                sw.WriteLine("</head>")
                sw.WriteLine("<body>")
                sw.WriteLine("Recipe 11-05: " & result.AsyncState)
                sw.WriteLine("</body>")
                sw.WriteLine("</html>")
                sw.Flush()

                '  Configure the Response.
                context.Response.ContentType = "text/html"
                context.Response.ContentEncoding = Encoding.UTF8

                '  Close the Response to send it to the client.
                context.Response.Close()

                Console.WriteLine("{0}: Sent HTTP response.", result.AsyncState)
            Catch ex As ObjectDisposedException
                Console.WriteLine("{0}: HttpListener disposed--shutting down.", result.AsyncState)
            Finally
                '  Start another handler unless the HttpListener is closing.
                If listener.IsListening Then
                    Console.WriteLine("{0}: Creating new request handler.", result.AsyncState)

                    listener.BeginGetContext(AddressOf RequestHandler, "RequestHandler_" & Interlocked.Increment(requestHandlerID))
                End If
            End Try

        End Sub

    End Class

End Namespace
