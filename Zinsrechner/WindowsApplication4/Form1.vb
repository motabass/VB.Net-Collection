Public Class Form1

    Private Sub cmdBerechne_Click(sender As System.Object, e As System.EventArgs) Handles cmdBerechne.Click
        lbZinsen.Text = CStr(CDbl(txtKapital.Text) * CDbl(txtSatz.Text) * CDbl(txtZeit.Text) / 100 / 360) & " €"


    End Sub

    Private Sub txtKapital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtKapital.KeyPress
        If e.KeyChar > Chr(47) And e.KeyChar < Chr(59) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = "," Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
        End If
        Else
        e.Handled = True


        End If

    End Sub


    Private Sub txtZeit_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtZeit.KeyPress
        If e.KeyChar > Chr(47) And e.KeyChar < Chr(59) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = "," Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
        Else
            e.Handled = True


        End If

    End Sub

    Private Sub txtSatz_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSatz.KeyPress
        If e.KeyChar > Chr(47) And e.KeyChar < Chr(59) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = "," Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
        Else
            e.Handled = True


        End If

    End Sub
End Class
