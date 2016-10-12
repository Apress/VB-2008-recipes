Imports System
Imports System.IO
Imports System.IO.IsolatedStorage
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_19

        Public Shared Sub Main(ByVal args As String())

            '  Create the store for the current user.
            Using store As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly
                '  Create a folder in the root of the isolated store.
                store.CreateDirectory("MyFolder")

                '  Create a file in the isolated store.
                Using fs As New IsolatedStorageFileStream("MyFile.txt", FileMode.Create, store)
                    Dim w As New StreamWriter(fs)

                    '  You can now write to the file as normal.
                    w.WriteLine("Test")
                    w.Flush()

                End Using

                Console.WriteLine("Current size: " & store.CurrentSize.ToString)
                Console.WriteLine("Scope: " & store.Scope.ToString)
                Console.WriteLine("Contained files include:")

                Dim files As String() = store.GetFileNames("*.*")
                For Each file As String In files
                    Console.WriteLine(file)
                Next

            End Using


            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
