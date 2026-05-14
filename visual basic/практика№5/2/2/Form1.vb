Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case Is = "Германия"
                Label3.Text = "Германия"
                Label4.Text = "Hallo"
            Case Is = "Англия"
                Label3.Text = "Англия"
                Label4.Text = "Hello"
            Case Is = "Россия"
                Label3.Text = "Россия"
                Label4.Text = "Привет"
            Case Is = "Япония"
                Label3.Text = "Япония"
                Label4.Text = "Aisatsu"
        End Select
    End Sub
End Class
