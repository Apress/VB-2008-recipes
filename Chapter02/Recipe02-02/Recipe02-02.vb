Imports System
Imports System.IO
Imports System.Text.Encoding

Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_02

        Public Shared Sub Main()

            '  Create a file to hold the output.
            Using output As New StreamWriter("output.txt")
                '  Create and write a string containing the symbol for pi.
                Dim srcString As String = String.Format("Area = {0}r^2", ChrW(&H3A0))
                output.WriteLine("Source Text:  " & srcString)

                '  Write the UTF-16 encoded bytes of the source string.
                Dim utf16String As Byte() = Unicode.GetBytes(srcString)
                output.WriteLine("UTF-16 Bytes:  {0}", BitConverter.ToString(utf16String))

                '  Convert the UTF-16 encoded source string to UTF-8 and ASCII.
                Dim utf8String As Byte() = UTF8.GetBytes(srcString)
                Dim asciiString As Byte() = ASCII.GetBytes(srcString)

                '  Write the UTF-8 and ASCII encoded byte arrays.
                output.WriteLine("UTF-8 Bytes:  {0}", BitConverter.ToString(utf8string))
                output.WriteLine("ASCII Bytes:  {0}", BitConverter.ToString(asciiString))

                '  Convert UTF-8 and ASCII encoded bytes back to UTF-16 encoded
                '  string and write to the output file.
                output.WriteLine("UTF-8 Text:  {0}", UTF8.GetString(utf8String))
                output.WriteLine("ASCII Text:  {0}", ASCII.GetString(asciiString))

            End Using

            '  Wait to continue
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()
        End Sub

    End Class

End Namespace