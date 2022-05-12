Module classModule
    Class Produto
        Private Property _cod_barras As String
        Private Property _descricao As String
        Private Property _qnt_embalagem As Double
        Public Property preco As Double
        Private Property _fornecedor As String

        Sub New(dr As MySql.Data.MySqlClient.MySqlDataReader)
            Me._cod_barras = dr("cod_produto")
            Me._descricao = dr("descricao")
            Me._qnt_embalagem = Double.Parse(dr("qnt_embalagem"))
            Me.preco = Double.Parse(dr("preco"))
            Me._fornecedor = dr("fornecedor")
        End Sub

    End Class

    Class Venda
        Private Property _diamesano As Date
        Private Property _hora As String
        Public Property lista As List(Of Produto)
        Private Property precoTotal As Double
        Public Property cliente As String

        Sub New(cliente As String)
            Me._diamesano = Now.Date
            Me._hora = Now.TimeOfDay.ToString
            Me._precoTotal = 0
            Me._cliente = cliente

        End Sub

        Sub adicionarProduto(prod As Produto)
            Me.precoTotal = Me.precoTotal + prod.preco
            lista.Add(prod)

        End Sub


    End Class

    Class Funcionario
        Private Property _cod_func As String
        Private Property _nome As String
        Private Property _cargo As String

        Sub New(dr As MySql.Data.MySqlClient.MySqlDataReader)
            'dr.Read()
            Me._cod_func = dr("codigo_funcionario")
            Me._nome = dr("nome")
            Me._cargo = dr("cargo")
        End Sub

        Sub myself()
            MessageBox.Show(_cod_func & " " & _nome & " " & _cargo)
        End Sub
    End Class
End Module
