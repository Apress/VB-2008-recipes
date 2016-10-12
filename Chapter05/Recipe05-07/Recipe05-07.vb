Imports System
Imports System.IO
Imports System.Text
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_07

        Public Shared Sub Main()

            '  Create a new file.
            Using fs As New FileStream("test.txt", FileMode.Create)
                '  Create a write and specify the encoding. The
                '  default (UTF-8) supprots special Unicode characters,
                '  but encodes all standard characters in the same way as
                '  ASCII encoding.
                Using w As New StreamWriter(fs, Encoding.UTF8)

                    '  Write a decimal, string and two chars.
                    w.WriteLine(CDec(124.23))
                    w.WriteLine("Test string")
                    w.WriteLine("δ"c)    'Produced by pressing ALT+235
                    w.WriteLine("!"c)

                End Using

            End Using

            Console.WriteLine("Press Enter to read the information.")
            Console.ReadLine()

            '  Open the file in read-only mode.
            Using fs As New FileStream("test.txt", FileMode.Open)
                Using r As New StreamReader(fs, Encoding.UTF8)
                    '  Read the data and convert it to the appropriate data type.
                    Console.WriteLine(Decimal.Parse(r.ReadLine))
                    Console.WriteLine(r.ReadLine)
                    Console.WriteLine(Char.Parse(r.ReadLine))
                    Console.WriteLine(Char.Parse(r.ReadLine))
                End Using
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace

