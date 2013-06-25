<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cbLaufwerk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvFiles = New System.Windows.Forms.ListView()
        Me.hdPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdTitel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdArtist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdAlbum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdTrack = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdLength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdBitrate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chbSubFolders = New System.Windows.Forms.CheckBox()
        Me.bgwShowFolder = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pbShowFolder = New System.Windows.Forms.ToolStripProgressBar()
        Me.txtTitel = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtTrack = New System.Windows.Forms.TextBox()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtBitrate = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMp3 = New mp3factory.dsMp3()
        Me.tvExplorer = New mp3factory.ExView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMp3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbLaufwerk
        '
        Me.cbLaufwerk.FormattingEnabled = True
        Me.cbLaufwerk.Location = New System.Drawing.Point(70, 16)
        Me.cbLaufwerk.Name = "cbLaufwerk"
        Me.cbLaufwerk.Size = New System.Drawing.Size(121, 21)
        Me.cbLaufwerk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Laufwerk"
        '
        'lvFiles
        '
        Me.lvFiles.AllowColumnReorder = True
        Me.lvFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hdPath, Me.hdTitel, Me.hdArtist, Me.hdAlbum, Me.hdTrack, Me.hdYear, Me.hdLength, Me.hdBitrate})
        Me.lvFiles.FullRowSelect = True
        Me.lvFiles.Location = New System.Drawing.Point(209, 39)
        Me.lvFiles.Name = "lvFiles"
        Me.lvFiles.Size = New System.Drawing.Size(537, 500)
        Me.lvFiles.TabIndex = 3
        Me.lvFiles.UseCompatibleStateImageBehavior = False
        Me.lvFiles.View = System.Windows.Forms.View.Details
        '
        'hdPath
        '
        Me.hdPath.DisplayIndex = 7
        Me.hdPath.Text = "Pfad"
        Me.hdPath.Width = 50
        '
        'hdTitel
        '
        Me.hdTitel.DisplayIndex = 0
        Me.hdTitel.Text = "Titel"
        Me.hdTitel.Width = 122
        '
        'hdArtist
        '
        Me.hdArtist.DisplayIndex = 1
        Me.hdArtist.Text = "Interpret"
        '
        'hdAlbum
        '
        Me.hdAlbum.DisplayIndex = 2
        Me.hdAlbum.Text = "Album"
        '
        'hdTrack
        '
        Me.hdTrack.DisplayIndex = 3
        Me.hdTrack.Text = "Track-Nr."
        '
        'hdYear
        '
        Me.hdYear.DisplayIndex = 4
        Me.hdYear.Text = "Jahr"
        '
        'hdLength
        '
        Me.hdLength.DisplayIndex = 5
        Me.hdLength.Text = "Länge"
        '
        'hdBitrate
        '
        Me.hdBitrate.DisplayIndex = 6
        Me.hdBitrate.Text = "Bitrate"
        '
        'chbSubFolders
        '
        Me.chbSubFolders.AutoSize = True
        Me.chbSubFolders.Location = New System.Drawing.Point(197, 19)
        Me.chbSubFolders.Name = "chbSubFolders"
        Me.chbSubFolders.Size = New System.Drawing.Size(116, 17)
        Me.chbSubFolders.TabIndex = 4
        Me.chbSubFolders.Text = "Unterverzeichnisse"
        Me.chbSubFolders.UseVisualStyleBackColor = True
        '
        'bgwShowFolder
        '
        Me.bgwShowFolder.WorkerReportsProgress = True
        Me.bgwShowFolder.WorkerSupportsCancellation = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbShowFolder})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 542)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1168, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pbShowFolder
        '
        Me.pbShowFolder.Name = "pbShowFolder"
        Me.pbShowFolder.Size = New System.Drawing.Size(100, 16)
        Me.pbShowFolder.Visible = False
        '
        'txtTitel
        '
        Me.txtTitel.Location = New System.Drawing.Point(752, 145)
        Me.txtTitel.Name = "txtTitel"
        Me.txtTitel.Size = New System.Drawing.Size(307, 20)
        Me.txtTitel.TabIndex = 6
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(752, 171)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(307, 20)
        Me.txtArtist.TabIndex = 6
        '
        'txtTrack
        '
        Me.txtTrack.Location = New System.Drawing.Point(752, 119)
        Me.txtTrack.Name = "txtTrack"
        Me.txtTrack.Size = New System.Drawing.Size(55, 20)
        Me.txtTrack.TabIndex = 6
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(752, 197)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(307, 20)
        Me.txtAlbum.TabIndex = 6
        '
        'txtLength
        '
        Me.txtLength.Enabled = False
        Me.txtLength.Location = New System.Drawing.Point(752, 249)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(77, 20)
        Me.txtLength.TabIndex = 6
        '
        'txtBitrate
        '
        Me.txtBitrate.Enabled = False
        Me.txtBitrate.Location = New System.Drawing.Point(752, 275)
        Me.txtBitrate.Name = "txtBitrate"
        Me.txtBitrate.Size = New System.Drawing.Size(55, 20)
        Me.txtBitrate.TabIndex = 6
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(752, 301)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(372, 20)
        Me.txtPath.TabIndex = 6
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(752, 223)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(77, 20)
        Me.txtYear.TabIndex = 6
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(992, 352)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Speichern"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DsMp3
        Me.BindingSource1.Position = 0
        '
        'DsMp3
        '
        Me.DsMp3.DataSetName = "dsMp3"
        Me.DsMp3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tvExplorer
        '
        Me.tvExplorer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvExplorer.HideSelection = False
        Me.tvExplorer.HotTracking = True
        Me.tvExplorer.Location = New System.Drawing.Point(12, 39)
        Me.tvExplorer.Name = "tvExplorer"
        Me.tvExplorer.ShowPlusMinus = False
        Me.tvExplorer.Size = New System.Drawing.Size(191, 500)
        Me.tvExplorer.Sorted = True
        Me.tvExplorer.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(978, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 564)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtTrack)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtBitrate)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtAlbum)
        Me.Controls.Add(Me.txtArtist)
        Me.Controls.Add(Me.txtTitel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chbSubFolders)
        Me.Controls.Add(Me.lvFiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbLaufwerk)
        Me.Controls.Add(Me.tvExplorer)
        Me.Name = "Form1"
        Me.Text = "mp3factory"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMp3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tvExplorer As mp3factory.ExView
    Friend WithEvents cbLaufwerk As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvFiles As System.Windows.Forms.ListView
    Friend WithEvents hdPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdTitel As System.Windows.Forms.ColumnHeader
    Friend WithEvents chbSubFolders As System.Windows.Forms.CheckBox
    Friend WithEvents hdArtist As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdAlbum As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdTrack As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdYear As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdLength As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdBitrate As System.Windows.Forms.ColumnHeader
    Friend WithEvents bgwShowFolder As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pbShowFolder As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents txtTitel As System.Windows.Forms.TextBox
    Friend WithEvents txtArtist As System.Windows.Forms.TextBox
    Friend WithEvents txtTrack As System.Windows.Forms.TextBox
    Friend WithEvents txtAlbum As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtBitrate As System.Windows.Forms.TextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsMp3 As mp3factory.dsMp3
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
