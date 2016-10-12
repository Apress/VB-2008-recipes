Imports System
Namespace Apress.VisualBasicRecipes.Chapter03

    <AttributeUsage(AttributeTargets.Class Or AttributeTargets.Assembly, AllowMultiple:=True, Inherited:=True)> _
    Public Class AuthorAttribute
        Inherits System.Attribute

        Private m_Company As String   '  Creator's company
        Private m_Name As String      '  Creator's name

        '  Declare a public constructor.
        Public Sub New(ByVal name As String)
            m_Name = name
            m_Company = ""
        End Sub
        '  Declare a property to get/set the company field.
        Public Property Company() As String
            Get
                Return m_Company
            End Get
            Set(ByVal value As String)
                m_Company = value
            End Set
        End Property
        '  Declare a property to get the internal field.
        Public ReadOnly Property Name() As String
            Get
                Return m_Name
            End Get
        End Property

    End Class

End Namespace
