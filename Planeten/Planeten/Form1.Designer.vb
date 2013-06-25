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
        Me.cbPlaneten = New System.Windows.Forms.ComboBox()
        Me.txtMasse = New System.Windows.Forms.TextBox()
        Me.lbGewicht = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbG = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbVergleich = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbPlaneten
        '
        Me.cbPlaneten.Items.AddRange(New Object() {"Erde", "Mars", "Venus"})
        Me.cbPlaneten.Location = New System.Drawing.Point(110, 70)
        Me.cbPlaneten.MaxDropDownItems = 9
        Me.cbPlaneten.Name = "cbPlaneten"
        Me.cbPlaneten.Size = New System.Drawing.Size(121, 21)
        Me.cbPlaneten.TabIndex = 0
        '
        'txtMasse
        '
        Me.txtMasse.Location = New System.Drawing.Point(110, 107)
        Me.txtMasse.Name = "txtMasse"
        Me.txtMasse.Size = New System.Drawing.Size(100, 20)
        Me.txtMasse.TabIndex = 1
        Me.txtMasse.Text = "0"
        '
        'lbGewicht
        '
        Me.lbGewicht.AutoSize = True
        Me.lbGewicht.Location = New System.Drawing.Point(107, 155)
        Me.lbGewicht.Name = "lbGewicht"
        Me.lbGewicht.Size = New System.Drawing.Size(0, 13)
        Me.lbGewicht.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gewicht auf den Planeten"
        '
        'lbG
        '
        Me.lbG.AutoSize = True
        Me.lbG.Location = New System.Drawing.Point(367, 73)
        Me.lbG.Name = "lbG"
        Me.lbG.Size = New System.Drawing.Size(0, 13)
        Me.lbG.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Masse in kg:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Planet:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Beschleunigung in m/s:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kraft:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vergleich zur Erde:"
        '
        'lbVergleich
        '
        Me.lbVergleich.AutoSize = True
        Me.lbVergleich.Location = New System.Drawing.Point(107, 184)
        Me.lbVergleich.Name = "lbVergleich"
        Me.lbVergleich.Size = New System.Drawing.Size(0, 13)
        Me.lbVergleich.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 222)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbVergleich)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbGewicht)
        Me.Controls.Add(Me.txtMasse)
        Me.Controls.Add(Me.cbPlaneten)
        Me.Name = "Form1"
        Me.Text = "Planeten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPlaneten As System.Windows.Forms.ComboBox
    Friend WithEvents txtMasse As System.Windows.Forms.TextBox
    Friend WithEvents lbGewicht As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbG As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbVergleich As System.Windows.Forms.Label

End Class
