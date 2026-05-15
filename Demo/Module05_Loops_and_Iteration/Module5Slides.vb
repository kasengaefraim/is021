Public Class Module5Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)
        slides.Add(New LoopsIntro())
        slides.Add(New ForLoopExample())
        slides.Add(New ForEachLoopExample())
        slides.Add(New WhileLoopExample())
        slides.Add(New DoWhileLoopExample())
        slides.Add(New DoUntilLoopExample())
        slides.Add(New NestedLoopsExample())
        slides.Add(New Module5Quiz())
        slides.Add(New Module5Practice())
        Return slides
    End Function
End Class
