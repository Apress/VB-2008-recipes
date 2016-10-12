Imports System
Imports System.Xml.Linq
Imports Microsoft.VisualBasic.FileIO
Imports System.Text
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_10

        Public Shared Sub Main(ByVal args As String())

            '  Call the sub routine to convert an XML tree to
            '  a delimited text file.
            Call XMLToFile(args(0))

            '  Call the sub routine to conver a delimited text
            '  file to an XML tree.
            Call FileToXML()


            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        Private Shared Sub XMLToFile(ByVal xmlFile As String)

            '  Load the Employees.xml file and store the contents into
            ' an XElement object.
            Dim employees As XElement = XElement.Load(xmlFile)

            '  Create a StringBuilder that will be used to hold
            '  the delimited text.
            Dim delimitedData As New StringBuilder

            '  Create a query to convert the xml data into fields delimited
            '  by quotes and commas.
            Dim xmlData = _
                From emp In employees.<Employee> _
                    Select _
                    String.Format("""{0}"",""{1}"",""{2}"",""{3}"",""{4}""", _
                        emp.@id, emp.<Name>.Value, _
                        emp.<Title>.Value, emp.<HireDate>.Value, _
                        emp.<HourlyRate>.Value)

            '  Execute the query and store the contents into the
            '  StringBuilder.
            For Each row In xmlData
                delimitedData.AppendLine(row)
            Next

            '  Display the contents to the screen and save it to the data.txt
            '  file.
            Console.WriteLine(delimitedData.ToString)
            File.WriteAllText("data.txt", delimitedData.ToString)

        End Sub
        Private Shared Sub FileToXML()

            '  Create the XElement object that will be used to build
            '  the XML data.
            Dim xmlTree As XElement

            '  Open the data.text file and parse it into a TextFieldParser
            '  object.
            Using parser As TextFieldParser = My.Computer.FileSystem.OpenTextFieldParser("data.txt")

                '  Configure the TextFieldParser to ensure it understands
                '  that the fields are encolsed in quotes and delimited
                '  with commas.
                parser.TextFieldType = FieldType.Delimited
                parser.Delimiters = New String() {","}
                parser.HasFieldsEnclosedInQuotes = True

                '  Create the root of our XML tree.
                xmlTree = <Employees></Employees>

                Dim currentRow As String()

                '  Loop through the file until the end is reached.
                Do While Not parser.EndOfData

                    '  Parse the fields out for the current row.
                    currentRow = parser.ReadFields

                    '  Create each employee node and add it to the tree.
                    '  Each node is created using embedded expressions
                    '  that contain the appropriate field data that was
                    '  previously parsed.
                    xmlTree.Add(<Employee id=<%= currentRow(0) %>>
                                    <Name><%= currentRow(1) %></Name>
                                    <Title><%= currentRow(2) %></Title>
                                    <HireDate><%= currentRow(3) %></HireDate>
                                    <HourlyRate><%= currentRow(4) %></HourlyRate>
                                </Employee>)
                Loop

            End Using

            '  Display the new XML tree to the screen.
            Console.WriteLine(xmlTree)

        End Sub

    End Class

End Namespace