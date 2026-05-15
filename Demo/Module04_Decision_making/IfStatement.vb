Public Class IfStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("IF STATEMENT")
        Console.WriteLine()

        Console.WriteLine("Used when we want to execute code only if a condition is true.")
        Console.WriteLine()
        Console.WriteLine("Its synthax is")
        Console.WriteLine()
        WriteSynthax("IF condition Then")
        WriteSynthax("      code here")
        WriteSynthax("End If")
        Console.WriteLine()
        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine()
        WriteCode("Dim coursework As Integer = 47")
        WriteCode("If coursework >= 40 Then")
        WriteCode("    Console.WriteLine(""You have passed"")")
        WriteCode("End If")
        Console.WriteLine()

        WriteOutput("Output:")
        Dim coursework As Integer = 47
        If coursework >= 40 Then
            WriteOutput("You have passed")
        End If



    End Sub

End Class