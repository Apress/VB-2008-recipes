Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_10

        ' Boolean to signal that the second thread should terminate.
        Public Shared terminate As Boolean = False

        '  A utility method for displaying useful trace information to the
        '  console along with details of the current thread.
        Private Shared Sub TraceMsg(ByVal msg As String)
            Console.WriteLine("[{0,3}] - {1} : {2}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:mm:ss.ffff"), msg)
        End Sub
        '  Declare the method that will be executed on the separate thead.
        '  In a loop the method waits to obtain a Mutex before displaying a
        '  a message to the console and then waits one second before releasing
        '  the Mutex.
        Private Shared Sub DisplayMessage()

            '  Obtain a handle to the Mutex with the name "MutexExample".
            '  Do not attempt to take ownership immediately.
            Using newMutex As New Mutex(False, "MutexExample")
                TraceMsg("Thread Started.")

                While Not terminate
                    '  Wait on the Mutex.
                    newMutex.WaitOne()

                    TraceMsg("Thread owns the Mutex.")
                    Thread.Sleep(1000)
                    TraceMsg("Thread releasing the Mutex.")

                    '  Release the Mutex.
                    newMutex.ReleaseMutex()

                    '  Sleep a little to give another thread a good chance of
                    '  acquiring the Mutex.
                    Thread.Sleep(100)
                End While
                TraceMsg("Thread terminating.")
            End Using
        End Sub
        Public Shared Sub Main()

            TraceMsg("Starting threads -- press Enter to terminate.")

            '  Create and start three new threads running the
            '  DisplayMessage method.
            Dim thread1 As New Thread(AddressOf DisplayMessage)
            Dim thread2 As New Thread(AddressOf DisplayMessage)
            Dim thread3 As New Thread(AddressOf DisplayMessage)

            thread1.Start()
            thread2.Start()
            thread3.Start()

            '  Wait for Enter to be pressed.
            Console.ReadLine()

            '  Terminate the DisplayMessage threads, and wait for them to
            '  complete before disposing of the Mutex.
            terminate = True
            thread1.Join(5000)
            thread2.Join(5000)
            thread3.Join(5000)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
