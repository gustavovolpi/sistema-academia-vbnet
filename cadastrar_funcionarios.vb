Imports ns1

Public Class cadastrar_funcionarios



    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        txt_pass.Text = UCase(txt_pass.Text)

        sql = "select * from tb_login where (usuario='" & txt_user.Text & "' or email='" & txt_user.Text & "')"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            MsgBox("Usuario incorreto", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
        Else
            tipo_user = rs.Fields(4).Value
            aux_rec = rs.Fields(3).Value
            If aux_rec = txt_pass.Text Then
                aux_id = rs.Fields(0).Value
                aux_nome = rs.Fields(1).Value
                If rs.Fields(5).Value = "BLOQUEADO" Then
                    MsgBox("Sua conta está bloqueada! Contate um administrador ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

                ElseIf tipo_user = "ADMINISTRADOR" Then
                    MsgBox("Bem vindo administrador!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")
                    TabControl1.TabPages.Add(Tab_cadastro)
                    TabControl1.TabPages.Add(tab_gerenciar)
                    TabControl1.TabPages.Remove(Tab_login)
                    Menu_adm.Show()
                ElseIf tipo_user = "PERSONAL TRAINER" Then
                    MsgBox("Bem Vindo Personal! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")
                    Menu_func.Show()
                    Me.Hide()
                ElseIf tipo_user = "FUNCIONARIO" Then
                    MsgBox("Bem vindo funcionario! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")
                    Menu_func.Show()
                    Me.Hide()
                Else
                    MsgBox("Senha incorreta")
                End If
            End If
        End If


    End Sub
    Private Sub cadastrar_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        If TabControl1.TabPages.Contains(Tab_cadastro) Or
          TabControl1.TabPages.Contains(tab_gerenciar) Then
            TabControl1.TabPages.Remove(Tab_cadastro)
            TabControl1.TabPages.Remove(tab_gerenciar)

        End If
    End Sub


    Private Sub dgv_gerenciar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_gerenciar.CellContentClick

        Try
            With dgv_gerenciar
                aux_rec = .CurrentRow.Cells(1).Value
                If .CurrentRow.Cells(3).Selected = True Then
                    TabControl1.SelectTab(0)
                    sql = "Select * from tb_login where usuario='" & aux_rec & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_usuario.Text = rs.Fields(1).Value
                        txt_email.Text = rs.Fields(2).Value
                        txt_senha.Text = rs.Fields(3).Value
                        txt_repete.Text = rs.Fields(3).Value
                        cmb_tipo.Text = rs.Fields(4).Value
                    End If

                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    sql = "select * from tb_login where usuario='" & aux_rec & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                            "o user: " & aux_rec & "?!", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete * from tb_login where usuario= '" & aux_rec & "'"
                            rs = db.Execute(sql)
                        End If
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then

                    sql = "select * from tb_login where usuario='" & aux_rec & "'"
                    rs = db.Execute(sql)
                    If rs.Fields(5).Value = "ATIVO" Then

                        resp = MsgBox("Tem deseja que deseja bloquear o usuario: " & aux_rec & " ?", vbInformation + vbYesNo, "AVISO")
                        If resp = vbYes Then
                            sql = "update tb_login set status_conta = 'bloqueado' where usuario= '" & aux_rec & "' "
                            rs = db.Execute(UCase(sql))
                            MsgBox("CONTA BLOQUEDA COM SUCESSO!!")
                        End If
                    Else

                        resp = MsgBox("Tem deseja que deseja reativar o usuario: " & aux_rec & " ?", vbInformation + vbYesNo, "AVISO")
                        If resp = vbYes Then
                            sql = "update tb_login set status_conta = 'ATIVO' where usuario= '" & aux_rec & "' "
                            rs = db.Execute(UCase(sql))
                            MsgBox("CONTA DESBLOQUEDA COM SUCESSO!!")
                        End If
                    End If


                End If


            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tab_gerenciar_Enter(sender As Object, e As EventArgs) Handles tab_gerenciar.Enter
        carregar_login()
    End Sub

    'Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
    'If chk_visualizar.Checked = True Then
    '  txt_senha.PasswordChar = ""
    ' txt_repete.PasswordChar = ""
    'Else
    '       txt_senha.PasswordChar = "*"
    '      txt_repete.PasswordChar = "*"
    'End If
    'End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Menu_adm.Show()
    End Sub



    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        logout()
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        logout()

    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Menu_adm.Show()
        Me.Hide()
    End Sub

    Private Sub txt_user_MouseLeave(sender As Object, e As EventArgs) Handles txt_user.MouseLeave
        If txt_user.Text = "" Then
            txt_user.Text = "Usuário"

        Else txt_temporario = txt_user.Text

        End If

    End Sub

    Private Sub txt_pass_MouseEnter(sender As Object, e As EventArgs) Handles txt_pass.MouseEnter
        If txt_pass.Text = "Senha" Then

            txt_pass.Text = ""

        Else txt_temporario = txt_user.Text

        End If
    End Sub

    Private Sub txt_user_MouseEnter(sender As Object, e As EventArgs) Handles txt_user.MouseEnter
        If txt_user.Text = "Usuário" Then

            txt_user.Text = ""

        Else txt_temporario = txt_user.Text

        End If
    End Sub

    Private Sub txt_pass_MouseLeave(sender As Object, e As EventArgs) Handles txt_pass.MouseLeave
        If txt_pass.Text = "" Then
            txt_pass.Text = "Senha"
        End If

    End Sub


    Private Sub txt_usuario_MouseLeave(sender As Object, e As EventArgs) Handles txt_usuario.MouseLeave
        If txt_usuario.Text = "" Then
            txt_usuario.Text = "Usuário"

        Else txt_temporario = txt_usuario.Text

        End If
    End Sub

    Private Sub txt_usuario_MouseEnter(sender As Object, e As EventArgs) Handles txt_usuario.MouseEnter
        If txt_usuario.Text = "Usuário" Then

            txt_usuario.Text = ""

        Else txt_temporario = txt_usuario.Text

        End If
    End Sub

    Private Sub txt_email_MouseLeave(sender As Object, e As EventArgs) Handles txt_email.MouseLeave
        If txt_email.Text = "" Then
            txt_email.Text = "Email"

        Else txt_temporario = txt_email.Text

        End If
    End Sub

    Private Sub txt_email_MouseEnter(sender As Object, e As EventArgs) Handles txt_email.MouseEnter
        If txt_email.Text = "Email" Then

            txt_email.Text = ""

        Else txt_temporario = txt_email.Text

        End If
    End Sub

    Private Sub txt_senha_MouseLeave(sender As Object, e As EventArgs) Handles txt_senha.MouseLeave
        If txt_senha.Text = "" Then
            txt_senha.Text = "Senha"
        End If
    End Sub

    Private Sub txt_senha_MouseEnter(sender As Object, e As EventArgs) Handles txt_senha.MouseEnter
        If txt_senha.Text = "Senha" Then

            txt_senha.Text = ""

        Else txt_temporario = txt_senha.Text

        End If
    End Sub


    Private Sub txt_repete_MouseLeave(sender As Object, e As EventArgs) Handles txt_repete.MouseLeave
        If txt_repete.Text = "" Then
            txt_repete.Text = "Repetir senha"
        End If
    End Sub

    Private Sub txt_repete_MouseEnter(sender As Object, e As EventArgs) Handles txt_repete.MouseEnter
        If txt_repete.Text = "Repetir senha" Then

            txt_repete.Text = ""

        Else txt_temporario = txt_repete.Text

        End If
    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Try
            sql = "select * from tb_login where email='" & txt_email.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_login set usuario='" & txt_usuario.Text & "', " &
                    "tipo_conta='" & cmb_tipo.Text & "', " &
                    "email='" & txt_email.Text & "' where email='" & txt_email.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            Else
                sql = "insert into tb_login(usuario, email, senha, tipo_conta) values('" & txt_usuario.Text & "', " &
                      "'" & txt_email.Text & "', '" & txt_senha.Text & "','" & cmb_tipo.Text & "' )"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
            End If

        Catch ex As Exception
            MsgBox("ERRO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        If chk_senha.Checked = True Then
            txt_pass.isPassword = False
        Else
            txt_pass.isPassword = True
        End If

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
End Class