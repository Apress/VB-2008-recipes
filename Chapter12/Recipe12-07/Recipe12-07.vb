Imports System.Security.Permissions
Namespace Apress.VisualBasicRecipes.Chapter12

    <PublisherIdentityPermission(SecurityAction.InheritanceDemand, CertFile:="pubcert.cer")> _
    Public Class Recipe12_07

        <PermissionSet(SecurityAction.InheritanceDemand, Name:="FullTrust")> _
        Public Sub SomeProtectedMethod()
            '  Method implementation...
        End Sub

    End Class
End Namespace
