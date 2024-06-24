
Public Class Coordinates
    Private CustomCordsList As New List(Of CustomCord)
    Private Index As Integer = 1
    Public Sub AddCustomCord(ByVal x As Double, ByVal y As Double, ByVal value As Double)
        Dim newCord As New CustomCord With {.x = x, .y = y, .value = value, .startIndex = Index}
        Index = Index + 1
        CustomCordsList.Add(newCord)
    End Sub

    Public Sub UpdateCustomCord(ByVal index As Integer, ByVal newX As Double, ByVal newY As Double, ByVal newValue As Double)
        If index >= 0 AndAlso index < CustomCordsList.Count Then
            Dim cordToUpdate As CustomCord = CustomCordsList(index)
            cordToUpdate.x = newX
            cordToUpdate.y = newY
            cordToUpdate.value = newValue
            CustomCordsList(index) = cordToUpdate

        End If
    End Sub

    Public Function GetCustomCord(ByVal index As Integer) As Double
        If index >= 0 AndAlso index < CustomCordsList.Count Then
            Return CustomCordsList(index).value
        Else
            Return 0.0
        End If
    End Function

    Public Function DistanceFromTheOrigin()
        Dim i As Integer
        For i = 0 To CustomCordsList.Count - 1
            Dim cord As CustomCord = CustomCordsList(i)
            cord.value = Math.Sqrt((cord.x * cord.x) + (cord.y * cord.y))
            CustomCordsList(i) = cord
        Next i
        SortFunc()
    End Function

    Public Function IncranceBetweenAngle()
        Dim i As Integer
        For i = 0 To CustomCordsList.Count - 1
            Dim cord As CustomCord = CustomCordsList(i)
            cord.value = Math.Atan(cord.y / cord.x)
            CustomCordsList(i) = cord
        Next i
        SortFunc()
    End Function
    Private Function SortFunc()
        CustomCordsList.Sort(Function(c1, c2) c1.value.CompareTo(c2.value))
    End Function

    Public Function GetText(ByVal method) As String

        Dim textToReturn As String
        Dim methodText As String

        If method = 0 Then
            methodText = "відстань: "
        Else
            methodText = "кут:"
        End If

        Dim i As Integer
        i = 1
        textToReturn = ""
        For Each cord As CustomCord In CustomCordsList
            textToReturn = textToReturn & "x" & cord.startIndex & "=" & cord.x & ", y" & cord.startIndex & "=" & cord.y & " "
            textToReturn = textToReturn & methodText & "= " & Math.Round(cord.value, 4) & vbCrLf
        Next

        GetText = textToReturn

    End Function
    Public Function RemoveAll()
        CustomCordsList.Clear()
    End Function
End Class
