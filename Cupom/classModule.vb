Module classModule
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
        Private Property _nome As String
        Public Property _cargo As String

        Sub New(dr As MySql.Data.MySqlClient.MySqlDataReader)
            Me._cod_func = dr("codigo_funcionario")
            Me._nome = dr("nome")
            Me._cargo = dr("cargo")
        End Sub

        Sub myself()
            MessageBox.Show(_cod_func & " " & _nome & " " & _cargo)
        End Sub
    End Class
End Module
