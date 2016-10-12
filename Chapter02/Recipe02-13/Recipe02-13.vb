Imports System
Imports System.Reflection
Imports System.Collections.Generic
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_13

        Public Shared Sub Main()

            '  Create an AssemblyName object for use during the example.
            Dim assembly1 As New AssemblyName("com.microsoft.crypto, Culture=en, PublicKeyToken=a5d015c7d5a0b012, Version=1.0.0.0")

            '  Create and use a Dictionary of AssemblyName objects.
            Dim assemblyDictionary As New Dictionary(Of String, AssemblyName)

            assemblyDictionary.Add("Crypto", assembly1)

            Dim ass1 As AssemblyName = assemblyDictionary("Crypto")

            Console.WriteLine("Got AssemblyName from dictionary: {0}", CType(ass1, AssemblyName).ToString)

            '  Create and use a list of AssemblyName objects.
            Dim assemblyList As New List(Of AssemblyName)

            assemblyList.Add(assembly1)

            Dim ass2 As AssemblyName = assemblyList(0)

            Console.WriteLine(vbCrLf & "Found AssemblyName in list: {0}", CType(ass2, AssemblyName).ToString)

            '  Create and use a stack of AssemblyName objects.
            Dim assemblyStack As New Stack(Of AssemblyName)

            assemblyStack.Push(assembly1)

            Dim ass3 As AssemblyName = assemblyStack.Pop

            Console.WriteLine(vbCrLf & "Popped AssemblyName from stack: {0}", CType(ass3, AssemblyName).ToString)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace