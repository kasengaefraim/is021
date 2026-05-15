Imports System

Public Module Layout

    Public Sub Render(moduleNumber As Integer, moduleTitle As String, contentAction As Action)

        Console.WriteLine()

        contentAction.Invoke()

        Console.WriteLine()

    End Sub



    Private Sub DrawModuleTitle(moduleNumber As Integer, moduleTitle As String)
        Console.WriteLine($"MODULE {moduleNumber}: {moduleTitle}")
    End Sub



End Module