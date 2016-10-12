Imports System
Imports System.Data
Imports System.Runtime.Remoting
Namespace Apress.VisualBasicRecipes.Chapter03

    Public Class Recipe03_04

        '  A method to wrap a DataSet.
        Public Function WrapDataset(ByVal ds As DataSet) As ObjectHandle

            '  Wrap the DataSet.
            Dim objHandle As New ObjectHandle(ds)

            '  Return the wrapped DataSet.
            Return objHandle

        End Function
        '  A method to unwrap a DataSet.
        Public Function UnwrapDataset(ByVal handle As ObjectHandle) As DataSet

            '  Unwrap the DataSet.
            Dim ds As DataSet = CType(handle.Unwrap, DataSet)

            '  Return the DataSet.
            Return ds

        End Function

    End Class

End Namespace