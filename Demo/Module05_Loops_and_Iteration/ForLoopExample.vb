Public Class ForLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("FOR LOOP")
        Console.WriteLine()

        Console.WriteLine("Used when we know how many times to repeat.")
        Console.WriteLine()

        Console.WriteLine("Synthax:")
        Console.WriteLine()

        WriteSynthax("For i As Integer = start To end")
        WriteSynthax("      code here")
        WriteSynthax("Next")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("For i As Integer = 1 To 5")
        WriteCode("    Console.WriteLine(i)")
        WriteCode("Next")
        Console.WriteLine()

        WriteOutput("Output:")
        For i As Integer = 1 To 5
            WriteOutput(i)
        Next

    End Sub

End Class