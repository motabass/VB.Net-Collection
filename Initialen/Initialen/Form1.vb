Public Class Form1
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim stift As New Pen(Brushes.Black, 4)
        Dim grafik As Graphics
        Dim x, y As Integer
        Dim i, j As Decimal

        x = 30
        y = 80


        grafik = CreateGraphics()


        grafik.Clear(System.Drawing.SystemColors.Control)

        For i = 0 To 50
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
        Next

        For i = 50 To 0 Step -1
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
            j += 0.5
        Next

        For i = 0 To 50
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
            j += 0.5
        Next

        For i = 50 To 0 Step -1
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
        Next


        x = 50

        For i = 0 To 50
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
        Next

        For i = 50 To 0 Step -1
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
            j += 0.5
        Next

        For i = 0 To 50
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
            j += 0.5
        Next

        For i = 50 To 0 Step -1
            grafik.DrawRectangle(stift, x + j, y - i, 1, 1)
        Next




        MyBase.OnPaint(e)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Invalidate()
    End Sub
End Class
