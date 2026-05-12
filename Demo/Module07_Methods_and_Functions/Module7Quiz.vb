Public Class Module7Quiz
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MODULE 7 QUIZ ===")
        Console.WriteLine()

        Dim score As Integer = 0

        Console.WriteLine("Q1: Which method returns a value?")
        Console.WriteLine("A: Sub  B: Function")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q2: What keyword returns a value?")
        Console.WriteLine("A: Return  B: End")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q3: Input values passed into methods are called?")
        Console.WriteLine("A: Parameters  B: Variables")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine($"Score: {score}/3")

        If score = 3 Then
            Console.WriteLine("Excellent understanding of methods!")
        Else
            Console.WriteLine("Revise methods and functions.")
        End If

    End Sub

End Class