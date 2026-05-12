Public Class IfStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== IF STATEMENT ===")
        Console.WriteLine()

        Console.WriteLine("Used when we want to execute code only if a condition is true.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim age As Integer = 18")
        Console.WriteLine("If age >= 18 Then")
        Console.WriteLine("    Console.WriteLine(""You are an adult"")")
        Console.WriteLine("End If")

    End Sub

End Class