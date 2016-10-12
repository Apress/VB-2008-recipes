Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_13

        Private Shared Sub DisplayMessage()

            '  Display a message to the console 5 times.
            For count As Integer = 1 To 5
                Console.WriteLine("{0} : DisplayMessage thread", DateTime.Now.ToString("HH:mm:ss.ffff"))

                '  Sleep for 1 second.
                Thread.Sleep(1000)
            Next
        End Sub
        Public Shared Sub Main()

            '  Create a new Thread to run the DisplayMessage method.
            Dim newThread As New Thread(AddressOf DisplayMessage)

            Console.WriteLine("{0} : Starting DisplayMessage thread.", DateTime.Now.ToString("HH:mm:ss.ffff"))

            '  Start the DisplayMessahe thread.
            newThread.Start()

            '  Block until the DisplayMessage threa finished, or time-out after
            '  2 seconds.
            If Not newThread.Join(2000) Then
                Console.WriteLine("{0} : Join timed out !!", DateTime.Now.ToString("HH:mm:ss.ffff"))
            End If

            '  Block again until the DisplayMessage thread finishes with
            '  no time-out.
            newThread.Join()

            '  Wait to continue.
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
