Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_04

        Public Shared Sub Main()

            '  Create the state object that is passd to the TimerHandler
            '  method when it is triggered. In this case, a message to display.
            Dim state As String = "Timer expired."

            Console.WriteLine("{0} : Creating Timer.", DateTime.Now.ToString("HH:mm:ss.ffff"))

            '  Create a Timer that fires first after 2 seconds and then every
            '  second.  The threadTimer object is automatically disposed at the
            '  end of the Using block.
            Using threadTimer As New Timer(AddressOf TimerTriggered, state, 2000, 1000)
                Dim period As Integer

                '  Read the new timer interval from the console until the
                '  user enters 0 (zero). Invalid values use a default value
                '  of 0, which will stop the example.
                Do
                    Try
                        period = Int32.Parse(Console.ReadLine())
                    Catch ex As FormatException
                        period = 0
                    End Try

                    '  Change the timer to fire using the new interval starting
                    '  immediately.
                    If period > 0 Then
                        Console.WriteLine("{0} : Changing Timer Interval.", DateTime.Now.ToString("HH:mm:ss.ffff"))
                        threadTimer.Change(0, period)
                    End If

                Loop While period > 0
            End Using

            '  Wait to continue.
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
        Private Shared Sub TimerTriggered(ByVal state As Object)
            Console.WriteLine("{0} : {1}", DateTime.Now.ToString("HH:mm:ss.ffff"), state)
        End Sub

    End Class

End Namespace