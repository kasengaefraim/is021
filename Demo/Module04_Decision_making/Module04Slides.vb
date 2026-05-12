Public Class Module04Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)
        slides.Add(New DecisionMakingIntro())
        slides.Add(New IfStatement())
        slides.Add(New IfElseStatement())
        slides.Add(New ElseIfStatement())
        slides.Add(New SelectCaseStatement())
        slides.Add(New NestedIfStatement())
        slides.Add(New Module4Quiz())
        slides.Add(New Module4Practice())
        Return slides
    End Function


End Class
