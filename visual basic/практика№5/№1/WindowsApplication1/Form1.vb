Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "user" AndAlso TextBox2.Text = "123456" Then
            Dim Form2 As New Form2
            Form2.Show()
            Me.Visible = False
        End If
        If TextBox1.Text = "user" AndAlso TextBox2.Text <> "123456" Then
            MsgBox("Неправильно введён пароль.", MsgBoxStyle.OkCancel, "Ошибка")
        End If
        If TextBox1.Text <> "user" AndAlso TextBox2.Text = "123456" Then
            MsgBox("Неправильно введён логин.", MsgBoxStyle.OkCancel, "Ошибка")
        End If
        If TextBox1.Text <> "user" AndAlso TextBox2.Text <> "123456" Then
            MsgBox("Неправильно введён логин и пароль.", MsgBoxStyle.OkCancel, "Ошибка")
        End If
    End Sub
End Class
