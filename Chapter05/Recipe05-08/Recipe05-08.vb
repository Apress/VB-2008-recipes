Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_08

        Public Shared Sub Main()

            '  Create a new file and writer.
            Using fs As New FileStream("test.bin", FileMode.Create)
                Using w As New BinaryWriter(fs)
                    '  Write a decimal, 2 strings and a char.
                    w.Write(CDec(124.23))
                    w.Write("Test string")
                    w.Write("Test string 2")
                    w.Write("δ"c)    'Produced by pressing ALT+235
                    w.Write("!"c)
                End Using
            End Using
            Console.WriteLine("Press Enter to read the information.")
            Console.ReadLine()

            '  Open the file in read-only mode.
            Using fs As New FileStream("test.bin", FileMode.Open)
                '  Display the raw information in the file.
                Using sr As New StreamReader(fs)
                    Console.WriteLine(sr.ReadToEnd)
                    Console.WriteLine()
                End Using

                ' Reposition the FileStream so we can reuse it.
                fs.Position = 0

                '  Read the data and convert it to the appropraite data type.
                Using br As New BinaryReader(fs)
                    Console.WriteLine(br.ReadDecimal)
                    Console.WriteLine(br.ReadString)
                    Console.WriteLine(br.ReadString)
                    Console.WriteLine(br.ReadChar)
                    Console.WriteLine(br.ReadChar)
                End Using
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace