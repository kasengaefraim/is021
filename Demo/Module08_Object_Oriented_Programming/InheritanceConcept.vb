Public Class InheritanceConcept
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== INHERITANCE ===")
        Console.WriteLine()

        Console.WriteLine("Inheritance allows one class to reuse another class.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Class Person")
        Console.WriteLine("    Public name As String")
        Console.WriteLine("End Class")
        Console.WriteLine()

        Console.WriteLine("Class Student")
        Console.WriteLine("    Inherits Person")
        Console.WriteLine("End Class")

    End Sub

End Class