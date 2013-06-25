Public Class Form1
    Dim brett As New Schachbrett

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        brett.Farbe = Color.Black
        brett.drawfields(PictureBox1, numSpalten.Value, numZeilen.Value)

    End Sub

    Private Sub numZeilen_ValueChanged(sender As Object, e As EventArgs) Handles numZeilen.ValueChanged, numSpalten.ValueChanged
        Try
            brett.drawfields(PictureBox1, numSpalten.Value, numZeilen.Value)

        Catch
        End Try
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Try
            brett.drawfields(PictureBox1, numSpalten.Value, numZeilen.Value)

        Catch
        End Try
    End Sub

    Private Sub cmdFarbe_Click(sender As Object, e As EventArgs) Handles cmdFarbe.Click
        Dim antw As DialogResult

        antw = ColorDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            brett.Farbe = ColorDialog1.Color
            brett.drawfields(PictureBox1, numSpalten.Value, numZeilen.Value)

        End If
    End Sub
End Class
