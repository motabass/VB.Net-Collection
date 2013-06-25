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
        Me.txtSekunden = New System.Windows.Forms.TextBox()
        Me.cmdUmrechnen = New System.Windows.Forms.Button()
        Me.lbZeit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdJetzt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSekunden
        '
        Me.txtSekunden.Location = New System.Drawing.Point(31, 39)
        Me.txtSekunden.Name = "txtSekunden"
        Me.txtSekunden.Size = New System.Drawing.Size(100, 20)
        Me.txtSekunden.TabIndex = 0
        '
        'cmdUmrechnen
        '
        Me.cmdUmrechnen.Location = New System.Drawing.Point(137, 37)
        Me.cmdUmrechnen.Name = "cmdUmrechnen"
        Me.cmdUmrechnen.Size = New System.Drawing.Size(75, 23)
        Me.cmdUmrechnen.TabIndex = 1
        Me.cmdUmrechnen.Text = "Umrechnen"
        Me.cmdUmrechnen.UseVisualStyleBackColor = True
        '
        'lbZeit
        '
        Me.lbZeit.AutoSize = True
        Me.lbZeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZeit.Location = New System.Drawing.Point(28, 96)
        Me.lbZeit.Name = "lbZeit"
        Me.lbZeit.Size = New System.Drawing.Size(0, 24)
        Me.lbZeit.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sekunden:"
        '
        'cmdJetzt
        '
        Me.cmdJetzt.Location = New System.Drawing.Point(137, 8)
        Me.cmdJetzt.Name = "cmdJetzt"
        Me.cmdJetzt.Size = New System.Drawing.Size(75, 23)
        Me.cmdJetzt.TabIndex = 1
        Me.cmdJetzt.Text = "Jetzt"
        Me.cmdJetzt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 163)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbZeit)
        Me.Controls.Add(Me.cmdJetzt)
        Me.Controls.Add(Me.cmdUmrechnen)
        Me.Controls.Add(Me.txtSekunden)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSekunden As System.Windows.Forms.TextBox
    Friend WithEvents cmdUmrechnen As System.Windows.Forms.Button
    Friend WithEvents lbZeit As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdJetzt As System.Windows.Forms.Button

End Class
