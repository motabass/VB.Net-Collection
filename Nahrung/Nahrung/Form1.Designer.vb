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
        Me.lstNahrung = New System.Windows.Forms.ListBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbKkal = New System.Windows.Forms.Label()
        Me.lbJoule = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstNahrung
        '
        Me.lstNahrung.FormattingEnabled = True
        Me.lstNahrung.Location = New System.Drawing.Point(12, 41)
        Me.lstNahrung.Name = "lstNahrung"
        Me.lstNahrung.Size = New System.Drawing.Size(302, 303)
        Me.lstNahrung.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(12, 12)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(352, 73)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(39, 13)
        Me.lbName.TabIndex = 5
        Me.lbName.Text = "Label1"
        '
        'lbKkal
        '
        Me.lbKkal.AutoSize = True
        Me.lbKkal.Location = New System.Drawing.Point(352, 96)
        Me.lbKkal.Name = "lbKkal"
        Me.lbKkal.Size = New System.Drawing.Size(39, 13)
        Me.lbKkal.TabIndex = 5
        Me.lbKkal.Text = "Label1"
        '
        'lbJoule
        '
        Me.lbJoule.AutoSize = True
        Me.lbJoule.Location = New System.Drawing.Point(352, 118)
        Me.lbJoule.Name = "lbJoule"
        Me.lbJoule.Size = New System.Drawing.Size(39, 13)
        Me.lbJoule.TabIndex = 5
        Me.lbJoule.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 480)
        Me.Controls.Add(Me.lbJoule)
        Me.Controls.Add(Me.lbKkal)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstNahrung)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstNahrung As System.Windows.Forms.ListBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbKkal As System.Windows.Forms.Label
    Friend WithEvents lbJoule As System.Windows.Forms.Label

End Class
