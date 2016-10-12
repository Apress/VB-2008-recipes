Imports System
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_09

        Public Shared Sub Main()

            '  Create the sample log file.
            Using w As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("SampleLog.txt", False, System.Text.Encoding.UTF8)

                '  Write sample log records to the file. The parser
                '  will skip blank lines.  Also, the TextFieldParser
                '  can be configured to ignore lines that are comments.
                w.WriteLine("# In this sample log file, comments start with a # character. The")
                w.WriteLine("# parser, when configured correctly, will ignore these lines.")
                w.WriteLine("")
                w.WriteLine("{0},INFO,""{1}""", DateTime.Now.ToString, "Some informational text.")
                w.WriteLine("{0},WARN,""{1}""", DateTime.Now.ToString, "Some warning message.")
                w.WriteLine("{0},ERR!,""{1}""", DateTime.Now.ToString, "[ERROR] Some exception has occurred.")
                w.WriteLine("{0},INFO,""{1}""", DateTime.Now.ToString, "More informational text.")
                w.WriteLine("{0},ERR!,""{1}""", DateTime.Now.ToString, "[ERROR] Some exception has occurred.")

            End Using

            Console.WriteLine("Press Enter to read and parse the information.")
            Console.ReadLine()

            '  Open the file in and parse the data into a
            '  TextFieldParser object.
            Using logFile As TextFieldParser = My.Computer.FileSystem.OpenTextFieldParser("SampleLog.txt")

                Console.WriteLine("Parsing text file.")
                Console.WriteLine(Environment.NewLine)

                '  Write header information to the console.
                Console.WriteLine("{0,-29}  {1}  {2}", "Date/Time in RFC1123", "Type", "Message")

                '  Configure the parser. For this recipe, make sure the
                '  HasFieldsEnclosedInQuotes is True.
                logFile.TextFieldType = FieldType.Delimited
                logFile.CommentTokens = New String() {"#"}
                logFile.Delimiters = New String() {","}
                logFile.HasFieldsEnclosedInQuotes = True

                Dim currentRecord As String()

                '  Loop through the file until we reach the end.
                Do While Not logFile.EndOfData
                    Try
                        '  Parse all the fields into the currentRow
                        '  array. This method automatically moves
                        '  the file point to the next row.
                        currentRecord = logFile.ReadFields

                        '  Write the parsed record to the console.
                        Console.WriteLine("{0:r}  {1}  {2}", DateTime.Parse(currentRecord(0)), currentRecord(1), currentRecord(2))
                    Catch ex As MalformedLineException
                        '  The MalformedLineException is thrown by the
                        '  TextFieldParser anytime a line cannot be
                        '  parsed.
                        Console.WriteLine("An exception occurred attempting to parse this row:  ", ex.Message)
                    End Try
                Loop
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace