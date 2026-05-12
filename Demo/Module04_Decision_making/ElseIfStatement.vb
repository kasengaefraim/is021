Public Class ElseIfStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== ELSE IF LADDER ===")
        Console.WriteLine()

        Console.WriteLine("Used when we have multiple conditions.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim marks As Integer = 75")
        Console.WriteLine("If marks >= 80 Then")
        Console.WriteLine("    Console.WriteLine(""Grade A"")")
        Console.WriteLine("ElseIf marks >= 60 Then")
        Console.WriteLine("    Console.WriteLine(""Grade B"")")
        Console.WriteLine("Else")
        Console.WriteLine("    Console.WriteLine(""Fail"")")
        Console.WriteLine("End If")

    End Sub

End Class