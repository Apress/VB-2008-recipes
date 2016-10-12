Imports System
Imports System.IO
Imports System.Text
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_04

        '  Create a byte array from a decimal.
        Public Shared Function DecimalToByteArray(ByVal src As Decimal) As Byte()

            '  Create a MemoryStream as a buffer to hold the binary data.
            Using stream As New MemoryStream
                '  Create a BinaryWriter to write binary data to the stream.
                Using writer As New BinaryWriter(stream)
                    '  Write the decimal to the BinaryWriter/MemoryStream.
                    writer.Write(src)

                    '  Return the byte representation of the decimal.
                    Return stream.ToArray
                End Using
            End Using

        End Function
        '  Create a decimal from a byte array.
        Public Shared Function ByteArrayToDecimal(ByVal src As Byte()) As Decimal

            '  Create a MemoryStream containing the byte array.
            Using stream As New MemoryStream(src)
                '  Create a BinaryReader to read the decomal from the stream.
                Using reader As New BinaryReader(stream)
                    '  Reda and return the decimal from the BinaryReader/MemoryStream.
                    Return reader.ReadDecimal
                End Using
            End Using

        End Function
        '  Base64 encode a Unicode string
        Public Shared Function StringToBase64(ByVal src As String) As String

            '  Get a byte representation of the source string.
            Dim b As Byte() = Encoding.Unicode.GetBytes(src)

            '  Return the Base64-encoded Unicode string.
            Return Convert.ToBase64String(b)

        End Function
        '  Decode a Base64-encoded Unicode string.
        Public Shared Function Base64ToString(ByVal src As String) As String

            '  Decode the Base64-encoded string to a byte array.
            Dim b As Byte() = Convert.FromBase64String(src)

            '  Return the decoded Unicode string.
            Return Encoding.Unicode.GetString(b)

        End Function
        '  Base64 encode a decimal
        Public Shared Function DecimalToBase64(ByVal src As Decimal) As String

            '  Get a byte representation of the decimal.
            Dim b As Byte() = DecimalToByteArray(src)

            '  Return the Base64-encoded decimal.
            Return Convert.ToBase64String(b)

        End Function
        '  Decode a Base64-encoded decimal.
        Public Shared Function Base64ToDecimal(ByVal src As String) As Decimal

            '  Decode the Base64-encoded decimal to a byte array.
            Dim b As Byte() = Convert.FromBase64String(src)

            '  Return the decoded decimal.
            Return ByteArrayToDecimal(b)

        End Function
        '  Base64 encode an int.
        Public Shared Function IntToBase64(ByVal src As Integer) As String

            '  Get a byte representation of the int.
            Dim b As Byte() = BitConverter.GetBytes(src)

            '  Return the Base64-encoded int.
            Return Convert.ToBase64String(b)

        End Function
        '  Decode a Base64-encoded int.
        Public Shared Function Base64ToInt(ByVal src As String) As Decimal

            '  Decode the Base64-encoded int to a byte array.
            Dim b As Byte() = Convert.FromBase64String(src)

            '  Return the decoded int.
            Return BitConverter.ToInt32(b, 0)

        End Function
        Public Shared Sub Main()

            '  Encode and decode a string
            Console.WriteLine(StringToBase64("Welcome to Visual Basic 2008 Recipes from Apress"))
            Console.WriteLine(Base64ToString("VwBlAGwAYwBvAG0AZQAgAHQAbwAgAFYAaQBzAHUAYQBsACAAQgBhAHMAaQBjACAAMgAwADAAOAAgAFIAZQBjAGkAcABlAHMAIABmAHIAbwBtACAAQQBwAHIAZQBzAHMA"))

            '  Encode and decode an decimal.
            Console.WriteLine(DecimalToBase64(285998345545.563846696D))
            Console.WriteLine(Base64ToDecimal("KDjBUP07BoEPAAAAAAAJAA=="))

            '  Encode and decode an int.
            Console.WriteLine(IntToBase64(35789))
            Console.WriteLine(Base64ToInt("zYsAAA=="))

            '  Wait to continue
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace