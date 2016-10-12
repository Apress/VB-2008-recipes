Imports System
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_03

        Public Shared Sub Main()

            '  Specify the URI of the resource to parse.
            Dim remoteUri As String = "http://www.msdn.com"

            '  Create a WebClient to perform the download.
            Dim client As New WebClient

            Console.WriteLine("Downloading {0}", remoteUri)

            '  Perform the download getting the resource as a string.
            Dim str As String = client.DownloadString(remoteUri)

            '  Use a regular expression to extract all fully qualified
            '  URIs that refer to GIF files.
            Dim matches As MatchCollection = Regex.Matches(str, "http\S+[^-,;:?]\.gif")

            '  Try to download each referenced .gif files.
            For Each expMatch As Match In matches
                For Each grp As Group In expMatch.Groups
                    '  Determine the local filename.
                    Dim downloadedFile As String = grp.Value.Substring(grp.Value.LastIndexOf("/") + 1)

                    Try
                        '  Download and store the file.
                        Console.WriteLine("Downloading {0} to file {1}", grp.Value, downloadedFile)

                        client.DownloadFile(New Uri(grp.Value), downloadedFile)
                    Catch ex As Exception
                        Console.WriteLine("Failed to download {0}", grp.Value)
                    End Try
                Next
            Next

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
