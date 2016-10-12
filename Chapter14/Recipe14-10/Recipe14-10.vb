Imports System
Namespace Apress.VisualBasicRecipes.Chapter14

    '  A delegate that specifies the signature that all temperature event
    '  handler methods must implement.
    Public Delegate Sub TemperatureChangedEventHandler(ByVal sender As Object, ByVal args As TemperatureChangedEventArgs)

    '  An event argument class that contains information about a temperature
    '  change event.  An instance of this class is passed with every event.
    <Serializable()> _
    Public Class TemperatureChangedEventArgs
        Inherits EventArgs

        '  Private data members contain the old and new temperature readings.
        Private ReadOnly m_OldTemperature, m_NewTemperature As Integer

        '  Constructor that takes the old and new temperature values.
        Public Sub New(ByVal oldTemp As Integer, ByVal newTemp As Integer)

            m_OldTemperature = oldTemp
            m_NewTemperature = newTemp

        End Sub
        '  Read-only properties provide access to the temperature values.
        Public ReadOnly Property OldTemperature()
            Get
                Return m_OldTemperature
            End Get
        End Property
        Public ReadOnly Property NewTemperature()
            Get
                Return m_NewTemperature
            End Get
        End Property

    End Class
    '  A thermostat observer that displays information about the change in
    '  temperature when a temperature change event occurrs.
    Public Class TemperatureChangeObserver

        '  A constructor that takes a reference to the Thermostat object that
        '  the TemperatureChangeObserver object should observe.
        Public Sub New(ByVal t As Thermostat)

            '  Add a handler for the TemperatureChanged event.
            AddHandler t.TemperatureChanged, AddressOf Me.TemperatureChange

        End Sub
        '  The method to handle temperature change events.
        Public Sub TemperatureChange(ByVal sender As Object, ByVal args As TemperatureChangedEventArgs)
            Console.WriteLine("ChangeObserver: Old={0}, New={1}, Change={2}", args.OldTemperature, args.NewTemperature, args.NewTemperature - args.OldTemperature)
        End Sub

    End Class
    '  A Thermostat observer that displays information about the average
    '  temperature when a temperature change event occurs.
    Public Class TemperatureAverageObserver

        '  Sum contains the running total of temperature readings.
        '  Count contains the number of temperature events received.
        Private sum As Integer = 0
        Private count As Integer = 0

        '  A constructor that takes a reference to the Thermostat object that
        '  the TemperatureAverageObserver object should observe.
        Public Sub New(ByVal T As Thermostat)
            '  Add a handler for the TemperatureChanged event.
            AddHandler T.TemperatureChanged, AddressOf Me.TemperatureChange
        End Sub
        '  The method to handle temperature change events.
        Public Sub TemperatureChange(ByVal sender As Object, ByVal args As TemperatureChangedEventArgs)

            count += 1
            sum += args.NewTemperature

            Console.WriteLine("AverageObserver: Average={0:F}", CDbl(sum) / CDbl(count))

        End Sub

    End Class
    '  A class that represents a Thermostat, which is the source of temperature
    '  change events.  In the Observer pattern, a Thermostat object is the
    '  Subject that Observers listen to for change notifications.
    Public Class Thermostat

        '  Private field to hold current temperature.
        Private m_Temperature As Integer = 0

        '  The event used to maintain a list of observer delegates and raise
        '  a temperature change event when a temperature change occurrs.
        Public Event TemperatureChanged As TemperatureChangedEventHandler
        '  A protected method used to raise the TemperatureChanged event.
        '  Because events can be triggered only from within the containing
        '  type, using a protected method to raise the event allows derived
        '  classes to provide customized behavior and still be able to raise
        '  the base class event.
        Protected Overridable Sub OnTemperatureChanged(ByVal args As TemperatureChangedEventArgs)

            '  Notify all observers.
            RaiseEvent TemperatureChanged(Me, args)

        End Sub
        '  Public property to get and set the current temperature.  The "set"
        '  side of the property is responsible for raising the temperature
        '  change event to notify all observers of a change in temperature.
        Public Property Temperature() As Integer
            Get
                Return m_Temperature
            End Get
            Set(ByVal value As Integer)
                '  Create a new event argument object containing the old and
                '  new temperatures.
                Dim args As New TemperatureChangedEventArgs(m_Temperature, value)

                '  Update the current temperature.
                m_Temperature = value

                '  Raise the temperature change event.
                OnTemperatureChanged(args)

            End Set
        End Property
    End Class
    '  A class to demonstrate the use of the Observer pattern.
    Public Class Recipe14_10

        Public Shared Sub Main()

            '  Create a Thermostat instance.
            Dim myThemoStat As New Thermostat

            '  Create the Thermostat observers.
            Dim changeObserver As New TemperatureChangeObserver(myThemoStat)
            Dim averageObserver As New TemperatureAverageObserver(myThemoStat)

            '  Loop, getting temperature readings from the user.
            '  Any non-integer value will terminate the loop.
            Do
                Console.WriteLine(Environment.NewLine)
                Console.Write("Enter current temperature: ")

                Try
                    '  Convert the user's input to an integer and use it to set
                    '  the current temperature of the Thermostat.
                    myThemoStat.Temperature = Int32.Parse(Console.ReadLine)
                Catch ex As Exception
                    '  Use the exception condition to trigger termination.
                    Console.WriteLine("Terminating Observer Pattern Example.")

                    '  Wait to continue.
                    Console.WriteLine(Environment.NewLine)
                    Console.WriteLine("Main method complete.  Press Enter.")
                    Console.ReadLine()
                    Return

                End Try
            Loop While True

        End Sub
    End Class
End Namespace

