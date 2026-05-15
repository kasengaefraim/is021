Public Class ParametersAndArguments
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        Console.WriteLine("PARAMETERS AND ARGUMENTS")
        Console.WriteLine()

        Console.WriteLine("Parameters are variables inside a method definition.")
        Console.WriteLine("Arguments are actual values passed when calling the method.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Sub DisplayName(name As String)")
        Console.WriteLine("    Console.WriteLine(""Hello "" & name)")
        Console.WriteLine("End Sub")

        Console.WriteLine()
        Console.WriteLine("Call:")
        Console.WriteLine("DisplayName(""John"")")


        Console.WriteLine()

        Console.WriteLine("EXPLANATION:")
        Console.WriteLine()

        WriteTitle("1. name As String  is the PARAMETER")
        Console.WriteLine("  (This is defined inside the method)")
        Console.WriteLine("  (It is a placeholder for incoming data)")

        Console.WriteLine()

        WriteTitle("2. ""John"" is the ARGUMENT")
        Console.WriteLine("  (This is the actual value passed into the method)")
        Console.WriteLine("  (It replaces the parameter when method runs)")

        Console.WriteLine()

        Console.WriteLine("HOW IT WORKS:")
        Console.WriteLine("- DisplayName(""John"") is called")
        Console.WriteLine("- VB.NET assigns: name = ""John""")
        Console.WriteLine("- Then executes: Console.WriteLine(""Hello John"")")

        Console.WriteLine()

        Console.WriteLine("OUTPUT:")
        DisplayName("John")

    End Sub

    Sub DisplayName(name As String)
        Console.WriteLine("Hello " & name)
    End Sub

End Class