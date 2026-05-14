Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label3.Visible = True
            Label4.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Button2.Visible = True
            Button3.Visible = True
        End If
        If CheckBox1.Checked = False Then
            Label3.Visible = False
            Label4.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button2.Visible = False
            Button3.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex <> -1 Then
            ListBox3.Items.Add(ListBox1.SelectedItem)
            ListBox4.Items.Add(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            ListBox1.Items.Add(TextBox1.Text)
            ListBox2.Items.Add(TextBox2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex <> -1 And ListBox2.SelectedIndex <> -1 Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim upi As Integer
        For Each iop As Integer In ListBox4.Items
            upi += iop
        Next
        Label7.Text = upi
    End Sub

End Class
