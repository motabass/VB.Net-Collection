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
        Me.scrR = New System.Windows.Forms.HScrollBar()
        Me.scrG = New System.Windows.Forms.HScrollBar()
        Me.scrB = New System.Windows.Forms.HScrollBar()
        Me.lbR = New System.Windows.Forms.Label()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lbG = New System.Windows.Forms.Label()
        Me.lbB = New System.Windows.Forms.Label()
        Me.lbRot = New System.Windows.Forms.Label()
        Me.cmdZufall = New System.Windows.Forms.Button()
        Me.lbGruen = New System.Windows.Forms.Label()
        Me.lbBlau = New System.Windows.Forms.Label()
        Me.lbMix = New System.Windows.Forms.Label()
        Me.lbGB = New System.Windows.Forms.Label()
        Me.lbRG = New System.Windows.Forms.Label()
        Me.lbRB = New System.Windows.Forms.Label()
        Me.cmdEnde = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'scrR
        '
        Me.scrR.LargeChange = 1
        Me.scrR.Location = New System.Drawing.Point(34, 28)
        Me.scrR.Maximum = 255
        Me.scrR.Name = "scrR"
        Me.scrR.Size = New System.Drawing.Size(358, 17)
        Me.scrR.TabIndex = 0
        '
        'scrG
        '
        Me.scrG.LargeChange = 1
        Me.scrG.Location = New System.Drawing.Point(34, 67)
        Me.scrG.Maximum = 255
        Me.scrG.Name = "scrG"
        Me.scrG.Size = New System.Drawing.Size(358, 17)
        Me.scrG.TabIndex = 0
        '
        'scrB
        '
        Me.scrB.LargeChange = 1
        Me.scrB.Location = New System.Drawing.Point(34, 106)
        Me.scrB.Maximum = 255
        Me.scrB.Name = "scrB"
        Me.scrB.Size = New System.Drawing.Size(358, 17)
        Me.scrB.TabIndex = 0
        '
        'lbR
        '
        Me.lbR.Location = New System.Drawing.Point(498, 28)
        Me.lbR.Name = "lbR"
        Me.lbR.Size = New System.Drawing.Size(47, 23)
        Me.lbR.TabIndex = 1
        Me.lbR.Text = "           "
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(410, 28)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(53, 20)
        Me.txtR.TabIndex = 0
        Me.txtR.Text = "0"
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(410, 67)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(53, 20)
        Me.txtG.TabIndex = 1
        Me.txtG.Text = "0"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(410, 106)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(53, 20)
        Me.txtB.TabIndex = 2
        Me.txtB.Text = "0"
        '
        'lbG
        '
        Me.lbG.Location = New System.Drawing.Point(498, 67)
        Me.lbG.Name = "lbG"
        Me.lbG.Size = New System.Drawing.Size(47, 23)
        Me.lbG.TabIndex = 1
        Me.lbG.Text = "           "
        '
        'lbB
        '
        Me.lbB.Location = New System.Drawing.Point(498, 106)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(47, 23)
        Me.lbB.TabIndex = 1
        Me.lbB.Text = "           "
        '
        'lbRot
        '
        Me.lbRot.BackColor = System.Drawing.Color.Black
        Me.lbRot.Location = New System.Drawing.Point(305, 158)
        Me.lbRot.Name = "lbRot"
        Me.lbRot.Size = New System.Drawing.Size(87, 68)
        Me.lbRot.TabIndex = 1
        Me.lbRot.Text = "           "
        '
        'cmdZufall
        '
        Me.cmdZufall.Location = New System.Drawing.Point(55, 158)
        Me.cmdZufall.Name = "cmdZufall"
        Me.cmdZufall.Size = New System.Drawing.Size(75, 23)
        Me.cmdZufall.TabIndex = 3
        Me.cmdZufall.Text = "Zufall"
        Me.cmdZufall.UseVisualStyleBackColor = True
        '
        'lbGruen
        '
        Me.lbGruen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbGruen.Location = New System.Drawing.Point(277, 192)
        Me.lbGruen.Name = "lbGruen"
        Me.lbGruen.Size = New System.Drawing.Size(86, 68)
        Me.lbGruen.TabIndex = 1
        Me.lbGruen.Text = "           "
        '
        'lbBlau
        '
        Me.lbBlau.BackColor = System.Drawing.Color.Yellow
        Me.lbBlau.Location = New System.Drawing.Point(334, 192)
        Me.lbBlau.Name = "lbBlau"
        Me.lbBlau.Size = New System.Drawing.Size(86, 68)
        Me.lbBlau.TabIndex = 1
        Me.lbBlau.Text = "           "
        '
        'lbMix
        '
        Me.lbMix.BackColor = System.Drawing.Color.White
        Me.lbMix.Location = New System.Drawing.Point(334, 192)
        Me.lbMix.Name = "lbMix"
        Me.lbMix.Size = New System.Drawing.Size(29, 34)
        Me.lbMix.TabIndex = 1
        Me.lbMix.Text = "           "
        '
        'lbGB
        '
        Me.lbGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbGB.Location = New System.Drawing.Point(334, 226)
        Me.lbGB.Name = "lbGB"
        Me.lbGB.Size = New System.Drawing.Size(29, 34)
        Me.lbGB.TabIndex = 1
        Me.lbGB.Text = "           "
        '
        'lbRG
        '
        Me.lbRG.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbRG.Location = New System.Drawing.Point(305, 192)
        Me.lbRG.Name = "lbRG"
        Me.lbRG.Size = New System.Drawing.Size(29, 34)
        Me.lbRG.TabIndex = 1
        Me.lbRG.Text = "           "
        '
        'lbRB
        '
        Me.lbRB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbRB.Location = New System.Drawing.Point(363, 192)
        Me.lbRB.Name = "lbRB"
        Me.lbRB.Size = New System.Drawing.Size(29, 34)
        Me.lbRB.TabIndex = 1
        Me.lbRB.Text = "           "
        '
        'cmdEnde
        '
        Me.cmdEnde.Location = New System.Drawing.Point(55, 202)
        Me.cmdEnde.Name = "cmdEnde"
        Me.cmdEnde.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnde.TabIndex = 4
        Me.cmdEnde.Text = "Ende"
        Me.cmdEnde.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 288)
        Me.Controls.Add(Me.cmdEnde)
        Me.Controls.Add(Me.lbMix)
        Me.Controls.Add(Me.lbRG)
        Me.Controls.Add(Me.lbRB)
        Me.Controls.Add(Me.lbGB)
        Me.Controls.Add(Me.cmdZufall)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.lbRot)
        Me.Controls.Add(Me.lbB)
        Me.Controls.Add(Me.lbG)
        Me.Controls.Add(Me.lbR)
        Me.Controls.Add(Me.scrB)
        Me.Controls.Add(Me.scrG)
        Me.Controls.Add(Me.scrR)
        Me.Controls.Add(Me.lbBlau)
        Me.Controls.Add(Me.lbGruen)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(591, 326)
        Me.MinimumSize = New System.Drawing.Size(591, 326)
        Me.Name = "Form1"
        Me.Text = "Farbmischer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scrR As System.Windows.Forms.HScrollBar
    Friend WithEvents scrG As System.Windows.Forms.HScrollBar
    Friend WithEvents scrB As System.Windows.Forms.HScrollBar
    Friend WithEvents lbR As System.Windows.Forms.Label
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents txtG As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents lbG As System.Windows.Forms.Label
    Friend WithEvents lbB As System.Windows.Forms.Label
    Friend WithEvents lbRot As System.Windows.Forms.Label
    Friend WithEvents cmdZufall As System.Windows.Forms.Button
    Friend WithEvents lbGruen As System.Windows.Forms.Label
    Friend WithEvents lbBlau As System.Windows.Forms.Label
    Friend WithEvents lbMix As System.Windows.Forms.Label
    Friend WithEvents lbGB As System.Windows.Forms.Label
    Friend WithEvents lbRG As System.Windows.Forms.Label
    Friend WithEvents lbRB As System.Windows.Forms.Label
    Friend WithEvents cmdEnde As System.Windows.Forms.Button

End Class
