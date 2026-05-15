Public Class NestedLoopsExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("NESTED LOOPS")
        Console.WriteLine()

        Console.WriteLine("A loop inside another loop.")
        Console.WriteLine()
        Console.WriteLine("Synthax:")
        Console.WriteLine()
        WriteSynthax("For i As Integer = 1 To 5")
        WriteSynthax("    For j As Integer = 1 To 5")
        WriteSynthax("          code here")
        WriteSynthax("    Next")
        WriteSynthax("Next")

        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("For i As Integer = 1 To 3")
        WriteCode("    For j As Integer = 1 To 2")
        WriteCode("        Console.WriteLine($""i={i}, j={j}"")")
        WriteCode("    Next")
        WriteCode("Next")

        Console.WriteLine()

        WriteOutput("Output:")

        For i As Integer = 1 To 3
            For j As Integer = 1 To 2
                WriteOutput($"i={i}, j = {j}")
            Next
        Next

        Console.WriteLine()

        WriteTitle("EXPLANATION")

        Console.WriteLine("- This is called a NESTED LOOP")
        Console.WriteLine("- A loop inside another loop")

        Console.WriteLine()

        Console.WriteLine("Outer loop:")
        Console.WriteLine("- Controls variable i")
        Console.WriteLine("- Runs from 1 to 3")

        Console.WriteLine()

        Console.WriteLine("Inner loop:")
        Console.WriteLine("- Controls variable j")
        Console.WriteLine("- Runs from 1 to 2")

        Console.WriteLine()

        Console.WriteLine("How it works:")

        Console.WriteLine()
        Console.WriteLine("Step 1:")
        Console.WriteLine("- i = 1")
        Console.WriteLine("- Inner loop runs completely")
        Console.WriteLine("- j = 1")
        Console.WriteLine("- j = 2")

        Console.WriteLine()
        Console.WriteLine("Step 2:")
        Console.WriteLine("- i becomes 2")
        Console.WriteLine("- Inner loop starts again")
        Console.WriteLine("- j = 1")
        Console.WriteLine("- j = 2")

        Console.WriteLine()
        Console.WriteLine("Step 3:")
        Console.WriteLine("- i becomes 3")
        Console.WriteLine("- Inner loop runs again")
        Console.WriteLine("- j = 1")
        Console.WriteLine("- j = 2")

        Console.WriteLine()

        Console.WriteLine("Important:")
        Console.WriteLine("- The inner loop completes fully for EACH outer loop iteration")
        Console.WriteLine("- Nested loops are useful for tables, grids, patterns, and matrices")

    End Sub

End Class