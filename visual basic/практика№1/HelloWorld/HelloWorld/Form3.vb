Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'создание новой объектной переменной как экземпляр класса frmNextForm
        Dim form4 As New Form4
        'отображение формы
        form4.Show()
        'скрытие формы
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'создание новой объектной переменной как экземпляр класса frmNextForm
        Dim form2 As New form2
        'отображение формы
        form2.Show()
        'скрытие формы
        Me.Hide()
    End Sub
End Class