Imports System
Imports System.Timers
Imports System.ServiceProcess
Namespace Apress.VisualBasicRecipes.Chapter15

    Class Recipe15_06
        Inherits ServiceBase

        '  A timer that controls how frequenty the example writes to the
        '  event log.
        Private serviceTimer As Timer
        Public Sub New()

            '  Set the ServiceBase.ServiceName property.
            ServiceName = "Recipe 15_06 Service"

            '  Configure the level of control available on the service.
            CanStop = True
            CanPauseAndContinue = True
            CanHandleSessionChangeEvent = True

            '  Configure the service to log important events to the
            '  Application event log automatically.
            AutoLog = True

        End Sub
        '  The method executed when the timer expires and writes an
        '  entry to the Application event log.
        Private Sub WriteLogEntry(ByVal sender As Object, ByVal e As ElapsedEventArgs)

            '  In case this is a long running process, Stop the timer
            '  so it won't attempt execute multiple times.
            serviceTimer.Stop()

            '  Use the EventLog object automatically configured by the
            '  ServiceBase class to write to the event log.
            EventLog.WriteEntry("Recipe15_06 Service active : " & e.SignalTime)

            '  Restart the timer.
            serviceTimer.Start()

        End Sub
        Protected Overrides Sub OnStart(ByVal args() As String)

            '  Obtain the interval between log entry writes from the first
            '  argument.  Use 5000 milliseconds by default and enforce a 1000
            '  millisecond minimum.
            Dim interval As Double

            Try
                interval = Double.Parse(args(0))
                interval = Math.Max(1000, interval)
            Catch ex As Exception
                interval = 5000
            End Try

            EventLog.WriteEntry(String.Format("Recipe15_06 Service starting.  Writing log entries every {0} milliseconds...", interval))

            '  Create, configure and start a System.Timers.Timer to
            '  periodically call the WriteLogEntry method.  The Start
            '  and Stop methods of the System.Timers.Timer class
            '  make starting, pausing, resuming and stopping the
            '  service straightforward.
            serviceTimer = New Timer
            serviceTimer.Interval = interval
            serviceTimer.AutoReset = True
            AddHandler serviceTimer.Elapsed, AddressOf WriteLogEntry
            serviceTimer.Start()

        End Sub
        Protected Overrides Sub OnStop()

            EventLog.WriteEntry("Recipe15_06 Service stopping...")
            serviceTimer.Stop()

            '  Free system resources used by the Timer object.
            serviceTimer.Dispose()
            serviceTimer = Nothing

        End Sub
        Protected Overrides Sub OnPause()

            If serviceTimer IsNot Nothing Then
                EventLog.WriteEntry("Recipe15_06 Service pausing...")
                serviceTimer.Stop()
            End If

        End Sub
        Protected Overrides Sub OnContinue()

            If serviceTimer IsNot Nothing Then
                EventLog.WriteEntry("Recipe15_06 Service resuming...")
                serviceTimer.Start()
            End If

        End Sub
        Protected Overrides Sub OnSessionChange(ByVal changeDescription As System.ServiceProcess.SessionChangeDescription)

            EventLog.WriteEntry("Recipe15_06 Session change..." & changeDescription.Reason)

        End Sub
        Public Shared Sub Main()

            '  Create an instance of the Recipe14_06 class that will write
            '  an entry to the Application event log.  Pass the object to the
            '  shared ServiceBase.Run method.
            ServiceBase.Run(New Recipe15_06)

        End Sub

    End Class

End Namespace
