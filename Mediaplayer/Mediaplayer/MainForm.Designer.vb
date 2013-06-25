<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.ofdFiles = New System.Windows.Forms.OpenFileDialog()
        Me.contInfos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DateiInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.tbPosition = New System.Windows.Forms.TrackBar()
        Me.tbVolume = New System.Windows.Forms.TrackBar()
        Me.lbVolume = New System.Windows.Forms.Label()
        Me.contStop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StoppenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmEndeDesTitelsStoppenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachEndeDesTitelsStoppenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrPosition = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.URLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachObenVerschiebenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachUntenVerschiebenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusgewählteLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeLeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdMute = New System.Windows.Forms.Button()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdRepeat = New System.Windows.Forms.Button()
        Me.cmdFullscreen = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.cmdStatusCancel = New System.Windows.Forms.ToolStripSplitButton()
        Me.pbStatusProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.lbStatusItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbItems = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdCollPlaylist = New System.Windows.Forms.Button()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.ofdPlaylist = New System.Windows.Forms.OpenFileDialog()
        Me.sfdPlaylist = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstFiles = New Mediaplayer.Playlist()
        Me.txtSuche = New System.Windows.Forms.TextBox()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.lbArtist = New System.Windows.Forms.Label()
        Me.lbAlbum = New System.Windows.Forms.Label()
        Me.lbTitel = New System.Windows.Forms.Label()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.tmrHotkeys = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.contInfos.SuspendLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contStop.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdUp
        '
        Me.cmdUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUp.Location = New System.Drawing.Point(5, 2)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(30, 27)
        Me.cmdUp.TabIndex = 3
        Me.cmdUp.Text = "↑"
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown.Location = New System.Drawing.Point(34, 2)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(30, 27)
        Me.cmdDown.TabIndex = 3
        Me.cmdDown.Text = "↓"
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'ofdFiles
        '
        Me.ofdFiles.Filter = "WAV; MP3; WMA; AVI; MPG; WMV | *wav; *.mp3; *.wma; *.avi; *.mpg; *.wmv"
        Me.ofdFiles.Multiselect = True
        '
        'contInfos
        '
        Me.contInfos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiInfoToolStripMenuItem})
        Me.contInfos.Name = "ContextMenuStrip2"
        Me.contInfos.Size = New System.Drawing.Size(137, 26)
        '
        'DateiInfoToolStripMenuItem
        '
        Me.DateiInfoToolStripMenuItem.Name = "DateiInfoToolStripMenuItem"
        Me.DateiInfoToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DateiInfoToolStripMenuItem.Text = "Datei-Info..."
        '
        'wmp
        '
        Me.wmp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(2, 87)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(776, 388)
        Me.wmp.TabIndex = 6
        '
        'tbPosition
        '
        Me.tbPosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPosition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbPosition.Enabled = False
        Me.tbPosition.LargeChange = 0
        Me.tbPosition.Location = New System.Drawing.Point(152, 478)
        Me.tbPosition.Maximum = 1000
        Me.tbPosition.Name = "tbPosition"
        Me.tbPosition.Size = New System.Drawing.Size(294, 45)
        Me.tbPosition.TabIndex = 7
        Me.tbPosition.TickFrequency = 60
        '
        'tbVolume
        '
        Me.tbVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbVolume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbVolume.LargeChange = 0
        Me.tbVolume.Location = New System.Drawing.Point(580, 476)
        Me.tbVolume.Maximum = 100
        Me.tbVolume.Name = "tbVolume"
        Me.tbVolume.Size = New System.Drawing.Size(172, 45)
        Me.tbVolume.TabIndex = 7
        Me.tbVolume.TickFrequency = 10
        Me.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lbVolume
        '
        Me.lbVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbVolume.AutoSize = True
        Me.lbVolume.Location = New System.Drawing.Point(657, 507)
        Me.lbVolume.Name = "lbVolume"
        Me.lbVolume.Size = New System.Drawing.Size(22, 13)
        Me.lbVolume.TabIndex = 4
        Me.lbVolume.Text = "Vol"
        Me.lbVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'contStop
        '
        Me.contStop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StoppenToolStripMenuItem, Me.AmEndeDesTitelsStoppenToolStripMenuItem, Me.NachEndeDesTitelsStoppenToolStripMenuItem})
        Me.contStop.Name = "ContextMenuStrip1"
        Me.contStop.Size = New System.Drawing.Size(236, 70)
        '
        'StoppenToolStripMenuItem
        '
        Me.StoppenToolStripMenuItem.Name = "StoppenToolStripMenuItem"
        Me.StoppenToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.StoppenToolStripMenuItem.Text = "Stoppen"
        '
        'AmEndeDesTitelsStoppenToolStripMenuItem
        '
        Me.AmEndeDesTitelsStoppenToolStripMenuItem.Name = "AmEndeDesTitelsStoppenToolStripMenuItem"
        Me.AmEndeDesTitelsStoppenToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.AmEndeDesTitelsStoppenToolStripMenuItem.Text = "Nach Ende des Titels stoppen"
        '
        'NachEndeDesTitelsStoppenToolStripMenuItem
        '
        Me.NachEndeDesTitelsStoppenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NachEndeDesTitelsStoppenToolStripMenuItem.Name = "NachEndeDesTitelsStoppenToolStripMenuItem"
        Me.NachEndeDesTitelsStoppenToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.NachEndeDesTitelsStoppenToolStripMenuItem.Text = "Nach Ende des Titels stoppen"
        Me.NachEndeDesTitelsStoppenToolStripMenuItem.Visible = False
        '
        'tmrPosition
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuelleToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.PlaylistToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1092, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuelleToolStripMenuItem
        '
        Me.QuelleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.OrdnerToolStripMenuItem, Me.URLToolStripMenuItem})
        Me.QuelleToolStripMenuItem.Name = "QuelleToolStripMenuItem"
        Me.QuelleToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.QuelleToolStripMenuItem.Text = "Quelle"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.DateiToolStripMenuItem.Text = "Datei..."
        '
        'OrdnerToolStripMenuItem
        '
        Me.OrdnerToolStripMenuItem.Name = "OrdnerToolStripMenuItem"
        Me.OrdnerToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.OrdnerToolStripMenuItem.Text = "Ordner..."
        '
        'URLToolStripMenuItem
        '
        Me.URLToolStripMenuItem.Name = "URLToolStripMenuItem"
        Me.URLToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.URLToolStripMenuItem.Text = "URL..."
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NachObenVerschiebenToolStripMenuItem, Me.NachUntenVerschiebenToolStripMenuItem, Me.AusgewählteLöschenToolStripMenuItem, Me.ListeLeerenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'NachObenVerschiebenToolStripMenuItem
        '
        Me.NachObenVerschiebenToolStripMenuItem.Name = "NachObenVerschiebenToolStripMenuItem"
        Me.NachObenVerschiebenToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.NachObenVerschiebenToolStripMenuItem.Text = "Nach oben verschieben"
        '
        'NachUntenVerschiebenToolStripMenuItem
        '
        Me.NachUntenVerschiebenToolStripMenuItem.Name = "NachUntenVerschiebenToolStripMenuItem"
        Me.NachUntenVerschiebenToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.NachUntenVerschiebenToolStripMenuItem.Text = "Nach unten verschieben"
        '
        'AusgewählteLöschenToolStripMenuItem
        '
        Me.AusgewählteLöschenToolStripMenuItem.Name = "AusgewählteLöschenToolStripMenuItem"
        Me.AusgewählteLöschenToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AusgewählteLöschenToolStripMenuItem.Text = "Ausgewählte löschen"
        '
        'ListeLeerenToolStripMenuItem
        '
        Me.ListeLeerenToolStripMenuItem.Name = "ListeLeerenToolStripMenuItem"
        Me.ListeLeerenToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ListeLeerenToolStripMenuItem.Text = "Liste leeren"
        '
        'PlaylistToolStripMenuItem1
        '
        Me.PlaylistToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeichernToolStripMenuItem, Me.LadToolStripMenuItem})
        Me.PlaylistToolStripMenuItem1.Name = "PlaylistToolStripMenuItem1"
        Me.PlaylistToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.PlaylistToolStripMenuItem1.Text = "Playlist"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SpeichernToolStripMenuItem.Text = "Laden"
        '
        'LadToolStripMenuItem
        '
        Me.LadToolStripMenuItem.Name = "LadToolStripMenuItem"
        Me.LadToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LadToolStripMenuItem.Text = "Speichern"
        '
        'cmdMute
        '
        Me.cmdMute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMute.BackColor = System.Drawing.Color.Transparent
        Me.cmdMute.Location = New System.Drawing.Point(749, 486)
        Me.cmdMute.Name = "cmdMute"
        Me.cmdMute.Size = New System.Drawing.Size(20, 20)
        Me.cmdMute.TabIndex = 9
        Me.cmdMute.Text = "M"
        Me.cmdMute.UseVisualStyleBackColor = False
        '
        'cmdLast
        '
        Me.cmdLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLast.Location = New System.Drawing.Point(106, 481)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(40, 40)
        Me.cmdLast.TabIndex = 10
        Me.cmdLast.Text = "<<"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNext.Location = New System.Drawing.Point(452, 481)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(40, 40)
        Me.cmdNext.TabIndex = 10
        Me.cmdNext.Text = ">>"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdRepeat
        '
        Me.cmdRepeat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRepeat.BackColor = System.Drawing.Color.Transparent
        Me.cmdRepeat.Location = New System.Drawing.Point(510, 477)
        Me.cmdRepeat.Name = "cmdRepeat"
        Me.cmdRepeat.Size = New System.Drawing.Size(64, 23)
        Me.cmdRepeat.TabIndex = 9
        Me.cmdRepeat.Text = "Repeat"
        Me.cmdRepeat.UseVisualStyleBackColor = False
        '
        'cmdFullscreen
        '
        Me.cmdFullscreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFullscreen.Location = New System.Drawing.Point(510, 499)
        Me.cmdFullscreen.Name = "cmdFullscreen"
        Me.cmdFullscreen.Size = New System.Drawing.Size(64, 23)
        Me.cmdFullscreen.TabIndex = 12
        Me.cmdFullscreen.Text = "Fullscreen"
        Me.cmdFullscreen.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdStatusCancel, Me.pbStatusProgress, Me.lbStatusItem, Me.lbItems})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 549)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1092, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cmdStatusCancel
        '
        Me.cmdStatusCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdStatusCancel.DropDownButtonWidth = 0
        Me.cmdStatusCancel.Image = Global.Mediaplayer.My.Resources.Resources.x
        Me.cmdStatusCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStatusCancel.Name = "cmdStatusCancel"
        Me.cmdStatusCancel.Size = New System.Drawing.Size(21, 20)
        Me.cmdStatusCancel.Text = "ToolStripSplitButton1"
        Me.cmdStatusCancel.Visible = False
        '
        'pbStatusProgress
        '
        Me.pbStatusProgress.Name = "pbStatusProgress"
        Me.pbStatusProgress.Size = New System.Drawing.Size(100, 16)
        Me.pbStatusProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbStatusProgress.Visible = False
        '
        'lbStatusItem
        '
        Me.lbStatusItem.Name = "lbStatusItem"
        Me.lbStatusItem.Size = New System.Drawing.Size(0, 17)
        '
        'lbItems
        '
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(1077, 17)
        Me.lbItems.Spring = True
        Me.lbItems.Text = "Items: 0"
        Me.lbItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCollPlaylist
        '
        Me.cmdCollPlaylist.Location = New System.Drawing.Point(1, 0)
        Me.cmdCollPlaylist.Name = "cmdCollPlaylist"
        Me.cmdCollPlaylist.Size = New System.Drawing.Size(17, 23)
        Me.cmdCollPlaylist.TabIndex = 15
        Me.cmdCollPlaylist.Text = "<"
        Me.cmdCollPlaylist.UseVisualStyleBackColor = True
        '
        'lbTime
        '
        Me.lbTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTime.Location = New System.Drawing.Point(165, 507)
        Me.lbTime.MinimumSize = New System.Drawing.Size(96, 13)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(273, 13)
        Me.lbTime.TabIndex = 4
        Me.lbTime.Text = "00:00/00:00"
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ofdPlaylist
        '
        Me.ofdPlaylist.Filter = "Playlists | *.pls; *.m3u"
        '
        'sfdPlaylist
        '
        Me.sfdPlaylist.Filter = "Winamp Playlist | *.pls | M3U Playlist | *.m3u"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSuche)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdUp)
        Me.SplitContainer1.Panel1MinSize = 300
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.ContextMenuStrip = Me.contInfos
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbTime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbVolume)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCollPlaylist)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdNext)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdMute)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdStop)
        Me.SplitContainer1.Panel2.Controls.Add(Me.wmp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbVolume)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdFullscreen)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdPlay)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbPosition)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdLast)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdRepeat)
        Me.SplitContainer1.Panel2MinSize = 600
        Me.SplitContainer1.Size = New System.Drawing.Size(1092, 525)
        Me.SplitContainer1.SplitterDistance = 309
        Me.SplitContainer1.TabIndex = 17
        '
        'lstFiles
        '
        Me.lstFiles.AllowDrop = True
        Me.lstFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.Location = New System.Drawing.Point(3, 29)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFiles.Size = New System.Drawing.Size(310, 498)
        Me.lstFiles.TabIndex = 7
        '
        'txtSuche
        '
        Me.txtSuche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSuche.Location = New System.Drawing.Point(72, 6)
        Me.txtSuche.Name = "txtSuche"
        Me.txtSuche.Size = New System.Drawing.Size(227, 20)
        Me.txtSuche.TabIndex = 6
        '
        'gbInfo
        '
        Me.gbInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbInfo.BackColor = System.Drawing.Color.White
        Me.gbInfo.ContextMenuStrip = Me.contInfos
        Me.gbInfo.Controls.Add(Me.lbArtist)
        Me.gbInfo.Controls.Add(Me.lbAlbum)
        Me.gbInfo.Controls.Add(Me.lbTitel)
        Me.gbInfo.Cursor = System.Windows.Forms.Cursors.Help
        Me.gbInfo.Location = New System.Drawing.Point(20, -4)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(755, 86)
        Me.gbInfo.TabIndex = 16
        Me.gbInfo.TabStop = False
        '
        'lbArtist
        '
        Me.lbArtist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbArtist.AutoSize = True
        Me.lbArtist.Location = New System.Drawing.Point(37, 39)
        Me.lbArtist.Name = "lbArtist"
        Me.lbArtist.Size = New System.Drawing.Size(0, 13)
        Me.lbArtist.TabIndex = 4
        '
        'lbAlbum
        '
        Me.lbAlbum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAlbum.AutoSize = True
        Me.lbAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlbum.Location = New System.Drawing.Point(47, 59)
        Me.lbAlbum.Name = "lbAlbum"
        Me.lbAlbum.Size = New System.Drawing.Size(0, 13)
        Me.lbAlbum.TabIndex = 4
        '
        'lbTitel
        '
        Me.lbTitel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTitel.AutoSize = True
        Me.lbTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitel.Location = New System.Drawing.Point(14, 11)
        Me.lbTitel.Name = "lbTitel"
        Me.lbTitel.Size = New System.Drawing.Size(0, 24)
        Me.lbTitel.TabIndex = 4
        '
        'cmdStop
        '
        Me.cmdStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdStop.ContextMenuStrip = Me.contStop
        Me.cmdStop.Image = Global.Mediaplayer.My.Resources.Resources._stop
        Me.cmdStop.Location = New System.Drawing.Point(14, 481)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(40, 40)
        Me.cmdStop.TabIndex = 2
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdPlay
        '
        Me.cmdPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdPlay.Image = Global.Mediaplayer.My.Resources.Resources.play
        Me.cmdPlay.Location = New System.Drawing.Point(60, 481)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(40, 40)
        Me.cmdPlay.TabIndex = 2
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'tmrHotkeys
        '
        Me.tmrHotkeys.Enabled = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 571)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(955, 223)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mediaplayer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.contInfos.ResumeLayout(False)
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contStop.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents cmdUp As System.Windows.Forms.Button
    Friend WithEvents cmdDown As System.Windows.Forms.Button
    Friend WithEvents ofdFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents tbPosition As System.Windows.Forms.TrackBar
    Friend WithEvents tbVolume As System.Windows.Forms.TrackBar
    Friend WithEvents lbVolume As System.Windows.Forms.Label
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents tmrPosition As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuelleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents URLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdMute As System.Windows.Forms.Button
    Friend WithEvents cmdLast As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NachObenVerschiebenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NachUntenVerschiebenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusgewählteLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeLeerenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contStop As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StoppenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmEndeDesTitelsStoppenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NachEndeDesTitelsStoppenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRepeat As System.Windows.Forms.Button
    Friend WithEvents cmdFullscreen As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbStatusItem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdCollPlaylist As System.Windows.Forms.Button
    Friend WithEvents ofdPlaylist As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdPlaylist As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents PlaylistToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contInfos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DateiInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pbStatusProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tmrHotkeys As System.Windows.Forms.Timer
    Friend WithEvents OrdnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbItems As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbArtist As System.Windows.Forms.Label
    Friend WithEvents lbTitel As System.Windows.Forms.Label
    Friend WithEvents lbAlbum As System.Windows.Forms.Label
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtSuche As System.Windows.Forms.TextBox
    Friend WithEvents cmdStatusCancel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents lstFiles As Mediaplayer.Playlist

End Class
