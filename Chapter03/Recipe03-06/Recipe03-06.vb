Imports System
Namespace Apress.VisualBasicRecipes.Chapter03

    '  Declare a class that is passed by value.
    <Serializable()> _
    Public Class Recipe03_06MBV

        Public ReadOnly Property HomeAppDomain() As String
            Get
                Return AppDomain.CurrentDomain.FriendlyName
            End Get
        End Property

    End Class
    '  Declare a class that is passed by reference.
    Public Class Recipe03_06MBR
        Inherits MarshalByRefObject

        Public ReadOnly Property HomeAppDomain() As String
            Get
                Return AppDomain.CurrentDomain.FriendlyName
            End Get
        End Property

    End Class
    Public Class Recipe03_06

        Public Shared Sub Main(ByVal args As String())

            '  Create a new application domain.
            Dim newDomain As AppDomain = AppDomain.CreateDomain("My New AppDomain")

            '  Instantiate an MBV object in the new application domain.
            Dim mbvObject As Recipe03_06MBV = CType(newDomain.CreateInstanceFromAndUnwrap("Recipe03-06.exe", "Apress.VisualBasicRecipes.Chapter03.Recipe03_06MBV"), Recipe03_06MBV)

            '  Instantiate an MBR object in the new application domain.
            Dim mbrObject As Recipe03_06MBR = CType(newDomain.CreateInstanceFromAndUnwrap("Recipe03-06.exe", "Apress.VisualBasicRecipes.Chapter03.Recipe03_06MBR"), Recipe03_06MBR)

            '  Display the name of the application domain in which each of
            '  the objects is located.
            Console.WriteLine("Main AppDomain = {0}", AppDomain.CurrentDomain.FriendlyName)
            Console.WriteLine("AppDomain of MBV object = {0}", mbvObject.HomeAppDomain)
            Console.WriteLine("AppDomain of MBR object = {0}", mbrObject.HomeAppDomain)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
