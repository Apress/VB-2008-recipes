Imports System
Imports System.Text
Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class Recipe03_10

        Public Shared Sub Main()

            '  Obtain type information using the GetType keyword.
            Dim t1 As Type = GetType(StringBuilder)

            '  Obtain type information using the Type.Gettype method.
            '  Case-sensitive, return nothing if not found.
            Dim t2 As Type = Type.GetType("System.String")

            '  Case-sensitive, throw TypeLoadException if not found.
            Dim t3 As Type = Type.GetType("System.String", True)

            '  Case-insensitive, throw TypeLoadException if not found.
            Dim t4 As Type = Type.GetType("system.string", True, True)

            '  Assembly-qualified type name.
            Dim t5 As Type = Type.GetType("System.Data.DataSet,System.Data," & "Version=2.0.0.0,Culture=neutral,PublicKeyToken=b77a5c561934e089")

            '  Obtain type information using the Object.GetType method.
            Dim sb As New StringBuilder
            Dim t6 As Type = sb.GetType()

            '  Display the types.
            Console.WriteLine("Type of T1:  {0}", t1.ToString)
            Console.WriteLine("Type of T2:  {0}", t2.ToString)
            Console.WriteLine("Type of T3:  {0}", t3.ToString)
            Console.WriteLine("Type of T4:  {0}", t4.ToString)
            Console.WriteLine("Type of T5:  {0}", t5.ToString)
            Console.WriteLine("Type of T6:  {0}", t6.ToString)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
