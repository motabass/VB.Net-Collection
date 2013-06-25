Public Class Form1
    'Function passwordcal(pw As String) As Integer
    '    Dim i As Integer, calString As String = "", calint As Integer = 3, key As Integer

    '    For i = 1 To Len(pw)
    '        calString &= Asc(Mid(pw, i, 1))
    '    Next
    '    i = 1


    '    For i = 1 To Len(calString)
    '        calint += Mid(calString, i, 1)
    '    Next
    '    calint = CInt(Mid(CStr(calint), Len(CStr(calint)) - 1, 2))

    '    key = calint

    '    Return key
    'End Function
    Private Sub cmdKey_Click(sender As System.Object, e As System.EventArgs) Handles cmdKey.Click
        'Dim i As Integer, unvertext As String, vertext As String = "", buchst As Integer, key As Integer
        'If txtPW.Text <> "" And Len(txtPW.Text) > 5 Then
        '    unvertext = txtText.Text


        '    key = passwordcal(txtPW.Text)
        '    For i = 1 To Len(unvertext)
        '        buchst = Asc(Mid(unvertext, i, 1))
        '        If buchst + key >= 255 Then
        '            buchst = buchst + key - 255
        '        Else
        '            buchst += key
        '        End If
        '        vertext &= Chr(buchst)
        '    Next
        '    txtText.Text = vertext
        'Else
        '    MsgBox("Bitte ein Passwort von 5 bis 20 Zeichen eingeben!")
        'End If
        If txtPW.Text <> "" Then
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
        Else
            MsgBox("Bitte geben sie ein Passwort ein!")
        End If
       
    End Sub

    Private Sub cmdUnkey_Click(sender As System.Object, e As System.EventArgs) Handles cmdUnkey.Click
        'Dim i As Integer, unvertext As String = "", vertext As String, buchst As Integer, key As Integer
        'If txtPW.Text <> "" And Len(txtPW.Text) > 5 Then
        '    vertext = txtText.Text
        '    key = passwordcal(txtPW.Text)
        '    For i = 1 To Len(vertext)
        '        buchst = Asc(Mid(vertext, i, 1))
        '        If buchst - key < 1 Then
        '            buchst = buchst - key + 255
        '        Else
        '            buchst -= key
        '        End If
        '        unvertext &= Chr(buchst)
        '    Next
        '    txtText.Text = unvertext
        'Else
        '    MsgBox("Bitte ein Passwort von 5 bis 20 Zeichen eingeben!")
        'End If
        If txtPW.Text <> "" Then
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
        Else
            MsgBox("Bitte geben sie ein Passwort ein!")
        End If
    End Sub


    Private Sub ÖffnenToolStripButton_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripButton.Click
        Dim antw As DialogResult
        Dim datei As System.IO.FileInfo
        Dim sr As System.IO.StreamReader
        Dim text As String

        antw = OpenFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            datei = New System.IO.FileInfo(OpenFileDialog1.FileName)
            sr = datei.OpenText
            text = sr.ReadToEnd
            txtText.Text = text
            sr.Close()
        End If
    End Sub

    Private Sub SpeichernToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SpeichernToolStripButton.Click
        Dim antw As DialogResult
        Dim datei As System.IO.FileInfo
        Dim sw As System.IO.StreamWriter
        Dim text As String = txtText.Text

        antw = SaveFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            datei = New System.IO.FileInfo(SaveFileDialog1.FileName)
            sw = datei.CreateText
            sw.WriteLine(Text)
            sw.Close()
        End If
    End Sub
  
    Private Sub NeuToolStripButton_Click(sender As Object, e As EventArgs) Handles NeuToolStripButton.Click
        Dim antw As MsgBoxResult

        antw = MsgBox("Wirklich alles löschen?" & vbNewLine & "Nicht gespeicherter Text geht verloren!", MsgBoxStyle.YesNo)

        If antw = MsgBoxResult.Yes Then
            txtText.Clear()
        End If
    End Sub
End Class
