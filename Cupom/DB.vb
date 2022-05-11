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
        Try
            conn.Open()
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.IsDBNull(1) Then

                cmd.CommandText = ""
                Return False
            Else
                funcionarioAtual = New Funcionario(dr)
                cmd.CommandText = ""
                Return True
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        conn.Close()
        Return False
    End Function
End Module

Module esquemario

End Module


