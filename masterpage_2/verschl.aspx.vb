
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub cmdVersch_Click(sender As Object, e As EventArgs) Handles cmdVersch.Click

        Dim i As Integer, pos As Integer, text As String, pw As String, pwlong As String

        text = txtText.Text
        pw = txtPW.Text
        pwlong = txtPW.Text
        pos = 1
        For i = Len(pw) + 1 To Len(text)
            If pos > Len(pw) Then
                pos = 1
            End If
            pwlong &= Mid(pw, pos, 1)
            pos += 1

        Next

        Dim j As Integer, verschl As String = "", letter As Integer

        For j = 1 To Len(text)
            letter = Asc(Mid(text, j, 1)) + Asc(Mid(pwlong, j, 1))

            If letter > 255 Then
                letter = Asc(Mid(text, j, 1)) + Asc(Mid(pwlong, j, 1)) - 255
            End If

            verschl &= Chr(letter)
        Next

        txtText.Text = verschl

    End Sub

    Protected Sub cmdEntsch_Click(sender As Object, e As EventArgs) Handles cmdEntsch.Click
            Dim i As Integer, pos As Integer, text As String, pw As String, pwlong As String

            text = txtText.Text
            pw = txtPW.Text
            pwlong = txtPW.Text
            pos = 1
            For i = Len(pw) + 1 To Len(text)
                If pos > Len(pw) Then
                    pos = 1
                End If
                pwlong &= Mid(pw, pos, 1)
                pos += 1
            Next

            Dim j As Integer, entschl As String = "", letter As Integer

            For j = 1 To Len(text)
                letter = Asc(Mid(text, j, 1)) - Asc(Mid(pwlong, j, 1))

                If letter < 0 Then
                    letter = Asc(Mid(text, j, 1)) - Asc(Mid(pwlong, j, 1)) + 255
                End If

                entschl &= Chr(letter)
            Next

            txtText.Text = entschl

    End Sub
End Class
