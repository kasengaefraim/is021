Public Class MethodOverloading
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== METHOD OVERLOADING ===")
        Console.WriteLine()

        Console.WriteLine("Method overloading means using the same method name with different parameters.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Function Add(a As Integer, b As Integer) As Integer")
        Console.WriteLine("Function Add(a As Double, b As Double) As Double")

        Console.WriteLine()
        Console.WriteLine("VB.NET chooses the correct method automatically.")

    End Sub

End Class