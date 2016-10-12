Imports System
Imports System.Threading
Namespace Apress.VisualBasicRecipes.Chapter04

    Class Recipe04_12

        Public Shared Sub Main()

            Dim firstInt As Integer = 2500
            Dim secondInt As Integer = 8000

            Console.WriteLine("firstInt initial value = {0}", firstInt)
            Console.WriteLine("secondInt initial value = {0}", secondInt)

            '  Decrement firstInt in a thread-safe manner. This is 
            '  the thread-safe equivalent of firstInt = firstInt - 1.
            Interlocked.Decrement(firstInt)

            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("firstInt after decrement = {0}", firstInt)

            '  Increment secondInt in a thread-safe manner.  This is
            '  the thread-safe equivalent of secondInt = secondInt + 1.
            Interlocked.Increment(secondInt)

            Console.WriteLine("secondInt after increment = {0}", secondInt)

            '  Add the firstInt and secondInt values, and store the result
            '  in firstInt. This is the thread-safe equivalent of firstInt
            '  = firstInt + secondInt.
            Interlocked.Add(firstInt, secondInt)

            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("firstInt after Add = {0}", firstInt)
            Console.WriteLine("secondInt after Add = {0}", secondInt)

            '  Exchange the value of firstInt with secondInt. This is the
            '  thread-safe equivalent of secondInt = firstInt.
            Interlocked.Exchange(secondInt, firstInt)

            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("firstInt after Exchange = {0}", firstInt)
            Console.WriteLine("secondInt after Exchange = {0}", secondInt)

            '  Compare firstInt with secondInt, and if theya re equal, set
            '  firstInt to 5000. This is the thread-safe equivalent of:
            '       if firstInt = secondInt then firstInt = 5000
            Interlocked.CompareExchange(firstInt, 5000, secondInt)

            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("firstInt after CompareExchange = {0}", firstInt)
            Console.WriteLine("secondInt after CompareExchange = {0}", secondInt)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete. Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
