Public Class IfElseStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== IF...ELSE STATEMENT ===")
        Console.WriteLine()

        Console.WriteLine("Used when we want two possible outcomes.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim age As Integer = 16")
        Console.WriteLine("If age >= 18 Then")
        Console.WriteLine("    Console.WriteLine(""Adult"")")
        Console.WriteLine("Else")
        Console.WriteLine("    Console.WriteLine(""Minor"")")
        Console.WriteLine("End If")

    End Sub

End Class