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
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.lbKorrekt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(75, 30)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(193, 20)
        Me.txtISBN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISBN"
        '
        'cmdCheck
        '
        Me.cmdCheck.Location = New System.Drawing.Point(292, 28)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(75, 23)
        Me.cmdCheck.TabIndex = 2
        Me.cmdCheck.Text = "Check"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'lbKorrekt
        '
        Me.lbKorrekt.AutoSize = True
        Me.lbKorrekt.Location = New System.Drawing.Point(142, 53)
        Me.lbKorrekt.Name = "lbKorrekt"
        Me.lbKorrekt.Size = New System.Drawing.Size(0, 13)
        Me.lbKorrekt.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 102)
        Me.Controls.Add(Me.lbKorrekt)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtISBN)
        Me.Name = "Form1"
        Me.Text = "ISBN-Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCheck As System.Windows.Forms.Button
    Friend WithEvents lbKorrekt As System.Windows.Forms.Label

End Class
