Public Class Module02Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)

        slides.Add(New VariablesAndConstants())
        slides.Add(New DataTypes())
        slides.Add(New TypeConversion())
        slides.Add(New OperatorsAndExpressions())
        slides.Add(New AccessAndImplementation())
        slides.Add(New Module2Quiz())

        Return slides

    End Function
End Class
