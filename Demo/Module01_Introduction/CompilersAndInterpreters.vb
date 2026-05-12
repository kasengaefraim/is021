Public Class CompilersAndInterpreters
    Implements ISlide
    Public Sub Explain() Implements ISlide.Show

        Console.WriteLine("=== COMPILERS, INTERPRETERS & TYPES OF LANGUAGES ===")
        Console.WriteLine()

        Console.WriteLine("Computers do not understand human-readable programming languages directly.")
        Console.WriteLine("They only understand machine language (binary: 0s and 1s).")
        Console.WriteLine()


        Console.WriteLine("=== COMPILER ===")
        Console.WriteLine("- Translates the entire program at once")
        Console.WriteLine("- Checks all errors before running")
        Console.WriteLine("- Faster execution after compilation")
        Console.WriteLine("- Example: VB.NET, C#")

        Console.WriteLine()

        Console.WriteLine("=== INTERPRETER ===")
        Console.WriteLine("- Translates code line by line")
        Console.WriteLine("- Stops when it finds an error")
        Console.WriteLine("- Slower execution")
        Console.WriteLine("- Example: Python, JavaScript")

    End Sub

End Class