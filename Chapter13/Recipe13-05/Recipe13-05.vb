Imports System
Imports System.Runtime.InteropServices
Namespace Apress.VisualBasicRecipes.Chapter13

    Public Class Recipe13_05

        '  Declare the unmanaged functions.
        <DllImport("kernel32.dll")> _
        Private Shared Function FormatMessage(ByVal dwFlags As Integer, ByVal lpSource As Integer, ByVal dwMessage As Integer, ByVal dwLanguageId As Integer, ByRef lpBuffer As String, ByVal nSize As Integer, ByVal Arguments As Integer) As Integer
        End Function

        <DllImport("user32.dll", SetLastError:=True)> _
        Public Shared Function MessageBox(ByVal hWnd As IntPtr, ByVal pText As String, ByVal pCaption As String, ByVal uType As Integer) As Integer
        End Function
        Public Shared Sub Main()

            '  Invoke the MessageBox function passing an invalid
            '  window handle and thus forcing an error.
            Dim badWindowHandle As IntPtr = New IntPtr(-1)

            MessageBox(badWindowHandle, "Message", "Caption", 0)

            '  Obtain the error information.
            Dim errorCode As Integer = Marshal.GetLastWin32Error

            If Not errorCode = 0 Then
                Console.WriteLine(errorCode)
                Console.WriteLine(GetErrorMessage(errorCode))
            End If

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        '  GetErrorMessage formats and returns an error Message
        '  corresponding to the input error code.
        Public Shared Function GetErrorMessage(ByVal errorCode As Integer) As String

            Dim FORMAT_MESSAGE_ALLOCATE_BUFFER As Integer = &H100
            Dim FORMAT_MESSAGE_IGNORE_INSERTS As Integer = &H200
            Dim FORMAT_MESSAGE_FROM_SYSTEM As Integer = &H1000

            Dim messageSize As Integer = 255
            Dim lpMsgBuf As String = ""
            Dim dwFlags As Integer = FORMAT_MESSAGE_ALLOCATE_BUFFER Or FORMAT_MESSAGE_FROM_SYSTEM Or FORMAT_MESSAGE_IGNORE_INSERTS

            Dim retVal As Integer = FormatMessage(dwFlags, 0, errorCode, 0, lpMsgBuf, messageSize, 0)
            If retVal = 0 Then
                Return Nothing
            Else
                Return lpMsgBuf
            End If

        End Function

    End Class
End Namespace
