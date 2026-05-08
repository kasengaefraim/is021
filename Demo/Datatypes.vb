Public Class DataTypes


    ' =========================
    ' 1. INTEGER (Whole numbers)
    ' =========================
    Public Sub IntegerDemo()

        Dim stock As Integer = 3.3
        Dim sold As Integer = 3
        Dim jumlisha As Integer

        ' Arithmetic
        Dim remaining As Integer = stock - sold
        'jumlisha = stock + 10 ' = 19
        'stock = jumlisha ' 19
        Dim doubled As Integer = stock * 2
        Dim divided As Integer = stock / 2
        Dim remainder As Integer = stock Mod 3

        'Console.WriteLine("Remaining: " & remaining)
        'Console.WriteLine("Doubled: " & doubled)
        'Console.WriteLine("Divided: " & divided)
        'Console.WriteLine("Remainder: " & remainder)
        'Console.WriteLine("Jumlisha: " & jumlisha)
        ' Comparisons
        'Console.WriteLine(stock > sold) ' if stock is greater than sold
        'Console.WriteLine(stock < sold) 'if stock is less than sold
        'Console.WriteLine(stock = sold) ' if stock is equal to sold
        'Console.WriteLine(stock <> sold) ' if stock is equal to sold
        'how does <> compare / function?


        Console.WriteLine(stock)
    End Sub


    ' =========================
    ' 2. DECIMAL (Money / precision)
    ' =========================
    Public Sub DecimalDemo()

        Dim price As Decimal = 1500D
        Dim discount As Decimal = 200D

        Dim finalPrice As Decimal = price - discount
        Dim increased As Decimal = price * 1.1D

        Console.WriteLine("Final Price: " & finalPrice)
        Console.WriteLine("Increased Price: " & increased)

        ' Comparisons
        Console.WriteLine(price > discount)
        Console.WriteLine(price < discount)
        Console.WriteLine(price = discount)

    End Sub


    ' =========================
    ' 3. STRING OPERATIONS
    ' =========================
    Public Sub StringDemo()

        'Dim productName As String = "Milk Pack"
        Dim category As String = "Dairy Section"

        ' Concatenation styles
        'Dim c1 As String = productName & " - " & category
        'Dim c2 As String = String.Concat(productName, " separator ", category)
        'Dim c3 As String = String.Format("{0} belongs to {1}", productName, category)

        'Console.WriteLine(c1)
        'Console.WriteLine(c2)
        'Console.WriteLine(c3)

        ' String functions
        'Console.WriteLine(productName.ToUpper())
        'Console.WriteLine(productName.ToLower())
        'Console.WriteLine(productName.Length)

        'productName = productName.Trim()
        'Console.WriteLine(productName.Length)
        'Console.WriteLine(productName.Trim().Length)



        Dim productName As String = "   Milk Packi"
        'Console.WriteLine(productName.Replace("Milk", "Cheese"))

        'productName.Replace("Milk", "Orange")
        'productName = productName.Replace("Milk", "Orange")

        'Console.WriteLine(productName)

        'Console.WriteLine(productName.Substring(2, 5))
        Console.WriteLine(productName.Contains("Milk"))
        Console.WriteLine(productName.StartsWith("Milk"))
        Console.WriteLine(productName.EndsWith("Pack"))

        ' Trim example
        'Dim messy As String = "   Bread   "
        'Console.WriteLine(messy.Trim())

    End Sub


    ' =========================
    ' 4. BOOLEAN (True / False logic)
    ' =========================
    Public Sub BooleanDemo()

        Dim inStock As Boolean = True
        Dim expired As Boolean = False

        Dim canSell As Boolean = inStock And expired

        Console.WriteLine("Can Sell: " & canSell)

    End Sub


    ' =========================
    ' 5. DATE OPERATIONS
    ' =========================
    Public Sub DateDemo()

        Dim today As Date = Date.Now
        Dim expiry As Date = #5/6/2026#

        'Console.WriteLine("Today: " & today)
        'Console.WriteLine("Day: " & today.Day)
        'Console.WriteLine("Month: " & today.Month)
        'Console.WriteLine("Year: " & today.Year)

        '' Date operations
        'Console.WriteLine("Next Day: " & today.AddDays(1))
        'Console.WriteLine("Next Month: " & today.AddMonths(1))
        'Console.WriteLine("Next Year: " & today.AddYears(1))

        ' Comparison
        If expiry > today Then
            Console.WriteLine("Product is valid")
        Else
            Console.WriteLine("Product expired")
        End If

        ' Difference
        Dim daysLeft As Integer = (expiry - today).Hours
        Console.WriteLine("Hours left: " & daysLeft)

    End Sub


    ' =========================
    ' 6. CHAR & OBJECT
    ' =========================
    Public Sub MiscDemo()

        Dim grade As Char = "A"c
        Dim anything As Object

        anything = "Text"
        Console.WriteLine(anything)

        anything = 100
        Console.WriteLine(anything)

        Console.WriteLine("Grade: " & grade)

    End Sub


    ' =========================
    ' 7. STRING + OTHER TYPES COMBINATION
    ' =========================
    Public Sub MixingDemo()

        Dim name As String = "Apple"
        Dim price As Decimal = 1500D
        Dim qty As Integer = 3
        Dim inStock As Boolean = True
        Dim expiry As Date = Date.Now.AddDays(5)

        ' Full concatenation
        Dim summary As String =
            "Name: " & name &
            ", Price: " & price &
            ", Qty: " & qty &
            ", Stock: " & inStock &
            ", Expiry: " & expiry.ToShortDateString()

        Console.WriteLine(summary)

        ' String.Format version
        Dim summary2 As String =
            String.Format("Product {0} costs {1} qty {2}", name, price, qty)

        Console.WriteLine(summary2)

    End Sub


    ' =========================
    ' EXAMPLE DEMO
    ' =========================
    Public Sub GrocerySystemDemo()

        Dim productName As String = "Bread"
        Dim price As Decimal = 2000D
        Dim quantity As Integer = 2
        Dim inStock As Boolean = True
        Dim expiry As Date = Date.Now.AddDays(3)

        Dim total As Decimal = price * quantity

        ' Decision using multiple data types
        If inStock And expiry > Date.Now Then

            Dim message As String =
                "Product: " & productName &
                ", Total: " & total &
                ", Expiry: " & expiry.ToShortDateString()

            Console.WriteLine("VALID PRODUCT")
            Console.WriteLine(message)

        Else
            Console.WriteLine("INVALID PRODUCT")
        End If

    End Sub


    ' =========================
    ' RUN ALL DEMOS
    ' =========================
    Public Sub RunAll()

        IntegerDemo()
        DecimalDemo()
        StringDemo()
        BooleanDemo()
        DateDemo()
        MiscDemo()
        MixingDemo()
        GrocerySystemDemo()

    End Sub


End Class
