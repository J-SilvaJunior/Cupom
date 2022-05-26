
Public Class frmRelatorio
    Private Sub frmRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            abrirBanco()
            cmd.CommandText = "select distinct funcionario from venda;"
            Dim dr As MySql.Data.MySqlClient.MySqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                ComboBox1.Items.Add(dr("funcionario"))
            End While
        Catch ex As Exception

        Finally
            fecharBanco()
            zerarComando()
        End Try
    End Sub

    Sub tratarInfo(dr As MySql.Data.MySqlClient.MySqlDataReader)

        ' Dim dr2 = dr
        Dim erro As Boolean = False
        '                   1234567890123456789012345678901234567890
        Dim wtr As System.IO.StreamWriter = New System.IO.StreamWriter("relatorio.txt", False)
        If Not erro Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add($"----------------------------------------")
            ListBox1.Items.Add($"{"Codigo",-7}{"Data",-19}{"Qnt",-6}{"Valor",8}")
            ListBox1.Items.Add($"{"Pgmt",-40}")
            ListBox1.Items.Add($"{"Funcionario",-40}")
            ListBox1.Items.Add($"----------------------------------------")
            Dim modo As String = "Dinheiro"
            While dr.Read()
                ListBox1.Items.Add($"{dr("cod_venda"),-7}{dr("data_hora"),-20}{dr("qnt_itens"),-6}{dr("valor_total"),-7}")
                Select Case dr("pagamento")
                    Case "1"
                        modo = "Dinheiro"
                    Case "2"
                        modo = "Crédito"
                    Case "3"
                        modo = "Débito"
                    Case "4"
                        modo = "Pix"
                End Select
                ListBox1.Items.Add($"{modo,-40}")
                ListBox1.Items.Add($"{dr("funcionario"),-40}")
                ListBox1.Items.Add($"----------------------------------------")
            End While
        End If
        fecharBanco()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ListBox1.Items.Count = 0 Then
            IniciaPorta("com1")
            Dim wtr As System.IO.StreamWriter = New System.IO.StreamWriter("relator.txt", False)
            Dim ql As String = Chr(13) & Chr(10)
            Dim linha As String
            For index = 0 To ListBox1.Items.Count - 1
                'FormataTX((UnAccent(ListBox1.Items(index))) & ql, 2, 0, 0, 0, 0)
                wtr.WriteLine(UnAccent(ListBox1.Items(index)))
                '----------------------------------------0      
                '1234567890123456789012345678901234567890
            Next
            wtr.Close()
            Dim rdr As System.IO.StreamReader = New System.IO.StreamReader("relator.txt")
            While Not rdr.EndOfStream
                linha = rdr.ReadLine & ql
                FormataTX(linha, 2, 0, 0, 0, 0)
                rdr.Peek()
            End While
            rdr.Close()

            AcionaGuilhotina(1)
            FechaPorta()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ComboBox1.SelectedIndex = -1 Then
            tratarInfo(consumirInfoRelatorio(ComboBox1.Text))
        Else
            avisar("Escolha um funcionário")
        End If
    End Sub
End Class