Imports System

Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_08

        Public Shared Sub Main()

            '  Create a TimeSpan representing 2.5 days.
            Dim timespan1 As New TimeSpan(2, 12, 0, 0)

            '  Create a TimeSpan representing 4.5 days.
            Dim timespan2 As New TimeSpan(4, 12, 0, 0)

            '  Create a TimeSpan representing 1 week.
            Dim oneweek As TimeSpan = timespan1 + timespan2

            '  Create a DateTime with the current date and time.
            Dim now As DateTime = DateTime.Now

            '  Create a DateTime representing 1 week ago.
            Dim past As DateTime = now - oneweek

            '  Create a DateTime representing 1 week in the future.
            Dim future As DateTime = now + oneweek

            ' Create a DateTime representing the next day using
            '  the AddDays method.
            Dim tomorrow As DateTime = now.AddDays(1)

            '  Display the DateTime instances.
            Console.WriteLine("Now      : {0}", now)
            Console.WriteLine("Past     : {0}", past)
            Console.WriteLine("Future   : {0}", future)
            Console.WriteLine("Tomorrow : {0}", tomorrow)
            Console.WriteLine(Environment.NewLine)

            '  Create various DateTimeOffset objects using the same
            '  methods demonstrated above using the DateTime class.
            Dim nowOffset As DateTimeOffset = DateTimeOffset.Now
            Dim pastoffset As DateTimeOffset = nowOffset - oneweek
            Dim futureOffset As DateTimeOffset = nowOffset + oneweek
            Dim tomorrowoffset As DateTimeOffset = nowOffset.AddDays(1)

            '  Change the offset used by nowOffset to -8 (which is Pacific 
            '  Standard Time).
            Dim nowPST As DateTimeOffset = nowOffset.ToOffset(New TimeSpan(-8, 0, 0))

            '  Display the DateTimeOffset instances.
            Console.WriteLine("Now      (with offset) : {0}", nowOffset)
            Console.WriteLine("Past     (with offset) : {0}", pastoffset)
            Console.WriteLine("Future   (with offset) : {0}", futureOffset)
            Console.WriteLine("Tomorrow (with offset) : {0}", tomorrowoffset)
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Now      (with offset of -8) : {0}", nowPST)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace