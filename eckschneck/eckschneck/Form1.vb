Public Class Form1
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim grafik As Graphics
        Dim stift As New Pen(Brushes.Black, 2)

        grafik = CreateGraphics()
        grafik.Clear(System.Drawing.SystemColors.Control)


        Dim mitte As Point
        Dim strecke As Integer = 10

        mitte.X = ClientSize.Width / 2
        mitte.Y = ClientSize.Height / 2
        For strecke = 10 To 1000 Step 10
            grafik.DrawLine(stift, mitte.X, mitte.Y, mitte.X, mitte.Y + strecke)
            mitte.Y += strecke
            grafik.DrawLine(stift, mitte.X, mitte.Y, mitte.X + strecke, mitte.Y)
            mitte.X += strecke

            strecke += 10
            grafik.DrawLine(stift, mitte.X, mitte.Y, mitte.X, mitte.Y - strecke)
            mitte.Y -= strecke
            grafik.DrawLine(stift, mitte.X, mitte.Y, mitte.X - strecke, mitte.Y)
            mitte.X -= strecke
        Next

    End Sub
End Class
