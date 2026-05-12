Public Class OutputFormatting
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== OUTPUT FORMATTING ===")
        Console.WriteLine()

        Console.WriteLine("1. CONCATENATION (&):")
        Console.WriteLine("Used to join strings together.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Console.WriteLine(""Hello "" & name)")
        Console.WriteLine()

        Console.WriteLine("2. STRING INTERPOLATION:")
        Console.WriteLine("Used to insert variables inside a string.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Console.WriteLine($""Hello {name}"")")
        Console.WriteLine()

    End Sub

End Class