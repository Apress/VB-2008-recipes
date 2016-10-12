Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Public Class Recipe04_01

        '  A private class used to pass data to the DisplayMessage
        '  method when it is executed using the thread pool.
        Private Class MessageInfo
            Private m_Iterations As Integer
            Private m_Message As String

            '  A constructor that takes configuration settings for
            '  the thread.
            Public Sub New(ByVal iterations As Integer, ByVal message As String)

                m_Iterations = iterations
                m_Message = message

            End Sub

            '  Properties to retrieve configuration settings.
            Public ReadOnly Property Iterations() As Integer
                Get
                    Return m_Iterations
                End Get
            End Property
            Public ReadOnly Property Message() As String
                Get
                    Return m_Message
                End Get
            End Property

        End Class
        '  A method that conforms to the System.Threading.WaitCallback
        '  delegate signature.  Displays a message to the console.
        Public Shared Sub DisplayMessage(ByVal state As Object)
            '  Safely case the state argument to a MessageInfo object.
            Dim config As MessageInfo = TryCast(state, MessageInfo)

            '  If the config argument is nothing, no arguments were passed to
            '  the ThreadPool.QueueUserWorkItem method; use default values.
            If config Is Nothing Then
                '  Display a fixed message to the console three times.
                For count As Integer = 1 To 3
                    Console.WriteLine("A thread pool example.")

                    '  Sleep for the purpose of demonstration.  Avoid sleeping
                    '  on thread-pool threads in real applications.
                    Thread.Sleep(1000)
                Next
            Else
                '  Display the specified message the specified number of times.
                For count As Integer = 1 To config.Iterations
                    Console.WriteLine(config.Message)

                    '  Sleep for the purpose of demonstration.  Avoid sleeping
                    '  on thread-pool threads in real applications.
                    Thread.Sleep(1000)
                Next
            End If
        End Sub
        Public Shared Sub Main()

            '  Execute DisplayMessage using the thread pool and no arguments.
            ThreadPool.QueueUserWorkItem(AddressOf DisplayMessage)

            '  Create a MessageInfo object to pass to the DisplayMessage method.
            Dim info As New MessageInfo(5, "A thread pool example with arguments.")

            '  Execute a DisplayMessage using the thread pool and providing an
            '  argument.
            ThreadPool.QueueUserWorkItem(AddressOf DisplayMessage, info)

            '  Wait to continue.
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace