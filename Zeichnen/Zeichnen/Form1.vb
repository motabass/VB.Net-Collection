Public Class Form1

    Private Sub cmdPen_Click(sender As System.Object, e As System.EventArgs) Handles cmdLine.Click
        Dim stift As New Pen(System.Drawing.Color.Red)
        Dim grafik As Graphics

        grafik = PictureBox1.CreateGraphics

        grafik.DrawLine(stift, 100, 50, 200, 200)




    End Sub

    Private Sub cmdEl_Click(sender As System.Object, e As System.EventArgs) Handles cmdEl.Click
        Dim stift As New Pen(System.Drawing.Color.FromArgb(122, 23, 170, 23), 4)
        Dim grafik As Graphics

        grafik = PictureBox1.CreateGraphics

        grafik.DrawEllipse(stift, 70, 50, 150, 200)

    End Sub

    Private Sub cmdRe_Click(sender As System.Object, e As System.EventArgs) Handles cmdRe.Click
        Dim stift As New Pen(System.Drawing.SystemColors.MenuText)
        Dim grafik As Graphics

        grafik = PictureBox1.CreateGraphics

        grafik.DrawRectangle(stift, 100, 100, 400, 250)

    End Sub

    Private Sub cmdText_Click(sender As System.Object, e As System.EventArgs) Handles cmdText.Click
        Dim schrift As New Font("Arial", 30, FontStyle.Italic)
        Dim grafik As Graphics

        grafik = PictureBox1.CreateGraphics

        grafik.DrawString("Servus", schrift, Brushes.BlueViolet, 70, 80)

    End Sub
End Class
