Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim tela = New menuPrincipal
        tela.ShowDialog()
    End Sub
End Class