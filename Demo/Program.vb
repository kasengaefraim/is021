'Visual basic 
'is an object oriented programming language.
'its implemented on the .NET framework

'what is the .NET framework?.
'relationship between visual basic (VB.NET) and the .NET framework

'OBJECT ORIENTED PROGRAMMING
'EXAMPLE
'CAR CLASS  -> Idadi_ya_Viti
'           -> MATAIRI
'           -> Rangi
'           -> VIOO
'           -> JINA
'           -> SPEED()
'           -> KUWAKA_NA_KUZIMA()

'in object oriented programming there are Classes

'OBJECTS
'Are instances of a class
'V8, ist, RR, crown, landrover, range rover. -> belong to the CAR class


'Dim name As String = "juma"
'Dim last_name As String = "john"
'So here String is a Class while name and last_name are
'objects (instances of the string class)















'Identifiers

'An identifier Is a name used To identify a Class, variable, Function, Or any other user-defined item.
'The basic rules For naming classes In VB.Net are As follows 
'A name must begin with a letter that could be followed by a sequence of letters, digits (0 - 9) or underscore.
'The first character in an identifier cannot be a digit.
'It must not contain any embedded space or symbol like ? - +! @ # % ^ & * ( ) [ ] { } . ; : " ' / and \.
'However, an underscore ( _ ) can be used.
'it should not be a reserved keyword.





Imports System



Module Program
    'hII NI SUB PROCESS INAYOITWA NYINGINE
    'INASAIDIA KUONYESHA PROCESS IPI INAANZA KATI YA MAIN NA NYINGINE

    Private class_and_object As New ClassAndObject
    Sub nyingine()
        'this sub process will not be executed first
        Console.WriteLine("hapa nimeiita subprocess nyingine()")
    End Sub
    Sub Main(args As String())

        'from the class DataTypes i have declared
        'and initialized the object (instance of the class)
        Dim datatype As DataTypes = New DataTypes()

        datatype.DateDemo()








        'class_and_object.Main()


        'Console.WriteLine("This is the main sub process in the program")
        'nyingine()
        'COMMENTS ARE IGNORED
        'Dim age As Integer = 20
        Dim age As Integer
        age = 20 'initialize 
        'lvalue
        'rvalue
        '20 = age 'will cause error because 20 is a rvalue

        'Dim number1, number2, number3  As Integer
        Dim number1 As Integer
        Dim number2 As Integer
        'Dim number3 As String
        number1 = 70
        'number2 = 45
        Dim price As Double = 12.5

        ''You can initialize a variable at the time of declaration as follows
        Dim name As String = "Josephat"
        Dim isActive As Boolean = True
        Dim day As DateTime = Today
        Dim character As Char = "character"


        ''comments
        ''these are ignored during compile time. and they are used to explain what code does

        'Console.WriteLine(character)
        'Console.WriteLine(name)
        'Console.WriteLine(age)
        'Console.WriteLine(isActive)
        'Console.WriteLine(price)
        'Console.WriteLine(day)


        ''Operations
        'Dim x As Integer = 10
        'Dim y As Integer = 5

        ''Arithmetic operations
        'Console.WriteLine(x + y) 'addition
        'Console.WriteLine(x - y) 'subtraction
        'Console.WriteLine(x * y) 'multiplication
        'Console.WriteLine(x / y) 'division

        Dim firstName As String = "John"
        Dim lastName As String = "Doe"

        ''Concatenation (Joining text)
        'Console.WriteLine(firstName & " " & lastName) 'the & joins text in VB
        'Console.WriteLine(firstName + " " + lastName) 'the & joins text in VB
        'Console.WriteLine($"{firstName} {lastName}") 'the & joins text in VB
        'Console.WriteLine("{2} {1} jina la pili {0}", firstName, lastName, age) 'the & joins text in VB

        ''Mixing text and numbers 
        'Console.WriteLine("Name: " & name)
        'Console.WriteLine("Age: " & age)

        ''boolean example
        'Dim isLoggedIn As Boolean = True
        'Console.WriteLine(isLoggedIn)

        'Console.WriteLine("Enter Your registration number")

        ''The Console class in the System namespace provides a function ReadLine for accepting input from the user and store it into a variable. For example
        Dim registrationNumber As String = Console.ReadLine
        'Console.WriteLine("Your registration number is: {0} ", registrationNumber)



        'The constants refer to fixed values that the program may not alter during its execution
        'The constants are treated just like regular variables except that their values cannot be modified after their definition.
        'Const maxval As Long = 4999
        'Console.WriteLine(message)

        Dim control As New ControlFlow()

        control.CheckProduct(1500, 2)
        control.ProcessCart()
        control.BranchingExample()
        control.RunDemo()
        Console.ReadLine()

    End Sub


    Public Const message As String = "HELLO"
    Private Const piValue As Double = 3.1415
End Module





