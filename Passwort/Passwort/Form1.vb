Public Class Form1
    Public seconds As Integer = 15
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub txtPW_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPW.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txtPW.Text = "passwort" Then
                MsgBox("Richtig")
                Timer1.Enabled = False
                lbTime.Text = "Entsperrt"
            Else
                MsgBox("Falsch" & vbNewLine & "Bitte versuch es noch einmal")
                Timer1.Enabled = False
                lbTime.Text = "15s"
                seconds = 15
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        seconds -= 1
        If seconds > -1 Then
            lbTime.Text = seconds & "s"
        Else
            txtPW.Enabled = False
            Timer1.Enabled = False
            MsgBox("Zeit abgelaufen!")
            lbTime.Text = "Zeit abgelaufen!"
        End If

    End Sub
End Class
