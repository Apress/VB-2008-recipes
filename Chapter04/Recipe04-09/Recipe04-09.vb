Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_09

        ' Boolean to signal that the second thread should terminate.
        Public Shared terminate As Boolean = False

        '  A utility method for displaying useful trace information to the
        '  console along with details of the current thread.
        Private Shared Sub TraceMsg(ByVal msg As String)
            Console.WriteLine("[{0,3}] - {1} : {2}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:mm:ss.ffff"), msg)
        End Sub
        '  Declare the method that will be executed on the separate thead.
        '  The method waits on the EventWaitHandle before displaying a message
        '  to the console and then waits two seconds and loops.
        Private Shared Sub DisplayMessage()

            '  Obtain a handle to the EventWaitHandle with the name "EventExample".
            Dim eventHandle As EventWaitHandle = EventWaitHandle.OpenExisting("EventExample")

            TraceMsg("DisplayMessage Started.")

            While Not terminate
                '  Wait on the EventWaitHandle, time-out after two seconds. WaitOne
                '  returns true if the event is signaled; otherwise, false. The
                '  first time through, the message will be displayed immediately
                '  because the EventWaitHandle was created in a signaled state.
                If eventHandle.WaitOne(2000, True) Then
                    TraceMsg("EventWaitHandle In Signaled State.")
                Else
                    TraceMsg("WaitOne Time Out -- EventWaitHandle In Unsignaled State.")
                End If
                Thread.Sleep(2000)
            End While

            TraceMsg("Thread Terminating.")
        End Sub
        Public Shared Sub Main()

            '  Create a new EventWaitHandle with an initial signaled state, in
            '  manual mode, with the name "EventExample".
            Using eventHandle As New EventWaitHandle(True, EventResetMode.ManualReset, "EventExample")
                '  Create and start a new thread running the DisplayMessage
                '  method.
                TraceMsg("Starting DisplayMessageThread.")
                Dim newThread As New Thread(AddressOf DisplayMessage)
                newThread.Start()

                '  Allow the EventWaitHandle to be toggled between a signaled and
                '  unsignaled state up to three times before ending.
                For count As Integer = 1 To 3
                    '  Wait for Enter to be pressed.
                    Console.ReadLine()

                    '  You need to toggle the event. The only way to know the
                    '  current state is to wait on it with a 0 (zero) time-out
                    '  and test the result.
                    If eventHandle.WaitOne(0, True) Then
                        TraceMsg("Switching Event To UnSignaled State.")

                        '  Event is signaled, so unsignal it.
                        eventHandle.Reset()
                    Else
                        TraceMsg("Switching Event To Signaled State.")

                        '  Event is unsignaled, so signal it.
                        eventHandle.Set()
                    End If
                Next

                '  Terminate the DisplayMessage thread, and wait for it to
                '  complete before disposing of the EventWaitHandle.
                terminate = True
                eventHandle.Set()
                newThread.Join(5000)

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace