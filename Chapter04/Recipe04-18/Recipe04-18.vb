Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_18

        Public Shared Sub Main()

            '  A boolean that indicates whether this application has
            '  initial ownership of the Mutex.
            Dim ownsMutex As Boolean

            '  Attemps to create and take ownership of a Mutex named
            '  MutexExample.
            Using newMutex As New Mutex(True, "MutexExample", ownsMutex)
                '  If the application owns the Mutex it can continue to executel
                '  otherwise, the application should exit.
                If ownsMutex Then
                    Console.WriteLine("This application currently owns the mutex named" & _
                    " MutexExample. Additional instances of this application will not" & _
                    " run until you release the mutex by pressing Enter.")

                    Console.ReadLine()

                    '  Release the mutex.
                    newMutex.ReleaseMutex()
                Else
                    Console.WriteLine("Another instance of this application already owns" & _
                    " the mutex named MutexExample. This instance of the application will" & _
                    " terminate.")
                End If
            End Using

            '  Wait to continue.
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace