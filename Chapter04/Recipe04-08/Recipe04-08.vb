Imports System
Imports System.Threading
Imports System.Collections.Generic
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_08

        '  Declare an object for synchronization of access to the console.
        '  A shared object is used because you are using it in shared methods.
        Private Shared consoleGate As New Object

        '  Declare a Queue to represent the work queue.
        Private Shared workQueue As New Queue(Of String)

        '  Declare a flag to indicate to activated threads that they should
        '  terminate and not process more work items.
        Private Shared workItemsProcessed As Boolean = False
        '  A utility method for displaying useful trace information to the
        '  console along with details of the current thread.
        Private Shared Sub TraceMsg(ByVal msg As String)

            SyncLock consoleGate
                Console.WriteLine("[{0,3}/{1}] - {2} : {3}", Thread.CurrentThread.ManagedThreadId, IIf(Thread.CurrentThread.IsThreadPoolThread, "pool", "fore"), DateTime.Now.ToString("HH:mm:ss.ffff"), msg)
            End SyncLock

        End Sub
        '  Declare the method that will be executed by each thread to process
        '  items from the work queue.
        Private Shared Sub ProcessWorkItems()

            '  A local variable to hold the work item taken from the work queue.
            Dim workItem As String = Nothing

            TraceMsg("Thread started, processing items from the queue...")

            '  Process items from the work queue until termination is signaled.
            While Not workItemsProcessed
                '  Obtain the lock on the work queue.
                Monitor.Enter(workQueue)

                Try
                    '  Pop the next work item and process it, or wait if none
                    '  are available.
                    If workQueue.Count = 0 Then
                        TraceMsg("No work items, waiting...")

                        '  Wait until Pulse is called on the workQueue object.
                        Monitor.Wait(workQueue)
                    Else
                        '  Obtain the next work item.
                        workItem = workQueue.Dequeue
                    End If
                Catch
                Finally
                    '  Always release the lock.
                    Monitor.Exit(workQueue)
                End Try

                '  Process the work item if one was obtained.
                If Not workItem Is Nothing Then
                    '  Obtain a lock on the console and display a series
                    '  of messages.
                    SyncLock consoleGate
                        For i As Integer = 0 To 4
                            TraceMsg("Processing " & workItem)
                            Thread.Sleep(200)
                        Next
                    End SyncLock

                    '  Reset the status of the local variable.
                    workItem = Nothing
                End If
            End While

            '  This will be reached only if workItemsProcessed is true.
            TraceMsg("Terminating.")
        End Sub
        Public Shared Sub Main()

            TraceMsg("Starting worker threads.")

            '  Add an initial work item to the work queue.
            SyncLock workQueue
                workQueue.Enqueue("Work Item 1")
            End SyncLock

            '  Create and start three new worker threads running the
            '  ProcessWorkItems method.
            For count As Integer = 1 To 3
                Dim newThread As New Thread(AddressOf ProcessWorkItems)
                newThread.Start()
            Next

            Thread.Sleep(1500)

            '  The first time the user presses Enter, add a work item and
            '  activate a single thread to process it.
            TraceMsg("Press Enter to pulse one waiting thread.")
            Console.ReadLine()

            '  Acquire a lock on the workQueue object.
            SyncLock workQueue
                '  Add a work item.
                workQueue.Enqueue("Work Item 2.")

                '  Pulse 1 waiting thread.
                Monitor.Pulse(workQueue)
            End SyncLock

            Thread.Sleep(2000)

            '  The second time the user presses Enter, add three work items and
            '  activate three threads to process them.
            TraceMsg("Press Enter to pulse three waiting threads.")
            Console.ReadLine()

            '  Acquire a lock on the workQueue object.
            SyncLock workQueue
                '  Add work items to the work queue, and activate worker threads.
                workQueue.Enqueue("Work Item 3.")
                Monitor.Pulse(workQueue)
                workQueue.Enqueue("Work Item 4.")
                Monitor.Pulse(workQueue)
                workQueue.Enqueue("Work Item 5.")
                Monitor.Pulse(workQueue)
            End SyncLock

            Thread.Sleep(3500)

            '  The third time the user presses Enter, signal the worker threads
            '  to terminate and activate them all.
            TraceMsg("Press Enter to pulse all waiting threads.")
            Console.ReadLine()

            '  Acquire a lock on the workQueue object.
            SyncLock workQueue
                '  Signal that threads should terminate.
                workItemsProcessed = True

                '  Pulse all waiting threads.
                Monitor.PulseAll(workQueue)
            End SyncLock

            Thread.Sleep(1000)

            '  Wait to continue.
            TraceMsg("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
