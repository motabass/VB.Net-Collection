Public Class Form1
    Public changecheck As Boolean = False
    Sub delete()
        Dim pos As Integer = lstTermine.SelectedIndex
        Dim elements As Integer = lstTermine.Items.Count

        If pos > -1 Then
            lstTermine.Items.RemoveAt(pos)
            lbBisWann.Text = ""
            lbDetail.Text = ""
            If lstTermine.Items.Count > 0 Then
                If pos = elements - 1 Then
                    lstTermine.SetSelected(pos - 1, True)
                Else
                    lstTermine.SetSelected(pos, True)
                End If
            End If
        End If
    End Sub

    Sub change()
        Dim eintrag As New Termin
        changecheck = True
        If lstTermine.SelectedIndex > -1 Then
            eintrag = lstTermine.Items(lstTermine.SelectedIndex)
            With My.Forms.Change
                .txtName.Text = eintrag.Bezeichnung
                .txtTime.Text = eintrag.BisWann
                .txtDetail.Text = eintrag.Detail
                .Text = "Bearbeiten"
                .ShowDialog()
            End With
            changecheck = False
        End If
    End Sub

    Private Sub cmdNeu_Click(sender As System.Object, e As System.EventArgs) Handles cmdNeu.Click
        changecheck = False
        With My.Forms.Change
            .Text = "Neu"
            .ShowDialog()
        End With
    End Sub

    Private Sub lstTermine_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstTermine.SelectedIndexChanged
        Dim gewaehlter As New Termin


        If lstTermine.SelectedItems.Count > 0 Then
            gewaehlter = lstTermine.SelectedItem

            lbBisWann.Text = gewaehlter.BisWann
            lbDetail.Text = gewaehlter.Detail


        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub lbBisWann_Click(sender As System.Object, e As System.EventArgs) Handles lbBisWann.Click

    End Sub


    Private Sub cmdChange_Click(sender As System.Object, e As System.EventArgs) Handles cmdChange.Click
        Call change()
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        Call delete()
    End Sub

    Private Sub NeuToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NeuToolStripButton.Click
        If lstTermine.Items.Count > 0 Then
            Dim antwort As MsgBoxResult

            antwort = MsgBox("Sicher alles Löschen?", MsgBoxStyle.YesNo)
            If antwort = MsgBoxResult.Yes Then
                lstTermine.Items.Clear()
            End If
        Else
            MsgBox("Eine leere liste kann nicht gelöscht werden!")
        End If
    End Sub

    Private Sub SpeichernToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SpeichernToolStripButton.Click
        If lstTermine.Items.Count > 0 Then
            Dim antw As DialogResult
            Dim datei As System.IO.FileInfo
            Dim sw As System.IO.StreamWriter
            Dim termin As New Termin

            antw = SaveFileDialog1.ShowDialog

            If antw = Windows.Forms.DialogResult.OK Then
                datei = New System.IO.FileInfo(SaveFileDialog1.FileName)
                sw = datei.CreateText

                For Each element As Termin In lstTermine.Items
                    termin = element

                    sw.WriteLine(termin.Bezeichnung & vbNewLine & termin.BisWann & vbNewLine & termin.Detail & vbNewLine & "\\")

                Next

                sw.Close()
            End If
        Else
            MsgBox("Eine leere Liste kann nicht gespeichert werden!")
        End If
    End Sub

    Private Sub ÖffnenToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ÖffnenToolStripButton.Click
        Dim antw As DialogResult
        Dim datei As System.IO.FileInfo
        Dim sr As System.IO.StreamReader
        Dim gelZeile As String
        Dim termin As Termin
        Dim detail As String = ""


        antw = OpenFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            lstTermine.Items.Clear()
            datei = New System.IO.FileInfo(OpenFileDialog1.FileName)
            sr = datei.OpenText

            Do
                termin = New Termin
                termin.Bezeichnung = sr.ReadLine
                termin.BisWann = sr.ReadLine
nextline:
                gelZeile = sr.ReadLine
                If gelZeile <> "\\" Then
                    detail &= gelZeile & vbNewLine
                    GoTo nextline
                End If

                termin.Detail = Mid(detail, 1, Len(detail) - 2)
                detail = ""
                lstTermine.Items.Add(termin)
            Loop While Not sr.EndOfStream
            sr.Close()

        End If
    End Sub

    Private Sub lstTermine_DoubleClick(sender As Object, e As EventArgs) Handles lstTermine.DoubleClick
        Call change()
    End Sub


    Private Sub lstTermine_KeyDown(sender As Object, e As KeyEventArgs) Handles lstTermine.KeyDown
        If e.KeyValue = Keys.Delete Then
            Call delete()
        End If
    End Sub
End Class