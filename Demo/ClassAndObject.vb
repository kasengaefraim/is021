'OBJECT ORIENTED PROGRAMMING (OOP)
'OOP is a way of writing programs by organizing code into objects, just like things in real life.
'
'Instead of writing everything as separate instructions, we group related data and behavior together.
'
'Key Idea
'
'In OOP, a program is made up of:
'
'Objects → real-world things
'Classes → blueprints for those objects
'
'Basic Terms
'1. Class
'A class is a template or blueprint.
'
'Example:
'A “Car” class defines what every car should have (color, speed, engine)

'2. Object
'An object is a real instance of a class.
'
'Example:
'A red Toyota is an object of the Car class

'3. Properties (Attributes)
'These are data/characteristics of an object.
'
'Example:
'color
'price
'name

'4. Methods (Functions)
'These are actions an object can perform.
'
'Example:
'start()
'stop()
'calculateTotal()

Public Class Product

    'Properties
    Public Name As String
    Private _price As Decimal 'Encapsulation using Private keyword
    Public Quantity As Integer
    Private stock As Integer

    'Functions or methods
    Public Function AddStock(amount As Integer)
        Return stock + amount
    End Function


    ' Encapsulation using Property
    'What Encapsulation Really Means
    '
    'Encapsulation is about:
    '-> hiding internal data
    '-> controlling how that data is accessed or modified
    Public Property Price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                _price = value
            End If
        End Set
    End Property



    Public Function GetTotalPrice() As Decimal
        Return Price * Quantity
    End Function
End Class


Public Class ClassAndObject
    Private product As New Product
    Sub Main()
        product.Name = "Apple"
        product.Price = 1000
        product.Quantity = 3


        Console.WriteLine("The product is {0} and its price is {1}", product.Name, product.Price)
        Console.WriteLine("How many {0}s do you want", product.Name)
        product.Quantity = Console.ReadLine
        Console.WriteLine("Please pay {0} shs", product.GetTotalPrice)

    End Sub

End Class