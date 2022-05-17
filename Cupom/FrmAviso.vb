Public Class FrmAviso
    Dim erro As String
    Sub New(e As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        erro = e
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmAviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtErro.Text = erro
    End Sub
End Class