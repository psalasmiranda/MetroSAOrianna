Public Class Form1
    'Menú de espera
  
    Private Sub L4AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L4AToolStripMenuItem.Click
        Dim frm As New Form5()
        frm.Show()
    End Sub

    Private Sub L5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L5ToolStripMenuItem.Click
        Dim frm As New Form2()
        frm.Show()
    End Sub

    Private Sub L4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L4ToolStripMenuItem.Click
        Dim frm As New Form3()
        frm.Show()
    End Sub

    Private Sub L2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L2ToolStripMenuItem.Click
        Dim frm As New Form4()
        frm.Show()
    End Sub

    Private Sub GenerarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarToolStripMenuItem.Click
        Dim frm As New Form6()
        frm.Show()
    End Sub
End Class
