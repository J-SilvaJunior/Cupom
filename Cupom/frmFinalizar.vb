Public Class frmFinalizar
    Dim V_Compra, V_Desconto As Double
    Dim valorTotal As Double
    Dim forma As Integer
    Dim pagamento As Double
    Dim troco As Double

    Private Sub MaskedTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles mskForma.KeyDown
        Select Case e.KeyValue
            Case "1"
                forma = 1
                mskForma.Enabled = False
                txtPag.Focus()
            Case "2"
                forma = 2
                mskForma.Enabled = False
                txtPag.Focus()
                txtPag.Text = (V_Compra - V_Desconto).ToString()
            Case "3"
                forma = 3
                mskForma.Enabled = False
                txtPag.Focus()
                txtPag.Text = (V_Compra - V_Desconto).ToString()
            Case "4"
                forma = 4
                mskForma.Enabled = False
                txtPag.Focus()
                txtPag.Text = (V_Compra - V_Desconto).ToString()
        End Select
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
                    lblTroco.Text = (valorTotal - pagamento).ToString("c")
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
        armazenarVenda()
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