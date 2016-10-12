Imports System
Imports System.Reflection
Imports System.Collections

Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class ListModifier

        Public Sub New()

            '  Get the list from the data cache.
            Dim list As ArrayList = CType(AppDomain.CurrentDomain.GetData("Pets"), ArrayList)

            '  Modify the list.
            list.Add("Turtle")

        End Sub

    End Class
    Public Class Recipe03_08

        Public Shared Sub Main()

            '  Create a new application domain.
            Dim domain As AppDomain = AppDomain.CreateDomain("Test")

            '  Create an ArrayList and populate with information.
            Dim list As New ArrayList
            list.Add("Dog")
            list.Add("Cat")
            list.Add("Fish")

            '  Place the list in the data cache of the new application domain.
            domain.SetData("Pets", list)

            '  Instantiate a ListModifier in the new application domain.
            domain.CreateInstance("Recipe03-08", "Apress.VisualBasicRecipes.Chapter03.ListModifier")

            '  Get the list and display its contents.
            Console.WriteLine("The list in the 'Test' application domain:")
            For Each s As String In CType(domain.GetData("Pets"), ArrayList)
                Console.WriteLine(s)
            Next
            Console.WriteLine(Environment.NewLine)

            '  Display the original list to show that it has not changed.
            Console.WriteLine("The list in the standard application domain:")
            For Each s As String In list
                Console.WriteLine(s)
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
