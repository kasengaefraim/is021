Public Class ModuleVsClass
End Class


' =========================
' CLASS
' =========================

' A class is a blueprint for creating objects.
Public Class DemoProduct
    Public Name As String
    Public Price As Decimal
End Class

' You must create an instance
' Dim item As New DemoProduct()

' Use when:
' You need multiple objects
' You are modeling real-world entities







' =========================
' MODULE
' =========================
' A Module is a container For Shared code that does Not need objects.

Module Utility
    Public Sub ShowMessage()
        Console.WriteLine("Hello")
    End Sub
End Module

' You don 't need to create an object:
' Utility.ShowMessage()

' Use when:
' You want Global/Shared functions
' No need To create instances