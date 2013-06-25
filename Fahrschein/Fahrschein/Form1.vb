Public Class Form1
    Public restgeld As Integer, eingeworfen As Integer, preis As Integer


    Private Sub cmdBerechne_Click(sender As Object, e As EventArgs) Handles cmdBerechne.Click
        Dim rd As New Random
        preis = rd.Next(10, 300)
        lbPreis.Text = preis / 10 & " €"
        cmdBerechne.Enabled = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        eingeworfen = eingeworfen + 100
        lbEingeworfen.Text = eingeworfen / 10 & " €"

        Call rest()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        eingeworfen = eingeworfen + 50
        lbEingeworfen.Text = eingeworfen / 10 & " €"

        Call rest()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        eingeworfen = eingeworfen + 20
        lbEingeworfen.Text = eingeworfen / 10 & " €"

        Call rest()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        eingeworfen = eingeworfen + 10
        lbEingeworfen.Text = eingeworfen / 10 & " €"

        Call rest()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        eingeworfen = eingeworfen + 5
        lbEingeworfen.Text = eingeworfen / 10 & " €"

        Call rest()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        eingeworfen = eingeworfen + 1
        lbEingeworfen.Text = eingeworfen / 10 & " €"

        Call rest()
    End Sub

    Sub rest()
        restgeld = preis - eingeworfen
        If restgeld <= 0 Then
            lbRest.Text = 0
            Do While restgeld <= -20
                lbWechsel.Text = lbWechsel.Text & " 2€"
                restgeld = restgeld + 20

            Loop
            Do While restgeld <= -10
                lbWechsel.Text = lbWechsel.Text & " 1€"
                restgeld = restgeld + 10
            Loop
            Do While restgeld <= -5
                lbWechsel.Text = lbWechsel.Text & " 50ct"
                restgeld = restgeld + 5
            Loop
            Do While restgeld <= -1
                lbWechsel.Text = lbWechsel.Text & " 10ct"
                restgeld = restgeld + 1
            Loop

            PictureBox1.Enabled = False
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False

            cmdWechsel.Enabled = True


        Else
            lbRest.Text = restgeld / 10 & " €"
        End If



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdWechsel.Click
        preis = 0
        restgeld = 0
        eingeworfen = 0

        lbPreis.Text = ""
        lbEingeworfen.Text = ""
        lbRest.Text = ""
        lbWechsel.Text = ""

        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True

        cmdBerechne.Enabled = True
    End Sub
End Class
