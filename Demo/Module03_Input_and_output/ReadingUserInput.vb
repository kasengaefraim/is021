Public Class ReadingUserInput
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== READING USER INPUT ===")
        Console.WriteLine()

        Console.WriteLine("In VB.NET, we use Console.ReadLine() to get input from the user.")
        Console.WriteLine()

        Console.WriteLine("Example Program:")
        Console.WriteLine()

        Console.WriteLine("Console.Write(""Enter your name: "")")
        Console.WriteLine("Dim name As String = Console.ReadLine()")
        Console.WriteLine("Console.WriteLine(""Your name is "" & name)")
        Console.WriteLine()

        Console.WriteLine("The program waits until the user types something and presses ENTER.")

    End Sub

End Class