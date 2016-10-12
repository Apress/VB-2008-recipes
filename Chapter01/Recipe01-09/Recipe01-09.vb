Imports System

Namespace Apress.VisualBasicRecipes.Chapter01

    Public Class Recipe01_09

        Public Shared Sub main(ByVal args As String())

            '  Display the standard console.
            Console.Title = "Standard Console"
            Console.WriteLine("Press Enter to change the console's appearance.")
            Console.ReadLine()

            '  Change the console appearance and redisplay.
            Console.Title = "Colored Text"
            Console.ForegroundColor = ConsoleColor.Red
            Console.BackgroundColor = ConsoleColor.Green
            Console.WriteLine("Press Enter to change the console's appearance.")
            Console.ReadLine()

            '  Change the console appearance and redisplay.
            Console.Title = "Cleared / Colored Console"
            Console.ForegroundColor = ConsoleColor.Blue
            Console.BackgroundColor = ConsoleColor.Yellow
            Console.Clear()
            Console.WriteLine("Press Enter to change the console's appearance.")
            Console.ReadLine()

            '  Change the console appearance and redisplay.
            Console.Title = "Resized Console"
            Console.ResetColor()
            Console.Clear()
            Console.SetWindowSize(100, 50)
            Console.BufferHeight = 500
            Console.BufferWidth = 100
            Console.CursorLeft = 20
            Console.CursorSize = 50
            Console.CursorTop = 20
            Console.CursorVisible = False
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
