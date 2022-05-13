Public Class frmArea
    Private Sub frmArea_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub

    Private Sub frmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image = New Bitmap(optionImg)
        funcionarioAtual.myself()
        If funcionarioAtual._cargo = "Caixa" Then
            btnRelatorio.Visible = False
            btnEstoque.Visible = False
        End If
        If funcionarioAtual._cargo = "Estoquista" Then
            btnPDV.Visible = False
            btnRelatorio.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnPDV_Click(sender As Object, e As EventArgs) Handles btnPDV.Click
        'frmPDV.show()
    End Sub

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        'frmEstoque.show()
    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        'frmRelatorio.show()
    End Sub
End Class