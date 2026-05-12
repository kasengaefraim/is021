Public Class OneDimensionalArray
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== ONE-DIMENSIONAL ARRAY ===")
        Console.WriteLine()

        Console.WriteLine("Stores values in a single row.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim numbers() As Integer = {10, 20, 30, 40}")

        Console.WriteLine()
        Console.WriteLine("Accessing elements:")
        Console.WriteLine("numbers(0) = 10")
        Console.WriteLine("numbers(1) = 20")

    End Sub

End Class