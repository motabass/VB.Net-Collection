Public Class Form1
    Public verbrauch As New Collection
    Public bilder As New Collection


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        verbrauch.Add(4)
        verbrauch.Add(6)
        verbrauch.Add(15)

        cbAuto.SelectedIndex = 0
    End Sub
    Sub berechne()
        Dim ergebnis As Single

        If IsNumeric(txtKilometer.Text) = True And cbAuto.SelectedIndex >= 0 Then
            ergebnis = verbrauch.Item(cbAuto.SelectedIndex + 1) * txtKilometer.Text / 100

            lbErgebnis.Text = "Verbrauch: " & ergebnis & " Liter"

        End If
    End Sub
    Sub pic()
        If cbAuto.SelectedIndex = 0 Then
            pic1.Image = My.Resources.VW_Golf
        ElseIf cbAuto.SelectedIndex = 1 Then
            pic1.Image = My.Resources.Mazda_5
        ElseIf cbAuto.SelectedIndex = 2 Then
            pic1.Image = My.Resources.Lamborghini_Diablo

        Else
            pic1.Image = Image.FromFile(bilder.Item(cbAuto.SelectedIndex - 2))






        End If

    End Sub

    Private Sub cmdBerechen_Click(sender As System.Object, e As System.EventArgs) Handles cmdBerechen.Click
       
        Call berechne()

    End Sub

    Private Sub cbAuto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAuto.SelectedIndexChanged
        Call berechne()
        Call Pic()

    End Sub

    Private Sub cbAuto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbAuto.KeyPress
        Dim eingabe As String, antw As DialogResult





        If e.KeyChar = Chr(Keys.Enter) Then
            If cbAuto.FindStringExact(cbAuto.Text) < 0 Then


                eingabe = InputBox("Verbrauch von " & cbAuto.Text & " eingeben:", "Verbrauch")
                If eingabe = "" Then
                    MsgBox("Fehlerhafte Eingabe!" & vbNewLine & "Sie haben nichts eingegeben.", MsgBoxStyle.Critical)
                    GoTo fehler
                ElseIf IsNumeric(eingabe) = False Then
                    MsgBox("Fehlerhafte Eingabe!" & vbNewLine & "Geben sie eine Zahl für den Verbrauch ein.", MsgBoxStyle.Critical)
                    GoTo fehler
                Else
                    antw = OpenFileDialog1.ShowDialog()
                    If antw = Windows.Forms.DialogResult.OK Then
                        bilder.Add(OpenFileDialog1.FileName)
                        verbrauch.Add(eingabe)

                        cbAuto.Items.Add(cbAuto.Text)
                        cbAuto.SelectedIndex = cbAuto.Items.Count - 1
                    Else
                        GoTo fehler
                    End If


                End If



            Else
                MsgBox("Eintrag schon Vorhanden", MsgBoxStyle.Critical)
            End If
           

        End If
        Exit Sub

fehler:


    End Sub

End Class
