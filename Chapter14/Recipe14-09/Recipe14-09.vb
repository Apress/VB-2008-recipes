Imports System
Namespace Apress.VisualBasicRecipes.Chapter14


    Public Class SingletonExample

        '  A shared member to hold a reference to the singleton instance.
        Private Shared m_Instance As SingletonExample

        '  A shared constructor to create the singleton instance.  Another
        '  alternative is to use lazy initialization in the Instance property.
        Shared Sub New()
            m_Instance = New SingletonExample
        End Sub
        '  A private constructor to stop code from creating additional
        '  instances of the singleton type.
        Private Sub New()
        End Sub
        '  A public property to provide access to the singleton instance.
        Public Shared ReadOnly Property Instance() As SingletonExample
            Get
                Return m_Instance
            End Get
        End Property
        '  Public methods that provide singleton functionality.
        Public Sub TestMethod1()
            Console.WriteLine("Test Method 1 ran.")
        End Sub
        Public Sub TestMethod2()
            Console.WriteLine("Test Method 2 ran.")
        End Sub

    End Class
    Public Class Recipe14_09

        Public Shared Sub Main()

            '  Obtain reference to a singleton and invoke methods.
            Dim s As SingletonExample = SingletonExample.Instance
            s.TestMethod1()

            '  Execute singleton functionality without a reference.
            SingletonExample.Instance.TestMethod2()

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
