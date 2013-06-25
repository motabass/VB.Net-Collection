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
        Me.lstErinnerungen = New System.Windows.Forms.ListBox()
        Me.cmdAnzeigen = New System.Windows.Forms.Button()
        Me.cmdAlle = New System.Windows.Forms.Button()
        Me.cmdDelAll = New System.Windows.Forms.Button()
        Me.cmdDelChoosed = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtEintrag = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdMove = New System.Windows.Forms.Button()
        Me.lstFertig = New System.Windows.Forms.ListBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NeuToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ÖffnenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SpeichernToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstErinnerungen
        '
        Me.lstErinnerungen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstErinnerungen.FormattingEnabled = True
        Me.lstErinnerungen.Location = New System.Drawing.Point(48, 41)
        Me.lstErinnerungen.Name = "lstErinnerungen"
        Me.lstErinnerungen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstErinnerungen.Size = New System.Drawing.Size(250, 212)
        Me.lstErinnerungen.TabIndex = 0
        '
        'cmdAnzeigen
        '
        Me.cmdAnzeigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAnzeigen.Location = New System.Drawing.Point(302, 289)
        Me.cmdAnzeigen.Name = "cmdAnzeigen"
        Me.cmdAnzeigen.Size = New System.Drawing.Size(120, 41)
        Me.cmdAnzeigen.TabIndex = 1
        Me.cmdAnzeigen.Text = "Gewählte anzeigen"
        Me.cmdAnzeigen.UseVisualStyleBackColor = True
        '
        'cmdAlle
        '
        Me.cmdAlle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAlle.Location = New System.Drawing.Point(428, 289)
        Me.cmdAlle.Name = "cmdAlle"
        Me.cmdAlle.Size = New System.Drawing.Size(120, 41)
        Me.cmdAlle.TabIndex = 1
        Me.cmdAlle.Text = "Alle anzeigen"
        Me.cmdAlle.UseVisualStyleBackColor = True
        '
        'cmdDelAll
        '
        Me.cmdDelAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelAll.Location = New System.Drawing.Point(680, 289)
        Me.cmdDelAll.Name = "cmdDelAll"
        Me.cmdDelAll.Size = New System.Drawing.Size(120, 41)
        Me.cmdDelAll.TabIndex = 1
        Me.cmdDelAll.Text = "Alle löschen"
        Me.cmdDelAll.UseVisualStyleBackColor = True
        '
        'cmdDelChoosed
        '
        Me.cmdDelChoosed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelChoosed.Location = New System.Drawing.Point(554, 289)
        Me.cmdDelChoosed.Name = "cmdDelChoosed"
        Me.cmdDelChoosed.Size = New System.Drawing.Size(120, 41)
        Me.cmdDelChoosed.TabIndex = 1
        Me.cmdDelChoosed.Text = "Gewählte löschen"
        Me.cmdDelChoosed.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(225, 170)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 41)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Gewählte löschen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtEintrag
        '
        Me.txtEintrag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEintrag.Location = New System.Drawing.Point(26, 300)
        Me.txtEintrag.Name = "txtEintrag"
        Me.txtEintrag.Size = New System.Drawing.Size(100, 20)
        Me.txtEintrag.TabIndex = 2
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Location = New System.Drawing.Point(132, 289)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(120, 41)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Hinzufügen"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdMove
        '
        Me.cmdMove.Location = New System.Drawing.Point(380, 192)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(55, 46)
        Me.cmdMove.TabIndex = 3
        Me.cmdMove.Text = "-->"
        Me.cmdMove.UseVisualStyleBackColor = True
        '
        'lstFertig
        '
        Me.lstFertig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstFertig.FormattingEnabled = True
        Me.lstFertig.Location = New System.Drawing.Point(516, 41)
        Me.lstFertig.Name = "lstFertig"
        Me.lstFertig.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFertig.Size = New System.Drawing.Size(250, 212)
        Me.lstFertig.TabIndex = 0
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Liste (*.lst) | *.lst"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripButton, Me.ÖffnenToolStripButton, Me.SpeichernToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(815, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NeuToolStripButton
        '
        Me.NeuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NeuToolStripButton.Image = CType(resources.GetObject("NeuToolStripButton.Image"), System.Drawing.Image)
        Me.NeuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripButton.Name = "NeuToolStripButton"
        Me.NeuToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NeuToolStripButton.Text = "&Neu"
        '
        'ÖffnenToolStripButton
        '
        Me.ÖffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ÖffnenToolStripButton.Image = CType(resources.GetObject("ÖffnenToolStripButton.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripButton.Name = "ÖffnenToolStripButton"
        Me.ÖffnenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ÖffnenToolStripButton.Text = "Ö&ffnen"
        '
        'SpeichernToolStripButton
        '
        Me.SpeichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SpeichernToolStripButton.Image = CType(resources.GetObject("SpeichernToolStripButton.Image"), System.Drawing.Image)
        Me.SpeichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripButton.Name = "SpeichernToolStripButton"
        Me.SpeichernToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SpeichernToolStripButton.Text = "&Speichern"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 342)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdMove)
        Me.Controls.Add(Me.txtEintrag)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdDelChoosed)
        Me.Controls.Add(Me.cmdDelAll)
        Me.Controls.Add(Me.cmdAlle)
        Me.Controls.Add(Me.cmdAnzeigen)
        Me.Controls.Add(Me.lstFertig)
        Me.Controls.Add(Me.lstErinnerungen)
        Me.MinimumSize = New System.Drawing.Size(831, 380)
        Me.Name = "Form1"
        Me.Text = "Erinnerungsliste"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstErinnerungen As System.Windows.Forms.ListBox
    Friend WithEvents cmdAnzeigen As System.Windows.Forms.Button
    Friend WithEvents cmdAlle As System.Windows.Forms.Button
    Friend WithEvents cmdDelAll As System.Windows.Forms.Button
    Friend WithEvents cmdDelChoosed As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtEintrag As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdMove As System.Windows.Forms.Button
    Friend WithEvents lstFertig As System.Windows.Forms.ListBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NeuToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ÖffnenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SpeichernToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
