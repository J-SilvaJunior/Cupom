Imports System.IO
Public Class frmConfig
    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = caixaAtual
        ComboBox1.SelectedItem = portaImpressora
        TextBox1.Text = nomeDaEmpresa
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wtr As StreamWriter = New StreamWriter("options.cfg", False)
        wtr.WriteLine(NumericUpDown1.Value)         'Caixa #
        wtr.WriteLine(ComboBox1.SelectedItem)       'Porta COM da impressora
        wtr.WriteLine(TextBox1.Text)                'Empresa
        wtr.Close()
        caixaAtual = NumericUpDown1.Value
        portaImpressora = ComboBox1.SelectedItem
        nomeDaEmpresa = TextBox1.Text

        Me.Close()
    End Sub
End Class