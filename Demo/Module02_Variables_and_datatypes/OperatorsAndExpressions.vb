Public Class OperatorsAndExpressions
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== OPERATORS AND EXPRESSIONS ===")
        Console.WriteLine()

        Console.WriteLine("OPERATORS are symbols used to perform operations on values.")
        Console.WriteLine()

        Console.WriteLine("Arithmetic Operators:")
        Console.WriteLine("+  Addition")
        Console.WriteLine("-  Subtraction")
        Console.WriteLine("*  Multiplication")
        Console.WriteLine("/  Division")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Dim result As Integer = 10 + 5")
        Console.WriteLine()

        Console.WriteLine("COMPARISON OPERATORS:")
        Console.WriteLine("=   Equal")
        Console.WriteLine("<>  Not equal")
        Console.WriteLine(">   Greater than")
        Console.WriteLine("<   Less than")

    End Sub

End Class