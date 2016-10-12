Imports System
Namespace Apress.VisualBasicRecipes.Chapter03

    <Author("Aidan"), Author("Todd", Company:="The Code Architects")> _
    Public Class Recipe03_14

        Public Shared Sub Main()

            '  Get a Type object for this class.
            Dim myType As Type = GetType(Recipe03_14)

            '  Get the attributes for the type.  Apply a filter so that only
            '  instances of AuthorAttributes are returned.
            Dim attrs As Object() = myType.GetCustomAttributes(GetType(AuthorAttribute), True)

            '  Enumerate the attributes and display their details.
            For Each a As AuthorAttribute In attrs
                Console.WriteLine(a.Name & ", " & a.Company)
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
