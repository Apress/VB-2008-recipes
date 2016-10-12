Imports System
Imports System.IO
Imports System.Collections
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Runtime.Serialization.Formatters.Binary
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_15

        '  Serialize an ArrayList object to a binary file.
        Private Shared Sub BinarySerialize(ByVal list As ArrayList)

            Using str As FileStream = File.Create("people.bin")
                Dim bf As New BinaryFormatter()
                bf.Serialize(str, list)
            End Using

        End Sub
        '  Deserialize an Arraylist object from a binary file.
        Private Shared Function BinaryDeserialize() As ArrayList
            Dim people As ArrayList = Nothing

            Using str As FileStream = File.OpenRead("people.bin")
                Dim bf As New BinaryFormatter()
                people = DirectCast(bf.Deserialize(str), ArrayList)
            End Using
            Return people

        End Function
        '  Serialize an ArrayList object to a SOAP file.
        Private Shared Sub SoapSerialize(ByVal list As ArrayList)

            Using str As FileStream = File.Create("people.soap")
                Dim sf As New SoapFormatter()
                sf.Serialize(str, list)
            End Using

        End Sub
        '  Deserialize an Arraylist object from a SOAP file.
        Private Shared Function SoapDeserialize() As ArrayList
            Dim people As ArrayList = Nothing

            Using str As FileStream = File.OpenRead("people.soap")
                Dim sf As New SoapFormatter()
                people = DirectCast(sf.Deserialize(str), ArrayList)
            End Using
            Return people

        End Function
        Public Shared Sub Main()

            '  Create and configure the ArrayList to serialize.
            Dim people As New ArrayList
            people.Add("Alex")
            people.Add("Dave")
            people.Add("Matthew")
            people.Add("Robb")

            '  Serialize the list to a file in both binary and SOAP form.
            BinarySerialize(people)
            SoapSerialize(people)

            '  Rebuild the lists of people form the binary and SOAP
            '  serializations and siaply them to the console.
            Dim binaryPeople As ArrayList = BinaryDeserialize()
            Dim soapPeople As ArrayList = SoapDeserialize()

            Console.WriteLine("Binary People:")
            For Each s As String In binaryPeople
                Console.WriteLine(vbTab & s)
            Next

            Console.WriteLine(vbCrLf & "SOAP People:")
            For Each s As String In soapPeople
                Console.WriteLine(vbTab & s)
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
