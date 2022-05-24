Public Class frmFun
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVol.Click
        txtCod.Text = ""
        txtNome.Text = ""
        txtcod2.Text = ""
        cmbCargo.SelectedIndex = -1
        Me.Hide()
        frmArea.Show()
    End Sub
    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        If txtCod.Text = "" Or txtNome.Text = "" Or cmbCargo.Text = "" Then
            avisar("Uma ou mais campos não foram preenchidos.")
        ElseIf Not txtCod.Text = txtcod2.Text Then
            avisar("Os códigos não são iguais.")
        ElseIf txtCod.text.Length < 6 Then
            avisar("O código não possui no mínimo 6 caractéres.")
        Else
            If checarDuplicidade(txtCod.Text) Then
                avisar("Este código já está cadastrado.")
            Else
                cadastrarUsuario(txtCod.Text, txtNome.Text, cmbCargo.Text)
                avisar("Cadastrado com sucesso!")
                txtCod.Text = ""
                txtNome.Text = ""
                txtcod2.Text = ""
                cmbCargo.SelectedIndex = -1
            End If
        End If
    End Sub
End Class