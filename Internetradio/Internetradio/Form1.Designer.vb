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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mp1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.lstRadioURL = New System.Windows.Forms.ListBox()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAddURL = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarbeÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchriftartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HintergrundbildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbVolume = New System.Windows.Forms.TrackBar()
        CType(Me.mp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mp1
        '
        Me.mp1.Enabled = True
        Me.mp1.Location = New System.Drawing.Point(31, 29)
        Me.mp1.Name = "mp1"
        Me.mp1.OcxState = CType(resources.GetObject("mp1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mp1.Size = New System.Drawing.Size(433, 99)
        Me.mp1.TabIndex = 0
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(486, 50)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 1
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(486, 79)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 1
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'lstRadioURL
        '
        Me.lstRadioURL.FormattingEnabled = True
        Me.lstRadioURL.Items.AddRange(New Object() {"http://stream4.jungletrain.net:8000/", "http://sender.fm:2323/"})
        Me.lstRadioURL.Location = New System.Drawing.Point(28, 151)
        Me.lstRadioURL.Name = "lstRadioURL"
        Me.lstRadioURL.Size = New System.Drawing.Size(380, 56)
        Me.lstRadioURL.TabIndex = 2
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(414, 167)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(97, 23)
        Me.cmdChange.TabIndex = 3
        Me.cmdChange.Text = "Stream starten"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(28, 247)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(380, 20)
        Me.txtURL.TabIndex = 4
        Me.txtURL.Text = "http://mp3stream1.apasf.apa.at:8000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Eigener URL"
        '
        'cmdAddURL
        '
        Me.cmdAddURL.Location = New System.Drawing.Point(415, 243)
        Me.cmdAddURL.Name = "cmdAddURL"
        Me.cmdAddURL.Size = New System.Drawing.Size(117, 23)
        Me.cmdAddURL.TabIndex = 6
        Me.cmdAddURL.Text = "URL Hinzufügen"
        Me.cmdAddURL.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.BearbeitenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndeToolStripMenuItem, Me.MinimierenToolStripMenuItem, Me.MaximierenToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
        Me.ToolStripMenuItem1.Text = "Datei"
        '
        'EndeToolStripMenuItem
        '
        Me.EndeToolStripMenuItem.Name = "EndeToolStripMenuItem"
        Me.EndeToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EndeToolStripMenuItem.Text = "Ende"
        '
        'MinimierenToolStripMenuItem
        '
        Me.MinimierenToolStripMenuItem.Name = "MinimierenToolStripMenuItem"
        Me.MinimierenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MinimierenToolStripMenuItem.Text = "Minimieren"
        '
        'MaximierenToolStripMenuItem
        '
        Me.MaximierenToolStripMenuItem.Name = "MaximierenToolStripMenuItem"
        Me.MaximierenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MaximierenToolStripMenuItem.Text = "Maximieren"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FarbeÄndernToolStripMenuItem, Me.SchriftartToolStripMenuItem, Me.HintergrundbildToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'FarbeÄndernToolStripMenuItem
        '
        Me.FarbeÄndernToolStripMenuItem.Name = "FarbeÄndernToolStripMenuItem"
        Me.FarbeÄndernToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.FarbeÄndernToolStripMenuItem.Text = "Farbe ändern..."
        '
        'SchriftartToolStripMenuItem
        '
        Me.SchriftartToolStripMenuItem.Name = "SchriftartToolStripMenuItem"
        Me.SchriftartToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SchriftartToolStripMenuItem.Text = "Schriftart..."
        '
        'HintergrundbildToolStripMenuItem
        '
        Me.HintergrundbildToolStripMenuItem.Name = "HintergrundbildToolStripMenuItem"
        Me.HintergrundbildToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.HintergrundbildToolStripMenuItem.Text = "Hintergrundbild..."
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG;GIF;PNG|*.jpg;*.gif;*.png"
        '
        'tbVolume
        '
        Me.tbVolume.Location = New System.Drawing.Point(486, 108)
        Me.tbVolume.Maximum = 100
        Me.tbVolume.Name = "tbVolume"
        Me.tbVolume.Size = New System.Drawing.Size(104, 45)
        Me.tbVolume.TabIndex = 8
        Me.tbVolume.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 286)
        Me.Controls.Add(Me.tbVolume)
        Me.Controls.Add(Me.cmdAddURL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.lstRadioURL)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.mp1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Radio"
        CType(Me.mp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mp1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents lstRadioURL As System.Windows.Forms.ListBox
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAddURL As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaximierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FarbeÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents SchriftartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HintergrundbildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbVolume As System.Windows.Forms.TrackBar

End Class
