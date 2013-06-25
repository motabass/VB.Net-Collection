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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKapital = New System.Windows.Forms.TextBox()
        Me.txtZeit = New System.Windows.Forms.TextBox()
        Me.txtSatz = New System.Windows.Forms.TextBox()
        Me.cmdBerechne = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbZinsen = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kapital"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Laufzeit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Zinssatz"
        '
        'txtKapital
        '
        Me.txtKapital.Location = New System.Drawing.Point(84, 30)
        Me.txtKapital.Name = "txtKapital"
        Me.txtKapital.Size = New System.Drawing.Size(128, 20)
        Me.txtKapital.TabIndex = 1
        '
        'txtZeit
        '
        Me.txtZeit.Location = New System.Drawing.Point(84, 82)
        Me.txtZeit.Name = "txtZeit"
        Me.txtZeit.Size = New System.Drawing.Size(128, 20)
        Me.txtZeit.TabIndex = 1
        '
        'txtSatz
        '
        Me.txtSatz.Location = New System.Drawing.Point(84, 132)
        Me.txtSatz.Name = "txtSatz"
        Me.txtSatz.Size = New System.Drawing.Size(128, 20)
        Me.txtSatz.TabIndex = 1
        '
        'cmdBerechne
        '
        Me.cmdBerechne.Location = New System.Drawing.Point(252, 77)
        Me.cmdBerechne.Name = "cmdBerechne"
        Me.cmdBerechne.Size = New System.Drawing.Size(165, 29)
        Me.cmdBerechne.TabIndex = 2
        Me.cmdBerechne.Text = "Berrechne"
        Me.cmdBerechne.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Zinsen:"
        '
        'lbZinsen
        '
        Me.lbZinsen.AutoSize = True
        Me.lbZinsen.Location = New System.Drawing.Point(347, 135)
        Me.lbZinsen.Name = "lbZinsen"
        Me.lbZinsen.Size = New System.Drawing.Size(13, 13)
        Me.lbZinsen.TabIndex = 4
        Me.lbZinsen.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 183)
        Me.Controls.Add(Me.lbZinsen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdBerechne)
        Me.Controls.Add(Me.txtSatz)
        Me.Controls.Add(Me.txtZeit)
        Me.Controls.Add(Me.txtKapital)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Zinsrechner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKapital As System.Windows.Forms.TextBox
    Friend WithEvents txtZeit As System.Windows.Forms.TextBox
    Friend WithEvents txtSatz As System.Windows.Forms.TextBox
    Friend WithEvents cmdBerechne As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbZinsen As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
