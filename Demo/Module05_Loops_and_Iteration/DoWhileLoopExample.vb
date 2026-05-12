Public Class DoWhileLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== DO WHILE LOOP ===")
        Console.WriteLine()

        Console.WriteLine("Runs at least once before checking condition.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim i As Integer = 1")
        Console.WriteLine("Do")
        Console.WriteLine("    Console.WriteLine(i)")
        Console.WriteLine("    i += 1")
        Console.WriteLine("Loop While i <= 5")

    End Sub

End Class