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
        Me.cmdRadius = New System.Windows.Forms.Button()
        Me.cmdFlaeche = New System.Windows.Forms.Button()
        Me.cmdUmfang = New System.Windows.Forms.Button()
        Me.cmdAusgabe = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRadius
        '
        Me.cmdRadius.Location = New System.Drawing.Point(68, 37)
        Me.cmdRadius.Name = "cmdRadius"
        Me.cmdRadius.Size = New System.Drawing.Size(115, 23)
        Me.cmdRadius.TabIndex = 0
        Me.cmdRadius.Text = "Radius eingeben"
        Me.cmdRadius.UseVisualStyleBackColor = True
        '
        'cmdFlaeche
        '
        Me.cmdFlaeche.Location = New System.Drawing.Point(68, 66)
        Me.cmdFlaeche.Name = "cmdFlaeche"
        Me.cmdFlaeche.Size = New System.Drawing.Size(115, 23)
        Me.cmdFlaeche.TabIndex = 0
        Me.cmdFlaeche.Text = "Fläche eingeben"
        Me.cmdFlaeche.UseVisualStyleBackColor = True
        '
        'cmdUmfang
        '
        Me.cmdUmfang.Location = New System.Drawing.Point(68, 95)
        Me.cmdUmfang.Name = "cmdUmfang"
        Me.cmdUmfang.Size = New System.Drawing.Size(115, 23)
        Me.cmdUmfang.TabIndex = 0
        Me.cmdUmfang.Text = "Umfang eingeben"
        Me.cmdUmfang.UseVisualStyleBackColor = True
        '
        'cmdAusgabe
        '
        Me.cmdAusgabe.Location = New System.Drawing.Point(203, 66)
        Me.cmdAusgabe.Name = "cmdAusgabe"
        Me.cmdAusgabe.Size = New System.Drawing.Size(75, 23)
        Me.cmdAusgabe.TabIndex = 1
        Me.cmdAusgabe.Text = "Ausgeben"
        Me.cmdAusgabe.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(203, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(521, 285)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 392)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdAusgabe)
        Me.Controls.Add(Me.cmdUmfang)
        Me.Controls.Add(Me.cmdFlaeche)
        Me.Controls.Add(Me.cmdRadius)
        Me.Name = "Form1"
        Me.Text = "Kreis"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdRadius As System.Windows.Forms.Button
    Friend WithEvents cmdFlaeche As System.Windows.Forms.Button
    Friend WithEvents cmdUmfang As System.Windows.Forms.Button
    Friend WithEvents cmdAusgabe As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
