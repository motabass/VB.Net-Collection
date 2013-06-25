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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Square = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdColor = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbX = New System.Windows.Forms.TrackBar()
        Me.tbY = New System.Windows.Forms.TrackBar()
        CType(Me.tbX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Square})
        Me.ShapeContainer1.Size = New System.Drawing.Size(658, 613)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Square
        '
        Me.Square.BackColor = System.Drawing.Color.Black
        Me.Square.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Square.BorderColor = System.Drawing.Color.Red
        Me.Square.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Square.BorderWidth = 10
        Me.Square.Location = New System.Drawing.Point(57, 150)
        Me.Square.Name = "Square"
        Me.Square.Size = New System.Drawing.Size(130, 130)
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(70, 41)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 1
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(70, 86)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 2
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(356, 37)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(100, 20)
        Me.txtR.TabIndex = 3
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(356, 63)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(100, 20)
        Me.txtG.TabIndex = 3
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(356, 89)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Colour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "x"
        '
        'cmdColor
        '
        Me.cmdColor.Location = New System.Drawing.Point(476, 63)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(75, 23)
        Me.cmdColor.TabIndex = 6
        Me.cmdColor.Text = "Change"
        Me.cmdColor.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "R"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "G"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "B"
        '
        'tbX
        '
        Me.tbX.Location = New System.Drawing.Point(176, 38)
        Me.tbX.Maximum = 400
        Me.tbX.Minimum = 20
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(104, 45)
        Me.tbX.TabIndex = 8
        Me.tbX.Value = 20
        '
        'tbY
        '
        Me.tbY.Location = New System.Drawing.Point(176, 86)
        Me.tbY.Maximum = 550
        Me.tbY.Minimum = 20
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(104, 45)
        Me.tbY.TabIndex = 8
        Me.tbY.Value = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 613)
        Me.Controls.Add(Me.tbY)
        Me.Controls.Add(Me.tbX)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Ereignisse"
        CType(Me.tbX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Square As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents txtG As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdColor As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbX As System.Windows.Forms.TrackBar
    Friend WithEvents tbY As System.Windows.Forms.TrackBar

End Class
