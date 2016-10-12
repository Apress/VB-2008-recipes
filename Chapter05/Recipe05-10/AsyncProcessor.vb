Imports System
Imports System.IO
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class AsyncProcessor

        Private inputStream As Stream
        '  The buffer that will hold the retrieved data.
        Private buffer As Byte()
        '  The amount that will be read in one block (2 kb).
        Private m_BufferSize As Integer = 2048
        Public ReadOnly Property BufferSize() As Integer
            Get
                Return m_BufferSize
            End Get
        End Property
        Public Sub New(ByVal fileName As String, ByVal size As Integer)

            m_BufferSize = size
            buffer = New Byte(m_BufferSize) {}

            '  Open the file, specifying true for asynchronous support.
            inputStream = New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, BufferSize, True)

        End Sub
        Public Sub StartProcess()

            '  Start the asynchronous read, which will fill the buffer.
            inputStream.BeginRead(buffer, 0, buffer.Length, AddressOf OnCompletedRead, Nothing)

        End Sub
        Private Sub OnCompletedRead(ByVal asyncResult As IAsyncResult)

            '  One block has been read asynchronously.  Retrieve
            '  the data.
            Dim bytesRead As Integer = inputStream.EndRead(asyncResult)

            '  If no bytes are read, the stream is at the end of the file.
            If bytesRead > 0 Then
                '  Pause to simulate processing this block of data.
                Console.WriteLine("{0}[ASYNC READER]: Read one block.", ControlChars.Tab)
                Thread.Sleep(TimeSpan.FromMilliseconds(20))

                '  Begin to read the next block asynchronously.
                inputStream.BeginRead(buffer, 0, buffer.Length, AddressOf OnCompletedRead, Nothing)
            Else
                '  End the operation.
                Console.WriteLine("{0}[ASYNC READER]: Complete.", ControlChars.Tab)
                inputStream.Close()
            End If

        End Sub

    End Class

End Namespace