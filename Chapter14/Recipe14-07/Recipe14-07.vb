Imports System
Imports System.Runtime.Serialization
Namespace Apress.VisualBasicRecipes.Chapter14

    '  Mark CustomException as Serializable.
    <Serializable()> _
    Public NotInheritable Class CustomException
        Inherits Exception

        '  Custom data members for CustomException.
        Private m_StringInfo As String
        Private m_BooleanInfo As Boolean

        '  Three standard constructors that simply call the base
        '  class cosntructor or System.Exception.
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
        Public Sub New(ByVal message As String, ByVal inner As Exception)
            MyBase.New(message, inner)
        End Sub

        '  The deserialization constructor required by the ISerialization
        '  interface.  Because CustomException is NotInheritable, this constructore
        '  is private.  If CustomException were not NotInheritable, this constructor
        '  should be declared as protected so that derived classes can call
        '  it during deserialization.
        Private Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context)

            '  Deserialize each custom data member.
            m_StringInfo = info.GetString("StringInfo")
            m_BooleanInfo = info.GetBoolean("BooleanInfo")

        End Sub
        '  Additional constructors to allow code to set the custom data
        '  members.
        Public Sub New(ByVal _message As String, ByVal _StringInfo As String, ByVal _BooleanInfo As Boolean)
            MyBase.New(_message)

            m_StringInfo = _StringInfo
            m_BooleanInfo = _BooleanInfo

        End Sub
        Public Sub New(ByVal _message As String, ByVal inner As Exception, ByVal _stringinfo As String, ByVal _booleanInfo As Boolean)
            MyBase.New(_message, inner)

            m_StringInfo = _stringinfo
            m_BooleanInfo = _booleanInfo

        End Sub
        '  Read-only properties that provide access to the custom data members.
        Public ReadOnly Property StringInfo() As String
            Get
                Return m_StringInfo
            End Get
        End Property
        Public ReadOnly Property BooleanInfo() As Boolean
            Get
                Return m_BooleanInfo
            End Get
        End Property
        '  The GetObjectData method (declared in the ISerializable interface)
        '  is used during serialization of CustomException.  Because 
        '  CustomException declares custom data members, it must override
        '  the base class implementation of GetObjectData.
        Public Overrides Sub GetObjectData(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)

            '  Serialize the csutom data members.
            info.AddValue("StringInfo", m_StringInfo)
            info.AddValue("BooleanInfo", m_BooleanInfo)

            '  Call the base class to serialize its members.
            MyBase.GetObjectData(info, context)

        End Sub
        '  Override the base class Message property to include the custom data
        '  members.
        Public Overrides ReadOnly Property Message() As String
            Get
                Dim msg As String = MyBase.Message

                If StringInfo IsNot Nothing Then
                    msg += Environment.NewLine & StringInfo & " = " & BooleanInfo
                End If

                Return msg
            End Get
        End Property

    End Class
    '  A class to demonstarte the use of CustomException.
    Public Class Recipe14_07

        Public Shared Sub Main()

            Try
                '  Create and throw a CustomException object.
                Throw New CustomException("Some error", "SomeCustomMessage", True)
            Catch ex As CustomException
                Console.WriteLine(ex.Message)
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
    End Class
End Namespace