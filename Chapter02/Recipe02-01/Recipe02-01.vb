Imports System
Imports System.Text

Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_01

        Public Shared Function ReverseString(ByVal str As String) As String

            '  Make sure we have a reversible string.
            If str Is Nothing Or str.Length <= 1 Then
                Return str
            End If

            '  Create a StringBuilder object with the required capacity.
            Dim revStr As StringBuilder = New StringBuilder(str.Length)

            '  Convert the string to a character array so we can easily loop
            '  through it.
            Dim chars As Char() = str.ToCharArray()

            '  Loop backward through the source string one character at a time and 
            '  append each character to the StringBuilder.
            For count As Integer = chars.Length - 1 To 0 Step -1
                revStr.Append(chars(count))
            Next

            Return revStr.ToString()

        End Function
        Public Shared Sub Main()

            Console.WriteLine(ReverseString("Madam Im Adam"))
            Console.WriteLine(ReverseString("The quick brown fox jumped over the lazy dog."))

            '  Wait to continue
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace