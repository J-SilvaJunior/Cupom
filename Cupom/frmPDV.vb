Imports System.IO
Public Class frmPdv
    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        '                 1234567890123456789012345678901234567890

    End Sub


    Public trust As Boolean = False
    Dim Aberto As Boolean = False
    Dim valorTotal As Double = 0
    Dim subtotal As Double = 0
    Public descontos As Integer = 0
    Dim indiceAtual As Integer = 9
    Public qnt_items As Integer = 0
    Public valorProdutoRemovidoTotal As Double
    Public finalizado As Boolean = False
    Private Sub txtCod_Keydown(sender As Object, e As KeyEventArgs) Handles txtCod.KeyDown
        Select Case e.KeyCode
            '-----------------------------------------------------------------------------'|
            Case Keys.Enter                                                               '|
                buscarProdutoPDV(txtCod.Text, Convert.ToDouble(lblQnt.Text), indiceAtual) '|
                txtCod.Clear()                                                            '|
            '-----------------------------------------------------------------------------'|
            '-----------------------'|
            Case Keys.F8            '|
                pesquisarProduto()  '|
            '-----------------------'|
            '-----------------------------------------------------------'|
            Case Keys.F5                                                '|
                If Aberto Then
                    lstCup.Focus()
                    txtCod.Enabled = False
                    lblInstrucao.Visible = True
                End If


            '-----------------------------------------------------------'|
            '-------------------------------------------------------'|
            Case Keys.Escape                                        '|
                If funcionarioAtual.cargo = "Administrador" Then    '|
                    Aberto = False                                  '|
                    reset()                                         '|
                    limparRegistroVenda()                           '|
                Else                                                '|
                    frmConfirmar.ShowDialog()                       '|
                    If trust = True Then                            '|
                        trust = False                               '|
                        Aberto = False                              '|
                        reset()                                     '|
                        limparRegistroVenda()                       '|
                        avisar("Código de administrador inserido")  '|
                    End If                                          '|
                End If                                              '|
                indiceAtual = 9                                     '|
                '---------------------------------------------------'|
            '-------------------------------------------------------'|
            Case Keys.F3                                            '|
                If funcionarioAtual.cargo = "Administrador" Then    '|
                    frmDesconto.ShowDialog()                        '|
                Else                                                '|
                    frmConfirmar.ShowDialog()                       '|
                    If trust Then                                   '|
                        trust = False                               '|
                        frmDesconto.ShowDialog()                    '|
                        lblDesconto.Text = descontos                '|
                    Else                                            '|
                        avisar("Código Incorreto.")                 '|
                    End If                                          '|
                End If                                              '|
                '---------------------------------------------------'|
            Case Keys.Space
                finalizarVenda()
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
        subtotal = 0
        lblPro.Text = "-"
        lblQua.Text = "-"
        lblSubTotal.Text = "-"
        lblDesconto.Text = "-"
        lblPreUnt.Text = "-"
        lblTotal.Text = "-"
        lblQnt.Text = "1"
        txtCod.Enabled = True


        If Aberto Then
            divisor()
            lstCup.Items.Add("")
            lstCup.Items.Add("           Mercado do Ricardão        ")
            lstCup.Items.Add("")
            lstCup.Items.Add($"{Now(),40}")
            divisor()
            lstCup.Items.Add($"{"Código",-13}{"Descrição",-18}    Preço")
            lstCup.Items.Add($"{"Quantidade",-6} {"Preço Total",29}")
            divisor()
            indiceAtual = 9
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
        lstCup.Items.Add($"{dr("cod_produto")}{dr("descricao"),-19}{Convert.ToDouble(dr("preco_venda")).ToString("c"),-8}") '|
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
        indiceAtual += 2
        qnt_items += 1
        '-----------------------------------------------------------------------------'|
    End Sub

    Private Sub frmPdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFun.Text = funcionarioAtual.nome
    End Sub

    Private Sub frmPdv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Aberto Then
            avisar("Não é possível fechar o PDV no momento: Uma venda está aberta")
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = Now.ToString("HH:mm:ss")
        lblData.Text = Now.ToString("dd/MM")
    End Sub

    Private Sub txtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod.KeyPress
        Select Case e.KeyChar
            Case " "
                e.KeyChar = ""
        End Select
    End Sub

    Private Sub lstCup_KeyDown(sender As Object, e As KeyEventArgs) Handles lstCup.KeyDown
        If Not txtCod.Enabled Then
            If e.KeyCode = Keys.Enter Then
                If removerDoCarrinho(lstCup.SelectedIndex) Then
                    lstCup.Items.Add("------------Produto removido------------")
                    lstCup.Items.Add(lstCup.SelectedItem)
                    lstCup.Items.Add("----------------------------------------")
                    subtotal -= valorProdutoRemovidoTotal
                    valorProdutoRemovidoTotal = 0
                    indiceAtual += 3
                    qnt_items -= 1
                End If
            End If
            If e.KeyCode = Keys.Escape Then
                txtCod.Enabled = True
                txtCod.Text = ""
                txtCod.Focus()
                lblInstrucao.Visible = False
            End If
        End If
    End Sub
    Sub finalizarVenda()
        Dim frm As New frmFinalizar(subtotal, descontos)
        frm.ShowDialog()
        frm.Dispose()
        If finalizado Then
            finalizado = False
            Aberto = False
            Dim aux As String = Now.ToString("yy-MM-dd hh-mm-ss")
            Dim wtr As StreamWriter = New StreamWriter($"{aux}.txt", False)
            IniciaPorta("COM1")
            For i = 0 To lstCup.Items.Count - 1
                wtr.WriteLine(Convert.ToString(lstCup.Items(i)))
                FormataTX(UnAccent(lstCup.Items(i) & Chr(13) & Chr(10)), 0, 0, 0, 0, 0)
            Next

            wtr.Close()
            AcionaGuilhotina(1)
            FechaPorta()

            reset()
            limparRegistroVenda()
            qnt_items = 0
        End If
    End Sub
End Class

