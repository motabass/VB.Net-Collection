Public Class Form1
    Public Zeitrechner As New Zeit


    Sub berechne()
        If IsNumeric(txtSekunden.Text) Then
            Zeitrechner.Sekunden = txtSekunden.Text

            lbZeit.Text = Zeitrechner.getClock
        End If
    End Sub

    Private Sub cmdUmrechnen_Click(sender As Object, e As EventArgs) Handles cmdUmrechnen.Click
        Call berechne()
    End Sub

    Private Sub txtSekunden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSekunden.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Call berechne()
        End If
    End Sub

    Private Sub cmdJetzt_Click(sender As Object, e As EventArgs) Handles cmdJetzt.Click
        Zeitrechner.Sekunden = Now.TimeOfDay.TotalSeconds

        lbZeit.Text = Zeitrechner.getClock
    End Sub
End Class
