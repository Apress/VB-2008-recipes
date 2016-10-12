Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_07

        '  A utility method for displaying useful trace information to the
        '  console along with details of the current thread.
        Private Shared Sub TraceMsg(ByVal msg As String)
            Console.WriteLine("[{0,3}] - {1} : {2}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:mm:ss.ffff"), msg)
        End Sub
        '  A private class used to pass initialization data to a new thread.
        Private Class ThreadStartData

            '  Member variables hold initialization data for a new thread.
            Private ReadOnly m_Iterations As Integer
            Private ReadOnly m_Message As String
            Private ReadOnly m_Delay As Integer
            Public Sub New(ByVal iterations As Integer, ByVal message As String, ByVal delay As Integer)
                m_Iterations = iterations
                m_Message = message
                m_Delay = delay
            End Sub
            '  Properties provide read-only access to initialization data.
            Public ReadOnly Property Iterations()
                Get
                    Return m_Iterations
                End Get
            End Property
            Public ReadOnly Property Message()
                Get
                    Return m_Message
                End Get
            End Property
            Public ReadOnly Property Delay()
                Get
                    Return m_Delay
                End Get
            End Property
        End Class
        '  Declare the method that will be executed in its own thread. The
        '  method displays a message to the console a specified number of
        '  times, sleeping between each message for a specified duration.
        Private Shared Sub DisplayMessage(ByVal config As Object)
            Dim data As ThreadStartData = TryCast(config, ThreadStartData)

            If Not data Is Nothing Then
                For count As Integer = 0 To data.Iterations - 1
                    TraceMsg(data.Message)

                    '  Sleep for the specified period.
                    Thread.Sleep(data.Delay)
                Next
            Else
                TraceMsg("Invalid thread configuration.")
            End If

        End Sub
        Public Shared Sub Main()

            '  Create a new Thread object specifying DisplayMessage
            '  as the method it will execute.
            Dim newThread As New Thread(AddressOf DisplayMessage)

            '  Create a new ThreadStartData object to configure the thread.
            Dim config As New ThreadStartData(5, "A thread example.", 500)

            TraceMsg("Starting new thread.")

            '  Start the new thread and pass the ThreadStartData object
            '  containing the initialization data.
            newThread.Start(config)

            '  Continue with other processing.
            For count As Integer = 0 To 12
                TraceMsg("Main thread continuing processing...")
                Thread.Sleep(200)
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
