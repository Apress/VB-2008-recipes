Imports System
Imports System.Net
Imports System.Security.Permissions

'  Minimum permission request for SocketPermission.
<Assembly: SocketPermission(SecurityAction.RequestMinimum, Unrestricted:=True)> 

'  Optional permission request for IsolatedStorageFilePermission.
<Assembly: IsolatedStorageFilePermission(SecurityAction.RequestOptional, Unrestricted:=True)> 

'  Refuse request for ReflectionPermission.
<Assembly: ReflectionPermission(SecurityAction.RequestRefuse, Unrestricted:=True)> 

Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Receipe12_05

        Public Shared Sub Main()

            '  Create and configure a FileIOPermission object that represents
            '  write access to the C:\Temp folder.
            Dim fileIOPerm As New FileIOPermission(FileIOPermissionAccess.Write, "C:\Temp")

            '  Make the dmeand.
            fileIOPerm.Demand()

            '  Do something...

            '  Wait to continue.
            Console.Write("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
