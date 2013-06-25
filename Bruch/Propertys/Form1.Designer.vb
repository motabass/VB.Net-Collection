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
        Me.cmdBruch = New System.Windows.Forms.Button()
        Me.lbBruch = New System.Windows.Forms.Label()
        Me.lbWert = New System.Windows.Forms.Label()
        Me.lbWert2 = New System.Windows.Forms.Label()
        Me.lbBruch2 = New System.Windows.Forms.Label()
        Me.cmdBruch2 = New System.Windows.Forms.Button()
        Me.cmdKurz1 = New System.Windows.Forms.Button()
        Me.cmdKurz2 = New System.Windows.Forms.Button()
        Me.cmdAddieren = New System.Windows.Forms.Button()
        Me.cmdMulti = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBruch
        '
        Me.cmdBruch.Location = New System.Drawing.Point(25, 22)
        Me.cmdBruch.Name = "cmdBruch"
        Me.cmdBruch.Size = New System.Drawing.Size(120, 23)
        Me.cmdBruch.TabIndex = 0
        Me.cmdBruch.Text = "Bruch 1 eingeben"
        Me.cmdBruch.UseVisualStyleBackColor = True
        '
        'lbBruch
        '
        Me.lbBruch.AutoSize = True
        Me.lbBruch.Location = New System.Drawing.Point(175, 27)
        Me.lbBruch.Name = "lbBruch"
        Me.lbBruch.Size = New System.Drawing.Size(0, 13)
        Me.lbBruch.TabIndex = 1
        '
        'lbWert
        '
        Me.lbWert.AutoSize = True
        Me.lbWert.Location = New System.Drawing.Point(178, 60)
        Me.lbWert.Name = "lbWert"
        Me.lbWert.Size = New System.Drawing.Size(0, 13)
        Me.lbWert.TabIndex = 2
        '
        'lbWert2
        '
        Me.lbWert2.AutoSize = True
        Me.lbWert2.Location = New System.Drawing.Point(178, 148)
        Me.lbWert2.Name = "lbWert2"
        Me.lbWert2.Size = New System.Drawing.Size(0, 13)
        Me.lbWert2.TabIndex = 5
        '
        'lbBruch2
        '
        Me.lbBruch2.AutoSize = True
        Me.lbBruch2.Location = New System.Drawing.Point(175, 115)
        Me.lbBruch2.Name = "lbBruch2"
        Me.lbBruch2.Size = New System.Drawing.Size(0, 13)
        Me.lbBruch2.TabIndex = 4
        '
        'cmdBruch2
        '
        Me.cmdBruch2.Location = New System.Drawing.Point(25, 110)
        Me.cmdBruch2.Name = "cmdBruch2"
        Me.cmdBruch2.Size = New System.Drawing.Size(120, 23)
        Me.cmdBruch2.TabIndex = 3
        Me.cmdBruch2.Text = "Bruch 2 eingeben"
        Me.cmdBruch2.UseVisualStyleBackColor = True
        '
        'cmdKurz1
        '
        Me.cmdKurz1.Location = New System.Drawing.Point(25, 50)
        Me.cmdKurz1.Name = "cmdKurz1"
        Me.cmdKurz1.Size = New System.Drawing.Size(75, 23)
        Me.cmdKurz1.TabIndex = 6
        Me.cmdKurz1.Text = "Kürzen"
        Me.cmdKurz1.UseVisualStyleBackColor = True
        '
        'cmdKurz2
        '
        Me.cmdKurz2.Location = New System.Drawing.Point(25, 138)
        Me.cmdKurz2.Name = "cmdKurz2"
        Me.cmdKurz2.Size = New System.Drawing.Size(75, 23)
        Me.cmdKurz2.TabIndex = 6
        Me.cmdKurz2.Text = "Kürzen"
        Me.cmdKurz2.UseVisualStyleBackColor = True
        '
        'cmdAddieren
        '
        Me.cmdAddieren.Location = New System.Drawing.Point(107, 50)
        Me.cmdAddieren.Name = "cmdAddieren"
        Me.cmdAddieren.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddieren.TabIndex = 7
        Me.cmdAddieren.Text = "Addieren"
        Me.cmdAddieren.UseVisualStyleBackColor = True
        '
        'cmdMulti
        '
        Me.cmdMulti.Location = New System.Drawing.Point(107, 138)
        Me.cmdMulti.Name = "cmdMulti"
        Me.cmdMulti.Size = New System.Drawing.Size(75, 23)
        Me.cmdMulti.TabIndex = 7
        Me.cmdMulti.Text = "Multipliziere"
        Me.cmdMulti.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmdMulti)
        Me.Controls.Add(Me.cmdAddieren)
        Me.Controls.Add(Me.cmdKurz2)
        Me.Controls.Add(Me.cmdKurz1)
        Me.Controls.Add(Me.lbWert2)
        Me.Controls.Add(Me.lbBruch2)
        Me.Controls.Add(Me.cmdBruch2)
        Me.Controls.Add(Me.lbWert)
        Me.Controls.Add(Me.lbBruch)
        Me.Controls.Add(Me.cmdBruch)
        Me.Name = "Form1"
        Me.Text = "Brüche"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBruch As System.Windows.Forms.Button
    Friend WithEvents lbBruch As System.Windows.Forms.Label
    Friend WithEvents lbWert As System.Windows.Forms.Label
    Friend WithEvents lbWert2 As System.Windows.Forms.Label
    Friend WithEvents lbBruch2 As System.Windows.Forms.Label
    Friend WithEvents cmdBruch2 As System.Windows.Forms.Button
    Friend WithEvents cmdKurz1 As System.Windows.Forms.Button
    Friend WithEvents cmdKurz2 As System.Windows.Forms.Button
    Friend WithEvents cmdAddieren As System.Windows.Forms.Button
    Friend WithEvents cmdMulti As System.Windows.Forms.Button

End Class
