
Public Class Form1



    Function getdez(ByVal bin As String) As Integer
        Dim i As Integer
        Dim zahl As Integer = 0
        bin = Trim(bin)
        For i = 0 To Len(bin) - 1
            If Mid(bin, Len(bin) - i, 1) = "1" Then
                zahl = zahl + 2 ^ i

            End If
        Next i
        Return zahl
    End Function

    Private Sub bt_ENDE_Click(sender As System.Object, e As System.EventArgs) Handles bt_ENDE.Click
        Close()

    End Sub


    Private Sub konvert()
        Dim zahl As Integer

        If rd_DEZ.Checked = True And rd_DEZ2.Checked = True Then
            'nix
        ElseIf rd_DEZ.Checked = True And rd_HEX2.Checked = True Then
            zahl = Me.box_INOUT.Text
            Me.box_INOUT.Text = Convert.ToString(zahl, 16)

        ElseIf rd_DEZ.Checked = True And rd_BIN2.Checked = True Then
            zahl = Me.box_INOUT.Text
            Me.box_INOUT.Text = Convert.ToString(zahl, 2)
        ElseIf rd_HEX.Checked = True And rd_DEZ2.Checked = True Then
            Me.box_INOUT.Text = Integer.Parse(Me.box_INOUT.Text, Globalization.NumberStyles.HexNumber)
        ElseIf rd_HEX.Checked = True And rd_HEX2.Checked = True Then
            'nix
        ElseIf rd_HEX.Checked = True And rd_BIN2.Checked = True Then
            Me.box_INOUT.Text = Integer.Parse(Me.box_INOUT.Text, Globalization.NumberStyles.HexNumber)
            zahl = Me.box_INOUT.Text
            Me.box_INOUT.Text = Convert.ToString(zahl, 2)
        ElseIf rd_BIN.Checked = True And rd_DEZ2.Checked = True Then

            Me.box_INOUT.Text = getdez(Me.box_INOUT.Text)

        ElseIf rd_BIN.Checked = True And rd_HEX2.Checked = True Then
            Me.box_INOUT.Text = getdez(Me.box_INOUT.Text)

            zahl = Me.box_INOUT.Text
            Me.box_INOUT.Text = Convert.ToString(zahl, 16)

        ElseIf rd_BIN.Checked = True And rd_BIN2.Checked = True Then
            'nix
        End If
    End Sub
    Private Sub bt_START_Click(sender As System.Object, e As System.EventArgs) Handles bt_START.Click
        Call konvert()

    End Sub
    Private Sub box_INOUT_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles box_INOUT.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            Call konvert()
        End If

    End Sub

End Class
