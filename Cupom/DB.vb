Imports MySql.Data
Module DB
    'string de conexão
    Dim connStr As String = "server=127.0.0.1;database=sistema;Uid=root;Pwd=OMNI2022;"

    'instância de classe de conexão
    Public conn As MySqlClient.MySqlConnection = New MySqlClient.MySqlConnection(connStr)

    Public cmd As MySqlClient.MySqlCommand = New MySqlClient.MySqlCommand("", conn)

    Public funcionarioAtual As Funcionario

    Function LogIn(cod As String) As Boolean
        cmd.CommandText = String.Format("select * from funcionario where codigo_funcionario = '{0}'", cod)
        Dim dr As MySqlClient.MySqlDataReader
        Dim encontrado As Boolean = False
        Try
            conn.Open()
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr("codigo_funcionario") = "" Then
                cmd.CommandText = ""
                encontrado = False
            Else
                encontrado = True
            End If
        Catch ex As Exception
        End Try

        If Not encontrado Then
            cmd.CommandText = ""
            conn.Close()
            Return False
        Else
            funcionarioAtual = New Funcionario(dr)
            cmd.CommandText = ""
            conn.Close()
            Return True
        End If


        Return False
    End Function

    Function retornarProduto(cod As String, qnt As Double) As Produto
        cmd.CommandText = String.Format("select * from produto_ref where cod_produto = '{0}'", cod)
        Dim dr As MySqlClient.MySqlDataReader
        Try
            conn.Open()
            dr = cmd.ExecuteReader()
            dr.Read()

        Catch ex As Exception

        End Try
    End Function

End Module



