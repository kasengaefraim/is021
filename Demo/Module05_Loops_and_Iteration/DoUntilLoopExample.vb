Public Class DoUntilLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("DO UNTIL LOOP")
        Console.WriteLine()

        Console.WriteLine("Repeats UNTIL a condition becomes true.")
        Console.WriteLine()
        Console.WriteLine("Synthax:")
        Console.WriteLine()
        WriteSynthax("Do Until condition")
        WriteSynthax("      code here")
        WriteSynthax("Loop")

        Console.WriteLine()


        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("Dim i As Integer = 1")
        WriteCode("Do Until i > 5")
        WriteCode("    Console.WriteLine(i)")
        WriteCode("    i += 1")
        WriteCode("Loop")

        Console.WriteLine()

        WriteTitle("OUTPUT")
        Dim i As Integer = 1

        Do Until i > 5
            WriteOutput(i.ToString())
            i += 1
        Loop


        Console.WriteLine()

        WriteTitle("EXPLANATION")

        Console.WriteLine("- The variable i starts at 1")
        Console.WriteLine("- DO UNTIL means: repeat the loop UNTIL the condition becomes True")
        Console.WriteLine("- The condition is: i > 5")

        Console.WriteLine()

        Console.WriteLine("At the beginning:")
        Console.WriteLine("- i = 1")
        Console.WriteLine("- Is 1 > 5 ?")
        Console.WriteLine("- No, so the loop continues")

        Console.WriteLine()

        Console.WriteLine("Inside the loop:")
        Console.WriteLine("- Console.WriteLine(i) prints the current value")
        Console.WriteLine("- i += 1 increases i by 1")

        Console.WriteLine()

        Console.WriteLine("Loop process:")
        Console.WriteLine("- First loop  -> i = 1")
        Console.WriteLine("- Second loop -> i = 2")
        Console.WriteLine("- Third loop  -> i = 3")
        Console.WriteLine("- Fourth loop -> i = 4")
        Console.WriteLine("- Fifth loop  -> i = 5")

        Console.WriteLine()

        Console.WriteLine("After printing 5:")
        Console.WriteLine("- i becomes 6")
        Console.WriteLine("- Condition checked: i > 5")
        Console.WriteLine("- 6 > 5 is True")
        Console.WriteLine("- Loop stops")

        Console.WriteLine()

        Console.WriteLine("Important:")
        Console.WriteLine("- DO UNTIL loops continue while condition is False")
        Console.WriteLine("- They stop once the condition becomes True")

        Console.ReadLine()
    End Sub

End Class