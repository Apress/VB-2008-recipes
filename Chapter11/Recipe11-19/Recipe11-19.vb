Imports System
Imports System.ServiceModel.Syndication
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_19

        Public Shared Sub main(ByVal args As String())

            '  Attempt to establish a connection to the feed represented by the url
            '  passed into this method.
            Dim rssFeed As SyndicationFeed
            Try
                rssFeed = SyndicationFeed.Load(New Uri(args(0)))

                '  Display a few of the RSS Feeds properties to the screen.
                Console.WriteLine("Title: {0}", rssFeed.Title.Text)
                Console.WriteLine("Description: {0}", rssFeed.Description.Text)
                Console.WriteLine("Copyright: {0}", rssFeed.Copyright.Text)
                Console.WriteLine("ImageUrl: {0}", rssFeed.ImageUrl.ToString)
                Console.WriteLine("LastUpdated: {0}", rssFeed.LastUpdatedTime.ToString())
                Console.WriteLine("Language: {0}", rssFeed.Language)
                '  Just show the first link (if there is more than one)
                Console.WriteLine("Link: {0}", rssFeed.Links(0).Uri.ToString())

                '  Now, show information for each item contained in the feed.
                Console.WriteLine("Items:")
                For Each item As SyndicationItem In rssFeed.Items
                    Console.WriteLine("Title: {0}", item.Title.Text)
                    Console.WriteLine("Description: {0}", item.Summary.Text)
                    '  Just show the first link (if there is more than one)
                    Console.WriteLine("Link: {0}", item.Links(0).Uri.ToString())
                Next
                Console.WriteLine(Environment.NewLine)

            Catch ex As Exception
                Console.WriteLine("Unable to retrieve the feed because of the following error:  {0}", ex.ToString)
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
