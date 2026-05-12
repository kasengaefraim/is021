Public Class Module8Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)
        slides.Add(New OOPIntro())
        slides.Add(New ClassesAndObjects())
        slides.Add(New Constructors())
        slides.Add(New Encapsulation())
        slides.Add(New InheritanceConcept())
        slides.Add(New PolymorphismConcept())
        slides.Add(New AbstractionConcept())
        slides.Add(New Module8Quiz())
        slides.Add(New Module8Practice())
        Return slides
    End Function
End Class
