Public Class Form1

    Sub berechne()
        Dim erg As Single, gesch As Integer, freq As Integer

        gesch = Val(txtGeschwindigkeit.Text)

            freq = sbFrequenz.Value

            erg = freq * (1 + gesch / 1188)

        lbErgebnis.Text = "Die neue Frequenz beträgt " & Math.Round(erg, 1) & "Hz"






    End Sub


    Private Sub txtGeschwindigkeit_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGeschwindigkeit.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back) = True Then
            If e.KeyChar = Chr(Keys.Enter) Then
                If txtGeschwindigkeit.Text <> "" Then
                    Call berechne()
                Else
                    MsgBox("Sie haben keine Geschwindigkeit angegeben!", MsgBoxStyle.Critical, "Keine Geschwindigkeit")

                End If
            End If
        Else
            e.Handled = True

        End If


       
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbFrequenz.Text = "f=" & sbFrequenz.Value & "HZ"
    End Sub

    Private Sub sbFrequenz_ValueChanged(sender As System.Object, e As System.EventArgs) Handles sbFrequenz.ValueChanged
        lbFrequenz.Text = "f=" & sbFrequenz.Value & "HZ"
        If txtGeschwindigkeit.Text <> "" Then
            Call berechne()
        End If

    End Sub
End Class
