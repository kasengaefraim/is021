Public Class TypeConversion
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== TYPE CONVERSION ===")
        Console.WriteLine()

        Console.WriteLine("Type conversion means changing one data type to another.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim num As String = ""100""")
        Console.WriteLine("Dim result As Integer = CInt(num)")
        Console.WriteLine()

        Console.WriteLine("Common conversion functions:")
        Console.WriteLine("- CInt() → Convert to Integer")
        Console.WriteLine("- CDbl() → Convert to Double")
        Console.WriteLine("- CStr() → Convert to String")
        Console.WriteLine("- CBool() → Convert to Boolean")

    End Sub

End Class