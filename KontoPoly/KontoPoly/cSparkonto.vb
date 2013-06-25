Public Class cSparkonto
    Inherits cKonto

    Private _sperrfrist As Integer

    Public Property Sperrfrist As Integer
        Get
            Return _sperrfrist
        End Get
        Set(value As Integer)
            If value > 0 Then
                _sperrfrist = value
            Else
                _sperrfrist = 0
                MsgBox("Keine Sperrfrist!")
            End If
        End Set
    End Property

    Public Sub New(knummer As String, kstand As Double, sperrfrist As Integer)
        MyBase.New(knummer, kstand)
        _sperrfrist = sperrfrist
    End Sub
    Public Overrides Function drucken() As String
        Return "Kontonummer: " & _knummer & vbNewLine & "Kontostand: " & _kstand & vbNewLine & "Sperrfrist: " & _sperrfrist
    End Function

    Public Overrides Function ToString() As String
        Return "Sparkonto " & _knummer
    End Function
End Class
