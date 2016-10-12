Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_14

        Private Shared Sub Displaymessage()

            Try
                While True
                    '  Display a message to the console.
                    Console.WriteLine("{0} : DisplayMessage thread active", DateTime.Now.ToString("HH:mm:ss.ffff"))

                    '  Sleep for 1 second.
                    Thread.Sleep(1000)
                End While
            Catch ex As ThreadAbortException
                '  Display a message to the console.
                Console.WriteLine("{0} : DisplayMessage thread terminating - {1}", DateTime.Now.ToString("HH:mm:ss.ffff"), DirectCast(ex.ExceptionState, String))

                '  Call Thread.ResetAbort here to cancel the abort request.
            End Try

            '  This code is never executed unless Thread.ResetAbort is
            '  called in the previous catch block.
            Console.WriteLine("{0} : nothing is called after the catch block", DateTime.Now.ToString("HH:mm:ss.ffff"))
        End Sub
        Public Shared Sub Main()

            '  Create a new Thread to run the DisplayMessage method.
            Dim newThread As New Thread(AddressOf Displaymessage)

            Console.WriteLine("{0} : Starting DisplayMessage thread - press Enter to terminate.", DateTime.Now.ToString("HH:mm:ss.ffff"))

            '  Start the DisplayMessage thread.
            newThread.Start()

            '  Wait until Enter is pressed and terminate the thread.
            System.Console.ReadLine()

            newThread.Abort("User pressed Enter")

            '  Block again until the DisplayMessage thread finishes.
            newThread.Join()

            '  Wait to continue.
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace