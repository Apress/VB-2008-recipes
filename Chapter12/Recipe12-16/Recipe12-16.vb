Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_16

        Public Shared Sub Main(ByVal args As String())

            '  Create a byte array from the key string, which is the
            '  third command-line argument.
            Dim key As Byte() = Encoding.Default.GetBytes(args(2))

            '  Create a KeyedHashAlgorithm derived object to generate the keyed
            '  hash code for the input file.  Pass the byte array representing 
            '  the key to the constructor.
            Using hashAlg As KeyedHashAlgorithm = KeyedHashAlgorithm.Create(args(1))

                '  Assign the key.
                hashAlg.Key = key

                '  Open a FileStream to read the input file.  The filename is
                '  specified by the first command-line argument.
                Using argFile As New FileStream(args(0), FileMode.Open, FileAccess.Read)

                    '  Generate the keyed hash code of the file's contents.
                    Dim hash As Byte() = hashAlg.ComputeHash(argFile)

                    '  Display the keyed hash code to the console.
                    Console.WriteLine(BitConverter.ToString(hash))

                End Using
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace