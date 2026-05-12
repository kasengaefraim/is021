Public Class ParametersAndArguments
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("=== PARAMETERS AND ARGUMENTS ===")
        Console.WriteLine()

        Console.WriteLine("Parameters are variables inside a method.")
        Console.WriteLine("Arguments are actual values passed to the method.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Sub DisplayName(name As String)")
        Console.WriteLine("    Console.WriteLine(""Hello "" & name)")
        Console.WriteLine("End Sub")

        Console.WriteLine()
        Console.WriteLine("Call:")
        Console.WriteLine("DisplayName(""John"")")

    End Sub

End Class