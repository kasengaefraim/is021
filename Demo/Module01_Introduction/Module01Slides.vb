
Public Class Module01Slides
    Public Function GetSlides() As List(Of ISlide)

        Dim slides As New List(Of ISlide)

        slides.Add(New WhatIsProgramming())
        slides.Add(New AlgorithmsAndFlowcharts())
        slides.Add(New TypesOfProgrammingLanguages())
        slides.Add(New CompilersAndInterpreters())
        slides.Add(New IntroductionToVBNet())
        slides.Add(New ProgramStructure())

        Return slides

    End Function

End Class
