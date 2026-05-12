Public Class ListCollection
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== LIST COLLECTION ===")
        Console.WriteLine()

        Console.WriteLine("A List is a dynamic collection that can grow or shrink.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim names As New List(Of String)")
        Console.WriteLine("names.Add(""John"")")
        Console.WriteLine("names.Add(""Mary"")")

        Console.WriteLine()
        Console.WriteLine("Lists are more flexible than arrays.")

    End Sub

End Class