Public Class Form1

    Private Sub СоздаьФормуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоздаьФормуToolStripMenuItem.Click
        Dim Form2 As New Form2
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub КаскадToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КаскадToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub ГоризонтальноToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ГоризонтальноToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ВертикальноToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВертикальноToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
