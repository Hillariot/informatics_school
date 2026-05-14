Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'создание новой объектной переменной как экземпляр класса frmNextForm
        Dim form3 As New Form3
        'отображение формы
        Form3.Show()
        'скрытие формы
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class