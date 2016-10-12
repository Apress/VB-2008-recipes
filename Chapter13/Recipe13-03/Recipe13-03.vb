Imports System
Imports System.Runtime.InteropServices
Namespace Apress.VisualBasicRecipes.Chapter13

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure OSVersionInfo
        Public dwOSVersionInfoSize As Integer
        Public dwMajorVersion As Integer
        Public dwMinorVersion As Integer
        Public dwBuildNumber As Integer
        Public dwPlatformId As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)> _
        Public szCSDVersion As String
    End Structure
    Public Class Recipe13_03

        '  Declare the external function.
        <DllImport("kernel32.dll")> _
        Public Shared Function GetVersionEx(<[In](), Out()> ByRef osvi As OSVersionInfo) As Boolean
        End Function
        Public Shared Sub Main()

            Dim osvi As New OSVersionInfo

            osvi.dwOSVersionInfoSize = Marshal.SizeOf(osvi)

            '  Obtain the OS version information.
            GetVersionEx(osvi)

            '  Display the version information.
            Console.WriteLine("Class Size: " & osvi.dwOSVersionInfoSize.ToString)
            Console.WriteLine("Major Version: " & osvi.dwMajorVersion.ToString)
            Console.WriteLine("Minor Version: " & osvi.dwMinorVersion.ToString)
            Console.WriteLine("Build Number: " & osvi.dwBuildNumber.ToString)
            Console.WriteLine("Platform Id: " & osvi.dwPlatformId.ToString)
            Console.WriteLine("CSD Version: " & osvi.szCSDVersion.ToString)
            Console.WriteLine("Platform: " & Environment.OSVersion.Platform.ToString)
            Console.WriteLine("Version: " & Environment.OSVersion.Version.ToString)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
