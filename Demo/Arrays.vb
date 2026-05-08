Public Class Arrays

    ' =========================
    ' 1. DECLARATION METHODS
    ' =========================
    Public Sub DeclarationDemo()

        ' Declare with fixed size (0 to 2 = 3 elements)
        Dim items(2) As String

        ' Assign values manually
        items(0) = "Apple"
        items(1) = "Milk"
        items(2) = "Bread"

        ' Declare and initialize directly
        Dim items2 As String() = {"Sugar", "Salt", "Rice"}

        ' Declare then assign
        Dim items3() As String
        items3 = New String() {"Tea", "Coffee"}

        Console.WriteLine("Declaration complete")

    End Sub


    ' =========================
    ' 2. ACCESSING & UPDATING
    ' =========================
    Public Sub AccessDemo()

        Dim items As String() = {"Apple", "Milk", "Bread"}

        ' Access by index
        Console.WriteLine(items(0)) ' Apple

        ' Update value
        items(1) = "Cheese"

        Console.WriteLine(items(1)) ' Cheese

    End Sub


    ' =========================
    ' 3. LOOPING THROUGH ARRAYS
    ' =========================
    Public Sub LoopDemo()

        Dim items As String() = {"Apple", "Milk", "Bread"}

        ' Using FOR (index-based)
        For i As Integer = 0 To items.Length - 1
            Console.WriteLine("Index " & i & ": " & items(i))
        Next

        ' Using FOR EACH (simpler)
        For Each item In items
            Console.WriteLine("Item: " & item)
        Next

    End Sub


    ' =========================
    ' 4. ARRAY PROPERTIES
    ' =========================
    Public Sub PropertiesDemo()

        Dim items As String() = {"Apple", "Milk", "Bread"}

        Console.WriteLine("Length: " & items.Length)

    End Sub


    ' =========================
    ' 5. RESIZING ARRAYS
    ' =========================
    Public Sub ResizeDemo()

        Dim items As String() = {"Apple", "Milk"}

        ' Resize (loses data)
        ReDim items(3)

        ' Assign again
        items(0) = "New Apple"

        ' Resize while preserving data
        ReDim Preserve items(4)

        items(2) = "Bread"
        items(3) = "Butter"

        For Each item In items
            Console.WriteLine(item)
        Next

    End Sub


    ' =========================
    ' 6. MULTI-DIMENSIONAL ARRAYS (TABLE)
    ' =========================
    Public Sub MultiDimensionalDemo()

        ' 2 rows, 2 columns
        Dim prices(1, 1) As Integer

        prices(0, 0) = 500
        prices(0, 1) = 1500
        prices(1, 0) = 2000
        prices(1, 1) = 2500

        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.WriteLine("Price: " & prices(i, j))
            Next
        Next

    End Sub


    ' =========================
    ' 7. ARRAY OF OBJECTS (REAL USE CASE)
    ' =========================
    Public Class Product
        Public Name As String
        Public Price As Decimal
    End Class

    Public Sub ObjectArrayDemo()

        Dim products(1) As Product

        products(0) = New Product With {.Name = "Apple", .Price = 500}
        products(1) = New Product With {.Name = "Milk", .Price = 2000}

        For Each p In products
            Console.WriteLine(p.Name & " - " & p.Price)
        Next

    End Sub


    ' =========================
    ' 8. ARRAY LIMITATIONS
    ' =========================
    Public Sub LimitationsDemo()

        Dim items As String() = {"Apple", "Milk"}

        ' These operations are NOT supported directly:
        ' items.Add("Bread")   ❌
        ' items.Remove("Milk") ❌

        Console.WriteLine("Arrays have fixed size and limited operations")

    End Sub


    ' =========================
    ' 9. PRACTICAL GROCERY EXAMPLE
    ' =========================
    Public Sub GroceryArrayDemo()

        Dim cart As String() = {"Apple", "Milk", "Bread"}
        Dim prices As Decimal() = {500, 2000, 1500}

        Dim total As Decimal = 0

        For i As Integer = 0 To cart.Length - 1
            Console.WriteLine(cart(i) & " = " & prices(i))
            total += prices(i)
        Next

        Console.WriteLine("Total: " & total)

    End Sub


    ' =========================
    ' 10. RUN ALL DEMOS
    ' =========================
    Public Sub RunAll()

        DeclarationDemo()
        AccessDemo()
        LoopDemo()
        PropertiesDemo()
        ResizeDemo()
        MultiDimensionalDemo()
        ObjectArrayDemo()
        LimitationsDemo()
        GroceryArrayDemo()

    End Sub

End Class