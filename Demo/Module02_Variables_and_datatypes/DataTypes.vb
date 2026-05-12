Public Class DataTypes
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== DATA TYPES ===")
        Console.WriteLine()

        Console.WriteLine("Data types define what kind of data a variable can store.")
        Console.WriteLine()

        Console.WriteLine("Common VB.NET Data Types:")
        Console.WriteLine()

        Console.WriteLine("Integer   - Whole numbers (10, 50, 100)")
        Console.WriteLine("Double    - Decimal numbers (10.5, 3.14)")
        Console.WriteLine("String    - Text ('Hello')")
        Console.WriteLine("Boolean   - True or False")
        Console.WriteLine("Char      - Single character ('A')")

    End Sub

End Class