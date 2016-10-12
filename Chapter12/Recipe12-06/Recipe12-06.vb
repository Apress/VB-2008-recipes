Imports System.Security
Imports System.Security.Permissions
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_06
        '  Define a variable to indicate whether the assembly has write
        '  access to the C:\Temp folder.
        Private canWrite As Boolean = False
        Public Sub New()
            '  Create and configure a FileIOPermission object that
            '  represents write access the the C:\Data folder.
            Dim fileIOPerm As New FileIOPermission(FileIOPermissionAccess.Write, "C:\Temp")

            '  Test if the current assembly has the specified permission.
            canWrite = SecurityManager.IsGranted(fileIOPerm)

        End Sub

    End Class

End Namespace