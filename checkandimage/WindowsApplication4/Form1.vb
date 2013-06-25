Public Class Form1
    Public toogle As Boolean = 0



    Private Sub chkCheck_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheck.CheckedChanged
        If chkCheck.Checked = True Then
            txtCheck.Text = "Ja"
        Else
            txtCheck.Text = "Nein"

        End If
    End Sub

    Private Sub pic1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pic1.DoubleClick
        If toogle = False Then
            pic1.Image = My.Resources.Koala
            toogle = True
        ElseIf toogle = True Then
            pic1.Image = My.Resources.picture1
            toogle = False
        End If




    End Sub

    Private Sub pic1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pic1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pic1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\jellyfish.jpg")
        End If
    End Sub
End Class
