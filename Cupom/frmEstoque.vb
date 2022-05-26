Public Class frmEstoque
    Private Sub BtnCdastrarclick(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim Rcod As Int64
        Dim aux As Double
        Dim elegivel As Boolean = True

        If Not Int64.TryParse(txtCod.Text, Rcod) Then
            elegivel = False
        ElseIf Not Double.TryParse(txtCompra.Text, aux) Then
            elegivel = False
        ElseIf Not Double.TryParse(txtVenda.Text, aux) Then
            elegivel = False
        End If

        If elegivel Then
            If cadastrarProduto(preencherVazio(txtCod.Text), txtDesc.Text, txtCompra.Text, txtVenda.Text) Then
                avisar("Produto cadastrado com sucesso!")
            Else
                avisar("Produto alterado com sucesso!")
            End If
            txtCod.Clear()
            txtCompra.Clear()
            txtDesc.Clear()
            txtVenda.Clear()
        Else
            avisar("Verifique os campos digitados e tente novamente")
        End If

    End Sub

    Private Sub BtnpesquisarClick(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        frmPesquisa.ShowDialog()
    End Sub

    Private Sub BtnSairClick(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class