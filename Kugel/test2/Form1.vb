
Public Class Form1

    Function volumen(ByVal wertR As Double) As Double
        Dim wertV As Double
        wertV = 4 / 3 * Math.PI * Math.Pow(wertR, 3)
        Return wertV

    End Function
    Function radius(ByVal wertV As Double) As Double
        Dim wertR As Double
        wertR = Math.Pow((wertV * 3 / (4 * Math.PI)), 1 / 3)
        Return wertR

    End Function

    Private Sub cmdEnd_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnd.Click
        Me.Close()
    End Sub

    Private Sub txtR_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtR.KeyUp

        txtV.Text = volumen(Me.txtR.Text)

    End Sub

    Private Sub txtV_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtV.KeyUp

        txtR.Text = radius(Me.txtV.Text)

    End Sub
End Class
