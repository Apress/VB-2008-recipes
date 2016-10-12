Imports System
Imports System.Threading
Imports System.Diagnostics
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_17

        Public Shared Sub Main()

            '  Create a new Process and run notepad.exe.
            Using newProcess As Process = Process.Start("notepad.exe", "C:\SomeFile.txt")
                '  Wait for 5 seconds and terminate the notepad process.
                Console.WriteLine("Waiting 5 seconds before terminating notepad.exe.")
                Thread.Sleep(5000)

                '  Terminate notepad process.
                Console.WriteLine("Terminating Notepad with CloseMainWindow.")

                '  Try to send a close message to the main window.
                If Not newProcess.CloseMainWindow Then
                    '  Close message did not get sent - Kill Notepad.
                    Console.WriteLine("CloseMainWindow returned false - terminating Notepad with Kill.")
                    newProcess.Kill()
                Else
                    '  Close message sent successfullyl wait for 2 seconds
                    '  for termination confirmation before resorting to kill.
                    If Not newProcess.WaitForExit(2000) Then
                        Console.WriteLine("CloseMaineWindow failed to terminate - terminating Notepad with Kill.")
                        newProcess.Kill()
                    End If
                End If
            End Using

            '  Wait to continue.
            Console.WriteLine("Main method compelte. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
