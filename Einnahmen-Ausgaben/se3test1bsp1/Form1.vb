Public Class Form1
    Sub add()
        Dim eingabe As String

fehler:

        eingabe = InputBox("Bitte Ein- bzw. Ausgabe eingeben.", "Eingabe/Ausgabe")
 

        If IsNumeric(eingabe) = True Then
                lstEinAus.Items.Add(eingabe)
        Else
            If eingabe = "" Then
                GoTo ende
            Else
                MsgBox("Sie haben keine Zahl eingegeben!" & vbNewLine & "Bitte noch einmal.", MsgBoxStyle.Critical, "Keine Zahl")
                GoTo fehler
            End If


            End If

ende:

        Call summe()


    End Sub

    Sub summe()
        Dim summe As Integer = 0

        For Each element As String In lstEinAus.Items
            summe += element * 100

        Next

        lbSumme.Text = "Die Summe beträgt: " & summe / 100 & "€"

        If summe > 0 Then
            picSmily.Image = My.Resources.good
        ElseIf summe = 0 Then
            picSmily.Image = My.Resources.neutral
        Else
            picSmily.Image = My.Resources.bad
        End If

    End Sub

    Sub delete()
        Dim i As Integer

        Do While i < lstEinAus.Items.Count
            If lstEinAus.GetSelected(i) = True Then
                lstEinAus.Items.RemoveAt(i)

            Else
                i += 1
            End If

        Loop
        Call summe()

    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Call add()

    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
        Call delete()

    End Sub

    Private Sub ElementHinzufügenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ElementHinzufügenToolStripMenuItem.Click
        Call add()

    End Sub

    Private Sub AusgewählteLöschenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AusgewählteLöschenToolStripMenuItem.Click
        Call delete()

    End Sub
End Class
