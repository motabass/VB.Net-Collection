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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(205, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(67, 25)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Kugel"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(16, 137)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(10, 13)
        Me.lblR.TabIndex = 12
        Me.lblR.Text = "r"
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Location = New System.Drawing.Point(16, 91)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(14, 13)
        Me.lblV.TabIndex = 11
        Me.lblV.Text = "V"
        '
        'cmdEnd
        '
        Me.cmdEnd.Location = New System.Drawing.Point(331, 103)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(157, 31)
        Me.cmdEnd.TabIndex = 10
        Me.cmdEnd.Text = "Beenden"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(36, 134)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(191, 20)
        Me.txtR.TabIndex = 9
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(36, 88)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(191, 20)
        Me.txtV.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 181)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.lblV)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txtV)
        Me.Name = "Form1"
        Me.Text = "Markus Mohoritsch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents cmdEnd As System.Windows.Forms.Button
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents txtV As System.Windows.Forms.TextBox

End Class
