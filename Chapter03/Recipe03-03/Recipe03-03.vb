Imports System
Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class Recipe03_03

        Public Shared Sub Main(ByVal args As String())

            '  For the purpose of this example, if this assembly is executing
            '  in an AppDomain with the friendly name "NewAppDomain", do not
            '  create a new AppDomain.  This avoids an infinite loop of
            '  AppDomain creation.
            If Not AppDomain.CurrentDomain.FriendlyName = "NewAppDomain" Then
                '  Create a new new application domain.
                Dim domain As AppDomain = AppDomain.CreateDomain("NewAppDomain")

                '  Excute this assembly in the new application domain and
                '  pass the array of command-line arguments.
                domain.ExecuteAssembly("Recipe03-03.exe", Nothing, args)

            End If

            '  Display the command-line arguments to the screen prefixed with
            '  the friendly name of the AppDomain.
            For Each s As String In args
                Console.WriteLine(AppDomain.CurrentDomain.FriendlyName + " : " + s)
            Next

            '  Wait to continue.
            If Not AppDomain.CurrentDomain.FriendlyName = "NewAppDomain" Then
                Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
                Console.ReadLine()
            End If

        End Sub

    End Class

End Namespace