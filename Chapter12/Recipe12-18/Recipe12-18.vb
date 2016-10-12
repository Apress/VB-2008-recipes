Imports System
Imports System.Text
Imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_18

        Public Shared Sub Main()

            '  Read the string from the console.
            Console.Write("Enter the string to encrypt: ")
            Dim str As String = Console.ReadLine

            '  Create a byte array of entropy to use in the encryption process.
            Dim entropy As Byte() = {0, 1, 2, 3, 4, 5, 6, 7, 8}

            '  Encrypt the entered string after converting it to a
            '  byte array.  Use CurrentUser scope so that only the
            '  current user can decrypt the data.
            Dim enc As Byte() = ProtectedData.Protect(Encoding.Default.GetBytes(str), entropy, DataProtectionScope.LocalMachine)

            '  Display the encrypted data to the console.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Encrypted string = {0}", BitConverter.ToString(enc))

            '  Attempt to decrypt the data using CurrentUser scope.
            Dim dec As Byte() = ProtectedData.Unprotect(enc, entropy, DataProtectionScope.CurrentUser)

            '  Display the data decrypted using CurrentUser scope.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Decrypted data using CurrentUser scope = {0}", Encoding.Default.GetString(dec))

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace