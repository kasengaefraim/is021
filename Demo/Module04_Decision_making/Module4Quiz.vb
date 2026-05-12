Public Class Module4Quiz
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MODULE 4 QUIZ ===")
        Console.WriteLine()

        Dim score As Integer = 0

        Console.WriteLine("Q1: Which statement is used for multiple conditions?")
        Console.WriteLine("A: If  B: ElseIf  C: Select Case")
        If Console.ReadLine().ToUpper() = "C" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q2: What runs when condition is false in IF?")
        Console.WriteLine("A: Else  B: Then")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q3: IF inside IF is called?")
        Console.WriteLine("A: Loop  B: Nested IF")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine($"Score: {score}/3")

        If score = 3 Then
            Console.WriteLine("Excellent!")
        Else
            Console.WriteLine("Revise Module 4.")
        End If

    End Sub

End Class