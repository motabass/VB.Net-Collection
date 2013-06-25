Public Class Form1

    Private Sub scrR_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles scrR.Scroll, scrG.Scroll, scrB.Scroll

        Call scrolling()





    End Sub

    Sub Zufall()
        Dim rd As New Random
        txtR.Text = rd.Next(0, 255)
        txtG.Text = rd.Next(0, 255)
        txtB.Text = rd.Next(0, 255)
    End Sub



    Sub scrolling()


        txtR.Text = scrR.Value
        txtG.Text = scrG.Value
        txtB.Text = scrB.Value
        


    End Sub


    Private Sub txtR_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtR.KeyPress, txtG.KeyPress, txtB.KeyPress

        If e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = Chr(Keys.Back) Then
        Else
            e.Handled = True

        End If

    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = cmdZufall
        Me.CancelButton = cmdEnde


        Call Zufall()


    End Sub

    Private Sub txtR_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtR.TextChanged, txtG.TextChanged, txtB.TextChanged
        If Val(txtR.Text) > 255 Then
            MsgBox("Zu hoher Farbwert", MsgBoxStyle.Critical, "Überschreitung")
            txtR.Text = "255"
        ElseIf Val(txtG.Text) > 255 Then
            MsgBox("Zu hoher Farbwert", MsgBoxStyle.Critical, "Überschreitung")
            txtG.Text = "255"
        ElseIf Val(txtB.Text) > 255 Then
            MsgBox("Zu hoher Farbwert", MsgBoxStyle.Critical, "Überschreitung")
            txtB.Text = "255"
        Else
            Try
                lbR.BackColor = Color.FromArgb(txtR.Text, 0, 0)
                lbRot.BackColor = Color.FromArgb(txtR.Text, 0, 0)
                lbG.BackColor = Color.FromArgb(0, txtG.Text, 0)
                lbGruen.BackColor = Color.FromArgb(0, txtG.Text, 0)
                lbB.BackColor = Color.FromArgb(0, 0, txtB.Text)
                lbBlau.BackColor = Color.FromArgb(0, 0, txtB.Text)
                lbMix.BackColor = Color.FromArgb(txtR.Text, txtG.Text, txtB.Text)
                lbRG.BackColor = Color.FromArgb(txtR.Text, txtG.Text, 0)
                lbRB.BackColor = Color.FromArgb(txtR.Text, 0, txtB.Text)
                lbGB.BackColor = Color.FromArgb(0, txtG.Text, txtB.Text)
                scrR.Value = txtR.Text
                scrG.Value = txtG.Text
                scrB.Value = txtB.Text
            Catch
            End Try
        End If

        

    End Sub

    Private Sub cmdZufall_Click(sender As System.Object, e As System.EventArgs) Handles cmdZufall.Click
        Call Zufall()

    End Sub

    Private Sub cmdEnde_Click(sender As Object, e As EventArgs) Handles cmdEnde.Click
        Me.Close()
    End Sub
End Class
