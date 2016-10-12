Imports System
Imports Microsoft.Win32
Namespace Apress.VisualBasicRecipes.Chapter15

    Public Class Recipe15_05

        Public Shared Sub SearchSubKeys(ByVal root As RegistryKey, ByVal searchKey As String)

            '  Loop through all subkeys contained in the current key.
            For Each keyName As String In root.GetSubKeyNames

                Try
                    Using key As RegistryKey = root.OpenSubKey(keyName)
                        If keyName = searchKey Then PrintKeyValues(key)
                        If Not key Is Nothing Then SearchSubKeys(key, searchKey)
                    End Using
                Catch ex As Security.SecurityException
                    '  Ignore SecurityException for the purpose of this example.
                    '  Some subkeys of HKEY_CURRENT_USER are secured and will
                    '  throw a SecurityException when opened.
                End Try
            Next

        End Sub
        Public Shared Sub PrintKeyValues(ByVal key As RegistryKey)

            '  Display the name of the matching subkey and the number of
            '  values it contains.
            Console.WriteLine("Registry key found : {0} contains {1} values", key.Name, key.ValueCount)

            '  Loop through the values and display.
            For Each valueName As String In key.GetValueNames

                If TypeOf key.GetValue(valueName) Is String Then
                    Console.WriteLine("  Value : {0} = {1}", valueName, key.GetValue(valueName))
                End If

            Next

        End Sub
        Public Shared Sub Main(ByVal args As String())

            If args.Length > 0 Then
                '  Open the CurrentUser base key.
                Using root As RegistryKey = Registry.CurrentUser
                    '  Search recursively through the registry for any keys
                    '  with the specified name.
                    SearchSubKeys(root, args(0))
                End Using
            End If

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace
