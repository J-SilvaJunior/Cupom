Module subRotinas
    '---------------------------------------------------------------------
    '                       Subrotinas customizadas
    '---------------------------------------------------------------------
    Public Sub erro(ex As String)
        Dim aviso As FrmAviso = New FrmAviso(ex)
        aviso.ShowDialog()
        aviso.Dispose()
    End Sub

    Sub pesquisarProduto()
        frmPesquisa.ShowDialog()
    End Sub
    '---------------------------------------------------------------------
    '                       Classe para estruturação
    '---------------------------------------------------------------------

    Class Funcionario
        Private Property _cod_func As String
        Public Property nome As String
        Public Property cargo As String

        Sub New(dr As MySql.Data.MySqlClient.MySqlDataReader)
            Me._cod_func = dr("codigo_funcionario")
            Me.nome = dr("nome")
            Me.cargo = dr("cargo")
        End Sub

        Sub myself()
            MessageBox.Show(_cod_func & " " & nome & " " & cargo)
        End Sub
    End Class
End Module
