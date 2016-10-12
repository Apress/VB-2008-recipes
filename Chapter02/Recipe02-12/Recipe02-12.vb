Imports System
Imports System.Collections
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_12

        Public Shared Sub Main()

            '  Create sample data.  For simplicity, the data consists of an
            '  array of  anonymous types that contain three properties:
            '  Name (a String), CallSign (a String) and Age (an Integer).
            Dim galactica() = { _
                               New With {.Name = "William Adama", _
                                         .CallSign = "Husker", _
                                         .Age = 65}, _
                               New With {.Name = "Saul Tigh", _
                                         .CallSign = Nothing, _
                                         .Age = 83}, _
                               New With {.Name = "Lee Adama", _
                                         .CallSign = "Apollo", _
                                         .Age = 30}, _
                               New With {.Name = "Kara Thrace", _
                                         .CallSign = "Starbuck", _
                                         .Age = 28}, _
                               New With {.Name = "Gaius Baltar", _
                                         .CallSign = Nothing, _
                                         .Age = 42}}

            '  Variables used to store results of Any and All methods.
            Dim anyResult As Boolean
            Dim allResult As Boolean

            '  Display the contents of the galactica array.
            Console.WriteLine("Galactica Crew:")
            For Each crewMember In galactica
                Console.WriteLine("  {0}", crewMember.Name)
            Next
            Console.WriteLine(Environment.NewLine)

            '  Determine if the galactica array has any data.
            anyResult = galactica.Any

            '  Display the results of the previous test.
            Console.WriteLine("Does the array contain any data:  ")
            If anyResult Then
                Console.Write("Yes")
            Else
                Console.Write("No")
            End If
            Console.WriteLine(Environment.NewLine)

            '  Determine if any members have nothing set for the
            '  CallSign property, using the Any method.
            anyResult = galactica.Any(Function(crewMember) crewMember.callsign Is Nothing)

            '  Display the results of the previous test.
            Console.WriteLine("Do any crew members NOT have a callsign:  ")
            If anyResult Then
                Console.Write("Yes")
            Else
                Console.Write("No")
            End If
            Console.WriteLine(Environment.NewLine)

            '  Determine if all members of the array have an Age property
            '  greater than 40, using the All method.
            allResult = galactica.All(Function(crewMember) crewMember.Age > 40)

            '  Display the results of the previous test.
            Console.WriteLine("Are all of the crew members over 40:  ")
            If allResult Then
                Console.Write("Yes")
            Else
                Console.Write("No")
            End If
            Console.WriteLine(Environment.NewLine)

            '  Display the contents of the galactica array in reversed.
            Console.WriteLine("Galactica Crew (Reverse Order):")
            For Each crewMember In galactica.Reverse
                Console.WriteLine("  {0}", crewMember.Name)
            Next

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

            '  For the record, references to BattleStar Gallactica
            '  are courtesy of the SciFi channel.

        End Sub

    End Class

End Namespace