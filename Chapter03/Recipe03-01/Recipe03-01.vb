Imports System
Imports System.Reflection
Imports System.Globalization
Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class Recipe03_01

        Public Shared Sub ListAssemblies()

            '  Get an array of the assemvlies loaded into the current
            '  application domain.
            Dim assemblies As Assembly() = AppDomain.CurrentDomain.GetAssemblies()

            For Each a As Assembly In assemblies
                Console.WriteLine(a.GetName)
            Next

        End Sub
        Public Shared Sub Main()

            '  List the assemblies in the current applciation domain.
            Console.WriteLine("**** BEFORE ****")
            ListAssemblies()

            '  Load the System.Data assembly using a fully qualified display name.
            Dim name1 As String = "System.Data,Version=2.0.0.0," + "Culture=neutral,PublicKeyToken=b77a5c561934e089"
            Dim a1 As Assembly = Assembly.Load(name1)

            '  Load the System.xml assembly using an AssemblyName.
            Dim name2 As New AssemblyName()
            name2.Name = "System.Xml"
            name2.Version = New Version(2, 0, 0, 0)
            name2.CultureInfo = New CultureInfo("")   '  Neutral culture.
            name2.SetPublicKeyToken(New Byte() {&HB7, &H7A, &H5C, &H56, &H19, &H34, &HE0, &H89})
            Dim a2 As Assembly = Assembly.Load(name2)

            '  Load the SomeAssembly assembly using a partial display name.
            Dim a3 As Assembly = Assembly.Load("SomeAssembly")

            '  Load the assembly named c:\shared\MySharedAssembly.dll.
            Dim a4 As Assembly = Assembly.LoadFrom("C:\shared\MySharedAssembly.dll")

            '  List the assemblies in the current application domain.
            Console.WriteLine("{0}{0}**** AFTER ****", vbCrLf)
            ListAssemblies()

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace