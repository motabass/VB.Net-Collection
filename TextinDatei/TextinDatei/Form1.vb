Imports System.IO


Public Class Form1
    Sub intext()
        Dim writetext As StreamWriter
        Dim textstring As String

        writetext = New StreamWriter("C:/text.txt")

        textstring = InputBox("Bitte Text")

        writetext.WriteLine(textstring & vbNewLine, True)

        writetext.Close()



    End Sub
 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call intext()

    End Sub
End Class
