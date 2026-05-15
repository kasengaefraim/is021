Public Class FunctionsIntro
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("FUNCTIONS")
        Console.WriteLine()

        Console.WriteLine("A Function returns a value after execution.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Function Add(a As Integer, b As Integer) As Integer")
        Console.WriteLine("    Return a + b")
        Console.WriteLine("End Function")

        Console.WriteLine()
        Console.WriteLine("Usage:")
        Console.WriteLine("Dim result = Add(5, 3)")

        Dim result = Add(5, 3)



    End Sub
    Function Add(a As Integer, b As Integer) As Integer
        Return a + b
    End Function
End Class