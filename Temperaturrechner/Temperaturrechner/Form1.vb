Public Class Form1
    Public MaxTemp As New Temperatur
    Public MinTemp As New Temperatur(-15)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String

        input = InputBox("°C")

        If IsNumeric(input) Then
            MaxTemp.Celsius = input
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input As String

        input = InputBox("°F")

        If IsNumeric(input) Then
            MaxTemp.Fahrenheit = input
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim input As String

        input = InputBox("°C")

        If IsNumeric(input) Then
            MinTemp.Celsius = input
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim input As String

        input = InputBox("°F")

        If IsNumeric(input) Then
            MinTemp.Fahrenheit = input
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(MaxTemp.Celsius)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox(MaxTemp.Fahrenheit)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox(MinTemp.Celsius)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox(MinTemp.Fahrenheit)
    End Sub
End Class
