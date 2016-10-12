Imports System
Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class Recipe03_02

        Public Shared Sub Main()

            '  Instantiate an AppDomainSetup object.
            Dim setupInfo As New AppDomainSetup

            '  Configure the application domain setup information.
            setupInfo.ApplicationBase = "C:\MyRootDirectory"
            setupInfo.ConfigurationFile = "MyApp.config"
            setupInfo.PrivateBinPath = "bin;plugins;external"

            '  Create a new application domain passing null as the evidence
            '  argument. Remember to save a refernce to the new AppDomain as
            '  this cannot be retrieved any other way.
            Dim newDomain As AppDomain = AppDomain.CreateDomain("My New AppDomain", Nothing, setupInfo)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
