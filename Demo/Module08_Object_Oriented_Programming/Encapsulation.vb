Public Class Encapsulation
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== ENCAPSULATION ===")
        Console.WriteLine()

        Console.WriteLine("Encapsulation means hiding data inside a class.")
        Console.WriteLine()

        Console.WriteLine("We use Private variables + Public methods")

        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Class Student")
        Console.WriteLine("    Private name As String")

        Console.WriteLine("    Public Sub SetName(n As String)")
        Console.WriteLine("        name = n")
        Console.WriteLine("    End Sub")
        Console.WriteLine()

        Console.WriteLine("    Public Function GetName() As String")
        Console.WriteLine("        Return name")
        Console.WriteLine("    End Function")
        Console.WriteLine("End Class")

    End Sub

End Class