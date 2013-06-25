Public Class Form1
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim stift As New Pen(Brushes.Black, 1)
        Dim grafik As Graphics
        Dim i, j As Integer
        Dim x, y As Integer

        x = Me.Width / 2
        y = Me.Height / 2

        grafik = CreateGraphics()

        grafik.Clear(System.Drawing.SystemColors.Control)
        For i = 0 To 200 Step 5
            grafik.DrawRectangle(stift, x - i, y - i, 2 + j, 2 + j)
            j += 10
        Next

        MyBase.OnPaint(e)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Invalidate()
    End Sub

End Class
