Imports System.Drawing
Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3 As Byte
        If star = 0 Then
            gamb = InputBox("Введите своё имя.")
            star += 1
            Button1.Text = "Играть"
        Else
            n1 = Int(Rnd() * 3 + 1)
            n2 = Int(Rnd() * 3 + 1)
            n3 = Int(Rnd() * 3 + 1)
            Select Case n1
                Case Is = 1
                    Label1.Image="C:\Users\User\Pictures\1.png")
            End Select
            pre += 1
            Label4.Text = "Процентное соотношение выигрышей к проигрышам:" & stat(win, pre)
            If n1 = n2 And n2 = n3 And n3 = 1 Then
                Beep()
                win = win + 1
                Label5.Text = "Количество выигрышей:" & win
                Form2.Visible = True
                Me.Visible = False
            End If
            If n1 = n2 And n2 = n3 And n3 = 2 Then
                Beep()
                win = win + 2
                Label5.Text = "Количество выигрышей:" & win
                Form2.Visible = True
                Me.Visible = False
            End If
            If n1 = n2 And n2 = n3 And n3 = 3 Then
                Beep()
                win = win + 3
                Label5.Text = "Количество выигрышей:" & win
                Form2.Visible = True
                Me.Visible = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        res(gamb)
        Me.Close()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        MsgBox("Разработал Егор Неборак", MsgBoxStyle.OkOnly, "О программе")
    End Sub

    Private Sub СтатистикаИгрыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СтатистикаИгрыToolStripMenuItem.Click
        MsgBox("Количество побед: " & win & vbCrLf & "Количество поражений: " & pre - win)
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
