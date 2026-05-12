Public Class Module7Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)
        slides.Add(New MethodsIntro())
        slides.Add(New SubProcedures())
        slides.Add(New FunctionsIntro())
        slides.Add(New ParametersAndArguments())
        slides.Add(New ReturnValues())
        slides.Add(New MethodOverloading())
        slides.Add(New Module7Quiz())
        slides.Add(New Module7Practice())
        Return slides
    End Function
End Class
