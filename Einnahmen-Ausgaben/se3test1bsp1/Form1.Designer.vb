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
        Me.lstEinAus = New System.Windows.Forms.ListBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgrammToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElementHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusgewählteLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picSmily = New System.Windows.Forms.PictureBox()
        Me.lbSumme = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picSmily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstEinAus
        '
        Me.lstEinAus.FormattingEnabled = True
        Me.lstEinAus.Location = New System.Drawing.Point(77, 92)
        Me.lstEinAus.Name = "lstEinAus"
        Me.lstEinAus.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstEinAus.Size = New System.Drawing.Size(120, 238)
        Me.lstEinAus.TabIndex = 0
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(309, 69)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(116, 33)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Element hinzufügen"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(309, 120)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(116, 33)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "Ausgewählte löschen"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(454, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgrammToolStripMenuItem
        '
        Me.ProgrammToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElementHinzufügenToolStripMenuItem, Me.AusgewählteLöschenToolStripMenuItem})
        Me.ProgrammToolStripMenuItem.Name = "ProgrammToolStripMenuItem"
        Me.ProgrammToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ProgrammToolStripMenuItem.Text = "Programm..."
        '
        'ElementHinzufügenToolStripMenuItem
        '
        Me.ElementHinzufügenToolStripMenuItem.Name = "ElementHinzufügenToolStripMenuItem"
        Me.ElementHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ElementHinzufügenToolStripMenuItem.Text = "Element hinzufügen"
        '
        'AusgewählteLöschenToolStripMenuItem
        '
        Me.AusgewählteLöschenToolStripMenuItem.Name = "AusgewählteLöschenToolStripMenuItem"
        Me.AusgewählteLöschenToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AusgewählteLöschenToolStripMenuItem.Text = "Ausgewählte löschen"
        '
        'picSmily
        '
        Me.picSmily.Location = New System.Drawing.Point(309, 231)
        Me.picSmily.Name = "picSmily"
        Me.picSmily.Size = New System.Drawing.Size(100, 99)
        Me.picSmily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmily.TabIndex = 3
        Me.picSmily.TabStop = False
        '
        'lbSumme
        '
        Me.lbSumme.AutoSize = True
        Me.lbSumme.Location = New System.Drawing.Point(74, 361)
        Me.lbSumme.Name = "lbSumme"
        Me.lbSumme.Size = New System.Drawing.Size(0, 13)
        Me.lbSumme.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Einnahmen/Ausgaben"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 401)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbSumme)
        Me.Controls.Add(Me.picSmily)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstEinAus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Ein- und Ausgaben"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picSmily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstEinAus As System.Windows.Forms.ListBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgrammToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElementHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusgewählteLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picSmily As System.Windows.Forms.PictureBox
    Friend WithEvents lbSumme As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
