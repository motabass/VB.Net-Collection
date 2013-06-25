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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.lbGewinn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCredit = New System.Windows.Forms.Label()
        Me.lbNocredit = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Cursor = System.Windows.Forms.Cursors.No
        Me.txt1.Enabled = False
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(60, 41)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(38, 47)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Cursor = System.Windows.Forms.Cursors.No
        Me.txt2.Enabled = False
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(108, 41)
        Me.txt2.Name = "txt2"
        Me.txt2.ReadOnly = True
        Me.txt2.Size = New System.Drawing.Size(38, 47)
        Me.txt2.TabIndex = 0
        '
        'txt3
        '
        Me.txt3.Cursor = System.Windows.Forms.Cursors.No
        Me.txt3.Enabled = False
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(157, 41)
        Me.txt3.Name = "txt3"
        Me.txt3.ReadOnly = True
        Me.txt3.Size = New System.Drawing.Size(38, 47)
        Me.txt3.TabIndex = 0
        '
        'cmdPlay
        '
        Me.cmdPlay.Location = New System.Drawing.Point(233, 57)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(101, 28)
        Me.cmdPlay.TabIndex = 1
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'lbGewinn
        '
        Me.lbGewinn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbGewinn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGewinn.Location = New System.Drawing.Point(60, 116)
        Me.lbGewinn.Name = "lbGewinn"
        Me.lbGewinn.Size = New System.Drawing.Size(266, 33)
        Me.lbGewinn.TabIndex = 2
        Me.lbGewinn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Credits:"
        '
        'lbCredit
        '
        Me.lbCredit.AutoSize = True
        Me.lbCredit.Location = New System.Drawing.Point(51, 197)
        Me.lbCredit.Name = "lbCredit"
        Me.lbCredit.Size = New System.Drawing.Size(13, 13)
        Me.lbCredit.TabIndex = 4
        Me.lbCredit.Text = "3"
        '
        'lbNocredit
        '
        Me.lbNocredit.AutoSize = True
        Me.lbNocredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNocredit.Location = New System.Drawing.Point(98, 197)
        Me.lbNocredit.Name = "lbNocredit"
        Me.lbNocredit.Size = New System.Drawing.Size(0, 13)
        Me.lbNocredit.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(233, 192)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(105, 23)
        Me.cmdLoad.TabIndex = 6
        Me.cmdLoad.Text = "Credits Laden"
        Me.cmdLoad.UseVisualStyleBackColor = True
        Me.cmdLoad.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 232)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.lbNocredit)
        Me.Controls.Add(Me.lbCredit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbGewinn)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Einarmiger Bandit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents lbGewinn As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbCredit As System.Windows.Forms.Label
    Friend WithEvents lbNocredit As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
