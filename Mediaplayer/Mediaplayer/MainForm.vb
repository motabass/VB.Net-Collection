Public Class MainForm
#Region "Declarations"
    Public mute As Boolean = False
    Public pause As Boolean = True
    Public stopatendof As Boolean = False
    Public repeat As Integer = 0
    Public nowplayurl As String
    Public collapse As Boolean = False

    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
#End Region

#Region "Subs"
    Sub playclick()
        If pause = True Then
            Call abspielen()
        Else
            wmp.Ctlcontrols.pause()
        End If
    End Sub
    Sub abspielen()
        Dim eintrag As New Musikdatei

        eintrag = lstFiles.SelectedItem
        If wmp.playState = WMPLib.WMPPlayState.wmppsPaused Then
            wmp.Ctlcontrols.play()
        ElseIf lstFiles.SelectedIndices.Count > 0 Then

            wmp.URL = eintrag.Pfad
            nowplayurl = wmp.URL
            wmp.Ctlcontrols.play()
        End If
    End Sub

    Sub getinfo()
        Dim eintrag As Musikdatei

        eintrag = lstFiles.SelectedItem
        lbStatusItem.Text = wmp.Ctlcontrols.currentItem.sourceURL

        If wmp.Ctlcontrols.currentItem.getItemInfo("Title") <> "" Then
            lbTitel.Text = wmp.Ctlcontrols.currentItem.getItemInfo("Title")
            Me.Text = wmp.Ctlcontrols.currentItem.getItemInfo("Title")
        Else
            lbTitel.Text = eintrag.Titel
            Me.Text = eintrag.Titel
        End If

        If wmp.Ctlcontrols.currentItem.getItemInfo("Artist") <> "" Then
            lbArtist.Text = "Interpret: " & wmp.Ctlcontrols.currentItem.getItemInfo("Artist")
            Me.Text = wmp.Ctlcontrols.currentItem.getItemInfo("Artist") & " - " & wmp.Ctlcontrols.currentItem.getItemInfo("Title")
        Else
            lbArtist.Text = "Interpret: Unbekannt"
        End If

        If wmp.Ctlcontrols.currentItem.getItemInfo("Album") <> "" Then
            lbAlbum.Text = "Album: " & wmp.Ctlcontrols.currentItem.getItemInfo("Album")
        Else
            lbAlbum.Text = "Album: Unbekannt"
        End If
        contInfos.Items(0).Visible = True
    End Sub

    Sub nextentry()
        If lstFiles.Items.Count > 0 Then
            Dim indexzahl As Integer
            Dim myMP3 As ID3TagLibrary.MP3File
            Dim pfadarray() As String

            pfadarray = Split(nowplayurl, "\")

            myMP3 = New ID3TagLibrary.MP3File(nowplayurl)
            indexzahl = lstFiles.FindStringExact(myMP3.Title)
            If indexzahl = -1 Then
                indexzahl = lstFiles.FindStringExact(Mid(pfadarray(pfadarray.Count - 1), 1, Len((pfadarray(pfadarray.Count - 1))) - 4))
            End If
            If lstFiles.Items.Count > 0 And indexzahl < 0 Then
                lstFiles.SetSelected(0, True)
                Me.BeginInvoke(New MethodInvoker(AddressOf abspielen))
            ElseIf indexzahl < lstFiles.Items.Count - 1 Then
                lstFiles.ClearSelected()
                lstFiles.SetSelected(indexzahl + 1, True)

                Me.BeginInvoke(New MethodInvoker(AddressOf abspielen))
            End If
        End If

    End Sub
    Sub lastentry()
        Dim indexzahl As Integer
        If lstFiles.SelectedIndices.Count > 0 Then
            Dim myMP3 As ID3TagLibrary.MP3File
            Dim pfadarray() As String

            pfadarray = Split(nowplayurl, "\")

            myMP3 = New ID3TagLibrary.MP3File(nowplayurl)
            indexzahl = lstFiles.FindStringExact(myMP3.Title)
            If indexzahl = -1 Then
                indexzahl = lstFiles.FindStringExact(Mid(pfadarray(pfadarray.Count - 1), 1, Len((pfadarray(pfadarray.Count - 1))) - 4))
            End If
            If wmp.Ctlcontrols.currentPosition < 3 Then
                If indexzahl = -1 Then
                    lstFiles.SetSelected(0, True)
                    Me.BeginInvoke(New MethodInvoker(AddressOf abspielen))
                Else
                    If indexzahl > 0 Then

                        lstFiles.SetSelected(indexzahl, False)
                        lstFiles.SetSelected(indexzahl - 1, True)

                        Me.BeginInvoke(New MethodInvoker(AddressOf abspielen))
                    End If
                End If
            Else
                wmp.Ctlcontrols.currentPosition = 0
            End If
        End If
    End Sub
#End Region

#Region "Events"
#Region "Form"
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

        Dim defaultpl As New System.IO.FileInfo(My.Application.Info.DirectoryPath & "\default.pls")

        wmp.uiMode = "none"
        wmp.stretchToFit = True
        wmp.enableContextMenu = False
        wmp.settings.volume = 100
        tbVolume.Value = wmp.settings.volume

        If defaultpl.Exists = True Then
            lstFiles.AddPLS(My.Application.Info.DirectoryPath & "\default.pls")
        End If
        contInfos.Items(0).Visible = False
        lbItems.Text = lstFiles.Items.Count
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.F) Then
            wmp.fullScreen = True
            e.Handled = True
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.Right) Then
            Call nextentry()
            e.Handled = True
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.Left) Then
            Call lastentry()
            e.Handled = True
        ElseIf GetKeyPress(Keys.Space) Then
            Call playclick()
            e.Handled = True
        End If
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If lstFiles.bgwAddFiles.IsBusy Then
        '    lstFiles.bgwAddFiles.CancelAsync()
        'End If
        lstFiles.SavePLS(My.Application.Info.DirectoryPath & "\default.pls")
    End Sub
