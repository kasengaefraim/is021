Public Class Module8Quiz
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== MODULE 8 QUIZ ===")
        Console.WriteLine()

        Dim score As Integer = 0

        Console.WriteLine("Q1: Class is?")
        Console.WriteLine("A: Object  B: Blueprint")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q2: Object is?")
        Console.WriteLine("A: Instance of class  B: Function")
        If Console.ReadLine().ToUpper() = "A" Then score += 1

        Console.WriteLine()

        Console.WriteLine("Q3: Inheritance means?")
        Console.WriteLine("A: Copy code  B: Reuse class features")
        If Console.ReadLine().ToUpper() = "B" Then score += 1

        Console.WriteLine()

        Console.WriteLine($"Score: {score}/3")

        If score = 3 Then
            Console.WriteLine("Excellent OOP understanding!")
        Else
            Console.WriteLine("Revise OOP concepts.")
        End If

    End Sub

End Class