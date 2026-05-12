Public Class AccessAndImplementation
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== ACCESS MODIFIERS & IMPLEMENTATION ===")
        Console.WriteLine()

        Console.WriteLine("ACCESS MODIFIERS control visibility of code:")
        Console.WriteLine()

        Console.WriteLine("Public:")
        Console.WriteLine("- Accessible from anywhere")

        Console.WriteLine("Private:")
        Console.WriteLine("- Accessible only inside the same class")

        Console.WriteLine("Friend:")
        Console.WriteLine("- Accessible within the same project")

        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Public Class Student")
        Console.WriteLine("    Private name As String")
        Console.WriteLine("End Class")

    End Sub

End Class