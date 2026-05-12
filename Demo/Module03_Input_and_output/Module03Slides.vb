Public Class Module03Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)
        slides.Add(New ConsoleInputOutput())
        slides.Add(New ReadingUserInput())
        slides.Add(New OutputFormatting())
        slides.Add(New OutputFormattingAdvanced())
        slides.Add(New InputOutputExample())
        slides.Add(New Module3Quiz())
        Return slides
    End Function
End Class
