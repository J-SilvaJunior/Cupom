Public Class frmArea
    Dim waitload As Short = 0
    Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub frmArea_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub

    Private Sub frmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If funcionarioAtual.cargo = "Vendedor" Then
            btnRelatorio.Visible = False
            btnEstoque.Visible = False
            Button1.Visible = False

        ElseIf funcionarioAtual.cargo = "Estoquista" Then
            btnPDV.Visible = False
            btnRelatorio.Visible = False
            Button1.Visible = False
        Else
            btnPDV.Visible = True
            btnRelatorio.Visible = True
            Button1.Visible = True
            btnEstoque.Visible = True
        End If
        Timer1.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnPDV_Click(sender As Object, e As EventArgs) Handles btnPDV.Click
        Me.Hide()
        frmPdv.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        'frmEstoque.show()
    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        'frmRelatorio.show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If waitload <= 3 Then
            waitload += 1
        End If
        If waitload > 3 Then
            Panel2.Size = New Size(0, 0)
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmFun.ShowDialog()
    End Sub
End Class