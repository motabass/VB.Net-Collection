Public Class Form1

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        lstProdukt.Items.Add("Kiste Gösser")
        lstPreis.Items.Add("13,80")
        Call summe()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        lstProdukt.Items.Add("Wildlachs")
        lstPreis.Items.Add("3,99")
        Call summe()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        lstProdukt.Items.Add("Panettone")
        lstPreis.Items.Add("1,99")
        Call summe()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        lstProdukt.Items.Add("Nudeln")
        lstPreis.Items.Add("1,39")
        Call summe()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        lstProdukt.Items.Add("Himbeer Schokolade")
        lstPreis.Items.Add("1,99")
        Call summe()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        lstProdukt.Items.Add("Orangen Schokolade")
        lstPreis.Items.Add("1,49")
        Call summe()

    End Sub

    Sub summe()
        Dim summe As Integer = 0

        For Each element As String In lstPreis.Items
            summe += element * 100

        Next


        lbSumme.Text = "Summe: " & summe / 100


    End Sub

    Private Sub NeuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        Dim antw As MsgBoxResult


        antw = MsgBox("Wirklich Löschen?", MsgBoxStyle.YesNo)

        If antw = MsgBoxResult.Yes Then
            lstPreis.Items.Clear()
            lstProdukt.Items.Clear()
            Call summe()

        End If
    End Sub


    Sub delselekted()
        Dim i As Integer

        Do While i < lstPreis.Items.Count - 1
            If lstPreis.GetSelected(i) Then
                lstPreis.Items.RemoveAt(i)
                lstProdukt.Items.RemoveAt(i)
            Else
                i += 1
            End If


        Loop
    End Sub

    Private Sub AusgewähltesLöschenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AusgewähltesLöschenToolStripMenuItem.Click
        Call delselekted()

    End Sub

    Private Sub lstProdukt_KeyDown(sender As Object, e As KeyEventArgs) Handles lstProdukt.KeyDown
        If e.KeyValue = Keys.Delete Then
            Call delselekted()

        End If
    End Sub

    Private Sub lstPreis_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPreis.KeyDown
        If e.KeyValue = Keys.Delete Then
            Call delselekted()

        End If
    End Sub

    Private Sub lstProdukt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProdukt.SelectedIndexChanged
        Dim i As Integer

        For i = 0 To lstProdukt.Items.Count - 1
            If lstProdukt.GetSelected(i) Then
                lstPreis.SetSelected(i, True)

            Else
                lstPreis.SetSelected(i, False)


            End If
        Next



    End Sub


    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        End

    End Sub
End Class
