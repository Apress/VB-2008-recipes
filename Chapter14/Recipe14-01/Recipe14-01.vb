Imports System
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Namespace Apress.VisualBasicRecipes.Chapter14

    <Serializable()> _
    Public Class Employee
        Implements ISerializable

        Private m_Name As String
        Private m_Age As Integer
        Private m_Address As String

        '  Simple Employee constructor.
        Public Sub New(ByVal name As String, ByVal age As Integer, ByVal address As String)

            m_Name = name
            m_Age = age
            m_Address = address

        End Sub
        '  Constructor required to enable a formatter to deserialize an
        '  Employee object.  You should declare the constructor non-public
        '  to help ensure it is not called unneccessarily.
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)

            '  Extract the name and age of the Employee, which will always be
            '  present in the serialized data regardless of the value of the
            '  StreamingContext.
            m_Name = info.GetString("Name")
            m_Age = info.GetInt32("Age")

            '  Attempt to extract the Employee's address and fail gracefully
            '  if it is not available.
            Try
                m_Address = info.GetString("Address")
            Catch ex As SerializationException
                m_Address = Nothing
            End Try

        End Sub
        '  Public property to provide access to the employee's name.
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(ByVal Value As String)
                m_Name = Value
            End Set
        End Property
        '  Public property to provide access to the employee's age.
        Public Property Age() As Integer
            Get
                Return m_Age
            End Get
            Set(ByVal value As Integer)
                m_Age = value
            End Set
        End Property
        '  Public property to provide access to the employee's address.
        '  Uses lazy initialization to establish address because a
        '  deserialized object may not have an address value.
        Public Property Address() As String
            Get
                If m_Address Is Nothing Then
                    '  Load the address from persistenet storage.
                    '  In this case, set it to an empty string.
                    m_Address = String.Empty
                End If

                Return m_Address
            End Get
            Set(ByVal value As String)
                m_Address = value
            End Set
        End Property
        '  Declared by the ISerializable interface, the GetObjectData method
        '  provides the mechanism with which a formatter obtains the object
        '  data that it should serialize.
        Public Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData

            '  Always serialize the Employee's name and age.
            info.AddValue("Name", Name)
            info.AddValue("Age", Age)

            '  Don't serialize the Employee's address if the StreamingContext
            '  indicates that the serialized data is to be written to a file.
            If (context.State And StreamingContextStates.File) = 0 Then
                info.AddValue("Address", Address)
            End If

        End Sub
        '  Override Object.ToString to return a string representation of the
        '  Employee state.
        Public Overrides Function ToString() As String

            Dim str As New StringBuilder

            str.AppendFormat("Name: {0}{1}", Name, ControlChars.CrLf)
            str.AppendFormat("Age: {0}{1}", Age, ControlChars.CrLf)
            str.AppendFormat("Address: {0}{1}", Address, ControlChars.CrLf)

            Return str.ToString

        End Function

    End Class
    '  A class to demonstrate the use of Employee.
    Public Class Recipe14_01

        Public Shared Sub Main()

            '  Create an Employee object representing an employee named Aidan.
            Dim emp As New Employee("Aidan", 35, "Retroville")

            '  Display Employee object.
            Console.WriteLine(emp.ToString())

            '  Serialize the employee object specifying another application domain
            '  as the destination of the serialized data.  All data including the
            '  employee's address is serialized.
            Dim str As Stream = File.Create("Aidan.bin")
            Dim bf As New BinaryFormatter
            bf.Context = New StreamingContext(StreamingContextStates.CrossAppDomain)
            bf.Serialize(str, emp)
            str.Close()

            '  Deserialize and display the Employee object.
            str = File.OpenRead("Aidan.bin")
            bf = New BinaryFormatter
            emp = DirectCast(bf.Deserialize(str), Employee)
            str.Close()
            Console.WriteLine(emp.ToString())

            '  Serialize the Employee object specifying a file as the destination 
            '  of the serialized data.  In this case, the employees's address is not
            '  included in the serialized data.
            str = File.Create("Aidan.bin")
            bf = New BinaryFormatter
            bf.Context = New StreamingContext(StreamingContextStates.File)
            bf.Serialize(str, emp)
            str.Close()

            '  Deserialize and display the Employee.
            str = File.OpenRead("Aidan.bin")
            bf = New BinaryFormatter
            emp = DirectCast(bf.Deserialize(str), Employee)
            str.Close()
            Console.WriteLine(emp.ToString())

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace