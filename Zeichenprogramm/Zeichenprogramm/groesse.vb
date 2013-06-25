Public Class Groesse

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        MainForm.PictureBox1.Width = txtX.Text
        MainForm.PictureBox1.Height = txtY.Text

        MainForm.PictureBox1.Image = New Bitmap(My.Forms.MainForm.PictureBox1.Width, My.Forms.MainForm.PictureBox1.Height)
        MainForm.grafik = Graphics.FromImage(My.Forms.MainForm.PictureBox1.Image)
        MainForm.grafik.Clear(MainForm.bgcolor)
        MainForm.resetdraw()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class