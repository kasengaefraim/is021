Public Class MultiDimensionalArray
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MULTI-DIMENSIONAL ARRAYS ===")
        Console.WriteLine()

        Console.WriteLine("Used to store data in rows and columns (like a table).")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim matrix(1, 1) As Integer")
        Console.WriteLine("matrix(0, 0) = 1")
        Console.WriteLine("matrix(0, 1) = 2")
        Console.WriteLine("matrix(1, 0) = 3")
        Console.WriteLine("matrix(1, 1) = 4")

    End Sub

End Class