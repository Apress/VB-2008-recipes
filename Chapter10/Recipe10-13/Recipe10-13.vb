Imports System
Imports System.Drawing.Printing
Namespace Apress.VisualBasicRecipes.Chapter10

    Public Class Recipe10_13

        Public Shared Sub Main()

            For Each printerName As String In PrinterSettings.InstalledPrinters

                '  Display the printer name.
                Console.WriteLine("Printer: {0}", printerName)

                '  Retrieve the printer settings.
                Dim printer As New PrinterSettings
                printer.PrinterName = printerName

                '  Check that this is a valid printer.
                '  (This step might be requried if you read the pritner name
                '  from a user-supplied value or a registry or configruation
                '  file setting.)
                If printer.IsValid Then
                    '  Display the list of valid resolutions.
                    Console.WriteLine("Supported Resolutions:")

                    For Each resolution As PrinterResolution In printer.PrinterResolutions
                        Console.WriteLine("  {0}", resolution)
                    Next
                    Console.WriteLine()

                    '  Display the list of valid paper sizes.
                    Console.WriteLine("Supported Paper Sizes:")

                    For Each size As PaperSize In printer.PaperSizes
                        If System.Enum.IsDefined(size.Kind.GetType, size.Kind) Then
                            Console.WriteLine("  {0}", size)
                        End If
                    Next
                    Console.WriteLine()
                End If
            Next
            Console.ReadLine()
        End Sub

    End Class
End Namespace