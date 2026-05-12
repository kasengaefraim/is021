Public Class ConsoleInputOutput
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== CONSOLE INPUT & OUTPUT ===")
        Console.WriteLine()

        Console.WriteLine("OUTPUT (Console.WriteLine):")
        Console.WriteLine("- Used to display information to the user")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Console.WriteLine(""Hello World"")")
        Console.WriteLine()

        Console.WriteLine("INPUT (Console.ReadLine):")
        Console.WriteLine("- Used to receive data from the user")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine("Dim name As String = Console.ReadLine()")

    End Sub

End Class