#End Region

#Region "FileAdd"""
    Private Sub itemchange(itcount As Integer) Handles lstFiles.ItemsChanged
        lbItems.Text = "Items: " & itcount
    End Sub
    Private Sub fastart() Handles lstFiles.FileAddStarted
        pbStatusProgress.Value = 0
        pbStatusProgress.Visible = True
        cmdStatusCancel.Visible = True
    End Sub
    Private Sub faprog(prozent As Integer, element As String) Handles lstFiles.FileAddProgressChanged
        pbStatusProgress.Value = prozent
        lbStatusItem.Text = element
    End Sub
    Private Sub fafinished() Handles lstFiles.FileAddFinished
        pbStatusProgress.Visible = False
        cmdStatusCancel.Visible = False
        lbStatusItem.Text = ""
    End Sub
#End Region

#Region "Timer"
    Private Sub hotkeys(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHotkeys.Tick
        If CBool(GetKeyPress(Keys.Escape)) Then
            wmp.fullScreen = False
        End If
    End Sub
    Private Sub position(sender As Object, e As EventArgs) Handles tmrPosition.Tick
        If wmp.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Try
                tbPosition.Value = wmp.Ctlcontrols.currentPosition
                lbTime.Text = wmp.Ctlcontrols.currentPositionString & "/" & wmp.Ctlcontrols.currentItem.durationString
            Catch
            End Try
        End If
    End Sub
#End Region

#Region "Playlist"
    Private Sub lstFiles_DoubleClick(sender As Object, e As EventArgs) Handles lstFiles.DoubleClick
        Call abspielen()
    End Sub
    Private Sub lstFiles_KeyDown(sender As Object, e As KeyEventArgs) Handles lstFiles.KeyDown
        If e.KeyValue = Keys.Delete Then
            lstFiles.Delete()
        End If
    End Sub

    Private Sub lstFiles_DragDrop(sender As Object, e As DragEventArgs) Handles lstFiles.DragDrop
        Dim pfade As String()
        pfade = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
        If IO.Directory.Exists(pfade(0)) Then
            lstFiles.AddDir(pfade(0))
        Else
            lstFiles.AddFile(pfade)
        End If
    End Sub
    Private Sub lstFiles_DragEnter(sender As Object, e As DragEventArgs) Handles lstFiles.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub txtSuche_TextChanged(sender As Object, e As EventArgs) Handles txtSuche.TextChanged
        lstFiles.Search(txtSuche.Text)
    End Sub
#End Region

    Private Sub wmp1_PlayStateChange(sender As System.Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles wmp.PlayStateChange
        Dim eintragtest As New Musikdatei

        If wmp.playState = WMPLib.WMPPlayState.wmppsMediaEnded Then
            If stopatendof = True Then
                wmp.Ctlcontrols.stop()
                stopatendof = False
                contStop.Items(1).Visible = True
                contStop.Items(2).Visible = False
            Else
                eintragtest = lstFiles.Items(lstFiles.Items.Count - 1)
                Select Case repeat

                    Case 1
                        Me.BeginInvoke(New MethodInvoker(AddressOf abspielen))
                    Case 2
                        lstFiles.ClearSelected()
                        lstFiles.SetSelected(0, True)
                        Me.BeginInvoke(New MethodInvoker(AddressOf abspielen))
                    Case 0
                        Call nextentry()
                End Select
            End If
        End If

        If wmp.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Dim eintrag As New Musikdatei

            eintrag = lstFiles.SelectedItem


            Dim infoThread As System.Threading.Thread

            infoThread = New Threading.Thread(AddressOf getinfo)
            infoThread.Start()


            'Call getinfo()
            cmdPlay.Image = My.Resources.pause
            pause = False
            If Mid(eintrag.Pfad, 2, 1) = ":" Then
                tbPosition.Enabled = True
                tbPosition.Maximum = wmp.Ctlcontrols.currentItem.duration
                tmrPosition.Enabled = True
            Else
                tmrPosition.Enabled = False
                tbPosition.Enabled = False
            End If
        End If

        If wmp.playState = WMPLib.WMPPlayState.wmppsStopped Then
            tmrPosition.Enabled = False
            tbPosition.Value = 0
            tbPosition.Enabled = False
            lbStatusItem.Text = ""
            lbTitel.Text = ""
            lbAlbum.Text = ""
            lbArtist.Text = ""
            contInfos.Items(0).Visible = False
            Me.Text = "Mediaplayer"
            cmdPlay.Image = My.Resources.play
            pause = True
        End If

        If wmp.playState = WMPLib.WMPPlayState.wmppsPaused Then
            cmdPlay.Image = My.Resources.play
            pause = True
        End If
    End Sub
#End Region

#Region "Commands"
    Private Sub cmdCollPlaylist_Click(sender As Object, e As EventArgs) Handles cmdCollPlaylist.Click
        If SplitContainer1.Panel1Collapsed = False Then
            SplitContainer1.Panel1Collapsed = True
            cmdCollPlaylist.Text = ">"
        Else
            SplitContainer1.Panel1Collapsed = False
            cmdCollPlaylist.Text = "<"
            'Me.MinimumSize = New Size(Me.MinimumSize.Width + 400, Me.MinimumSize.Height)
        End If
    End Sub

    Private Sub cmdUp_Click(sender As System.Object, e As System.EventArgs) Handles cmdUp.Click
        lstFiles.MoveUp()
    End Sub
    Private Sub cmdDown_Click(sender As System.Object, e As System.EventArgs) Handles cmdDown.Click
        lstFiles.MoveDown()
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles cmdStatusCancel.ButtonClick
        lstFiles.bgwAddFiles.CancelAsync()
    End Sub

#Region "MenuStrip"
    Private Sub NachObenVerschiebenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NachObenVerschiebenToolStripMenuItem.Click
        lstFiles.MoveUp()
    End Sub
    Private Sub NachUntenVerschiebenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NachUntenVerschiebenToolStripMenuItem.Click
        lstFiles.MoveDown()
    End Sub
    Private Sub AusgewählteLöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusgewählteLöschenToolStripMenuItem.Click
        lstFiles.Delete()
    End Sub
    Private Sub ListeLeerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeLeerenToolStripMenuItem.Click
        lstFiles.ClearList()
    End Sub
    Private Sub DateiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateiToolStripMenuItem.Click
        Dim antw As DialogResult

        antw = ofdFiles.ShowDialog()

        If antw = Windows.Forms.DialogResult.OK Then
            lstFiles.AddFile(ofdFiles.FileNames)
        End If
    End Sub
    Private Sub URLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles URLToolStripMenuItem.Click
        lstFiles.AddURL()
    End Sub
    Private Sub SpeichernToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click
        Dim antw As DialogResult
        Dim pfad As String

        antw = ofdPlaylist.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            pfad = ofdPlaylist.FileName
            If Mid(pfad, Len(pfad) - 2, 3) = "pls" Then
                lstFiles.AddPLS(ofdPlaylist.FileName)
            ElseIf Mid(pfad, Len(pfad) - 2, 3) = "m3u" Then
                lstFiles.AddM3U(ofdPlaylist.FileName)
            End If
        End If
    End Sub
    Private Sub LadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LadToolStripMenuItem.Click
        Dim antw As DialogResult


        antw = sfdPlaylist.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            If sfdPlaylist.FilterIndex = 1 Then
                lstFiles.SavePLS(sfdPlaylist.FileName)
            ElseIf sfdPlaylist.FilterIndex = 2 Then
                lstFiles.SaveM3U(sfdPlaylist.FileName)
            End If
        End If
    End Sub
    Private Sub OrdnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdnerToolStripMenuItem.Click
        Dim antw As DialogResult
        antw = FolderBrowserDialog1.ShowDialog
        If antw = Windows.Forms.DialogResult.OK Then
            lstFiles.AddDir(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
#End Region

#Region "ContextMenu"
    Private Sub AmEndeDesTitelsStoppenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmEndeDesTitelsStoppenToolStripMenuItem.Click
        stopatendof = True
        contStop.Items(1).Visible = False
        contStop.Items(2).Visible = True
    End Sub
    Private Sub NachEndeDesTitelsStoppenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NachEndeDesTitelsStoppenToolStripMenuItem.Click
        stopatendof = False
        contStop.Items(1).Visible = True
        contStop.Items(2).Visible = False
    End Sub
    Private Sub DateiInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateiInfoToolStripMenuItem.Click

        If wmp.URL <> "" Then
            Dim ts As TimeSpan = Now.AddSeconds(wmp.Ctlcontrols.currentItem.getItemInfo("Duration")).Subtract(Now)

            My.Forms.Infos.lbArtist.Text = wmp.Ctlcontrols.currentItem.getItemInfo("Artist")
            My.Forms.Infos.lbTitel.Text = wmp.Ctlcontrols.currentItem.getItemInfo("Title")
            My.Forms.Infos.lbAlbum.Text = wmp.Ctlcontrols.currentItem.getItemInfo("Album")
            My.Forms.Infos.lbTrack.Text = wmp.Ctlcontrols.currentItem.getItemInfo("WM/TrackNumber")
            My.Forms.Infos.lbLaenge.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Truncate(ts.TotalHours), ts.Minutes, ts.Seconds)
            My.Forms.Infos.lbJahr.Text = wmp.Ctlcontrols.currentItem.getItemInfo("WM/Year")
            My.Forms.Infos.lbBitrate.Text = Mid(wmp.Ctlcontrols.currentItem.getItemInfo("Bitrate"), 1, 3) & " kbit/s"
            My.Forms.Infos.ShowDialog()
        End If
    End Sub
#End Region

#Region "Media"
    Private Sub cmdPlay_Click(sender As System.Object, e As System.EventArgs) Handles cmdPlay.Click
        Call playclick()
    End Sub
    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        wmp.Ctlcontrols.stop()
    End Sub
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        Call nextentry()
    End Sub
    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        Call lastentry()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdRepeat.Click
        Select Case repeat
            Case 0
                cmdRepeat.BackColor = Color.Orange
                repeat = 1
            Case 1
                cmdRepeat.BackColor = Color.Red
                repeat = 2
            Case 2
                cmdRepeat.BackColor = Color.Transparent
                repeat = 0
        End Select
    End Sub
    Private Sub cmdMute_Click(sender As Object, e As EventArgs) Handles cmdMute.Click
        If mute = False Then
            cmdMute.BackColor = Color.Orange
            tbVolume.Value = 0
            wmp.settings.mute = True
            tbVolume.Enabled = False
            mute = True
        Else
            cmdMute.BackColor = Color.Transparent
            tbVolume.Enabled = True
            wmp.settings.mute = False
            tbVolume.Value = wmp.settings.volume
            mute = False
        End If
    End Sub
    Private Sub cmdFullscreen_Click(sender As System.Object, e As System.EventArgs) Handles cmdFullscreen.Click
        If wmp.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            wmp.fullScreen = True
        End If
    End Sub

    Private Sub tbPosition_MouseDown(sender As Object, e As MouseEventArgs) Handles tbPosition.MouseDown
        Dim wert, xstart, mouseon, frac As Single

        xstart = tbPosition.Location.X
        mouseon = e.X
        frac = mouseon / tbPosition.Width
        wert = tbPosition.Maximum * frac
        tbPosition.Value = CInt(wert)
        wmp.Ctlcontrols.currentPosition = tbPosition.Value
    End Sub
    Private Sub tbVolume_MouseDown(sender As Object, e As MouseEventArgs) Handles tbVolume.MouseDown
        Dim wert, xstart, mouseon, frac As Single

        xstart = tbVolume.Location.X
        mouseon = e.X
        frac = mouseon / tbVolume.Width
        wert = tbVolume.Maximum * frac
        tbVolume.Value = CInt(wert)
        wmp.settings.volume = tbVolume.Value
    End Sub

    Private Sub tbPosition_Scroll(sender As Object, e As EventArgs) Handles tbPosition.Scroll
        wmp.Ctlcontrols.currentPosition = tbPosition.Value
    End Sub
    Private Sub tbVolume_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        wmp.settings.volume = tbVolume.Value
        lbVolume.Text = tbVolume.Value & "%"
        lbStatusItem.Text = "Lautstärke (" & tbVolume.Value & "%)"
    End Sub
#End Region

#Region "Tooltips"
    Private Sub cmdStop_MouseEnter(sender As Object, e As EventArgs) Handles cmdStop.MouseEnter
        lbStatusItem.Text = "Stop (Rechtsklick möglich)"
    End Sub
    Private Sub cmdPlay_MouseEnter(sender As Object, e As EventArgs) Handles cmdPlay.MouseEnter
        lbStatusItem.Text = "Play/Pause"
    End Sub
    Private Sub cmdLast_MouseEnter(sender As Object, e As EventArgs) Handles cmdLast.MouseEnter
        lbStatusItem.Text = "Vorherigen Titel abspielen"
    End Sub
    Private Sub cmdNext_MouseEnter(sender As Object, e As EventArgs) Handles cmdNext.MouseEnter
        lbStatusItem.Text = "Nächsten Titel abspielen"
    End Sub
    Private Sub cmdRepeat_MouseEnter(sender As Object, e As EventArgs) Handles cmdRepeat.MouseEnter
        lbStatusItem.Text = "Repeat (Grau: Aus - Orange: 1 - Rot: Alle)"
    End Sub
    Private Sub cmdFullscreen_MouseEnter(sender As Object, e As EventArgs) Handles cmdFullscreen.MouseEnter
        lbStatusItem.Text = "Vollbild-Modus (Verlassen mit Escape)"
    End Sub
    Private Sub cmdMute_MouseEnter(sender As Object, e As EventArgs) Handles cmdMute.MouseEnter
        lbStatusItem.Text = "Stumm schalten"
    End Sub
    Private Sub tbPosition_MouseEnter(sender As Object, e As EventArgs) Handles tbPosition.MouseEnter
        lbStatusItem.Text = "Aktuelle Position"
    End Sub
    Private Sub tbVolume_MouseEnter(sender As Object, e As EventArgs) Handles tbVolume.MouseEnter
        lbStatusItem.Text = "Lautstärke (" & tbVolume.Value & "%)"
        lbVolume.Text = tbVolume.Value & "%"
    End Sub
    Private Sub cmdUp_MouseEnter(sender As Object, e As EventArgs) Handles cmdUp.MouseEnter
        lbStatusItem.Text = "Ausgewählte Titel nach oben verschieben"
    End Sub
    Private Sub cmdDown_MouseEnter(sender As Object, e As EventArgs) Handles cmdDown.MouseEnter
        lbStatusItem.Text = "Ausgewählte Titel nach unten verschieben"
    End Sub

    Private Sub cmdStop_MouseLeave(sender As Object, e As EventArgs) Handles cmdStop.MouseLeave, cmdDown.MouseLeave, cmdUp.MouseLeave, tbPosition.MouseLeave, tbVolume.MouseLeave, cmdMute.MouseLeave, cmdFullscreen.MouseLeave, cmdStop.MouseLeave, cmdPlay.MouseLeave, cmdLast.MouseLeave, cmdNext.MouseLeave
        lbStatusItem.Text = wmp.URL
        lbVolume.Text = "Vol"
    End Sub
#End Region
#End Region
End Class