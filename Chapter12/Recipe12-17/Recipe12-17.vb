Imports System
Imports System.Security
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_17

        Public Shared Function ReadString() As SecureString

            '  Create a new empty SecureString.
            Dim str As New SecureString

            '  Read the string from the console one
            '  character at a time without displaying it.
            Dim nextChar As ConsoleKeyInfo = Console.ReadKey(True)

            '  Read characters until Enter is pressed.
            While Not nextChar.Key = ConsoleKey.Enter

                If nextChar.Key = ConsoleKey.Backspace Then
                    If str.Length > 0 Then
                        '  Backspace pressed, remove the last character.
                        str.RemoveAt(str.Length - 1)

                        Console.Write(nextChar.KeyChar)
                        Console.Write(" ")
                        Console.Write(nextChar.KeyChar)
                    Else
                        Console.Beep()
                    End If
                Else
                    '  Append the character to the SecureString and
                    '  display a masked character.
                    str.AppendChar(nextChar.KeyChar)
                    Console.Write("*")
                End If

                '  Read the next character.
                nextChar = Console.ReadKey(True)

            End While

            '  String entry finished.  Make it read-only.
            str.MakeReadOnly()
            Return str

        End Function
        Public Shared Sub Main()

            Dim user As String = ""

            '  Get the username under which Notepad.exe will be run.
            Console.Write("Enter the user name: ")
            user = Console.ReadLine

            '  Get the user's password as a SecureString.
            Console.Write("Enter the user's password: ")
            Using pword As SecureString = ReadString()

                '  Start Notepad as the specified user.
                Dim startInfo As New ProcessStartInfo

                startInfo.FileName = "Notepad.exe"
                startInfo.UserName = user
                startInfo.Password = pword
                startInfo.UseShellExecute = False

                '  Create a new Process object.
                Using proc As New Process

                    '  Assign the ProcessStartInfo to the Process object.
                    proc.StartInfo = startInfo

                    Try
                        '  Start the new process.
                        proc.Start()
                    Catch ex As Exception
                        Console.WriteLine(Environment.NewLine)
                        Console.WriteLine(Environment.NewLine)
                        Console.WriteLine("Could not start Notepad process.")
                        Console.WriteLine(ex.ToString)
                    End Try

                End Using

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub
    End Class

End Namespace