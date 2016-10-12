Imports System

Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_07

        Public Shared Sub Main(ByVal args As String())

            '  1st January 1975 at  00:00:00
            Dim dt1 As DateTime = DateTime.Parse("Jan 1975")

            '  12th January 1975 at 18:19:00
            Dim dt2 As DateTime = DateTime.Parse("Sunday 12 January 1975 18:19:00")

            '  12th January 1975 at 00:00:00
            Dim dt3 As DateTime = DateTime.Parse("1,12,1975")

            '  12th January 1975 at 18:19:00
            Dim dt4 As DateTime = DateTime.Parse("1/12/1975 18:19:00")

            '  Current Date at 18:19 showing UTC offset for local time zone
            Dim dt5 As DateTimeOffset = DateTimeOffset.Parse("6:19 PM")

            '  Current Date at 18:19 showing an offset of -8 hours from UTC.
            Dim dt6 As DateTimeOffset = DateTimeOffset.Parse("6:19 PM -8")

            '  Date set to minvalue to be used later by TryParse
            Dim dt7 As DateTime = DateTime.MinValue

            '  Display the converted DateTime objects.
            Console.WriteLine(dt1)
            Console.WriteLine(dt2)
            Console.WriteLine(dt3)
            Console.WriteLine(dt4)
            Console.WriteLine(dt5)
            Console.WriteLine(dt6)

            '  Try to parse a non-datetime string.
            If Not DateTime.TryParse("This is an invalid date", dt7) Then
                Console.WriteLine("Unable to parse.")
            Else
                Console.WriteLine(dt7)
            End If

            '  Parse only strings containing LongTimePattern.
            Dim dt8 As DateTime = DateTime.ParseExact("6:19:00 PM", "h:mm:ss tt", Nothing)

            '  Parse only strings containing RFC1123Pattern.
            Dim dt9 As DateTime = DateTime.ParseExact("Sun, 12 Jan 1975 18:19:00 GMT", "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'", Nothing)

            '  Parse only strings containing MonthDayPattern.
            Dim dt10 As DateTime = DateTime.ParseExact("January 12", "MMMM dd", Nothing)

            '  Display the converted DateTime objects.
            Console.WriteLine(dt8)
            Console.WriteLine(dt9)
            Console.WriteLine(dt10)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
