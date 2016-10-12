Imports System
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_08

        Public Shared Sub ConnectedExample()

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"

                '  Create and configure a new command that includes the
                '  FOR XML AUTO clause.
                Using com As SqlCommand = con.CreateCommand

                    com.CommandType = CommandType.Text
                    com.CommandText = "SELECT DepartmentID, [Name], GroupName FROM HumanResources.Department FOR XML AUTO"

                    '  Open the database connection.
                    con.Open()

                    '  Execute the command and retrieve and XmlReader to access
                    '  the results.
                    Using reader As XmlReader = com.ExecuteXmlReader

                        '  Loop through the reader.
                        While reader.Read

                            '  Make sure we are dealing with an actual element of
                            '  some type.
                            If reader.NodeType = XmlNodeType.Element Then

                                '  Create an XElement object based on the current
                                '  contents of the reader.
                                Dim currentEle As XElement = XElement.ReadFrom(reader)

                                '  Display the name of the current element and list any
                                '  attributes that it may have.
                                Console.WriteLine("Element:  {0}", currentEle.Name)
                                If currentEle.HasAttributes Then
                                    For i As Integer = 0 To currentEle.Attributes.Count - 1
                                        Console.Write("  {0}: {1}", currentEle.Attributes()(i).Name, currentEle.Attributes()(i).Value)
                                    Next
                                End If
                            End If
                        End While

                    End Using

                    '  Close the database connection.
                    con.Close()

                End Using
            End Using

        End Sub
        Public Shared Sub DisconnectedExample()

            '  This will be used to create the new XML document.
            Dim doc As New XDocument

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"

                '  Create and configure a new command that includes the
                '  FOR XML AUTO clause.
                Using com As SqlCommand = con.CreateCommand

                    com.CommandType = CommandType.Text
                    com.CommandText = "SELECT DepartmentID, [Name], GroupName FROM HumanResources.Department FOR XML AUTO;"

                    '  Open the database connection.
                    con.Open()

                    '  Execute the command and retrieve and XmlReader to access
                    '  the results.
                    Using reader As XmlReader = com.ExecuteXmlReader
                        '  Create the parent element for the results.
                        Dim root As XElement = <Results></Results>

                        '  Loop throught the reader and add each node as a
                        '  child to the root.
                        While reader.Read
                            '  We need to make sure we are only dealing with
                            '  some form of an Element.
                            If reader.NodeType = XmlNodeType.Element Then
                                Dim newChild As XNode = XElement.ReadFrom(reader)
                                root.Add(newChild)
                            End If

                        End While

                        '  Finally, add the root element (and all of it's childred)
                        '  to the new XML document.
                        doc.Add(root)

                    End Using

                    '  Close the database connection.
                    con.Close()

                End Using
            End Using

            '  Process the disconnected XmlDocument.
            Console.WriteLine(doc.ToString)

        End Sub
        Public Shared Sub Main()

            ConnectedExample()
            Console.WriteLine(Environment.NewLine)

            DisconnectedExample()
            Console.WriteLine(Environment.NewLine)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
