Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim meinPunkt As New cPunkt3D(4, 3, 6)

        MsgBox("x " & meinPunkt.X & "; y " & meinPunkt.Y & "; z " & meinPunkt.Z)
    End Sub
End Class
