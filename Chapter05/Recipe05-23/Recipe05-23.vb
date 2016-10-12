Imports System
Imports System.IO
Imports System.Security.AccessControl
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_23

        Public Shared Sub Main()
            Dim fileName As String

            '  Create a new file and assign full control to 'Everyone'.
            Console.WriteLine("Press any key to write a new file...")
            Console.ReadKey(True)

            fileName = Path.GetRandomFileName
            Using testStream As New FileStream(fileName, FileMode.Create)
                '  Do something...
            End Using
            Console.WriteLine("Created a new file {0}.", fileName)
            Console.WriteLine()

            '  Deny 'Everyone' access to the file.
            Console.WriteLine("Press any key to deny 'Everyone' access to the file.")
            Console.ReadKey(True)

            SetRule(fileName, "Everyone", FileSystemRights.Read, AccessControlType.Deny)

            Console.WriteLine("Removed access rights of 'Everyone'.")
            Console.WriteLine()

            '  Attempt to access the file.
            Console.WriteLine("Press any key to attempt to access the file...")
            Console.ReadKey(True)

            Dim stream As FileStream
            Try
                stream = New FileStream(fileName, FileMode.Create)
            Catch ex As Exception
                Console.WriteLine("Exception thrown : ")
                Console.WriteLine(ex.ToString)
            Finally
                If stream IsNot Nothing Then
                    stream.Close()
                    stream.Dispose()
                End If
            End Try

            '  Wait to contiue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
        Private Shared Sub SetRule(ByVal filePath As String, ByVal account As String, ByVal rights As FileSystemRights, ByVal controlType As AccessControlType)

            '  Get a FileSecurity object that represents the
            '  current security settings.
            Dim fSecurity As FileSecurity = File.GetAccessControl(filePath)

            '  Update the FileSystemAccessRule with the new
            '  security settings.
            fSecurity.ResetAccessRule(New FileSystemAccessRule(account, rights, controlType))

            '  Set the new access settings.
            File.SetAccessControl(filePath, fSecurity)

        End Sub

    End Class

End Namespace