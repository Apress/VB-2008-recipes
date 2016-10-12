Imports System
Imports System.Text.RegularExpressions
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_05

        Public Shared Function ValidateInput(ByVal expression As String, ByVal input As String) As Boolean

            '  Create a new Regex based on the specified regular expression.
            Dim r As New Regex(expression)

            '  Test if the specified input matches the regular expression.
            Return r.IsMatch(input)

        End Function
        Public Shared Sub Main(ByVal args As String())

            '  Test the input from the command line.  The first argument is the
            '  regular expression, and the second is the input.
            Console.WriteLine("Regular Expresion:  {0}", args(0))
            Console.WriteLine("Input:  {0}", args(1))
            Console.WriteLine("Valid = {0}", ValidateInput(args(0), args(1)))

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace