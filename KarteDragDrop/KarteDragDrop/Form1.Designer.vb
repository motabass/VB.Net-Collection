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
        Me.picKarte = New System.Windows.Forms.PictureBox()
        Me.picOesZiel = New System.Windows.Forms.PictureBox()
        Me.picOesQuelle = New System.Windows.Forms.PictureBox()
        Me.picCzQuelle = New System.Windows.Forms.PictureBox()
        Me.picPolQuelle = New System.Windows.Forms.PictureBox()
        Me.picPolZiel = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picCzZiel = New System.Windows.Forms.PictureBox()
        CType(Me.picKarte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOesZiel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOesQuelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCzQuelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPolQuelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPolZiel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCzZiel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picKarte
        '
        Me.picKarte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picKarte.Image = Global.KarteDragDrop.My.Resources.Resources.karte
        Me.picKarte.Location = New System.Drawing.Point(-1, 0)
        Me.picKarte.Name = "picKarte"
        Me.picKarte.Size = New System.Drawing.Size(891, 665)
        Me.picKarte.TabIndex = 0
        Me.picKarte.TabStop = False
        '
        'picOesZiel
        '
        Me.picOesZiel.Location = New System.Drawing.Point(450, 528)
        Me.picOesZiel.Name = "picOesZiel"
        Me.picOesZiel.Size = New System.Drawing.Size(100, 60)
        Me.picOesZiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOesZiel.TabIndex = 1
        Me.picOesZiel.TabStop = False
        '
        'picOesQuelle
        '
        Me.picOesQuelle.Image = Global.KarteDragDrop.My.Resources.Resources.oesterreich
        Me.picOesQuelle.Location = New System.Drawing.Point(12, 12)
        Me.picOesQuelle.Name = "picOesQuelle"
        Me.picOesQuelle.Size = New System.Drawing.Size(100, 60)
        Me.picOesQuelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOesQuelle.TabIndex = 1
        Me.picOesQuelle.TabStop = False
        '
        'picCzQuelle
        '
        Me.picCzQuelle.Image = Global.KarteDragDrop.My.Resources.Resources.tschechien
        Me.picCzQuelle.Location = New System.Drawing.Point(132, 12)
        Me.picCzQuelle.Name = "picCzQuelle"
        Me.picCzQuelle.Size = New System.Drawing.Size(100, 60)
        Me.picCzQuelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCzQuelle.TabIndex = 1
        Me.picCzQuelle.TabStop = False
        '
        'picPolQuelle
        '
        Me.picPolQuelle.Image = Global.KarteDragDrop.My.Resources.Resources.polen
        Me.picPolQuelle.Location = New System.Drawing.Point(250, 12)
        Me.picPolQuelle.Name = "picPolQuelle"
        Me.picPolQuelle.Size = New System.Drawing.Size(100, 60)
        Me.picPolQuelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPolQuelle.TabIndex = 1
        Me.picPolQuelle.TabStop = False
        '
        'picPolZiel
        '
        Me.picPolZiel.Location = New System.Drawing.Point(653, 159)
        Me.picPolZiel.Name = "picPolZiel"
        Me.picPolZiel.Size = New System.Drawing.Size(100, 60)
        Me.picPolZiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPolZiel.TabIndex = 1
        Me.picPolZiel.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(790, 895)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 60)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'picCzZiel
        '
        Me.picCzZiel.Location = New System.Drawing.Point(472, 379)
        Me.picCzZiel.Name = "picCzZiel"
        Me.picCzZiel.Size = New System.Drawing.Size(100, 60)
        Me.picCzZiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCzZiel.TabIndex = 1
        Me.picCzZiel.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 664)
        Me.Controls.Add(Me.picPolZiel)
        Me.Controls.Add(Me.picPolQuelle)
        Me.Controls.Add(Me.picCzZiel)
        Me.Controls.Add(Me.picCzQuelle)
        Me.Controls.Add(Me.picOesQuelle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picOesZiel)
        Me.Controls.Add(Me.picKarte)
        Me.MaximumSize = New System.Drawing.Size(905, 702)
        Me.MinimumSize = New System.Drawing.Size(905, 702)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picKarte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOesZiel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOesQuelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCzQuelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPolQuelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPolZiel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCzZiel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picKarte As System.Windows.Forms.PictureBox
    Friend WithEvents picOesZiel As System.Windows.Forms.PictureBox
    Friend WithEvents picOesQuelle As System.Windows.Forms.PictureBox
    Friend WithEvents picCzQuelle As System.Windows.Forms.PictureBox
    Friend WithEvents picPolQuelle As System.Windows.Forms.PictureBox
    Friend WithEvents picPolZiel As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCzZiel As System.Windows.Forms.PictureBox

End Class
