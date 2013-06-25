Public Class Form1
    Public gedrueckt As Boolean = False
    Public quelle As PictureBox


    Private Sub picOesQuelle_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picOesQuelle.MouseDown, picCzQuelle.MouseDown, picPolQuelle.MouseDown
        gedrueckt = True
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub picOesQuelle_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picOesQuelle.MouseUp, picCzQuelle.MouseUp, picPolQuelle.MouseUp
        gedrueckt = False

    End Sub

    Private Sub picOesQuelle_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picOesQuelle.MouseMove, picCzQuelle.MouseMove, picPolQuelle.MouseMove
        Dim pic1 As PictureBox

        Me.Cursor = Cursors.Hand
        If gedrueckt = True Then
            pic1 = CType(sender, PictureBox)

            gedrueckt = False
            quelle = pic1
            pic1.DoDragDrop(sender.image, DragDropEffects.Move)


        End If
    End Sub

    Private Sub picOesQuelle_MouseEnter(sender As System.Object, e As System.EventArgs) Handles picPolQuelle.MouseEnter, picOesQuelle.MouseEnter, picCzQuelle.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub picOesQuelle_MouseLeave(sender As System.Object, e As System.EventArgs) Handles picPolQuelle.MouseLeave, picOesQuelle.MouseLeave, picCzQuelle.MouseLeave
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        picOesZiel.AllowDrop = True
        picCzZiel.AllowDrop = True
        picPolZiel.AllowDrop = True

    End Sub

    Private Sub picCzZiel_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles picPolZiel.DragEnter, picOesZiel.DragEnter, picCzZiel.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picCzZiel_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles picPolZiel.DragDrop, picOesZiel.DragDrop, picCzZiel.DragDrop
        If Mid(quelle.Name, 1, Len(quelle.Name) - 6) = Mid(sender.name, 1, Len(sender.name) - 4) Then
            sender.image = e.Data.GetData(DataFormats.Bitmap)
            quelle.Visible = False
            sender.allowdrop = False
        End If
       

    End Sub
End Class
