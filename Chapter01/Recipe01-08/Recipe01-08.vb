#Const winXP = True

Imports System
Imports System.Diagnostics

Namespace APress.VisualBasicRecipes.Chapter01

    Public Class Recipe01_08

        '  Declare a string to contain the platform name
        Private Shared platformName As String
        <Conditional("DEBUG")> _
        Public Shared Sub DumpState()
            Console.WriteLine("Dump some state...")
        End Sub
        Public Shared Sub Main()

#If winVista Then       '  Compiling for Windows Vista
            platformName = "Microsoft Windows Vista"
#ElseIf winXP Then      '  Compiling for Windows XP
            platformName = "Microsoft Windows XP"
#ElseIf win2000 Then    '  Compiling for Windows 2000
            platformName = "Microsoft Windows 2000"
#ElseIf winNT Then      '  Compiling for Windows NT
            platformName = "Microsoft Windows NT"
#ElseIf win98 Then      '  Compiling for Windows 98
            platformName = "Microsoft Windows 98"
#Else                   '  Unknown platform specified
            platformName = "Unknown"
#End If

            Console.WriteLine(platformName)

            '  Call the conditional DumpState method
            DumpState()

            '  Wait to continue...
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.Read()

        End Sub

    End Class

End Namespace

