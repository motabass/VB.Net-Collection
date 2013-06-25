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
        Me.txtZahl1 = New System.Windows.Forms.TextBox()
        Me.txtSumme = New System.Windows.Forms.TextBox()
        Me.txtZahl2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad4 = New System.Windows.Forms.RadioButton()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbRichtig = New System.Windows.Forms.Label()
        Me.lbfalsch = New System.Windows.Forms.Label()
        Me.cmdEnde = New System.Windows.Forms.Button()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.cmdNeueZahl = New System.Windows.Forms.Button()
        Me.picSmile = New System.Windows.Forms.PictureBox()
        Me.ToolTipSumme = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.picSmile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtZahl1
        '
        Me.txtZahl1.Enabled = False
        Me.txtZahl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZahl1.Location = New System.Drawing.Point(69, 47)
        Me.txtZahl1.Name = "txtZahl1"
        Me.txtZahl1.Size = New System.Drawing.Size(62, 26)
        Me.txtZahl1.TabIndex = 0
        '
        'txtSumme
        '
        Me.txtSumme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumme.Location = New System.Drawing.Point(69, 128)
        Me.txtSumme.Name = "txtSumme"
        Me.txtSumme.Size = New System.Drawing.Size(62, 26)
        Me.txtSumme.TabIndex = 0
        '
        'txtZahl2
        '
        Me.txtZahl2.Enabled = False
        Me.txtZahl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZahl2.Location = New System.Drawing.Point(69, 79)
        Me.txtZahl2.Name = "txtZahl2"
        Me.txtZahl2.Size = New System.Drawing.Size(62, 26)
        Me.txtZahl2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad4)
        Me.GroupBox1.Controls.Add(Me.rad3)
        Me.GroupBox1.Controls.Add(Me.rad2)
        Me.GroupBox1.Location = New System.Drawing.Point(179, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schwierigkeitsgrad"
        '
        'rad4
        '
        Me.rad4.AutoSize = True
        Me.rad4.Location = New System.Drawing.Point(7, 66)
        Me.rad4.Name = "rad4"
        Me.rad4.Size = New System.Drawing.Size(60, 17)
        Me.rad4.TabIndex = 0
        Me.rad4.TabStop = True
        Me.rad4.Text = "4-stellig"
        Me.rad4.UseVisualStyleBackColor = True
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.Location = New System.Drawing.Point(7, 43)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(60, 17)
        Me.rad3.TabIndex = 0
        Me.rad3.TabStop = True
        Me.rad3.Text = "3-stellig"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.Checked = True
        Me.rad2.Location = New System.Drawing.Point(7, 20)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(60, 17)
        Me.rad2.TabIndex = 0
        Me.rad2.TabStop = True
        Me.rad2.Text = "2-stellig"
        Me.rad2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "+"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(59, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "_____________"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(59, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "_____________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Richtig:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Falsch:"
        '
        'lbRichtig
        '
        Me.lbRichtig.AutoSize = True
        Me.lbRichtig.Location = New System.Drawing.Point(373, 67)
        Me.lbRichtig.Name = "lbRichtig"
        Me.lbRichtig.Size = New System.Drawing.Size(13, 13)
        Me.lbRichtig.TabIndex = 4
        Me.lbRichtig.Text = "0"
        '
        'lbfalsch
        '
        Me.lbfalsch.AutoSize = True
        Me.lbfalsch.Location = New System.Drawing.Point(373, 90)
        Me.lbfalsch.Name = "lbfalsch"
        Me.lbfalsch.Size = New System.Drawing.Size(13, 13)
        Me.lbfalsch.TabIndex = 4
        Me.lbfalsch.Text = "0"
        '
        'cmdEnde
        '
        Me.cmdEnde.Location = New System.Drawing.Point(461, 209)
        Me.cmdEnde.Name = "cmdEnde"
        Me.cmdEnde.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnde.TabIndex = 5
        Me.cmdEnde.Text = "Ende"
        Me.cmdEnde.UseVisualStyleBackColor = True
        '
        'cmdCheck
        '
        Me.cmdCheck.Location = New System.Drawing.Point(131, 209)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(66, 23)
        Me.cmdCheck.TabIndex = 6
        Me.cmdCheck.Text = "Check"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'cmdNeueZahl
        '
        Me.cmdNeueZahl.Location = New System.Drawing.Point(207, 209)
        Me.cmdNeueZahl.Name = "cmdNeueZahl"
        Me.cmdNeueZahl.Size = New System.Drawing.Size(85, 23)
        Me.cmdNeueZahl.TabIndex = 7
        Me.cmdNeueZahl.Text = "Neue Zahlen"
        Me.cmdNeueZahl.UseVisualStyleBackColor = True
        '
        'picSmile
        '
        Me.picSmile.BackgroundImage = Global.WindowsApplication3.My.Resources.Resources.smile
        Me.picSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSmile.Location = New System.Drawing.Point(421, 37)
        Me.picSmile.Name = "picSmile"
        Me.picSmile.Size = New System.Drawing.Size(130, 130)
        Me.picSmile.TabIndex = 9
        Me.picSmile.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 244)
        Me.Controls.Add(Me.picSmile)
        Me.Controls.Add(Me.cmdNeueZahl)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.cmdEnde)
        Me.Controls.Add(Me.lbfalsch)
        Me.Controls.Add(Me.lbRichtig)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtZahl2)
        Me.Controls.Add(Me.txtSumme)
        Me.Controls.Add(Me.txtZahl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(594, 282)
        Me.MinimumSize = New System.Drawing.Size(594, 282)
        Me.Name = "Form1"
        Me.Text = "Additionstrainer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picSmile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtZahl1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSumme As System.Windows.Forms.TextBox
    Friend WithEvents txtZahl2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rad4 As System.Windows.Forms.RadioButton
    Friend WithEvents rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbRichtig As System.Windows.Forms.Label
    Friend WithEvents lbfalsch As System.Windows.Forms.Label
    Friend WithEvents cmdEnde As System.Windows.Forms.Button
    Friend WithEvents cmdCheck As System.Windows.Forms.Button
    Friend WithEvents cmdNeueZahl As System.Windows.Forms.Button
    Friend WithEvents picSmile As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTipSumme As System.Windows.Forms.ToolTip

End Class
