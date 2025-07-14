Public Class Menu_func
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        cadastrar_funcionarios.Show()
        Me.Hide()
        logout()
    End Sub

    Private Sub btn_cad_alunos_Click(sender As Object, e As EventArgs) Handles btn_cad_alunos.Click
        Cadastro.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cad_produtos_Click(sender As Object, e As EventArgs) Handles btn_cad_produtos.Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cadastro.Show()

    End Sub
End Class