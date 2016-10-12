Imports System
Imports System.Collections.Generic
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Bag(Of T)
        '  A list to hold the bag's contents.  The list must be
        '  of the same type as the bag.
        Private items As New List(Of T)

        '  A method to add an item to the bag.
        Public Sub Add(ByVal item As T)
            items.Add(item)
        End Sub

        '  A method to remove a random item from the bag.
        Public Function Remove() As T
            Dim item As T = Nothing

            If Not items.Count = 0 Then
                '  Determine which item to remove from the bag.
                Dim r As New Random
                Dim num As Integer = r.Next(0, items.Count)

                '  Remove the item.
                item = items(num)
                items.RemoveAt(num)
            End If
            Return item

        End Function

        '  A method to remove all items form the bag and return them
        '  as an array.
        Public Function RemoveAll() As T()

            Dim i As T() = items.ToArray()
            items.Clear()
            Return i

        End Function

    End Class
    Public Class Recipe02_14

        Public Shared Sub Main()

            '  Create a new bag of strings.
            Dim bag As New Bag(Of String)

            '  Add strings to the bag.
            bag.Add("Amy")
            bag.Add("Alaina")
            bag.Add("Aidan")
            bag.Add("Robert")
            bag.Add("Pearl")
            bag.Add("Mark")
            bag.Add("Karen")

            '  Take four strings from the bag and display.
            Console.WriteLine("Item 1 = {0}", bag.Remove())
            Console.WriteLine("Item 2 = {0}", bag.Remove())
            Console.WriteLine("Item 3 = {0}", bag.Remove())
            Console.WriteLine("Item 4 = {0}", bag.Remove())
            Console.WriteLine(vbCrLf)

            '  Remove the remaining items from the bag.
            Dim s As String() = bag.RemoveAll

            '  Display the remaining items.
            For i As Integer = 0 To s.Length - 1
                Console.WriteLine("Item {0} = {1}", i + 1.ToString, s(i))
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace