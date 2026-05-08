Public Class AccessModifiers

    ' PUBLIC: Accessible from anywhere (any class, any project)
    Public publicValue As String = "I am Public"

    ' PRIVATE: Accessible only inside this class
    Private privateValue As String = "I am Private"

    ' PROTECTED: Accessible inside this class and any class that inherits from it
    Protected protectedValue As String = "I am Protected"

    ' FRIEND: Accessible anywhere within the same project 
    Friend friendValue As String = "I am Friend"

    ' PROTECTED FRIEND: Accessible in same project OR in derived classes (even outside project)
    Protected Friend protectedFriendValue As String = "I am Protected Friend"


    ' METHOD TO SHOW INTERNAL ACCESS (everything works here)
    Public Sub ShowAccessInsideClass()
        Console.WriteLine(publicValue)            ' allowed
        Console.WriteLine(privateValue)           ' allowed
        Console.WriteLine(protectedValue)         ' allowed
        Console.WriteLine(friendValue)            ' allowed
        Console.WriteLine(protectedFriendValue)   ' allowed
    End Sub

End Class

Public Class ChildClass
    Inherits AccessModifiers

    Public Sub ShowAccessInChild()
        Console.WriteLine(publicValue)            ' accessible (public)

        'Console.WriteLine(privateValue)          ' NOT accessible (private)

        Console.WriteLine(protectedValue)         ' accessible (protected)

        Console.WriteLine(friendValue)            ' accessible (same project)

        Console.WriteLine(protectedFriendValue)   ' accessible (protected friend)
    End Sub

End Class

Module TestModule

    Sub Test()
        Dim obj As New AccessModifiers()

        Console.WriteLine(obj.publicValue)           ' accessible

        ' Console.WriteLine(obj.privateValue)        ' NOT accessible

        ' Console.WriteLine(obj.protectedValue)      ' NOT accessible

        Console.WriteLine(obj.friendValue)           ' accessible (same project)

        Console.WriteLine(obj.protectedFriendValue)  ' accessible (same project)

    End Sub

End Module


'| Modifier         | Same Class  | Child Class | Same Project | Outside Project    |
'| ---------------- | ---------- | ----------- | ------------ | ------------------ |
'| Public           | ✔          | ✔          | ✔            | ✔                 |
'| Private          | ✔          | ❌         | ❌           | ❌                |
'| Protected        | ✔          | ✔          | ❌           | ❌                |
'| Friend           | ✔          | ✔          | ✔            | ❌                |
'| Protected Friend | ✔          | ✔          | ✔            | ✔ (if inherited)  |

'Simple Way to Explain It
'Public → open to everyone
'Private → only me
'Protected → me + my children
'Friend → my project/team
'Protected Friend → children + team