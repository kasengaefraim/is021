Public Class NestedIfStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== NESTED IF ===")
        Console.WriteLine()

        Console.WriteLine("A nested IF is an IF statement inside another IF.")
        Console.WriteLine()

        Console.WriteLine("Its synthax is")
        Console.WriteLine()
        WriteSynthax("If condition1 Then")
        WriteSynthax("    If condition2 Then")
        WriteSynthax("          code here")
        WriteSynthax("    End If")
        WriteSynthax("End If")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("Dim age As Integer = 20")
        WriteCode("Dim hasID As Boolean = True")
        Console.WriteLine()
        WriteCode("If age >= 18 Then")
        WriteCode("    If hasID Then")
        WriteCode("        Console.WriteLine(""Allowed"")")
        WriteCode("    End If")
        WriteCode("End If")
        Console.WriteLine()

        WriteOutput("Output:")
        Dim age As Integer = 20
        Dim hasID As Boolean = True
        If age >= 18 Then
            If hasID Then
                Console.WriteLine("Allowed")
            End If
        End If

    End Sub

End Class