Public Class ReturnValues
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== RETURN VALUES ===")
        Console.WriteLine()

        Console.WriteLine("Functions must return a value using Return keyword.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Function Square(num As Integer) As Integer")
        Console.WriteLine("    Return num * num")
        Console.WriteLine("End Function")

        Console.WriteLine()
        Console.WriteLine("Usage:")
        Console.WriteLine("Dim result = Square(4) ' 16")

    End Sub

End Class