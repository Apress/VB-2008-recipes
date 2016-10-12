Imports System
Imports System.Runtime.InteropServices
Imports System.Text
Namespace Apress.VisualBasicRecipes.Chapter13

    Public Class Recipe13_01

        '  Declare the unmanged functions
        <DllImport("kernel32.dll", EntryPoint:="GetPrivateProfileString")> _
        Private Shared Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
        End Function

        <DllImport("kernel32.dll", EntryPoint:="WritePrivateProfileString")> _
        Private Shared Function WritePrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Boolean
        End Function
        Public Shared Sub main(ByVal args As String())

            Dim val As String

            '  Obtain current value.
            val = GetIniValue("SampleSection", "Key1", args(0))
            Console.WriteLine("Value of Key1 in [SampleSection] is: {0}", val)

            '  Write a new value.
            WriteIniValue("SampleSection", "Key1", "New Value", args(0))

            '  Obtain the new value.
            val = GetIniValue("SampleSection", "Key1", args(0))
            Console.WriteLine("Value of Key1 in [SampleSection] is now: {0}", val)

            '  Write original value.
            WriteIniValue("SampleSection", "Key1", "Value1", args(0))

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        Public Shared Function GetIniValue(ByVal section As String, ByVal key As String, ByVal fileName As String) As String

            Dim chars As Integer = 256
            Dim buffer As New StringBuilder(chars)

            If Not GetPrivateProfileString(section, key, "", buffer, chars, fileName) = 0 Then
                Return buffer.ToString
            Else
                Return Nothing
            End If

        End Function
        Public Shared Function WriteIniValue(ByVal section As String, ByVal key As String, ByVal value As String, ByVal fileName As String) As String
            Return WritePrivateProfileString(section, key, value, fileName)
        End Function

    End Class

End Namespace
