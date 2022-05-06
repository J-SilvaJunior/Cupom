Public Class frmArea
    Private Sub frmArea_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub frmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcionarioAtual.myself()
    End Sub
End Class