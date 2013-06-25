Public Class Form1

    Private Sub cmdEnde_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnde.Click
        End
    End Sub

    Sub Zufallszahlen()
        Dim rd As New Random

        txtSumme.Text = ""

        cmdCheck.Enabled = True
        txtSumme.Enabled = True
        If rad2.Checked = True Then
            txtZahl1.Text = rd.Next(1, 99)
            txtZahl2.Text = rd.Next(1, 99)
        ElseIf rad3.Checked = True Then
            txtZahl1.Text = rd.Next(100, 999)
            txtZahl2.Text = rd.Next(100, 999)
        ElseIf rad4.Checked = True Then
            txtZahl1.Text = rd.Next(1000, 9999)
            txtZahl2.Text = rd.Next(1000, 9999)
        End If
        txtSumme.Focus()
    End Sub

    Sub check()
        txtSumme.Enabled = False
        cmdCheck.Enabled = False
        If Val(txtSumme.Text) = Val(txtZahl1.Text) + Val(txtZahl2.Text) Then
            lbRichtig.Text = lbRichtig.Text + 1
        Else
            lbfalsch.Text = lbfalsch.Text + 1

        End If



        If lbRichtig.Text > lbfalsch.Text Then
            picSmile.BackgroundImage = My.Resources.smile
      Else
            picSmile.BackgroundImage = My.Resources.sad
        End If
        cmdNeueZahl.Focus()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ToolTipSumme.SetToolTip(txtSumme, "Hier bitte das Ergebniss eingeben")
        CancelButton = cmdEnde
        AcceptButton = cmdCheck


        Call Zufallszahlen()
    End Sub

    Private Sub rad2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad2.CheckedChanged, rad3.CheckedChanged, rad4.CheckedChanged

        Call Zufallszahlen()


    End Sub

    Private Sub txtSumme_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSumme.KeyPress
        If e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Enter) Then

            If e.KeyChar = Chr(Keys.Enter) Then
                txtSumme.Enabled = False
                Call check()
                cmdCheck.Enabled = False
            End If
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub cmdCheck_Click(sender As System.Object, e As System.EventArgs) Handles cmdCheck.Click

        Call check()


    End Sub

    Private Sub cmdNeueZahl_Click(sender As System.Object, e As System.EventArgs) Handles cmdNeueZahl.Click

        Call Zufallszahlen()
    End Sub
End Class
