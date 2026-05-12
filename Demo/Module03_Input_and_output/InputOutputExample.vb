Public Class InputOutputExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== FULL INPUT/OUTPUT EXAMPLE ===")
        Console.WriteLine()

        Console.WriteLine("This is a complete simple program flow:")
        Console.WriteLine()

        Console.WriteLine("Console.Write(""Enter your age: "")")
        Console.WriteLine("Dim age As Integer = CInt(Console.ReadLine())")
        Console.WriteLine()

        Console.WriteLine("Console.WriteLine($""You are {age} years old"")")
        Console.WriteLine()

        Console.WriteLine("Key Idea:")
        Console.WriteLine("- Input = data from user")
        Console.WriteLine("- Output = data shown to user")

    End Sub

End Class