Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_15

        Public Class Tool
            Public Name As String
        End Class
        Public Class Clothes
            Public Name As String
        End Class
        Public Shared Sub Main()

            '  From Example - NonGeneric Collection
            Dim employeeList As New ArrayList

            employeeList.Add("Todd")
            employeeList.Add("Alex")
            employeeList.Add("Joe")
            employeeList.Add("Todd")
            employeeList.Add("Ed")
            employeeList.Add("David")
            employeeList.Add("Mark")

            '  You can't normally use standard query operators on
            '  an arraylist (IEnumerable) unless you strongly type
            '  the From Clause.  Strongly typing the from clause
            '  creates a call to the Cast function, shown below.
            Dim queryableList = employeeList.Cast(Of String)()
            Dim query = From name In queryableList

            For Each name In query
                Console.WriteLine(name)
            Next
            Console.WriteLine()

            Dim shoppingCart As New ArrayList

            shoppingCart.Add(New Clothes With {.Name = "Shirt"})
            shoppingCart.Add(New Clothes With {.Name = "Socks"})
            shoppingCart.Add(New Tool With {.Name = "Hammer"})
            shoppingCart.Add(New Clothes With {.Name = "Hat"})
            shoppingCart.Add(New Tool With {.Name = "Screw Driver"})
            shoppingCart.Add(New Clothes With {.Name = "Pants"})
            shoppingCart.Add(New Tool With {.Name = "Drill"})

            '  Attempting to itterate through the results would generate
            '  an InvalidCastException because some items can not be
            '  cast to the appropriate type.  Although, some items
            '  may be cast prior to hitting the exception.
            Dim queryableList2 = shoppingCart.Cast(Of Clothes)()

            Console.WriteLine("Cast (using Cast) all items to 'Clothes':")
            Try
                For Each item In queryableList2
                    Console.WriteLine(item.Name)
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Console.WriteLine()

            '  OfType is similar to cast but wouldn't cause the
            '  exception as shown in the previous example.  Only
            '  the items that can be successfully cast will be returned.
            Dim queryableList3 = shoppingCart.OfType(Of Clothes)()

            Console.WriteLine("Cast (using OfType) all items to 'Clothes':")
            For Each item In queryableList3
                Console.WriteLine(item.Name)
            Next
            Console.WriteLine()

            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace

