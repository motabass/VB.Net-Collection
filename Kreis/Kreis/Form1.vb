Public Class Form1
    Public meinKreis As New Kreis


    Private Sub cmdRadius_Click(sender As Object, e As EventArgs) Handles cmdRadius.Click
        meinKreis.Radius = InputBox("Radius:")
    End Sub

    Private Sub cmdFlaeche_Click(sender As Object, e As EventArgs) Handles cmdFlaeche.Click
        meinKreis.Fläche = InputBox("Fläche:")
    End Sub

    Private Sub cmdUmfang_Click(sender As Object, e As EventArgs) Handles cmdUmfang.Click
        meinKreis.Umfang = InputBox("Umfang:")
    End Sub

    Private Sub cmdAusgabe_Click(sender As Object, e As EventArgs) Handles cmdAusgabe.Click
        zeichnen()
        MsgBox("Radius: " & meinKreis.Radius & vbNewLine & "Fläche: " & meinKreis.Fläche & vbNewLine & "Umfang: " & meinKreis.Umfang)
    End Sub

    Private Sub zeichnen()
        Dim grafik As Graphics
        Dim p As New Pen(Brushes.Black)
        Dim mitte As New Point(meinKreis.Radius + 10, meinKreis.Radius + 10)
        Dim r As Single = meinKreis.Radius
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        grafik = Graphics.FromImage(PictureBox1.Image)

        grafik.DrawEllipse(p, mitte.X - r, mitte.Y - r, r * 2, r * 2)
    End Sub
End Class
