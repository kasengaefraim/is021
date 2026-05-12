Public Class DoUntilLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== DO UNTIL LOOP ===")
        Console.WriteLine()

        Console.WriteLine("Repeats UNTIL a condition becomes true.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim i As Integer = 1")
        Console.WriteLine("Do Until i > 5")
        Console.WriteLine("    Console.WriteLine(i)")
        Console.WriteLine("    i += 1")
        Console.WriteLine("Loop")

    End Sub

End Class