Imports System
Imports System.Runtime.Remoting
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_14Host

        Public Shared Sub Main()

            '  Register the remotable classes defined in the specified
            '  configuration file.
            RemotingConfiguration.Configure("Recipe11-14Host.exe.config", False)

            '  As long as this application is running, the registered remote
            '  objects will be accessible.
            Console.Clear()
            Console.WriteLine("Press Enter to shut down the host.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace