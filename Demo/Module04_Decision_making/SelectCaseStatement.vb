Public Class SelectCaseStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("SELECT CASE")
        Console.WriteLine()

        Console.WriteLine("Used when checking one variable against many values.")
        Console.WriteLine()

        Console.WriteLine("Its synthax is")
        Console.WriteLine()
        WriteSynthax("Select Case variable")
        WriteSynthax("    Case value1")
        WriteSynthax("          code here")
        WriteSynthax("    Case value2")
        WriteSynthax("          code here")
        WriteSynthax("    Case Else")
        WriteSynthax("        ' default block")
        WriteSynthax("End Select")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        WriteCode("Dim day As Integer = 3")
        Console.WriteLine()

        WriteCode("Select Case day")
        WriteCode("    Case 1")
        WriteCode("        Console.WriteLine(""Monday"")")
        WriteCode("    Case 2")
        WriteCode("        Console.WriteLine(""Tuesday"")")
        WriteCode("    Case Else")
        WriteCode("        Console.WriteLine(""Invalid day"")")
        WriteCode("End Select")
        Console.WriteLine()

        WriteOutput("Output: ")
        Dim day As Integer = 3
        Select Case day
            Case 1
                Console.WriteLine("Monday")
            Case 2
                Console.WriteLine("Tuesday")
            Case Else
                Console.WriteLine("Invalid day")
        End Select
        Console.WriteLine()

    End Sub

End Class