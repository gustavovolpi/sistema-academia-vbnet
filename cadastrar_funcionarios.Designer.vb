<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastrar_funcionarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrar_funcionarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tab_login = New System.Windows.Forms.TabPage()
        Me.txt_pass = New ns1.BunifuMaterialTextbox()
        Me.txt_user = New ns1.BunifuMaterialTextbox()
        Me.chk_senha = New System.Windows.Forms.CheckBox()
        Me.lbl_senha = New System.Windows.Forms.LinkLabel()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab_cadastro = New System.Windows.Forms.TabPage()
        Me.btn_enviar = New Guna.UI.WinForms.GunaCircleButton()
        Me.txt_senha = New ns1.BunifuMaterialTextbox()
        Me.txt_email = New ns1.BunifuMaterialTextbox()
        Me.txt_usuario = New ns1.BunifuMaterialTextbox()
        Me.btn_logout = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_sair = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.chk_visualizar = New System.Windows.Forms.CheckBox()
        Me.txt_repete = New ns1.BunifuMaterialTextbox()
        Me.tab_gerenciar = New System.Windows.Forms.TabPage()
        Me.toolstrip_cad = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_gerenciar = New System.Windows.Forms.DataGridView()
        Me.id_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ativar_bloquear = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tab_login.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab_cadastro.SuspendLayout()
        Me.tab_gerenciar.SuspendLayout()
        Me.toolstrip_cad.SuspendLayout()
        CType(Me.dgv_gerenciar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_login
        '
        Me.Tab_login.BackColor = System.Drawing.Color.Maroon
        Me.Tab_login.BackgroundImage = CType(resources.GetObject("Tab_login.BackgroundImage"), System.Drawing.Image)
        Me.Tab_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab_login.Controls.Add(Me.txt_pass)
        Me.Tab_login.Controls.Add(Me.txt_user)
        Me.Tab_login.Controls.Add(Me.chk_senha)
        Me.Tab_login.Controls.Add(Me.lbl_senha)
        Me.Tab_login.Controls.Add(Me.btn_entrar)
        Me.Tab_login.Location = New System.Drawing.Point(4, 22)
        Me.Tab_login.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_login.Name = "Tab_login"
        Me.Tab_login.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_login.Size = New System.Drawing.Size(582, 515)
        Me.Tab_login.TabIndex = 2
        Me.Tab_login.Text = "Login Funcionarios"
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.ForeColor = System.Drawing.Color.Black
        Me.txt_pass.HintForeColor = System.Drawing.Color.Empty
        Me.txt_pass.HintText = ""
        Me.txt_pass.isPassword = True
        Me.txt_pass.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_pass.LineIdleColor = System.Drawing.Color.Black
        Me.txt_pass.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_pass.LineThickness = 4
        Me.txt_pass.Location = New System.Drawing.Point(177, 273)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(229, 44)
        Me.txt_pass.TabIndex = 18
        Me.txt_pass.Text = "Senha"
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.ForeColor = System.Drawing.Color.Black
        Me.txt_user.HintForeColor = System.Drawing.Color.Empty
        Me.txt_user.HintText = "Usúario"
        Me.txt_user.isPassword = False
        Me.txt_user.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_user.LineIdleColor = System.Drawing.Color.Black
        Me.txt_user.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_user.LineThickness = 4
        Me.txt_user.Location = New System.Drawing.Point(177, 219)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(229, 44)
        Me.txt_user.TabIndex = 17
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'chk_senha
        '
        Me.chk_senha.AutoSize = True
        Me.chk_senha.BackColor = System.Drawing.Color.Transparent
        Me.chk_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chk_senha.Image = CType(resources.GetObject("chk_senha.Image"), System.Drawing.Image)
        Me.chk_senha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_senha.Location = New System.Drawing.Point(177, 323)
        Me.chk_senha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_senha.Name = "chk_senha"
        Me.chk_senha.Size = New System.Drawing.Size(128, 24)
        Me.chk_senha.TabIndex = 16
        Me.chk_senha.Text = "Visualizar Senha"
        Me.chk_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_senha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chk_senha.UseVisualStyleBackColor = False
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_senha.LinkColor = System.Drawing.Color.Lime
        Me.lbl_senha.Location = New System.Drawing.Point(235, 417)
        Me.lbl_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(113, 13)
        Me.lbl_senha.TabIndex = 15
        Me.lbl_senha.TabStop = True
        Me.lbl_senha.Text = "Esqueceu sua senha?"
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.Black
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btn_entrar.Image = CType(resources.GetObject("btn_entrar.Image"), System.Drawing.Image)
        Me.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_entrar.Location = New System.Drawing.Point(206, 373)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(174, 42)
        Me.btn_entrar.TabIndex = 9
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab_login)
        Me.TabControl1.Controls.Add(Me.Tab_cadastro)
        Me.TabControl1.Controls.Add(Me.tab_gerenciar)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 541)
        Me.TabControl1.TabIndex = 0
        '
        'Tab_cadastro
        '
        Me.Tab_cadastro.BackColor = System.Drawing.Color.Maroon
        Me.Tab_cadastro.BackgroundImage = CType(resources.GetObject("Tab_cadastro.BackgroundImage"), System.Drawing.Image)
        Me.Tab_cadastro.Controls.Add(Me.btn_enviar)
        Me.Tab_cadastro.Controls.Add(Me.txt_senha)
        Me.Tab_cadastro.Controls.Add(Me.txt_email)
        Me.Tab_cadastro.Controls.Add(Me.txt_usuario)
        Me.Tab_cadastro.Controls.Add(Me.btn_logout)
        Me.Tab_cadastro.Controls.Add(Me.btn_sair)
        Me.Tab_cadastro.Controls.Add(Me.Label5)
        Me.Tab_cadastro.Controls.Add(Me.cmb_tipo)
        Me.Tab_cadastro.Controls.Add(Me.chk_visualizar)
        Me.Tab_cadastro.Controls.Add(Me.txt_repete)
        Me.Tab_cadastro.Location = New System.Drawing.Point(4, 22)
        Me.Tab_cadastro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_cadastro.Name = "Tab_cadastro"
        Me.Tab_cadastro.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_cadastro.Size = New System.Drawing.Size(582, 515)
        Me.Tab_cadastro.TabIndex = 3
        Me.Tab_cadastro.Text = "Cadastro Funcionarios"
        '
        'btn_enviar
        '
        Me.btn_enviar.AnimationHoverSpeed = 0.07!
        Me.btn_enviar.AnimationSpeed = 0.03!
        Me.btn_enviar.BackColor = System.Drawing.Color.DimGray
        Me.btn_enviar.BaseColor = System.Drawing.Color.GreenYellow
        Me.btn_enviar.BorderColor = System.Drawing.Color.Black
        Me.btn_enviar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_enviar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_enviar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_enviar.ForeColor = System.Drawing.Color.White
        Me.btn_enviar.Image = CType(resources.GetObject("btn_enviar.Image"), System.Drawing.Image)
        Me.btn_enviar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_enviar.Location = New System.Drawing.Point(270, 376)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.btn_enviar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_enviar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_enviar.OnHoverImage = Nothing
        Me.btn_enviar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_enviar.Size = New System.Drawing.Size(52, 47)
        Me.btn_enviar.TabIndex = 66
        '
        'txt_senha
        '
        Me.txt_senha.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_senha.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_senha.HintText = ""
        Me.txt_senha.isPassword = False
        Me.txt_senha.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_senha.LineIdleColor = System.Drawing.Color.Black
        Me.txt_senha.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_senha.LineThickness = 4
        Me.txt_senha.Location = New System.Drawing.Point(168, 204)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(248, 32)
        Me.txt_senha.TabIndex = 64
        Me.txt_senha.Text = "Senha"
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_email
        '
        Me.txt_email.AutoValidate = System.Windows.Forms.AutoValidate.Disable
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
        Me.txt_email.Location = New System.Drawing.Point(168, 160)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(248, 32)
        Me.txt_email.TabIndex = 63
        Me.txt_email.Text = "Email"
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_usuario
        '
        Me.txt_usuario.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_usuario.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.Color.Black
        Me.txt_usuario.HintForeColor = System.Drawing.Color.Empty
        Me.txt_usuario.HintText = ""
        Me.txt_usuario.isPassword = False
        Me.txt_usuario.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_usuario.LineIdleColor = System.Drawing.Color.Black
        Me.txt_usuario.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_usuario.LineThickness = 4
        Me.txt_usuario.Location = New System.Drawing.Point(168, 117)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(248, 33)
        Me.txt_usuario.TabIndex = 62
        Me.txt_usuario.Text = "Usuário"
        Me.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btn_logout.Location = New System.Drawing.Point(30, 24)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.RosyBrown
        Me.btn_logout.OnHoverImage = Nothing
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Size = New System.Drawing.Size(47, 47)
        Me.btn_logout.TabIndex = 61
        Me.btn_logout.Text = "LOGOUT"
        '
        'btn_sair
        '
        Me.btn_sair.AnimationHoverSpeed = 0.07!
        Me.btn_sair.AnimationSpeed = 0.03!
        Me.btn_sair.BaseColor = System.Drawing.Color.DimGray
        Me.btn_sair.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_sair.FocusedColor = System.Drawing.Color.Empty
        Me.btn_sair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Image = Nothing
        Me.btn_sair.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_sair.Location = New System.Drawing.Point(511, 24)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_sair.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_sair.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sair.OnHoverImage = Nothing
        Me.btn_sair.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sair.Size = New System.Drawing.Size(47, 47)
        Me.btn_sair.TabIndex = 60
        Me.btn_sair.Text = "SAIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 327)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Tipo de conta:"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Administrador", "Funcionario", "Personal Trainer"})
        Me.cmb_tipo.Location = New System.Drawing.Point(210, 349)
        Me.cmb_tipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(166, 21)
        Me.cmb_tipo.TabIndex = 57
        '
        'chk_visualizar
        '
        Me.chk_visualizar.AutoSize = True
        Me.chk_visualizar.BackColor = System.Drawing.Color.Transparent
        Me.chk_visualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_visualizar.Location = New System.Drawing.Point(216, 291)
        Me.chk_visualizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk_visualizar.Name = "chk_visualizar"
        Me.chk_visualizar.Size = New System.Drawing.Size(140, 20)
        Me.chk_visualizar.TabIndex = 56
        Me.chk_visualizar.Text = "Visualizar senha"
        Me.chk_visualizar.UseVisualStyleBackColor = False
        '
        'txt_repete
        '
        Me.txt_repete.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_repete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_repete.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_repete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_repete.ForeColor = System.Drawing.Color.Black
        Me.txt_repete.HintForeColor = System.Drawing.Color.Empty
        Me.txt_repete.HintText = ""
        Me.txt_repete.isPassword = False
        Me.txt_repete.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_repete.LineIdleColor = System.Drawing.Color.Black
        Me.txt_repete.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_repete.LineThickness = 4
        Me.txt_repete.Location = New System.Drawing.Point(168, 248)
        Me.txt_repete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_repete.Name = "txt_repete"
        Me.txt_repete.Size = New System.Drawing.Size(248, 34)
        Me.txt_repete.TabIndex = 65
        Me.txt_repete.Text = "Repetir senha"
        Me.txt_repete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tab_gerenciar
        '
        Me.tab_gerenciar.Controls.Add(Me.toolstrip_cad)
        Me.tab_gerenciar.Controls.Add(Me.dgv_gerenciar)
        Me.tab_gerenciar.Location = New System.Drawing.Point(4, 22)
        Me.tab_gerenciar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_gerenciar.Name = "tab_gerenciar"
        Me.tab_gerenciar.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_gerenciar.Size = New System.Drawing.Size(582, 515)
        Me.tab_gerenciar.TabIndex = 4
        Me.tab_gerenciar.Text = "Gerenciar Funcionarios"
        Me.tab_gerenciar.UseVisualStyleBackColor = True
        '
        'toolstrip_cad
        '
        Me.toolstrip_cad.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolstrip_cad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3})
        Me.toolstrip_cad.Location = New System.Drawing.Point(2, 2)
        Me.toolstrip_cad.Name = "toolstrip_cad"
        Me.toolstrip_cad.Size = New System.Drawing.Size(578, 31)
        Me.toolstrip_cad.TabIndex = 62
        Me.toolstrip_cad.Text = "ToolStrip2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton2.Text = "ToolStripButton1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'dgv_gerenciar
        '
        Me.dgv_gerenciar.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv_gerenciar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gerenciar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_conta, Me.Usuario, Me.Tipo_conta, Me.Editar, Me.Excluir, Me.Ativar_bloquear})
        Me.dgv_gerenciar.Location = New System.Drawing.Point(2, 27)
        Me.dgv_gerenciar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_gerenciar.Name = "dgv_gerenciar"
        Me.dgv_gerenciar.RowHeadersWidth = 62
        Me.dgv_gerenciar.RowTemplate.Height = 28
        Me.dgv_gerenciar.Size = New System.Drawing.Size(578, 484)
        Me.dgv_gerenciar.TabIndex = 1
        '
        'id_conta
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.id_conta.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_conta.HeaderText = "ID"
        Me.id_conta.MinimumWidth = 8
        Me.id_conta.Name = "id_conta"
        Me.id_conta.ReadOnly = True
        Me.id_conta.Width = 150
        '
        'Usuario
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Usuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.MinimumWidth = 8
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 150
        '
        'Tipo_conta
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Tipo_conta.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tipo_conta.HeaderText = "Tipo conta"
        Me.Tipo_conta.MinimumWidth = 8
        Me.Tipo_conta.Name = "Tipo_conta"
        Me.Tipo_conta.ReadOnly = True
        Me.Tipo_conta.Width = 150
        '
        'Editar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Editar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.MinimumWidth = 8
        Me.Editar.Name = "Editar"
        Me.Editar.Width = 150
        '
        'Excluir
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = CType(resources.GetObject("DataGridViewCellStyle5.NullValue"), Object)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.Excluir.DefaultCellStyle = DataGridViewCellStyle5
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.MinimumWidth = 8
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Width = 150
        '
        'Ativar_bloquear
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.Ativar_bloquear.DefaultCellStyle = DataGridViewCellStyle6
        Me.Ativar_bloquear.HeaderText = "Ativar/bloquear"
        Me.Ativar_bloquear.MinimumWidth = 8
        Me.Ativar_bloquear.Name = "Ativar_bloquear"
        Me.Ativar_bloquear.Width = 150
        '
        'cadastrar_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(591, 533)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "cadastrar_funcionarios"
        Me.Text = "cadastrar_funcionarios"
        Me.Tab_login.ResumeLayout(False)
        Me.Tab_login.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_cadastro.ResumeLayout(False)
        Me.Tab_cadastro.PerformLayout()
        Me.tab_gerenciar.ResumeLayout(False)
        Me.tab_gerenciar.PerformLayout()
        Me.toolstrip_cad.ResumeLayout(False)
        Me.toolstrip_cad.PerformLayout()
        CType(Me.dgv_gerenciar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_login As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tab_cadastro As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents chk_visualizar As CheckBox
    Friend WithEvents chk_senha As CheckBox
    Friend WithEvents lbl_senha As LinkLabel
    Friend WithEvents btn_entrar As Button
    Friend WithEvents tab_gerenciar As TabPage
    Friend WithEvents dgv_gerenciar As DataGridView
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_sair As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txt_user As ns1.BunifuMaterialTextbox
    Friend WithEvents toolstrip_cad As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents txt_pass As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_repete As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_senha As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_email As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_usuario As ns1.BunifuMaterialTextbox
    Friend WithEvents btn_enviar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents id_conta As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_conta As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents Ativar_bloquear As DataGridViewCheckBoxColumn
End Class
