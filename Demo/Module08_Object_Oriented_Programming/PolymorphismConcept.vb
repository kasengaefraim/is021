Public Class PolymorphismConcept
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== POLYMORPHISM ===")
        Console.WriteLine()

        Console.WriteLine("Polymorphism means 'many forms'.")
        Console.WriteLine()

        Console.WriteLine("Same method behaves differently in different classes.")

        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Class Animal")
        Console.WriteLine("    Public Overridable Sub Sound()")
        Console.WriteLine("    End Sub")
        Console.WriteLine()

        Console.WriteLine("Class Dog")
        Console.WriteLine("    Inherits Animal")
        Console.WriteLine("    Public Overrides Sub Sound()")
        Console.WriteLine("        Console.WriteLine(""Bark"")")
        Console.WriteLine("    End Sub")
        Console.WriteLine("End Class")

    End Sub

End Class