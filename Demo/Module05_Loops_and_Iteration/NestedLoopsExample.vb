Public Class NestedLoopsExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== NESTED LOOPS ===")
        Console.WriteLine()

        Console.WriteLine("A loop inside another loop.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("For i As Integer = 1 To 3")
        Console.WriteLine("    For j As Integer = 1 To 2")
        Console.WriteLine("        Console.WriteLine($""i={i}, j={j}"")")
        Console.WriteLine("    Next")
        Console.WriteLine("Next")

    End Sub

End Class