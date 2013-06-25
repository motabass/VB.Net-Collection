Imports System.IO

Public Class Form1
    Public filter As String = "*.mp3"

    Sub showfolder()
        lvFiles.Items.Clear()
        pbShowFolder.Visible = True
        bgwShowFolder.RunWorkerAsync(tvExplorer.SelectedNode.FullPath)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

        For Each Drive In System.Environment.GetLogicalDrives()
            cbLaufwerk.Items.Add(Drive)
            cbLaufwerk.SelectedIndex = 0
        Next
    End Sub

    Private Sub cbLaufwerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLaufwerk.SelectedIndexChanged
        tvExplorer.Nodes.Clear()
        tvExplorer.ShowTree(cbLaufwerk.SelectedItem)
        tvExplorer.TopNode.Expand()
    End Sub

    Private Sub tvExplorer_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvExplorer.AfterSelect
        bgwShowFolder.CancelAsync()
        showfolder()
    End Sub

    Private Sub chbSubFolders_CheckedChanged(sender As Object, e As EventArgs) Handles chbSubFolders.CheckedChanged
        showfolder()
    End Sub

    Private Sub bgwShowFolder_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwShowFolder.DoWork

        Dim dirpfad As String = DirectCast(e.Argument, String)
        Dim zaehler, prozent, anzahl As Integer

        Dim mp3 As Mp3Lib.Mp3File
        Dim infos(7) As String
        Dim item As ListViewItem

        Dim dir As New IO.DirectoryInfo(dirpfad)
        Dim files() As IO.FileInfo

        If chbSubFolders.Checked = True Then
            If bgwShowFolder.CancellationPending = True Then
                e.Cancel = True
                Exit Sub
            End If
            files = dir.GetFiles(filter, IO.SearchOption.AllDirectories)
        Else
            If bgwShowFolder.CancellationPending = True Then
                e.Cancel = True
                Exit Sub
            End If
            files = dir.GetFiles(filter)
        End If

        anzahl = files.Count

        For Each file As IO.FileInfo In files
            If bgwShowFolder.CancellationPending = True Then
                e.Cancel = True
                Exit Sub
            End If
            zaehler += 1
            prozent = zaehler / anzahl * 100
            bgwShowFolder.ReportProgress(prozent)
            Try
                mp3 = New Mp3Lib.Mp3File(file.FullName)


                'Dim row As DataRow = DsMp3.Tables("tblMp3").NewRow()

                'row("Path") = file.FullName

                'DsMp3.Tables("tblMp3").Rows.Add(row)

                infos(0) = file.FullName
                infos(1) = mp3.TagHandler.Title
                infos(2) = mp3.TagHandler.Artist
                infos(3) = mp3.TagHandler.Album
                infos(4) = mp3.TagHandler.Track
                infos(5) = mp3.TagHandler.Year
                infos(6) = TimeOfDay.AddSeconds(mp3.Audio.Duration) - TimeOfDay.TimeOfDay
                infos(7) = mp3.Audio.BitRateMp3 / 1000



                item = New ListViewItem(infos)

                lvFiles.Items.Add(item)
                lvFiles.Refresh()
            Catch : End Try
        Next
    End Sub

    Private Sub bgwShowFolder_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwShowFolder.ProgressChanged
        pbShowFolder.Value = e.ProgressPercentage
    End Sub

    Private Sub bgwShowFolder_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwShowFolder.RunWorkerCompleted
        pbShowFolder.Visible = False
    End Sub

    Private Sub lvFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFiles.SelectedIndexChanged
        If lvFiles.SelectedItems.Count > 0 Then
            If lvFiles.SelectedIndices.Count > 1 Then
                Dim pfad As String
                Dim mp3 As Mp3Lib.Mp3File
                Dim splitpath() As String

                pfad = lvFiles.SelectedItems(0).Text
                mp3 = New Mp3Lib.Mp3File(pfad)


                splitpath = Split(pfad, "\")
                txtPath.Text = ""
                For i = 0 To splitpath.Count - 2
                    txtPath.Text &= splitpath(i) & "\"
                Next


                txtArtist.Enabled = True
                txtTitel.Enabled = True
                txtAlbum.Enabled = True
                txtYear.Enabled = True
                txtTrack.Enabled = True

                txtTitel.Text = mp3.TagHandler.Title
                txtArtist.Text = mp3.TagHandler.Artist
                txtAlbum.Text = mp3.TagHandler.Album
                txtYear.Text = mp3.TagHandler.Year
                txtTrack.Text = mp3.TagHandler.Track
                txtLength.Text = TimeOfDay.AddSeconds(mp3.Audio.Duration) - TimeOfDay.TimeOfDay
                txtBitrate.Text = mp3.Audio.BitRateMp3 / 1000

                For i As Integer = 1 To lvFiles.SelectedItems.Count - 1
                    pfad = lvFiles.SelectedItems(i).Text
                    mp3 = New Mp3Lib.Mp3File(pfad)

                    If mp3.TagHandler.Title <> txtTitel.Text Then
                        txtTitel.Text = "(Unterschidlich)"
                        txtTitel.Enabled = False
                    End If
                    If mp3.TagHandler.Artist <> txtArtist.Text Then
                        txtArtist.Text = "(Unterschidlich)"
                        txtArtist.Enabled = False
                    End If
                    If mp3.TagHandler.Album <> txtAlbum.Text Then
                        txtAlbum.Text = "(Unterschidlich)"
                        txtAlbum.Enabled = False
                    End If
                    If mp3.TagHandler.Year <> txtYear.Text Then
                        txtYear.Text = "(Unterschidlich)"
                        txtYear.Enabled = False
                    End If

                    txtTrack.Text = ""
                    txtTrack.Enabled = False
                    txtLength.Text = ""
                        txtBitrate.Text = ""
                Next
            Else
                Dim pfad As String
                Dim mp3 As Mp3Lib.Mp3File
                pfad = lvFiles.SelectedItems(0).Text
                mp3 = New Mp3Lib.Mp3File(pfad)

                txtArtist.Enabled = True
                txtTitel.Enabled = True
                txtAlbum.Enabled = True
                txtYear.Enabled = True
                txtTrack.Enabled = True

                txtPath.Text = pfad
                txtTitel.Text = mp3.TagHandler.Title
                txtArtist.Text = mp3.TagHandler.Artist
                txtAlbum.Text = mp3.TagHandler.Album
                txtYear.Text = mp3.TagHandler.Year
                txtTrack.Text = mp3.TagHandler.Track
                txtLength.Text = TimeOfDay.AddSeconds(mp3.Audio.Duration) - TimeOfDay.TimeOfDay
                txtBitrate.Text = mp3.Audio.BitRateMp3 / 1000
            End If
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim mp3 As Mp3Lib.Mp3File

        If lvFiles.SelectedItems.Count < 2 Then
            mp3 = New Mp3Lib.Mp3File(lvFiles.SelectedItems(0).Text)

            mp3.TagHandler.Title = txtTitel.Text
            mp3.TagHandler.Artist = txtArtist.Text
            mp3.TagHandler.Album = txtAlbum.Text
            mp3.TagHandler.Year = txtYear.Text
            mp3.TagHandler.Track = txtTrack.Text

            mp3.Update()
        Else
            For Each item As ListViewItem In lvFiles.SelectedItems
                mp3 = New Mp3Lib.Mp3File(item.Text)

                If txtAlbum.Enabled Then
                    mp3.TagHandler.Album = txtAlbum.Text
                End If
                If txtTitel.Enabled Then
                    mp3.TagHandler.Title = txtTitel.Text
                End If
                If txtArtist.Enabled Then
                    mp3.TagHandler.Artist = txtArtist.Text
                End If
                If txtTrack.Enabled Then
                    mp3.TagHandler.Track = txtTrack.Text
                End If
                If txtYear.Enabled Then
                    mp3.TagHandler.Year = txtYear.Text
                End If

                mp3.Update()
            Next
        End If
 
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  
    End Sub
End Class
