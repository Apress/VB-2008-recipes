Imports System
Imports System.Collections
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_11

        Public Shared Sub Main()

            '  Create a new ArrayList and populate it.
            Dim nameList As New ArrayList(3)
            nameList.Add("Amy")
            nameList.Add("Alaina")
            nameList.Add("Aidan")

            '  Create a string array and use the ICollection.CopyTo method
            '  to copy the contents of the ArrayList.
            Dim array1(nameList.Count - 1) As String
            nameList.CopyTo(array1, 0)

            '  Use ArrayList.ToArray to create an object array from the
            '  contents of the collection.
            Dim array2 As Object() = nameList.ToArray()

            '  Use ArrayList.ToArray to create a strongy typed string
            '  array from the contents of the collection.
            Dim array3 As String() = DirectCast(nameList.ToArray(GetType(String)), String())

            '  Display the contents of the 3 arrays.
            Console.WriteLine("Array 1:")
            For Each s As String In array1
                Console.WriteLine(vbTab + "{0}", s)
            Next

            Console.WriteLine("Array 2:")
            For Each s As String In array2
                Console.WriteLine(vbTab + "{0}", s)
            Next

            Console.WriteLine("Array 3:")
            For Each s As String In array3
                Console.WriteLine(vbTab + "{0}", s)
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
