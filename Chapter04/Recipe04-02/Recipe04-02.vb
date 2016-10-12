Imports System
Imports System.Threading
Imports System.Collections
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_02

        '  A utility method for displaying useful trace information to the
        '  console along with details of the current thread.
        Private Shared Sub TraceMsg(ByVal currentTime As DateTime, ByVal msg As String)

            Console.WriteLine("[{0,3}/{1}] - {2} : {3}", Thread.CurrentThread.ManagedThreadId, IIf(Thread.CurrentThread.IsThreadPoolThread, "pool", "fore"), currentTime.ToString("HH:mm:ss.ffff"), msg)

        End Sub

        '  A delegate that allows you to perform asynchronous execution of
        '  LongRunningMethod.
        Public Delegate Function AsyncExampleDelegate(ByVal delay As Integer, ByVal name As String) As DateTime

        '  A simulated long-running method.
        Public Shared Function LongRunningMethod(ByVal delay As Integer, ByVal name As String) As DateTime

            TraceMsg(DateTime.Now, name & " example - thread starting.")

            '  Simulate time-consuming process.
            Thread.Sleep(delay)

            TraceMsg(DateTime.Now, name & " example - thread stopping.")

            '  Return the method's completion time.
            Return DateTime.Now

        End Function

        '  This method executes LongRunningMethod asynchronously and continues
        '  with other processing.  Once the processing is complete, the method
        '  blocks until LongRunningMethod completes.
        Public Shared Sub BlockingExample()

            Console.WriteLine(Environment.NewLine & "*** Running Blocking Example ***")

            '  Invoke LongRunningMethod asynchronously.  Pass nothing for both the
            '  callback delegate and the asynchronous state object.
            Dim longMethod As AsyncExampleDelegate = AddressOf LongRunningMethod
            Dim asyncResult As IAsyncResult = longMethod.BeginInvoke(2000, "Blocking", Nothing, Nothing)

            '  Perform other processing until ready to block.
            For count As Integer = 1 To 3
                TraceMsg(DateTime.Now, "Continue processing until ready to block...")

                Thread.Sleep(300)
            Next

            '  Block until the asynchronous method completes.
            TraceMsg(DateTime.Now, "Blocking until method is complete...")

            '  Obtain the completion data for the asynchronous method.
            Dim completion As DateTime = DateTime.MinValue

            Try
                completion = longMethod.EndInvoke(asyncResult)
            Catch ex As Exception
                '  Catch and handle those exceptions you would if calling
                '  LongRunningMethod directly.
            End Try

            '  Display completion information.
            TraceMsg(completion, "Blocking example complete.")

        End Sub
        '  This method executes LongRunningMethod asynchronously and then
        '  enters a polling loop until LongRunningMethod completes.
        Public Shared Sub PollingExample()

            Console.WriteLine(Environment.NewLine & "*** Running Polling Example ***")

            '  Invoke LongRunningMethod asynchronously.  Pass nothing for both the
            '  callback delegate and the asynchronous state object.
            Dim longMethod As AsyncExampleDelegate = AddressOf LongRunningMethod
            Dim asyncResult As IAsyncResult = longMethod.BeginInvoke(2000, "Polling", Nothing, Nothing)

            '  Poll the asynchronous method to test for completion.  If not
            '  complete, sleep for 300ms before polling again.
            TraceMsg(DateTime.Now, "Poll repeatedly until method is complete.")

            While Not asyncResult.IsCompleted
                TraceMsg(DateTime.Now, "Polling...")
                Thread.Sleep(300)
            End While

            '  Obtain the completion data for the asynchronous method.
            Dim completion As DateTime = DateTime.MinValue

            Try
                completion = longMethod.EndInvoke(asyncResult)
            Catch ex As Exception
                '  Catch and handle those exceptions you would if calling
                '  LongRunningMethod directly.
            End Try

            '  Display completion information.
            TraceMsg(completion, "Polling example complete.")

        End Sub
        '  This method executes LongRunningMethod asychronously and then
        '  uses a WaitHandle to wait efficiently until LongRunningMethod
        '  completes. Use of a time-out allows the method to break out of
        '  waiting in order to update the user interface or fail if the
        '  asynchronous method is taking too long.
        Public Shared Sub WaitingExample()

            Console.WriteLine(Environment.NewLine & "*** Running Waiting Example ***")

            '  Invoke LongRunningMethod asynchronously.  Pass nothing for both the
            '  callback delegate and the asynchronous state object.
            Dim longMethod As AsyncExampleDelegate = AddressOf LongRunningMethod
            Dim asyncResult As IAsyncResult = longMethod.BeginInvoke(2000, "Waiting", Nothing, Nothing)

            '  Wait for the asynchronous method to complete.  Time-out after
            '  300ms and display status to the console before continuing to
            '  wait.
            TraceMsg(DateTime.Now, "Waiting until method is complete.")

            While Not asyncResult.AsyncWaitHandle.WaitOne(300, False)
                TraceMsg(DateTime.Now, "Wait timeout...")
            End While

            '  Obtain the completion data for the asynchronous method.
            Dim completion As DateTime = DateTime.MinValue

            Try
                completion = longMethod.EndInvoke(asyncResult)
            Catch ex As Exception
                '  Catch and handle those exceptions you would if calling
                '  LongRunningMethod directly.
            End Try

            '  Display completion information.
            TraceMsg(completion, "Waiting example complete.")

        End Sub
        '  This method executes LongRunningMethod asynchronously multiple
        '  times and then uses an array of WaitHandle objects to wait
        '  efficiently until all of the methos are complete. Use of a 
        '  time-out allows the method to break out of waiting in order to
        '  update the user interface or fail if the asynchronous method
        '  is taking too long.
        Public Shared Sub WaitAllExample()

            Console.WriteLine(Environment.NewLine & "*** Running WaitAll Example ***")

            '  An ArrayList to hold the IAsyncResult instances for each of the
            '  asynchonrous methods started.
            Dim asyncResults As New ArrayList(3)

            '  Invoke three LongRunningMethod asynchronously.  Pass nothing for 
            '  both the callback delegate and the asynchronous state object. Add
            '  the IAsyncResult instance for each method to the ArrayList.
            Dim longMethod As AsyncExampleDelegate = AddressOf LongRunningMethod

            asyncResults.Add(longMethod.BeginInvoke(3000, "WaitAll 1", Nothing, Nothing))
            asyncResults.Add(longMethod.BeginInvoke(2500, "WaitAll 2", Nothing, Nothing))
            asyncResults.Add(longMethod.BeginInvoke(1500, "WaitAll 3", Nothing, Nothing))

            '  Create an array of WaitHandle objects that will be used to wait
            '  for the completion of all the asynchronous methods.
            Dim waitHandles As WaitHandle() = New WaitHandle(2) {}

            For count As Integer = 0 To 2
                waitHandles(count) = DirectCast(asyncResults(count), IAsyncResult).AsyncWaitHandle
            Next

            '  Wait for all three asynchronous methods to complete.  Time out
            '  after 300ms and display status to the console before continuing
            '  to wait.
            TraceMsg(DateTime.Now, "Waiting until all 3 methods are complete...")

            While Not WaitHandle.WaitAll(waitHandles, 300, False)
                TraceMsg(DateTime.Now, "WaitAll timeout...")
            End While

            '  Inspect the completion data for each method, and determine the
            '  time at which the final method completed.
            Dim completion As DateTime = DateTime.MinValue

            For Each result As IAsyncResult In asyncResults
                Try
                    Dim completedTime As DateTime = longMethod.EndInvoke(result)
                    If completedTime > completion Then completion = completedTime
                Catch ex As Exception
                    '  Catch and handle those exceptions you would if calling
                    '  LongRunningMethod directly.
                End Try
            Next

            '  Display completion information.
            TraceMsg(completion, "WaitAll example complete.")

        End Sub
        '  This method executes LongRunningMethod asnchronously and passes
        '  an AsyncCallback delegate instance. The referenced CallbackHandler
        '  method is called automatically when the asynchronous method
        '  completes, leaving this method free to continue processing.
        Public Shared Sub CallbackExample()

            Console.WriteLine(Environment.NewLine & "*** Running Callback Example ***")

            '  Invoke LongRunningMethod asynchronously.  Pass an AsyncCallback
            '  delegate instance referencing the CallbackHandler method that
            '  will be called automatically when the asynchronous method
            '  completes. Pass a reference to the ASyncExampleDelegate delegate
            '  instance as asynchronous state; otherwise, the callback method
            '  has no access to the delegate instance in order to call EndInvoke.
            Dim longMethod As AsyncExampleDelegate = AddressOf LongRunningMethod
            Dim asyncResult As IAsyncResult = longMethod.BeginInvoke(2000, "Callback", AddressOf CallbackHandler, longMethod)

            '  Continue with other processing.
            For count As Integer = 0 To 15
                TraceMsg(DateTime.Now, "Continue processing...")
                Thread.Sleep(300)
            Next

        End Sub
        '  A method to handle asynchronous completion using callbacks.
        Public Shared Sub CallbackHandler(ByVal result As IAsyncResult)
            '  Extract the reference to the AsyncExampleDelegate instance
            '  from the IAsyncResult instance. This allows you to obtain the
            '  completion data.
            Dim longMethod As AsyncExampleDelegate = DirectCast(result.AsyncState, AsyncExampleDelegate)

            '  Obtain the completion data for the asynchronous method.
            Dim completion As DateTime = DateTime.MinValue

            Try
                completion = longMethod.EndInvoke(result)
            Catch ex As Exception
                '  Catch and handle those exceptions you would if calling
                '  LongRunningMethod directly.
            End Try

            '  Display completion information.
            TraceMsg(completion, "Callback example complete.")

        End Sub
        <MTAThread()> _
        Public Shared Sub Main()

            '  Demonstrate the various approaches to asynchronous method completion.
            BlockingExample()
            PollingExample()
            WaitingExample()
            WaitAllExample()
            CallbackExample()

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
