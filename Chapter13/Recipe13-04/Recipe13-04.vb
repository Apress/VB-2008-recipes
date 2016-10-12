Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Namespace Apress.VisualBasicRecipes.Chapter13

    Public Class Recipe13_04

        '  The signature for the callback method.
        Public Delegate Function CallBack(ByVal hwnd As IntPtr, ByVal lParam As Integer) As Boolean

        '  The unmanaged function that will trigger the CallBack
        '  as it enumerates the open windows.
        <DllImport("user32.dll")> _
        Public Shared Function EnumWindows(ByVal windowCallback As CallBack, ByVal param As Integer) As Integer
        End Function
        <DllImport("user32.dll")> _
        Public Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal text As StringBuilder, ByVal count As Integer) As Integer
        End Function
        Public Shared Sub Main()

            '  Request that the operating system enumerate all windows,
            '  and trigger your callback with the handle of each one.
            EnumWindows(AddressOf DisplayWindowInfo, 0)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        '  The method that will receive the callback.  The second
        '  parameter is not used, but is needed to match the
        '  callback's signature.
        Public Shared Function DisplayWindowInfo(ByVal hWnd As IntPtr, ByVal lPatam As Integer) As Boolean

            Dim chars As Integer = 100
            Dim buf As New StringBuilder(chars)

            If Not GetWindowText(hWnd, buf, chars) = 0 Then
                Console.WriteLine(buf)
            End If
            Return True

        End Function

    End Class
End Namespace