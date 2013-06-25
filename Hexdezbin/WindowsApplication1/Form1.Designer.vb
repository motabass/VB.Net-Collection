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
        Me.Ausgangswert = New System.Windows.Forms.GroupBox()
        Me.rd_BIN = New System.Windows.Forms.RadioButton()
        Me.rd_DEZ = New System.Windows.Forms.RadioButton()
        Me.rd_HEX = New System.Windows.Forms.RadioButton()
        Me.Zielwert = New System.Windows.Forms.GroupBox()
        Me.rd_HEX2 = New System.Windows.Forms.RadioButton()
        Me.rd_BIN2 = New System.Windows.Forms.RadioButton()
        Me.rd_DEZ2 = New System.Windows.Forms.RadioButton()
        Me.bt_START = New System.Windows.Forms.Button()
        Me.bt_ENDE = New System.Windows.Forms.Button()
        Me.box_INOUT = New System.Windows.Forms.TextBox()
        Me.Ausgangswert.SuspendLayout()
        Me.Zielwert.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ausgangswert
        '
        Me.Ausgangswert.Controls.Add(Me.rd_BIN)
        Me.Ausgangswert.Controls.Add(Me.rd_DEZ)
        Me.Ausgangswert.Controls.Add(Me.rd_HEX)
        Me.Ausgangswert.Location = New System.Drawing.Point(58, 186)
        Me.Ausgangswert.Name = "Ausgangswert"
        Me.Ausgangswert.Size = New System.Drawing.Size(200, 100)
        Me.Ausgangswert.TabIndex = 3
        Me.Ausgangswert.TabStop = False
        Me.Ausgangswert.Text = "Ausgangswert"
        '
        'rd_BIN
        '
        Me.rd_BIN.AutoSize = True
        Me.rd_BIN.Location = New System.Drawing.Point(6, 65)
        Me.rd_BIN.Name = "rd_BIN"
        Me.rd_BIN.Size = New System.Drawing.Size(49, 17)
        Me.rd_BIN.TabIndex = 3
        Me.rd_BIN.TabStop = True
        Me.rd_BIN.Text = "Binär"
        Me.rd_BIN.UseVisualStyleBackColor = True
        '
        'rd_DEZ
        '
        Me.rd_DEZ.AutoSize = True
        Me.rd_DEZ.Location = New System.Drawing.Point(6, 19)
        Me.rd_DEZ.Name = "rd_DEZ"
        Me.rd_DEZ.Size = New System.Drawing.Size(62, 17)
        Me.rd_DEZ.TabIndex = 2
        Me.rd_DEZ.TabStop = True
        Me.rd_DEZ.Text = "Dezimal"
        Me.rd_DEZ.UseVisualStyleBackColor = True
        '
        'rd_HEX
        '
        Me.rd_HEX.AutoSize = True
        Me.rd_HEX.Location = New System.Drawing.Point(6, 42)
        Me.rd_HEX.Name = "rd_HEX"
        Me.rd_HEX.Size = New System.Drawing.Size(85, 17)
        Me.rd_HEX.TabIndex = 1
        Me.rd_HEX.TabStop = True
        Me.rd_HEX.Text = "Hexadezimal"
        Me.rd_HEX.UseVisualStyleBackColor = True
        '
        'Zielwert
        '
        Me.Zielwert.Controls.Add(Me.rd_HEX2)
        Me.Zielwert.Controls.Add(Me.rd_BIN2)
        Me.Zielwert.Controls.Add(Me.rd_DEZ2)
        Me.Zielwert.Location = New System.Drawing.Point(429, 186)
        Me.Zielwert.Name = "Zielwert"
        Me.Zielwert.Size = New System.Drawing.Size(200, 100)
        Me.Zielwert.TabIndex = 3
        Me.Zielwert.TabStop = False
        Me.Zielwert.Text = "Zielwert"
        '
        'rd_HEX2
        '
        Me.rd_HEX2.AutoSize = True
        Me.rd_HEX2.Location = New System.Drawing.Point(7, 43)
        Me.rd_HEX2.Name = "rd_HEX2"
        Me.rd_HEX2.Size = New System.Drawing.Size(85, 17)
        Me.rd_HEX2.TabIndex = 2
        Me.rd_HEX2.TabStop = True
        Me.rd_HEX2.Text = "Hexadezimal"
        Me.rd_HEX2.UseVisualStyleBackColor = True
        '
        'rd_BIN2
        '
        Me.rd_BIN2.AutoSize = True
        Me.rd_BIN2.Location = New System.Drawing.Point(7, 66)
        Me.rd_BIN2.Name = "rd_BIN2"
        Me.rd_BIN2.Size = New System.Drawing.Size(49, 17)
        Me.rd_BIN2.TabIndex = 1
        Me.rd_BIN2.TabStop = True
        Me.rd_BIN2.Text = "Binär"
        Me.rd_BIN2.UseVisualStyleBackColor = True
        '
        'rd_DEZ2
        '
        Me.rd_DEZ2.AutoSize = True
        Me.rd_DEZ2.Location = New System.Drawing.Point(7, 20)
        Me.rd_DEZ2.Name = "rd_DEZ2"
        Me.rd_DEZ2.Size = New System.Drawing.Size(62, 17)
        Me.rd_DEZ2.TabIndex = 0
        Me.rd_DEZ2.TabStop = True
        Me.rd_DEZ2.Text = "Dezimal"
        Me.rd_DEZ2.UseVisualStyleBackColor = True
        '
        'bt_START
        '
        Me.bt_START.Location = New System.Drawing.Point(159, 379)
        Me.bt_START.Name = "bt_START"
        Me.bt_START.Size = New System.Drawing.Size(75, 23)
        Me.bt_START.TabIndex = 1
        Me.bt_START.Text = "&Start"
        Me.bt_START.UseVisualStyleBackColor = True
        '
        'bt_ENDE
        '
        Me.bt_ENDE.Location = New System.Drawing.Point(429, 379)
        Me.bt_ENDE.Name = "bt_ENDE"
        Me.bt_ENDE.Size = New System.Drawing.Size(75, 23)
        Me.bt_ENDE.TabIndex = 2
        Me.bt_ENDE.Text = "E&nde"
        Me.bt_ENDE.UseVisualStyleBackColor = True
        '
        'box_INOUT
        '
        Me.box_INOUT.Location = New System.Drawing.Point(58, 130)
        Me.box_INOUT.Name = "box_INOUT"
        Me.box_INOUT.Size = New System.Drawing.Size(463, 20)
        Me.box_INOUT.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 490)
        Me.Controls.Add(Me.box_INOUT)
        Me.Controls.Add(Me.bt_ENDE)
        Me.Controls.Add(Me.bt_START)
        Me.Controls.Add(Me.Zielwert)
        Me.Controls.Add(Me.Ausgangswert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Ausgangswert.ResumeLayout(False)
        Me.Ausgangswert.PerformLayout()
        Me.Zielwert.ResumeLayout(False)
        Me.Zielwert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ausgangswert As System.Windows.Forms.GroupBox
    Friend WithEvents rd_BIN As System.Windows.Forms.RadioButton
    Friend WithEvents rd_DEZ As System.Windows.Forms.RadioButton
    Friend WithEvents rd_HEX As System.Windows.Forms.RadioButton
    Friend WithEvents Zielwert As System.Windows.Forms.GroupBox
    Friend WithEvents rd_HEX2 As System.Windows.Forms.RadioButton
    Friend WithEvents rd_BIN2 As System.Windows.Forms.RadioButton
    Friend WithEvents rd_DEZ2 As System.Windows.Forms.RadioButton
    Friend WithEvents bt_START As System.Windows.Forms.Button
    Friend WithEvents bt_ENDE As System.Windows.Forms.Button
    Friend WithEvents box_INOUT As System.Windows.Forms.TextBox

End Class
