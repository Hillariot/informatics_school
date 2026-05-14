Imports System.Math
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i1 = 1 To 30
            For i2 = 1 To 30
                For i3 = 1 To 30
                    If i1 ^ 2 + i2 ^ 2 = i3 ^ 2 Then
                        ListBox1.Items.Add(i1)
                        ListBox2.Items.Add(i2)
                        ListBox3.Items.Add(i3)
                    End If
                Next
            Next
        Next
    End Sub
End Class
