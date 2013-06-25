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
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(12, 32)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(151, 20)
        Me.txtPW.TabIndex = 0
        Me.txtPW.UseSystemPasswordChar = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Location = New System.Drawing.Point(12, 65)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(24, 13)
        Me.lbTime.TabIndex = 1
        Me.lbTime.Text = "15s"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Passwort eingeben:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 87)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.txtPW)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(191, 125)
        Me.MinimumSize = New System.Drawing.Size(191, 125)
        Me.Name = "Form1"
        Me.Text = "Passwort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
