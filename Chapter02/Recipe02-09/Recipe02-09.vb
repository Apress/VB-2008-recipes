Imports System
Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_09

        Public Shared Sub Main()

            '  Create a TimeZoneInfo object for the local time zone.
            Dim localTimeZone As TimeZoneInfo = TimeZoneInfo.Local

            '  Create a TimeZoneInfo object for Coordinated Universal
            '  Time (UTC).
            Dim utcTimeZone As TimeZoneInfo = TimeZoneInfo.Utc

            '  Create a TimeZoneInfo object for Pacific Standard Time (PST).
            Dim pstTimeZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")

            '  Create a DateTimeOffset that represents the current time.
            Dim currentTime As DateTimeOffset = DateTimeOffset.Now

            '  Display the local time and the local time zone.
            If localTimeZone.IsDaylightSavingTime(currentTime) Then
                Console.WriteLine("Current time in the local time zone ({0}):", localTimeZone.DaylightName)
            Else
                Console.WriteLine("Current time in the local time zone ({0})", localTimeZone.StandardName)
            End If
            Console.WriteLine("  {0}", currentTime.ToString())
            Console.WriteLine(Environment.NewLine)

            '  Display the results of converting the current local time
            '  to Coordinated Universal Time (UTC).
            If utcTimeZone.IsDaylightSavingTime(currentTime) Then
                Console.WriteLine("Current time in {0}:", utcTimeZone.DaylightName)
            Else
                Console.WriteLine("Current time in {0}:", utcTimeZone.StandardName)
            End If
            Console.WriteLine("  {0}", TimeZoneInfo.ConvertTime(currentTime, utcTimeZone))
            Console.WriteLine(Environment.NewLine)

            '  Create a DateTimeOffset object that represents the current local time
            '  converted to the Pacific Stanard Time time zone.
            Dim pstDTO As DateTimeOffset = TimeZoneInfo.ConvertTime(currentTime, pstTimeZone)

            '  Display the results of the conversion.
            If pstTimeZone.IsDaylightSavingTime(currentTime) Then
                Console.WriteLine("Current time in {0}:", pstTimeZone.DaylightName)
            Else
                Console.WriteLine("Current time in {0}:", pstTimeZone.StandardName)
            End If
            Console.WriteLine("  {0}", pstDTO.ToString())

            '  Display the previous results converted to Coordinated Universal Time (UTC).
            Console.WriteLine("  {0} (Converted to UTC)", TimeZoneInfo.ConvertTimeToUtc(pstDTO.DateTime, pstTimeZone))
            Console.WriteLine(Environment.NewLine)

            '  Create a DateTimeOffset that represents the current local time
            '  converted to Mountatin Standard Time using the 
            '  ConvertTimeBySystemTimeZoneId method.  This conversion works
            '  but it is best to create an actual TimeZoneInfo object so
            '  you have access to determine if it is daylight savings time or not.
            Dim mstDTO As DateTimeOffset = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, "Mountain Standard Time")

            '  Display the results of the conversion
            Console.WriteLine("Current time in Mountain Standard Time:")
            Console.WriteLine("  {0}", mstDTO.ToString())
            Console.WriteLine(Environment.NewLine)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
