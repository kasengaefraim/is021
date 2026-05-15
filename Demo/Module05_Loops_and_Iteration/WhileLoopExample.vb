Public Class WhileLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("WHILE LOOP")
        Console.WriteLine()

        Console.WriteLine("Used when we don't know how many times to repeat.")
        Console.WriteLine()

        Console.WriteLine("Syntax")
        Console.WriteLine()

        WriteSynthax("While condition")
        WriteSynthax("      code here")
        WriteSynthax("End While")

        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("Dim i As Integer = 1")
        Console.WriteLine()

        WriteCode("While i <= 5")
        WriteCode("    Console.WriteLine(i)")
        WriteCode("    i += 1")
        WriteCode("End While")
        Console.WriteLine()


        WriteOutput("Output:")
        Dim i As Integer = 1

        While i <= 5
            WriteOutput(i)
            i += 1
        End While

        Console.WriteLine()

        Console.WriteLine("Explanation:")
        Console.WriteLine("1. i starts at 1")
        Console.WriteLine("2. The loop runs while i is less than or equal to 5")
        Console.WriteLine("3. i += 1 increases i by 1 each loop")
        Console.WriteLine("4. This helps the condition eventually become False")

        Console.WriteLine()

        Console.WriteLine("What does i += 1 mean?")
        Console.WriteLine("It is shorthand for:")
        Console.WriteLine("  i = i + 1")

        Console.WriteLine()

        Console.WriteLine("Without i += 1:")
        Console.WriteLine("1. i would remain 1 forever")
        Console.WriteLine("2. The condition i <= 5 would always be True")
        Console.WriteLine("3. The loop would never stop")

        Console.WriteLine()

        WriteSynthax("This is called an INFINITE LOOP.")
        Console.WriteLine()

        Console.WriteLine("How to avoid infinite loops:")
        Console.WriteLine("1. Always update the loop variable")
        Console.WriteLine("2. Make sure the condition can eventually become False")
        Console.WriteLine("3. Test loop conditions carefully")
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("FOR loops are safer because VB.NET automatically updates the counter.")
        Console.WriteLine("WHILE loops require the programmer to update variables manually.")
        Console.WriteLine("If conditions never become False, an infinite loop occurs.")

    End Sub

End Class