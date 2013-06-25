Public Class Form1
    Public bilder As New Collection

    Sub buttonchange()
        If lstArtikel.SelectedIndex = -1 Then
            cmdAendern.Enabled = False
        Else
            cmdAendern.Enabled = True
        End If

        If lstArtikel.SelectedIndex = -1 Then
            cmdDelete.Enabled = False
        Else
            cmdDelete.Enabled = True
        End If
    End Sub
    Sub add()
        Dim eintrag As String, stueckzahl As String

        If txtArtikel.Text = "" Or txtStueck.Text = "" Then
            MsgBox("Füllen Sie bitte beide Textfelder aus.")
        ElseIf IsNumeric(txtStueck.Text) = False Then
            MsgBox("Bei der Stückzahl sind nur Ziffern erlaubt")
        Else
            If lstArtikel.FindStringExact(txtArtikel.Text) > -1 Then

                lstStueck.Items(lstArtikel.FindStringExact(txtArtikel.Text)) += Val(txtStueck.Text)
            Else
                eintrag = txtArtikel.Text
                stueckzahl = txtStueck.Text

                OpenFileDialog1.ShowDialog()

                bilder.Add(OpenFileDialog1.FileName)

                lstArtikel.Items.Add(eintrag)
                lstStueck.Items.Add(stueckzahl)
            End If




        End If
    End Sub

    Sub addip()
        Dim eintrag As String, stueckzahl As String

        eintrag = InputBox("Artikel eingeben:")

        If eintrag <> "" Then
keinezahl:
            stueckzahl = InputBox("Ganzahlige Stückzahl eingeben:")
            If stueckzahl = "" Then
                Exit Sub
            Else
                If IsNumeric(stueckzahl) = False Then
                    MsgBox("Bitte eine Zahl eingeben")
                    GoTo keinezahl
                Else
                    If lstArtikel.FindStringExact(eintrag) > -1 Then
                        lstStueck.Items(lstArtikel.FindStringExact(txtArtikel.Text)) += Val(stueckzahl)
                    Else
                        OpenFileDialog1.ShowDialog()

                        bilder.Add(OpenFileDialog1.FileName)

                        lstArtikel.Items.Add(eintrag)
                        lstStueck.Items.Add(stueckzahl)
                    End If

                End If
            End If

        Else
            Exit Sub
        End If




    End Sub

    Sub change()
        Dim stueckzahl As String, wert As Integer



noplusminus:
        stueckzahl = InputBox("Änderung der Stückzahl mit vorangestelltem '+' oder '-'" & vbNewLine & "Bitte nur Ganzzahlen eingeben")
        If Mid(stueckzahl, 1, 1) = "+" Then
            wert = Mid(stueckzahl, 2, Len(stueckzahl))

            lstStueck.Items(lstArtikel.SelectedIndex) += wert

        ElseIf Mid(stueckzahl, 1, 1) = "-" Then
            wert = Mid(stueckzahl, 2, Len(stueckzahl))

            lstStueck.Items(lstArtikel.SelectedIndex) -= wert

        Else
            MsgBox("Falsche Eingabe")

            GoTo noplusminus


        End If




    End Sub

    Sub delete()
        Dim i As Integer


        Do While i < lstArtikel.Items.Count
            If lstArtikel.GetSelected(i) Then
                lstArtikel.Items.RemoveAt(i)
                lstStueck.Items.RemoveAt(i)
                bilder.Remove(i + 1)


            Else
                i += 1

            End If

        Loop


    End Sub

    Sub deleteall()
        Dim antw As MsgBoxResult

        antw = MsgBox("Wirklich alles löschen?", MsgBoxStyle.YesNo)

        If antw = MsgBoxResult.Yes Then
            lstArtikel.Items.Clear()
            lstStueck.Items.Clear()
            bilder.Clear()


        End If

    End Sub


    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Call add()
    End Sub

    Private Sub cmdAendern_Click(sender As System.Object, e As System.EventArgs) Handles cmdAendern.Click
        Call change()
    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
        Call delete()
    End Sub


    Private Sub txtArtikel_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtArtikel.KeyPress, txtStueck.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Call add()
        End If
    End Sub

    Private Sub lstArtikel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstArtikel.SelectedIndexChanged
        Dim i As Integer

        lstStueck.ClearSelected()

        For i = 0 To lstArtikel.Items.Count - 1

            If lstArtikel.GetSelected(i) = True Then
                lstStueck.SelectedIndex = i

            End If

        Next

        Call buttonchange()

        If lstArtikel.SelectedItems.Count < 2 And lstArtikel.SelectedItems.Count > 0 Then
            picArtikel.Image = Image.FromFile(bilder.Item(lstArtikel.SelectedIndex + 1))


        End If
    End Sub

    Private Sub LöschenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LöschenToolStripMenuItem.Click
        Call addip()
    End Sub

    Private Sub AllesLöschenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllesLöschenToolStripMenuItem.Click
        Call change()
    End Sub

    Private Sub GewählteLöschenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GewählteLöschenToolStripMenuItem.Click
        Call delete()
    End Sub

    Private Sub AllesLöschenToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AllesLöschenToolStripMenuItem1.Click
        Call deleteall()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles tbStueck.Scroll
        txtStueck.Text = tbStueck.Value
    End Sub

    Private Sub txtStueck_TextChanged(sender As Object, e As EventArgs) Handles txtStueck.TextChanged
        If IsNumeric(txtStueck.Text) Then
            If txtStueck.Text < 1000 Then
                tbStueck.Value = Val(txtStueck.Text)
            End If
        End If
     
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buttonchange()
    End Sub
End Class
