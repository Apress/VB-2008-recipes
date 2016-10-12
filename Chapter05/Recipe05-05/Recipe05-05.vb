Imports System
Imports System.Diagnostics
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_05

        Public Shared Sub Main(ByVal args As String())

            If args.Length > 0 Then
                Dim info As FileVersionInfo = FileVersionInfo.GetVersionInfo(args(0))

                '  Display version information.
                Console.WriteLine("Checking File: " & info.FileName)
                Console.WriteLine("Product Name: " & info.ProductName)
                Console.WriteLine("Product Version: " & info.ProductVersion)
                Console.WriteLine("Company Name: " & info.CompanyName)
                Console.WriteLine("File Version: " & info.FileVersion)
                Console.WriteLine("File Description: " & info.FileDescription)
                Console.WriteLine("Original Filename: " & info.OriginalFilename)
                Console.WriteLine("Legal Copyright: " & info.LegalCopyright)
                Console.WriteLine("InternalName: " & info.InternalName)
                Console.WriteLine("IsDebug: " & info.IsDebug)
                Console.WriteLine("IsPatched: " & info.IsPatched)
                Console.WriteLine("IsPreRelease: " & info.IsPreRelease)
                Console.WriteLine("IsPrivateBuild: " & info.IsPrivateBuild)
                Console.WriteLine("IsSpecialBuild: " & info.IsSpecialBuild)

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete. Press Enter.")
                Console.ReadLine()

            Else
                Console.WriteLine("Please supply a filename.")
            End If

        End Sub

    End Class

End Namespace
