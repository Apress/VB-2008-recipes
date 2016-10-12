Imports System
'  Declare Todd as the assembly author.  Assembly attributes
'  must be declared after using statements but before any other.
'  Author name is a positional parameter.
'  Company name is a named parameter.
<Assembly: Apress.VisualBasicRecipes.Chapter03.Author("Todd", Company:="The Code Architects")> 

Namespace Apress.VisualBasicRecipes.Chapter03

    '  Declare a class authored by Todd.
    <Author("Todd", company:="The Code Architects")> _
    Public Class SomeClass
        '  Class implementation.
    End Class
    '  Declare a class authored by Aidan.  Since the "Company"
    '  property is optional we will leave it out for this test.
    <Author("Aidan")> _
    Public Class SomeOtherClass
        '  Class implementation.
    End Class

End Namespace
