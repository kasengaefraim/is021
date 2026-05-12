Public Class ArraysIntro
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== ARRAYS INTRODUCTION ===")
        Console.WriteLine()

        Console.WriteLine("An array is used to store multiple values in one variable.")
        Console.WriteLine()

        Console.WriteLine("Instead of:")
        Console.WriteLine("Dim a1 As Integer = 10")
        Console.WriteLine("Dim a2 As Integer = 20")
        Console.WriteLine()

        Console.WriteLine("We use:")
        Console.WriteLine("Dim numbers() As Integer = {10, 20, 30}")

    End Sub

End Class