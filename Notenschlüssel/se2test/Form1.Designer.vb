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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdEingabe = New System.Windows.Forms.Button()
        Me.txtAnzahl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtZusammen = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPunkte = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmdEingabe
        '
        Me.cmdEingabe.Location = New System.Drawing.Point(110, 101)
        Me.cmdEingabe.Name = "cmdEingabe"
        Me.cmdEingabe.Size = New System.Drawing.Size(75, 23)
        Me.cmdEingabe.TabIndex = 3
        Me.cmdEingabe.Text = "Eingabe"
        Me.cmdEingabe.UseVisualStyleBackColor = True
        '
        'txtAnzahl
        '
        Me.txtAnzahl.Location = New System.Drawing.Point(110, 12)
        Me.txtAnzahl.Name = "txtAnzahl"
        Me.txtAnzahl.Size = New System.Drawing.Size(45, 20)
        Me.txtAnzahl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Anzahl der Beispiele"
        '
        'txtZusammen
        '
        Me.txtZusammen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtZusammen.Enabled = False
        Me.txtZusammen.Location = New System.Drawing.Point(254, 12)
        Me.txtZusammen.Multiline = True
        Me.txtZusammen.Name = "txtZusammen"
        Me.txtZusammen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtZusammen.Size = New System.Drawing.Size(270, 162)
        Me.txtZusammen.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 75)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'txtPunkte
        '
        Me.txtPunkte.Location = New System.Drawing.Point(110, 43)
        Me.txtPunkte.Name = "txtPunkte"
        Me.txtPunkte.Size = New System.Drawing.Size(45, 20)
        Me.txtPunkte.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Erreichbare Punkte"
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(12, 151)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 3
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 186)
        Me.Controls.Add(Me.txtPunkte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtZusammen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnzahl)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdEingabe)
        Me.Name = "Form1"
        Me.Text = "Notenrechner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdEingabe As System.Windows.Forms.Button
    Friend WithEvents txtAnzahl As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZusammen As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPunkte As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button

End Class
