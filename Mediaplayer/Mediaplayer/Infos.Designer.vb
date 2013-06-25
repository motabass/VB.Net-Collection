<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Infos
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
        Me.lbArtist = New System.Windows.Forms.Label()
        Me.lbTitel = New System.Windows.Forms.Label()
        Me.lbAlbum = New System.Windows.Forms.Label()
        Me.lbJahr = New System.Windows.Forms.Label()
        Me.lbTrack = New System.Windows.Forms.Label()
        Me.lbLaenge = New System.Windows.Forms.Label()
        Me.lbBitrate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbBR = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbArtist
        '
        Me.lbArtist.AutoSize = True
        Me.lbArtist.Location = New System.Drawing.Point(79, 89)
        Me.lbArtist.Name = "lbArtist"
        Me.lbArtist.Size = New System.Drawing.Size(39, 13)
        Me.lbArtist.TabIndex = 0
        Me.lbArtist.Text = "Label1"
        '
        'lbTitel
        '
        Me.lbTitel.AutoSize = True
        Me.lbTitel.Location = New System.Drawing.Point(79, 54)
        Me.lbTitel.Name = "lbTitel"
        Me.lbTitel.Size = New System.Drawing.Size(39, 13)
        Me.lbTitel.TabIndex = 1
        Me.lbTitel.Text = "Label2"
        '
        'lbAlbum
        '
        Me.lbAlbum.AutoSize = True
        Me.lbAlbum.Location = New System.Drawing.Point(79, 124)
        Me.lbAlbum.Name = "lbAlbum"
        Me.lbAlbum.Size = New System.Drawing.Size(39, 13)
        Me.lbAlbum.TabIndex = 2
        Me.lbAlbum.Text = "Label3"
        '
        'lbJahr
        '
        Me.lbJahr.AutoSize = True
        Me.lbJahr.Location = New System.Drawing.Point(79, 159)
        Me.lbJahr.Name = "lbJahr"
        Me.lbJahr.Size = New System.Drawing.Size(39, 13)
        Me.lbJahr.TabIndex = 3
        Me.lbJahr.Text = "Label4"
        '
        'lbTrack
        '
        Me.lbTrack.AutoSize = True
        Me.lbTrack.Location = New System.Drawing.Point(79, 19)
        Me.lbTrack.Name = "lbTrack"
        Me.lbTrack.Size = New System.Drawing.Size(39, 13)
        Me.lbTrack.TabIndex = 4
        Me.lbTrack.Text = "Label5"
        '
        'lbLaenge
        '
        Me.lbLaenge.AutoSize = True
        Me.lbLaenge.Location = New System.Drawing.Point(79, 194)
        Me.lbLaenge.Name = "lbLaenge"
        Me.lbLaenge.Size = New System.Drawing.Size(39, 13)
        Me.lbLaenge.TabIndex = 5
        Me.lbLaenge.Text = "Label6"
        '
        'lbBitrate
        '
        Me.lbBitrate.AutoSize = True
        Me.lbBitrate.Location = New System.Drawing.Point(79, 229)
        Me.lbBitrate.Name = "lbBitrate"
        Me.lbBitrate.Size = New System.Drawing.Size(39, 13)
        Me.lbBitrate.TabIndex = 6
        Me.lbBitrate.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artist:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Album"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jahr:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Track:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Länge:"
        '
        'lbBR
        '
        Me.lbBR.AutoSize = True
        Me.lbBR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBR.Location = New System.Drawing.Point(34, 229)
        Me.lbBR.Name = "lbBR"
        Me.lbBR.Size = New System.Drawing.Size(48, 13)
        Me.lbBR.TabIndex = 6
        Me.lbBR.Text = "Bitrate:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbBR)
        Me.Controls.Add(Me.lbBitrate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbLaenge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbTrack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbJahr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbAlbum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTitel)
        Me.Controls.Add(Me.lbArtist)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(0, 300)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Datei-Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbArtist As System.Windows.Forms.Label
    Friend WithEvents lbTitel As System.Windows.Forms.Label
    Friend WithEvents lbAlbum As System.Windows.Forms.Label
    Friend WithEvents lbJahr As System.Windows.Forms.Label
    Friend WithEvents lbTrack As System.Windows.Forms.Label
    Friend WithEvents lbLaenge As System.Windows.Forms.Label
    Friend WithEvents lbBitrate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbBR As System.Windows.Forms.Label
End Class
