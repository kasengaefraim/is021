Public Class ArrayLooping
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== LOOPING THROUGH ARRAYS ===")
        Console.WriteLine()

        Console.WriteLine("We use loops to access all elements in an array.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim numbers() As Integer = {1, 2, 3, 4, 5}")

        Console.WriteLine("For i As Integer = 0 To numbers.Length - 1")
        Console.WriteLine("    Console.WriteLine(numbers(i))")
        Console.WriteLine("Next")

    End Sub

End Class