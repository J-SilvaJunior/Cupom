<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoque
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPesquisar)
        Me.Panel1.Controls.Add(Me.btnSair)
        Me.Panel1.Controls.Add(Me.txtCompra)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtVenda)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDesc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCod)
        Me.Panel1.Controls.Add(Me.btnCadastrar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(19, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 279)
        Me.Panel1.TabIndex = 4
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Location = New System.Drawing.Point(90, 208)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(145, 38)
        Me.btnPesquisar.TabIndex = 11
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Location = New System.Drawing.Point(3, 208)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(81, 38)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'txtCompra
        '
        Me.txtCompra.Location = New System.Drawing.Point(193, 142)
        Me.txtCompra.MaxLength = 20
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(174, 27)
        Me.txtCompra.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Preço de Compra"
        '
        'txtVenda
        '
        Me.txtVenda.Location = New System.Drawing.Point(193, 109)
        Me.txtVenda.MaxLength = 20
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.Size = New System.Drawing.Size(174, 27)
        Me.txtVenda.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Preço de Venda"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(141, 76)
        Me.txtDesc.MaxLength = 18
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(226, 27)
        Me.txtDesc.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descrição"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(141, 43)
        Me.txtCod.MaxLength = 13
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(226, 27)
        Me.txtCod.TabIndex = 0
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Location = New System.Drawing.Point(241, 208)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(171, 38)
        Me.btnCadastrar.TabIndex = 3
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Adicionar Produtos"
        '
        'frmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 362)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtVenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents btnPesquisar As Button
End Class
