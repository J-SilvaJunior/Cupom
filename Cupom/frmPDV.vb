Public Class frmPdv
    '---------------------------------------------
    'tabela ASCII com códigos úteis
    ' 13  - enter
    ' 42  - *
    '
    '
    Private Sub txtCod_Keydown(sender As Object, e As KeyEventArgs) Handles txtCod.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                erro(e.KeyCode)
            Case Keys.F8
                erro(e.KeyCode)
            Case Keys.F5
                erro(e.KeyCode)
            Case Keys.Escape
                erro(e.KeyCode)
            Case Keys.F3
                erro(e.KeyCode)
            Case Keys.Space
                e.SuppressKeyPress = True
                erro(e.KeyCode)
            Case Keys.F2
                lblQnt.Text = txtCod.Text
                txtCod.Clear()
        End Select
    End Sub
End Class