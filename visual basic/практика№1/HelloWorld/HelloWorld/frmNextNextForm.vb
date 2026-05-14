Public Class frmNextNextForm

    Private Sub frmNextNextForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles form3.Click
        'создание новой объектной переменной как экземпляр класса frmNextForm
        Dim frmNextForm As New form2
        'отображение формы
        frmNextForm.Show()
        'скрытие формы
    End Sub
End Class