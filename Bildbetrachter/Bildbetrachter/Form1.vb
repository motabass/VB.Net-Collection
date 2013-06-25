Public Class Form1

    Private Sub cmdLoad_Click(sender As System.Object, e As System.EventArgs) Handles cmdLoad.Click
        Dim antw As DialogResult

        antw = OpenFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            For Each element As String In OpenFileDialog1.FileNames
                cbDateien.Items.Add(element)
            Next
            cbDateien.SelectedIndex = 0


        End If
    End Sub

    Private Sub cbDateien_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbDateien.SelectedIndexChanged
        picBild.Image = Image.FromFile(cbDateien.Items(cbDateien.SelectedIndex))

    End Sub

    Private Sub rdOriginal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdOriginal.CheckedChanged, rdProgramm.CheckedChanged

        If rdProgramm.Checked = True Then
            picBild.SizeMode = PictureBoxSizeMode.Zoom
        ElseIf rdOriginal.Checked = True Then
            picBild.SizeMode = PictureBoxSizeMode.AutoSize
        End If

    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click

        If cbDateien.SelectedIndex <> 0 And cbDateien.SelectedIndex <> -1 Then
            cbDateien.SelectedIndex -= 1
        End If


    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If cbDateien.SelectedIndex <> cbDateien.Items.Count - 1 And cbDateien.SelectedIndex <> -1 Then
            cbDateien.SelectedIndex += 1
        End If
    End Sub

End Class
