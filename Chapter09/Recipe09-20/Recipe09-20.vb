Imports System
Imports System.Windows
Imports System.Windows.Controls
Namespace Apress.VisualBasicRecipes.Chapter09

    Class Recipe09_20
        Inherits System.Windows.Window

        Public Shared Sub Main()

            Dim app As New Application
            app.Run(New Recipe09_20)

        End Sub
        Public Sub New()

            Dim btn As New Button

            Title = "Recipe09-20"

            Width = 300
            Height = 300
            Left = SystemParameters.PrimaryScreenWidth / 2 - Width / 2
            Top = SystemParameters.PrimaryScreenHeight / 2 - Height / 2

            AddHandler btn.Click, AddressOf ButtonClick

            btn.Content = "Click To Close"
            btn.Width = 150
            btn.Height = 50
            btn.ToolTip = "Close this WPF form"

            Content = btn

        End Sub
        Private Sub ButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)

            Close()

        End Sub

    End Class


End Namespace