Public Class frmPdv
    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        '                 1234567890123456789012345678901234567890

    End Sub



    Dim Aberto As Boolean = False
    Dim valorTotal As Double = 0
    Dim subtotal As Double = 0
    Dim descontos As Integer = 0
    Private Sub txtCod_Keydown(sender As Object, e As KeyEventArgs) Handles txtCod.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                buscarProdutoPDV(txtCod.Text, Convert.ToDouble(lblQnt.Text))
                txtCod.Clear()
            Case Keys.F8
                pesquisarProduto()
            Case Keys.F5
                erro(e.KeyCode)
            Case Keys.Escape
                If funcionarioAtual._cargo = "Administrador" Then
                    reset()
                End If
                erro(e.KeyCode)
            Case Keys.F3
                erro(e.KeyCode)
            Case Keys.Space
                e.SuppressKeyPress = True
                erro(e.KeyCode)
            Case Keys.F2
                Dim qnt As Double
                If Double.TryParse(txtCod.Text, qnt) Then
                    lblQnt.Text = Convert.ToString(qnt)
                End If
                txtCod.Clear()
        End Select
    End Sub

    Sub reset()
        lstCup.Items.Clear()
        valorTotal = 0
        descontos = 0
        lblPro.Text = "-"
        lblQua.Text = "-"
        lblSubTotal.Text = "-"
        lblDesconto.Text = "-"
        lblPreUnt.Text = "-"
        lblTotal.Text = "-"
        lblQnt.Text = "1"
        If Aberto Then
            divisor()
            lstCup.Items.Add("")
            lstCup.Items.Add("           Mercado do Ricardão           ")
            lstCup.Items.Add("")
            lstCup.Items.Add($"{Now(),40}")
            divisor()
            lstCup.Items.Add($"{"Código",-13}{"Descrição",-18}    Preço")
            lstCup.Items.Add($"{"Quantidade",-6} {"Preço Total",29}")
            divisor()
        End If

    End Sub

    Sub divisor()
        lstCup.Items.Add("----------------------------------------")
    End Sub

    Public Sub adicionarProdutoCupom(dr As MySql.Data.MySqlClient.MySqlDataReader, qnt As Double)
        If Not Aberto Then

            Aberto = True
            reset()
        End If

        '-----------------|Primeira linha adicionada|----------------------------------------------------------------------------'|
        lstCup.Items.Add($"{dr("cod_produto"),-13}{dr("descricao"),-19}{Convert.ToDouble(dr("preco_venda")).ToString("c"),-40}") '|
        '------------------------------------------------------------------------------------------------------------------------'|

        '-----------------|Segunda linha adicionada|----------------------------------------------------'|
        lstCup.Items.Add($"{qnt,-6}    {(Convert.ToDouble(dr("preco_venda")) * qnt).ToString("c"),30}") '|
        '-----------------------------------------------------------------------------------------------'|

        '-----------------|Adicionar ao subtotal|-------------------------------------------'|
        subtotal += Convert.ToDouble(dr("preco_venda")) * qnt                               '|
        '-----------------------------------------------------------------------------------'|

        '-----------------|Scroll down|----------------|
        lstCup.SelectedIndex = lstCup.Items.Count - 1 '|
        lstCup.SelectedIndex = lstCup.Items.Count - 2 '|
        '----------------------------------------------|

        '-----------------|Atualização de tela do PDV|--------------------------------'|
        lblPro.Text = dr("descricao")                                                 '|
        lblQua.Text = qnt.ToString()                                                  '|
        lblSubTotal.Text = subtotal.ToString("c")                                     '|
        lblDesconto.Text = descontos.ToString("c")                                    '|
        lblPreUnt.Text = (Convert.ToDouble(dr("preco_venda")) * qnt).ToString("c")    '|
        lblTotal.Text = (subtotal - descontos).ToString("c")                          '|
        lblQnt.Text = "1"                                                             '|
        '-----------------------------------------------------------------------------'|
    End Sub

    Private Sub frmPdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPdv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Aberto Then
            erro("Não é possível fechar o PDV no momento: Uma venda está aberta")
            e.Cancel = True
        End If
    End Sub
End Class

