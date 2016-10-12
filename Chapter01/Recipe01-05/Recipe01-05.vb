Imports System
Imports System.windows.forms
Imports System.Resources

Namespace Apress.VisualBasicRecipes.Chapter01

    Public Class Recipe01_05
        Inherits Form

        ' Private members to hold references to the form's controls.
        Private label1 As Label
        Private textbox1 As TextBox
        Private button1 As Button
        Private resManager As New ResourceManager("MyStrings", System.Reflection.Assembly.GetExecutingAssembly())

        ' Constructor used to create an instance of the form and configure
        ' the form's controls.
        Public Sub New()
            ' Instantiat the controls used on the form.
            Me.label1 = New Label
            Me.textbox1 = New TextBox
            Me.button1 = New Button

            ' Suspend the layout logic of the form while we configure and
            ' position the controls.
            Me.SuspendLayout()

            ' Configure label1, which displays the user prompt.
            Me.label1.Location = New System.Drawing.Size(16, 36)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(155, 16)
            Me.label1.TabIndex = 0
            Me.label1.Text = resManager.GetString("UserPrompt")

            ' Configure textbox1, which accepts the user input.
            Me.textbox1.Location = New System.Drawing.Point(172, 32)
            Me.textbox1.Name = "textbox1"
            Me.textbox1.TabIndex = 1
            Me.textbox1.Text = ""

            ' Configure button1, which the user clicks to enter a name.
            Me.button1.Location = New System.Drawing.Point(109, 80)
            Me.button1.Name = "button1"
            Me.button1.TabIndex = 2
            Me.button1.Text = resManager.GetString("ButtonCaption")
            AddHandler button1.Click, AddressOf button1_Click

            ' Configure WelcomeForm, and add controls.
            Me.ClientSize = New System.Drawing.Size(292, 126)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textbox1)
            Me.Controls.Add(Me.label1)
            Me.Name = "form1"
            Me.Text = resManager.GetString("FormTitle")

            ' Resume the layout logic of the form now that all controls are
            ' configrued.
            Me.ResumeLayout(False)

        End Sub
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

            ' Write debug message to the console.
            System.Console.WriteLine("User entered: " + textbox1.Text)

            ' Display welcome as a message box.
            MessageBox.Show(resManager.GetString("Message") + textbox1.Text, resManager.GetString("FormTitle"))

        End Sub
        ' Application entry point, creates an instance of the form, and begins
        ' running a standard message loop on the current thread.  The message
        ' loop feeds the application with input from the user as events.
        Public Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Recipe01_05())
        End Sub

    End Class

End Namespace