Imports System
Imports System.Xml.Linq

Namespace Apress.VisualBasicRecipes.Chapter07

    Public Class Recipe07_02

        Public Shared Sub Main()

            '  Load the Employees.xml and store the contents into an
            '  XDocument object.
            Dim xmlDoc As XDocument = XDocument.Load("Employees.xml")

            '  Display the XML files declaration information.
            Console.WriteLine("The document declaration is '{0}'", xmlDoc.Declaration.ToString)

            '  Display the name of the root element in the loaded
            '  XML tree.  The Root property returns the top-level
            '  XElement, the Name property returns the XName class
            '  associated with Root and LocalName returns the name
            '  of the element as a string).
            Console.WriteLine("The root element is '{0}'", xmlDoc.Root.Name.LocalName)

            '  Wait to continue.
            Console.WriteLine()
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace