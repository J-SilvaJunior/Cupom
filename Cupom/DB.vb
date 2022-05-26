Imports MySql.Data
Module DB
#Region "Cabeçalho de Declarações"
    '---------------------------------------------------------------------------------------
    '                                 CABEÇALHO DE DECLARAÇÕES
    '---------------------------------------------------------------------------------------
    'string de conexão
    Dim connStr As String = "server=127.0.0.1;database=sistema;Uid=root;Pwd=OMNI2022;"

    'instância de classe de conexão
    Public conn As MySqlClient.MySqlConnection = New MySqlClient.MySqlConnection(connStr)

    Public cmd As MySqlClient.MySqlCommand = New MySqlClient.MySqlCommand("", conn)

    Public funcionarioAtual As Funcionario

    Public caixaAtual As Integer
    Public portaImpressora As String
    Public nomeDaEmpresa As String
#End Region


#Region "Funções de consumo do Banco de Dados"
    '---------------------------------------------------------------------------------------
    '                           Funções de consumo do Banco de dados
    '---------------------------------------------------------------------------------------
    Function LogIn(cod As String) As Boolean
        cmd.CommandText = String.Format("select * from funcionario where codigo_funcionario = '{0}'", cod)
        Dim dr As MySqlClient.MySqlDataReader
        Dim encontrado As Boolean = False
        Try
            abrirBanco()
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr("codigo_funcionario") = "" Then
                zerarComando()
                encontrado = False
            Else
                encontrado = True
            End If
        Catch ex As Exception

        End Try

        If Not encontrado Then
            zerarComando()
            fecharBanco()
            Return False
        Else
            funcionarioAtual = New Funcionario(dr)
            zerarComando()
            fecharBanco()
            Return True
        End If


        Return False
    End Function 'ok

    Function adminTrust(cod As String) As Boolean
        cmd.CommandText = String.Format("select * from funcionario where codigo_funcionario = '{0}'", cod)
        Dim trusted As Boolean = False
        Try
            abrirBanco()
            Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr("cargo") = "Administrador" Then
                    trusted = True
                End If
            End If
        Catch ex As Exception
            avisar(ex.Message)
        Finally
            fecharBanco()
        End Try
        Return trusted
    End Function 'ok

    Function checarDuplicidade(cod As String) As Boolean
        cmd.CommandText = $"select * from funcionario where codigo_funcionario = '{cod}'"
        Dim dr As MySqlClient.MySqlDataReader
        Try
            conn.Open()
            dr = cmd.ExecuteReader()
            zerarComando()
            If dr.HasRows Then
                fecharBanco()
                Return True
            End If

        Catch ex As Exception
            erroDB(ex)
            zerarComando()
            fecharBanco()
            Return False
        End Try
        fecharBanco()
        Return False
    End Function 'ok

    Sub cadastrarUsuario(cod As String, name As String, cargo As String)
        cmd.CommandText = $"insert into funcionario (codigo_funcionario, nome, cargo) values ('{cod}','{name}','{cargo}')"

        Try
            abrirBanco()
            cmd.ExecuteNonQuery()
            fecharBanco()
        Catch ex As Exception
            erroDB(ex)
            fecharBanco()
        End Try
    End Sub 'ok

    Sub zerarComando()
        cmd.CommandText = ""
    End Sub 'ok

    Sub abrirBanco()
        conn.Close()
        conn.Open()
    End Sub 'ok

    Sub fecharBanco()
        conn.Close()
    End Sub 'ok

    Sub erroDB(ex As Exception)
        avisar("Ocorreu um erro ao acessar a base de dados: " + ex.Message)
    End Sub 'ok
#End Region



