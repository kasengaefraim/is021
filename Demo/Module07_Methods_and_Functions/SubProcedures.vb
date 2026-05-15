Public Class SubProcedures
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("SUB PROCEDURES")
        Console.WriteLine()

        Console.WriteLine("A Sub performs an action but does NOT return a value.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Sub Greet()")
        Console.WriteLine("    Console.WriteLine(""Hello Student!"")")
        Console.WriteLine("End Sub")

        Console.WriteLine()
        Console.WriteLine("Call it like:")
        Console.WriteLine("Greet()")
        Console.WriteLine()
        Console.WriteLine("Output:")
        Greet()

    End Sub

    Sub Greet()
        Console.WriteLine("Hello Student!")
    End Sub

End Class