Imports System
Namespace Apress.VisualBasicRecipes.Chapter14

    Public Class Person
        Implements IFormattable

        '  Private members to hold the person's title and name details.
        Private title As String
        Private names As String()
        '  Constructor used to set the person's title and names.
        Public Sub New(ByVal _title As String, ByVal ParamArray _names As String())

            Me.title = _title
            Me.names = _names

        End Sub
        '  Override the Object.ToString method to return the person's
        '  name using the general format.
        Public Overrides Function ToString() As String
            Return ToString("G", Nothing)
        End Function
        '  Implementation of the IFormattable.ToString method to return the
        '  person's name in different forms based on the format string
        '  provided.
        Public Overloads Function ToString(ByVal format As String, ByVal formatProvider As System.IFormatProvider) As String Implements System.IFormattable.ToString

            Dim result As String = Nothing

            '  Use the general format if none is specified.
            If format Is Nothing Then format = "G"

            '  The contents of the format string determine the format of the
            '  name returned.
            Select Case format.ToUpper()(0)
                Case "S"
                    '  Use short form - first initial and surname if a surname
                    '  was supplied.
                    If names.Length > 1 Then
                        result = names(0)(0) & ". " & names(names.Length - 1)
                    Else
                        result = names(0)
                    End If
                Case "P"
                    '  Use polite form - title, initials, and surname.
                    '  Add the person's title to the result.
                    If title IsNot Nothing And Not title.Length = 0 Then
                        result = title & ". "
                    End If

                    '  Add the person's initials and surname.
                    For count As Integer = 0 To names.Length - 1

                        If Not count = (names.Length - 1) Then
                            result += names(count)(0) & ". "
                        Else
                            result += names(count)
                        End If

                    Next
                Case "I"
                    '  Use informal form - first name only.
                    result = names(0)
                Case Else
                    '  Use general.default form - first name and surname (if
                    '  a surname is supplied).
                    If names.Length > 1 Then
                        result = names(0) & " " & names(names.Length - 1)
                    Else
                        result = names(0)
                    End If
            End Select

            Return result

        End Function
        '  A class to demonstrate the use of Person.
        Public Class Recipe14_06

            Public Shared Sub Main()
                '  Create a Person object representing a man with the name
                '  Dr. Gaius Baltar.
                Dim newPerson As New Person("Dr", "Gaius", "Baltar")

                '  Display the person's name using a variety of format strings.
                Console.WriteLine("Dear {0:G}", newPerson)
                Console.WriteLine("Dear {0:P}", newPerson)
                Console.WriteLine("Dear {0:I},", newPerson)
                Console.WriteLine("Dear {0}", newPerson)
                Console.WriteLine("Dear {0:S},", newPerson)

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete.  Press Enter.")
                Console.ReadLine()

            End Sub

        End Class

    End Class

End Namespace