Public Class WhileLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== WHILE LOOP ===")
        Console.WriteLine()

        Console.WriteLine("Used when we don't know how many times to repeat.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim i As Integer = 1")
        Console.WriteLine("While i <= 5")
        Console.WriteLine("    Console.WriteLine(i)")
        Console.WriteLine("    i += 1")
        Console.WriteLine("End While")

    End Sub

End Class