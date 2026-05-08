
'Why Use OOP?
'Makes code easy to understand
'Makes code reusable
'Makes programs easier to maintain
'Helps build large systems efficiently
'Simple Summary
'
'OOP is about:
'Modeling real-world things in code
'Grouping data and behavior together
'Making programs cleaner and more organized

Public Class OOPPrinciples

    ' =========================
    ' 1. ENCAPSULATION
    ' =========================
    ' Hiding data and controlling access using Private + Property
    ' Data is hidden using Private
    ' Access Is controlled using Property

    Public Class Product
        Public Name As String

        Private _price As Decimal   ' Hidden field (cannot be accessed directly)

        Public Property Price As Decimal
            Get
                Return _price
            End Get
            Set(value As Decimal)
                If value >= 0 Then   ' Validation (control)
                    _price = value
                End If
            End Set
        End Property

        Public Quantity As Integer

        Public Function GetTotal() As Decimal
            Return _price * Quantity
        End Function
    End Class


    ' =========================
    ' 2. INHERITANCE
    ' =========================
    ' Reusing Product and extending it
    ' PerishableProduct inherits from Product
    ' Reuse -> Name, Price, Quantity
    ' Add -> ExpiryDate

    Public Class PerishableProduct
        Inherits Product

        Public ExpiryDate As Date

        Public Function IsExpired() As Boolean
            Return ExpiryDate < Date.Now
        End Function
    End Class


    ' =========================
    ' 3. POLYMORPHISM
    ' =========================
    ' Same method, different behavior
    ' DiscountedProduct → 10%
    ' PremiumProduct → 20%

    Public Class DiscountedProduct
        Inherits Product

        Public Overrides Function ToString() As String
            ' Different behavior from default ToString
            Return Name & " (Discounted Product)"
        End Function

        Public Overridable Function GetDiscount() As Decimal
            Return 0.1D   ' 10% discount
        End Function
    End Class

    Public Class PremiumProduct
        Inherits DiscountedProduct

        Public Overrides Function GetDiscount() As Decimal
            Return 0.2D   ' 20% discount
        End Function
    End Class


    ' =========================
    ' 4. ABSTRACTION
    ' =========================
    ' Hiding complex logic inside a class
    ' Cart hides calculation logic
    ' User only sees cart.GetFinalTotal()
    ' No need to know loops, discount calculations

    Public Class Cart
        Private items As New List(Of Product)

        Public Sub AddItem(product As Product)
            items.Add(product)
        End Sub

        Public Function GetFinalTotal() As Decimal
            Dim total As Decimal = 0

            For Each item In items
                Dim discount As Decimal = 0

                ' Check if item supports discount (polymorphism)
                If TypeOf item Is DiscountedProduct Then
                    discount = CType(item, DiscountedProduct).GetDiscount()
                End If

                total += item.Price * item.Quantity * (1 - discount)
            Next

            Return total
        End Function
    End Class


    ' =========================
    ' EXAMPLE
    ' =========================

    Public Sub RunDemo()

        ' Create products
        Dim apple As New Product()
        apple.Name = "Apple"
        apple.Price = 500
        apple.Quantity = 2

        Dim milk As New PerishableProduct()
        milk.Name = "Milk"
        milk.Price = 2000
        milk.Quantity = 1
        milk.ExpiryDate = #5/10/2026#

        Dim bread As New PremiumProduct()
        bread.Name = "Bread"
        bread.Price = 1500
        bread.Quantity = 1

        ' Add to cart
        Dim cart As New Cart()
        cart.AddItem(apple)
        cart.AddItem(milk)
        cart.AddItem(bread)

        ' Get total
        Dim total = cart.GetFinalTotal()

        Console.WriteLine("Final Total: " & total)

    End Sub

End Class

'Encapsulation → protect data
'Inheritance → reuse code
'Polymorphism → same action, different behavior
'Abstraction → hide complexity