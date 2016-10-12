Imports System
Imports System.Security.Principal
Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_09

        Public Shared Sub Main(ByVal args As String())

            '  Obtain a WindowsIdentity object representing the currently
            '  logged on Windows user.
            Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent

            '  Create a Windows Principal object that represents the security
            '  capabilities of the specified WindowsIdentity; in this case,
            '  the Windows groups to which the current user belongs.
            Dim principal As New WindowsPrincipal(identity)

            '  Iterate through the group names specified as command-line 
            '  arguments and test to see if the current user is a member of
            '  each one.
            For Each role As String In args
                Console.WriteLine("Is {0} a member of {1}? = {2}", identity.Name, role, principal.IsInRole(role))
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.Write("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
