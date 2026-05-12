Public Class ForLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== FOR LOOP ===")
        Console.WriteLine()

        Console.WriteLine("Used when we know how many times to repeat.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("For i As Integer = 1 To 5")
        Console.WriteLine("    Console.WriteLine(i)")
        Console.WriteLine("Next")

        Console.WriteLine()
        Console.WriteLine("Output: 1 2 3 4 5")

    End Sub

End Class