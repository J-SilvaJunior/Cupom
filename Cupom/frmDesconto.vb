Public Class frmDesconto
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim desc As Double
        If e.KeyCode = Keys.Enter Then
            If Double.TryParse(TextBox1.Text, desc) Then
                frmPdv.descontos = desc
                TextBox1.Clear()
                Me.Close()
            Else
                avisar("Não é um valor válido.")
                TextBox1.Clear()
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            TextBox1.Clear()
            Me.Close()
        End If
    End Sub
End Class