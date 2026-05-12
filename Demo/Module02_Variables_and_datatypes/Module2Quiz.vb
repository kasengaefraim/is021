Public Class Module2Quiz
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MODULE 2 QUIZ ===")
        Console.WriteLine()

        Dim score As Integer = 0

        Console.WriteLine("Q1: Can a variable change its value?")
        Console.WriteLine("A: Yes  B: No")
        Dim a = Console.ReadLine()
        If a.ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q2: What data type is text?")
        Console.WriteLine("A: Integer  B: String")
        Dim b = Console.ReadLine()
        If b.ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q3: Which converts to Integer?")
        Console.WriteLine("A: CStr  B: CInt")
        Dim c = Console.ReadLine()
        If c.ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Your Score: " & score & "/3")

        If score = 3 Then
            Console.WriteLine("Excellent! You mastered Module 2.")
        Else
            Console.WriteLine("Revise and try again.")
        End If

    End Sub

End Class