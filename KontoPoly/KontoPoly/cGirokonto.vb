Public Class cGirokonto
    Inherits cKonto

    Private _dispo As Double

    Public Property Dispolimit As Double
        Get
            Return _dispo
        End Get
        Set(value As Double)
            _dispo = value
        End Set
    End Property

    Public Sub New(knummer As String, kstand As Double, dispolimit As Double)
        MyBase.New(knummer, kstand)
        _dispo = dispolimit
    End Sub

    Public Overrides Function drucken() As String
        Return "Kontonummer: " & _knummer & vbNewLine & "Kontostand: " & _kstand & vbNewLine & "Dispolimit: " & _dispo
    End Function

    Public Overrides Function ToString() As String
        Return "Girokonto " & _knummer
    End Function
End Class
