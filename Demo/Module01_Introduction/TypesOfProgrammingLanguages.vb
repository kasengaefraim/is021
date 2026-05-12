Public Class TypesOfProgrammingLanguages
    Implements ISlide
    Public Sub Explain() Implements ISlide.Show

        Console.WriteLine("=== TYPES OF PROGRAMMING LANGUAGES ===")
        Console.WriteLine()

        Console.WriteLine("1. MACHINE LANGUAGE")
        Console.WriteLine("- Written in binary (0s and 1s)")
        Console.WriteLine("- Directly understood by the computer")
        Console.WriteLine("- Very hard for humans to read or write")
        Console.WriteLine()

        Console.WriteLine("2. ASSEMBLY LANGUAGE")
        Console.WriteLine("- Uses simple English-like instructions (e.g. MOV, ADD)")
        Console.WriteLine("- Needs an assembler to convert to machine code")
        Console.WriteLine("- Easier than machine language but still low-level")
        Console.WriteLine()

        Console.WriteLine("3. HIGH-LEVEL LANGUAGE")
        Console.WriteLine("- Easy for humans to read and write")
        Console.WriteLine("- Uses words like If, Else, Class, Sub")
        Console.WriteLine("- Needs a compiler or interpreter")
        Console.WriteLine("- Examples: VB.NET, C#, Python, Java")
        Console.WriteLine()


    End Sub

End Class