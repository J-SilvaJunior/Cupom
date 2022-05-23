Public Class frmPesquisa
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
        If e.KeyCode = Keys.Enter Then
            ListBox1.Items.Clear()
            buscarProdutoPesquisa(TextBox1.Text)
        End If
    End Sub

    Sub feedBack(dr As MySql.Data.MySqlClient.MySqlDataReader)
        While dr.Read()
            ListBox1.Items.Add($"{preencherVazio(dr("cod_produto")),-14}|{dr("descricao"),-20}|{Convert.ToDouble(dr("preco_venda")).ToString("c"),-10}")
        End While
    End Sub

    Private Sub frmPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

End Class