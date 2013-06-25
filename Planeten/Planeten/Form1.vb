
Public Class Form1

    Public beschl As New Collection



    Private Sub cbPlaneten_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbPlaneten.SelectedIndexChanged
        Call berechnen()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        beschl.Add(9.81) : beschl.Add(3.7) : beschl.Add(8.6)
        cbPlaneten.SelectedIndex = 0
        txtMasse.Focus()


    End Sub

    Sub berechnen()
        Dim g As Double, m As Double, erg As Double, pos As Integer, vergl As Double, erde As Double


        pos = cbPlaneten.SelectedIndex + 1

        g = beschl.Item(pos)

        lbG.Text = g

        If txtMasse.Text <> "" Then


            m = txtMasse.Text
            erg = m * g

            erde = m * beschl.Item(1)

            vergl = erg / erde


            lbGewicht.Text = erg & " N"
            If m <> 0 Then
                lbVergleich.Text = Math.Round(vergl, 2) & "x"
            End If

        Else
            MsgBox("Bitte geben Sie eine Masse an")

        End If

      







    End Sub

    Private Sub cbPlaneten_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbPlaneten.KeyPress
        Dim input As String


        If e.KeyChar = Chr(Keys.Enter) Then
            If cbPlaneten.FindStringExact(cbPlaneten.Text) < 0 Then

                input = InputBox("Bitte die Beschleunigung angeben")
                If input <> "" Then
                    cbPlaneten.Items.Add(cbPlaneten.Text)
                    beschl.Add(CDbl(input))
                    cbPlaneten.SelectedIndex = cbPlaneten.Items.Count - 1

                    Call berechnen()

                Else
                    MsgBox("Keine Eingabe")

                End If
            Else
                MsgBox("Eintrag schon Vorhanden")


            End If
        End If
    End Sub

    Private Sub txtMasse_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMasse.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Call berechnen()

        End If
    End Sub
End Class