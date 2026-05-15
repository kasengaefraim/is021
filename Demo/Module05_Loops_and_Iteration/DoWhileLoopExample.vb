Public Class DoWhileLoopExample
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("DO WHILE LOOP")
        Console.WriteLine()

        Console.WriteLine("Runs at least once before checking condition.")

        Console.WriteLine()
        Console.WriteLine("Synthax:")
        Console.WriteLine()
        WriteSynthax("Do")
        WriteSynthax("      code here")
        WriteSynthax("Loop While condition")


        Console.WriteLine()

        Console.WriteLine("Example:")


        WriteCode("Dim i As Integer = 1")
        Console.WriteLine()

        WriteCode("Do")
        WriteCode("    Console.WriteLine(i)")
        WriteCode("    i += 1")
        WriteCode("Loop While i <= 5")

        Console.WriteLine()

        WriteTitle("OUTPUT")

        Dim i As Integer = 1

        Do
            WriteOutput(i.ToString())
            i += 1
        Loop While i <= 5

        Console.WriteLine()

        WriteTitle("EXPLANATION")


        Console.WriteLine("1) The variable i starts at 1")
        Console.WriteLine("2) The DO block runs first before checking the condition")
        Console.WriteLine("3) Console.WriteLine(i) displays the current value of i")
        Console.WriteLine("4) i += 1 increases i by 1 after each loop")

        Console.WriteLine()

        Console.WriteLine("Loop process:")
        Console.WriteLine("- First loop  -> i = 1")
        Console.WriteLine("- Second loop -> i = 2")
        Console.WriteLine("- Third loop  -> i = 3")
        Console.WriteLine("- Fourth loop -> i = 4")
        Console.WriteLine("- Fifth loop  -> i = 5")

        Console.WriteLine()

        Console.WriteLine("After printing 5:")
        Console.WriteLine("1) i becomes 6")
        Console.WriteLine("2) Condition checked: i <= 5")
        Console.WriteLine("3) 6 <= 5 is False")
        Console.WriteLine("4) Loop stops")

        Console.WriteLine()

        Console.WriteLine("Important:")
        Console.WriteLine("1) DO WHILE loops execute at least once")
        Console.WriteLine("2) Because the condition is checked AFTER the block runs")

    End Sub

End Class