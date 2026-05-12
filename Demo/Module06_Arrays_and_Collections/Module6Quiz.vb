Public Class Module6Quiz
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MODULE 6 QUIZ ===")
        Console.WriteLine()

        Dim score As Integer = 0

        Console.WriteLine("Q1: Arrays store:")
        Console.WriteLine("A: One value  B: Multiple values")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q2: Array index starts from:")
        Console.WriteLine("A: 1  B: 0")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q3: Which is dynamic?")
        Console.WriteLine("A: Array  B: List")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine($"Score: {score}/3")

        If score = 3 Then
            Console.WriteLine("Excellent understanding of collections!")
        Else
            Console.WriteLine("Review arrays and lists.")
        End If

    End Sub

End Class