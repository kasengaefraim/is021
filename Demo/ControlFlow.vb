Public Class ControlFlow

    ' =========================
    ' SELECTION (If, ElseIf, Select Case)
    ' =========================
    Public Sub CheckProduct(price As Decimal, stock As Integer)

        Dim category As String = "Fruit"
        Dim isAvailable As Boolean = (stock > 0)

        ' =========================
        ' 1. BASIC IF
        ' =========================
        If stock > 0 Then
            Console.WriteLine("Item is available")
        End If


        ' =========================
        ' 2. IF...ELSE
        ' =========================
        If stock > 0 Then
            Console.WriteLine("Available")
        Else
            Console.WriteLine("Out of stock")
        End If


        ' =========================
        ' 3. IF...ELSEIF...ELSE
        ' =========================
        If price > 2000 Then
            Console.WriteLine("Expensive item")
        ElseIf price > 1000 Then
            Console.WriteLine("Moderate item")
        Else
            Console.WriteLine("Cheap item")
        End If


        ' =========================
        ' 4. USING NOT (Negation)
        ' =========================
        If Not isAvailable Then
            Console.WriteLine("Item is NOT available")
        End If

        ' Same as:
        If stock <= 0 Then
            Console.WriteLine("Out of stock (alternative check)")
        End If


        ' =========================
        ' 5. COMBINED CONDITIONS (And / Or)
        ' =========================
        If stock > 0 And price > 1000 Then
            Console.WriteLine("Available and valuable item")
        End If

        If stock = 0 Or price = 0 Then
            Console.WriteLine("Invalid product state")
        End If


        ' =========================
        ' 6. NESTED IF
        ' =========================
        If stock > 0 Then
            If price > 2000 Then
                Console.WriteLine("Premium available item")
            End If
        End If


        ' =========================
        ' 7. SELECT CASE (Basic)
        ' =========================
        Select Case category
            Case "Fruit"
                Console.WriteLine("Fresh produce section")
            Case "Beverage"
                Console.WriteLine("Drinks section")
            Case Else
                Console.WriteLine("Other category")
        End Select


        ' =========================
        ' 8. SELECT CASE WITH MULTIPLE VALUES
        ' =========================
        Select Case category
            Case "Fruit", "Vegetable"
                Console.WriteLine("Healthy foods")
            Case "Beverage", "Juice"
                Console.WriteLine("Drinks")
            Case Else
                Console.WriteLine("Misc items")
        End Select


        ' =========================
        ' 9. SELECT CASE WITH CONDITIONS
        ' =========================
        Select Case price
            Case Is > 2000
                Console.WriteLine("Expensive (Select Case)")
            Case Is > 1000
                Console.WriteLine("Moderate (Select Case)")
            Case Else
                Console.WriteLine("Cheap (Select Case)")
        End Select


        ' =========================
        ' 10. SELECT CASE WITH RANGE
        ' =========================
        Select Case price
            Case 0 To 1000
                Console.WriteLine("Budget range")
            Case 1001 To 2000
                Console.WriteLine("Mid range")
            Case Else
                Console.WriteLine("High end")
        End Select

    End Sub


    ' =========================
    ' ITERATION (Loops)
    ' =========================
    Public Sub ProcessCart()

        Dim cart As New List(Of Decimal) From {500, 1500, 2500}

        ' FOR EACH (Best for collections)
        For Each price In cart
            Console.WriteLine("Item price: " & price)
        Next

        ' FOR LOOP (Fixed count)
        For i As Integer = 1 To 3
            Console.WriteLine("Processing item #" & i)
        Next

        ' WHILE LOOP (Condition-based)
        Dim stock As Integer = 3

        While stock > 0
            Console.WriteLine("Selling item, remaining: " & stock)
            stock -= 1
        End While

        ' DO WHILE (Runs at least once)
        Dim input As String

        Do
            Console.WriteLine("Enter item name (type 'exit' to stop):")
            input = Console.ReadLine()
        Loop While input <> "exit"

    End Sub


    ' =========================
    ' BRANCHING (Exit, Continue)
    ' =========================
    Public Sub BranchingExample()

        ' EXIT FOR (Break loop)
        For i As Integer = 1 To 10
            If i = 5 Then
                Exit For
            End If
            Console.WriteLine("Number: " & i)
        Next

        ' CONTINUE FOR (Skip iteration)
        For i As Integer = 1 To 5
            If i = 3 Then
                Continue For
            End If
            Console.WriteLine("Skipping 3, current: " & i)
        Next

    End Sub


    ' =========================
    ' FULL DEMO (Combining Everything)
    ' =========================
    Public Sub RunDemo()

        Dim prices As New List(Of Decimal) From {500, 1200, 2500}
        Dim total As Decimal = 0

        For Each price In prices

            ' Decision making inside loop
            If price > 2000 Then
                Console.WriteLine("Premium item detected")
            ElseIf price > 1000 Then
                Console.WriteLine("Mid-range item")
            Else
                Console.WriteLine("Budget item")
            End If

            total += price

        Next

        Console.WriteLine("Total cart value: " & total)

    End Sub

End Class