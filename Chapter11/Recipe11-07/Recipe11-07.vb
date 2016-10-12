Imports System
Imports System.Net
Imports System.Net.Mail
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_07

        Public Shared Sub Main(ByVal args As String())

            '  Create and configure the SmtpClient that will send the mail.
            '  Specify the host name of the SMTP server and the port used
            '  to send mail.
            Dim client As New SmtpClient("mail.somecompany.com", 25)

            '  Configure the SmtpClient with the credentials used to connect
            '  to the SMTP server.
            client.Credentials = New NetworkCredential("user@somecompany.com", "password")

            '  Create the MailMessage to represent the e-mail being sent.
            Using msg As New MailMessage

                '  Configure the e-mail sender and subject.
                msg.From = New MailAddress("author@visual-basic-recipes.com")
                msg.Subject = "Greetings from Visual Basic Recipes"

                '  Configure the e-mail body.
                msg.Body = "This is a message from Recipe 11-07 of Visual Basic Recipes.  Attached is the source file and the binary for the recipe."

                '  Attach the files to the e-mail message and set their MIME type.
                msg.Attachments.Add(New Attachment("..\..\Recipe11-07.vb", "text/plain"))
                msg.Attachments.Add(New Attachment("Recipe11-07.exe", "application/octet-stream"))

                '  Iterate through the set of recipients specified on the
                '  command line.  Add all addresses with the correct structure
                '  as recipients.
                For Each arg As String In args
                    '  Create a MailAdress from each value on the command line
                    '  and add it to the set of recipients.
                    Try
                        msg.To.Add(New MailAddress(arg))
                    Catch ex As FormatException
                        '  Proceed to the next specified recipient.
                        Console.WriteLine("{0}: Error -- {1}", arg, ex.Message)
                        Continue For
                    End Try

                    '  Send the message.
                    client.Send(msg)
                Next
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace
