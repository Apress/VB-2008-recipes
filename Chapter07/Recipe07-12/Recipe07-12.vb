Imports System
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_12

        Public Shared Sub Main()

            '  Create the employee roster.
            Dim roster = New EmployeeRoster(DateTime.Now)
            Dim employees = New Employee() _
                {New Employee With {.Id = 1, .Name = "Joed McCormick", _
                                    .Title = "Airline Pilot", _
                                    .HireDate = DateTime.Now.AddDays(-25), _
                                    .HourlyRate = 100.0}, _
                 New Employee With {.Id = 2, .Name = "Kai Nakamura", _
                                    .Title = "Super Genius", _
                                    .HireDate = DateTime.Now.AddYears(-10), _
                                    .HourlyRate = 999.99}, _
                 New Employee With {.Id = 3, .Name = "Romi Doshi", _
                                    .Title = "Actress", _
                                    .HireDate = DateTime.Now.AddMonths(-15), _
                                    .HourlyRate = 120.0}, _
                 New Employee With {.Id = 4, .Name = "Leah Clooney", _
                                    .Title = "Molecular Biologist", _
                                    .HireDate = DateTime.Now.AddMonths(-10), _
                                    .HourlyRate = 100.75}}

            roster.Employees = employees

            '  Serialize the order to a file.
            Dim serializer As New XmlSerializer(GetType(EmployeeRoster))
            Dim fs As New FileStream("EmployeeRoster.xml", FileMode.Create)

            serializer.Serialize(fs, roster)
            fs.Close()

            roster = Nothing

            '  Deserialize the order from the file.
            fs = New FileStream("EmployeeRoster.xml", FileMode.Open)
            roster = DirectCast(serializer.Deserialize(fs), EmployeeRoster)

            '  Serialize the order to the console window.
            serializer.Serialize(Console.Out, roster)
            Console.ReadLine()

        End Sub

    End Class
    <XmlRoot("EmployeeRoster")> _
    Public Class EmployeeRoster

        '  Use the date data type (and ignore the time portion
        '  in the serialized XML).
        <XmlElement(ElementName:="LastUpdated", datatype:="date")> _
        Public LastUpdated As DateTime

        '  Configure the name of the tag that holds all employees
        '  and the name of the employee tag itself.
        <XmlArray("Employees"), XmlArrayItem("Employee")> _
        Public Employees As Employee()
        Public Sub New()
        End Sub
        Public Sub New(ByVal update As DateTime)

            Me.LastUpdated = update

        End Sub

    End Class
    Public Class Employee

        <XmlElement("Name")> _
        Public Name As String = String.Empty

        <XmlElement("Title")> _
        Public Title As String = String.Empty

        <XmlElement(ElementName:="HireDate", datatype:="date")> _
        Public HireDate As DateTime = Date.MinValue

        <XmlElement("HourlyRate")> _
        Public HourlyRate As Decimal = 0

        <XmlAttribute(AttributeName:="id", DataType:="integer")> _
        Public Id As String = String.Empty
        Public Sub New()
        End Sub
        Public Sub New(ByVal employeName As String, ByVal employeeTitle As String, ByVal employeeHireDate As DateTime, ByVal employeeHourlyRate As Decimal)

            Me.Name = employeName
            Me.Title = employeeTitle
            Me.HireDate = employeeHireDate
            Me.HourlyRate = employeeHourlyRate

        End Sub

    End Class

End Namespace
