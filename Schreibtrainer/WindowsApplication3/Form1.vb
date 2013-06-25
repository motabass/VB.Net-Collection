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
        Me.lbText = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbFehler = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbZeit = New System.Windows.Forms.Label()
        Me.lbZeit2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbGratuliere = New System.Windows.Forms.Label()
        Me.cmdAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbText
        '
        Me.lbText.Location = New System.Drawing.Point(41, 27)
        Me.lbText.Name = "lbText"
        Me.lbText.Size = New System.Drawing.Size(661, 88)
        Me.lbText.TabIndex = 0
        Me.lbText.Text = "Dieser Text soll fehlerfrei geschrieben werden."
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(44, 158)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(658, 192)
        Me.txtText.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fehler:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Zeit:"
        '
        'lbFehler
        '
        Me.lbFehler.AutoSize = True
        Me.lbFehler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFehler.Location = New System.Drawing.Point(211, 380)
        Me.lbFehler.Name = "lbFehler"
        Me.lbFehler.Size = New System.Drawing.Size(14, 13)
        Me.lbFehler.TabIndex = 4
        Me.lbFehler.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbZeit
        '
        Me.lbZeit.AutoSize = True
        Me.lbZeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZeit.Location = New System.Drawing.Point(603, 380)
        Me.lbZeit.Name = "lbZeit"
        Me.lbZeit.Size = New System.Drawing.Size(14, 13)
        Me.lbZeit.TabIndex = 5
        Me.lbZeit.Text = "0"
        '
        'lbZeit2
        '
        Me.lbZeit2.AutoSize = True
        Me.lbZeit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZeit2.Location = New System.Drawing.Point(581, 380)
        Me.lbZeit2.Name = "lbZeit2"
        Me.lbZeit2.Size = New System.Drawing.Size(14, 13)
        Me.lbZeit2.TabIndex = 6
        Me.lbZeit2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(594, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ":"
        '
        'lbGratuliere
        '
        Me.lbGratuliere.AutoSize = True
        Me.lbGratuliere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGratuliere.Location = New System.Drawing.Point(246, 380)
        Me.lbGratuliere.Name = "lbGratuliere"
        Me.lbGratuliere.Size = New System.Drawing.Size(0, 13)
        Me.lbGratuliere.TabIndex = 8
        '
        'cmdAgain
        '
        Me.cmdAgain.Location = New System.Drawing.Point(641, 375)
        Me.cmdAgain.Name = "cmdAgain"
        Me.cmdAgain.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgain.TabIndex = 9
        Me.cmdAgain.Text = "Noch Einmal"
        Me.cmdAgain.UseVisualStyleBackColor = True
        Me.cmdAgain.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 417)
        Me.Controls.Add(Me.cmdAgain)
        Me.Controls.Add(Me.lbGratuliere)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbZeit2)
        Me.Controls.Add(Me.lbZeit)
        Me.Controls.Add(Me.lbFehler)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lbText)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(744, 455)
        Me.MinimumSize = New System.Drawing.Size(744, 455)
        Me.Name = "Form1"
        Me.Text = "Schreibtrainer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbText As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbFehler As System.Windows.Forms.Label
    Private Sub txtText_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtText.TextChanged


        If Len(txtText.Text) = 1 Then


        End If



        If Len(txtText.Text) <> 0 Then
            If compare_string(Mid(txtText.Text, Len(txtText.Text), 1), Mid(lbText.Text, Len(txtText.Text), 1)) = False Then
                lbFehler.Text = lbFehler.Text + 1
                Beep()
            End If




        End If



        If Len(txtText.Text) = Len(lbText.Text) And compare_string(Mid(txtText.Text, 1, Len(txtText.Text)), Mid(lbText.Text, 1, Len(txtText.Text))) = True Then
            Timer1.Enabled = False
            txtText.Enabled = False
            cmdAgain.Visible = True
            If lbFehler.Text = 0 Then
                lbGratuliere.Text = "Gratulation! Fehlerfrei."
            End If

        End If

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lbZeit.Text = lbZeit.Text + 1

        If lbZeit.Text = 60 Then
            lbZeit2.Text = lbZeit2.Text + 1
            lbZeit.Text = 0

        End If

    End Sub
    Friend WithEvents lbZeit As System.Windows.Forms.Label
    Friend WithEvents lbZeit2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbGratuliere As System.Windows.Forms.Label

    Private Sub txtText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtText.KeyPress


        ' If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Or compare_string(e.KeyChar, Mid(lbText.Text, Len(txtText.Text) + 1, 1)) = True Then
        'Else
        'lbFehler.Text = lbFehler.Text + 1
        'e.Handled = True
        'End If
        If e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
        Else
            If Len(txtText.Text) > 1 Then
                If compare_string(Mid(txtText.Text, Len(txtText.Text) - 1, 1), Mid(lbText.Text, Len(txtText.Text) - 1, 1)) = False And e.KeyChar = Chr(Keys.Back) Then
                    lbFehler.Text = lbFehler.Text - 1

                End If
            End If
        End If

       

    End Sub
    Friend WithEvents cmdAgain As System.Windows.Forms.Button

    Private Sub cmdAgain_Click(sender As Object, e As EventArgs) Handles cmdAgain.Click
        txtText.Text = ""
        cmdAgain.Visible = False
        lbFehler.Text = 0
        lbZeit.Text = 0
        lbZeit2.Text = 0
        txtText.Enabled = True
        lbGratuliere.Text = ""

    End Sub
    Function compare_string(ByVal str1 As String, ByVal str2 As String) As Boolean

        If str1 = str2 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub txtText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtText.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.Handled = True

        End If
    End Sub
End Class
