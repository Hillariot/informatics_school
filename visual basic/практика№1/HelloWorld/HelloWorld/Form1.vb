Public Class form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHelloWorld.Click

    End Sub

    Private Sub btnShowForm_Click(sender As Object, e As EventArgs) Handles btnShowForm.Click
        'создание новой объектной переменной как экземпляр класса frmNextForm
        Dim form2 As New form2
        'отображение формы
        form2.Show()
        'скрытие формы
        Me.Hide()
    End Sub

    Private Sub frmHelloWorld_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
