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
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.chkCheck = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pic1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(39, 21)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(100, 20)
        Me.txtCheck.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCheck, "Hier wird deine Auswahl angezeigt")
        '
        'chkCheck
        '
        Me.chkCheck.AutoSize = True
        Me.chkCheck.Location = New System.Drawing.Point(146, 23)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(15, 14)
        Me.chkCheck.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.chkCheck, "Ja oder Nein")
        Me.chkCheck.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 20000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'pic1
        '
        Me.pic1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic1.Image = Global.WindowsApplication4.My.Resources.Resources.picture1
        Me.pic1.Location = New System.Drawing.Point(39, 82)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(557, 320)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 2
        Me.pic1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic1, "Ein Bild")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 417)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.chkCheck)
        Me.Controls.Add(Me.txtCheck)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents chkCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox

End Class
