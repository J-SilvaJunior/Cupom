Public Class frmFun
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVol.Click
        Me.Hide()
        frmArea.Show()
    End Sub

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        If txtCod.Text = "" Or txtNome.Text = "" Or cmbCargo.Text = "" Then
            erro("Uma ou mais campos não foram preenchidos.")
        ElseIf Not txtCod.Text = txtcod2.Text Then
            erro("Os códigos não são iguais.")
        Else
            If checarDuplicidade(txtCod.Text) Then
                erro("Este código já está cadastrado.")
            Else
                cadastrarUsuario(txtCod.Text, txtNome.Text, cmbCargo.Text)
                erro("Cadastrado com sucesso!")
                txtCod.Text = ""
                txtNome.Text = ""
                txtcod2.Text = ""
                cmbCargo.SelectedIndex = -1
            End If
        End If

    End Sub
End Class