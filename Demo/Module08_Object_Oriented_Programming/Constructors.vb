Public Class Constructors
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== CONSTRUCTORS ===")
        Console.WriteLine()

        Console.WriteLine("A constructor runs automatically when an object is created.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Class Student")
        Console.WriteLine("    Public Sub New()")
        Console.WriteLine("        Console.WriteLine(""Object created"")")
        Console.WriteLine("    End Sub")
        Console.WriteLine("End Class")

        Console.WriteLine()

        Console.WriteLine("Dim s As New Student()")

    End Sub

End Class