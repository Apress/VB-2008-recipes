Imports System
Imports Microsoft.Win32
Namespace Apress.VisualBasicRecipes.Chapter15

    Public Class Recipe15_04

        Public Shared Sub Main()

            '  Variables to hold usage information read from registry.
            Dim lastUser As String
            Dim lastRun As String
            Dim runCount As Integer

            '  Read the name of the last user to run the application from the
            '  registry.  This is stored as the default value of the key and is
            '  accessed by not specifying a value name.  Cast the returned object
            '  to a string.
            lastUser = Registry.GetValue("HKEY_CURRENT_USER\Software\Apress\Visual Basic 2008 Recipes", "", "Nobody")

            '  If lastUser is Nothing, it means that the specified registry key
            '  does not exist.
            If lastUser Is Nothing Then
                lastUser = "Nobody"
                lastRun = "Never"
                runCount = 0
            Else
                '  Read the last run date and specify a default value of
                '  "Never".  Cast the returned Object to a String.
                lastRun = DirectCast(Registry.GetValue("HKEY_CURRENT_USER\Software\Apress\Visual Basic 2008 Recipes", "LastRun", "Never"), String)

                '  Read the run count value and specify a default value of
                '  0 (zero).  Cast the returned Object to an Integer.
                runCount = DirectCast(Registry.GetValue("HKEY_CURRENT_USER\Software\Apress\Visual Basic 2008 Recipes", "RunCount", 0), Integer)
            End If

            '  Display the usage information.
            Console.WriteLine("Last user name: " & lastUser)
            Console.WriteLine("Last run date/time: " & lastRun)
            Console.WriteLine("Previous executions: " & runCount)

            '  Update the usage information.  It doesn't matter if the registry
            '  key exists or not, SetValue will automatically create it.

            '  Update the "last user" information with the current username.
            '  Specifiy that this should be stored as the default value
            '  for the key by using an empty string as the value name.
            Registry.SetValue("HKEY_CURRENT_USER\Software\Apress\Visual Basic 2008 Recipes", "", Environment.UserName, RegistryValueKind.String)

            '  Update the "last run" information with the current date and time.
            '  Specify that this should be stored as a string value in the
            '  registry.
            Registry.SetValue("HKEY_CURRENT_USER\Software\Apress\Visual Basic 2008 Recipes", "LastRun", DateTime.Now.ToString, RegistryValueKind.String)

            '  Update the usage count information.  Specify that this should
            '  be stored as an Integer value in the registry.
            runCount += 1
            Registry.SetValue("HKEY_CURRENT_USER\Software\Apress\Visual Basic 2008 Recipes", "RunCount", runCount, RegistryValueKind.DWord)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace
