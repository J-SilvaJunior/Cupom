Imports System.IO
Public Class frmLogin
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogar.PerformClick()
        End If
        If e.KeyChar = Chr(27) Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click
        If LogIn(txtCod.Text) Then
            txtCod.Text = ""
            Me.Hide()
            frmArea.Show()

        Else
            avisar("Usuário não encontrado.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists("options.cfg") Then
            Dim wtr As StreamWriter = New StreamWriter("options.cfg", False)
            wtr.WriteLine("0")          'Caixa #
            wtr.WriteLine("COM1")       'Porta COM da impressora
            wtr.WriteLine("10")         'Desconto máximo
            wtr.WriteLine("Empresa")    'Empresa
            wtr.Close()
        End If

        Dim rdr As StreamReader = New StreamReader("options.cfg")
        If File.Exists("options.cfg") Then
            caixaAtual = rdr.ReadLine()                         'Caixa #
            portaImpressora = rdr.ReadLine()                    'Porta COM da impressora
            descontoMaximo = Convert.ToDouble(rdr.ReadLine())   'Desconto máximo
            nomeDaEmpresa = rdr.ReadLine()                      'Empresa
        End If

    End Sub
End Class
