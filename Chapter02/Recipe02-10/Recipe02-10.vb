Imports System
Imports System.Collections
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_10

        Public Shared Sub Main()

            '  Create a new array and populate it.
            Dim array1 As Integer() = {4, 2, 9, 3}

            '  Sort the array.
            Array.Sort(array1)

            '  Display the contents of the sorted array.
            For Each i As Integer In array1
                Console.WriteLine(i.ToString)
            Next

            '  Create a new ArrayList and populate it.
            Dim list1 As New ArrayList(3)
            list1.Add("Amy")
            list1.Add("Alaina")
            list1.Add("Aidan")

            '  Sort the ArrayList.
            list1.Sort()

            '  Display the contents of the sorted ArrayList.
            For Each s As String In list1
                Console.WriteLine(s)
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
