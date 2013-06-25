Public Class Form1
    Public WithEvents ampel1 As Ampel
    Public WithEvents ampel2 As Ampel
    Public WithEvents ampel3 As Ampel
    Public WithEvents ampel4 As Ampel
    Public auto1 As Auto
    Public auto2 As Auto
    Public auto3 As Auto
    Public auto4 As Auto

    Private Sub changeofstate(state As Integer) Handles ampel1.StateChange 

        Select Case state
            Case 0
                If ampel3.StateNow = 3 Then
                    ampel3.FarbeGrün = True
                End If
            Case 1
                timebetween.Enabled = True
            Case 2
                If ampel3.StateNow = 0 Or ampel3.StateNow = 3 Then
                    ampel3.UmschaltenRot()
                End If
            Case 3
                ampel3.Blinken()
                ampel2.Blinken()
            Case 4
                If ampel3.StateNow = 1 Or ampel3.StateNow = 3 Then
                    ampel3.UmschaltenGruen()
                End If
        End Select
    End Sub

    Private Sub changeofstate2(state As Integer) Handles ampel2.StateChange
 
        Select Case state
            Case 1
                timebetween2.Enabled = True
            Case 2
                If ampel4.StateNow = 0 Or ampel4.StateNow = 3 Then
                    ampel4.UmschaltenRot()
                End If
            Case 3
                ampel4.Blinken()
            Case 4
                If ampel4.StateNow = 1 Or ampel4.StateNow = 3 Then
                    ampel4.UmschaltenGruen()
                End If
        End Select
    End Sub


    Private Sub tmr_Tick4(sender As Object, e As EventArgs) Handles timebetween.Tick
        timebetween.Enabled = False
        ampel2.UmschaltenGruen()
        ampel2.wait()
    End Sub


    Private Sub tmr_Tick5(sender As Object, e As EventArgs) Handles timebetween2.Tick
        timebetween2.Enabled = False
        ampel1.UmschaltenGruen()
        ampel1.wait()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ampel1 = New Ampel(Me, 100, 460, 40, 40, "r")
        ampel2 = New Ampel(Me, 470, 450, 40, 40, "u")
        ampel3 = New Ampel(Me, 480, 160, 40, 40, "l")
        ampel4 = New Ampel(Me, 180, 100, 40, 40, "d")
        ampel1.FarbeGrün = True
        ampel2.FarbeRot = True
        ampel3.FarbeGrün = True
        ampel4.FarbeRot = True

        auto1 = New Auto(Me, -30, 360, 120, 45, "r")
        auto2 = New Auto(Me, 400, 580, 60, 30, "u")
        auto3 = New Auto(Me, 600, 260, 100, 40, "l")

        auto1.Starten()
        auto1.Geschwindigkeit = 10
        auto2.Starten()
        auto3.Starten()
    End Sub

    Private Sub cmdAufRot_Click(sender As Object, e As EventArgs) Handles cmdAufRot.Click
        ampel1.UmschaltenRot()
    End Sub

    Private Sub check_Tick(sender As Object, e As EventArgs) Handles check.Tick
        If auto1.PosX > ampel1.PosX And auto1.PosX < ampel1.PosX + 30 And (ampel1.StateNow = 1 Or ampel1.StateNow = 4) Then
            auto1.Stoppen()
        Else
            auto1.Starten()
        End If

        If auto2.PosY < ampel2.PosY And auto2.PosY > ampel2.PosY - 30 And (ampel2.StateNow = 1 Or ampel2.StateNow = 4) Then
            auto2.Stoppen()
        Else
            auto2.Starten()
        End If

        If auto3.PosX < ampel3.PosX And auto3.PosX > ampel3.PosX - 30 And (ampel3.StateNow = 1 Or ampel3.StateNow = 4) Then
            auto3.Stoppen()
        Else
            auto3.Starten()
        End If


        If auto1.PosX > Me.Width + 20 Then
            auto1 = New Auto(Me, -30, 360, 120, 45, "r")
            auto1.Geschwindigkeit = 10
            auto1.Starten()
        End If

        If auto2.PosY < -20 Then
            auto2 = New Auto(Me, 400, 580, 60, 30, "u")
            auto2.Starten()
        End If

        If auto3.PosX < -20 Then
            auto3 = New Auto(Me, 600, 260, 100, 40, "l")
            auto3.Starten()
        End If

    End Sub

    Private Sub cmdBlinken_Click(sender As Object, e As EventArgs) Handles cmdBlinken.Click
        ampel1.Blinken()
    End Sub
End Class
