<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alunos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alunos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_user = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_aulas = New System.Windows.Forms.DataGridView()
        Me.id_aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dia_aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_aula_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inscrever = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tabpage3 = New System.Windows.Forms.TabPage()
        Me.btn_cad_produtos = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_aulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.tabpage3)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(603, 366)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_user)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(595, 340)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LOGIN"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(21, 32)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_user.Mask = "000,000,000-00"
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(105, 20)
        Me.txt_user.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 24)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 96)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(107, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SOU FUNCIONARIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INSIRA SEU CPF: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_aulas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(595, 340)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INSCRIÇÃO AULAS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_aulas
        '
        Me.dgv_aulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_aulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_aula, Me.personal_aula, Me.horario, Me.dia_aula, Me.tipo_aula_dgv, Me.Inscrever})
        Me.dgv_aulas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_aulas.Location = New System.Drawing.Point(2, 2)
        Me.dgv_aulas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_aulas.Name = "dgv_aulas"
        Me.dgv_aulas.RowHeadersWidth = 51
        Me.dgv_aulas.RowTemplate.Height = 24
        Me.dgv_aulas.Size = New System.Drawing.Size(591, 336)
        Me.dgv_aulas.TabIndex = 1
        '
        'id_aula
        '
        Me.id_aula.HeaderText = "ID Aula"
        Me.id_aula.MinimumWidth = 8
        Me.id_aula.Name = "id_aula"
        Me.id_aula.ReadOnly = True
        Me.id_aula.Width = 30
        '
        'personal_aula
        '
        Me.personal_aula.HeaderText = "Personal"
        Me.personal_aula.MinimumWidth = 8
        Me.personal_aula.Name = "personal_aula"
        Me.personal_aula.ReadOnly = True
        Me.personal_aula.Width = 150
        '
        'horario
        '
        Me.horario.HeaderText = "Horario"
        Me.horario.MinimumWidth = 8
        Me.horario.Name = "horario"
        Me.horario.ReadOnly = True
        Me.horario.Width = 80
        '
        'dia_aula
        '
        Me.dia_aula.HeaderText = "Dia"
        Me.dia_aula.MinimumWidth = 8
        Me.dia_aula.Name = "dia_aula"
        Me.dia_aula.ReadOnly = True
        Me.dia_aula.Width = 80
        '
        'tipo_aula_dgv
        '
        Me.tipo_aula_dgv.HeaderText = "Tipo de aula"
        Me.tipo_aula_dgv.MinimumWidth = 8
        Me.tipo_aula_dgv.Name = "tipo_aula_dgv"
        Me.tipo_aula_dgv.ReadOnly = True
        Me.tipo_aula_dgv.Width = 80
        '
        'Inscrever
        '
        Me.Inscrever.HeaderText = "Inscrever-se"
        Me.Inscrever.Image = CType(resources.GetObject("Inscrever.Image"), System.Drawing.Image)
        Me.Inscrever.MinimumWidth = 8
        Me.Inscrever.Name = "Inscrever"
        Me.Inscrever.Width = 90
        '
        'tabpage3
        '
        Me.tabpage3.Controls.Add(Me.btn_cad_produtos)
        Me.tabpage3.Location = New System.Drawing.Point(4, 22)
        Me.tabpage3.Name = "tabpage3"
        Me.tabpage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage3.Size = New System.Drawing.Size(595, 340)
        Me.tabpage3.TabIndex = 2
        Me.tabpage3.Text = "TREINO"
        Me.tabpage3.UseVisualStyleBackColor = True
        '
        'btn_cad_produtos
        '
        Me.btn_cad_produtos.BackColor = System.Drawing.Color.Maroon
        Me.btn_cad_produtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_produtos.Image = CType(resources.GetObject("btn_cad_produtos.Image"), System.Drawing.Image)
        Me.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cad_produtos.Location = New System.Drawing.Point(165, 132)
        Me.btn_cad_produtos.Name = "btn_cad_produtos"
        Me.btn_cad_produtos.Size = New System.Drawing.Size(235, 42)
        Me.btn_cad_produtos.TabIndex = 8
        Me.btn_cad_produtos.Text = "Acessar Treinos"
        Me.btn_cad_produtos.UseVisualStyleBackColor = False
        '
        'alunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "alunos"
        Me.Text = "alunos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_aulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_user As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_aulas As DataGridView
    Friend WithEvents id_aula As DataGridViewTextBoxColumn
    Friend WithEvents personal_aula As DataGridViewTextBoxColumn
    Friend WithEvents horario As DataGridViewTextBoxColumn
    Friend WithEvents dia_aula As DataGridViewTextBoxColumn
    Friend WithEvents tipo_aula_dgv As DataGridViewTextBoxColumn
    Friend WithEvents Inscrever As DataGridViewImageColumn
    Friend WithEvents tabpage3 As TabPage
    Friend WithEvents btn_cad_produtos As Button
End Class
