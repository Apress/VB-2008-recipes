Imports System
Imports System.IO.Ports
Namespace Apress.VisualBasicRecipes.Chapter05

    Public Class Recipe05_21

        Public Shared Sub Main()

            '  Enumerate each of the available COM ports
            '  on the computer.
            Console.WriteLine("Available Ports on this computer:")
            For Each portName As String In SerialPort.GetPortNames
                Console.WriteLine("PORT: " & portName)
            Next
            Console.WriteLine()

            '  For this example, lets just grab the first item from 
            '  the array returned by the GetPortNames method.
            Dim testPort As String = SerialPort.GetPortNames(0)
            Using port As New SerialPort(testPort)

                '  Set the properties.
                port.BaudRate = 9600
                port.Parity = Parity.None
                port.ReadTimeout = 10
                port.StopBits = StopBits.One

                '  Write a message into the port.
                port.Open()
                port.Write("Hello world!")
                port.Close()

                Console.WriteLine("Wrote to the {0} port.", testPort)

            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
