Public Class Form1
    Public bruch1 As New cBruch
    Public bruch2 As New cBruch

    Private Sub cmdBruch_Click(sender As System.Object, e As System.EventArgs) Handles cmdBruch.Click

        bruch1.Zähler = InputBox("Zähler:")
        bruch1.Nenner = InputBox("Nenner:")

        darstellen()
    End Sub

    Private Sub darstellen()
        lbBruch.Text = bruch1.Zähler & "/" & bruch1.Nenner
        lbWert.Text = bruch1.getWert

        lbBruch2.Text = bruch2.Zähler & "/" & bruch2.Nenner
        lbWert2.Text = bruch2.getWert
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        darstellen()
    End Sub

    Private Sub cmdBruch2_Click(sender As System.Object, e As System.EventArgs) Handles cmdBruch2.Click

        bruch2.Zähler = InputBox("Zähler:")
        bruch2.Nenner = InputBox("Nenner:")

        darstellen()
    End Sub

    Private Sub cmdKurz1_Click(sender As Object, e As EventArgs) Handles cmdKurz1.Click
        bruch1.kuerzen()
        darstellen()
    End Sub

    Private Sub cmdKurz2_Click(sender As Object, e As EventArgs) Handles cmdKurz2.Click
        bruch2.kuerzen()
        darstellen()
    End Sub

    Private Sub cmdAddieren_Click(sender As Object, e As EventArgs) Handles cmdAddieren.Click
        bruch1.addiere(InputBox("Zähler:"), InputBox("Nenner:"))
        darstellen()
    End Sub

    Private Sub cmdMulti_Click(sender As Object, e As EventArgs) Handles cmdMulti.Click
        bruch2.multipliziere(InputBox("Zähler:"), InputBox("Nenner:"))
        darstellen()
    End Sub
End Class
