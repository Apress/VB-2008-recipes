Imports System
Imports System.Net
Imports System.Security.Permissions

'  Permission request for SocketPermission that allows the code to 
'  open a TCP connection to the specified host and port.
<Assembly: SocketPermission(SecurityAction.RequestMinimum, Access:="Connect", Host:="www.fabrikam.com", Port:="3538", Transport:="Tcp")> 

'  Permission request for the UnmanagedCode element of SecurityPermission,
'  which controls the code's ability to execute unmanaged code.
<Assembly: SecurityPermission(SecurityAction.RequestMinimum, UnmanagedCode:=True)> 

Namespace Apress.VisualBasicRecipes.Chapter12

    Public Class Recipe12_03

        Public Shared Sub Main()

            '  Do something

            '  Wait to continue.
            Console.Write("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class


End Namespace
