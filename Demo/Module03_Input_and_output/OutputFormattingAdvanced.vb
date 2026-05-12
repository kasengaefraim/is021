Public Class OutputFormattingAdvanced
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== FORMATTING OUTPUT ===")
        Console.WriteLine()

        Console.WriteLine("You can format numbers and text output for better display.")
        Console.WriteLine()

        Console.WriteLine("Example 1: Decimal formatting")
        Console.WriteLine("Dim price As Double = 10.5678")
        Console.WriteLine("Console.WriteLine(price.ToString(""F2"")) ' 10.57")
        Console.WriteLine()

        Console.WriteLine("Example 2: Currency format")
        Console.WriteLine("Console.WriteLine(price.ToString(""C""))")
        Console.WriteLine()

        Console.WriteLine("Example 3: Alignment")
        'Console.WriteLine("Console.WriteLine(""Name".PadRight(10) & ""Score"")")

    End Sub

End Class