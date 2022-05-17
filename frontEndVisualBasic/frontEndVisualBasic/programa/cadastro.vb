Public Class cadastro


    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub habilitarCampos()
        txtNome.Visible = True
        txtCelular.Visible = True
        btnLimpar.Visible = True
        btnSalvar.Visible = True

    End Sub
    Sub desabilitarCampos()
        txtNome.Visible = False
        txtCelular.Visible = False
        btnLimpar.Visible = False
        btnSalvar.Visible = False

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        habilitarCampos()
        txtNome.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        desabilitarCampos()


    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtNome.Text = ""
        txtCelular.Text = "+55 "
        txtNome.Focus()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim tela = New Login
        Login.ShowDialog()


    End Sub
End Class