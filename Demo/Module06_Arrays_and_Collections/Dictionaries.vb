Public Class Dictionaries
    Implements ISlide

    Public Sub Show() Implements ISlide.Show
        Console.WriteLine("===================================")
        Console.WriteLine(" MAPS (DICTIONARY IN VB.NET)")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("A Dictionary stores data in KEY → VALUE pairs.")
        Console.WriteLine("It is also called a MAP in other languages.")
        Console.WriteLine()

        Console.WriteLine("Example:")
        Console.WriteLine()

        Console.WriteLine("Dim person As New Dictionary(Of String, String)")
        Console.WriteLine("person.Add(""name"", ""John"")")
        Console.WriteLine("person.Add(""city"", ""Dar"")")
        Console.WriteLine()

        Dim person As New Dictionary(Of String, String)

        person.Add("name", "John")
        person.Add("city", "Dar")
        person.Add("job", "Developer")

        Console.WriteLine("===================================")
        Console.WriteLine(" ACCESSING VALUES")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("Use the key instead of index:")
        Console.WriteLine("person(""name"") = " & person("name"))
        Console.WriteLine("person(""city"") = " & person("city"))
        Console.WriteLine("person(""job"") = " & person("job"))
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" LOOPING THROUGH A DICTIONARY")
        Console.WriteLine("===================================")
        Console.WriteLine()

        For Each item In person
            Console.WriteLine(item.Key & " → " & item.Value)
        Next

        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" CHECK IF KEY EXISTS")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("ContainsKey(""name"") = " & person.ContainsKey("name"))
        Console.WriteLine("ContainsKey(""age"") = " & person.ContainsKey("age"))
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" SAFE ACCESS (IMPORTANT)")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Dim value As String = ""

        If person.TryGetValue("city", value) Then
            Console.WriteLine("City found: " & value)
        Else
            Console.WriteLine("City not found")
        End If

        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" ADD vs UPDATE")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("Add() → new key only")
        Console.WriteLine("If key exists, it crashes")
        Console.WriteLine()

        Console.WriteLine("To update safely:")
        person("city") = "Arusha"

        Console.WriteLine("Updated city = " & person("city"))
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" REMOVE ITEMS")
        Console.WriteLine("===================================")
        Console.WriteLine()

        person.Remove("job")

        For Each item In person
            Console.WriteLine(item.Key & " → " & item.Value)
        Next

        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" REAL WORLD USE")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("Dictionaries are used for:")
        Console.WriteLine("- User profiles (id → user)")
        Console.WriteLine("- API responses (json-like data)")
        Console.WriteLine("- Settings (key → value)")
        Console.WriteLine("- Fast lookup systems")
        Console.WriteLine()

        Console.WriteLine("===================================")
        Console.WriteLine(" ARRAY vs LIST vs DICTIONARY")
        Console.WriteLine("===================================")
        Console.WriteLine()

        Console.WriteLine("ARRAY:")
        Console.WriteLine("- Fixed size")
        Console.WriteLine("- Index based (0,1,2)")
        Console.WriteLine()

        Console.WriteLine("LIST:")
        Console.WriteLine("- Dynamic size")
        Console.WriteLine("- Index based")
        Console.WriteLine()

        Console.WriteLine("DICTIONARY (MAP):")
        Console.WriteLine("- Key → Value")
        Console.WriteLine("- No numeric index needed")
        Console.WriteLine("- Fast lookup")

        Console.WriteLine()
        Console.WriteLine("===================================")
        Console.WriteLine(" END OF LESSON")
        Console.WriteLine("===================================")

    End Sub
End Class
