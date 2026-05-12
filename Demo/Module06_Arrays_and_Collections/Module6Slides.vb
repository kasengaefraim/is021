Public Class Module6Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)
        slides.Add(New ArraysIntro())
        slides.Add(New OneDimensionalArray())
        slides.Add(New ArrayLooping())
        slides.Add(New MultiDimensionalArray())
        slides.Add(New ListCollection())
        slides.Add(New ArraysVsLists())
        slides.Add(New Module6Quiz())
        slides.Add(New Module6Practice())
        Return slides
    End Function
End Class
