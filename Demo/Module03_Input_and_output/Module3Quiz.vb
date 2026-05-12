Public Class Module3Quiz
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MODULE 3 QUIZ ===")
        Console.WriteLine()

        Dim score As Integer = 0

        Console.WriteLine("Q1: Which method is used for input?")
        Console.WriteLine("A: Console.WriteLine  B: Console.ReadLine")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q2: What symbol joins strings?")
        Console.WriteLine("A: &  B: +")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q3: What does interpolation use?")
        Console.WriteLine("A: $"" ""  B: &")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine($"Your Score: {score}/3")

    End Sub

End Class