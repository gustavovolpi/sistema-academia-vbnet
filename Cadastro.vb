Public Class Cadastro


    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        'Try

        sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
        'não esquecer o .Text
        rs = db.Execute(sql)
        If rs.EOF = False Then 'se existir o cpf na tabela
            'MsgBox("CPF já cadasrado!", MsgBoxStyle.OkOnly, "ATENÇÂO")
            sql = "update tb_cadastro set nome='" & txt_nome.Text & "', " &
                    "data_nasc='" & txt_data.Value & "', " &
                    "cep='" & txt_cep.Text & "', " &
                    "endereco='" & txt_endereco.Text & "', " &
                    "num='" & txt_num.Text & "', " &
                    "Objetivo='" & cmb_obj.Text & "', " &
                    "bairro='" & txt_bairro.Text & "', " &
                    "cidade='" & txt_cidade.Text & "', " &
                    "uf='" & txt_uf.Text & "', " &
                    "celular='" & txt_celular.Text & "', " &
                    "email='" & txt_email.Text & "', " &
                    "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            Else
            sql = "insert into tb_cadastro (CPF, NOME, DATA_NASC, CEP, ENDERECO,
            NUM, BAIRRO, CIDADE, UF , CELULAR, EMAIL, OBJETIVO, FOTO) values('" & txt_cpf.Text & "', " &
                 "'" & txt_nome.Text & "', '" & txt_data.Value.Date & "', " &
                 "'" & txt_cep.Text & "' , '" & txt_endereco.Text & "',  " &
                 "'" & txt_num.Text & "' , '" & txt_bairro.Text & "', " &
                 "'" & txt_cidade.Text & "', '" & txt_uf.Text & "', " &
                 "'" & txt_celular.Text & "', '" & txt_email.Text & "', " &
                 "'" & cmb_obj.Text & "' , '" & diretorio & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")


        End If
        'limpar_cadastro()

        'Catch ex As Exception
        'MsgBox("ERRO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        'End Try
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select * from tb_cadastro where CPF = '" & txt_id.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            MsgBox("ALUNO NAO ENCONTRADO")
        Else
            aux_id = rs.Fields(0).Value
            check_treino_costas()
            check_treino_peito()
            check_treino_triceps()
            check_treino_biceps()
            check_treino_abdomen()
            check_treino_aerobico()
            check_treino_ombros()
            check_treino_quadriceps()
            check_treino_panturrilha()
            check_treino_gluteo()

            sql = "insert into tb_treino values('" & aux_id & "','" & chk_costas.Text + chk_costas1.Text + chk_costas2.Text + chk_costas3.Text + chk_costas4.Text & "' , " &
                        "'" & chk_peito.Text + chk_peito1.Text + chk_peito2.Text + chk_peito3.Text + chk_peito4.Text & "', " &
                        "'" & chk_abm.Text + chk_abm1.Text + chk_abm2.Text + chk_abm3.Text & "', " &
                        "'" & chk_biceps.Text + chk_biceps1.Text + chk_biceps2.Text + chk_biceps3.Text + chk_biceps4.Text & "', " &
                        "'" & chk_ombro.Text + chk_ombro1.Text + chk_ombro2.Text + chk_ombro3.Text & "', " &
                        "'" & chk_tri.Text + chk_tri1.Text + chk_tri2.Text + chk_tri3.Text + chk_tri4.Text & "', " &
                        "'" & chk_quad.Text + chk_quad1.Text + chk_quad2.Text + chk_quad3.Text + chk_quad4.Text + chk_quad5.Text & "', " &
                        "'" & chk_pantu.Text + chk_pantu1.Text + chk_pantu2.Text + chk_pantu3.Text + chk_pantu4.Text + chk_pantu5.Text & "', " &
                        "'" & chk_glu.Text + chk_glu1.Text + chk_glu2.Text + chk_glu3.Text & "' , " &
                        "'" & chk_aero.Text + chk_aero1.Text + chk_aero2.Text + chk_aero3.Text & "', " &
                        "'" & cmb_dia.Text & "')"
            rs = db.Execute(sql)

            MsgBox("TREINO CRIADO COM SUCESSO!!!")
        End If

    End Sub

    Private Sub txt_nome_MouseLeave(sender As Object, e As EventArgs) Handles txt_nome.MouseLeave
        If txt_nome.Text = "" Then
            txt_nome.Text = "Nome:"

        Else txt_temporario = txt_nome.Text

        End If

    End Sub

    Private Sub txt_nome_MouseEnter(sender As Object, e As EventArgs) Handles txt_nome.MouseEnter
        If txt_nome.Text = "Nome:" Then

            txt_nome.Text = ""

        Else txt_temporario = txt_nome.Text

        End If
    End Sub

    Private Sub txt_celular_MouseLeave(sender As Object, e As EventArgs) Handles txt_celular.MouseLeave
        If txt_celular.Text = "" Then
            txt_celular.Text = "Celular:"

        Else txt_temporario = txt_celular.Text

        End If

    End Sub

    Private Sub txt_celular_MouseEnter(sender As Object, e As EventArgs) Handles txt_celular.MouseEnter
        If txt_celular.Text = "Celular:" Then

            txt_celular.Text = ""

        Else txt_temporario = txt_celular.Text

        End If
    End Sub


    Private Sub txt_email_MouseLeave(sender As Object, e As EventArgs) Handles txt_email.MouseLeave
        If txt_email.Text = "" Then
            txt_email.Text = "Email:"

        Else txt_temporario = txt_email.Text

        End If
    End Sub

    Private Sub txt_email_MouseEnter(sender As Object, e As EventArgs) Handles txt_email.MouseEnter
        If txt_email.Text = "Email:" Then

            txt_email.Text = ""

        Else txt_temporario = txt_email.Text

        End If
    End Sub

    Private Sub txt_cpf_MouseEnter(sender As Object, e As EventArgs) Handles txt_cpf.MouseEnter
        If txt_cpf.Text = "CPF:" Then

            txt_cpf.Text = ""

        Else txt_temporario = txt_cpf.Text

        End If
    End Sub

    Private Sub txt_cpf_MouseLeave(sender As Object, e As EventArgs) Handles txt_cpf.MouseLeave
        If txt_cpf.Text = "" Then
            txt_cpf.Text = "CPF:"

        Else txt_temporario = txt_cpf.Text

        End If
    End Sub


    Private Sub txt_cep_MouseEnter(sender As Object, e As EventArgs) Handles txt_cep.MouseEnter
        If txt_cep.Text = "CEP:" Then

            txt_cep.Text = ""

        Else txt_temporario = txt_cep.Text

        End If
    End Sub

    Private Sub txt_cep_MouseLeave(sender As Object, e As EventArgs) Handles txt_cep.MouseLeave
        If txt_cep.Text = "" Then
            txt_cep.Text = "CEP:"

        Else txt_temporario = txt_cep.Text
        End If

    End Sub

    Private Sub txt_num_MouseLeave(sender As Object, e As EventArgs) Handles txt_num.MouseLeave
        If txt_num.Text = "" Then
            txt_num.Text = "NUM:"

        Else txt_temporario = txt_num.Text
        End If
    End Sub

    Private Sub txt_num_MouseEnter(sender As Object, e As EventArgs) Handles txt_num.MouseEnter
        If txt_num.Text = "NUM:" Then

            txt_num.Text = ""

        Else txt_temporario = txt_num.Text

        End If
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        sql = "select * from tb_cep where cep = '" & txt_cep.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_endereco.Text = rs.Fields(1).Value
            txt_cidade.Text = rs.Fields(2).Value
            txt_bairro.Text = rs.Fields(3).Value
            txt_uf.Text = rs.Fields(4).Value
            txt_num.Focus()

        End If
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        sql = "insert into tb_aulas (id_conta, personal, horario, dia, tipo_aula, max_inscritos) values ('" & aux_id & "', " &
            "'" & aux_nome & "', '" & cmb_hora.Text & "', '" & txt_data1.Value.Date & "',  " &
            " '" & cmb_aula.Text & "', '" & max_alunos.Text & "')"
        rs = db.Execute(sql)
        MsgBox("Aula criada com sucesso")
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        cadastrar_funcionarios.Show()
        Me.Hide()
        logout()
    End Sub
End Class