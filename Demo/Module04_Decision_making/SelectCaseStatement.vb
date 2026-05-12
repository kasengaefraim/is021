Public Class SelectCaseStatement
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== SELECT CASE ===")
        Console.WriteLine()

        Console.WriteLine("Used when checking one variable against many values.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim day As Integer = 3")
        Console.WriteLine("Select Case day")
        Console.WriteLine("    Case 1")
        Console.WriteLine("        Console.WriteLine(""Monday"")")
        Console.WriteLine("    Case 2")
        Console.WriteLine("        Console.WriteLine(""Tuesday"")")
        Console.WriteLine("    Case Else")
        Console.WriteLine("        Console.WriteLine(""Invalid day"")")
        Console.WriteLine("End Select")

    End Sub

End Class