Imports System
Imports System.Collections
Namespace Apress.VisualBasicRecipes.Chapter15

    Public Class Recipe15_02

        Public Shared Sub Main()

            '  Retrieve a named environment variable.
            Console.WriteLine("Path = " & Environment.GetEnvironmentVariable("Path"))
            Console.WriteLine(Environment.NewLine)

            '  Substitute the value of named environment variables.
            Console.WriteLine(Environment.ExpandEnvironmentVariables("The Path on %computername% is %path%"))

            '  Retrieve all environment variables targeted at the process and
            '  display the values of all that begin with the letter U.
            Dim vars As IDictionary = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process)

            For Each s As String In vars.Keys
                If s.ToUpper.StartsWith("U") Then
                    Console.WriteLine(s & " = " & vars(s))
                End If
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace