Public Class Form1

    Private Sub cmdStart_Click(sender As System.Object, e As System.EventArgs) Handles cmdStart.Click
        mp1.Ctlcontrols.play()

    End Sub

    Private Sub cmdStop_Click(sender As System.Object, e As System.EventArgs) Handles cmdStop.Click
        mp1.Ctlcontrols.stop()

    End Sub

    Private Sub cmdChange_Click(sender As System.Object, e As System.EventArgs) Handles cmdChange.Click
        
        Call change()



    End Sub

    Sub change()
        Dim pos As Integer

        If lstRadioURL.SelectedIndex > -1 Then
            mp1.Ctlcontrols.stop()

            pos = lstRadioURL.SelectedIndex

            mp1.URL = lstRadioURL.Items(pos)

            mp1.Ctlcontrols.play()
        Else
            MsgBox("Stream auswählen!")


        End If
    End Sub


    Private Sub cmdAddURL_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddURL.Click
        If txtURL.Text <> "" Then
            lstRadioURL.Items.Add(txtURL.Text)

        End If
    End Sub

    Private Sub EndeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EndeToolStripMenuItem.Click
        End

    End Sub

    Private Sub MinimierenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimierenToolStripMenuItem.Click
        Me.Width = 150
        Me.Height = 200

        mp1.Visible = False

        lstRadioURL.Visible = False
        txtURL.Visible = False
        cmdAddURL.Visible = False

        cmdChange.Visible = False

        tbVolume.Value = mp1.settings.volume

        tbVolume.Visible = True

        cmdStart.Left = 20
        cmdStop.Left = 20
        tbVolume.Left = 20





    End Sub

    Private Sub MaximierenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaximierenToolStripMenuItem.Click
        Me.Width = 607
        Me.Height = 324

        mp1.Visible = True

        lstRadioURL.Visible = True
        txtURL.Visible = True
        cmdAddURL.Visible = True

        cmdChange.Visible = True

        cmdStart.Left = 486
        cmdStop.Left = 486
        tbVolume.Visible = False


    End Sub

    Private Sub FarbeÄndernToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FarbeÄndernToolStripMenuItem.Click
        Dim antw As DialogResult


        antw = ColorDialog1.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color

        End If



    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mp1.Ctlcontrols.stop()

        ColorDialog1.Color = Me.BackColor
        FontDialog1.Font = cmdAddURL.Font


    End Sub

    Private Sub SchriftartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SchriftartToolStripMenuItem.Click

        Dim antw As DialogResult


        antw = FontDialog1.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            cmdAddURL.Font = FontDialog1.Font
            cmdChange.Font = FontDialog1.Font
            cmdStart.Font = FontDialog1.Font
            cmdStop.Font = FontDialog1.Font

        End If


    End Sub

    Private Sub HintergrundbildToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HintergrundbildToolStripMenuItem.Click
        Dim antw As DialogResult


        antw = OpenFileDialog1.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            Me.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)


        End If
    End Sub

    Private Sub lstRadioURL_DoubleClick(sender As Object, e As EventArgs) Handles lstRadioURL.DoubleClick
        Call change()

    End Sub

    Private Sub tbVolume_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        mp1.settings.volume = tbVolume.Value


    End Sub
End Class
