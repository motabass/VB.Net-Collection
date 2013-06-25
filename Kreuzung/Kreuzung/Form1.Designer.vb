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
        Me.cmdAufRot = New System.Windows.Forms.Button()
        Me.timebetween = New System.Windows.Forms.Timer(Me.components)
        Me.timebetween2 = New System.Windows.Forms.Timer(Me.components)
        Me.check = New System.Windows.Forms.Timer(Me.components)
        Me.cmdBlinken = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAufRot
        '
        Me.cmdAufRot.Location = New System.Drawing.Point(120, 534)
        Me.cmdAufRot.Name = "cmdAufRot"
        Me.cmdAufRot.Size = New System.Drawing.Size(75, 23)
        Me.cmdAufRot.TabIndex = 0
        Me.cmdAufRot.Text = "Auf Rot"
        Me.cmdAufRot.UseVisualStyleBackColor = True
        '
        'timebetween
        '
        Me.timebetween.Interval = 2000
        '
        'timebetween2
        '
        Me.timebetween2.Interval = 2000
        '
        'check
        '
        Me.check.Enabled = True
        Me.check.Interval = 1
        '
        'cmdBlinken
        '
        Me.cmdBlinken.Location = New System.Drawing.Point(39, 534)
        Me.cmdBlinken.Name = "cmdBlinken"
        Me.cmdBlinken.Size = New System.Drawing.Size(75, 23)
        Me.cmdBlinken.TabIndex = 0
        Me.cmdBlinken.Text = "Blinken"
        Me.cmdBlinken.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kreuzung.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.Controls.Add(Me.cmdBlinken)
        Me.Controls.Add(Me.cmdAufRot)
        Me.Name = "Form1"
        Me.Text = "Kreuzung"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAufRot As System.Windows.Forms.Button
    Friend WithEvents timebetween As System.Windows.Forms.Timer
    Friend WithEvents timebetween2 As System.Windows.Forms.Timer
    Friend WithEvents check As System.Windows.Forms.Timer
    Friend WithEvents cmdBlinken As System.Windows.Forms.Button

End Class
