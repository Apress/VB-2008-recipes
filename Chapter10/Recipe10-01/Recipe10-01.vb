Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.text
'  All designed code is stored in the auto-generated partial
'  class called Recipe10-01.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe10_01

    Private Sub Recipe10_01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '  Create the font collection.
        Using fontFamilies As New InstalledFontCollection

            '  Iterate through all font families
            Dim offset As Integer = 10

            For Each family As FontFamily In fontFamilies.Families

                Try
                    '  Create a label that will display text in this font.
                    Dim fontLabel As New Label

                    fontLabel.Text = family.Name
                    fontLabel.Font = New Font(family, 14)
                    fontLabel.Left = 10
                    fontLabel.Width = pnlFonts.Width
                    fontLabel.Top = offset

                    '  Add the label to a scrollable Panel.
                    pnlFonts.Controls.Add(fontLabel)
                    offset += 30
                Catch ex As ArgumentException
                    '  An ArgumentException will be thrown if the selected
                    '  font does not support regular style (the default used
                    '  when creating a font object).  For this example, we 
                    '  will display an appropriate message in the list.
                    Dim fontLabel As New Label

                    fontLabel.Text = ex.Message
                    fontLabel.Font = New Font("Arial", 10, FontStyle.Italic)
                    fontLabel.ForeColor = Color.Red
                    fontLabel.Left = 10
                    fontLabel.Width = 500
                    fontLabel.Top = offset

                    '  Add the label to a scrollable Panel.
                    pnlFonts.Controls.Add(fontLabel)
                    offset += 30
                End Try

            Next


        End Using

    End Sub

End Class