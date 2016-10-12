Imports System
Imports System.IO
Imports System.Security.Principal
Imports System.Security.Permissions
Imports System.Runtime.InteropServices

'  Ensure the assembly has permission to execute unmanaged code
'  and control the thread principal.
<Assembly: SecurityPermission(SecurityAction.RequestMinimum, UnmanagedCode:=True, ControlPrincipal:=True)> 

Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_11

        '  Define some constants for use with the LogonUser function.
        Const LOGON32_PROVIDER_DEFAULT As Integer = 0
        Const LOGON32_LOGON_INTERACTIVE As Integer = 2

        '  Import the Win32 LogonUser function from advapi32.dll.  Specify
        '  "SetLastError = True" to correctly support access to Win32 error
        '  codes.
        <DllImport("advapi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)> _
        Private Shared Function LogonUser(ByVal userName As String, ByVal domain As String, ByVal password As String, ByVal logonType As Integer, ByVal logonProvider As Integer, ByRef accessToken As IntPtr) As Boolean
        End Function

        Public Shared Sub Main(ByVal args As String())

            '  Create a new IntPtr to hold the access token return by the
            '  LogonUser function.
            Dim accessToken As IntPtr = IntPtr.Zero

            '  Call the Logonuser function to obtain an access token for the
            '  specified user.  The accessToken variable is passed to LogonUser
            '  by reference and will contain a refernce to the Windows access 
            '  token if LogonUser is successful.
            Dim success As Boolean = LogonUser(args(0), ".", args(1), LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, accessToken)

            '  If LogonUser returns False, an error has occurred.
            '  Display the error and exit.
            If Not success Then
                Console.WriteLine("LogonUser returned error {0}", Marshal.GetLastWin32Error())
            Else
                '  Display the active identity.
                Console.WriteLine("Identity before impersonation = {0}", WindowsIdentity.GetCurrent.Name)

                '  Create a new WindowsIdentity from the Windows access token.
                Dim identity As New WindowsIdentity(accessToken)

                '  Impersonate the specified user, saving a reference to the
                '  returned WindowsImpersonationContext, which contains the
                '  information necessary to revert to the orginal user context.
                Dim impContext As WindowsImpersonationContext = identity.Impersonate

                '  Display the active identity.
                Console.WriteLine("Identity during impersonation = {0}", WindowsIdentity.GetCurrent.Name)

                '  Perform actions as the impersonated user...

                '  Revert to the orginial Windows user using the
                '  WindowsImpersonationContext object.
                impContext.Undo()

                '  Display the active identity.
                Console.WriteLine("Identity after impersonation = {0}", WindowsIdentity.GetCurrent.Name)

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete.  Press Enter.")
                Console.ReadLine()

            End If

        End Sub

    End Class

End Namespace