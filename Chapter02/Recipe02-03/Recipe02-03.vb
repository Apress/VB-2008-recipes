Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_03

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
        Public Shared Sub Main()

            Dim b As Byte() = Nothing

            '  Convert a bool to a byte array and display.
            b = BitConverter.GetBytes(True)
            Console.WriteLine(BitConverter.ToString(b))

            '  Convert a byte array to a bool and display.
            Console.WriteLine(BitConverter.ToBoolean(b, 0))

            '  Convert an int to a byte array and display.
            b = BitConverter.GetBytes(3678)
            Console.WriteLine(BitConverter.ToString(b))

            '  Convert a byte array to int and display.
            Console.WriteLine(BitConverter.ToInt32(b, 0))

            '  Convert a decimal to a byte array and display.
            b = DecimalToByteArray(285998345545.563846696D)
            Console.WriteLine(BitConverter.ToString(b))

            '  Convert a a byte array to a decimal and display.
            Console.WriteLine(ByteArrayToDecimal(b))

            '  Wait to continue
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
