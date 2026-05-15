Public Class OneDimensionalArray
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("ONE-DIMENSIONAL ARRAY")
        Console.WriteLine()


        Console.WriteLine("A one-dimensional array stores values in a SINGLE row.")
        Console.WriteLine("Think of it like a list.")
        Console.WriteLine()

        Console.WriteLine("Example declaration:")
        Console.WriteLine("Dim numbers() As Integer = {10, 20, 30, 40}")
        Console.WriteLine()

        Dim numbers() As Integer = {10, 20, 30, 40}

        WriteTitle("ACCESSING ELEMENTS")

        Console.WriteLine()

        Console.WriteLine("Array indexing starts at 0.")
        Console.WriteLine()

        Console.WriteLine("numbers(0) = " & numbers(0))
        Console.WriteLine("numbers(1) = " & numbers(1))
        Console.WriteLine("numbers(2) = " & numbers(2))
        Console.WriteLine("numbers(3) = " & numbers(3))
        Console.WriteLine()

        WriteTitle("ARRAY STRUCTURE")

        Console.WriteLine()

        Console.WriteLine("Index:   0   1   2   3")
        Console.WriteLine("Value:  10  20  30  40")
        Console.WriteLine()

        Console.WriteLine("Size rule:")
        Console.WriteLine("Dim numbers(3) means 4 elements (0 to 3)")
        Console.WriteLine()

        WriteTitle("LOOPING THROUGH ARRAY")

        Console.WriteLine()

        Console.WriteLine("Using For loop:")
        WriteCode("For i As Integer = 0 To numbers.Length - 1")
        WriteCode("    Console.WriteLine(""Index"" & i &  = & numbers(i))")
        WriteCode("Next")
        Console.WriteLine()
        For i As Integer = 0 To numbers.Length - 1
            Console.WriteLine("Index " & i & " = " & numbers(i))
        Next
        Console.WriteLine()

        Console.WriteLine("Using For Each loop:")
        WriteCode("For Each num In numbers")
        WriteCode("    Console.WriteLine(""Value = "" & num)")
        WriteCode("Next")
        For Each num In numbers
            Console.WriteLine("Value = " & num)
        Next
        Console.WriteLine()

        WriteTitle("ARRAY LENGTH")

        Console.WriteLine()

        Console.WriteLine("Length property gives total elements:")
        WriteCode("numbers.Length = " & "numbers.Length")
        Console.WriteLine("numbers.Length = " & numbers.Length)
        Console.WriteLine()

        Console.WriteLine("Last index is always Length - 1")
        WriteCode("Last index = " & "numbers.Length - 1")
        Console.WriteLine("Last index = " & numbers.Length - 1)
        Console.WriteLine()

        WriteTitle("DECLARING WITHOUT VALUES")

        Console.WriteLine()

        Console.WriteLine("You can declare first then assign:")
        WriteCode("Dim marks(3) As Integer")
        Console.WriteLine()

        Dim marks(3) As Integer

        marks(0) = 50
        marks(1) = 60
        marks(2) = 70
        marks(3) = 80

        Console.WriteLine("marks array:")
        WriteCode("For i As Integer = 0 To 3")
        WriteCode("    Console.WriteLine(""marks(" & "i" & ") = " & "marks(i)"")")
        WriteCode("Next")
        Console.WriteLine()

        For i As Integer = 0 To 3
            Console.WriteLine("marks(" & i & ") = " & marks(i))
        Next
        Console.WriteLine()

        WriteTitle("COMMON OPERATIONS")

        Console.WriteLine()

        Console.WriteLine("1. SUM OF ARRAY")
        WriteCode("Dim sum As Integer = 0")

        WriteCode("For Each n In numbers")
        WriteCode("    sum += n")
        WriteCode("Next")
        Console.WriteLine()

        Dim sum As Integer = 0

        For Each n In numbers
            sum += n
        Next

        Console.WriteLine("Sum = " & sum)
        Console.WriteLine()

        Console.WriteLine("2. FIND MAX VALUE")
        Dim max As Integer = numbers(0)

        For Each n In numbers
            If n > max Then
                max = n
            End If
        Next

        Console.WriteLine("Max = " & max)
        Console.WriteLine()

        Console.WriteLine("3. FIND MIN VALUE")
        Dim min As Integer = numbers(0)

        For Each n In numbers
            If n < min Then
                min = n
            End If
        Next

        Console.WriteLine("Min = " & min)
        Console.WriteLine()

        WriteTitle("ARRAY LIMITATIONS")

        Console.WriteLine()

        Console.WriteLine("Arrays have FIXED SIZE in VB.NET.")
        Console.WriteLine("You cannot directly add/remove items.")
        Console.WriteLine()

        Console.WriteLine("To resize dynamically, you use ReDim:")
        Console.WriteLine("Dim arr() As Integer")
        Console.WriteLine("ReDim arr(4)")
        Console.WriteLine()

        Console.WriteLine("BUT modern VB.NET prefers List(Of T)")
        Console.WriteLine()

        WriteTitle("BEST PRACTICE (MODERN APPROACH)")

        Console.WriteLine()

        Console.WriteLine("Instead of arrays:")
        Console.WriteLine("Dim list As New List(Of Integer)")
        Console.WriteLine("list.Add(10)")
        Console.WriteLine("list.Add(20)")
        Console.WriteLine()

        Console.WriteLine("Lists are dynamic and easier to use.")

    End Sub

End Class