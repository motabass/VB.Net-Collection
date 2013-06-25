Public Class Termin

    Public BisWann As Date
    Public Bezeichnung As String
    Public Detail As String

    Public Overrides Function ToString() As String
        Return Bezeichnung & " (" & BisWann & ")"
    End Function
End Class