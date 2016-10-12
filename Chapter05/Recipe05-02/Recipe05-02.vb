Imports System
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_02

        Public Shared Sub Main()

            '  This file has the archive and read-only attributes.
            Dim file As New FileInfo("data.txt")

            '  This displays the string "ReadOnly, Archive".
            Console.WriteLine(file.Attributes.ToString)

            '  This test fails, because other attributes are set.
            If file.Attributes = FileAttributes.ReadOnly Then
                Console.WriteLine("File is read-only (faulty test).")
            End If

            '  This test succeeds, because it filters out just the
            '  read-only attributes.
            If file.Attributes And FileAttributes.ReadOnly = FileAttributes.ReadOnly Then
                Console.WriteLine("File is read-only (correct test).")
            End If

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace