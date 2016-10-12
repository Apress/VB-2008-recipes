Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_01

        Public Shared Sub Main(ByVal args As String())

            If args.Length > 0 Then
                '  Display file information.
                Dim file As FileInfo = New FileInfo(args(0))

                Console.WriteLine("Checking file: " & file.Name)
                Console.WriteLine("File exists: " & file.Exists.ToString())

                If file.Exists Then
                    Console.Write("File created: ")
                    Console.WriteLine(file.CreationTime.ToString)
                    Console.Write("File last updated: ")
                    Console.WriteLine(file.LastWriteTime.ToString)
                    Console.Write("File last accessed: ")
                    Console.WriteLine(file.LastAccessTime.ToString)
                    Console.Write("File size (bytes): ")
                    Console.WriteLine(file.Length.ToString)
                    Console.Write("File attribute list: ")
                    Console.WriteLine(file.Attributes.ToString)
                End If
                Console.WriteLine()

                '  Display directory information.
                Dim dir As DirectoryInfo = file.Directory

                Console.WriteLine("Checking directory: " & dir.Name)
                Console.WriteLine("In directory: " & dir.Parent.Name)
                Console.Write("Directory exists: ")
                Console.WriteLine(dir.Exists.ToString)

                If dir.Exists Then
                    Console.Write("Directory created: ")
                    Console.WriteLine(dir.CreationTime.ToString)
                    Console.Write("Directory last updated: ")
                    Console.WriteLine(dir.LastWriteTime.ToString)
                    Console.Write("Directory last accessed: ")
                    Console.WriteLine(dir.LastAccessTime.ToString)
                    Console.Write("Directory attribute list: ")
                    Console.WriteLine(file.Attributes.ToString)
                    Console.Write("Directory contains: ")
                    Console.WriteLine(dir.GetFiles().Length.ToString & " files")
                End If
                Console.WriteLine()

                '  Display drive information.
                Dim drv As DriveInfo = New DriveInfo(file.FullName)

                Console.Write("Drive: ")
                Console.WriteLine(drv.Name)

                If drv.IsReady Then
                    Console.Write("Drive type: ")
                    Console.WriteLine(drv.DriveType.ToString)
                    Console.Write("Drive format: ")
                    Console.WriteLine(drv.DriveFormat.ToString)
                    Console.Write("Drive free space: ")
                    Console.WriteLine(drv.AvailableFreeSpace.ToString)
                End If

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
