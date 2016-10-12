Imports System
Imports System.IO
Imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_14

        Public Shared Sub Main(ByVal args As String())

            '  Create a HashAlgorithm of the type specified by the first
            '  command-line argument.
            Dim hashAlg As HashAlgorithm = Nothing

            '  The SHA1Managed algorithm cannot be implemented using the
            '  factory approach. It must be instantiated directly.
            If args(0).CompareTo("SHA1Managed") = 0 Then
                hashAlg = New SHA1Managed
            Else
                hashAlg = HashAlgorithm.Create(args(0))
            End If

            '  Open a FileStream to the file specified by the second
            '  command-line argument.
            Using fileArg As New FileStream(args(1), FileMode.Open, FileAccess.Read)

                '  Generate the hash code of the password.
                Dim hash As Byte() = hashAlg.ComputeHash(fileArg)

                '  Display the hash code of the password to the console.
                Console.WriteLine(BitConverter.ToString(hash))

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete.  Press Enter.")
                Console.ReadLine()

            End Using

        End Sub

    End Class

End Namespace