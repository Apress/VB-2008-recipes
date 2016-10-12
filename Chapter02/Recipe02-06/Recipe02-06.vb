Imports System
Imports System.Reflection
Imports System.Text.RegularExpressions
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_06

        Public Shared Sub Main()

            '  Create the array to hold the Regex info objects.
            Dim regexInfo(1) As RegexCompilationInfo

            '  Create the RegexCompilationInfo for PinRegex.
            regexInfo(0) = New RegexCompilationInfo("^\d{4}$", RegexOptions.Compiled, "PinRegex", "Apress.VisualBasicRecipes.Chapter02", True)

            '  Create the RegexCompilationInfo for CreditCardRegex.
            regexInfo(1) = New RegexCompilationInfo("^\d{4}-?\d{4}-?\d{4}-?\d{4}$", RegexOptions.Compiled, "CreditCardRegex", "Apress.VisualBasicRecipes.Chapter02", True)

            '  Create the AssemblyName to define the target assembly.
            Dim assembly As New AssemblyName("MyRegEx")

            '  Create the compiled regulat expression.
            Regex.CompileToAssembly(regexInfo, assembly)

        End Sub

    End Class

End Namespace