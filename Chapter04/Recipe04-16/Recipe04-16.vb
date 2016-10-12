Imports System
Imports System.Diagnostics
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_16

        Public Shared Sub Main()

            '  Create a ProcessStartInfo object and configure it with the
            '  information required to run the new process.
            Dim startInfo As New ProcessStartInfo

            startInfo.FileName = "notepad.exe"
            startInfo.Arguments = "file.txt"
            startInfo.WorkingDirectory = "C:\Temp"
            startInfo.WindowStyle = ProcessWindowStyle.Maximized
            startInfo.ErrorDialog = True

            '  Declare a new process object.
            Dim newProcess As Process

            Try
                '  Start the new process.
                newProcess = Process.Start(startInfo)

                '  Wait for the new process to terminate before exiting.
                Console.WriteLine("Waiting 30 seconds for process to finish.")

                If newProcess.WaitForExit(30000) Then
                    Console.WriteLine("Process terminated.")
                Else
                    Console.WriteLine("Timed out waiting for process to end.")
                End If
            Catch ex As Exception
                Console.WriteLine("Could not start process.")
                Console.WriteLine(ex)
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace