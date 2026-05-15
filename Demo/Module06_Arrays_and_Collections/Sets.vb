Public Class Sets
    Implements ISlide

    Public Sub Show() Implements ISlide.Show
        Console.WriteLine("===================================")
        Console.WriteLine(" SETS (HashSet) IN VB.NET")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("A Set stores UNIQUE values only.")
        Console.WriteLine("Duplicate values are automatically ignored.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim numbers As New HashSet(Of Integer)")
        Console.WriteLine("numbers.Add(10)")
        Console.WriteLine("numbers.Add(20)")
        Console.WriteLine("numbers.Add(10)")
        Console.WriteLine()

        Dim numbers As New HashSet(Of Integer)

        numbers.Add(10)
        numbers.Add(20)
        numbers.Add(10)
        numbers.Add(30)

        Console.WriteLine("===================================")
        Console.WriteLine(" DISPLAYING VALUES")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("Notice duplicate 10 appears only once:")
        Console.WriteLine()

        For Each num In numbers
            Console.WriteLine(num)
        Next

        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" CHECKING IF VALUE EXISTS")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("Contains(20) = " & numbers.Contains(20))
        Console.WriteLine("Contains(50) = " & numbers.Contains(50))
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" REMOVING VALUES")
        Console.WriteLine("===================================")
        Console.WriteLine()

        numbers.Remove(20)

        Console.WriteLine("After removing 20:")

        For Each num In numbers
            Console.WriteLine(num)
        Next

        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" COUNT")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("numbers.Count = " & numbers.Count)
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" CLEARING SET")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Dim tempSet As New HashSet(Of String)

        tempSet.Add("A")
        tempSet.Add("B")

        Console.WriteLine("Before Clear = " & tempSet.Count)

        tempSet.Clear()

        Console.WriteLine("After Clear = " & tempSet.Count)
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" REAL WORLD USES")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("Sets are useful for:")
        Console.WriteLine("- Preventing duplicates")
        Console.WriteLine("- Fast searching")
        Console.WriteLine("- Tags")
        Console.WriteLine("- User permissions")
        Console.WriteLine("- Unique IDs")
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" LIST vs SET")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("LIST:")
        Console.WriteLine("- Allows duplicates")
        Console.WriteLine("- Ordered")
        Console.WriteLine("- Uses indexes")
        Console.WriteLine()

        Console.WriteLine("SET:")
        Console.WriteLine("- No duplicates")
        Console.WriteLine("- Faster lookup")
        Console.WriteLine("- No indexes")
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" IMPORTANT DIFFERENCE")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("List:")
        Console.WriteLine("names(0)")
        Console.WriteLine()

        Console.WriteLine("Set:")
        Console.WriteLine("No numeric indexes available.")
        Console.WriteLine("You loop through values instead.")
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" COMMON SET OPERATIONS")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Dim setA As New HashSet(Of Integer) From {1, 2, 3, 4}
        Dim setB As New HashSet(Of Integer) From {3, 4, 5, 6}

        Console.WriteLine("Set A:")
        PrintSet(setA)

        Console.WriteLine("Set B:")
        PrintSet(setB)

        Console.WriteLine()

        Console.WriteLine("UNION (combine all unique values):")

        Dim unionSet As New HashSet(Of Integer)(setA)
        unionSet.UnionWith(setB)

        PrintSet(unionSet)
        Console.WriteLine()

        Console.WriteLine("INTERSECTION (common values):")

        Dim intersectSet As New HashSet(Of Integer)(setA)
        intersectSet.IntersectWith(setB)

        PrintSet(intersectSet)
        Console.WriteLine()

        Console.WriteLine("DIFFERENCE (values in A not in B):")

        Dim diffSet As New HashSet(Of Integer)(setA)
        diffSet.ExceptWith(setB)

        PrintSet(diffSet)
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" ARRAY vs LIST vs DICTIONARY vs SET")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("ARRAY:")
        Console.WriteLine("- Fixed size")
        Console.WriteLine("- Index based")
        Console.WriteLine()

        Console.WriteLine("LIST:")
        Console.WriteLine("- Dynamic")
        Console.WriteLine("- Allows duplicates")
        Console.WriteLine()

        Console.WriteLine("DICTIONARY:")
        Console.WriteLine("- Key → Value")
        Console.WriteLine("- Fast lookup")
        Console.WriteLine()

        Console.WriteLine("SET:")
        Console.WriteLine("- Unique values only")
        Console.WriteLine("- No duplicates")
        Console.WriteLine("- Very fast existence checking")
    End Sub
    Sub PrintSet(setData As HashSet(Of Integer))

        For Each item In setData
            Console.Write(item & " ")
        Next

        Console.WriteLine()

    End Sub
End Class
