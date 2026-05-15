Module ConsoleHelper

    Public Sub WriteTitle(text As String)
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine(text)
        Console.ResetColor()

    End Sub

    Public Sub WriteSynthax(text As String)
        Console.ForegroundColor = ConsoleColor.Green


        Console.WriteLine(text)
        Console.ResetColor()

    End Sub
    Public Sub WriteCode(text As String)
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine(text)
        Console.ResetColor()

    End Sub
    Public Sub WriteOutput(text As String)
        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine(text)
        Console.ResetColor()

    End Sub
    Public Sub AddVerticalSpace(value As Integer)
        If value < 1 Then Return
        For a = 1 To 3
            Console.WriteLine()
        Next
    End Sub
End Module
