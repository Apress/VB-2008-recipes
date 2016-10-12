Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_17

        Public Shared Sub Main(ByVal args As String())

            If args.Length = 1 Then
                Dim drive As New DriveInfo(args(0))

                Console.Write("Free space in {0}-drive (in kilobytes): ", args(0))
                Console.WriteLine(drive.AvailableFreeSpace / 1024)
            Else
                For Each drive As DriveInfo In DriveInfo.GetDrives

                    Try
                        Console.WriteLine("Free space in {0}-drive (in kilobytes):  {1}", drive.RootDirectory, drive.AvailableFreeSpace / 1024.ToString)
                    Catch ex As IOException
                        Console.WriteLine(drive)
                    End Try

                Next
            End If

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
