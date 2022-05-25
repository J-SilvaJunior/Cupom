Public Class frmFinalizar
    Dim V_Compra, V_Desconto As Double
    Dim valorTotal As Double
    Dim forma As Integer
    Dim pagamento As Double
    Dim troco As Double

    Private Sub MaskedTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles mskForma.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case mskForma.Text
                Case "1"
                    forma = 1
                    mskForma.Enabled = False
                    txtPag.Enabled = True
                    txtPag.Focus()
                Case "2"
                    forma = 2
                    mskForma.Enabled = False
                    txtPag.Enabled = True
                    txtPag.Focus()
                    txtPag.Text = (V_Compra - V_Desconto).ToString()
                Case "3"
                    forma = 3
                    mskForma.Enabled = False
                    txtPag.Enabled = True
                    txtPag.Focus()
                    txtPag.Text = (V_Compra - V_Desconto).ToString()
                Case "4"
                    forma = 4
                    mskForma.Enabled = False
                    txtPag.Enabled = True
                    txtPag.Focus()
                    txtPag.Text = (V_Compra - V_Desconto).ToString()
            End Select
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPag.KeyPress
        Dim unused As Integer
        If Not Int16.TryParse(e.KeyChar, unused) Then
            If Not e.KeyChar = "," Then
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPag.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Double.TryParse(txtPag.Text, pagamento) Then
                If (pagamento >= valorTotal) Then
                    txtPag.Enabled = False

                    btnFinalizar.Text = "Aperte enter para finalizar"
                    lblValorPago.Text = pagamento.ToString("c")
                    troco = (valorTotal - pagamento)
                    lblTroco.Text = troco.ToString("c")
                    btnFinalizar.Enabled = True
                    btnFinalizar.Focus()
                Else
                    txtPag.Clear()
                    avisar("O valor pago não pode ser menor que o valor total")
                End If

            Else
                avisar("Insira o valor corretamente.")
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            txtPag.Clear()
            txtPag.Enabled = False
            mskForma.Focus()
        End If
    End Sub

    Private Sub frmFinalizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mskForma.Focus()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        frmPdv.finalizado = True
        Dim modo As String = "Dinheiro"
        Select Case forma
            Case 1
                modo = "Dinheiro"
            Case 2
                modo = "Crédito"
            Case 3
                modo = "Débito"
            Case 4
                modo = "Pix"
        End Select
        With frmPdv.lstCup.Items
            .Add("----------------------------------------")
            .Add($"Valor da compra:{V_Compra.ToString("c"),24}")
            .Add($"Descontos:{V_Desconto.ToString("c"),30}")
            .Add($"Valor total:{valorTotal,28}")
            .Add($"Troco:{troco.ToString("c"),34}")
            .Add($"Forma de pagamento:{modo,21}")
        End With
        armazenarVenda(V_Compra,
                       V_Desconto,
                       valorTotal,
                       troco,
                       forma)
        Me.Close()
    End Sub

    Sub New(valor As Double, desconto As Double)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        V_Compra = valor
        V_Desconto = desconto
        valorTotal = V_Compra - V_Desconto
        lblValor.Text = V_Compra.ToString("C")
        lblDesc.Text = V_Desconto.ToString("c")
        lblVTotal.Text = valorTotal.ToString("c")
    End Sub

End Class