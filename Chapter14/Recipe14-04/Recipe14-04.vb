Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Namespace Apress.VisualBasicRecipes.Chapter14

    '  The TeamMember class represents an individual team member.
    Public Class TeamMember

        Public Name As String
        Public Title As String

        '  Simple TeamMember constructor.
        Public Sub New(ByVal _name As String, ByVal _title As String)

            Me.Name = _name
            Me.Title = _title

        End Sub
        '  Returns a string representation of the TeamMember.
        Public Overrides Function ToString() As String
            Return String.Format("{0} ({1})", Name, Title)
        End Function

    End Class
    '  Team class represents a collection of TeamMember objects.
    '  It Implements the IEnumerable interface to support enumerating
    '  TeamMember objects.
    Public Class Team
        Implements IEnumerable

        '  A delegate that specifies the signature that all team change 
        '  event handler methods must implement.
        Public Delegate Sub TeamChangedEventHandler(ByVal source As Team, ByVal e As EventArgs)
        '  A List to contain the TeamMember objects.
        Private teamMembers As List(Of TeamMember)
        '  The event used to notify that the Team has changed.
        Public Event TeamChange As TeamChangedEventHandler
        '  Team constructor.
        Public Sub New()
            teamMembers = New List(Of TeamMember)
        End Sub
        '  Implement the IEnumerable.GetEnumerator method.
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return New TeamMemberEnumerator(Me)
        End Function
        '  Adds a TeamMember object to the Team.
        Public Sub AddMember(ByVal member As TeamMember)

            teamMembers.Add(member)

            '  Notify listeners that the list has changed.
            RaiseEvent TeamChange(Me, EventArgs.Empty)

        End Sub
        '  TeamMemberEnumerator is a private nested class that provides
        '  the functionality to enumerate the TeamMembers contained in
        '  a Team collection.  As a nested class, TeamMemberEnumerator
        '  has access to the private members of the Team class.
        Private Class TeamMemberEnumerator
            Implements IEnumerator

            '  The Team that this object is enumerating.
            Private sourceTeam As Team
            '  Boolean to indicate whether underlying Team has changed
            '  and so is invalid for further enumeration.
            Private teamInvalid As Boolean = False
            '  Integer to identify the current TeamMember.  Provides
            '  the index of the TeamMember in the underlying List
            '  used by the Team colelction.  Initialize to -1, which is
            '  the index prior to the first element.
            Private currentMember As Integer = -1
            '  The constructor takes a reference to the Team that is 
            '  the source of the enumerated data.
            Friend Sub New(ByVal _team As Team)

                Me.sourceTeam = _team

                '  Register with sourceTeam for change notifications.
                AddHandler Me.sourceTeam.TeamChange, AddressOf Me.TeamChange

            End Sub
            '  Implement the IEnumerator.Current property.
            Public ReadOnly Property Current() As Object Implements System.Collections.IEnumerator.Current
                Get
                    '  If the TeamMemberEnumerator is positioned before
                    '  the first element or after the last element, then
                    '  throw an exception.
                    If currentMember = -1 Or currentMember > (sourceTeam.teamMembers.Count - 1) Then
                        Throw New InvalidOperationException
                    End If

                    '  Otherwise, return the current TeamMember.
                    Return sourceTeam.teamMembers(currentMember)

                End Get
            End Property
            '  Implement the IEnumerator.MoveNext method.
            Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext

                '  If underlying Team is invalid, throw exception.
                If teamInvalid Then
                    Throw New InvalidOperationException("Team modified")
                End If

                '  Otherwise, progress to the next TeamMember.
                currentMember += 1

                '  Return false if we have moved past the last TeamMember.
                If currentMember > (sourceTeam.teamMembers.Count - 1) Then
                    Return False
                Else
                    Return True
                End If

            End Function
            '  Implement the IEnumerator.Reset method.  This method
            '  resets the position of the TeamMemberEnumerator to 
            '  the beginning of the TeamMembers collection.
            Public Sub Reset() Implements System.Collections.IEnumerator.Reset

                '  If underlying Team is invalid, throw exception.
                If teamInvalid Then
                    Throw New InvalidOperationException("Team modified")
                End If

                '  Move the currentMember pointer back to the index
                '  preceding the first element.
                currentMember = -1

            End Sub
            '  An event handler to handle notification that the underlying
            '  Team collection has changed.
            Friend Sub TeamChange(ByVal source As Team, ByVal e As EventArgs)

                '  Signal that the underlying Team is now invalid.
                teamInvalid = True

            End Sub

        End Class
    End Class
    '  A class to demonstrate the use of Team.
    Public Class Recipe14_04

        Public Shared Sub Main()

            '  Create a new Team.
            Dim newTeam As New Team

            newTeam.AddMember(New TeamMember("Leah", "Biologist"))
            newTeam.AddMember(New TeamMember("Romi", "Actress"))
            newTeam.AddMember(New TeamMember("Gavin", "Quantum Physicist"))

            '  Enumerate the Team.
            Console.Clear()
            Console.WriteLine("Enumerate with a for each loop:")

            For Each member As TeamMember In newTeam
                Console.WriteLine(member.ToString)
            Next

            '  Enumerate using a while loop.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Enumerate with while loop:")

            Dim e As IEnumerator = newTeam.GetEnumerator

            While e.MoveNext
                Console.WriteLine(e.Current)
            End While

            '  Enumerate the Team and try to add a Team Member.
            '  Since adding a member will invalidate the collection,
            '  the MoveNext method, of the TeamMemberEnumerator class,
            '  will throw an exception.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Modify while enumerating:")

            For Each member As TeamMember In newTeam
                Console.WriteLine(member.ToString)
                newTeam.AddMember(New TeamMember("Joed", "Linguist"))
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
