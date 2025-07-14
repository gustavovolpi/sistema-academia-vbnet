<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_func
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_func))
        Me.btn_cad_alunos = New System.Windows.Forms.Button()
        Me.btn_cad_produtos = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_cad_alunos
        '
        Me.btn_cad_alunos.BackColor = System.Drawing.Color.Coral
        Me.btn_cad_alunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_alunos.Image = CType(resources.GetObject("btn_cad_alunos.Image"), System.Drawing.Image)
        Me.btn_cad_alunos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cad_alunos.Location = New System.Drawing.Point(198, 149)
        Me.btn_cad_alunos.Name = "btn_cad_alunos"
        Me.btn_cad_alunos.Size = New System.Drawing.Size(204, 42)
        Me.btn_cad_alunos.TabIndex = 1
        Me.btn_cad_alunos.Text = "Cadastrar Alunos"
        Me.btn_cad_alunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_alunos.UseVisualStyleBackColor = False
        '
        'btn_cad_produtos
        '
        Me.btn_cad_produtos.BackColor = System.Drawing.Color.Coral
        Me.btn_cad_produtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_produtos.Image = CType(resources.GetObject("btn_cad_produtos.Image"), System.Drawing.Image)
        Me.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cad_produtos.Location = New System.Drawing.Point(198, 211)
        Me.btn_cad_produtos.Name = "btn_cad_produtos"
        Me.btn_cad_produtos.Size = New System.Drawing.Size(204, 42)
        Me.btn_cad_produtos.TabIndex = 2
        Me.btn_cad_produtos.Text = "Cadastrar Venda"
        Me.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_produtos.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Coral
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(198, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 42)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Treinos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(175, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MENU FUNCIONARIO"
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.DarkGray
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_logout.Location = New System.Drawing.Point(198, 463)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(204, 42)
        Me.btn_logout.TabIndex = 6
        Me.btn_logout.Text = "Deslogar"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Menu_func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 546)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_cad_produtos)
        Me.Controls.Add(Me.btn_cad_alunos)
        Me.Name = "Menu_func"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cad_alunos As Button
    Friend WithEvents btn_cad_produtos As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_logout As Button
End Class
