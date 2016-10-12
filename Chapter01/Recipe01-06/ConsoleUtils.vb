Imports System

Namespace Apress.VisualBasicRecipes.Chapter01

    Public Class ConsoleUtils

        '  This method will display a prompt and read a response from the console.
        Public Shared Function ReadString(ByVal message As String) As String

            Console.Write(message)
            Return Console.ReadLine

        End Function
        '  This method will display a message on the console.
        Public Shared Sub WriteString(ByVal message As String)

            Console.WriteLine(message)

        End Sub
        '  This method is used for testing ConsoleUtility methods.
        '  While it is not good practice to have multiple Main
        '  methods in an assembly, it sometimes can't be avoided.
        '  You specify in the compiler which Main sub routine should
        '  be used as the entry point.  For this example, this Main
        '  routine will never be executed.
        Public Shared Sub Main()

            '  Prompt the reader to enter a name.
            Dim name As String = ReadString("Please enter a name:  ")

            '  Welcome the reader to Visual Basic 2008 Recipes.
            WriteString("Welcome to Visual Basic 2008 Recipes, " & name)

        End Sub

    End Class

End Namespace
