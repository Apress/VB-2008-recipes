Imports System
Namespace Apress.VisualBasicRecipes.Chapter14

    '  Implement the IDisposable interface in an
    '  example class.
    Public Class DisposeExample
        Implements IDisposable

        '  Private data member to signal if the object has already
        '  been disposed.
        Private isDisposed As Boolean = False
        '  Private data member that holds the handle to an unmanaged
        '  resource.
        Private resourceHandle As IntPtr

        '  Constructor.
        Public Sub New()

            '  Constructor code obtains reference to an unmanaged
            '  resource.
            resourceHandle = IntPtr.Zero

        End Sub
        '  Protected overload of the Dispose method.  The disposing argument
        '  signals whether the method is called by consume code (true), or by
        '  the garbage collector (false).  Note that this method is not part
        '  of the IDisposable interface because it has a different signature to
        '  the parameterless Dispose method.
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)

            '  Don't try to Dispose of the object twice.
            If Not Me.isDisposed Then

                '  Determine if consumer code or the garbage collector is
                '  calling.  Avoid referencing other managed objects during
                '  finalization.
                If disposing Then
                    '  Method called by consumer code.  Call the Dispose method
                    '  of any managed data members that implement the IDisposable
                    '  interface.
                    '  ...
                End If

                '  Whether called by consume code or the garbage collector,
                '  free all unmanaged resources and set the value of managed
                '  data members to nothing.  In the case of an inherited type,
                '  call base.Dispose(disposing).
            End If

            '  Signal that this object has been disposed.
            Me.isDisposed = True
        End Sub
        '  Public implementation of the IDisposable.Dispose method, called
        '  by the consumer of the object in order to free unmanaged resources.
        Public Sub Dispose() Implements IDisposable.Dispose

            '  Call the protected Dispose overload and pass a value of "True"
            '  to indicate that Dispose is being called by consumer code, not
            '  by the garbage collector.
            Dispose(True)

            '  Because the Dispose method performs all necessary cleanup,
            '  ensure the garbage collector does not call the class destructor.
            GC.SuppressFinalize(Me)

        End Sub
        '  Destructor / Finalizer.  Because Dispose calls GC.SuppressFinalize,
        '  this method is called by the garbage collection process only if
        '  the consumer of the object does not call Dispose as it should.
        Protected Overrides Sub Finalize()

            '  Call the Dispose method as opposed to duplicating the code to
            '  clean up any unmanaged resources.  use the protected Dispose
            '  overload and pass a value of "False" to indicate that Dispose is
            '  being called during the garbage collection process, not by the
            '  consumer code.
            Dispose(False)

        End Sub
        '  Before executing any functionality, ensure that Dispose had not
        '  already been executed on the object.
        Public Sub SomeMethod()

            '  Throw an exception if the object has already been disposed.
            If isDisposed Then
                Throw New ObjectDisposedException("DisposeExample")
            End If

            '  Execute method functionality.
            '  ...

        End Sub
    End Class
    '  A class to demonstrate the use of DisposeExample.
    Public Class Recipe14_05

        Public Shared Sub Main()

            '  The using statement ensures the Dispose method is called
            '  even if an exception occurrs.
            Using d As New DisposeExample
                '  Do something with d.
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace
