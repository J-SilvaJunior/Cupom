Imports MySql.Data
Module DB
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
    Public descontoMaximo As Double
    Public nomeDaEmpresa As String

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
        conn.Open()
    End Sub 'ok

    Sub fecharBanco()
        conn.Close()
    End Sub 'ok

    Sub erroDB(ex As Exception)
        avisar("Ocorreu um erro ao acessar a base de dados: " + ex.Message)
    End Sub 'ok


    '-----------------------------------------------------------------------
    '                           Sub e Funções do PDV
    '-----------------------------------------------------------------------

    Sub buscarProdutoPDV(cod As String, qnt As Double, indice As Integer)
        cmd.CommandText = $"SELECT * FROM produto_ref WHERE cod_produto = '{preencherVazio(cod)}'"
        Try
            abrirBanco()
            Dim dr As MySqlClient.MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows() Then
                dr.Read()

                cmd.CommandText = $"INSERT INTO venda_atual (indice, cod_prod, qnt, preco_prod, preco_total) values ({indice}, '{dr("cod_produto")}', '{(qnt).ToString.Replace(",", ".")}',{dr("preco_venda")},{(Convert.ToDouble(dr("preco_venda")) * qnt).ToString.Replace(",", ".")})"
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

    Sub removerDoCarrinho(index As Integer)

    End Sub

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
    End Function

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

    End Sub

End Module



