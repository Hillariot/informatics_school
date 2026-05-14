Imports System.Math
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            Dim a As Integer
            Dim b As Integer
            If RadioButton1.Checked = True Then
                a = TextBox1.Text
                b = TextBox2.Text
                Label4.Text = a + b
            End If
        End If
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            If RadioButton2.Checked = True Then
                Label4.Text = TextBox1.Text - TextBox2.Text
            End If
        End If
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            If RadioButton3.Checked = True Then
                Label4.Text = TextBox1.Text * TextBox2.Text
            End If
        End If
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            Dim a As Integer
            Dim b As Integer
            If RadioButton4.Checked = True Then
                a = TextBox1.Text
                b = TextBox2.Text
                Label4.Text = a / b
            End If
        End If





        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            Dim a As Integer
            Dim b As Integer
            If RadioButton5.Checked = True Then
                a = TextBox1.Text
                b = TextBox2.Text
                Label4.Text = a \ b
            End If
        End If




        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            If RadioButton6.Checked = True Then
                Label4.Text = TextBox1.Text ^ TextBox2.Text
            End If
        End If
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            If RadioButton7.Checked = True Then
                Label4.Text = TextBox1.Text Mod TextBox2.Text
            End If
        End If
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            Dim a As Integer
            Dim b As Integer
            If RadioButton8.Checked = True And TextBox2.Text <> 0 Then
                a = TextBox1.Text
                b = TextBox2.Text
                Label4.Text = a & b
            End If
        End If




        If IsNumeric(TextBox1.Text) Then
            If RadioButton9.Checked = True Then
                Label4.Text = Sqrt(TextBox1.Text)
            End If
        End If

        If IsNumeric(TextBox1.Text) Then
            If RadioButton10.Checked = True Then
                Label4.Text = Sin(TextBox1.Text)
            End If
        End If

        If IsNumeric(TextBox1.Text) Then
            If RadioButton11.Checked = True Then
                Label4.Text = Cos(TextBox1.Text)
            End If
        End If

        If IsNumeric(TextBox1.Text) Then
            If RadioButton12.Checked = True Then
                Label4.Text = Tan(TextBox1.Text)
            End If
        End If


        If IsNumeric(TextBox1.Text) Then
            If RadioButton13.Checked = True Then
                Label4.Text = Log(TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub ВидToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВидToolStripMenuItem.Click

    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click

    End Sub

    Private Sub ОсновныеОперацииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОсновныеОперацииToolStripMenuItem.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub РасширенныеОперацииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РасширенныеОперацииToolStripMenuItem.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub МатематическиеОперацииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МатематическиеОперацииToolStripMenuItem.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
        TextBox2.Visible = False
    End Sub
End Class
