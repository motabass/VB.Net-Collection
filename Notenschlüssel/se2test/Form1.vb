Public Class Form1
    Public alle As Single, punkte As Integer, anzahl As Integer





    Private Sub cmdEingabe_Click(sender As System.Object, e As System.EventArgs) Handles cmdEingabe.Click

        Call eingabe()


    End Sub

    Private Sub txtAnzahl_TextChanged(sender As Object, e As EventArgs) Handles txtAnzahl.TextChanged, txtPunkte.TextChanged

        punkte = Val(txtPunkte.Text)
        anzahl = Val(txtAnzahl.Text)

        alle = punkte * anzahl



    End Sub

 

    Private Sub txtAnzahl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnzahl.KeyPress, txtPunkte.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back) Then
        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Call eingabe()

        End If
    End Sub

    Sub eingabe()
        Dim nachname As String, gesamtpunkte As Integer, note As Integer, testpunkte As String, antw As DialogResult


        Dim beispiele As New Collection

      


        If txtAnzahl.Text <> "" And txtPunkte.Text <> "" Then
            If txtName.Text <> "" Then

                txtAnzahl.Enabled = False
                txtPunkte.Enabled = False
                nachname = txtName.Text

                For i = 1 To Val(txtAnzahl.Text)
retry:
                    testpunkte = InputBox("Bitte die Punkte für Beispiel " & i & " eingeben!")
                    If testpunkte = "" Then

                        antw = MsgBox("Wirklich abbrechen??", MsgBoxStyle.YesNo)
                        If antw = Windows.Forms.DialogResult.Yes Then
                            GoTo abbr
                        Else
                            GoTo retry
                        End If


                    Else
                        If Val(testpunkte) <= punkte And Val(testpunkte) > -1 Then
                            beispiele.Add(testpunkte)
                        Else

                            MsgBox("Punkteanzahl ist nicht möglich." & vbNewLine & "Bitte noch einmal eingeben")
                            GoTo retry
                        End If

                    End If
                   
                    gesamtpunkte = gesamtpunkte + beispiele(i)

                Next


                If gesamtpunkte >= alle / 10 * 9 Then

                    note = 1
                ElseIf gesamtpunkte >= alle / 10 * 8 Then
                    note = 2
                ElseIf gesamtpunkte >= alle / 10 * 6 Then
                    note = 3
                ElseIf gesamtpunkte >= alle / 10 * 5 Then
                    note = 4
                Else
                    note = 5
                End If

                txtZusammen.Text = txtZusammen.Text & "Name: " & nachname & vbNewLine & "Gesamtpunkte: " & gesamtpunkte & vbNewLine & "Note: " & note & vbNewLine & vbNewLine


                txtName.Clear()
                txtName.Focus()


            Else
                MsgBox("Bitte einen Namen eingeben.")

            End If
        Else
            MsgBox("Bitte Anzahl der Beispiele und erreichbare Punkte angeben.")
        End If
        Exit Sub
abbr:
        txtName.Focus()
        txtName.SelectAll()

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        txtAnzahl.Enabled = True
        txtPunkte.Enabled = True
        txtZusammen.Clear()

    End Sub
End Class
