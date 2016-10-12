Imports System
Imports System.Reflection
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Namespace Apress.VisualBasicRecipes.Chapter03

    '  A common interface that all plug-ins must implement.
    Public Interface IPlugin

        Sub Start()
        Sub [Stop]()

    End Interface
    '  A simple IPlugin implementation to demonstrate the PluginManager
    '  controller class.
    Public Class SimplePlugin
        Implements IPlugin

        Public Sub Start() Implements IPlugin.Start
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName & ": SimplePlugin starting...")
        End Sub
        Public Sub [Stop]() Implements IPlugin.Stop
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName & ": SimplePlugin stopping...")
        End Sub

    End Class
    '  The controller class, which manages the loading and manipulation
    '  of plug-ins in its application domain.
    Public Class PluginManager
        Inherits MarshalByRefObject

        '  A Dictionary to hold keyed references to IPlugin instances.
        Private plugins As New Dictionary(Of String, IPlugin)

        '  Default constructor.
        Public Sub New()

        End Sub
        '  Constructor that loads a set of specified plug-ins on creation.
        Public Sub New(ByVal pluginList As NameValueCollection)

            '  Load each of the specified plug-ins.
            For Each plugin As String In pluginList.Keys
                Me.LoadPlugin(pluginList(plugin), plugin)
            Next

        End Sub
        '  Load the specified assembly and instantiate the specified
        '  IPlugin implementation from that assembly.
        Public Function LoadPlugin(ByVal assemblyName As String, ByVal pluginName As String)

            Try
                '  Load the named private assembly.
                Dim assembly As Assembly = Reflection.Assembly.Load(assemblyName)

                '  Create the IPlugin instance, ignore case.
                Dim plugin As IPlugin = DirectCast(assembly.CreateInstance(pluginName, True), IPlugin)

                If Not plugin Is Nothing Then
                    '  Add new IPlugin to ListDictionary
                    plugins(pluginName) = plugin

                    Return True
                Else
                    Return False
                End If
            Catch
                '  Return false on all exceptions for the purpose of
                '  this example. Do not suppress exceptions like this
                '  in production code.
                Return False
            End Try

        End Function
        Public Sub StartPlugin(ByVal plugin As String)

            Try
                '  Extract the IPlugin from the Dictionary and call Start.
                plugins(plugin).Start()
            Catch
                '  Log or handle exceptions appropriately.
            End Try

        End Sub
        Public Sub StopPlugin(ByVal plugin As String)

            Try
                '  Extract the IPlugin from the Dictionary and call Stop.
                plugins(plugin).Stop()
            Catch
                '  Log or handle exceptions appropriately.
            End Try

        End Sub
        Public Function GetPluginList() As ArrayList

            '  Return an enumerable list of plug-in names.  Take the keys
            '  and place them in an ArrayList, which supports marshal-by-value.
            Return New ArrayList(plugins.Keys)

        End Function

    End Class
    Public Class Recipe03_07

        Public Shared Sub Main(ByVal args As String())

            '  Create a new application domain.
            Dim domain1 As AppDomain = AppDomain.CreateDomain("NewAppDomain1")

            '  Create a PluginManager in the new application domain using
            '  the default constructor.
            Dim manager1 As PluginManager = CType(domain1.CreateInstanceAndUnwrap("Recipe03-07", "Apress.VisualBasicRecipes.Chapter03.PluginManager"), PluginManager)

            '  Load a new plugin into NewAppDomain1
            manager1.LoadPlugin("Recipe03-07", "Apress.VisualBasicRecipes.Chapter03.SimplePlugin")

            '  Start and stop the plug-in NewAppDomain1.
            manager1.StartPlugin("Apress.VisualBasicRecipes.Chapter03.SimplePlugin")
            manager1.StopPlugin("Apress.VisualBasicRecipes.Chapter03.SimplePlugin")

            '  Create a new application domain.
            Dim domain2 As AppDomain = AppDomain.CreateDomain("NewAppDomain2")

            '  Create a ListDictionary containing a list of plug-ins to create.
            Dim pluginList As New NameValueCollection()
            pluginList("Apress.VisualBasicRecipes.Chapter03.SimplePlugin") = "Recipe03-07"

            '  Create a PluginManager in the new application domain and
            '  specify the default list of plug-ins to create.
            Dim manager2 As PluginManager = CType(domain1.CreateInstanceAndUnwrap("Recipe03-07", "Apress.VisualBasicRecipes.Chapter03.PluginManager", True, 0, Nothing, New Object() {pluginList}, Nothing, Nothing, Nothing), PluginManager)

            '  Display this list of plug-ins loaded into NewAppDomain2.
            Console.WriteLine("{0}Plugins in NewAppDomain2:", vbCrLf)

            For Each s As String In manager2.GetPluginList()
                Console.WriteLine(" - " & s)
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
