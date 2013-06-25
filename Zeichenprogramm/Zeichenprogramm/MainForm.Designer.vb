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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrößeÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GößeÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArbeitsflächeLeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.numStaerke = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdStift = New System.Windows.Forms.Button()
        Me.cmdForm = New System.Windows.Forms.Button()
        Me.cmdText = New System.Windows.Forms.Button()
        Me.cbTyp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pForm = New System.Windows.Forms.Panel()
        Me.chbGefüllt = New System.Windows.Forms.CheckBox()
        Me.pStift = New System.Windows.Forms.Panel()
        Me.pText = New System.Windows.Forms.Panel()
        Me.cbFont = New System.Windows.Forms.ComboBox()
        Me.numFontsize = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cdFarbe = New System.Windows.Forms.ColorDialog()
        Me.cmdFarbe = New System.Windows.Forms.Button()
        Me.cmdRad = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdForw = New System.Windows.Forms.Button()
        Me.lbColor = New System.Windows.Forms.Label()
        Me.HintergrundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cdBG = New System.Windows.Forms.ColorDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numStaerke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pForm.SuspendLayout()
        Me.pStift.SuspendLayout()
        Me.pText.SuspendLayout()
        CType(Me.numFontsize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(197, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.GrößeÄndernToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1001, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LadenToolStripMenuItem, Me.SpeichernToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'LadenToolStripMenuItem
        '
        Me.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem"
        Me.LadenToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LadenToolStripMenuItem.Text = "Laden"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'GrößeÄndernToolStripMenuItem
        '
        Me.GrößeÄndernToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GößeÄndernToolStripMenuItem, Me.ArbeitsflächeLeerenToolStripMenuItem, Me.HintergrundToolStripMenuItem})
        Me.GrößeÄndernToolStripMenuItem.Name = "GrößeÄndernToolStripMenuItem"
        Me.GrößeÄndernToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.GrößeÄndernToolStripMenuItem.Text = "Bild"
        '
        'GößeÄndernToolStripMenuItem
        '
        Me.GößeÄndernToolStripMenuItem.Name = "GößeÄndernToolStripMenuItem"
        Me.GößeÄndernToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.GößeÄndernToolStripMenuItem.Text = "Größe ändern..."
        '
        'ArbeitsflächeLeerenToolStripMenuItem
        '
        Me.ArbeitsflächeLeerenToolStripMenuItem.Name = "ArbeitsflächeLeerenToolStripMenuItem"
        Me.ArbeitsflächeLeerenToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ArbeitsflächeLeerenToolStripMenuItem.Text = "Arbeitsfläche leeren"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "JPG | *.jpg | PNG | *.png"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bilder | *.jpg; *.png"
        '
        'numStaerke
        '
        Me.numStaerke.Location = New System.Drawing.Point(13, 20)
        Me.numStaerke.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numStaerke.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numStaerke.Name = "numStaerke"
        Me.numStaerke.Size = New System.Drawing.Size(50, 20)
        Me.numStaerke.TabIndex = 4
        Me.numStaerke.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Stärke:"
        '
        'cmdStift
        '
        Me.cmdStift.Location = New System.Drawing.Point(12, 34)
        Me.cmdStift.Name = "cmdStift"
        Me.cmdStift.Size = New System.Drawing.Size(75, 23)
        Me.cmdStift.TabIndex = 0
        Me.cmdStift.Text = "Stift"
        Me.cmdStift.UseVisualStyleBackColor = True
        '
        'cmdForm
        '
        Me.cmdForm.Location = New System.Drawing.Point(12, 63)
        Me.cmdForm.Name = "cmdForm"
        Me.cmdForm.Size = New System.Drawing.Size(75, 23)
        Me.cmdForm.TabIndex = 1
        Me.cmdForm.Text = "Form"
        Me.cmdForm.UseVisualStyleBackColor = True
        '
        'cmdText
        '
        Me.cmdText.Location = New System.Drawing.Point(12, 92)
        Me.cmdText.Name = "cmdText"
        Me.cmdText.Size = New System.Drawing.Size(75, 23)
        Me.cmdText.TabIndex = 2
        Me.cmdText.Text = "Text"
        Me.cmdText.UseVisualStyleBackColor = True
        '
        'cbTyp
        '
        Me.cbTyp.FormattingEnabled = True
        Me.cbTyp.Items.AddRange(New Object() {"Rechteck", "Ellipse"})
        Me.cbTyp.Location = New System.Drawing.Point(10, 26)
        Me.cbTyp.Name = "cbTyp"
        Me.cbTyp.Size = New System.Drawing.Size(121, 21)
        Me.cbTyp.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Form:"
        '
        'pForm
        '
        Me.pForm.Controls.Add(Me.chbGefüllt)
        Me.pForm.Controls.Add(Me.Label3)
        Me.pForm.Controls.Add(Me.cbTyp)
        Me.pForm.Location = New System.Drawing.Point(12, 236)
        Me.pForm.Name = "pForm"
        Me.pForm.Size = New System.Drawing.Size(164, 77)
        Me.pForm.TabIndex = 8
        Me.pForm.Visible = False
        '
        'chbGefüllt
        '
        Me.chbGefüllt.AutoSize = True
        Me.chbGefüllt.Location = New System.Drawing.Point(13, 53)
        Me.chbGefüllt.Name = "chbGefüllt"
        Me.chbGefüllt.Size = New System.Drawing.Size(56, 17)
        Me.chbGefüllt.TabIndex = 7
        Me.chbGefüllt.Text = "Gefüllt"
        Me.chbGefüllt.UseVisualStyleBackColor = True
        '
        'pStift
        '
        Me.pStift.Controls.Add(Me.Label2)
        Me.pStift.Controls.Add(Me.numStaerke)
        Me.pStift.Location = New System.Drawing.Point(12, 189)
        Me.pStift.Name = "pStift"
        Me.pStift.Size = New System.Drawing.Size(164, 48)
        Me.pStift.TabIndex = 9
        '
        'pText
        '
        Me.pText.Controls.Add(Me.cbFont)
        Me.pText.Controls.Add(Me.numFontsize)
        Me.pText.Controls.Add(Me.Label8)
        Me.pText.Controls.Add(Me.Label7)
        Me.pText.Controls.Add(Me.Label6)
        Me.pText.Controls.Add(Me.txtText)
        Me.pText.Location = New System.Drawing.Point(12, 313)
        Me.pText.Name = "pText"
        Me.pText.Size = New System.Drawing.Size(164, 147)
        Me.pText.TabIndex = 10
        Me.pText.Visible = False
        '
        'cbFont
        '
        Me.cbFont.FormattingEnabled = True
        Me.cbFont.Location = New System.Drawing.Point(11, 73)
        Me.cbFont.Name = "cbFont"
        Me.cbFont.Size = New System.Drawing.Size(121, 21)
        Me.cbFont.TabIndex = 4
        '
        'numFontsize
        '
        Me.numFontsize.Location = New System.Drawing.Point(11, 119)
        Me.numFontsize.Maximum = New Decimal(New Integer() {72, 0, 0, 0})
        Me.numFontsize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFontsize.Name = "numFontsize"
        Me.numFontsize.Size = New System.Drawing.Size(50, 20)
        Me.numFontsize.TabIndex = 7
        Me.numFontsize.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Schriftgröße:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Font:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Text:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(10, 24)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(151, 20)
        Me.txtText.TabIndex = 0
        Me.txtText.Text = "DeinText"
        '
        'cdFarbe
        '
        Me.cdFarbe.AnyColor = True
        Me.cdFarbe.FullOpen = True
        '
        'cmdFarbe
        '
        Me.cmdFarbe.Location = New System.Drawing.Point(12, 155)
        Me.cmdFarbe.Name = "cmdFarbe"
        Me.cmdFarbe.Size = New System.Drawing.Size(117, 23)
        Me.cmdFarbe.TabIndex = 4
        Me.cmdFarbe.Text = "Farbe..."
        Me.cmdFarbe.UseVisualStyleBackColor = True
        '
        'cmdRad
        '
        Me.cmdRad.Location = New System.Drawing.Point(12, 121)
        Me.cmdRad.Name = "cmdRad"
        Me.cmdRad.Size = New System.Drawing.Size(75, 23)
        Me.cmdRad.TabIndex = 3
        Me.cmdRad.Text = "Radierer"
        Me.cmdRad.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Enabled = False
        Me.cmdBack.Location = New System.Drawing.Point(216, 1)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(46, 23)
        Me.cmdBack.TabIndex = 12
        Me.cmdBack.Text = "<<"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdForw
        '
        Me.cmdForw.Enabled = False
        Me.cmdForw.Location = New System.Drawing.Point(268, 1)
        Me.cmdForw.Name = "cmdForw"
        Me.cmdForw.Size = New System.Drawing.Size(46, 23)
        Me.cmdForw.TabIndex = 12
        Me.cmdForw.Text = ">>"
        Me.cmdForw.UseVisualStyleBackColor = True
        '
        'lbColor
        '
        Me.lbColor.Location = New System.Drawing.Point(135, 155)
        Me.lbColor.Name = "lbColor"
        Me.lbColor.Size = New System.Drawing.Size(28, 23)
        Me.lbColor.TabIndex = 13
        '
        'HintergrundToolStripMenuItem
        '
        Me.HintergrundToolStripMenuItem.Name = "HintergrundToolStripMenuItem"
        Me.HintergrundToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.HintergrundToolStripMenuItem.Text = "Hintergrund..."
        '
        'cdBG
        '
        Me.cdBG.AnyColor = True
        Me.cdBG.Color = System.Drawing.Color.White
        Me.cdBG.FullOpen = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 637)
        Me.Controls.Add(Me.lbColor)
        Me.Controls.Add(Me.cmdForw)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdFarbe)
        Me.Controls.Add(Me.pText)
        Me.Controls.Add(Me.cmdRad)
        Me.Controls.Add(Me.cmdText)
        Me.Controls.Add(Me.cmdForm)
        Me.Controls.Add(Me.cmdStift)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pForm)
        Me.Controls.Add(Me.pStift)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Zeichenprogramm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numStaerke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pForm.ResumeLayout(False)
        Me.pForm.PerformLayout()
        Me.pStift.ResumeLayout(False)
        Me.pStift.PerformLayout()
        Me.pText.ResumeLayout(False)
        Me.pText.PerformLayout()
        CType(Me.numFontsize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LadenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GrößeÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents numStaerke As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdStift As System.Windows.Forms.Button
    Friend WithEvents cmdForm As System.Windows.Forms.Button
    Friend WithEvents cmdText As System.Windows.Forms.Button
    Friend WithEvents cbTyp As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pForm As System.Windows.Forms.Panel
    Friend WithEvents pStift As System.Windows.Forms.Panel
    Friend WithEvents pText As System.Windows.Forms.Panel
    Friend WithEvents cbFont As System.Windows.Forms.ComboBox
    Friend WithEvents numFontsize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents cdFarbe As System.Windows.Forms.ColorDialog
    Friend WithEvents cmdFarbe As System.Windows.Forms.Button
    Friend WithEvents GößeÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArbeitsflächeLeerenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRad As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdForw As System.Windows.Forms.Button
    Friend WithEvents lbColor As System.Windows.Forms.Label
    Friend WithEvents chbGefüllt As System.Windows.Forms.CheckBox
    Friend WithEvents HintergrundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cdBG As System.Windows.Forms.ColorDialog

End Class
