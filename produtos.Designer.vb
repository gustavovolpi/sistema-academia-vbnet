<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(produtos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlProduto = New System.Windows.Forms.Panel()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_estoque = New System.Windows.Forms.TextBox()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_produto = New System.Windows.Forms.DataGridView()
        Me.id_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlProduto.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(783, 652)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlProduto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(775, 623)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro Produtos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlProduto
        '
        Me.pnlProduto.BackColor = System.Drawing.Color.Brown
        Me.pnlProduto.BackgroundImage = CType(resources.GetObject("pnlProduto.BackgroundImage"), System.Drawing.Image)
        Me.pnlProduto.Controls.Add(Me.btn_salvar)
        Me.pnlProduto.Controls.Add(Me.btn_sair)
        Me.pnlProduto.Controls.Add(Me.txt_cod)
        Me.pnlProduto.Controls.Add(Me.txt_estoque)
        Me.pnlProduto.Controls.Add(Me.txt_preco)
        Me.pnlProduto.Controls.Add(Me.txt_nome)
        Me.pnlProduto.Controls.Add(Me.Label7)
        Me.pnlProduto.Controls.Add(Me.Label6)
        Me.pnlProduto.Controls.Add(Me.Label3)
        Me.pnlProduto.Controls.Add(Me.Label2)
        Me.pnlProduto.Location = New System.Drawing.Point(0, 0)
        Me.pnlProduto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(773, 617)
        Me.pnlProduto.TabIndex = 7
        '
        'btn_salvar
        '
        Me.btn_salvar.Location = New System.Drawing.Point(241, 501)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(75, 26)
        Me.btn_salvar.TabIndex = 14
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(479, 502)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 26)
        Me.btn_sair.TabIndex = 10
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'txt_cod
        '
        Me.txt_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.Location = New System.Drawing.Point(321, 182)
        Me.txt_cod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(123, 34)
        Me.txt_cod.TabIndex = 13
        '
        'txt_estoque
        '
        Me.txt_estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estoque.Location = New System.Drawing.Point(268, 411)
        Me.txt_estoque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_estoque.Name = "txt_estoque"
        Me.txt_estoque.Size = New System.Drawing.Size(243, 34)
        Me.txt_estoque.TabIndex = 12
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(268, 338)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(243, 34)
        Me.txt_preco.TabIndex = 11
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(225, 255)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(327, 34)
        Me.txt_nome.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(329, 378)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Estoque"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 305)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 29)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Preço de venda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 222)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Controls.Add(Me.dgv_produto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(775, 623)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gerenciar produtos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(769, 27)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'dgv_produto
        '
        Me.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_prod, Me.nome, Me.valor, Me.estoque, Me.editar, Me.excluir})
        Me.dgv_produto.Location = New System.Drawing.Point(11, 31)
        Me.dgv_produto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_produto.Name = "dgv_produto"
        Me.dgv_produto.RowHeadersWidth = 51
        Me.dgv_produto.RowTemplate.Height = 24
        Me.dgv_produto.Size = New System.Drawing.Size(727, 507)
        Me.dgv_produto.TabIndex = 2
        '
        'id_prod
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.id_prod.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_prod.HeaderText = "ID Produto"
        Me.id_prod.MinimumWidth = 6
        Me.id_prod.Name = "id_prod"
        Me.id_prod.Width = 125
        '
        'nome
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.nome.DefaultCellStyle = DataGridViewCellStyle2
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.Width = 125
        '
        'valor
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.valor.DefaultCellStyle = DataGridViewCellStyle3
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.Width = 125
        '
        'estoque
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.estoque.DefaultCellStyle = DataGridViewCellStyle4
        Me.estoque.HeaderText = "Estoque"
        Me.estoque.MinimumWidth = 6
        Me.estoque.Name = "estoque"
        Me.estoque.Width = 125
        '
        'editar
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = CType(resources.GetObject("DataGridViewCellStyle5.NullValue"), Object)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.editar.DefaultCellStyle = DataGridViewCellStyle5
        Me.editar.HeaderText = "Editar"
        Me.editar.Image = CType(resources.GetObject("editar.Image"), System.Drawing.Image)
        Me.editar.MinimumWidth = 6
        Me.editar.Name = "editar"
        Me.editar.Width = 125
        '
        'excluir
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.excluir.DefaultCellStyle = DataGridViewCellStyle6
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.MinimumWidth = 6
        Me.excluir.Name = "excluir"
        Me.excluir.Width = 125
        '
        'produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 646)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "produtos"
        Me.Text = "produtos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlProduto.ResumeLayout(False)
        Me.pnlProduto.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnlProduto As Panel
    Friend WithEvents btn_sair As Button
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents txt_estoque As TextBox
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_produto As DataGridView
    Friend WithEvents btn_salvar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents id_prod As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents estoque As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
