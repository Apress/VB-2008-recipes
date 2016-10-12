Imports System
Imports System.Windows.Forms

Namespace Apress.VisualBasicRecipes.Chapter01

    Public Class Recipe01_02
        Inherits Form

        ' Private members to hold references to the form's controls.
        Private Label1 As Label
        Private TextBox1 As TextBox
        Private Button1 As Button

        ' Constructor used to create an instance of the form and configure
        ' the form's controls.
        Public Sub New()
            ' Instantiat the controls used on the form.
            Me.Label1 = New Label
            Me.TextBox1 = New TextBox
            Me.Button1 = New Button

            ' Suspend the layout logic of the form while we configure and
            ' position the controls.
            Me.SuspendLayout()

            ' Configure Label1, which displays the user prompt.
            Me.Label1.Location = New System.Drawing.Size(16, 36)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(155, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Please enter your name:"

            ' Configure TextBox1, which accepts the user input.
            Me.TextBox1.Location = New System.Drawing.Point(172, 32)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.TabIndex = 1
            Me.TextBox1.Text = ""

            ' Configure Button1, which the user clicks to enter a name.
            Me.Button1.Location = New System.Drawing.Point(109, 80)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "Enter"
            AddHandler Button1.Click, AddressOf Button1_Click

            ' Configure WelcomeForm, and add controls.
            Me.ClientSize = New System.Drawing.Size(292, 126)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label1)
            Me.Name = "Form1"
            Me.Text = "Visual Basic 2008 Recipes"

            ' Resume the layout logic of the form now that all controls are
            ' configrued.
            Me.ResumeLayout(False)

        End Sub
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

            ' Write debug message to the console.
            System.Console.WriteLine("User entered: " + TextBox1.Text)

            ' Display welcome as a message box.
            MessageBox.Show("Welcome to Visual Basic 2008 Recipes, " + TextBox1.Text, "Visual Basic 2008 Recipes")

        End Sub
        ' Application entry point, creates an instance of the form, and begins
        ' running a standard message loop on the current thread.  The message
        ' loop feeds the application with input from the user as events.
        Public Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Recipe01_02())
        End Sub

    End Class

End Namespace

