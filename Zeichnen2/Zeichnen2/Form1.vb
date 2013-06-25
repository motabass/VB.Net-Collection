Public Class Form1
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim cx, cy As Integer
        Dim p(7) As Point
        Dim grafik As Graphics
        Dim stift As New Pen(Color.Red)


        grafik = CreateGraphics()

        cx = ClientSize.Width
        cy = ClientSize.Height

        p(0) = New Point(1 / 4 * cx, 3 / 4 * cy)
        p(1) = New Point(1 / 4 * cx, 1 / 2 * cy)
        p(2) = New Point(1 / 2 * cx, 1 / 4 * cy)
        p(3) = New Point(3 / 4 * cx, 1 / 2 * cy)
        p(4) = New Point(3 / 4 * cx, 3 / 4 * cy)
        p(5) = p(0)
        p(6) = p(1)
        p(7) = p(3)

        grafik.DrawLines(stift, p)


        MyBase.OnPaint(e)
    End Sub



    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Invalidate()
    End Sub
End Class
