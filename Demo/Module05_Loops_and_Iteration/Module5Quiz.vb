Public Class Module5Quiz
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MODULE 5 QUIZ ===")
        Console.WriteLine()

        Dim score As Integer = 0

        Console.WriteLine("Q1: Which loop is best when number of iterations is known?")
        Console.WriteLine("A: For  B: While")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q2: Which loop runs at least once?")
        Console.WriteLine("A: While  B: Do While")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q3: Loop inside loop is called?")
        Console.WriteLine("A: Nested loop  B: Infinite loop")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine($"Score: {score}/3")

        If score = 3 Then
            Console.WriteLine("Excellent understanding of loops!")
        Else
            Console.WriteLine("Revise loops and try again.")
        End If

    End Sub

End Class