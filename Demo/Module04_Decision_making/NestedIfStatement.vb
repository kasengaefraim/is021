Public Class NestedIfStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== NESTED IF ===")
        Console.WriteLine()

        Console.WriteLine("A nested IF is an IF statement inside another IF.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim age As Integer = 20")
        Console.WriteLine("Dim hasID As Boolean = True")

        Console.WriteLine("If age >= 18 Then")
        Console.WriteLine("    If hasID Then")
        Console.WriteLine("        Console.WriteLine(""Allowed"")")
        Console.WriteLine("    End If")
        Console.WriteLine("End If")

    End Sub

End Class