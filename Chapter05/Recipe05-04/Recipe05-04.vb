Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_04

        Public Shared Sub Main(ByVal args As String())

            If args.Length > 0 Then
                Dim dir As New DirectoryInfo(args(0))

                Console.WriteLine("Total size: " & CalculateDirectorySize(dir, True).ToString & " bytes.")

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete. Press Enter.")
                Console.ReadLine()

            Else
                Console.WriteLine("Please supply a directory path.")
            End If

        End Sub
        Public Shared Function CalculateDirectorySize(ByVal dir As DirectoryInfo, ByVal includeSubDirs As Boolean) As Long

            Dim totalSize As Long = 0

            '  Examine all contained files.
            Dim files As FileInfo() = dir.GetFiles

            For Each currentFile As FileInfo In files
                totalSize += currentFile.Length
            Next

            '  Examine all contained directories.
            If includeSubDirs Then
                Dim dirs As DirectoryInfo() = dir.GetDirectories

                For Each currentDir As DirectoryInfo In dirs
                    totalSize += CalculateDirectorySize(currentDir, True)
                Next

            End If

            Return totalSize

        End Function

    End Class

End Namespace
