Public Class Collections


    ' =========================
    ' 1. LIST (Ordered collection)
    ' =========================
    Public Sub ListDemo()

        ' Creating a list
        Dim items As New List(Of String)


        ' Adding items
        items.Add("Apple")
        items.Add("Milk")
        items.Add("Bread")
        items.Add("Apple") ' duplicates allowed

        ' Access by index
        Console.WriteLine(items(0)) ' Apple

        ' Insert at position
        items.Insert(1, "Butter")

        ' Remove item
        items.Remove("Milk")

        ' Remove by index
        items.RemoveAt(0)

        ' Count
        Console.WriteLine("Total items: " & items.Count)

        ' Check existence
        Console.WriteLine(items.Contains("Bread"))

        ' Loop through list
        For Each item In items
            Console.WriteLine(item)
        Next

        ' Sorting
        items.Sort()

        ' Reverse
        items.Reverse()

        ' Clear all
        ' items.Clear()

    End Sub


    ' =========================
    ' 2. LIST WITH OBJECTS (REAL USE CASE)
    ' =========================
    Public Class Product
        Public Name As String
        Public Price As Decimal
    End Class

    Public Sub ListOfObjectsDemo()

        Dim products As New List(Of Product)

        products.Add(New Product With {.Name = "Apple", .Price = 500})
        products.Add(New Product With {.Name = "Milk", .Price = 2000})

        ' Loop through objects
        For Each p In products
            Console.WriteLine(p.Name & " - " & p.Price)
        Next

    End Sub


    ' =========================
    ' 3. DICTIONARY (Key-Value / Map)
    ' =========================
    Public Sub DictionaryDemo()

        ' Create dictionary
        Dim products As New Dictionary(Of String, Decimal)

        ' Add key-value pairs
        products.Add("Apple", 500)
        products.Add("Milk", 2000)
        products.Add("Bread", 1500)

        ' Access value using key
        Console.WriteLine(products("Milk"))

        ' Update value
        products("Milk") = 2500

        ' Check if key exists
        If products.ContainsKey("Apple") Then
            Console.WriteLine("Apple exists")
        End If

        ' Remove item
        products.Remove("Bread")

        ' Loop through dictionary
        For Each item In products
            Console.WriteLine(item.Key & ": " & item.Value)
        Next

        ' Count
        Console.WriteLine("Total: " & products.Count)

        ' Get all keys
        For Each key In products.Keys
            Console.WriteLine("Key: " & key)
        Next

        ' Get all values
        For Each value In products.Values
            Console.WriteLine("Value: " & value)
        Next

        ' Clear dictionary
        ' products.Clear()

    End Sub


    ' =========================
    ' 4. HASHSET (Unique values only)
    ' =========================
    Public Sub HashSetDemo()

        Dim categories As New HashSet(Of String)

        ' Add items
        categories.Add("Fruit")
        categories.Add("Dairy")
        categories.Add("Fruit") ' duplicate ignored

        ' Check existence
        Console.WriteLine(categories.Contains("Fruit"))

        ' Remove item
        categories.Remove("Dairy")

        ' Count
        Console.WriteLine("Total categories: " & categories.Count)

        ' Loop
        For Each category In categories
            Console.WriteLine(category)
        Next

        ' Clear
        ' categories.Clear()

    End Sub


    ' =========================
    ' 5. COLLECTION OPERATIONS (ADVANCED)
    ' =========================
    Public Sub AdvancedOperations()

        Dim numbers As New List(Of Integer) From {1, 2, 3, 4, 5}

        ' Find items (LINQ)
        Dim evenNumbers = numbers.Where(Function(n) n Mod 2 = 0)

        ' Convert to list
        Dim evenList = evenNumbers.ToList()

        ' Sum
        Dim total = numbers.Sum()

        ' Max / Min
        Dim maxVal = numbers.Max()
        Dim minVal = numbers.Min()

        Console.WriteLine("Sum: " & total)
        Console.WriteLine("Max: " & maxVal)
        Console.WriteLine("Min: " & minVal)

    End Sub


    ' =========================
    ' 6. FULL GROCERY SYSTEM USING COLLECTIONS
    ' =========================
    Public Sub GroceryCollectionsDemo()

        ' List of product names (cart)
        Dim cart As New List(Of String) From {"Apple", "Milk", "Bread"}

        ' Dictionary for prices
        Dim prices As New Dictionary(Of String, Decimal) From {
            {"Apple", 500},
            {"Milk", 2000},
            {"Bread", 1500}
        }

        ' HashSet for categories
        Dim categories As New HashSet(Of String) From {"Fruit", "Dairy", "Bakery"}

        Dim total As Decimal = 0

        For Each item In cart

            If prices.ContainsKey(item) Then
                total += prices(item)
            End If

        Next

        Console.WriteLine("Cart Total: " & total)

        ' Show categories
        For Each cat In categories
            Console.WriteLine("Category: " & cat)
        Next

    End Sub


    ' =========================
    ' RUN ALL DEMOS
    ' =========================
    Public Sub RunAll()

        ListDemo()
        ListOfObjectsDemo()
        DictionaryDemo()
        HashSetDemo()
        AdvancedOperations()
        GroceryCollectionsDemo()

    End Sub


End Class