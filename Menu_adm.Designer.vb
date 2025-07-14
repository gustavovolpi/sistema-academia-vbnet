<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_adm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cad_produtos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_logout = New Guna.UI.WinForms.GunaCircleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(219, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MENU ADM"
        '
        'btn_cad_produtos
        '
        Me.btn_cad_produtos.BackColor = System.Drawing.Color.Maroon
        Me.btn_cad_produtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_produtos.Image = CType(resources.GetObject("btn_cad_produtos.Image"), System.Drawing.Image)
        Me.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cad_produtos.Location = New System.Drawing.Point(175, 172)
        Me.btn_cad_produtos.Name = "btn_cad_produtos"
        Me.btn_cad_produtos.Size = New System.Drawing.Size(235, 51)
        Me.btn_cad_produtos.TabIndex = 7
        Me.btn_cad_produtos.Text = "Cadastrar Produtos"
        Me.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_produtos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(175, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 52)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Gerenciar Funcionários"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.AnimationHoverSpeed = 0.07!
        Me.btn_logout.AnimationSpeed = 0.03!
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BaseColor = System.Drawing.Color.DarkGray
        Me.btn_logout.BorderColor = System.Drawing.Color.Black
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.FocusedColor = System.Drawing.Color.Empty
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Image = Nothing
        Me.btn_logout.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_logout.Location = New System.Drawing.Point(272, 379)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.RosyBrown
        Me.btn_logout.OnHoverImage = Nothing
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Size = New System.Drawing.Size(47, 47)
        Me.btn_logout.TabIndex = 62
        Me.btn_logout.Text = "LOGOUT"
        '
        'Menu_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(574, 510)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cad_produtos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu_adm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cad_produtos As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaCircleButton
End Class
