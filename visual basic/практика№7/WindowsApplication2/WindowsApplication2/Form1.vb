Imports System.Math
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, t As Double
        x = 0
        x = TextBox1.Text
        Select Case x
            Case Is < 1.4
                Label1.Text = "Y: " & 3.14 * x ^ 2 - 9 * x ^ 2
            Case Is = 1.4
                t = InputBox("Введите число a.")
                Label1.Text = "Y: " & t * x ^ 3 + 17 * Sqrt(x)
            Case Is > 1.4
                t = InputBox("Введите число a.")
                Label1.Text = "Y: " & Log(x + 11 * Sqrt(Abs(x + t)))
        End Select
    End Sub
End Class
