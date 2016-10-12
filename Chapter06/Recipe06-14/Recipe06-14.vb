Imports System
Imports System.Linq
Imports System.Diagnostics

Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_14

        Public Shared Sub Main()

            '  Array to hold a set of strings.
            Dim myWishList = New String() {"XBox 360", _
                                           "Rolex", _
                                           "Serenity", _
                                           "iPod iTouch", _
                                           "Season 3 of BSG", _
                                           "Dell XPS", _
                                           "Halo 3"}

            '  An array holding a second set of strings.
            Dim myShoppingCart = New String() {"Shrek", _
                                               "Swatch (Green)", _
                                               "Sony Walkman", _
                                               "XBox 360", _
                                               "Season 3 of The Golden Girls", _
                                               "Serenity"}

            '  Returns elements from myWishList that are NOT in
            '  myShoppingCart.
            Dim result1 = myWishList.Except(myShoppingCart)

            Console.WriteLine("Items in the wish list that were not in the shopping cart:")
            For Each item In result1
                Console.WriteLine(item)
            Next
            Console.WriteLine()

            '  Returns elements that are common in both myWishList
            '  and myShoppingCart.
            Dim result2 = myWishList.Intersect(myShoppingCart)

            Console.WriteLine("Matching items from both lists:")
            For Each item In result2
                Console.WriteLine(item)
            Next
            Console.WriteLine()

            '  Returns all elements from myWishList and myShoppingCart
            '  without duplicates.
            Dim result3 = myWishList.Union(myShoppingCart)

            Console.WriteLine("All items from both lists (no duplicates):")
            For Each item In result3
                Console.WriteLine(item)
            Next
            Console.WriteLine()

            '  Returns all elements from myWishList and myShoppingCart
            '  including duplicates
            Dim result4 = myWishList.Concat(myShoppingCart)

            Console.WriteLine("All items from both lists (with duplicates):")
            For Each item In result4
                Console.WriteLine(item)
            Next

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
