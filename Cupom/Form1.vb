﻿Public Class frmLogin
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
            'Dim frmAreaNew = New frmArea()
            frmArea.Show()

        Else
            MsgBox("Foi encontrado um problema: Usuário já logado ou não encontrado.")
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
End Class
