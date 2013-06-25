Public Class Change


    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles cmdOK.Click
        If txtDetail.Text <> "" And txtName.Text <> "" And txtTime.Text <> "" Then
            If IsDate(txtTime.Text) Then

                Dim meinTermin As New Termin

                meinTermin.Bezeichnung = txtName.Text
                meinTermin.BisWann = txtTime.Text
                meinTermin.Detail = txtDetail.Text
                If My.Forms.Form1.changecheck = False Then
                    My.Forms.Form1.lstTermine.Items.Add(meinTermin)
                Else
                    My.Forms.Form1.lstTermine.Items(My.Forms.Form1.lstTermine.SelectedIndex) = meinTermin
                End If
                txtDetail.Clear()
                txtName.Clear()
                txtTime.Clear()
                Me.Close()
            Else
                MsgBox("Bitte geben Sie ein gültiges Datum ein!")
                txtTime.Focus()
                txtTime.SelectAll()
            End If
        Else
            MsgBox("Es gibt leere Felder")
        End If
    End Sub

    Private Sub txtTime_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtDetail.Focus()
            txtDetail.SelectAll()
        End If

        If Len(txtTime.Text) < 10 Then
            If IsNumeric(e.KeyChar) = True Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back) Then
            Else
                e.Handled = True
            End If
        ElseIf e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        txtDetail.Clear()
        txtName.Clear()
        txtTime.Clear()
        Me.Close()
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.LostFocus
        If IsDate(txtTime.Text) Then
            DateTimePicker1.Value = txtTime.Text
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtTime.Text = Format(DateTimePicker1.Value, "dd.MM.yyyy")
    End Sub

    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtTime.Text <> "" Then
            DateTimePicker1.Value = txtTime.Text
        End If
        txtName.Focus()
        txtName.SelectAll()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtTime.Focus()
            txtTime.SelectAll()
        End If
    End Sub

    Private Sub Change_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtDetail.Clear()
        txtName.Clear()
        txtTime.Clear()
    End Sub
End Class