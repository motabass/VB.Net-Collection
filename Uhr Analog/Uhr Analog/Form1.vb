Public Class Form1

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim cx, cy As Integer
        Dim mix, miy As Integer
        Dim rad As Integer
        Dim x, y As Integer
        Dim stift As New Pen(Color.Black, 2)
        Dim stift2 As New Pen(Color.Black, 3)
        Dim stift3 As New Pen(Color.Black, 5)
        Dim grafik As Graphics

        grafik = PictureBox1.CreateGraphics

        cx = PictureBox1.Width
        cy = PictureBox1.Height

        mix = 1 / 2 * cx
        miy = 1 / 2 * cy

        rad = Math.Min(cx, cy) / 2 * 0.95

        x = mix - rad
        y = miy - rad

        grafik.Clear(SystemColors.Control)
        grafik.FillEllipse(Brushes.Brown, x, y, 2 * rad, 2 * rad)
        grafik.DrawEllipse(stift, x, y, 2 * rad, 2 * rad)

        x = mix + (rad * 0.95) * Math.Sin(Second(Now) * 6 / 180 * Math.PI)
        y = miy - (rad * 0.95) * Math.Cos(Second(Now) * 6 / 180 * Math.PI)

        grafik.DrawLine(stift, mix, miy, x, y)

        x = mix + (rad * 0.8) * Math.Sin(Minute(Now) * 6 / 180 * Math.PI)
        y = miy - (rad * 0.8) * Math.Cos(Minute(Now) * 6 / 180 * Math.PI)

        grafik.DrawLine(stift2, mix, miy, x, y)

        x = mix + (rad * 0.65) * Math.Sin((Hour(Now) + Minute(Now) / 60) * 30 / 180 * Math.PI)
        y = miy - (rad * 0.65) * Math.Cos((Hour(Now) + Minute(Now) / 60) * 30 / 180 * Math.PI)

        grafik.DrawLine(stift3, mix, miy, x, y)


    End Sub
End Class
