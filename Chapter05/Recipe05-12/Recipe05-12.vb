Imports System
Imports System.IO
Imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_12

        Public Shared Sub Main(ByVal args As String())

            If args.Length = 2 Then
                Console.WriteLine("comparing {0} and {1}", args(0), args(1))

                '  Create the hashing object.
                Using hashAlg As HashAlgorithm = HashAlgorithm.Create
                    Using fsA As New FileStream(args(0), FileMode.Open), fsB As New FileStream(args(1), FileMode.Open)
                        '  Calculate the hash for the files.
                        Dim hashBytesA As Byte() = hashAlg.ComputeHash(fsA)
                        Dim hashBytesB As Byte() = hashAlg.ComputeHash(fsB)

                        '  Compare the hashes.
                        If BitConverter.ToString(hashBytesA) = BitConverter.ToString(hashBytesB) Then
                            Console.WriteLine("Files match.")
                        Else
                            Console.WriteLine("No match.")
                        End If

                    End Using

                    '  Wait to continue.
                    Console.WriteLine(Environment.NewLine)
                    Console.WriteLine("Main method complete. Press Enter.")
                    Console.ReadLine()

                End Using

            Else
                Console.WriteLine("USAGE:  Recipe05-12 [fileName] [fileName]")
            End If

        End Sub

    End Class

End Namespace
