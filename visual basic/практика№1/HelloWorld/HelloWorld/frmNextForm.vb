Public Class form2

    Private Sub B_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'создание новой объектной переменной как экземпляр класса frmNextForm
        Dim form3 As New Form3
        'отображение формы
        form3.Show()
        'скрытие формы
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'создание новой объектной переменной как экземпляр класса frmNextForm
        Dim form1 As New form1
        'отображение формы
        form1.Show()
        'скрытие формы
        Me.Hide()
    End Sub

    Private Sub frmNextForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class