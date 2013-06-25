
Public Class Form1


    Sub color_change()
        If IsNumeric(txtR.Text) = True And IsNumeric(txtG.Text) = True And IsNumeric(txtB.Text) = True And txtR.Text < 256 And txtG.Text < 256 And txtB.Text < 256 Then
            Square.BackColor = Color.FromArgb(255, txtR.Text, txtG.Text, txtB.Text)
        Else
            MsgBox("Falsche Eingabe!" & vbNewLine & "Nur Werte von 0 - 255 erlaubt.", MsgBoxStyle.Critical)

            If txtR.Text > 255 Then
                txtR.Text = 255
            ElseIf txtG.Text > 255 Then
                txtG.Text = 255
            ElseIf txtB.Text > 255 Then
                txtB.Text = 255

            End If
        End If
    End Sub


    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        If IsNumeric(txtHeight.Text) = True Then
            Square.Height = txtHeight.Text
        End If
    End Sub

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
        If IsNumeric(txtWidth.Text) = True Then
            Square.Width = txtWidth.Text
        End If
    End Sub

    Private Sub Square_MouseEnter(sender As Object, e As EventArgs) Handles Square.MouseEnter
        Square.BorderColor = Color.Aquamarine

    End Sub

    Private Sub Square_MouseLeave(sender As Object, e As EventArgs) Handles Square.MouseLeave
        Square.BorderColor = Color.Red

    End Sub

    Private Sub cmdColor_Click(sender As Object, e As EventArgs) Handles cmdColor.Click
       
        Call color_change()



    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHeight.Text = Square.Height
        txtWidth.Text = Square.Width

        txtR.Text = Square.BackColor.R
        txtG.Text = Square.BackColor.G
        txtB.Text = Square.BackColor.B

        tbX.Value = Square.Height
        tbY.Value = Square.Width

    End Sub

    Private Sub tbX_Scroll(sender As Object, e As EventArgs) Handles tbX.Scroll, tbY.Scroll
        txtHeight.Text = tbX.Value
        txtWidth.Text = tbY.Value

    End Sub

    Private Sub txtR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtR.KeyPress, txtB.KeyPress, txtG.KeyPress

        If e.KeyChar = Chr(Keys.Enter) Then
            Call color_change()

        End If

    End Sub

    Private Sub Square_DoubleClick(sender As Object, e As EventArgs) Handles Square.MouseDoubleClick
        Dim rd As New Random


        Square.BackColor = Color.FromArgb(255, rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255))

        txtR.Text = Square.BackColor.R
        txtG.Text = Square.BackColor.G
        txtB.Text = Square.BackColor.B


    End Sub
End Class
