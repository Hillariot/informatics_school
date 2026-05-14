Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Form2 As New Form2
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub FailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FailToolStripMenuItem.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim Form2 As New Form2
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Завершить работу программы?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Dim FIO As String
        FIO = InputBox("Введите фамилию, имя и отчество")
        Me.Text = "Сейчас работаем " & FIO
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TheHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TheVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
