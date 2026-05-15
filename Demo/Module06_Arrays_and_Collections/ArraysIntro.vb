Public Class ArraysIntro
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("ARRAYS INTRODUCTION")
        Console.WriteLine()

        Console.WriteLine("An array is used to store multiple values in one variable.")
        Console.WriteLine()

        Console.WriteLine("Instead of:")
        Console.WriteLine("Dim a1 As Integer = 10")
        Console.WriteLine("Dim a2 As Integer = 20")
        Console.WriteLine("Dim a3 As Integer = 30")

        Console.WriteLine()

        Console.WriteLine("We use:")
        Console.WriteLine("Dim numbers() As Integer = {10, 20, 30}")

        Console.WriteLine()

        Console.WriteLine("EXPLANATION:")
        Console.WriteLine("- Arrays store multiple values in one variable")
        Console.WriteLine("- Each value is stored using an INDEX position")
        Console.WriteLine("- Index starts from 0")

        Console.WriteLine()

        Console.WriteLine("ACCESSING BY INDEX:")
        Console.WriteLine()

        Dim numbers() As Integer = {10, 20, 30}

        Console.WriteLine("numbers(0) = " & numbers(0))
        Console.WriteLine("numbers(1) = " & numbers(1))
        Console.WriteLine("numbers(2) = " & numbers(2))

        Console.WriteLine()

        Console.WriteLine("EXPLANATION:")
        Console.WriteLine("- numbers(0) gets the FIRST value = 10")
        Console.WriteLine("- numbers(1) gets the SECOND value = 20")
        Console.WriteLine("- numbers(2) gets the THIRD value = 30")

        Console.WriteLine()

        Console.WriteLine("OUTPUT:")
        Console.WriteLine()


        For Each num In numbers
            Console.WriteLine(num)
        Next



        WriteTitle("ARRAY DECLARATION + ASSIGNMENT")

        Console.WriteLine()

        Console.WriteLine("1. DECLARE EMPTY ARRAY (NO SIZE YET)")
        Console.WriteLine()

        Dim numberdemo() As Integer
        WriteCode("Dim numbers() As Integer")

        Console.WriteLine("Array declared but NOT initialized yet.")
        Console.WriteLine("Must use ReDim before using it.")
        Console.WriteLine()

        ReDim numberdemo(3)
        WriteCode("ReDim numbers(3)")
        Console.WriteLine()

        Console.WriteLine("After ReDim numbers(3):")

        WriteCode("numbers(0) = 10")
        WriteCode("numbers(1) = 20")
        WriteCode("numbers(2) = 30")
        WriteCode("numbers(3) = 40")
        Console.WriteLine()

        numberdemo(0) = 10
        numberdemo(1) = 20
        numberdemo(2) = 30
        numberdemo(3) = 40

        PrintArray(numberdemo)

        Console.WriteLine()


        Console.WriteLine("2. DECLARE WITH SIZE DIRECTLY")
        Console.WriteLine()

        Dim marks(3) As Integer
        WriteCode("Dim marks(3) As Integer")
        Console.WriteLine()

        Console.WriteLine("Array automatically has size 4 (0 to 3).")
        Console.WriteLine("Default values are 0.")

        Console.WriteLine()


        marks(0) = 50
        marks(1) = 60
        marks(2) = 70
        marks(3) = 80

        WriteCode("marks(0) = 50")
        WriteCode("marks(1) = 60")
        WriteCode("marks(2) = 70")
        WriteCode("marks(3) = 80")
        Console.WriteLine()

        PrintArray(marks)

        Console.WriteLine()


        Console.WriteLine("3. DECLARE WITH VALUES DIRECTLY")
        Console.WriteLine()

        Dim scores() As Integer = {100, 200, 300, 400}
        WriteCode("Dim scores() As Integer = {100, 200, 300, 400}")
        Console.WriteLine()

        Console.WriteLine("Array created with values already set.")
        PrintArray(scores)

        Console.WriteLine()


        Console.WriteLine("4. DYNAMIC GROWTH USING ReDim Preserve")
        Console.WriteLine()

        Dim dynamicArr() As Integer
        WriteCode("Dim dynamicArr() As Integer")
        Console.WriteLine()

        ReDim dynamicArr(0)
        dynamicArr(0) = 5
        WriteCode("ReDim dynamicArr(0)")
        WriteCode("dynamicArr(0) = 5")
        Console.WriteLine()

        Console.WriteLine("Start:")
        PrintArray(dynamicArr)

        ReDim Preserve dynamicArr(1)
        dynamicArr(1) = 10
        WriteCode("ReDim Preserve dynamicArr(1)")
        WriteCode("dynamicArr(1) = 10")
        Console.WriteLine()

        ReDim Preserve dynamicArr(2)
        dynamicArr(2) = 15
        WriteCode("ReDim Preserve dynamicArr(2)")
        WriteCode("dynamicArr(2) = 15")
        Console.WriteLine()

        Console.WriteLine("After growing dynamically:")
        PrintArray(dynamicArr)

        Console.WriteLine()

        WriteTitle("IMPORTANT RULE")

        Console.WriteLine()

        Console.WriteLine("If array is declared like:")
        Console.WriteLine("Dim arr() As Integer")
        Console.WriteLine("You MUST use ReDim before accessing it.")
        Console.WriteLine()

        Console.WriteLine("Otherwise you get NullReferenceException.")

    End Sub
    Sub PrintArray(arr() As Integer)

        Console.Write("Array: ")

        For Each item In arr
            Console.Write(item & " ")
        Next

        Console.WriteLine()

    End Sub
End Class