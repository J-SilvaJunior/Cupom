Public Class frmConfirmar
    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()



    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmPdv.trust = adminTrust(TextBox1.Text)
            TextBox1.Clear()
            Me.Close()
        ElseIf e.KeyCode = keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class