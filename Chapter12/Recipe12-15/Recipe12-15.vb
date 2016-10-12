Imports System
Imports System.Text
Imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_15

        '  A method to compare a newly generated hash code with an
        '  existing hash code that's represented by a hex code string.
        Private Shared Function VerifyHexHash(ByVal hash As Byte(), ByVal oldHashString As String)

            '  Create a string representation of the hash code bytes.
            Dim newHashString As New StringBuilder(hash.Length)

            '  Append each byte as a two character uppercase hex string.
            For Each b As Byte In hash
                newHashString.AppendFormat("{0:X2}", b)
            Next

            '  Compare the string representation of the old and new hash
            '  codes and return the result.
            Return oldHashString.Replace("-", "") = newHashString.ToString

        End Function
        '  A method to compare a newly generated hash code with an
        '  existing hash code that's represented by a Base64-encoded
        '  string.
        Private Shared Function VerifyB64Hash(ByVal hash As Byte(), ByVal oldHashString As String) As Boolean

            '  Create a Base64 representation of the hash code bytes.
            Dim newHashString As String = Convert.ToBase64String(hash)

            '  Compare the string represenations of the old and new hash
            '  codes and return the result.
            Return oldHashString = newHashString

        End Function
        '  A method to compare a newly generated hash code with an 
        '  existing hash code represented by a byte array.
        Private Shared Function VerifyByteHash(ByVal hash As Byte(), ByVal oldHash As Byte()) As Boolean

            '  If either array is nothing or the arrays are different lengths,
            '  then they are not equal.
            If hash Is Nothing Or oldHash Is Nothing Or Not (hash.Length = oldHash.Length) Then
                Return False
            End If

            '  Step through the byte arrays and compare each byte value.
            For count As Integer = 0 To hash.Length - 1
                If Not hash(count) = oldHash(count) Then Return False
            Next

            '  Hash codes are equal.
            Return True

        End Function

    End Class
End Namespace
