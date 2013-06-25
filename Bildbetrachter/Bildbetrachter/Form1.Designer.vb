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
        Me.picBild = New System.Windows.Forms.PictureBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.gbGroesse = New System.Windows.Forms.GroupBox()
        Me.rdOriginal = New System.Windows.Forms.RadioButton()
        Me.rdProgramm = New System.Windows.Forms.RadioButton()
        Me.cbDateien = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGroesse.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBild
        '
        Me.picBild.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBild.Location = New System.Drawing.Point(216, 12)
        Me.picBild.MinimumSize = New System.Drawing.Size(465, 366)
        Me.picBild.Name = "picBild"
        Me.picBild.Size = New System.Drawing.Size(465, 366)
        Me.picBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBild.TabIndex = 0
        Me.picBild.TabStop = False
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(12, 12)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(75, 23)
        Me.cmdLoad.TabIndex = 1
        Me.cmdLoad.Text = "Laden"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'gbGroesse
        '
        Me.gbGroesse.Controls.Add(Me.rdOriginal)
        Me.gbGroesse.Controls.Add(Me.rdProgramm)
        Me.gbGroesse.Location = New System.Drawing.Point(48, 240)
        Me.gbGroesse.Name = "gbGroesse"
        Me.gbGroesse.Size = New System.Drawing.Size(95, 71)
        Me.gbGroesse.TabIndex = 2
        Me.gbGroesse.TabStop = False
        Me.gbGroesse.Text = "Größe"
        '
        'rdOriginal
        '
        Me.rdOriginal.AutoSize = True
        Me.rdOriginal.Location = New System.Drawing.Point(6, 43)
        Me.rdOriginal.Name = "rdOriginal"
        Me.rdOriginal.Size = New System.Drawing.Size(60, 17)
        Me.rdOriginal.TabIndex = 0
        Me.rdOriginal.Text = "Original"
        Me.rdOriginal.UseVisualStyleBackColor = True
        '
        'rdProgramm
        '
        Me.rdProgramm.AutoSize = True
        Me.rdProgramm.Checked = True
        Me.rdProgramm.Location = New System.Drawing.Point(7, 20)
        Me.rdProgramm.Name = "rdProgramm"
        Me.rdProgramm.Size = New System.Drawing.Size(75, 17)
        Me.rdProgramm.TabIndex = 0
        Me.rdProgramm.TabStop = True
        Me.rdProgramm.Text = "Angepasst"
        Me.rdProgramm.UseVisualStyleBackColor = True
        '
        'cbDateien
        '
        Me.cbDateien.FormattingEnabled = True
        Me.cbDateien.Location = New System.Drawing.Point(12, 51)
        Me.cbDateien.Name = "cbDateien"
        Me.cbDateien.Size = New System.Drawing.Size(198, 21)
        Me.cbDateien.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bilder JPG;GIF;PNG|*.jpg;*.gif;*.png"
        Me.OpenFileDialog1.Multiselect = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(55, 78)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(41, 40)
        Me.cmdBack.TabIndex = 4
        Me.cmdBack.Text = "<"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(102, 78)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(41, 40)
        Me.cmdNext.TabIndex = 4
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(709, 395)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cbDateien)
        Me.Controls.Add(Me.gbGroesse)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.picBild)
        Me.MinimumSize = New System.Drawing.Size(725, 433)
        Me.Name = "Form1"
        Me.Text = "Bildbetracher"
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGroesse.ResumeLayout(False)
        Me.gbGroesse.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBild As System.Windows.Forms.PictureBox
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents gbGroesse As System.Windows.Forms.GroupBox
    Friend WithEvents rdOriginal As System.Windows.Forms.RadioButton
    Friend WithEvents rdProgramm As System.Windows.Forms.RadioButton
    Friend WithEvents cbDateien As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button

End Class
