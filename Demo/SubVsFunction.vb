Public Class SubVsFunction


    ' =========================
    ' Sub (Subroutine)
    ' =========================
    ' 
    ' A Sub() performs an action but does Not return a value.
    Public Sub AddItem(name As String)

        Console.WriteLine("Item added: " & name)
    End Sub

    ' =========================
    ' FUNCTION
    ' =========================
    ' 
    ' A Function() performs an action And returns a value.

    Const price As Decimal = 100 ' acts as Global variable
    Public Function GetTotal(quantity As Integer) As Decimal
        Dim price As Decimal = 98 ' acts as local variable


        Return price * quantity
    End Function
End Class
