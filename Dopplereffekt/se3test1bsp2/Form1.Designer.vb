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
        Me.sbFrequenz = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbFrequenz = New System.Windows.Forms.Label()
        Me.txtGeschwindigkeit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbErgebnis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sbFrequenz
        '
        Me.sbFrequenz.LargeChange = 1
        Me.sbFrequenz.Location = New System.Drawing.Point(113, 31)
        Me.sbFrequenz.Maximum = 500
        Me.sbFrequenz.Minimum = 100
        Me.sbFrequenz.Name = "sbFrequenz"
        Me.sbFrequenz.Size = New System.Drawing.Size(311, 17)
        Me.sbFrequenz.TabIndex = 0
        Me.sbFrequenz.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Frequenz"
        '
        'lbFrequenz
        '
        Me.lbFrequenz.AutoSize = True
        Me.lbFrequenz.Location = New System.Drawing.Point(451, 33)
        Me.lbFrequenz.Name = "lbFrequenz"
        Me.lbFrequenz.Size = New System.Drawing.Size(0, 13)
        Me.lbFrequenz.TabIndex = 2
        '
        'txtGeschwindigkeit
        '
        Me.txtGeschwindigkeit.Location = New System.Drawing.Point(113, 85)
        Me.txtGeschwindigkeit.Name = "txtGeschwindigkeit"
        Me.txtGeschwindigkeit.Size = New System.Drawing.Size(57, 20)
        Me.txtGeschwindigkeit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Geschwindigkeit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "km/h"
        '
        'lbErgebnis
        '
        Me.lbErgebnis.AutoSize = True
        Me.lbErgebnis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbErgebnis.Location = New System.Drawing.Point(279, 117)
        Me.lbErgebnis.Name = "lbErgebnis"
        Me.lbErgebnis.Size = New System.Drawing.Size(0, 13)
        Me.lbErgebnis.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 142)
        Me.Controls.Add(Me.lbErgebnis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGeschwindigkeit)
        Me.Controls.Add(Me.lbFrequenz)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sbFrequenz)
        Me.Name = "Form1"
        Me.Text = "Dopplereffekt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbFrequenz As System.Windows.Forms.HScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbFrequenz As System.Windows.Forms.Label
    Friend WithEvents txtGeschwindigkeit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbErgebnis As System.Windows.Forms.Label

End Class
