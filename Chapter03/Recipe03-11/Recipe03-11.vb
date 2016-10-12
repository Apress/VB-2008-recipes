Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class Recipe03_11

        '  A method to test whether an object is an instance of a type.
        Public Shared Function IsType(ByVal obj As Object, ByVal myType As String) As Boolean

            '  Get the named type, use case-insensitive search, throw
            '  an exception if the type is not found.
            Dim t As Type = Type.GetType(myType, True, True)

            If t Is obj.GetType() Then
                Return True
            ElseIf obj.GetType.IsSubclassOf(t) Then
                Return True
            Else
                Return False
            End If

        End Function
        Public Shared Sub Main()

            '  Create a new StringReader for testing.
            Dim someObject As Object = New StringReader("This is a StringReader")

            '  Test if someObject is a StringReader by obtaining and
            '  comparing a Type reference using the typeof operator.
            If someObject.GetType Is GetType(StringReader) Then
                Console.WriteLine("GetType Is: someObject is a StringReader")
            End If

            '  Test if someObject is, or is derived from, a TextReader
            '  using the is operator.
            If TypeOf someObject Is TextReader Then
                Console.WriteLine("TypeOf Is: someObject is a TextReader or a derived class")
            End If

            '  Test if someObject is, or is derived from, a TextReader using
            '  the Type.GetType and Type.IsSubClasOf methods.
            If IsType(someObject, "System.IO.TextReader") Then
                Console.WriteLine("GetType: someObject is (or is derived from) a TextReader")
            End If

            '  Use the "TryCast" keyword to perform a safe cast.
            Dim reader As StringReader = TryCast(someObject, StringReader)

            If Not reader Is Nothing Then
                Console.WriteLine("TryCast: someObject is a StringReader")
            End If

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
