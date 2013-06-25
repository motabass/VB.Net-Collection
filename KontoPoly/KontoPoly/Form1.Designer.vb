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
        Me.lstKonten = New System.Windows.Forms.ListBox()
        Me.cmdGiro = New System.Windows.Forms.Button()
        Me.cmdSpar = New System.Windows.Forms.Button()
        Me.lbInfos = New System.Windows.Forms.Label()
        Me.cmdBuchen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstKonten
        '
        Me.lstKonten.FormattingEnabled = True
        Me.lstKonten.Location = New System.Drawing.Point(13, 13)
        Me.lstKonten.Name = "lstKonten"
        Me.lstKonten.Size = New System.Drawing.Size(290, 212)
        Me.lstKonten.TabIndex = 0
        '
        'cmdGiro
        '
        Me.cmdGiro.Location = New System.Drawing.Point(378, 26)
        Me.cmdGiro.Name = "cmdGiro"
        Me.cmdGiro.Size = New System.Drawing.Size(140, 23)
        Me.cmdGiro.TabIndex = 1
        Me.cmdGiro.Text = "Neues Girokonto"
        Me.cmdGiro.UseVisualStyleBackColor = True
        '
        'cmdSpar
        '
        Me.cmdSpar.Location = New System.Drawing.Point(378, 55)
        Me.cmdSpar.Name = "cmdSpar"
        Me.cmdSpar.Size = New System.Drawing.Size(140, 23)
        Me.cmdSpar.TabIndex = 1
        Me.cmdSpar.Text = "Neues Sparkonto"
        Me.cmdSpar.UseVisualStyleBackColor = True
        '
        'lbInfos
        '
        Me.lbInfos.AutoSize = True
        Me.lbInfos.Location = New System.Drawing.Point(34, 240)
        Me.lbInfos.Name = "lbInfos"
        Me.lbInfos.Size = New System.Drawing.Size(0, 13)
        Me.lbInfos.TabIndex = 2
        '
        'cmdBuchen
        '
        Me.cmdBuchen.Location = New System.Drawing.Point(411, 151)
        Me.cmdBuchen.Name = "cmdBuchen"
        Me.cmdBuchen.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuchen.TabIndex = 3
        Me.cmdBuchen.Text = "Buchen"
        Me.cmdBuchen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 337)
        Me.Controls.Add(Me.cmdBuchen)
        Me.Controls.Add(Me.lbInfos)
        Me.Controls.Add(Me.cmdSpar)
        Me.Controls.Add(Me.cmdGiro)
        Me.Controls.Add(Me.lstKonten)
        Me.Name = "Form1"
        Me.Text = "Konten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstKonten As System.Windows.Forms.ListBox
    Friend WithEvents cmdGiro As System.Windows.Forms.Button
    Friend WithEvents cmdSpar As System.Windows.Forms.Button
    Friend WithEvents lbInfos As System.Windows.Forms.Label
    Friend WithEvents cmdBuchen As System.Windows.Forms.Button

End Class
