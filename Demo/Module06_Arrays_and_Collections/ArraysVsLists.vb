Public Class ArraysVsLists
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== ARRAYS VS LISTS ===")
        Console.WriteLine()

        Console.WriteLine("ARRAYS:")
        Console.WriteLine("- Fixed size")
        Console.WriteLine("- Faster")
        Console.WriteLine("- Cannot easily resize")

        Console.WriteLine()
        Console.WriteLine("LISTS:")
        Console.WriteLine("- Dynamic size")
        Console.WriteLine("- Easier to use")
        Console.WriteLine("- Can add/remove items")

    End Sub

End Class