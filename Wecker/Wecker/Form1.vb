Public Class Form1
    Public weckzeit As String
    Public blinker As Boolean = False

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbTime.Text = Format(Now(), "HH:mm:ss")
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lbTime.Text = Format(Now(), "HH:mm:ss")
        If weckzeit & ":00" = lbTime.Text Then
            Timer2.Enabled = True
            Timer3.Enabled = True
            cmdAus.Enabled = True
            wmp1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub cmdWeckzeit_Click(sender As System.Object, e As System.EventArgs) Handles cmdWeckzeit.Click
fehler:
        weckzeit = InputBox("Bitte die Weckzeit im Format HH:MM eingeben!")

        If weckzeit = "" Then
            Exit Sub
        ElseIf IsNumeric(Mid(weckzeit, 1, 2)) And Mid(weckzeit, 3, 1) = ":" And IsNumeric(Mid(weckzeit, 4, 2)) And Len(weckzeit) = 5 Then
            If Mid(weckzeit, 1, 2) < 24 And Mid(weckzeit, 4, 2) < 60 Then
                MsgBox("Wecker gestellt!")
            Else
                MsgBox("Falsche Eingabe" & vbNewLine & "Versuchen Sie es nocheinmal")
                GoTo fehler
            End If
        Else
            MsgBox("Falsche Eingabe" & vbNewLine & "Versuchen Sie es nocheinmal")
            GoTo fehler
        End If
    End Sub

    Private Sub cmdRadioURL_Click(sender As System.Object, e As System.EventArgs) Handles cmdRadioURL.Click
        Dim url As String

        url = InputBox("Bitte den URL des Radio-Streams eingeben.", , "mms://apasf.apa.at/OE3_Live_Audio")

        wmp1.URL = url
        wmp1.Ctlcontrols.stop()
        cmdWeckzeit.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        wmp1.Ctlcontrols.stop()
        Timer3.Enabled = False
        cmdAus.Enabled = False

    End Sub

    Private Sub cmdAus_Click(sender As System.Object, e As System.EventArgs) Handles cmdAus.Click
        Timer3.Enabled = False
        Timer2.Enabled = False
        wmp1.Ctlcontrols.stop()

        cmdAus.BackColor = Color.LightGray
        blinker = False
        cmdAus.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If blinker = False Then
            cmdAus.BackColor = Color.Orange
            blinker = True
        Else
            cmdAus.BackColor = Color.LightGray
            blinker = False
        End If
    End Sub
End Class
