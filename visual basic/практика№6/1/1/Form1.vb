Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r1, r2 As String
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            r1 = TextBox1.Text
            r2 = TextBox2.Text
        End If
        For a = i To i
            array1(i) = TextBox1.Text()
            array2(i) = TextBox2.Text()
            i += 1
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2
        For d = 0 To i
            If array2(d) > 4000 And array2(d) < 10000 Then
                Form2.ListBox1.Items.Add(array1(d) & array2(d))
            End If
        Next

        form2.Visible = True
        Me.Visible = False
    End Sub
End Class
