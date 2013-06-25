Public Class Form1
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)


        Dim stift As New Pen(Brushes.Black, 1)
        Dim grafik As Graphics
        Dim mix, miy As Integer
        Dim x, y As Integer
        Dim r, winkel, k As Decimal
        Dim points(3600) As Point

        k = 0.07

        mix = Me.Width / 2
        miy = Me.Height / 2

        grafik = CreateGraphics()
        grafik.Clear(System.Drawing.SystemColors.Control)

        For winkel = 0 To 3600
            x = mix + r * Math.Sin(winkel * Math.PI / 180)
            y = miy + r * Math.Cos(winkel * Math.PI / 180)
            r = winkel * k
            points(winkel) = New Point(x, y)
        Next
        grafik.DrawLines(stift, points)
    End Sub



    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Invalidate()
    End Sub
End Class
