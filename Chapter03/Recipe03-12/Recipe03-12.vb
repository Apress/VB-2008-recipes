Imports System
Imports System.Text
Imports System.Reflection
Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class Recipe03_12

        Public Shared Function CreateStringBuilder() As StringBuilder

            '  Obtain the Type for the StringBuilder class.
            Dim type As Type = GetType(StringBuilder)

            '  Create a Type() containing Type instances for each
            '  of the constructor arguments - astring and an integer.
            Dim argTypes As Type() = New Type() {GetType(System.String), GetType(System.Int32)}

            '  Obtain the ConstructorInfo object.
            Dim cInfo As ConstructorInfo = type.GetConstructor(argTypes)

            '  Create an object() containing the constructor arguments.
            Dim argVals As Object() = New Object() {"Some string", 30}

            '  Create the object and cast it to a StringBuilder.
            Dim sb As StringBuilder = CType(cInfo.Invoke(argVals), StringBuilder)

            Return sb

        End Function

    End Class
End Namespace
Namespace Apress.VisualBasicRecipes.Chapter03

    '  A common interface that all plug-ins must implement.
    Public Interface IPlugin

        Property Description() As String
        Sub Start()
        Sub [Stop]()

    End Interface
    '  An abstract base class from which all plug-ins must derive.
    Public MustInherit Class AbstractPlugIn
        Implements IPlugin

        '  Hold a description for the plug-in instance.
        Private m_description As String = ""

        '  Sealed property to get the plug-in description.
        Public Property Description() As String Implements IPlugin.Description
            Get
                Return m_description
            End Get
            Set(ByVal value As String)
                m_description = value
            End Set
        End Property

        '  Declare the members of the IPlugin interface as abstract.
        Public MustOverride Sub Start() Implements IPlugin.Start
        Public MustOverride Sub [Stop]() Implements IPlugin.Stop

    End Class
    '  A simple IPlugin implementation to demonstrate the PluginFactory class.
    Public Class SimplePlugin
        Inherits AbstractPlugIn

        '  Implement Start method.
        Public Overrides Sub Start()
            Console.WriteLine(Description & ": Starting...")
        End Sub
        '  Implement Stop method.
        Public Overrides Sub [Stop]()
            Console.WriteLine(Description & ": Stopping...")
        End Sub

    End Class
    '  A factory to instantiate instances of IPlugin.
    NotInheritable Class PluginFactory

        Public Shared Function CreatePlugin(ByVal assembly As String, ByVal pluginName As String, ByVal description As String) As IPlugin

            Console.WriteLine("Attempting to load plugin")

            '  Obtain the Type for the specified plug-in.
            Dim pluginType As Type = Type.GetType(pluginName & ", " & assembly)

            '  Obtain the ConstructorInfo object.
            Dim cInfo As ConstructorInfo = pluginType.GetConstructor(Type.EmptyTypes)

            '  Create the object and cast it to StringBuilder.
            Dim plugin As IPlugin = TryCast(cInfo.Invoke(Nothing), IPlugin)

            '  Configure the new IPlugin.
            plugin.Description = description

            Console.WriteLine("Plugin '{0}' [{1}] succesfully loaded.", assembly, plugin.Description)
            Console.WriteLine(Environment.NewLine)

            Return plugin

        End Function
        Public Shared Sub Main(ByVal args As String())

            '  Instantiate a new IPlugin using the PluginFactory.
            Dim plugin As IPlugin = PluginFactory.CreatePlugin("Recipe03-12", "Apress.VisualBasicRecipes.Chapter03.SimplePlugin", "A Simple Plugin")

            plugin.Start()
            plugin.Stop()

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
