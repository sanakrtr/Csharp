Public Class Form1
    Const limitOfCoordinates As Integer = 10
    Dim nextElementIndex As Integer = 1

    Dim cord As New Coordinates()

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub addXY_Click(sender As Object, e As EventArgs) Handles addXY.Click
        If nextElementIndex <= limitOfCoordinates Then
            If Len(XBox.Text) = 0 Or Len(YBox.Text) = 0 Then
                MsgBox("Помилка. Ви не вказали всі координати")
                Return
            ElseIf Not IsNumeric(XBox.Text) Or Not IsNumeric(YBox.Text) Then
                MsgBox("Помилка. Ви ввели не числа.")
                Return
            End If

            cord.AddCustomCord(CDbl(XBox.Text), CDbl(YBox.Text), 0.0)
            If Not XYList.Visible Then
                XYList.Text = ""
                XYList.Visible = True
            End If

            Button1.Enabled = True
            XYList.Text = XYList.Text & "x" & nextElementIndex & "= " & XBox.Text & ", y" & nextElementIndex & "= " & YBox.Text & vbCrLf
            nextElementIndex = nextElementIndex + 1
        Else
            MsgBox("Помилка. Ви додали забагато координат.")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If methodBox.SelectedIndex = -1 Then
            MsgBox("Помилка. Ви не обрали метод.")
            Return
        End If

        If methodBox.SelectedIndex = 0 Then
            cord.DistanceFromTheOrigin()
        ElseIf methodBox.SelectedIndex = 1 Then
            cord.IncranceBetweenAngle()
        Else
            MsgBox("Невідома помилка")
            Return
        End If
        addXY.Enabled = False
        Button3.Enabled = False
        methodBox.Enabled = False
        XYList.Text = cord.GetText(methodBox.SelectedIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cord.RemoveAll()
        XYList.Visible = False
        Button1.Enabled = False

        addXY.Enabled = True
        Button3.Enabled = True
        methodBox.Enabled = True
        nextElementIndex = 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
