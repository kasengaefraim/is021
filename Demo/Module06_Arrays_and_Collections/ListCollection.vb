Public Class ListCollection
    Implements ISlide

    Public Sub Show() Implements ISlide.Show

        WriteTitle("LIST COLLECTION")
        Console.WriteLine()

        Console.WriteLine("A List is a dynamic collection that can grow or shrink.")
        Console.WriteLine("Unlike arrays, you don't need to set a fixed size.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim names As New List(Of String)")
        Console.WriteLine("names.Add(""John"")")
        Console.WriteLine("names.Add(""Mary"")")
        Console.WriteLine()

        Dim names As New List(Of String)
        names.Add("John")
        names.Add("Mary")
        names.Add("Peter")


        WriteTitle("ACCESSING ITEMS")

        Console.WriteLine()

        Console.WriteLine("Lists use indexes just like arrays (start at 0).")
        Console.WriteLine()

        Console.WriteLine("names(0) = " & names(0))
        Console.WriteLine("names(1) = " & names(1))
        Console.WriteLine("names(2) = " & names(2))
        Console.WriteLine()


        WriteTitle("LOOPING THROUGH A LIST")

        Console.WriteLine()

        Console.WriteLine("Using For loop:")
        For i As Integer = 0 To names.Count - 1
            Console.WriteLine("Index " & i & " = " & names(i))
        Next
        Console.WriteLine()

        Console.WriteLine("Using For Each loop (preferred):")
        For Each name In names
            Console.WriteLine("Name = " & name)
        Next
        Console.WriteLine()


        WriteTitle("LIST SIZE VS ARRAY LENGTH")

        Console.WriteLine()

        Console.WriteLine("Array uses Length property")
        Console.WriteLine("List uses Count property")
        Console.WriteLine()

        Console.WriteLine("names.Count = " & names.Count)
        Console.WriteLine()


        WriteTitle("ADDING ITEMS")

        Console.WriteLine()

        Console.WriteLine("Add items using Add():")
        names.Add("David")
        names.Add("Alice")

        For Each name In names
            Console.WriteLine(name)
        Next
        Console.WriteLine()


        WriteTitle("INSERTING ITEMS")

        Console.WriteLine()

        Console.WriteLine("Insert allows placing at specific index:")
        names.Insert(1, "Zara")

        For Each name In names
            Console.WriteLine(name)
        Next
        Console.WriteLine()


        WriteTitle("REMOVING ITEMS")

        Console.WriteLine()

        Console.WriteLine("Remove by value:")
        names.Remove("John")

        Console.WriteLine("Remove by index:")
        names.RemoveAt(0)

        For Each name In names
            Console.WriteLine(name)
        Next
        Console.WriteLine()


        WriteTitle("CHECKING ITEMS")

        Console.WriteLine()

        Console.WriteLine("Contains() checks if item exists:")
        Console.WriteLine("Contains Mary? " & names.Contains("Mary"))
        Console.WriteLine("Contains John? " & names.Contains("John"))
        Console.WriteLine()


        WriteTitle("CLEARING LIST")

        Console.WriteLine()

        Console.WriteLine("Clear() removes everything:")
        Dim tempList As New List(Of Integer) From {1, 2, 3, 4, 5}

        Console.WriteLine("Before Clear: " & tempList.Count)
        tempList.Clear()
        Console.WriteLine("After Clear: " & tempList.Count)
        Console.WriteLine()


        WriteTitle("SORTING LIST")

        Console.WriteLine()

        Dim numbers As New List(Of Integer) From {5, 2, 9, 1, 3}

        Console.WriteLine("Before Sort:")
        PrintList(numbers)

        numbers.Sort()

        Console.WriteLine("After Sort:")
        PrintList(numbers)
        Console.WriteLine()


        WriteTitle("LIST vs ARRAY SUMMARY")

        Console.WriteLine()

        Console.WriteLine("ARRAY:")
        Console.WriteLine("- Fixed size")
        Console.WriteLine("- Faster for static data")
        Console.WriteLine("- Uses Length")
        Console.WriteLine()

        Console.WriteLine("LIST:")
        Console.WriteLine("- Dynamic size")
        Console.WriteLine("- Easier to manage")
        Console.WriteLine("- Uses Count")
        Console.WriteLine("- Has Add, Remove, Insert, Clear, Sort")
        Console.WriteLine()


        WriteTitle("WHEN TO USE LISTS")

        Console.WriteLine()

        Console.WriteLine("Use List(Of T) when:")
        Console.WriteLine("- You don't know size in advance")
        Console.WriteLine("- Data changes frequently")
        Console.WriteLine("- You need Add/Remove operations")
        Console.WriteLine()

    End Sub
    Sub PrintList(list As List(Of Integer))
        For Each item In list
            Console.Write(item & " ")
        Next
        Console.WriteLine()
    End Sub
End Class