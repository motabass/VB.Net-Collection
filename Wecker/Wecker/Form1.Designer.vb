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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdWeckzeit = New System.Windows.Forms.Button()
        Me.cmdRadioURL = New System.Windows.Forms.Button()
        Me.cmdAus = New System.Windows.Forms.Button()
        Me.wmp1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.wmp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.Location = New System.Drawing.Point(29, 25)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(0, 55)
        Me.lbTime.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'cmdWeckzeit
        '
        Me.cmdWeckzeit.Enabled = False
        Me.cmdWeckzeit.Location = New System.Drawing.Point(328, 54)
        Me.cmdWeckzeit.Name = "cmdWeckzeit"
        Me.cmdWeckzeit.Size = New System.Drawing.Size(75, 23)
        Me.cmdWeckzeit.TabIndex = 1
        Me.cmdWeckzeit.Text = "Weckzeit"
        Me.cmdWeckzeit.UseVisualStyleBackColor = True
        '
        'cmdRadioURL
        '
        Me.cmdRadioURL.Location = New System.Drawing.Point(328, 25)
        Me.cmdRadioURL.Name = "cmdRadioURL"
        Me.cmdRadioURL.Size = New System.Drawing.Size(75, 23)
        Me.cmdRadioURL.TabIndex = 1
        Me.cmdRadioURL.Text = "Radiosender"
        Me.cmdRadioURL.UseVisualStyleBackColor = True
        '
        'cmdAus
        '
        Me.cmdAus.BackColor = System.Drawing.Color.LightGray
        Me.cmdAus.Enabled = False
        Me.cmdAus.Location = New System.Drawing.Point(64, 88)
        Me.cmdAus.Name = "cmdAus"
        Me.cmdAus.Size = New System.Drawing.Size(287, 23)
        Me.cmdAus.TabIndex = 2
        Me.cmdAus.Text = "AUS"
        Me.cmdAus.UseVisualStyleBackColor = False
        '
        'wmp1
        '
        Me.wmp1.Enabled = True
        Me.wmp1.Location = New System.Drawing.Point(197, 25)
        Me.wmp1.Name = "wmp1"
        Me.wmp1.OcxState = CType(resources.GetObject("wmp1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp1.Size = New System.Drawing.Size(75, 23)
        Me.wmp1.TabIndex = 3
        Me.wmp1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 300000
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 123)
        Me.Controls.Add(Me.wmp1)
        Me.Controls.Add(Me.cmdAus)
        Me.Controls.Add(Me.cmdRadioURL)
        Me.Controls.Add(Me.cmdWeckzeit)
        Me.Controls.Add(Me.lbTime)
        Me.Name = "Form1"
        Me.Text = "Wecker"
        CType(Me.wmp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdWeckzeit As System.Windows.Forms.Button
    Friend WithEvents cmdRadioURL As System.Windows.Forms.Button
    Friend WithEvents cmdAus As System.Windows.Forms.Button
    Friend WithEvents wmp1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
