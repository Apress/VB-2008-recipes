Imports System
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_06

        Public Shared Sub Main()

            '  Create a WebRequest that authenticates the user with a
            '  username and password combination over basic authentication.
            Dim requestA As WebRequest = WebRequest.Create("http://www.somesite.com")
            requestA.Credentials = New NetworkCredential("username", "password")

            '  Create a WebRequest that authenticates the current user
            '  with Windows integrated authentication.
            Dim requestB As WebRequest = WebRequest.Create("http://www.somesite.com")
            requestB.Credentials = CredentialCache.DefaultCredentials

            '  Create a WebRequest that authenticates the use with a client
            '  certificate loaded from a file.
            Dim requestC As HttpWebRequest = DirectCast(WebRequest.Create("http://www.somesite.com"), HttpWebRequest)
            Dim cert1 = X509Certificate.CreateFromCertFile("..\..\TestCertificate.cer")
            requestC.ClientCertificates.Add(cert1)

            '  Create a WebRequest that authenticates the user with a client
            '  certificate loaded from a certificate store.  Try to find a
            '  certificate with a specific subject, but if it is not found
            '  present the user with a dialog so they can select the certificate
            '  to use from their personal store.
            Dim requestD As HttpWebRequest = DirectCast(WebRequest.Create("http://www.somesite.com"), HttpWebRequest)
            Dim store As New X509Store
            Dim certs As X509Certificate2Collection = store.Certificates.Find(X509FindType.FindBySubjectName, "Todd Herman", False)

            If certs.Count = 1 Then
                requestD.ClientCertificates.Add(certs(0))
            Else
                certs = X509Certificate2UI.SelectFromCollection(store.Certificates, "Select Certificate", "Select the certificate to use for authentication.", X509SelectionFlag.SingleSelection)

                If Not certs.Count = 0 Then
                    requestD.ClientCertificates.Add(certs(0))
                End If
            End If

            '  Now issue the request and process the responses...

        End Sub

    End Class

End Namespace

