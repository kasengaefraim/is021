Imports System

Public Module CourseContent

    Public Sub Show()

        Dim exitApp As Boolean = False

        While Not exitApp

            Console.Clear()

            Console.WriteLine()
            Console.WriteLine("IS021 Introduction to programming with Visual basic .NET")
            ConsoleHelper.AddVerticalSpace(2)

            Console.WriteLine("Welcome to the course")
            Console.WriteLine("Learn programming step-by-step from basics to advanced concepts.")

            ConsoleHelper.AddVerticalSpace(1)

            Console.WriteLine()
            Console.WriteLine("SELECT A MODULE:")
            Console.WriteLine()

            Console.WriteLine("1. Module 01: Introduction to Programming")
            Console.WriteLine("2. Module 02: Variables and Data Types")
            Console.WriteLine("3. Module 03: Input and Output")
            Console.WriteLine("4. Module 04: Decision Making")
            Console.WriteLine("5. Module 05: Loops and Iterations")
            Console.WriteLine("6. Module 06: Arrays and Collections")
            Console.WriteLine("7. Module 07: Methods and Functions")
            Console.WriteLine("8. Module 08: Object Oriented Programming")
            Console.WriteLine("9. Exit Course")
            Console.WriteLine()

            Console.Write("Enter Module number: ")

            Dim choice As String = Console.ReadLine()

            Select Case choice

                Case "1"
                    RunModule1()
                Case "2"
                    RunModule2()
                Case "3"
                    RunModule3()
                Case "4"
                    RunModule4()
                Case "5"
                    RunModule5()
                Case "6"
                    RunModule6()
                Case "7"
                    RunModule7()
                Case "8"
                    RunModule8()
                Case "9"
                    exitApp = True

                Case Else
                    Console.WriteLine("Invalid choice. Press any key...")
                    Console.ReadKey()
            End Select
        End While

        Console.WriteLine("Goodbye!")

    End Sub

    Private Sub RunModule1()
        Dim slides As New Module01Slides
        Dim controller As New SlideController(slides.GetSlides(), 1, "Introduction to Programming")
        controller.Start()
    End Sub

    Private Sub RunModule2()

        Dim slides As New Module02Slides
        Dim controller As New SlideController(slides.GetSlides(), 2, "Variables and Data Types")
        controller.Start()

    End Sub

    Private Sub RunModule3()
        Dim slides As New Module03Slides
        Dim controller As New SlideController(slides.GetSlides(), 3, "Input and Output")
        controller.Start()

    End Sub
    Private Sub RunModule4()
        Dim slides As New Module04Slides
        Dim controller As New SlideController(slides.GetSlides(), 4, "Decision Making")
        controller.Start()
    End Sub
    Private Sub RunModule5()
        Dim slides As New Module5Slides
        Dim controller As New SlideController(slides.GetSlides(), 5, "Input and Output")
        controller.Start()
    End Sub
    Private Sub RunModule6()

        Dim slides As New Module6Slides
        Dim controller As New SlideController(slides.GetSlides(), 6, "Arrays and Collections")
        controller.Start()
    End Sub
    Private Sub RunModule7()
        Dim slides As New Module7Slides
        Dim controller As New SlideController(slides.GetSlides(), 7, "Methods and Functions")
        controller.Start()
    End Sub
    Private Sub RunModule8()
        Dim slides As New Module8Slides
        Dim controller As New SlideController(slides.GetSlides(), 8, "Object Oriented Programming")
        controller.Start()
    End Sub

End Module