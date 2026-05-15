Public Class IfElseStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("IF...ELSE STATEMENT")
        Console.WriteLine()

        Console.WriteLine("Used when we want two possible outcomes.")
        Console.WriteLine()
        Console.WriteLine("Its synthax is")
        Console.WriteLine()

        WriteSynthax("If condition Then")
        WriteSynthax("    ' true block")
        WriteSynthax("Else")
        WriteSynthax("    ' false block")
        WriteSynthax("End If")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("Dim age As Integer = 16")
        Console.WriteLine()
        WriteCode("If age >= 18 Then")
        WriteCode("    Console.WriteLine(""Adult"")")
        WriteCode("Else")
        WriteCode("    Console.WriteLine(""Minor"")")
        WriteCode("End If")
        Console.WriteLine()

        WriteOutput("Output:")
        Dim age As Integer = 16
        If age >= 18 Then
            Console.WriteLine("Adult")
        Else
            Console.WriteLine("Minor")
        End If
    End Sub

End Class