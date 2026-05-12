Public Class WhatIsProgramming
    Implements ISlide
    Public Sub Explain() Implements ISlide.Show

        Console.WriteLine("=== WHAT IS PROGRAMMING? ===")
        Console.WriteLine()
        Console.WriteLine("Programming is the process of creating instructions for a computer.")
        Console.WriteLine("These instructions tell the computer what to do step by step.")
        Console.WriteLine()
        Console.WriteLine("Example:")
        Console.WriteLine("- Add two numbers")
        Console.WriteLine("- Display a message")
        Console.WriteLine("- Store data in memory")
        Console.WriteLine()
        Console.WriteLine("Without programming, computers cannot function.")


    End Sub

End Class
