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

    Public produtoAtual As Produto
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
    End Function

    Function retornarProduto(cod As String, qnt As Double) As Boolean
        cmd.CommandText = String.Format("select * from produto_ref where cod_produto = '{0}'", cod)
        Dim dr As MySqlClient.MySqlDataReader
        Try
            abrirBanco()
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                dr.Read()
                produtoAtual = New Produto(dr, qnt)
                zerarComando()
                fecharBanco()
                Return True
            End If


        Catch ex As Exception
            erroDB(ex)
            fecharBanco()
            Return False
        End Try
        fecharBanco()
        Return False
    End Function

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
    End Function

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
    End Sub

    Sub zerarComando()
        cmd.CommandText = ""
    End Sub

    Sub abrirBanco()
        conn.Open()
    End Sub

    Sub fecharBanco()
        conn.Close()
    End Sub

    Sub erroDB(ex As Exception)
        erro("Ocorreu um erro ao acessar a base de dados: " + ex.Message)
    End Sub
End Module



