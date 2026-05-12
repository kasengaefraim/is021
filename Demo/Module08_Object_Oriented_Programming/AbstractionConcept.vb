Public Class AbstractionConcept
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== ABSTRACTION ===")
        Console.WriteLine()

        Console.WriteLine("Abstraction means hiding complex details and showing only what is necessary.")
        Console.WriteLine()

        Console.WriteLine("In real life:")
        Console.WriteLine("- You drive a car without knowing engine details")
        Console.WriteLine()

        Console.WriteLine("In VB.NET, abstraction is done using:")
        Console.WriteLine("- MustInherit classes")
        Console.WriteLine("- MustOverride methods")

        Console.WriteLine()

        Console.WriteLine("Example:")

        Console.WriteLine()
        Console.WriteLine("MustInherit Class Animal")
        Console.WriteLine("    Public MustOverride Sub Sound()")
        Console.WriteLine("End Class")

        Console.WriteLine()

        Console.WriteLine("Class Dog Inherits Animal")
        Console.WriteLine("    Public Overrides Sub Sound()")
        Console.WriteLine("        Console.WriteLine(""Bark"")")
        Console.WriteLine("    End Sub")
        Console.WriteLine("End Class")

    End Sub

End Class