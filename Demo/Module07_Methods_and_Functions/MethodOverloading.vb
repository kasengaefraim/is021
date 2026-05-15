Public Class MethodOverloading
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("METHOD OVERLOADING")
        Console.WriteLine()

        Console.WriteLine("Method overloading means using the same method name with different parameters.")
        Console.WriteLine("This allows a method to perform similar actions with different types or number of inputs.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Function Add(a As Integer, b As Integer) As Integer")
        Console.WriteLine("Function Add(a As Double, b As Double) As Double")

        Console.WriteLine()

        Console.WriteLine("EXPLANATION (IN CODE TERMS):")
        Console.WriteLine()

        Console.WriteLine("- Both methods have the SAME name: Add")
        Console.WriteLine("- But they have DIFFERENT parameter types")
        Console.WriteLine()

        Console.WriteLine("1st method:")
        Console.WriteLine("- Add(a As Integer, b As Integer)")
        Console.WriteLine("- Used when inputs are whole numbers")

        Console.WriteLine()

        Console.WriteLine("2nd method:")
        Console.WriteLine("- Add(a As Double, b As Double)")
        Console.WriteLine("- Used when inputs have decimal values")

        Console.WriteLine()

        Console.WriteLine("HOW VB.NET DECIDES:")

        Console.WriteLine()
        Console.WriteLine("Calling Add(2, 3):")
        Console.WriteLine(Add(2, 3))
        Console.WriteLine("  → VB.NET uses Integer version")

        Console.WriteLine()

        Console.WriteLine("Calling Add(2.5, 3.5):")
        Console.WriteLine(Add(2.5, 3.5))
        Console.WriteLine("  → VB.NET uses Double version")
        Console.WriteLine()

        Console.WriteLine("IMPORTANT:")
        Console.WriteLine("- VB.NET automatically chooses the correct method")
        Console.WriteLine("- This is based on parameter type and number of arguments")
        Console.WriteLine("- This improves flexibility and code reusability")

    End Sub

    ' Integer version
    Function Add(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    ' Double version (overloaded method)
    Function Add(a As Double, b As Double) As Double
        Return a + b
    End Function

End Class