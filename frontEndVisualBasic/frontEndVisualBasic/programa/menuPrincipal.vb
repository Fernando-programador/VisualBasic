Public Class menuPrincipal
    Private Sub CadastrarToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WhatsappTelegramToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WhatsappTelegramToolStripMenuItem1.Click
        Dim tela = New cadastrofe
        cadastro.ShowDialog()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click

    End Sub
End Class