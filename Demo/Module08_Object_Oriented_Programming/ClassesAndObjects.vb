Public Class ClassesAndObjects
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== CLASSES AND OBJECTS ===")
        Console.WriteLine()

        Console.WriteLine("Class = blueprint")
        Console.WriteLine("Object = real instance of a class")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Class Student")
        Console.WriteLine("    Public name As String")
        Console.WriteLine("End Class")

        Console.WriteLine()

        Console.WriteLine("Creating object:")
        Console.WriteLine("Dim s As New Student()")
        Console.WriteLine("s.name = ""John""")

    End Sub

End Class