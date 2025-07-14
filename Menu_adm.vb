Imports DevComponents.DotNetBar

Public Class Menu_adm
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        cadastrar_funcionarios.Show()
        Me.Hide()


    End Sub

    Private Sub btn_cad_produtos_Click(sender As Object, e As EventArgs) Handles btn_cad_produtos.Click
        produtos.Show()
        Me.Hide()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        cadastrar_funcionarios.Show()
        Me.Hide()
        logout()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cadastrar_funcionarios.Show()
        With cadastrar_funcionarios
            .TabControl1.SelectTab(0)
        End With
        Me.Hide()


    End Sub
End Class