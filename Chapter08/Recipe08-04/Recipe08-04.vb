Imports System
Imports System.Configuration
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter08

    Public Class Recipe08_04

        Private Shared Sub WriteEncryptedConnectionStringSection(ByVal name As String, ByVal constring As String, ByVal provider As String)

            '  Get the configuration file for the current application.  Specify
            '  the ConfigurationUserLevel.None argument so that we get the
            '  configuration settings that apply to all users.
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            '  Get the connectionStrings section from the configuration file.
            Dim section As ConnectionStringsSection = config.ConnectionStrings

            '  If the connectionString section does not exist, create it.
            If section Is Nothing Then
                section = New ConnectionStringsSection
                config.Sections.Add("connectionSettings", section)
            End If

            '  If it is not already encrypted, configure the connectionStrings
            '  section to be encrypted using the standard RSA Protected
            '  Configuration Provider.
            If Not section.SectionInformation.IsProtected Then
                '  Remove this statement to write the connection strin in clear
                '  text for the purpose of testing.
                section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider")
            End If

            '  Create a new connection string element and add it to the
            '  connection string configuration section.
            Dim cs As New ConnectionStringSettings(name, constring, provider)
            section.ConnectionStrings.Add(cs)

            '  Force the connection string section to be saved whether
            '  it was modified or not.
            section.SectionInformation.ForceSave = True

            '  Save the updated configuration file.
            config.Save(ConfigurationSaveMode.Full)

        End Sub
        Public Shared Sub main()

            '  The connection string information to be written to the
            '  configuration file.
            Dim conName As String = "ConnectionString1"
            Dim conString As String = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;Min Pool Size=5;Max Pool Size=5;Connection Reset=True;Connection Lifetime=600;"
            Dim providerName As String = "System.Data.SqlClient"

            '  Write the new connection string to the application's
            '  configuration file.
            WriteEncryptedConnectionStringSection(conName, conString, providerName)

            '  Read the encrypted connection string settings from the
            '  application's configuration file.
            Dim cs2 As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("ConnectionString1")

            '  Use the connections string to create a new SQL Server connection.
            Using con As New SqlConnection(cs2.ConnectionString)
                '  Issue database commands/queries...
            End Using

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
    End Class

End Namespace