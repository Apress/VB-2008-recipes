Imports System
Imports System.Text
Imports System.Collections.Generic
Namespace Apress.VisualBasicRecipes.Chapter14

    Public Class Employee
        Implements ICloneable

        Public Name As String
        Public Title As String
        Public Age As Integer
        '  Simple Employee constructor.
        Public Sub New(ByVal _name As String, ByVal _title As String, ByVal _age As Integer)

            Name = _name
            Title = _title
            Age = _age

        End Sub
        '  Create a clone using the Object.MemberwiseClone method because
        '  the Employee class contains only string and value types.
        Public Function Clone() As Object Implements System.ICloneable.Clone
            Return Me.MemberwiseClone
        End Function
        '  Returns a string representation of the Employee object.
        Public Overrides Function ToString() As String
            Return String.Format("{0} ({1}) - Age {2}", Name, Title, Age)
        End Function

    End Class
    Public Class Team
        Implements ICloneable

        '  A List to hold the Employee team members.
        Public TeamMembers As New List(Of Employee)
        Public Sub New()
        End Sub

        '  Override Object.ToString to return a string representation
        '  of the entire team.
        Public Overrides Function ToString() As String

            Dim str As New StringBuilder

            For Each e As Employee In TeamMembers
                str.AppendFormat("  {0}{1}", e, ControlChars.CrLf)
            Next

            Return str.ToString

        End Function
        '  Implementation of ICloneable.Clone.
        Public Function Clone() As Object Implements System.ICloneable.Clone

            '  Create a deep copy of the team
            Dim newTeam As New Team

            For Each e As Employee In Me.TeamMembers
                '  Clone the individual employee objects and
                '  add them to the List.
                newTeam.TeamMembers.Add(DirectCast(e.Clone, Employee))
            Next

            Return newTeam

        End Function

    End Class
    '  A class to demonstrate the use of Employee.
    Public Class Recipe14_02

        Public Shared Sub Main()

            '  Create the original team.
            Dim originalTeam As New Team
            originalTeam.TeamMembers.Add(New Employee("Kai", "Genius", 34))
            originalTeam.TeamMembers.Add(New Employee("Jeremy", "Jack-Of-All-Trades", 35))
            originalTeam.TeamMembers.Add(New Employee("Guy", "Developer", 25))

            '  Clone the original team.
            Dim clonedTeam As Team = DirectCast(originalTeam.Clone, Team)

            '  Display the original team.
            Console.WriteLine("Original Team:")
            Console.WriteLine(originalTeam)

            '  Display the cloned team.
            Console.WriteLine("Cloned Team:")
            Console.WriteLine(clonedTeam)

            '  Make change.
            Console.WriteLine("*** Make a change to original team ***")
            Console.WriteLine(Environment.NewLine)

            originalTeam.TeamMembers(0).Name = "Joed"
            originalTeam.TeamMembers(0).Title = "Manager"
            originalTeam.TeamMembers(0).Age = 30

            '  Display the original team.
            Console.WriteLine("Original Team:")
            Console.WriteLine(originalTeam)

            '  Display the cloned team.
            Console.WriteLine("Cloned Team:")
            Console.WriteLine(clonedTeam)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.Read()

        End Sub

    End Class
End Namespace