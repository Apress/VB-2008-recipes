Imports System
Imports System.IO
Imports System.Windows.Forms
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_20

        Public Shared Sub Main()

            Using watch As New FileSystemWatcher

                watch.Path = Application.StartupPath
                watch.Filter = "*.*"
                watch.IncludeSubdirectories = True

                '  Attach the event handlers.
                AddHandler watch.Created, AddressOf OnCreatedOrDeleted
                AddHandler watch.Deleted, AddressOf OnCreatedOrDeleted
                watch.EnableRaisingEvents = True

                Console.WriteLine("Press Enter to create a file.")
                Console.ReadLine()

                If File.Exists("test.bin") Then
                    File.Delete("test.bin")
                End If

                '  Create test.bin file.
                Using fs As New FileStream("test.bin", FileMode.Create)
                    '  Do something here...
                End Using

                Console.WriteLine("Press Enter to terminate the application.")
                Console.ReadLine()

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
        '  Fires when a new file is created or deleted in the directory
        '  that is being monitored.
        Private Shared Sub OnCreatedOrDeleted(ByVal sender As Object, ByVal e As FileSystemEventArgs)

            '  Display the notification information.
            Console.WriteLine("{0}NOTIFICATION: {1} was {2}", ControlChars.Tab, e.FullPath, e.ChangeType.ToString)
            Console.WriteLine()

        End Sub

    End Class

End Namespace
