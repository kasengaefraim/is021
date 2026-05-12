Public Class AlgorithmsAndFlowcharts
    Implements ISlide
    Public Sub Explain() Implements ISlide.Show

        Console.WriteLine("=== ALGORITHMS AND FLOWCHARTS ===")
        Console.WriteLine()

        Console.WriteLine("An ALGORITHM is a step-by-step solution to a problem.")
        Console.WriteLine()

        Console.WriteLine("Example Algorithm (Add two numbers):")
        Console.WriteLine("1. Start")
        Console.WriteLine("2. Input number A")
        Console.WriteLine("3. Input number B")
        Console.WriteLine("4. Add A + B")
        Console.WriteLine("5. Display result")
        Console.WriteLine("6. End")
        Console.WriteLine()

        Console.WriteLine("A FLOWCHART is a diagram that visually represents an algorithm.")
        Console.WriteLine("It uses symbols like:")
        Console.WriteLine("- Oval: Start/End")
        Console.WriteLine("- Rectangle: Process")
        Console.WriteLine("- Parallelogram: Input/Output")

    End Sub
End Class
