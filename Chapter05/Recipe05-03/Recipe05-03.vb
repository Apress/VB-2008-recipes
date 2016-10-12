Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_03

        Public Shared Sub Main(ByVal args As String())

            If args.Length = 2 Then
                Dim sourceDir As New DirectoryInfo(args(0))
                Dim destinationDir As New DirectoryInfo(args(1))

                CopyDirectory(sourceDir, destinationDir)

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete. Press Enter.")
                Console.ReadLine()

            Else
                Console.WriteLine("USAGE:  " & " Recipe05_03 [sourcePath] [destionationPath]")
            End If

        End Sub
        Public Shared Sub CopyDirectory(ByVal source As DirectoryInfo, ByVal destination As DirectoryInfo)

            If Not destination.Exists Then
                Console.WriteLine("Creating the destination folder {0}", destination.FullName)
                destination.Create()
            End If

            '  Copy all files.
            Dim files As FileInfo() = source.GetFiles

            For Each file As FileInfo In files
                Console.WriteLine("Copying the {0} file...", file.Name)
                file.CopyTo(Path.Combine(destination.FullName, file.Name))
            Next

            '  Process subdirectories.
            Dim dirs As DirectoryInfo() = source.GetDirectories

            For Each dir As DirectoryInfo In dirs
                '  Get destination directory.
                Dim destinationDir As String = Path.Combine(destination.FullName, dir.Name)

                '  Call CopyDirectory recursively.
                CopyDirectory(dir, New DirectoryInfo(destinationDir))
            Next

        End Sub


    End Class

End Namespace