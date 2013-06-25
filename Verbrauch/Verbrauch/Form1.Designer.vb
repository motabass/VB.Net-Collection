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
        Me.cbAuto = New System.Windows.Forms.ComboBox()
        Me.txtKilometer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdBerechen = New System.Windows.Forms.Button()
        Me.lbErgebnis = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbAuto
        '
        Me.cbAuto.FormattingEnabled = True
        Me.cbAuto.Items.AddRange(New Object() {"VW Golf", "Mazda 5", "Lamborghini Diablo"})
        Me.cbAuto.Location = New System.Drawing.Point(60, 55)
        Me.cbAuto.Name = "cbAuto"
        Me.cbAuto.Size = New System.Drawing.Size(121, 21)
        Me.cbAuto.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cbAuto, "Auto auswählen (Per Eingabe + Enter können sie Einträge hinzufügen)")
        '
        'txtKilometer
        '
        Me.txtKilometer.Location = New System.Drawing.Point(60, 145)
        Me.txtKilometer.Name = "txtKilometer"
        Me.txtKilometer.Size = New System.Drawing.Size(100, 20)
        Me.txtKilometer.TabIndex = 1
        Me.txtKilometer.Text = "100"
        Me.ToolTip1.SetToolTip(Me.txtKilometer, "Gefahrene Kilometer eingeben")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gefahrene Kilometer"
        '
        'cmdBerechen
        '
        Me.cmdBerechen.Location = New System.Drawing.Point(197, 143)
        Me.cmdBerechen.Name = "cmdBerechen"
        Me.cmdBerechen.Size = New System.Drawing.Size(75, 23)
        Me.cmdBerechen.TabIndex = 3
        Me.cmdBerechen.Text = "Berechnen"
        Me.ToolTip1.SetToolTip(Me.cmdBerechen, "Zum Berechnen klicken")
        Me.cmdBerechen.UseVisualStyleBackColor = True
        '
        'lbErgebnis
        '
        Me.lbErgebnis.AutoSize = True
        Me.lbErgebnis.Location = New System.Drawing.Point(194, 213)
        Me.lbErgebnis.Name = "lbErgebnis"
        Me.lbErgebnis.Size = New System.Drawing.Size(0, 13)
        Me.lbErgebnis.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.lbErgebnis, "Berrechneter Verbauch in Litern")
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(360, 29)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(439, 244)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 5
        Me.pic1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic1, "Aktuell ausgewähltes Fahrzeug")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 20000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 310)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.lbErgebnis)
        Me.Controls.Add(Me.cmdBerechen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKilometer)
        Me.Controls.Add(Me.cbAuto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbAuto As System.Windows.Forms.ComboBox
    Friend WithEvents txtKilometer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdBerechen As System.Windows.Forms.Button
    Friend WithEvents lbErgebnis As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
