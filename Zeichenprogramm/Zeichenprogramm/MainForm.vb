Imports System.Drawing.Imaging

Public Class MainForm
    Public grafik As Graphics
    Public bgcolor As Color
    Public x1, x2, y1, y2 As Integer
    Public myWerkzeug As New Werkzeug
    Public drawing As Boolean
    Public drawingTemp As Bitmap
    Public radiererTemp As Bitmap
    Public history As New List(Of Bitmap)
    Public backpos As Integer = 0

    Sub modechangeForm()
        Select Case cbTyp.SelectedIndex
            Case 0
                If chbGefüllt.Checked = False Then
                    myWerkzeug.Mode = Werkzeug.Modus.rechteck
                Else
                    myWerkzeug.Mode = Werkzeug.Modus.rechteckVoll
                End If
            Case 1
                If chbGefüllt.Checked = False Then
                    myWerkzeug.Mode = Werkzeug.Modus.ellipse
                Else
                    myWerkzeug.Mode = Werkzeug.Modus.ellipseVoll
                End If
        End Select
    End Sub

    Sub fontlist()
        For Each ff As FontFamily In FontFamily.Families
            cbFont.Items.Add(ff.Name)
        Next
    End Sub

    Sub resetdraw()
        history.Clear()
        backpos = 0
        drawing = False
        grafik.Clear(bgcolor)
        PictureBox1.Refresh()
        Call saving()
        cmdBack.Enabled = False
        cmdForw.Enabled = False
    End Sub
    Sub saving()
        If backpos > 0 Then
            history.RemoveRange(history.Count - backpos, backpos)
            backpos = 0
            cmdForw.Enabled = False
        End If
        history.Add(New Bitmap(PictureBox1.Image))
        cmdBack.Enabled = True

    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call fontlist()
        bgcolor = cdBG.Color
        cbTyp.SelectedIndex = 0
        cbFont.SelectedIndex = 0
   
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        grafik = Graphics.FromImage(PictureBox1.Image)
        grafik.Clear(bgcolor)
        Call saving()
        cmdBack.Enabled = False

        myWerkzeug = New Werkzeug(cdFarbe.Color, numStaerke.Value, cbFont.SelectedItem, numFontsize.Value)

        lbColor.BackColor = myWerkzeug.Farbe
    End Sub


    Private Sub PictureBox1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Select Case myWerkzeug.Mode
                Case Werkzeug.Modus.stift
                    If drawing = False Then
                        drawing = True
                        drawingTemp = New Bitmap(PictureBox1.Image)
                    End If
                    myWerkzeug.Punkte = myWerkzeug.MausPosition
                    grafik.DrawLine(myWerkzeug.Stift, myWerkzeug.MausPosition.X, myWerkzeug.MausPosition.Y, e.X, e.Y)
                    PictureBox1.Refresh()
                Case Werkzeug.Modus.rechteck, Werkzeug.Modus.ellipse, Werkzeug.Modus.rechteckVoll, Werkzeug.Modus.ellipseVoll
                    If drawing = False Then
                        drawing = True
                        x1 = e.X
                        y1 = e.Y
                        drawingTemp = New Bitmap(PictureBox1.Image)

                    Else

                        x2 = e.X
                        y2 = e.Y

                        Dim b, h, startx, starty As Integer
                        If x2 < x1 Then
                            b = x1 - x2
                        Else
                            b = x2 - x1
                        End If

                        If y2 < y1 Then
                            h = y1 - y2
                        Else
                            h = y2 - y1
                        End If
                        startx = Math.Min(x1, x2)
                        starty = Math.Min(y1, y2)
                        PictureBox1.Image = New Bitmap(drawingTemp)
                        grafik = Graphics.FromImage(PictureBox1.Image)

                        Select Case myWerkzeug.Mode
                            Case Werkzeug.Modus.rechteck
                                grafik.DrawRectangle(myWerkzeug.Stift, startx, starty, b, h)
                            Case Werkzeug.Modus.ellipse
                                grafik.DrawEllipse(myWerkzeug.Stift, startx, starty, b, h)
                            Case Werkzeug.Modus.rechteckVoll
                                grafik.FillRectangle(myWerkzeug.BrushFarbe, startx, starty, b, h)
                            Case Werkzeug.Modus.ellipseVoll
                                grafik.FillEllipse(myWerkzeug.BrushFarbe, startx, starty, b, h)
                        End Select

                        PictureBox1.Refresh()
                    End If
                Case Werkzeug.Modus.radierer
                    If drawing = False Then
                        drawing = True
                        drawingTemp = New Bitmap(PictureBox1.Image)
                        radiererTemp = New Bitmap(PictureBox1.Image)
                    End If
                    myWerkzeug.Punkte = myWerkzeug.MausPosition
                    PictureBox1.Image = New Bitmap(radiererTemp)
                    grafik = Graphics.FromImage(PictureBox1.Image)
                    grafik.DrawLine(New Pen(bgcolor, numStaerke.Value), myWerkzeug.MausPosition.X, myWerkzeug.MausPosition.Y, e.X, e.Y)
                    radiererTemp.Dispose()
                    radiererTemp = New Bitmap(PictureBox1.Image)
                    grafik.DrawEllipse(Pens.Black, e.X - numStaerke.Value / 2, e.Y - numStaerke.Value / 2, numStaerke.Value, numStaerke.Value)
                    PictureBox1.Refresh()
            End Select
        End If
        myWerkzeug.MausPosition = New Point(e.X, e.Y)
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpeichernToolStripMenuItem.Click
        Dim antw As DialogResult

        antw = SaveFileDialog1.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FilterIndex = 1 Then
                PictureBox1.Image.Save(SaveFileDialog1.FileName, ImageFormat.Jpeg)
            Else
                PictureBox1.Image.Save(SaveFileDialog1.FileName, ImageFormat.Png)
            End If
        End If

    End Sub

    Private Sub LadenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LadenToolStripMenuItem.Click
        Dim antw As DialogResult

        antw = OpenFileDialog1.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            grafik = Graphics.FromImage(PictureBox1.Image)
            Call resetdraw()
        End If
    End Sub

    Private Sub numStaerke_ValueChanged(sender As Object, e As EventArgs) Handles numStaerke.ValueChanged
        myWerkzeug.Stärke = numStaerke.Value
    End Sub

    Private Sub cmdForm_Click(sender As Object, e As EventArgs) Handles cmdForm.Click
        pForm.Visible = True
        pStift.Visible = True
        pText.Visible = False
        cmdFarbe.Enabled = True

        Call modechangeForm
    End Sub

    Private Sub cmdStift_Click(sender As Object, e As EventArgs) Handles cmdStift.Click
        myWerkzeug.Mode = Werkzeug.Modus.stift
        pForm.Visible = False
        pStift.Visible = True
        pText.Visible = False
        cmdFarbe.Enabled = True
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Select Case myWerkzeug.Mode
            Case Werkzeug.Modus.stift
                If myWerkzeug.AnzahlPunkte > 1 Then
                    PictureBox1.Image = New Bitmap(drawingTemp)
                    grafik = Graphics.FromImage(PictureBox1.Image)
                    grafik.DrawLines(myWerkzeug.Stift, myWerkzeug.Punkte.ToArray)
                ElseIf myWerkzeug.AnzahlPunkte = 0 Then
                    grafik.FillRectangle(myWerkzeug.BrushFarbe, e.X, e.Y, myWerkzeug.Stärke, myWerkzeug.Stärke)
                End If
                myWerkzeug.Punkte.clear()
                PictureBox1.Refresh()
                drawing = False
                Call saving()
            Case Werkzeug.Modus.rechteck, Werkzeug.Modus.ellipse, Werkzeug.Modus.rechteckVoll, Werkzeug.Modus.ellipseVoll
                If drawing = True Then
                    drawing = False
                    Dim b, h, startx, starty As Integer

                    x2 = e.X
                    y2 = e.Y

                    If x2 < x1 Then
                        b = x1 - x2
                    Else
                        b = x2 - x1
                    End If

                    If y2 < y1 Then
                        h = y1 - y2
                    Else
                        h = y2 - y1
                    End If
                    startx = Math.Min(x1, x2)
                    starty = Math.Min(y1, y2)

                    Select Case myWerkzeug.Mode
                        Case Werkzeug.Modus.rechteck
                            grafik.DrawRectangle(myWerkzeug.Stift, startx, starty, b, h)
                        Case Werkzeug.Modus.ellipse
                            grafik.DrawEllipse(myWerkzeug.Stift, startx, starty, b, h)
                        Case Werkzeug.Modus.rechteckVoll
                            grafik.FillRectangle(myWerkzeug.BrushFarbe, startx, starty, b, h)
                        Case Werkzeug.Modus.ellipseVoll
                            grafik.FillEllipse(myWerkzeug.BrushFarbe, startx, starty, b, h)
                    End Select

                    PictureBox1.Refresh()
                    Call saving()
                End If
            Case Werkzeug.Modus.text
                grafik.DrawString(txtText.Text, myWerkzeug.Schrift, myWerkzeug.BrushFarbe, e.X, e.Y)
                PictureBox1.Refresh()
                Call saving()
            Case Werkzeug.Modus.radierer
                PictureBox1.Image = New Bitmap(drawingTemp)
                grafik = Graphics.FromImage(PictureBox1.Image)

                grafik.DrawLines(New Pen(bgcolor,numStaerke.Value), myWerkzeug.Punkte.ToArray)
                myWerkzeug.Punkte.Clear()

                PictureBox1.Refresh()
                drawing = False
                Call saving()
        End Select
    End Sub

    Private Sub cbTyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTyp.SelectedIndexChanged
        Call modechangeForm()
    End Sub

    Private Sub cmdText_Click(sender As Object, e As EventArgs) Handles cmdText.Click
        myWerkzeug.Mode = Werkzeug.Modus.text
        pForm.Visible = False
        pStift.Visible = False
        pText.Visible = True
        cmdFarbe.Enabled = True
    End Sub

    Private Sub numFontsize_ValueChanged(sender As Object, e As EventArgs) Handles numFontsize.ValueChanged
        myWerkzeug.Schriftgröße = numFontsize.Value
    End Sub

    Private Sub cbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFont.SelectedIndexChanged
        myWerkzeug.Schriftart = cbFont.SelectedItem
    End Sub

    Private Sub cmdFarbe_Click(sender As Object, e As EventArgs) Handles cmdFarbe.Click
        Dim antw As DialogResult
        cdFarbe.Color = myWerkzeug.Farbe
        antw = cdFarbe.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            myWerkzeug.Farbe = cdFarbe.Color
            lbColor.BackColor = cdFarbe.Color
        End If
    End Sub

    Private Sub GößeÄndernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GößeÄndernToolStripMenuItem.Click
        Groesse.txtX.Text = PictureBox1.Width
        Groesse.txtY.Text = PictureBox1.Height
        Groesse.ShowDialog()
    End Sub

    Private Sub ArbeitsflächeLeerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArbeitsflächeLeerenToolStripMenuItem.Click
        grafik.Clear(bgcolor)
        PictureBox1.Refresh()
        Call resetdraw()
    End Sub

    Private Sub cmdRad_Click(sender As Object, e As EventArgs) Handles cmdRad.Click
        myWerkzeug.Mode = Werkzeug.Modus.radierer
        pForm.Visible = False
        pStift.Visible = True
        pText.Visible = False
        cmdFarbe.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        backpos += 1
        cmdForw.Enabled = True
        If backpos = history.Count - 1 Then
            cmdBack.Enabled = False
        End If
        PictureBox1.Image = New Bitmap(history.Item(history.Count - (backpos + 1)))
        grafik = Graphics.FromImage(PictureBox1.Image)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdForw.Click
        backpos -= 1
        cmdBack.Enabled = True
        If backpos = 0 Then
            cmdForw.Enabled = False
        End If
        PictureBox1.Image = New Bitmap(history(history.Count - (backpos + 1)))
        grafik = Graphics.FromImage(PictureBox1.Image)
    End Sub

    Private Sub chbGefüllt_CheckedChanged(sender As Object, e As EventArgs) Handles chbGefüllt.CheckedChanged
        Call modechangeForm()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Me.Cursor = Cursors.Cross
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        me.Cursor=Cursors.Default
    End Sub

    Private Sub HintergrundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HintergrundToolStripMenuItem.Click
        Dim antw As DialogResult
        cdBG.Color = bgcolor
        antw = cdFarbe.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            bgcolor = cdFarbe.Color
            Call resetdraw()
        End If
    End Sub
End Class
