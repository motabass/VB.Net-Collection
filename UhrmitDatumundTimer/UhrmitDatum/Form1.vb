Public Class Form1
    Public startzeit As TimeSpan
    Public stopzeit As TimeSpan
    Public startstop As Boolean = False


    Sub anaclock()
        Dim cx, cy As Integer
        Dim mix, miy As Integer
        Dim rad As Integer
        Dim x, y As Integer
        Dim stift As New Pen(Color.Black, 1)
        Dim stift2 As New Pen(Color.Black, 2)
        Dim stift3 As New Pen(Color.Black, 3)
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
        grafik.FillEllipse(Brushes.Teal, x, y, 2 * rad, 2 * rad)
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
    Sub starttimer()
        cmdStart.Text = "Stop"
        If lbSW.Text = "0:00:00:000" Then
            startzeit = Now.TimeOfDay
        Else
            startzeit = Now.TimeOfDay.Subtract(stopzeit)
        End If

        Timer2.Enabled = True

        cmdReset.Enabled = False
        ResetToolStripMenuItem.Enabled = False
        cmdZwischen.Enabled = True
        startstop = True
    End Sub

    Sub stoptimer()
        Dim zeitdiff As TimeSpan

        zeitdiff = Now.TimeOfDay.Subtract(startzeit)

        lbSW.Text = zeitdiff.Hours & ":" & zeitdiff.Minutes.ToString("00") & ":" & zeitdiff.Seconds.ToString("00") & ":" & zeitdiff.Milliseconds.ToString("000")

        stopzeit = zeitdiff

        cmdStart.Text = "Start"
        Timer2.Enabled = False

        cmdReset.Enabled = True
        ResetToolStripMenuItem.Enabled = True
        cmdZwischen.Enabled = False
        startstop = False
    End Sub

    Sub timerreset()
        lbSW.Text = "0:00:00:000"
        cmdStart.Enabled = True
        cmdReset.Enabled = False
        ResetToolStripMenuItem.Enabled = False
        lstZwischen.Items.Clear()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTime.Text = Format(Now(), "HH:mm:ss")
        lbDate.Text = Format(Now(), "dddd, d.MMMM yyyy")

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTime.Text = Format(Now(), "HH:mm:ss")
        lbDate.Text = Format(Now(), "dddd, d.MMMM yyyy")
        Me.Refresh()
        Call anaclock()

    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        If startstop = False Then
            Call starttimer()
        Else
            Call stoptimer()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim zeitdiff As TimeSpan

        zeitdiff = Now.TimeOfDay.Subtract(startzeit)

        lbSW.Text = zeitdiff.Hours & ":" & zeitdiff.Minutes.ToString("00") & ":" & zeitdiff.Seconds.ToString("00") & ":" & zeitdiff.Milliseconds.ToString("000")
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        Call timerreset()
    End Sub

    Private Sub cmdZwischen_Click(sender As Object, e As EventArgs) Handles cmdZwischen.Click
        lstZwischen.Items.Add(lbSW.Text)
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Call starttimer()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StopToolStripMenuItem.Click
        Call stoptimer()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Call timerreset()
    End Sub
End Class
