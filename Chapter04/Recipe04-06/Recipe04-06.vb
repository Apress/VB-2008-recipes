Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_06

        '  A method that is executed when the AutoResetEvent is signaled
        '  or the wait operation times out.
        Private Shared Sub ResetEventHandler(ByVal state As Object, ByVal timedOut As Boolean)

            '  Display an appropriate message tot he console based on whether
            '  the wait timed out or the AutoResetEvent was signaled.
            If timedOut Then
                Console.WriteLine("{0} : Wait timed out.", DateTime.Now.ToString("HH:mm:ss.ffff"))
            Else
                Console.WriteLine("{0} : {1}", DateTime.Now.ToString("HH:mm:ss.ffff"), state)
            End If

        End Sub
        Public Shared Sub Main()

            '  Create the new AutoResetEvent in an unsignaled state.
            Dim autoEvent As New AutoResetEvent(False)

            '  Create the state object that is passed to the event handler
            '  method when it is triggered. In this case, a message to display.
            Dim state As String = "AutoResetEvent signaled."

            '  Register the ResetEventHandler method to wait for the AutoResetEvent
            '  to be signaled. Set a time-out of 3 seconds and configure the wait
            '  event to reset after activation (last argument).
            Dim handle As RegisteredWaitHandle = ThreadPool.RegisterWaitForSingleObject(autoEvent, AddressOf ResetEventHandler, state, 3000, False)

            Console.WriteLine("Press ENTER to signal the AutoResetEvent or enter ""CANCEL"" to unregister the wait operation.")

            While Not Console.ReadLine.ToUpper = "CANCEL"
                '  If "CANCEL" has not been entered into the console, signal
                '  the AutoResetEvent, which will cause the EventHandler
                '  method to execute. The AutoResetEvent will automatically
                '  revert to an unsignaled state.
                autoEvent.Set()
            End While

            '  Unregister the wait operation.
            Console.WriteLine("Unregistering wait operation.")
            handle.Unregister(Nothing)

            '  Wait to continue.
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
