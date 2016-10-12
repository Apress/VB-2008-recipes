Imports System
Namespace Apress.VisualBasicRecipes.Chapter14

    <Serializable()> _
    Public NotInheritable Class MailReceivedEventArgs
        Inherits EventArgs

        '  Private read-only members that hold the event state that is to be
        '  distributed to all event handlers.  The MailReceivedEventArgs class
        '  will specify who sent the received mail and what the subject is.
        Private ReadOnly m_From As String
        Private ReadOnly m_Subject As String

        '  Constuctor, initializes event state.
        Public Sub New(ByVal _from As String, ByVal _subject As String)

            Me.m_From = _from
            Me.m_Subject = _subject

        End Sub
        '  Read-only properties to provide access to event state.
        Public ReadOnly Property From() As String
            Get
                Return m_From
            End Get
        End Property
        Public ReadOnly Property Subject() As String
            Get
                Return m_Subject
            End Get
        End Property

    End Class
    '  A class to demonstrate the use of MailReceivedEventArgs.
    Public Class Recipe14_08

        Public Shared Sub Main()

            Dim args As New MailReceivedEventArgs("Amy", "Work Plan")

            Console.WriteLine("From: {0}, Subject: {1}", args.From, args.Subject)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace
