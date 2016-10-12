Imports System
Imports System.Threading
Imports System.Globalization
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_05
        Public Shared Sub RunAt(ByVal execTime As DateTime)

            '  Calculate the difference between the specified execution
            '  time and the current time.
            Dim waitTime As TimeSpan = execTime - DateTime.Now

            '  Check if a time in the past was specified.  If it was, set
            '  the waitTime to TimeSpan(0) which will cause the timer
            '  to execute immediately.
            If waitTime < New TimeSpan(0) Then
                Console.WriteLine("A 'Past' time was specified.")
                Console.WriteLine("Timer will fire immediately.")
                waitTime = New TimeSpan(0)
            End If

            '  Create a Timer that fires once at the specified time. Specify
            '  an interval of -1 to stop the timer executing the method
            '  repeatedly.
            Dim threadTimer As New Timer(AddressOf TimerTriggered, "Timer Triggered", waitTime, New TimeSpan(-1))

        End Sub
        Private Shared Sub TimerTriggered(ByVal state As Object)
            Console.WriteLine("{0} : {1}", DateTime.Now.ToString("HH:mm:ss.ffff"), state)
            Console.WriteLine("Main method complete. Press Enter.")
        End Sub
        Public Shared Sub Main(ByVal args As String())

            Dim execTime As DateTime

            '  Ensure there is an execution time specified on the command line.
            If args.Length > 0 Then
                '  Convert the string to a datetime. Support only the RFC1123
                '  DateTime pattern.
                Try
                    execTime = DateTime.ParseExact(args(0), "r", Nothing)
                    Console.WriteLine("Current time     : " & DateTime.Now.ToString("r"))
                    Console.WriteLine("Execution time   : " & execTime.ToString("r"))

                    RunAt(execTime)
                Catch ex As FormatException
                    Console.WriteLine("Execution time must be of the format:{0}{1}{2}", ControlChars.NewLine, ControlChars.Tab, CultureInfo.CurrentCulture.DateTimeFormat.RFC1123Pattern)
                End Try

                '  Wait to continue.
                Console.WriteLine("Waiting for Timer...")
                Console.ReadLine()
            Else
                Console.WriteLine("Specify the time you want the method to execute using the format :{0}{1} {2}", ControlChars.NewLine, ControlChars.Tab, CultureInfo.CurrentCulture.DateTimeFormat.RFC1123Pattern)
            End If
        End Sub
    End Class

End Namespace