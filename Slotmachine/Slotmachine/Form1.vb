Public Class Form1
    Public counter As Integer

    Sub creditcheck()
        If lbCredit.Text = 0 Then
            lbNocredit.Text = "Kein Credit"
            cmdLoad.Visible = True
            cmdPlay.Enabled = False

        End If
    End Sub

    Private Sub cmdPlay_Click(sender As System.Object, e As System.EventArgs) Handles cmdPlay.Click

        Dim rd As New Random

   
        cmdPlay.Enabled = False
        lbGewinn.Text = ""
        lbCredit.Text = lbCredit.Text - 1
        Me.counter = 1
        txt1.Text = rd.Next(0, 9)
        txt2.Text = rd.Next(0, 9)
        txt3.Text = rd.Next(0, 9)
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
       



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        txt1.Text = txt1.Text + 1
        If txt1.Text > 9 Then
            txt1.Text = 0

        End If
       
       
        Timer1.Interval = Timer1.Interval + 6

      

        


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        txt2.Text = txt2.Text + 1
        If txt2.Text > 9 Then
            txt2.Text = 0

        End If
        Timer2.Interval = Timer2.Interval + 8
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        txt3.Text = txt3.Text + 1
        If txt3.Text > 9 Then
            txt3.Text = 0

        End If
        Timer3.Interval = Timer3.Interval + 10
        Me.counter = Me.counter + 1


        If Me.counter = 28 Then
            Call check()
        End If
    End Sub
    Sub check()
        If txt1.Text = txt2.Text And txt2.Text = txt3.Text Then
            lbGewinn.Text = "Sie haben 3 Gleiche Zahlen. WOW"

            lbCredit.Text = lbCredit.Text + 60
            Timer1.Enabled = False
            Timer1.Interval = 10
            Timer1.Enabled = False
            Timer2.Interval = 10
            Timer2.Enabled = False
            Timer3.Interval = 10
            Timer3.Enabled = False
            cmdPlay.Enabled = True
            creditcheck()


        Else
            If txt1.Text = txt2.Text Or txt1.Text = txt3.Text Or txt2.Text = txt3.Text Then
                lbGewinn.Text = "Sie haben 2 Gleiche Zahlen"
                lbCredit.Text = lbCredit.Text + 2
                Timer1.Interval = 10
                Timer1.Enabled = False
                Timer2.Interval = 10
                Timer2.Enabled = False
                Timer3.Interval = 10
                Timer3.Enabled = False
                cmdPlay.Enabled = True
                creditcheck()

            Else
                lbGewinn.Text = "Leider Nichts"
                Timer1.Interval = 10
                Timer1.Enabled = False
                Timer2.Interval = 10
                Timer2.Enabled = False
                Timer3.Interval = 10
                Timer3.Enabled = False
                cmdPlay.Enabled = True
                creditcheck()

            End If
        End If
    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        lbCredit.Text = 50
        cmdLoad.Visible = False
        lbNocredit.Text = ""
        cmdPlay.Enabled = True


    End Sub

End Class


