Imports System
Imports System.Collections.Generic
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_16

        Public Shared Sub Main()

            '  Local variable to hold the key entered by the user.
            Dim key As ConsoleKeyInfo

            '  Control whether character or asterik is displayed.
            Dim secret As Boolean = False

            '  Character List for the user data entered.
            Dim input As New List(Of Char)
            Dim msg As String = "Enter characters and press Escape to see input." & vbCrLf & "Press F1 to enter/exit Secret mode and Alt-X to exit."

            Console.WriteLine(msg)

            '  Process input until the users enters "Alt-X" or "Alt-x".
            Do
                '  Read a key from the console.  Intercept the key so that it is not
                '  displayed to the console.  What is displayed is determined later
                '  depending on whether the program is in secret mode.
                key = Console.ReadKey(True)

                '  Switch secret mode on and off.
                If key.Key = ConsoleKey.F1 Then
                    If secret Then
                        '  Switch secret mode off.
                        secret = False
                    Else
                        '  Switch secret mode on.
                        secret = True
                    End If
                End If

                If key.Key = ConsoleKey.Backspace Then
                    '  Handle Backspace.
                    If input.Count > 0 Then
                        '  Backspace pressed remove the last character.
                        input.RemoveAt(input.Count - 1)

                        Console.Write(key.KeyChar)
                        Console.Write(" ")
                        Console.Write(key.KeyChar)
                    End If
                    '  Handle Escape.
                ElseIf key.Key = ConsoleKey.Escape Then
                    Console.Clear()
                    Console.WriteLine("Input:  {0}{1}{1}", New String(input.ToArray), vbCrLf)
                    Console.WriteLine(msg)
                    input.Clear()
                    '  Handle character input.
                ElseIf key.Key >= ConsoleKey.A And key.Key <= ConsoleKey.Z Then
                    input.Add(key.KeyChar)

                    If secret Then
                        Console.Write("*")
                    Else
                        Console.Write(key.KeyChar)
                    End If

                End If

            Loop While Not key.Key = ConsoleKey.X Or Not key.Modifiers = ConsoleModifiers.Alt

            '  Wait to continue.
            Console.WriteLine("{0}{0}Main method complete.  Press Enter", vbCrLf)
            Console.ReadLine()

        End Sub

    End Class

End Namespace
