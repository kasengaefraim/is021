Public Class ForEachLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("FOR EACH LOOP")
        Console.WriteLine()

        Console.WriteLine("FOR EACH is used to loop through collections or arrays.")
        Console.WriteLine()

        Console.WriteLine("Unlike FOR loops:")
        Console.WriteLine("1. You do not use indexes")
        Console.WriteLine("2. VB.NET automatically gets each item")
        Console.WriteLine()

        Console.WriteLine("Syntax:")
        Console.WriteLine()

        WriteSynthax("For Each item In collection")
        WriteSynthax("      code here")
        WriteSynthax("Next")

        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim names() As String = {""John"", ""Mary"", ""James""}")
        Console.WriteLine()

        WriteCode("For Each name In names")
        WriteCode("    Console.WriteLine(name)")
        WriteCode("Next")

        Console.WriteLine()

        WriteTitle("OUTPUT")

        Dim names() As String = {"John", "Mary", "James"}
        For Each name In names
            WriteOutput(name)
        Next

        Console.WriteLine()

        WriteTitle("EXPLANATION")
        

        Console.WriteLine("1. names is an array containing 3 values")
        Console.WriteLine("2. FOR EACH takes one item at a time")
        Console.WriteLine("3. First loop  -> John")
        Console.WriteLine("4. Second loop -> Mary")
        Console.WriteLine("5. Third loop  -> James")

        Console.WriteLine()

        Console.WriteLine("Important:")
        Console.WriteLine("1. FOR EACH is simpler than FOR loops")
        Console.WriteLine("2. Best for arrays and collections")
        Console.WriteLine("3. You cannot directly control indexes easily")

    End Sub

End Class