#Region "Sub e funções do PDV"
    '-----------------------------------------------------------------------
    '                           Sub e Funções do PDV
    '-----------------------------------------------------------------------
    Sub armazenarVenda(VCompra As Double,
                       VDesconto As Double,
                       VTotal As Double,
                       VTroco As Double,
                       FPagamento As Integer)
        Try
            cmd.CommandText = "insert into venda (cod_venda,qnt_itens, valor_total, pagamento, funcionario, data_hora) " &
                             $"values ('{pegarIdVenda()}','{frmPdv.qnt_items}','{VTotal.ToString.Replace(",", ".")}','{FPagamento}','{funcionarioAtual.nome}', now())"
            abrirBanco()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            avisar(ex.Message)
        Finally
            fecharBanco()
            zerarComando()
        End Try
    End Sub
    Sub buscarProdutoPDV(cod As String, qnt As Double, indice As Integer)
        cmd.CommandText = $"SELECT * FROM produto_ref WHERE cod_produto = '{preencherVazio(cod)}'"
        Try
            abrirBanco()
            Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows() Then
                dr.Read()

                cmd.CommandText = $"INSERT INTO venda_atual (indice, cod_prod, qnt, preco_prod, preco_total) values ('{indice}', '{dr("cod_produto")}', '{(qnt).ToString.Replace(",", ".")}','{dr("preco_venda").ToString.Replace(",", ".")}',{(Convert.ToDouble(dr("preco_venda")) * qnt).ToString.Replace(",", ".")})"
                'MessageBox.Show(cmd.CommandText)
                frmPdv.adicionarProdutoCupom(dr, qnt)
                dr.Close()
                cmd.ExecuteNonQuery()
            Else
                avisar("Produto não encontrado.")
            End If

        Catch ex As Exception
            avisar(ex.Message)
        Finally
            zerarComando()
            fecharBanco()
        End Try


    End Sub 'ok

    Function removerDoCarrinho(index As Integer) As Boolean
        Dim encontrado As Boolean = False
        cmd.CommandText = $"select * from venda_atual where indice = {index}"
        Try
            abrirBanco()
            Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader()
            If dr.HasRows() Then
                dr.Read()
                frmPdv.valorProdutoRemovidoTotal = Convert.ToDouble(dr("preco_total"))
                dr.Close()
                cmd.CommandText = $"delete from venda_atual where indice = {index}"
                cmd.ExecuteNonQuery()
                encontrado = True
            Else
                avisar("A linha escolhida não é um item.")
                encontrado = False
            End If


        Catch ex As Exception
            avisar(ex.Message)
        Finally
            zerarComando()
            fecharBanco()
        End Try
        Return encontrado
    End Function 'ok

    Function pegarIdVenda() As Integer
        Dim aux As Integer = 0
        Try

            cmd.CommandText = "select max(cod_venda) from venda"
            abrirBanco()
            Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader()
            If dr.HasRows() Then
                dr.Read()
                aux = dr("max(cod_venda)")
                aux += 1
            End If
        Catch ex As Exception
            avisar(ex.Message)
        End Try
        Return aux

    End Function

    Sub limparRegistroVenda()
        cmd.CommandText = "delete from venda_atual"
        Try
            abrirBanco()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            avisar(ex.Message)
        Finally
            fecharBanco()
            zerarComando()
        End Try
    End Sub 'ok
    '---------------------------------------------------------------------
    '-----------preencher espaço vazio de codigo de produto------------
    '---------------------------------------------------------------------
    Function preencherVazio(cod As String) As String
        Dim aux As String = New String("0", 13 - cod.Length)
        Return (aux + cod)
    End Function 'ok

    Sub buscarProdutoPesquisa(cod As String)
        Dim aux As UInt64
        If UInt64.TryParse(cod, aux) Then
            Try
                cmd.CommandText = $"select cod_produto, descricao, preco_venda from produto_ref where cod_produto = '{preencherVazio(cod)}'"
                abrirBanco()

                Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader()

                If dr.HasRows() Then
                    frmPesquisa.feedBack(dr)
                End If

            Catch ex As Exception
                avisar(ex.Message)
            Finally
                zerarComando()
                fecharBanco()
            End Try
        Else
            Try
                cmd.CommandText = $"select cod_produto, descricao, preco_venda from produto_ref where descricao like '%{cod}%'"
                abrirBanco()
                Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                If dr.HasRows() Then
                    frmPesquisa.feedBack(dr)
                End If
            Catch ex As Exception
                avisar(ex.Message)
            Finally
                zerarComando()
                fecharBanco()
            End Try
        End If

    End Sub 'ok
#End Region

    Public Function UnAccent(ByVal aString As String) As String
        Dim toReplace() As Char = "àèìòùÀÈÌÒÙ äëïöüÄËÏÖÜ âêîôûÂÊÎÔÛ áéíóúÁÉÍÓÚðÐýÝ ãñõÃÑÕšŠžŽçÇåÅøØ".ToCharArray
        Dim replaceChars() As Char = "aeiouAEIOU aeiouAEIOU aeiouAEIOU aeiouAEIOUdDyY anoANOsSzZcCaAoO".ToCharArray
        For index As Integer = 0 To toReplace.GetUpperBound(0)
            aString = aString.Replace(toReplace(index), replaceChars(index))
        Next
        Return aString
    End Function

    Function cadastrarProduto(cod As String, descr As String, compra As String, venda As String) As Boolean
        Dim insercao As Boolean = False
        Try
            abrirBanco()
            cmd.CommandText = $"select * from produto_ref where cod_produto = {preencherVazio(cod)};"
            Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader()
            If dr.HasRows() Then
                dr.Read()
                dr.Close()
                cmd.CommandText = $"update produto_ref set " &
                                  $"cod_produto = '{cod}', " &
                                  $"descricao = '{descr}', " &
                                  $"preco_compra = '{compra.ToString().Replace(",", ".")}', " &
                                  $"preco_venda = '{venda.ToString().Replace(",", ".")}' " &
                                  $"where  cod_produto = '{cod}'"
                cmd.ExecuteNonQuery()
            Else
                dr.Close()
                cmd.CommandText = $"insert into produto_ref " &
                                  $"(cod_produto, descricao, preco_compra, preco_venda) values " &
                                  $"('{cod}','{descr}','{compra.ToString().Replace(",", ".")}','{venda.ToString().Replace(",", ".")}')"
                insercao = True
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            avisar(ex.Message)
        Finally
            fecharBanco()
            zerarComando()
        End Try
        Return insercao
    End Function
End Module



