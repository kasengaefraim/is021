Public Class MultiDimensionalArray
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("MULTI-DIMENSIONAL ARRAYS")
        Console.WriteLine()

        Console.WriteLine("A multi-dimensional array stores data in rows and columns (like a table).")
        Console.WriteLine()

        Console.WriteLine("Example declaration:")
        Console.WriteLine("Dim matrix(1, 1) As Integer")
        Console.WriteLine()

        Console.WriteLine("This creates a 2x2 grid (NOT 1x1):")
        Console.WriteLine("Rows: 0 to 1")
        Console.WriteLine("Columns: 0 to 1")
        Console.WriteLine()

        Dim matrix(1, 1) As Integer

        matrix(0, 0) = 1
        matrix(0, 1) = 2
        matrix(1, 0) = 3
        matrix(1, 1) = 4

        Console.WriteLine("Accessing values:")
        Console.WriteLine("matrix(0,0) = " & matrix(0, 0))
        Console.WriteLine("matrix(0,1) = " & matrix(0, 1))
        Console.WriteLine("matrix(1,0) = " & matrix(1, 0))
        Console.WriteLine("matrix(1,1) = " & matrix(1, 1))
        Console.WriteLine()

        Console.WriteLine("Printing matrix using loops:")
        WriteCode("For i As Integer = 0 To 1")
        WriteCode("    For j As Integer = 0 To 1")
        WriteCode("        Console.Write(matrix(i, j) & "" "")")
        WriteCode("    Next")
        WriteCode("    Console.WriteLine()")
        WriteCode("Next")
        Console.WriteLine()
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.Write(matrix(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()

        WriteTitle("WHAT DOES Dim matrix(1,3) MEAN?")

        Console.WriteLine()

        Console.WriteLine("It creates a 2 x 4 array:")
        Console.WriteLine("Rows: 0 to 1")
        Console.WriteLine("Columns: 0 to 3")
        Console.WriteLine()


        WriteCode("Dim matrix2(1, 3) As Integer")

        WriteCode("matrix2(0, 0) = 10")
        WriteCode("matrix2(0, 1) = 20")
        WriteCode("matrix2(0, 2) = 30")
        WriteCode("matrix2(0, 3) = 40")
        Console.WriteLine()
        WriteCode("matrix2(1, 0) = 50")
        WriteCode("matrix2(1, 1) = 60")
        WriteCode("matrix2(1, 2) = 70")
        WriteCode("matrix2(1, 3) = 80")

        Console.WriteLine("Matrix output:")
        WriteCode("For i As Integer = 0 To 1")
        WriteCode("    For j As Integer = 0 To 3")
        WriteCode("        Console.Write(matrix2(i, j) & "" "")")
        WriteCode("    Next")
        WriteCode("    Console.WriteLine()")
        WriteCode("Next")
        Console.WriteLine()

        Dim matrix2(1, 3) As Integer

        matrix2(0, 0) = 10
        matrix2(0, 1) = 20
        matrix2(0, 2) = 30
        matrix2(0, 3) = 40

        matrix2(1, 0) = 50
        matrix2(1, 1) = 60
        matrix2(1, 2) = 70
        matrix2(1, 3) = 80

        Console.WriteLine("Matrix output:")
        For i As Integer = 0 To 1
            For j As Integer = 0 To 3
                Console.Write(matrix2(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()

        WriteTitle("DYNAMIC ARRAYS USING ReDim")

        Console.WriteLine()

        Console.WriteLine("ReDim is used to resize arrays at runtime.")
        Console.WriteLine("BUT it resets data unless you use Preserve.")
        Console.WriteLine()

        Dim numbers() As Integer
        Console.WriteLine("Dim numbers() As Integer")


        Console.WriteLine("Initial array declared (empty).")

        ReDim numbers(2)
        numbers(0) = 10
        numbers(1) = 20
        numbers(2) = 30
        Console.WriteLine()

        WriteCode("ReDim numbers(2)")
        WriteCode("numbers(0) = 10")
        WriteCode("numbers(1) = 20")
        WriteCode("numbers(2) = 30")

        Console.WriteLine("After first ReDim:")
        PrintArray(numbers)

        Console.WriteLine()
        Console.WriteLine("Resizing WITHOUT Preserve (data will be lost):")
        ReDim numbers(4)

        numbers(3) = 40
        numbers(4) = 50

        WriteCode("ReDim numbers(4)")
        Console.WriteLine()
        WriteCode("numbers(3) = 40")
        WriteCode("numbers(4) = 50")

        PrintArray(numbers)

        Console.WriteLine()

        WriteTitle("USING ReDim Preserve")

        Console.WriteLine()

        Dim data() As Integer

        ReDim data(2)
        data(0) = 100
        data(1) = 200
        data(2) = 300

        WriteCode("Dim data() As Integer")
        WriteCode("")
        WriteCode("ReDim data(2)")
        WriteCode("data(0) = 100")
        WriteCode("data(1) = 200")
        WriteCode("data(2) = 300")
        Console.WriteLine()

        Console.WriteLine("Original array:")
        PrintArray(data)

        Console.WriteLine()
        Console.WriteLine("Resizing WITH Preserve (data kept):")
        ReDim Preserve data(4)

        data(3) = 400
        data(4) = 500

        WriteCode("ReDim Preserve data(4)")
        WriteCode("")
        WriteCode("data(3) = 400")
        WriteCode("data(4) = 500")

        PrintArray(data)

        Console.WriteLine()

        WriteTitle("IMPORTANT RULE")

        Console.WriteLine()

        Console.WriteLine("With ReDim Preserve, only the LAST dimension can change.")
        Console.WriteLine("Example for 2D arrays:")
        Console.WriteLine()

        Dim grid(,) As Integer

        ReDim grid(1, 1)
        grid(0, 0) = 1
        grid(0, 1) = 2
        grid(1, 0) = 3
        grid(1, 1) = 4

        Console.WriteLine("Original 2D grid:")
        PrintGrid(grid, 1, 1)

        Console.WriteLine()
        Console.WriteLine("Resizing columns using Preserve:")
        ReDim Preserve grid(1, 3)
        WriteCode("ReDim Preserve grid(1, 3)")
        WriteCode("")
        WriteCode("grid(0, 2) = 99")
        WriteCode("grid(0, 3) = 100")
        WriteCode("grid(1, 2) = 77")
        WriteCode("grid(1, 3) = 88")

        grid(0, 2) = 99
        grid(0, 3) = 100
        grid(1, 2) = 77
        grid(1, 3) = 88

        PrintGrid(grid, 1, 3)

        Console.WriteLine()

    End Sub

    Sub PrintArray(arr() As Integer)
        Console.WriteLine()
        Console.WriteLine("Array contents:")
        For Each item In arr
            Console.Write(item & " ")
        Next
        Console.WriteLine()
    End Sub

    Sub PrintGrid(grid(,) As Integer, rows As Integer, cols As Integer)
        Console.WriteLine()
        For i As Integer = 0 To rows
            For j As Integer = 0 To cols
                Console.Write(grid(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub



End Class