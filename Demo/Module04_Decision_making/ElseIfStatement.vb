Public Class ElseIfStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("ELSE IF")
        Console.WriteLine()

        Console.WriteLine("Used when we have multiple conditions.")
        Console.WriteLine()

        Console.WriteLine("Its synthax is")
        Console.WriteLine()

        WriteSynthax("If condition1 Then")
        WriteSynthax("      code here")
        WriteSynthax("ElseIf condition2 Then")
        WriteSynthax("      code here")
        WriteSynthax("Else")
        WriteSynthax("    ' default block")
        WriteSynthax("End If")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("Dim marks As Integer = 75")
        Console.WriteLine()
        WriteCode("If marks >= 80 Then")
        WriteCode("    Console.WriteLine(""Grade A"")")
        WriteCode("ElseIf marks >= 60 Then")
        WriteCode("    Console.WriteLine(""Grade B"")")
        WriteCode("Else")
        WriteCode("    Console.WriteLine(""Fail"")")
        WriteCode("End If")
        Console.WriteLine()


        WriteOutput("Output:")
        Dim marks As Integer = 75
        If marks >= 80 Then
            Console.WriteLine("Grade A")
        ElseIf marks >= 60 Then
            Console.WriteLine("Grade B")
        Else
            Console.WriteLine("Fail")
        End If

    End Sub

End Class