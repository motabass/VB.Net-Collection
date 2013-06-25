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
        Me.cmdLine = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdEl = New System.Windows.Forms.Button()
        Me.cmdRe = New System.Windows.Forms.Button()
        Me.cmdText = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdLine
        '
        Me.cmdLine.Location = New System.Drawing.Point(32, 29)
        Me.cmdLine.Name = "cmdLine"
        Me.cmdLine.Size = New System.Drawing.Size(75, 23)
        Me.cmdLine.TabIndex = 0
        Me.cmdLine.Text = "Linie"
        Me.cmdLine.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(24, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(775, 495)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmdEl
        '
        Me.cmdEl.Location = New System.Drawing.Point(194, 29)
        Me.cmdEl.Name = "cmdEl"
        Me.cmdEl.Size = New System.Drawing.Size(75, 23)
        Me.cmdEl.TabIndex = 0
        Me.cmdEl.Text = "Ellipse"
        Me.cmdEl.UseVisualStyleBackColor = True
        '
        'cmdRe
        '
        Me.cmdRe.Location = New System.Drawing.Point(113, 29)
        Me.cmdRe.Name = "cmdRe"
        Me.cmdRe.Size = New System.Drawing.Size(75, 23)
        Me.cmdRe.TabIndex = 0
        Me.cmdRe.Text = "Rechteck"
        Me.cmdRe.UseVisualStyleBackColor = True
        '
        'cmdText
        '
        Me.cmdText.Location = New System.Drawing.Point(275, 29)
        Me.cmdText.Name = "cmdText"
        Me.cmdText.Size = New System.Drawing.Size(75, 23)
        Me.cmdText.TabIndex = 0
        Me.cmdText.Text = "Text"
        Me.cmdText.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdRe)
        Me.Controls.Add(Me.cmdText)
        Me.Controls.Add(Me.cmdEl)
        Me.Controls.Add(Me.cmdLine)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdLine As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdEl As System.Windows.Forms.Button
    Friend WithEvents cmdRe As System.Windows.Forms.Button
    Friend WithEvents cmdText As System.Windows.Forms.Button

End Class
