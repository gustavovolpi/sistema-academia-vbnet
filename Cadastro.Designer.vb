<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_endereco = New ns1.BunifuMaterialTextbox()
        Me.txt_uf = New ns1.BunifuMaterialTextbox()
        Me.txt_num = New ns1.BunifuMaterialTextbox()
        Me.txt_cep = New ns1.BunifuMaterialTextbox()
        Me.txt_cidade = New ns1.BunifuMaterialTextbox()
        Me.txt_bairro = New ns1.BunifuMaterialTextbox()
        Me.txt_celular = New ns1.BunifuMaterialTextbox()
        Me.txt_cpf = New ns1.BunifuMaterialTextbox()
        Me.txt_email = New ns1.BunifuMaterialTextbox()
        Me.txt_nome = New ns1.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_obj = New System.Windows.Forms.ComboBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_biceps2 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_aero2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_aero1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_quad2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_pantu2 = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.chk_tri1 = New System.Windows.Forms.CheckBox()
        Me.cmb_dia = New System.Windows.Forms.ComboBox()
        Me.chk_glu3 = New System.Windows.Forms.CheckBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.chk_glu1 = New System.Windows.Forms.CheckBox()
        Me.chk_glu2 = New System.Windows.Forms.CheckBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.chk_glu = New System.Windows.Forms.CheckBox()
        Me.chk_pantu5 = New System.Windows.Forms.CheckBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.chk_pantu4 = New System.Windows.Forms.CheckBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.chk_pantu3 = New System.Windows.Forms.CheckBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.chk_pantu1 = New System.Windows.Forms.CheckBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.chk_pantu = New System.Windows.Forms.CheckBox()
        Me.chk_quad5 = New System.Windows.Forms.CheckBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.chk_quad4 = New System.Windows.Forms.CheckBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.chk_quad3 = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chk_quad1 = New System.Windows.Forms.CheckBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.chk_quad = New System.Windows.Forms.CheckBox()
        Me.chk_aero3 = New System.Windows.Forms.CheckBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.chk_aero = New System.Windows.Forms.CheckBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.chk_abm3 = New System.Windows.Forms.CheckBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.chk_abm1 = New System.Windows.Forms.CheckBox()
        Me.chk_abm2 = New System.Windows.Forms.CheckBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.chk_abm = New System.Windows.Forms.CheckBox()
        Me.chk_biceps4 = New System.Windows.Forms.CheckBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.chk_biceps3 = New System.Windows.Forms.CheckBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.chk_biceps1 = New System.Windows.Forms.CheckBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.chk_biceps = New System.Windows.Forms.CheckBox()
        Me.chk_ombro3 = New System.Windows.Forms.CheckBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.chk_ombro1 = New System.Windows.Forms.CheckBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.chk_ombro2 = New System.Windows.Forms.CheckBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.chk_ombro = New System.Windows.Forms.CheckBox()
        Me.chk_tri4 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chk_tri3 = New System.Windows.Forms.CheckBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.chk_tri2 = New System.Windows.Forms.CheckBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.chk_tri = New System.Windows.Forms.CheckBox()
        Me.chk_peito4 = New System.Windows.Forms.CheckBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.chk_peito3 = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chk_peito1 = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chk_peito2 = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chk_peito = New System.Windows.Forms.CheckBox()
        Me.chk_costas4 = New System.Windows.Forms.CheckBox()
        Me.chk_costas3 = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chk_costas1 = New System.Windows.Forms.CheckBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.chk_costas2 = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chk_costas = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_criar = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.max_alunos = New System.Windows.Forms.NumericUpDown()
        Me.txt_data1 = New System.Windows.Forms.DateTimePicker()
        Me.cmb_hora = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmb_aula = New System.Windows.Forms.ComboBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.lbl1231 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txt_id = New ns1.BunifuMaterialTextbox()
        Me.btn_logout = New Guna.UI.WinForms.GunaCircleButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.max_alunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-4, -2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(589, 532)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Maroon
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.txt_endereco)
        Me.TabPage1.Controls.Add(Me.txt_uf)
        Me.TabPage1.Controls.Add(Me.txt_num)
        Me.TabPage1.Controls.Add(Me.txt_cep)
        Me.TabPage1.Controls.Add(Me.txt_cidade)
        Me.TabPage1.Controls.Add(Me.txt_bairro)
        Me.TabPage1.Controls.Add(Me.txt_celular)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cmb_obj)
        Me.TabPage1.Controls.Add(Me.btn_salvar)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_data)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(581, 506)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CADASTRO"
        '
        'txt_endereco
        '
        Me.txt_endereco.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_endereco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_endereco.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.ForeColor = System.Drawing.Color.Black
        Me.txt_endereco.HintForeColor = System.Drawing.Color.Empty
        Me.txt_endereco.HintText = ""
        Me.txt_endereco.isPassword = False
        Me.txt_endereco.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_endereco.LineIdleColor = System.Drawing.Color.Black
        Me.txt_endereco.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_endereco.LineThickness = 4
        Me.txt_endereco.Location = New System.Drawing.Point(161, 295)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(259, 25)
        Me.txt_endereco.TabIndex = 36
        Me.txt_endereco.Text = "Endereço:"
        Me.txt_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_uf
        '
        Me.txt_uf.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_uf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_uf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.ForeColor = System.Drawing.Color.Black
        Me.txt_uf.HintForeColor = System.Drawing.Color.Empty
        Me.txt_uf.HintText = ""
        Me.txt_uf.isPassword = False
        Me.txt_uf.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_uf.LineIdleColor = System.Drawing.Color.Black
        Me.txt_uf.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_uf.LineThickness = 4
        Me.txt_uf.Location = New System.Drawing.Point(161, 395)
        Me.txt_uf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(69, 25)
        Me.txt_uf.TabIndex = 35
        Me.txt_uf.Text = "UF:"
        Me.txt_uf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_num
        '
        Me.txt_num.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_num.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num.ForeColor = System.Drawing.Color.Black
        Me.txt_num.HintForeColor = System.Drawing.Color.Empty
        Me.txt_num.HintText = ""
        Me.txt_num.isPassword = False
        Me.txt_num.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_num.LineIdleColor = System.Drawing.Color.Black
        Me.txt_num.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_num.LineThickness = 4
        Me.txt_num.Location = New System.Drawing.Point(356, 394)
        Me.txt_num.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(64, 26)
        Me.txt_num.TabIndex = 34
        Me.txt_num.Text = "NUM:"
        Me.txt_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_cep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cep.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.ForeColor = System.Drawing.Color.Black
        Me.txt_cep.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cep.HintText = ""
        Me.txt_cep.isPassword = False
        Me.txt_cep.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_cep.LineIdleColor = System.Drawing.Color.Black
        Me.txt_cep.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_cep.LineThickness = 4
        Me.txt_cep.Location = New System.Drawing.Point(232, 262)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(124, 25)
        Me.txt_cep.TabIndex = 33
        Me.txt_cep.Text = "CEP:"
        Me.txt_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_cidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cidade.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.ForeColor = System.Drawing.Color.Black
        Me.txt_cidade.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cidade.HintText = ""
        Me.txt_cidade.isPassword = False
        Me.txt_cidade.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_cidade.LineIdleColor = System.Drawing.Color.Black
        Me.txt_cidade.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_cidade.LineThickness = 4
        Me.txt_cidade.Location = New System.Drawing.Point(161, 361)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(259, 25)
        Me.txt_cidade.TabIndex = 32
        Me.txt_cidade.Text = "Cidade:"
        Me.txt_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_bairro
        '
        Me.txt_bairro.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_bairro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bairro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.ForeColor = System.Drawing.Color.Black
        Me.txt_bairro.HintForeColor = System.Drawing.Color.Empty
        Me.txt_bairro.HintText = ""
        Me.txt_bairro.isPassword = False
        Me.txt_bairro.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_bairro.LineIdleColor = System.Drawing.Color.Black
        Me.txt_bairro.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_bairro.LineThickness = 4
        Me.txt_bairro.Location = New System.Drawing.Point(161, 328)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(259, 25)
        Me.txt_bairro.TabIndex = 31
        Me.txt_bairro.Text = "Bairro:"
        Me.txt_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_celular
        '
        Me.txt_celular.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_celular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_celular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.ForeColor = System.Drawing.Color.Black
        Me.txt_celular.HintForeColor = System.Drawing.Color.Empty
        Me.txt_celular.HintText = ""
        Me.txt_celular.isPassword = False
        Me.txt_celular.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_celular.LineIdleColor = System.Drawing.Color.Black
        Me.txt_celular.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_celular.LineThickness = 4
        Me.txt_celular.Location = New System.Drawing.Point(176, 136)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(229, 30)
        Me.txt_celular.TabIndex = 30
        Me.txt_celular.Text = "Celular:"
        Me.txt_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.Black
        Me.txt_cpf.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpf.HintText = ""
        Me.txt_cpf.isPassword = False
        Me.txt_cpf.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_cpf.LineIdleColor = System.Drawing.Color.Black
        Me.txt_cpf.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_cpf.LineThickness = 4
        Me.txt_cpf.Location = New System.Drawing.Point(176, 210)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(229, 30)
        Me.txt_cpf.TabIndex = 29
        Me.txt_cpf.Text = "CPF:"
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.HintForeColor = System.Drawing.Color.Empty
        Me.txt_email.HintText = ""
        Me.txt_email.isPassword = False
        Me.txt_email.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_email.LineIdleColor = System.Drawing.Color.Black
        Me.txt_email.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_email.LineThickness = 4
        Me.txt_email.Location = New System.Drawing.Point(176, 174)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(229, 28)
        Me.txt_email.TabIndex = 28
        Me.txt_email.Text = "Email:"
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.Color.Black
        Me.txt_nome.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nome.HintText = ""
        Me.txt_nome.isPassword = False
        Me.txt_nome.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_nome.LineIdleColor = System.Drawing.Color.Black
        Me.txt_nome.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_nome.LineThickness = 4
        Me.txt_nome.Location = New System.Drawing.Point(176, 96)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(229, 32)
        Me.txt_nome.TabIndex = 27
        Me.txt_nome.Text = "Nome:"
        Me.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(463, 123)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "OBJETIVO"
        '
        'cmb_obj
        '
        Me.cmb_obj.FormattingEnabled = True
        Me.cmb_obj.Items.AddRange(New Object() {"Emagrecimento", "Hipertrofia", "Definição", "Qualidade de vida"})
        Me.cmb_obj.Location = New System.Drawing.Point(445, 139)
        Me.cmb_obj.Name = "cmb_obj"
        Me.cmb_obj.Size = New System.Drawing.Size(106, 21)
        Me.cmb_obj.TabIndex = 25
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salvar.Location = New System.Drawing.Point(271, 393)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(44, 42)
        Me.btn_salvar.TabIndex = 24
        Me.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(247, 19)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(98, 82)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 22
        Me.img_foto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(35, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DATA DE NASC:"
        '
        'txt_data
        '
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(31, 139)
        Me.txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(106, 20)
        Me.txt_data.TabIndex = 4
        Me.txt_data.Value = New Date(2023, 3, 20, 0, 0, 0, 0)
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Brown
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.txt_id)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.chk_biceps2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.chk_aero2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.chk_aero1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.chk_quad2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.chk_pantu2)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.chk_tri1)
        Me.TabPage2.Controls.Add(Me.cmb_dia)
        Me.TabPage2.Controls.Add(Me.chk_glu3)
        Me.TabPage2.Controls.Add(Me.Label67)
        Me.TabPage2.Controls.Add(Me.Label68)
        Me.TabPage2.Controls.Add(Me.chk_glu1)
        Me.TabPage2.Controls.Add(Me.chk_glu2)
        Me.TabPage2.Controls.Add(Me.Label69)
        Me.TabPage2.Controls.Add(Me.chk_glu)
        Me.TabPage2.Controls.Add(Me.chk_pantu5)
        Me.TabPage2.Controls.Add(Me.Label60)
        Me.TabPage2.Controls.Add(Me.chk_pantu4)
        Me.TabPage2.Controls.Add(Me.Label61)
        Me.TabPage2.Controls.Add(Me.chk_pantu3)
        Me.TabPage2.Controls.Add(Me.Label62)
        Me.TabPage2.Controls.Add(Me.Label63)
        Me.TabPage2.Controls.Add(Me.chk_pantu1)
        Me.TabPage2.Controls.Add(Me.Label64)
        Me.TabPage2.Controls.Add(Me.chk_pantu)
        Me.TabPage2.Controls.Add(Me.chk_quad5)
        Me.TabPage2.Controls.Add(Me.Label58)
        Me.TabPage2.Controls.Add(Me.chk_quad4)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.chk_quad3)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.chk_quad1)
        Me.TabPage2.Controls.Add(Me.Label56)
        Me.TabPage2.Controls.Add(Me.chk_quad)
        Me.TabPage2.Controls.Add(Me.chk_aero3)
        Me.TabPage2.Controls.Add(Me.Label57)
        Me.TabPage2.Controls.Add(Me.Label59)
        Me.TabPage2.Controls.Add(Me.chk_aero)
        Me.TabPage2.Controls.Add(Me.Label55)
        Me.TabPage2.Controls.Add(Me.chk_abm3)
        Me.TabPage2.Controls.Add(Me.Label52)
        Me.TabPage2.Controls.Add(Me.Label53)
        Me.TabPage2.Controls.Add(Me.chk_abm1)
        Me.TabPage2.Controls.Add(Me.chk_abm2)
        Me.TabPage2.Controls.Add(Me.Label54)
        Me.TabPage2.Controls.Add(Me.chk_abm)
        Me.TabPage2.Controls.Add(Me.chk_biceps4)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.chk_biceps3)
        Me.TabPage2.Controls.Add(Me.Label48)
        Me.TabPage2.Controls.Add(Me.Label49)
        Me.TabPage2.Controls.Add(Me.chk_biceps1)
        Me.TabPage2.Controls.Add(Me.Label51)
        Me.TabPage2.Controls.Add(Me.chk_biceps)
        Me.TabPage2.Controls.Add(Me.chk_ombro3)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.chk_ombro1)
        Me.TabPage2.Controls.Add(Me.Label46)
        Me.TabPage2.Controls.Add(Me.chk_ombro2)
        Me.TabPage2.Controls.Add(Me.Label47)
        Me.TabPage2.Controls.Add(Me.chk_ombro)
        Me.TabPage2.Controls.Add(Me.chk_tri4)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.chk_tri3)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.Label40)
        Me.TabPage2.Controls.Add(Me.Label41)
        Me.TabPage2.Controls.Add(Me.chk_tri2)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.chk_tri)
        Me.TabPage2.Controls.Add(Me.chk_peito4)
        Me.TabPage2.Controls.Add(Me.Label38)
        Me.TabPage2.Controls.Add(Me.chk_peito3)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.chk_peito1)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.chk_peito2)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.chk_peito)
        Me.TabPage2.Controls.Add(Me.chk_costas4)
        Me.TabPage2.Controls.Add(Me.chk_costas3)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.chk_costas1)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.chk_costas2)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.chk_costas)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(581, 506)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TREINO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(448, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Rosca Scott"
        '
        'chk_biceps2
        '
        Me.chk_biceps2.AutoSize = True
        Me.chk_biceps2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_biceps2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_biceps2.Location = New System.Drawing.Point(435, 131)
        Me.chk_biceps2.Name = "chk_biceps2"
        Me.chk_biceps2.Size = New System.Drawing.Size(15, 14)
        Me.chk_biceps2.TabIndex = 177
        Me.chk_biceps2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(452, 264)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "Bicicleta"
        '
        'chk_aero2
        '
        Me.chk_aero2.AutoSize = True
        Me.chk_aero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aero2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_aero2.Location = New System.Drawing.Point(437, 265)
        Me.chk_aero2.Name = "chk_aero2"
        Me.chk_aero2.Size = New System.Drawing.Size(15, 14)
        Me.chk_aero2.TabIndex = 175
        Me.chk_aero2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(452, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Corda"
        '
        'chk_aero1
        '
        Me.chk_aero1.AutoSize = True
        Me.chk_aero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aero1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_aero1.Location = New System.Drawing.Point(437, 247)
        Me.chk_aero1.Name = "chk_aero1"
        Me.chk_aero1.Size = New System.Drawing.Size(15, 14)
        Me.chk_aero1.TabIndex = 173
        Me.chk_aero1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(44, 390)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Leg press"
        '
        'chk_quad2
        '
        Me.chk_quad2.AutoSize = True
        Me.chk_quad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_quad2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_quad2.Location = New System.Drawing.Point(30, 392)
        Me.chk_quad2.Name = "chk_quad2"
        Me.chk_quad2.Size = New System.Drawing.Size(15, 14)
        Me.chk_quad2.TabIndex = 171
        Me.chk_quad2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(216, 391)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 16)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Salto  elevação de panturrilha"
        '
        'chk_pantu2
        '
        Me.chk_pantu2.AutoSize = True
        Me.chk_pantu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pantu2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_pantu2.Location = New System.Drawing.Point(203, 392)
        Me.chk_pantu2.Name = "chk_pantu2"
        Me.chk_pantu2.Size = New System.Drawing.Size(15, 14)
        Me.chk_pantu2.TabIndex = 169
        Me.chk_pantu2.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label33.Location = New System.Drawing.Point(199, 325)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(134, 20)
        Me.Label33.TabIndex = 168
        Me.Label33.Text = "PANTURRILHA"
        '
        'chk_tri1
        '
        Me.chk_tri1.AutoSize = True
        Me.chk_tri1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tri1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_tri1.Location = New System.Drawing.Point(285, 110)
        Me.chk_tri1.Name = "chk_tri1"
        Me.chk_tri1.Size = New System.Drawing.Size(15, 14)
        Me.chk_tri1.TabIndex = 167
        Me.chk_tri1.UseVisualStyleBackColor = True
        '
        'cmb_dia
        '
        Me.cmb_dia.FormattingEnabled = True
        Me.cmb_dia.Items.AddRange(New Object() {"Segunda - Feira", "Terça - Feira", "Quarta - Feira", "Quita - Feira", "Sexta - Feira", "Sábado", "Domingo"})
        Me.cmb_dia.Location = New System.Drawing.Point(242, 32)
        Me.cmb_dia.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_dia.Name = "cmb_dia"
        Me.cmb_dia.Size = New System.Drawing.Size(112, 21)
        Me.cmb_dia.TabIndex = 166
        '
        'chk_glu3
        '
        Me.chk_glu3.AutoSize = True
        Me.chk_glu3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_glu3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_glu3.Location = New System.Drawing.Point(286, 285)
        Me.chk_glu3.Name = "chk_glu3"
        Me.chk_glu3.Size = New System.Drawing.Size(15, 14)
        Me.chk_glu3.TabIndex = 165
        Me.chk_glu3.UseVisualStyleBackColor = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label67.Location = New System.Drawing.Point(299, 283)
        Me.Label67.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(113, 16)
        Me.Label67.TabIndex = 164
        Me.Label67.Text = "Elev quadril barra"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label68.Location = New System.Drawing.Point(299, 246)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(88, 16)
        Me.Label68.TabIndex = 163
        Me.Label68.Text = "Glúteo bridge"
        '
        'chk_glu1
        '
        Me.chk_glu1.AutoSize = True
        Me.chk_glu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_glu1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_glu1.Location = New System.Drawing.Point(286, 245)
        Me.chk_glu1.Name = "chk_glu1"
        Me.chk_glu1.Size = New System.Drawing.Size(104, 20)
        Me.chk_glu1.TabIndex = 162
        Me.chk_glu1.Text = "Remada alta"
        Me.chk_glu1.UseVisualStyleBackColor = True
        '
        'chk_glu2
        '
        Me.chk_glu2.AutoSize = True
        Me.chk_glu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_glu2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_glu2.Location = New System.Drawing.Point(286, 264)
        Me.chk_glu2.Name = "chk_glu2"
        Me.chk_glu2.Size = New System.Drawing.Size(109, 20)
        Me.chk_glu2.TabIndex = 161
        Me.chk_glu2.Text = "Agacha sumô"
        Me.chk_glu2.UseVisualStyleBackColor = True
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label69.Location = New System.Drawing.Point(299, 227)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(89, 16)
        Me.Label69.TabIndex = 160
        Me.Label69.Text = "Agacha barra"
        '
        'chk_glu
        '
        Me.chk_glu.AutoSize = True
        Me.chk_glu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_glu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_glu.Location = New System.Drawing.Point(286, 228)
        Me.chk_glu.Name = "chk_glu"
        Me.chk_glu.Size = New System.Drawing.Size(15, 14)
        Me.chk_glu.TabIndex = 159
        Me.chk_glu.UseVisualStyleBackColor = True
        '
        'chk_pantu5
        '
        Me.chk_pantu5.AutoSize = True
        Me.chk_pantu5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pantu5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_pantu5.Location = New System.Drawing.Point(203, 448)
        Me.chk_pantu5.Name = "chk_pantu5"
        Me.chk_pantu5.Size = New System.Drawing.Size(15, 14)
        Me.chk_pantu5.TabIndex = 158
        Me.chk_pantu5.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label60.Location = New System.Drawing.Point(215, 447)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(187, 16)
        Me.Label60.TabIndex = 157
        Me.Label60.Text = "Elevação panturrilha unilateral"
        '
        'chk_pantu4
        '
        Me.chk_pantu4.AutoSize = True
        Me.chk_pantu4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pantu4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_pantu4.Location = New System.Drawing.Point(203, 429)
        Me.chk_pantu4.Name = "chk_pantu4"
        Me.chk_pantu4.Size = New System.Drawing.Size(15, 14)
        Me.chk_pantu4.TabIndex = 156
        Me.chk_pantu4.UseVisualStyleBackColor = True
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label61.Location = New System.Drawing.Point(215, 429)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(185, 16)
        Me.Label61.TabIndex = 155
        Me.Label61.Text = "Elevação panturrilha máquina"
        '
        'chk_pantu3
        '
        Me.chk_pantu3.AutoSize = True
        Me.chk_pantu3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pantu3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_pantu3.Location = New System.Drawing.Point(203, 411)
        Me.chk_pantu3.Name = "chk_pantu3"
        Me.chk_pantu3.Size = New System.Drawing.Size(15, 14)
        Me.chk_pantu3.TabIndex = 154
        Me.chk_pantu3.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label62.Location = New System.Drawing.Point(216, 411)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(165, 16)
        Me.Label62.TabIndex = 153
        Me.Label62.Text = "Elevação panturrilha barra"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label63.Location = New System.Drawing.Point(216, 373)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(182, 16)
        Me.Label63.TabIndex = 152
        Me.Label63.Text = "Elevação panturrilha sentado"
        '
        'chk_pantu1
        '
        Me.chk_pantu1.AutoSize = True
        Me.chk_pantu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pantu1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_pantu1.Location = New System.Drawing.Point(203, 372)
        Me.chk_pantu1.Name = "chk_pantu1"
        Me.chk_pantu1.Size = New System.Drawing.Size(104, 20)
        Me.chk_pantu1.TabIndex = 151
        Me.chk_pantu1.Text = "Remada alta"
        Me.chk_pantu1.UseVisualStyleBackColor = True
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label64.Location = New System.Drawing.Point(216, 353)
        Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(171, 16)
        Me.Label64.TabIndex = 149
        Me.Label64.Text = "Elevação panturrilha em pé"
        '
        'chk_pantu
        '
        Me.chk_pantu.AutoSize = True
        Me.chk_pantu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pantu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_pantu.Location = New System.Drawing.Point(203, 355)
        Me.chk_pantu.Name = "chk_pantu"
        Me.chk_pantu.Size = New System.Drawing.Size(15, 14)
        Me.chk_pantu.TabIndex = 148
        Me.chk_pantu.UseVisualStyleBackColor = True
        '
        'chk_quad5
        '
        Me.chk_quad5.AutoSize = True
        Me.chk_quad5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_quad5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_quad5.Location = New System.Drawing.Point(30, 446)
        Me.chk_quad5.Name = "chk_quad5"
        Me.chk_quad5.Size = New System.Drawing.Size(15, 14)
        Me.chk_quad5.TabIndex = 147
        Me.chk_quad5.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label58.Location = New System.Drawing.Point(42, 445)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(117, 16)
        Me.Label58.TabIndex = 146
        Me.Label58.Text = "Cadeira extensora"
        '
        'chk_quad4
        '
        Me.chk_quad4.AutoSize = True
        Me.chk_quad4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_quad4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_quad4.Location = New System.Drawing.Point(30, 427)
        Me.chk_quad4.Name = "chk_quad4"
        Me.chk_quad4.Size = New System.Drawing.Size(15, 14)
        Me.chk_quad4.TabIndex = 145
        Me.chk_quad4.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label30.Location = New System.Drawing.Point(42, 426)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 16)
        Me.Label30.TabIndex = 144
        Me.Label30.Text = "Cadeira flexora"
        '
        'chk_quad3
        '
        Me.chk_quad3.AutoSize = True
        Me.chk_quad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_quad3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_quad3.Location = New System.Drawing.Point(30, 409)
        Me.chk_quad3.Name = "chk_quad3"
        Me.chk_quad3.Size = New System.Drawing.Size(15, 14)
        Me.chk_quad3.TabIndex = 143
        Me.chk_quad3.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label31.Location = New System.Drawing.Point(44, 407)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 16)
        Me.Label31.TabIndex = 142
        Me.Label31.Text = "Afundo"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label32.Location = New System.Drawing.Point(43, 370)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(142, 16)
        Me.Label32.TabIndex = 141
        Me.Label32.Text = "Agachamento halteres"
        '
        'chk_quad1
        '
        Me.chk_quad1.AutoSize = True
        Me.chk_quad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_quad1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_quad1.Location = New System.Drawing.Point(30, 370)
        Me.chk_quad1.Name = "chk_quad1"
        Me.chk_quad1.Size = New System.Drawing.Size(104, 20)
        Me.chk_quad1.TabIndex = 140
        Me.chk_quad1.Text = "Remada alta"
        Me.chk_quad1.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label56.Location = New System.Drawing.Point(43, 352)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(126, 16)
        Me.Label56.TabIndex = 138
        Me.Label56.Text = "Agachamento barra"
        '
        'chk_quad
        '
        Me.chk_quad.AutoSize = True
        Me.chk_quad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_quad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_quad.Location = New System.Drawing.Point(30, 352)
        Me.chk_quad.Name = "chk_quad"
        Me.chk_quad.Size = New System.Drawing.Size(15, 14)
        Me.chk_quad.TabIndex = 137
        Me.chk_quad.UseVisualStyleBackColor = True
        '
        'chk_aero3
        '
        Me.chk_aero3.AutoSize = True
        Me.chk_aero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aero3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_aero3.Location = New System.Drawing.Point(437, 284)
        Me.chk_aero3.Name = "chk_aero3"
        Me.chk_aero3.Size = New System.Drawing.Size(15, 14)
        Me.chk_aero3.TabIndex = 136
        Me.chk_aero3.UseVisualStyleBackColor = True
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label57.Location = New System.Drawing.Point(452, 283)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(51, 16)
        Me.Label57.TabIndex = 135
        Me.Label57.Text = "Eliptico"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label59.Location = New System.Drawing.Point(452, 228)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(49, 16)
        Me.Label59.TabIndex = 131
        Me.Label59.Text = "Esteira"
        '
        'chk_aero
        '
        Me.chk_aero.AutoSize = True
        Me.chk_aero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_aero.Location = New System.Drawing.Point(437, 229)
        Me.chk_aero.Name = "chk_aero"
        Me.chk_aero.Size = New System.Drawing.Size(15, 14)
        Me.chk_aero.TabIndex = 130
        Me.chk_aero.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label55.Location = New System.Drawing.Point(433, 201)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(102, 20)
        Me.Label55.TabIndex = 129
        Me.Label55.Text = "AEROBICO"
        '
        'chk_abm3
        '
        Me.chk_abm3.AutoSize = True
        Me.chk_abm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_abm3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_abm3.Location = New System.Drawing.Point(157, 283)
        Me.chk_abm3.Name = "chk_abm3"
        Me.chk_abm3.Size = New System.Drawing.Size(15, 14)
        Me.chk_abm3.TabIndex = 126
        Me.chk_abm3.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label52.Location = New System.Drawing.Point(170, 282)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(95, 16)
        Me.Label52.TabIndex = 125
        Me.Label52.Text = "Prancha abdm"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label53.Location = New System.Drawing.Point(170, 243)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(91, 16)
        Me.Label53.TabIndex = 124
        Me.Label53.Text = "Abdm obliquo"
        '
        'chk_abm1
        '
        Me.chk_abm1.AutoSize = True
        Me.chk_abm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_abm1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_abm1.Location = New System.Drawing.Point(157, 243)
        Me.chk_abm1.Name = "chk_abm1"
        Me.chk_abm1.Size = New System.Drawing.Size(104, 20)
        Me.chk_abm1.TabIndex = 123
        Me.chk_abm1.Text = "Remada alta"
        Me.chk_abm1.UseVisualStyleBackColor = True
        '
        'chk_abm2
        '
        Me.chk_abm2.AutoSize = True
        Me.chk_abm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_abm2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_abm2.Location = New System.Drawing.Point(157, 261)
        Me.chk_abm2.Name = "chk_abm2"
        Me.chk_abm2.Size = New System.Drawing.Size(116, 20)
        Me.chk_abm2.TabIndex = 122
        Me.chk_abm2.Text = "Prancha lateral"
        Me.chk_abm2.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label54.Location = New System.Drawing.Point(170, 225)
        Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(103, 16)
        Me.Label54.TabIndex = 121
        Me.Label54.Text = "Abdm clássicos"
        '
        'chk_abm
        '
        Me.chk_abm.AutoSize = True
        Me.chk_abm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_abm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_abm.Location = New System.Drawing.Point(157, 225)
        Me.chk_abm.Name = "chk_abm"
        Me.chk_abm.Size = New System.Drawing.Size(15, 14)
        Me.chk_abm.TabIndex = 120
        Me.chk_abm.UseVisualStyleBackColor = True
        '
        'chk_biceps4
        '
        Me.chk_biceps4.AutoSize = True
        Me.chk_biceps4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_biceps4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_biceps4.Location = New System.Drawing.Point(435, 167)
        Me.chk_biceps4.Name = "chk_biceps4"
        Me.chk_biceps4.Size = New System.Drawing.Size(15, 14)
        Me.chk_biceps4.TabIndex = 119
        Me.chk_biceps4.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label43.Location = New System.Drawing.Point(447, 167)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(98, 16)
        Me.Label43.TabIndex = 118
        Me.Label43.Text = "Rosca martelo "
        '
        'chk_biceps3
        '
        Me.chk_biceps3.AutoSize = True
        Me.chk_biceps3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_biceps3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_biceps3.Location = New System.Drawing.Point(435, 149)
        Me.chk_biceps3.Name = "chk_biceps3"
        Me.chk_biceps3.Size = New System.Drawing.Size(15, 14)
        Me.chk_biceps3.TabIndex = 117
        Me.chk_biceps3.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label48.Location = New System.Drawing.Point(448, 148)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(94, 16)
        Me.Label48.TabIndex = 116
        Me.Label48.Text = "Rosca inversa"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label49.Location = New System.Drawing.Point(448, 110)
        Me.Label49.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(84, 16)
        Me.Label49.TabIndex = 115
        Me.Label49.Text = "Rosca direta"
        '
        'chk_biceps1
        '
        Me.chk_biceps1.AutoSize = True
        Me.chk_biceps1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_biceps1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_biceps1.Location = New System.Drawing.Point(435, 109)
        Me.chk_biceps1.Name = "chk_biceps1"
        Me.chk_biceps1.Size = New System.Drawing.Size(104, 20)
        Me.chk_biceps1.TabIndex = 114
        Me.chk_biceps1.Text = "Remada alta"
        Me.chk_biceps1.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label51.Location = New System.Drawing.Point(448, 93)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(76, 16)
        Me.Label51.TabIndex = 111
        Me.Label51.Text = "Rosca alter"
        '
        'chk_biceps
        '
        Me.chk_biceps.AutoSize = True
        Me.chk_biceps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_biceps.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_biceps.Location = New System.Drawing.Point(435, 93)
        Me.chk_biceps.Name = "chk_biceps"
        Me.chk_biceps.Size = New System.Drawing.Size(15, 14)
        Me.chk_biceps.TabIndex = 110
        Me.chk_biceps.UseVisualStyleBackColor = True
        '
        'chk_ombro3
        '
        Me.chk_ombro3.AutoSize = True
        Me.chk_ombro3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ombro3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_ombro3.Location = New System.Drawing.Point(28, 284)
        Me.chk_ombro3.Name = "chk_ombro3"
        Me.chk_ombro3.Size = New System.Drawing.Size(15, 14)
        Me.chk_ombro3.TabIndex = 109
        Me.chk_ombro3.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label44.Location = New System.Drawing.Point(41, 283)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(104, 16)
        Me.Label44.TabIndex = 108
        Me.Label44.Text = "Elevação frontal"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label45.Location = New System.Drawing.Point(41, 246)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(116, 16)
        Me.Label45.TabIndex = 107
        Me.Label45.Text = "Desenvol halteres"
        '
        'chk_ombro1
        '
        Me.chk_ombro1.AutoSize = True
        Me.chk_ombro1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ombro1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_ombro1.Location = New System.Drawing.Point(28, 246)
        Me.chk_ombro1.Name = "chk_ombro1"
        Me.chk_ombro1.Size = New System.Drawing.Size(104, 20)
        Me.chk_ombro1.TabIndex = 106
        Me.chk_ombro1.Text = "Remada alta"
        Me.chk_ombro1.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label46.Location = New System.Drawing.Point(41, 265)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(108, 16)
        Me.Label46.TabIndex = 105
        Me.Label46.Text = "Elevação lateral "
        '
        'chk_ombro2
        '
        Me.chk_ombro2.AutoSize = True
        Me.chk_ombro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ombro2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_ombro2.Location = New System.Drawing.Point(28, 264)
        Me.chk_ombro2.Name = "chk_ombro2"
        Me.chk_ombro2.Size = New System.Drawing.Size(111, 20)
        Me.chk_ombro2.TabIndex = 104
        Me.chk_ombro2.Text = "Puxada frontal"
        Me.chk_ombro2.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label47.Location = New System.Drawing.Point(41, 228)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(100, 16)
        Me.Label47.TabIndex = 103
        Me.Label47.Text = "Desenvol barra"
        '
        'chk_ombro
        '
        Me.chk_ombro.AutoSize = True
        Me.chk_ombro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ombro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_ombro.Location = New System.Drawing.Point(28, 228)
        Me.chk_ombro.Name = "chk_ombro"
        Me.chk_ombro.Size = New System.Drawing.Size(15, 14)
        Me.chk_ombro.TabIndex = 102
        Me.chk_ombro.UseVisualStyleBackColor = True
        '
        'chk_tri4
        '
        Me.chk_tri4.AutoSize = True
        Me.chk_tri4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tri4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_tri4.Location = New System.Drawing.Point(285, 165)
        Me.chk_tri4.Name = "chk_tri4"
        Me.chk_tri4.Size = New System.Drawing.Size(15, 14)
        Me.chk_tri4.TabIndex = 101
        Me.chk_tri4.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(297, 165)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 16)
        Me.Label21.TabIndex = 100
        Me.Label21.Text = "Tríceps com halteres"
        '
        'chk_tri3
        '
        Me.chk_tri3.AutoSize = True
        Me.chk_tri3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tri3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_tri3.Location = New System.Drawing.Point(285, 147)
        Me.chk_tri3.Name = "chk_tri3"
        Me.chk_tri3.Size = New System.Drawing.Size(15, 14)
        Me.chk_tri3.TabIndex = 99
        Me.chk_tri3.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label39.Location = New System.Drawing.Point(298, 146)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(91, 16)
        Me.Label39.TabIndex = 98
        Me.Label39.Text = "Tríceps corda"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label40.Location = New System.Drawing.Point(299, 109)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(102, 16)
        Me.Label40.TabIndex = 97
        Me.Label40.Text = "Rosca francesa"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label41.Location = New System.Drawing.Point(298, 128)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(110, 16)
        Me.Label41.TabIndex = 95
        Me.Label41.Text = "Flexão de tríceps"
        '
        'chk_tri2
        '
        Me.chk_tri2.AutoSize = True
        Me.chk_tri2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tri2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_tri2.Location = New System.Drawing.Point(285, 127)
        Me.chk_tri2.Name = "chk_tri2"
        Me.chk_tri2.Size = New System.Drawing.Size(111, 20)
        Me.chk_tri2.TabIndex = 94
        Me.chk_tri2.Text = "Puxada frontal"
        Me.chk_tri2.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label42.Location = New System.Drawing.Point(298, 91)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(112, 16)
        Me.Label42.TabIndex = 93
        Me.Label42.Text = "Tríceps mergulho"
        '
        'chk_tri
        '
        Me.chk_tri.AutoSize = True
        Me.chk_tri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tri.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_tri.Location = New System.Drawing.Point(285, 91)
        Me.chk_tri.Name = "chk_tri"
        Me.chk_tri.Size = New System.Drawing.Size(15, 14)
        Me.chk_tri.TabIndex = 92
        Me.chk_tri.UseVisualStyleBackColor = True
        '
        'chk_peito4
        '
        Me.chk_peito4.AutoSize = True
        Me.chk_peito4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_peito4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_peito4.Location = New System.Drawing.Point(155, 165)
        Me.chk_peito4.Name = "chk_peito4"
        Me.chk_peito4.Size = New System.Drawing.Size(15, 14)
        Me.chk_peito4.TabIndex = 91
        Me.chk_peito4.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label38.Location = New System.Drawing.Point(167, 165)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(70, 16)
        Me.Label38.TabIndex = 90
        Me.Label38.Text = "PeckDeck"
        '
        'chk_peito3
        '
        Me.chk_peito3.AutoSize = True
        Me.chk_peito3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_peito3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_peito3.Location = New System.Drawing.Point(155, 147)
        Me.chk_peito3.Name = "chk_peito3"
        Me.chk_peito3.Size = New System.Drawing.Size(15, 14)
        Me.chk_peito3.TabIndex = 86
        Me.chk_peito3.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(168, 146)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 16)
        Me.Label22.TabIndex = 85
        Me.Label22.Text = "Crucifixo "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Location = New System.Drawing.Point(168, 109)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 16)
        Me.Label23.TabIndex = 84
        Me.Label23.Text = "Supito inclinado"
        '
        'chk_peito1
        '
        Me.chk_peito1.AutoSize = True
        Me.chk_peito1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_peito1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_peito1.Location = New System.Drawing.Point(155, 109)
        Me.chk_peito1.Name = "chk_peito1"
        Me.chk_peito1.Size = New System.Drawing.Size(104, 20)
        Me.chk_peito1.TabIndex = 83
        Me.chk_peito1.Text = "Remada alta"
        Me.chk_peito1.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(168, 128)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 16)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "Supino declinado"
        '
        'chk_peito2
        '
        Me.chk_peito2.AutoSize = True
        Me.chk_peito2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_peito2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_peito2.Location = New System.Drawing.Point(155, 127)
        Me.chk_peito2.Name = "chk_peito2"
        Me.chk_peito2.Size = New System.Drawing.Size(111, 20)
        Me.chk_peito2.TabIndex = 81
        Me.chk_peito2.Text = "Puxada frontal"
        Me.chk_peito2.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Location = New System.Drawing.Point(168, 91)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 16)
        Me.Label25.TabIndex = 80
        Me.Label25.Text = "Supino reto"
        '
        'chk_peito
        '
        Me.chk_peito.AutoSize = True
        Me.chk_peito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_peito.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_peito.Location = New System.Drawing.Point(155, 91)
        Me.chk_peito.Name = "chk_peito"
        Me.chk_peito.Size = New System.Drawing.Size(15, 14)
        Me.chk_peito.TabIndex = 79
        Me.chk_peito.UseVisualStyleBackColor = True
        '
        'chk_costas4
        '
        Me.chk_costas4.AutoSize = True
        Me.chk_costas4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_costas4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_costas4.Location = New System.Drawing.Point(29, 165)
        Me.chk_costas4.Name = "chk_costas4"
        Me.chk_costas4.Size = New System.Drawing.Size(99, 20)
        Me.chk_costas4.TabIndex = 78
        Me.chk_costas4.Text = "Remada cvl"
        Me.chk_costas4.UseVisualStyleBackColor = True
        '
        'chk_costas3
        '
        Me.chk_costas3.AutoSize = True
        Me.chk_costas3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_costas3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_costas3.Location = New System.Drawing.Point(29, 147)
        Me.chk_costas3.Name = "chk_costas3"
        Me.chk_costas3.Size = New System.Drawing.Size(15, 14)
        Me.chk_costas3.TabIndex = 76
        Me.chk_costas3.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label35.Location = New System.Drawing.Point(42, 146)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 16)
        Me.Label35.TabIndex = 75
        Me.Label35.Text = "Barra livre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(42, 108)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Remada alta"
        '
        'chk_costas1
        '
        Me.chk_costas1.AutoSize = True
        Me.chk_costas1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_costas1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_costas1.Location = New System.Drawing.Point(29, 108)
        Me.chk_costas1.Name = "chk_costas1"
        Me.chk_costas1.Size = New System.Drawing.Size(104, 20)
        Me.chk_costas1.TabIndex = 72
        Me.chk_costas1.Text = "Remada alta"
        Me.chk_costas1.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label36.Location = New System.Drawing.Point(42, 128)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(92, 16)
        Me.Label36.TabIndex = 71
        Me.Label36.Text = "Puxada frontal"
        '
        'chk_costas2
        '
        Me.chk_costas2.AutoSize = True
        Me.chk_costas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_costas2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_costas2.Location = New System.Drawing.Point(29, 127)
        Me.chk_costas2.Name = "chk_costas2"
        Me.chk_costas2.Size = New System.Drawing.Size(111, 20)
        Me.chk_costas2.TabIndex = 70
        Me.chk_costas2.Text = "Puxada frontal"
        Me.chk_costas2.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(42, 90)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Remada baixa"
        '
        'chk_costas
        '
        Me.chk_costas.AutoSize = True
        Me.chk_costas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_costas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_costas.Location = New System.Drawing.Point(29, 90)
        Me.chk_costas.Name = "chk_costas"
        Me.chk_costas.Size = New System.Drawing.Size(15, 14)
        Me.chk_costas.TabIndex = 68
        Me.chk_costas.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label34.Location = New System.Drawing.Point(196, 32)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(40, 20)
        Me.Label34.TabIndex = 62
        Me.Label34.Text = "DIA"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(499, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 41)
        Me.Button1.TabIndex = 57
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label29.Location = New System.Drawing.Point(282, 201)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 20)
        Me.Label29.TabIndex = 49
        Me.Label29.Text = "GLUTEO"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label27.Location = New System.Drawing.Point(26, 324)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(126, 20)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "QUADRICEPS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(153, 201)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 20)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "ABDOMEN"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(277, 66)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 20)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "TRICEPS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(431, 66)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 20)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "BICEPS"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(24, 201)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "OMBRO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(151, 66)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 20)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "PEITO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(23, 65)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "COSTAS"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Maroon
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.btn_logout)
        Me.TabPage3.Controls.Add(Me.btn_criar)
        Me.TabPage3.Controls.Add(Me.Label66)
        Me.TabPage3.Controls.Add(Me.max_alunos)
        Me.TabPage3.Controls.Add(Me.txt_data1)
        Me.TabPage3.Controls.Add(Me.cmb_hora)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.cmb_aula)
        Me.TabPage3.Controls.Add(Me.Label65)
        Me.TabPage3.Controls.Add(Me.lbl1231)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(581, 506)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CADASTRO AULAS"
        '
        'btn_criar
        '
        Me.btn_criar.AnimationHoverSpeed = 0.07!
        Me.btn_criar.AnimationSpeed = 0.03!
        Me.btn_criar.BackColor = System.Drawing.Color.DimGray
        Me.btn_criar.BaseColor = System.Drawing.Color.GreenYellow
        Me.btn_criar.BorderColor = System.Drawing.Color.Black
        Me.btn_criar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_criar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_criar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_criar.ForeColor = System.Drawing.Color.White
        Me.btn_criar.Image = CType(resources.GetObject("btn_criar.Image"), System.Drawing.Image)
        Me.btn_criar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_criar.Location = New System.Drawing.Point(267, 381)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.btn_criar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_criar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_criar.OnHoverImage = Nothing
        Me.btn_criar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_criar.Size = New System.Drawing.Size(52, 47)
        Me.btn_criar.TabIndex = 67
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Clarendon Blk BT", 11.25!)
        Me.Label66.Location = New System.Drawing.Point(246, 319)
        Me.Label66.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(102, 18)
        Me.Label66.TabIndex = 12
        Me.Label66.Text = "Max alunos"
        '
        'max_alunos
        '
        Me.max_alunos.Location = New System.Drawing.Point(273, 339)
        Me.max_alunos.Margin = New System.Windows.Forms.Padding(2)
        Me.max_alunos.Name = "max_alunos"
        Me.max_alunos.Size = New System.Drawing.Size(40, 20)
        Me.max_alunos.TabIndex = 11
        '
        'txt_data1
        '
        Me.txt_data1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data1.Location = New System.Drawing.Point(249, 274)
        Me.txt_data1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_data1.Name = "txt_data1"
        Me.txt_data1.Size = New System.Drawing.Size(92, 20)
        Me.txt_data1.TabIndex = 10
        '
        'cmb_hora
        '
        Me.cmb_hora.FormattingEnabled = True
        Me.cmb_hora.Items.AddRange(New Object() {"12:00"})
        Me.cmb_hora.Location = New System.Drawing.Point(249, 214)
        Me.cmb_hora.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_hora.Name = "cmb_hora"
        Me.cmb_hora.Size = New System.Drawing.Size(92, 21)
        Me.cmb_hora.TabIndex = 9
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Clarendon Blk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(245, 142)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(107, 18)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Tipo de aula"
        '
        'cmb_aula
        '
        Me.cmb_aula.FormattingEnabled = True
        Me.cmb_aula.Location = New System.Drawing.Point(249, 161)
        Me.cmb_aula.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_aula.Name = "cmb_aula"
        Me.cmb_aula.Size = New System.Drawing.Size(92, 21)
        Me.cmb_aula.TabIndex = 6
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("Clarendon Blk BT", 11.25!)
        Me.Label65.Location = New System.Drawing.Point(271, 196)
        Me.Label65.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(48, 18)
        Me.Label65.TabIndex = 5
        Me.Label65.Text = "Hora"
        '
        'lbl1231
        '
        Me.lbl1231.AutoSize = True
        Me.lbl1231.BackColor = System.Drawing.Color.Transparent
        Me.lbl1231.Font = New System.Drawing.Font("Clarendon Blk BT", 11.25!)
        Me.lbl1231.Location = New System.Drawing.Point(277, 255)
        Me.lbl1231.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1231.Name = "lbl1231"
        Me.lbl1231.Size = New System.Drawing.Size(35, 18)
        Me.lbl1231.TabIndex = 4
        Me.lbl1231.Text = "Dia"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.HintForeColor = System.Drawing.Color.Empty
        Me.txt_id.HintText = ""
        Me.txt_id.isPassword = False
        Me.txt_id.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_id.LineIdleColor = System.Drawing.Color.Black
        Me.txt_id.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_id.LineThickness = 4
        Me.txt_id.Location = New System.Drawing.Point(36, 25)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(154, 30)
        Me.txt_id.TabIndex = 179
        Me.txt_id.Text = "CPF:"
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_logout
        '
        Me.btn_logout.AnimationHoverSpeed = 0.07!
        Me.btn_logout.AnimationSpeed = 0.03!
        Me.btn_logout.BaseColor = System.Drawing.Color.DimGray
        Me.btn_logout.BorderColor = System.Drawing.Color.Black
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.FocusedColor = System.Drawing.Color.Empty
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Image = Nothing
        Me.btn_logout.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_logout.Location = New System.Drawing.Point(506, 23)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.RosyBrown
        Me.btn_logout.OnHoverImage = Nothing
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Size = New System.Drawing.Size(47, 47)
        Me.btn_logout.TabIndex = 68
        Me.btn_logout.Text = "LOGOUT"
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 523)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Cadastro"
        Me.Text = "Form3"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.max_alunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_data As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb_obj As ComboBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chk_peito3 As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents chk_peito1 As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents chk_peito2 As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents chk_peito As CheckBox
    Friend WithEvents chk_costas4 As CheckBox
    Friend WithEvents chk_costas3 As CheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents chk_costas1 As CheckBox
    Friend WithEvents Label36 As Label
    Friend WithEvents chk_costas2 As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents chk_costas As CheckBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents chk_pantu5 As CheckBox
    Friend WithEvents Label60 As Label
    Friend WithEvents chk_pantu4 As CheckBox
    Friend WithEvents Label61 As Label
    Friend WithEvents chk_pantu3 As CheckBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents chk_pantu1 As CheckBox
    Friend WithEvents Label64 As Label
    Friend WithEvents chk_pantu As CheckBox
    Friend WithEvents chk_quad5 As CheckBox
    Friend WithEvents Label58 As Label
    Friend WithEvents chk_quad4 As CheckBox
    Friend WithEvents Label30 As Label
    Friend WithEvents chk_quad3 As CheckBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents chk_quad1 As CheckBox
    Friend WithEvents Label56 As Label
    Friend WithEvents chk_quad As CheckBox
    Friend WithEvents chk_aero3 As CheckBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents chk_aero As CheckBox
    Friend WithEvents Label55 As Label
    Friend WithEvents chk_abm3 As CheckBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents chk_abm1 As CheckBox
    Friend WithEvents chk_abm2 As CheckBox
    Friend WithEvents Label54 As Label
    Friend WithEvents chk_abm As CheckBox
    Friend WithEvents chk_biceps4 As CheckBox
    Friend WithEvents Label43 As Label
    Friend WithEvents chk_biceps3 As CheckBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents chk_biceps1 As CheckBox
    Friend WithEvents Label51 As Label
    Friend WithEvents chk_biceps As CheckBox
    Friend WithEvents chk_ombro3 As CheckBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents chk_ombro1 As CheckBox
    Friend WithEvents Label46 As Label
    Friend WithEvents chk_ombro2 As CheckBox
    Friend WithEvents Label47 As Label
    Friend WithEvents chk_ombro As CheckBox
    Friend WithEvents chk_tri4 As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents chk_tri3 As CheckBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents chk_tri2 As CheckBox
    Friend WithEvents Label42 As Label
    Friend WithEvents chk_tri As CheckBox
    Friend WithEvents chk_peito4 As CheckBox
    Friend WithEvents Label38 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents chk_glu3 As CheckBox
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents chk_glu1 As CheckBox
    Friend WithEvents chk_glu2 As CheckBox
    Friend WithEvents Label69 As Label
    Friend WithEvents chk_glu As CheckBox
    Friend WithEvents cmb_dia As ComboBox
    Friend WithEvents chk_tri1 As CheckBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label28 As Label
    Friend WithEvents cmb_aula As ComboBox
    Friend WithEvents Label65 As Label
    Friend WithEvents lbl1231 As Label
    Friend WithEvents cmb_hora As ComboBox
    Friend WithEvents txt_data1 As DateTimePicker
    Friend WithEvents Label66 As Label
    Friend WithEvents max_alunos As NumericUpDown
    Friend WithEvents txt_email As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_nome As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_endereco As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_uf As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_num As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cep As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cidade As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_bairro As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_celular As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cpf As ns1.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_biceps2 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_aero2 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chk_aero1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_quad2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_pantu2 As CheckBox
    Friend WithEvents btn_criar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txt_id As ns1.BunifuMaterialTextbox
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaCircleButton
End Class
