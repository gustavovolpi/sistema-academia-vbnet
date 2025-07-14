Public Class alunos
    Private Sub dgv_aulas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_aulas.CellContentClick
        With dgv_aulas
            If .CurrentRow.Cells(5).Selected = True Then
                resp = MsgBox("Tem certeza que deseja se inscrever? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                If resp = vbYes Then
                    aux_id = .CurrentRow.Cells(0).Value
                    sql = "insert into tb_inscritos values ('" & aux_aluno & "', '" & aux_id & "') "
                    rs = db.Execute(sql)
                    MsgBox("inscrito na aula com sucesso! ")
                End If


            End If
        End With

    End Sub

    Private Sub alunos_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        TabControl1.TabPages.Remove(TabPage2)
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        carregar_aulas()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        cadastrar_funcionarios.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select * from tb_cadastro where cpf = '" & txt_user.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            aux_aluno = rs.Fields(2).Value
            MsgBox("Bem vindo aluno: " + aux_aluno)
            If TabControl1.TabPages.Contains(TabPage1) Then
                TabControl1.TabPages.Add(TabPage2)
                TabControl1.SelectedTab = TabPage2
                TabControl1.TabPages.Remove(TabPage1)
                carregar_aulas()

            End If
        Else
            MsgBox("Aluno não encontrado!!", vbInformation + vbOKOnly, "AIVSO")
            txt_user.Text = ""
            txt_user.Focus()


        End If
    End Sub


End Class