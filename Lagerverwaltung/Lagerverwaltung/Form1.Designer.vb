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
        Me.lstArtikel = New System.Windows.Forms.ListBox()
        Me.lstStueck = New System.Windows.Forms.ListBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAendern = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EintragToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllesLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GewählteLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllesLöschenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtArtikel = New System.Windows.Forms.TextBox()
        Me.txtStueck = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbStueck = New System.Windows.Forms.TrackBar()
        Me.picArtikel = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.tbStueck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArtikel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstArtikel
        '
        Me.lstArtikel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstArtikel.FormattingEnabled = True
        Me.lstArtikel.Location = New System.Drawing.Point(29, 47)
        Me.lstArtikel.Name = "lstArtikel"
        Me.lstArtikel.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstArtikel.Size = New System.Drawing.Size(134, 238)
        Me.lstArtikel.TabIndex = 5
        '
        'lstStueck
        '
        Me.lstStueck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstStueck.Enabled = False
        Me.lstStueck.FormattingEnabled = True
        Me.lstStueck.Location = New System.Drawing.Point(162, 47)
        Me.lstStueck.Name = "lstStueck"
        Me.lstStueck.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstStueck.Size = New System.Drawing.Size(73, 238)
        Me.lstStueck.TabIndex = 6
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Location = New System.Drawing.Point(295, 175)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Löschen"
        Me.ToolTip1.SetToolTip(Me.cmdDelete, "Löscht die gewählten Einträge.")
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAendern
        '
        Me.cmdAendern.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAendern.Location = New System.Drawing.Point(295, 146)
        Me.cmdAendern.Name = "cmdAendern"
        Me.cmdAendern.Size = New System.Drawing.Size(75, 23)
        Me.cmdAendern.TabIndex = 3
        Me.cmdAendern.Text = "Ändern"
        Me.ToolTip1.SetToolTip(Me.cmdAendern, "Lässt Sie die Stückzahl ändern." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stellen sie einfach ""+"" oder ""-"" vorran.")
        Me.cmdAendern.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Location = New System.Drawing.Point(295, 117)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Hinzufügen"
        Me.ToolTip1.SetToolTip(Me.cmdAdd, "Fügt den im Textfeld eingetragenen Artikel zur Liste hinzu.")
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EintragToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EintragToolStripMenuItem
        '
        Me.EintragToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem, Me.AllesLöschenToolStripMenuItem, Me.ÄndernToolStripMenuItem})
        Me.EintragToolStripMenuItem.Name = "EintragToolStripMenuItem"
        Me.EintragToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EintragToolStripMenuItem.Text = "Einträge..."
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.LöschenToolStripMenuItem.Text = "Hinzufügen.."
        '
        'AllesLöschenToolStripMenuItem
        '
        Me.AllesLöschenToolStripMenuItem.Name = "AllesLöschenToolStripMenuItem"
        Me.AllesLöschenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AllesLöschenToolStripMenuItem.Text = "Ändern..."
        '
        'ÄndernToolStripMenuItem
        '
        Me.ÄndernToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GewählteLöschenToolStripMenuItem, Me.AllesLöschenToolStripMenuItem1})
        Me.ÄndernToolStripMenuItem.Name = "ÄndernToolStripMenuItem"
        Me.ÄndernToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ÄndernToolStripMenuItem.Text = "Löschen..."
        '
        'GewählteLöschenToolStripMenuItem
        '
        Me.GewählteLöschenToolStripMenuItem.Name = "GewählteLöschenToolStripMenuItem"
        Me.GewählteLöschenToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.GewählteLöschenToolStripMenuItem.Text = "Gewählte löschen"
        '
        'AllesLöschenToolStripMenuItem1
        '
        Me.AllesLöschenToolStripMenuItem1.Name = "AllesLöschenToolStripMenuItem1"
        Me.AllesLöschenToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.AllesLöschenToolStripMenuItem1.Text = "Alles löschen"
        '
        'txtArtikel
        '
        Me.txtArtikel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArtikel.Location = New System.Drawing.Point(283, 62)
        Me.txtArtikel.Name = "txtArtikel"
        Me.txtArtikel.Size = New System.Drawing.Size(142, 20)
        Me.txtArtikel.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtArtikel, "Geben Sie hier den Artikel-Namen ein.")
        '
        'txtStueck
        '
        Me.txtStueck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStueck.Location = New System.Drawing.Point(431, 62)
        Me.txtStueck.Name = "txtStueck"
        Me.txtStueck.Size = New System.Drawing.Size(49, 20)
        Me.txtStueck.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtStueck, "Geben Sie hier die Stückzahl ein.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Artikel"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stück"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Artikel"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stück"
        '
        'tbStueck
        '
        Me.tbStueck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbStueck.Location = New System.Drawing.Point(437, 82)
        Me.tbStueck.Maximum = 999
        Me.tbStueck.Minimum = 1
        Me.tbStueck.Name = "tbStueck"
        Me.tbStueck.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbStueck.Size = New System.Drawing.Size(45, 190)
        Me.tbStueck.TabIndex = 9
        Me.tbStueck.Value = 1
        '
        'picArtikel
        '
        Me.picArtikel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picArtikel.Location = New System.Drawing.Point(537, 47)
        Me.picArtikel.Name = "picArtikel"
        Me.picArtikel.Size = New System.Drawing.Size(223, 215)
        Me.picArtikel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picArtikel.TabIndex = 10
        Me.picArtikel.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 300)
        Me.Controls.Add(Me.picArtikel)
        Me.Controls.Add(Me.tbStueck)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStueck)
        Me.Controls.Add(Me.txtArtikel)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdAendern)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lstStueck)
        Me.Controls.Add(Me.lstArtikel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(428, 273)
        Me.Name = "Form1"
        Me.Text = "Lagerverwaltung"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.tbStueck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArtikel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstArtikel As System.Windows.Forms.ListBox
    Friend WithEvents lstStueck As System.Windows.Forms.ListBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdAendern As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EintragToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllesLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtArtikel As System.Windows.Forms.TextBox
    Friend WithEvents txtStueck As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GewählteLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllesLöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbStueck As System.Windows.Forms.TrackBar
    Friend WithEvents picArtikel As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
