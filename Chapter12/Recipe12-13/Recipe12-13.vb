Imports System
Imports System.Text
Imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_13

        Public Shared Sub Main(ByVal args As String())

            '  Create a HashAlgorithm of the type specified by the first
            '  command-line argument.
            Dim hashAlg As HashAlgorithm = Nothing

            '  Some of the classes cannot be instantiated using the
            '  factory method so they most be directly created.
            Select Case args(0).ToUpper()
                Case "SHA1MANAGED"
                    hashAlg = New SHA1Managed
                Case "SHA256CRYPTOSERVICEPROVIDER"
                    hashAlg = New SHA256CryptoServiceProvider
                Case "SHA384CRYPTOSERVICEPROVIDER"
                    hashAlg = New SHA384CryptoServiceProvider
                Case "SHA512CRYPTOSERVICEPROVIDER"
                    hashAlg = New SHA512CryptoServiceProvider
                Case Else
                    hashAlg = HashAlgorithm.Create(args(0))
            End Select

            Using hashAlg

                '  Convert the password string, provided as the second
                '  command-line argument, to an array of bytes.
                Dim pwordData As Byte() = Encoding.Default.GetBytes(args(1))

                '  Generate the hash code of the password.
                Dim hash As Byte() = hashAlg.ComputeHash(pwordData)

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