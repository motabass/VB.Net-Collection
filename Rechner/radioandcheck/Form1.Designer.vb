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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdModulo = New System.Windows.Forms.RadioButton()
        Me.rdDivision = New System.Windows.Forms.RadioButton()
        Me.rdMultiplikation = New System.Windows.Forms.RadioButton()
        Me.rdSubtraktion = New System.Windows.Forms.RadioButton()
        Me.rdAddition = New System.Windows.Forms.RadioButton()
        Me.txtZahl1 = New System.Windows.Forms.TextBox()
        Me.txtZahl2 = New System.Windows.Forms.TextBox()
        Me.lbErgebnis = New System.Windows.Forms.Label()
        Me.lbSymbol = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdModulo)
        Me.GroupBox1.Controls.Add(Me.rdDivision)
        Me.GroupBox1.Controls.Add(Me.rdMultiplikation)
        Me.GroupBox1.Controls.Add(Me.rdSubtraktion)
        Me.GroupBox1.Controls.Add(Me.rdAddition)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 156)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechenoperation"
        '
        'rdModulo
        '
        Me.rdModulo.AutoSize = True
        Me.rdModulo.Location = New System.Drawing.Point(6, 122)
        Me.rdModulo.Name = "rdModulo"
        Me.rdModulo.Size = New System.Drawing.Size(60, 17)
        Me.rdModulo.TabIndex = 4
        Me.rdModulo.Text = "Modulo"
        Me.rdModulo.UseVisualStyleBackColor = True
        '
        'rdDivision
        '
        Me.rdDivision.AutoSize = True
        Me.rdDivision.Location = New System.Drawing.Point(6, 99)
        Me.rdDivision.Name = "rdDivision"
        Me.rdDivision.Size = New System.Drawing.Size(62, 17)
        Me.rdDivision.TabIndex = 3
        Me.rdDivision.Text = "Division"
        Me.rdDivision.UseVisualStyleBackColor = True
        '
        'rdMultiplikation
        '
        Me.rdMultiplikation.AutoSize = True
        Me.rdMultiplikation.Location = New System.Drawing.Point(6, 76)
        Me.rdMultiplikation.Name = "rdMultiplikation"
        Me.rdMultiplikation.Size = New System.Drawing.Size(86, 17)
        Me.rdMultiplikation.TabIndex = 2
        Me.rdMultiplikation.Text = "Multiplikation"
        Me.rdMultiplikation.UseVisualStyleBackColor = True
        '
        'rdSubtraktion
        '
        Me.rdSubtraktion.AutoSize = True
        Me.rdSubtraktion.Location = New System.Drawing.Point(6, 53)
        Me.rdSubtraktion.Name = "rdSubtraktion"
        Me.rdSubtraktion.Size = New System.Drawing.Size(79, 17)
        Me.rdSubtraktion.TabIndex = 1
        Me.rdSubtraktion.Text = "Subtraktion"
        Me.rdSubtraktion.UseVisualStyleBackColor = True
        '
        'rdAddition
        '
        Me.rdAddition.AutoSize = True
        Me.rdAddition.Checked = True
        Me.rdAddition.Location = New System.Drawing.Point(7, 30)
        Me.rdAddition.Name = "rdAddition"
        Me.rdAddition.Size = New System.Drawing.Size(63, 17)
        Me.rdAddition.TabIndex = 0
        Me.rdAddition.TabStop = True
        Me.rdAddition.Text = "Addition"
        Me.rdAddition.UseVisualStyleBackColor = True
        '
        'txtZahl1
        '
        Me.txtZahl1.Location = New System.Drawing.Point(59, 58)
        Me.txtZahl1.Name = "txtZahl1"
        Me.txtZahl1.Size = New System.Drawing.Size(100, 20)
        Me.txtZahl1.TabIndex = 0
        '
        'txtZahl2
        '
        Me.txtZahl2.Location = New System.Drawing.Point(59, 108)
        Me.txtZahl2.Name = "txtZahl2"
        Me.txtZahl2.Size = New System.Drawing.Size(100, 20)
        Me.txtZahl2.TabIndex = 1
        '
        'lbErgebnis
        '
        Me.lbErgebnis.AutoSize = True
        Me.lbErgebnis.Location = New System.Drawing.Point(61, 157)
        Me.lbErgebnis.Name = "lbErgebnis"
        Me.lbErgebnis.Size = New System.Drawing.Size(0, 13)
        Me.lbErgebnis.TabIndex = 2
        '
        'lbSymbol
        '
        Me.lbSymbol.AutoSize = True
        Me.lbSymbol.Location = New System.Drawing.Point(63, 85)
        Me.lbSymbol.Name = "lbSymbol"
        Me.lbSymbol.Size = New System.Drawing.Size(13, 13)
        Me.lbSymbol.TabIndex = 3
        Me.lbSymbol.Text = "+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 214)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbSymbol)
        Me.Controls.Add(Me.lbErgebnis)
        Me.Controls.Add(Me.txtZahl2)
        Me.Controls.Add(Me.txtZahl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(379, 252)
        Me.MinimumSize = New System.Drawing.Size(379, 252)
        Me.Name = "Form1"
        Me.Text = "Rechner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdDivision As System.Windows.Forms.RadioButton
    Friend WithEvents rdMultiplikation As System.Windows.Forms.RadioButton
    Friend WithEvents rdSubtraktion As System.Windows.Forms.RadioButton
    Friend WithEvents rdAddition As System.Windows.Forms.RadioButton
    Friend WithEvents rdModulo As System.Windows.Forms.RadioButton
    Friend WithEvents txtZahl1 As System.Windows.Forms.TextBox
    Friend WithEvents txtZahl2 As System.Windows.Forms.TextBox
    Friend WithEvents lbErgebnis As System.Windows.Forms.Label
    Friend WithEvents lbSymbol As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
