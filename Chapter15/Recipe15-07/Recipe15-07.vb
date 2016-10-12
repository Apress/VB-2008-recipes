Imports System.Configuration.Install
Imports System.ServiceProcess
Imports System.ComponentModel
Namespace Apress.VisualBasicRecipes.Chapter15

    <RunInstaller(True)> _
    Public Class Recipe15_07
        Inherits Installer

        Public Sub New()

            '  Instantiate and configure a ServiceProcessInstaller.
            Dim ServiceExampleProcess As New ServiceProcessInstaller
            ServiceExampleProcess.Account = ServiceAccount.LocalSystem

            '  Instantiate and configure a ServiceInstaller.
            Dim ServiceExampleInstaller As New ServiceInstaller
            ServiceExampleInstaller.DisplayName = "Visual Basic 2008 Recipes Service Example"
            ServiceExampleInstaller.ServiceName = "Recipe 15_06 Service"
            ServiceExampleInstaller.StartType = ServiceStartMode.Automatic

            '  Add both the ServiceProcessInstaller and ServiceInstaller to
            '  the installers collections, which is inherited from the
            '  Installer base class.
            Installers.Add(ServiceExampleInstaller)
            Installers.Add(ServiceExampleProcess)

        End Sub

    End Class
End Namespace
