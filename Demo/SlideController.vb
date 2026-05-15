Imports System.ComponentModel
Imports System.Reflection

Public Class SlideController

    Private ReadOnly _slides As List(Of ISlide)
    Private _currentIndex As Integer = 0
    Private _exitRequested As Boolean = False
    Private ReadOnly _moduleNumber As Integer
    Private ReadOnly _moduleTitle As String

    Public Sub New(slides As List(Of ISlide), moduleNumber As Integer, moduleTitle As String)

        _slides = slides
        _moduleNumber = moduleNumber
        _moduleTitle = moduleTitle

    End Sub

    Public Sub Start()

        While Not _exitRequested
            Console.Clear()

            Layout.Render(_moduleNumber, _moduleTitle,
                Sub()

                    ' Run current slide
                    _slides(_currentIndex).Show()
                End Sub)


            ' Handle navigation
            HandleInput()

        End While

        Console.Clear()
        Console.WriteLine("Course exited. Goodbye!")

    End Sub

    Private Sub HandleInput()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Instructions:")
        Console.WriteLine()
        Console.WriteLine("Next:  SPACE/ENTER")
        Console.WriteLine("Back:  B")
        Console.WriteLine("Exit:  ESC")

        Dim key As ConsoleKeyInfo = Console.ReadKey(True)

        Select Case key.Key

            Case ConsoleKey.Spacebar, ConsoleKey.Enter
                NextSlide()

            Case ConsoleKey.B
                PreviousSlide()

            Case ConsoleKey.C
                Console.Clear()

            Case ConsoleKey.Escape
                _exitRequested = True

        End Select

    End Sub

    Private Sub NextSlide()

        If _currentIndex < _slides.Count - 1 Then
            _currentIndex += 1
        End If

    End Sub

    Private Sub PreviousSlide()

        If _currentIndex > 0 Then
            _currentIndex -= 1
        End If

    End Sub

End Class