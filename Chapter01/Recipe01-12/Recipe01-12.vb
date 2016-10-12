Imports System
Imports System.Reflection

<Assembly: AssemblyCulture("")> 
<Assembly: AssemblyVersion("1.1.0.5")> 

Namespace Apress.VisualBasicRecipes.Chapter01

    Public Class Recipe01_12

        Public Shared Sub main()
            Console.WriteLine("Welcome to Visual Basic 2008 Recipes")

            '  Wait to continue...
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.Read()
        End Sub

    End Class

End Namespace
