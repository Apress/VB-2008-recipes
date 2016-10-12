Imports System
Imports System.Collections.Generic
Namespace Apress.VisualBasicRecipes.Chapter14

    Public Class Newspaper
        Implements IComparable(Of Newspaper)

        Private _name As String
        Private _circulation As Integer
        '  Simple Newspaper constructor.
        Public Sub New(ByVal name As String, ByVal circulation As Integer)

            _name = name
            _circulation = circulation

        End Sub
        '  Declare a read-only property to access _name field.
        Public ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property
        '  Declare a read-only property to access _circulation field.
        Public ReadOnly Property Circulation() As String
            Get
                Return _circulation
            End Get
        End Property
        '  Declare a read-only property that returns an instance of the
        '  AscendingCirculationComparer.
        Public Shared ReadOnly Property CirculationSorter() As IComparer(Of Newspaper)
            Get
                Return New AscendingCirculationComparer
            End Get
        End Property
        '  Override Object.ToString.
        Public Overrides Function ToString() As String
            Return String.Format("{0}: Circulation = {1}", _name, _circulation)
        End Function
        '  Implementation of IComparable.CompareTo.  The generic definition
        '  of IComparable allows us to ensure that the argument provided
        '  must be a Newspaper object.  Comparison is based on a case-
        '  insensitive comparison of the Newspaper names.
        Public Function CompareTo(ByVal other As Newspaper) As Integer Implements System.IComparable(Of Newspaper).CompareTo

            '  IComparable dictates that an object is always considered
            '  greater than nothing.
            If other Is Nothing Then Return 1

            '  Short-circuit the case where the other Newspaper object is a 
            '  reference to this one.
            If other Is Me Then Return 0

            '  Calculate return value by performing a case-insesitive
            '  comparison of the Newspaper names.

            '  Because the Newspaper name is a string, the easiest approach
            '  is to reply on the comparison capabilities of the string
            '  class, which perform culture-sensitive string comparisons.
            Return String.Compare(Me.Name, other.Name, True)

        End Function

        Private Class AscendingCirculationComparer
            Implements IComparer(Of Newspaper)

            '  Implementation of IComparer.Compare.  The generic definition of
            '  IComparer allows us to ensure both arguments are Newspaper
            '  objects.
            Public Function Compare(ByVal x As Newspaper, ByVal y As Newspaper) As Integer Implements System.Collections.Generic.IComparer(Of Newspaper).Compare

                '  Handle logic for nothing reference as dictated by the
                '  IComparer interface.  Nothing is considered less than
                '  any other value.
                If x Is Nothing And y Is Nothing Then
                    Return 0
                ElseIf x Is Nothing Then
                    Return -1
                ElseIf y Is Nothing Then
                    Return 1
                End If

                '  Short-circuit condition where x and y are references.
                '  to the same object.
                If x Is y Then
                    Return 0
                End If

                '  Compare the circulation figures.  IComparer dicates that:
                '       return less than zero if x < y
                '       return zero if x = y
                '       return greater than zero if x > y
                '  This logic is easily implemented using integer arithmetic.
                Return x.Circulation - y.Circulation

            End Function

        End Class
    End Class
    '  A class to demonstrate the use of Newspaper.
    Public Class Recipe14_03

        Public Shared Sub Main()

            Dim newspapers As New List(Of Newspaper)

            newspapers.Add(New Newspaper("The Washington Post", 125780))
            newspapers.Add(New Newspaper("The Times", 55230))
            newspapers.Add(New Newspaper("The Sun", 88760))
            newspapers.Add(New Newspaper("The Herald", 5670))
            newspapers.Add(New Newspaper("The Gazette", 235950))

            Console.Clear()
            Console.WriteLine("Unsorted newspaper list:")

            For Each n As Newspaper In newspapers
                Console.WriteLine("  {0}", n)
            Next

            '  Sort the newspapers list using the object's implementation
            '  of IComparable.CompareTo.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Newspaper list sorted by name (default order):")
            newspapers.Sort()

            For Each n As Newspaper In newspapers
                Console.WriteLine("  {0}", n)
            Next

            '  Sort the newspapers list using the supplied IComparer object.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Newspaper list sorted by circulation:")
            newspapers.Sort(Newspaper.CirculationSorter)

            For Each n As Newspaper In newspapers
                Console.WriteLine("  {0}", n)
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class
End Namespace