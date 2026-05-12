Public Class ProgramStructure
    Implements ISlide
    Public Sub Explain() Implements ISlide.Show

        Console.WriteLine("=== STRUCTURE OF A VB.NET PROGRAM ===")
        Console.WriteLine()

        Console.WriteLine("A VB.NET program is made up of several parts:")

        Console.WriteLine()
        Console.WriteLine("1. Namespace (optional)")
        Console.WriteLine("   Groups related classes")

        Console.WriteLine()
        Console.WriteLine("2. Module or Class")
        Console.WriteLine("   Contains methods and logic")

        Console.WriteLine()
        Console.WriteLine("3. Sub Main()")
        Console.WriteLine("   Entry point of the program")

        Console.WriteLine()
        Console.WriteLine("Example Structure:")
        Console.WriteLine()
        Console.WriteLine("Module Program")
        Console.WriteLine("    Sub Main()")
        Console.WriteLine("        Console.WriteLine(""This is what you see!!!"")")
        Console.WriteLine("    End Sub")
        Console.WriteLine("End Module")

    End Sub

End Class