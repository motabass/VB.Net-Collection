Public Class Form1
   
    Private Sub cmdCheck_Click(sender As Object, e As EventArgs) Handles cmdCheck.Click
        Dim i As Integer, ergebnis As Integer, prüfzahl As Integer, ergstring As String




        If Len(txtISBN.Text) = 10 Then
            For i = 1 To 9
                ergebnis = ergebnis + Mid(txtISBN.Text, i, 1) * i

            Next
            prüfzahl = ergebnis Mod 11
            If prüfzahl = 10 Then

                prüfzahl = "X"

            End If
            If Mid(txtISBN.Text, 10, 1) = prüfzahl Then
                lbKorrekt.Text = "Korrekt"
            Else
                lbKorrekt.Text = "Inkorrekt"

            End If
        Else
            If Len(txtISBN.Text) = 13 Then
                For i = 1 To 11 Step 2
                    ergebnis = ergebnis + Mid(txtISBN.Text, i, 1)
                Next
                i = 2
                For i = 2 To 12 Step 2
                    ergebnis = ergebnis + Mid(txtISBN.Text, i, 1) * 3
                Next
                ergstring = ergebnis
                prüfzahl = 10 - Mid(ergstring, Len(ergstring), 1)

                If Mid(txtISBN.Text, 13, 1) = prüfzahl Then
                    lbKorrekt.Text = "Korrekt"
                Else
                    lbKorrekt.Text = "Inkorrekt"

                End If

            Else
                MsgBox("Die von Ihnen eingegebene Nummer hat die falsche Länge." & vbNewLine & "Bitte überprüfen Sie ihre Eingabe", MsgBoxStyle.Critical, "Falsche Eingabe")
            End If

        End If
    End Sub

    Private Sub txtISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtISBN.KeyPress
        If e.KeyChar = "x" Then
            e.KeyChar = "X"

        End If
        If e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = "X" Then
        Else
            e.Handled = True

        End If
    End Sub
End Class
