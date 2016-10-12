Imports System
Imports System.IO
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_10

        Public Shared Sub Main(ByVal args As String())
            '  Create a 2 MB test file.
            Using fs As New FileStream("test.txt", FileMode.Create)
                fs.SetLength(2097152)
            End Using

            '  Start the asynchronous file processor on another thread.
            Dim asyncIO As New AsyncProcessor("test.txt", 2048)
            asyncIO.StartProcess()

            '  At the same time, do some other work.
            '  In thi example, we simply loop for 10 seconds.
            Dim startTime As DateTime = DateTime.Now

            While DateTime.Now.Subtract(startTime).TotalSeconds < 10
                Console.WriteLine("[MAIN THREAD]: Doing some work.")

                '  Pause to simulate a time-consuming operation.
                Thread.Sleep(TimeSpan.FromMilliseconds(100))
            End While
            Console.WriteLine("[MAIN THREAD]: Complete.")
            Console.ReadLine()

            '  Remove the test file.
            File.Delete("test.txt")
        End Sub

    End Class
End Namespace
