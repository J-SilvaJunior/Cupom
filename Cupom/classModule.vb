Module classModule
    Class Produto
        Private Property _cod_barras As String
        Private Property _descricao As String
        Private Property _qnt_embalagem As Double
        Private Property _preco As Double
        Private Property _fornecedor As String

        Sub New(dr As MySql.Data.MySqlClient.MySqlDataReader)
            Me._cod_barras = dr("cod_produto")
            Me._descricao = dr("descricao")
            Me._qnt_embalagem = Double.Parse(dr("qnt_embalagem"))
            Me._preco = Double.Parse(dr("preco"))
            Me._fornecedor = dr("fornecedor")
        End Sub

    End Class

    Class Venda
        Private Property _diamesano As Date
        Private Property _hora As String
        Public Property lista As List(Of Produto)
        Public Property precoTotal As Double
        Public Property cliente As String

        Sub New()
            Me._diamesano = Now.Date
            Me._hora = Now.TimeOfDay.ToString

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
