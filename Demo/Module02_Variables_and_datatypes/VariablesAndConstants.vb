Public Class VariablesAndConstants
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== VARIABLES AND CONSTANTS ===")
        Console.WriteLine()

        Console.WriteLine("VARIABLES:")
        Console.WriteLine("- A variable is a container for storing data.")
        Console.WriteLine("- Its value can change during program execution.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Dim age As Integer = 20")
        Console.WriteLine("age = 25 ' value changed")
        Console.WriteLine()

        Console.WriteLine("CONSTANTS:")
        Console.WriteLine("- A constant is a value that cannot be changed.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Const Pi As Double = 3.14")

    End Sub

End Class