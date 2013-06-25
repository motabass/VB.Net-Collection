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
        Me.lbMin = New System.Windows.Forms.Label()
        Me.lbMax = New System.Windows.Forms.Label()
        Me.lbDurch = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NeuToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ÖffnenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.lstWerte = New System.Windows.Forms.ListBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbMin
        '
        Me.lbMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMin.AutoSize = True
        Me.lbMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMin.Location = New System.Drawing.Point(94, 206)
        Me.lbMin.Name = "lbMin"
        Me.lbMin.Size = New System.Drawing.Size(76, 20)
        Me.lbMin.TabIndex = 0
        Me.lbMin.Text = "Minimum:"
        '
        'lbMax
        '
        Me.lbMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMax.AutoSize = True
        Me.lbMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMax.Location = New System.Drawing.Point(94, 237)
        Me.lbMax.Name = "lbMax"
        Me.lbMax.Size = New System.Drawing.Size(80, 20)
        Me.lbMax.TabIndex = 0
        Me.lbMax.Text = "Maximum:"
        '
        'lbDurch
        '
        Me.lbDurch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDurch.AutoSize = True
        Me.lbDurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDurch.Location = New System.Drawing.Point(94, 269)
        Me.lbDurch.Name = "lbDurch"
        Me.lbDurch.Size = New System.Drawing.Size(103, 20)
        Me.lbDurch.TabIndex = 0
        Me.lbDurch.Text = "Durchschnitt:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text | *.txt"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripButton, Me.ÖffnenToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(228, 25)
        Me.ToolStrip1.TabIndex = 1
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
        'lstWerte
        '
        Me.lstWerte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstWerte.FormattingEnabled = True
        Me.lstWerte.Location = New System.Drawing.Point(13, 29)
        Me.lstWerte.Name = "lstWerte"
        Me.lstWerte.Size = New System.Drawing.Size(78, 264)
        Me.lstWerte.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 307)
        Me.Controls.Add(Me.lstWerte)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbDurch)
        Me.Controls.Add(Me.lbMax)
        Me.Controls.Add(Me.lbMin)
        Me.MinimumSize = New System.Drawing.Size(244, 345)
        Me.Name = "Form1"
        Me.Text = "Temperaturen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbMin As System.Windows.Forms.Label
    Friend WithEvents lbMax As System.Windows.Forms.Label
    Friend WithEvents lbDurch As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NeuToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ÖffnenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstWerte As System.Windows.Forms.ListBox

End Class
