Public Class DecisionMakingIntro
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("DECISION MAKING")
        Console.WriteLine()

        Console.WriteLine("Decision making allows a program to choose different paths based on conditions.")
        Console.WriteLine()


        Console.WriteLine("In real life:")
        Console.WriteLine("- If it rains → take umbrella")
        Console.WriteLine("- If it is dark → switch on lights")
        Console.WriteLine()

        Console.WriteLine("In VB.NET, we use:")
        Console.WriteLine("- If...Then")
        Console.WriteLine("- If...Then...Else")
        Console.WriteLine("- ElseIf")
        Console.WriteLine("- Select Case")

    End Sub

End Class