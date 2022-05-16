<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPdv))
        Me.lstCup = New System.Windows.Forms.ListBox()
        Me.btnVnd = New System.Windows.Forms.Button()
        Me.btnQtd = New System.Windows.Forms.Button()
        Me.btnRmv = New System.Windows.Forms.Button()
        Me.btnDsc = New System.Windows.Forms.Button()
        Me.btnEcr = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnPes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblPreUnt = New System.Windows.Forms.Label()
        Me.lblQua = New System.Windows.Forms.Label()
        Me.lblPro = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pctCoupon = New System.Windows.Forms.PictureBox()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblFun = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pctCoupon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpCliente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCup
        '
        Me.lstCup.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCup.FormattingEnabled = True
        Me.lstCup.ItemHeight = 14
        Me.lstCup.Items.AddRange(New Object() {"0123456789012345678901234567890123456789"})
        Me.lstCup.Location = New System.Drawing.Point(12, 12)
        Me.lstCup.Name = "lstCup"
        Me.lstCup.Size = New System.Drawing.Size(912, 536)
        Me.lstCup.TabIndex = 0
        '
        'btnVnd
        '
        Me.btnVnd.BackColor = System.Drawing.Color.White
        Me.btnVnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVnd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVnd.Location = New System.Drawing.Point(934, 107)
        Me.btnVnd.Name = "btnVnd"
        Me.btnVnd.Size = New System.Drawing.Size(160, 76)
        Me.btnVnd.TabIndex = 1
        Me.btnVnd.Text = "Efetuar Venda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Barra de Espaço)"
        Me.btnVnd.UseVisualStyleBackColor = False
        '
        'btnQtd
        '
        Me.btnQtd.BackColor = System.Drawing.Color.White
        Me.btnQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQtd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQtd.Location = New System.Drawing.Point(1100, 105)
        Me.btnQtd.Name = "btnQtd"
        Me.btnQtd.Size = New System.Drawing.Size(168, 78)
        Me.btnQtd.TabIndex = 2
        Me.btnQtd.Text = "Quantidade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F2)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnQtd.UseVisualStyleBackColor = False
        '
        'btnRmv
        '
        Me.btnRmv.BackColor = System.Drawing.Color.White
        Me.btnRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRmv.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRmv.Location = New System.Drawing.Point(1100, 189)
        Me.btnRmv.Name = "btnRmv"
        Me.btnRmv.Size = New System.Drawing.Size(168, 76)
        Me.btnRmv.TabIndex = 4
        Me.btnRmv.Text = "Remover Produto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F5)"
        Me.btnRmv.UseVisualStyleBackColor = False
        '
        'btnDsc
        '
        Me.btnDsc.BackColor = System.Drawing.Color.White
        Me.btnDsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDsc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDsc.Location = New System.Drawing.Point(934, 189)
        Me.btnDsc.Name = "btnDsc"
        Me.btnDsc.Size = New System.Drawing.Size(160, 76)
        Me.btnDsc.TabIndex = 3
        Me.btnDsc.Text = "Desconto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F3)"
        Me.btnDsc.UseVisualStyleBackColor = False
        '
        'btnEcr
        '
        Me.btnEcr.BackColor = System.Drawing.Color.White
        Me.btnEcr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEcr.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEcr.Location = New System.Drawing.Point(934, 369)
        Me.btnEcr.Name = "btnEcr"
        Me.btnEcr.Size = New System.Drawing.Size(334, 114)
        Me.btnEcr.TabIndex = 5
        Me.btnEcr.Text = "Encerrar (Esc)"
        Me.btnEcr.UseVisualStyleBackColor = False
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(930, 509)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(220, 40)
        Me.txtCod.TabIndex = 6
        '
        'btnPes
        '
        Me.btnPes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPes.Location = New System.Drawing.Point(1160, 509)
        Me.btnPes.Name = "btnPes"
        Me.btnPes.Size = New System.Drawing.Size(112, 40)
        Me.btnPes.TabIndex = 7
        Me.btnPes.Text = "Pesquisar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F8)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnPes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(930, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código do Produto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblSubTotal)
        Me.Panel2.Controls.Add(Me.lblPreUnt)
        Me.Panel2.Controls.Add(Me.lblQua)
        Me.Panel2.Controls.Add(Me.lblPro)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(232, 555)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(866, 152)
        Me.Panel2.TabIndex = 10
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblSubTotal.Location = New System.Drawing.Point(94, 114)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(75, 19)
        Me.lblSubTotal.TabIndex = 15
        Me.lblSubTotal.Text = "Subtotal:"
        '
        'lblPreUnt
        '
        Me.lblPreUnt.AutoSize = True
        Me.lblPreUnt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreUnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblPreUnt.Location = New System.Drawing.Point(104, 79)
        Me.lblPreUnt.Name = "lblPreUnt"
        Me.lblPreUnt.Size = New System.Drawing.Size(85, 19)
        Me.lblPreUnt.TabIndex = 14
        Me.lblPreUnt.Text = "Preço Unt:"
        '
        'lblQua
        '
        Me.lblQua.AutoSize = True
        Me.lblQua.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblQua.Location = New System.Drawing.Point(127, 47)
        Me.lblQua.Name = "lblQua"
        Me.lblQua.Size = New System.Drawing.Size(108, 19)
        Me.lblQua.TabIndex = 13
        Me.lblQua.Text = "Quantidade:"
        '
        'lblPro
        '
        Me.lblPro.AutoSize = True
        Me.lblPro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblPro.Location = New System.Drawing.Point(91, 10)
        Me.lblPro.Name = "lblPro"
        Me.lblPro.Size = New System.Drawing.Size(72, 19)
        Me.lblPro.TabIndex = 12
        Me.lblPro.Text = "Produto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(13, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 19)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Subtotal:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(13, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 19)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Preço Unt:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(13, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 19)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Quantidade:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(13, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 19)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Produto:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblTotal)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(232, 713)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(866, 43)
        Me.Panel3.TabIndex = 11
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(68, 12)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(45, 19)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(13, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 19)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Total:"
        '
        'pctCoupon
        '
        Me.pctCoupon.Image = CType(resources.GetObject("pctCoupon.Image"), System.Drawing.Image)
        Me.pctCoupon.Location = New System.Drawing.Point(1104, 555)
        Me.pctCoupon.Name = "pctCoupon"
        Me.pctCoupon.Size = New System.Drawing.Size(168, 201)
        Me.pctCoupon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCoupon.TabIndex = 12
        Me.pctCoupon.TabStop = False
        '
        'btnImp
        '
        Me.btnImp.BackColor = System.Drawing.Color.White
        Me.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImp.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImp.Location = New System.Drawing.Point(934, 271)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(334, 92)
        Me.btnImp.TabIndex = 13
        Me.btnImp.Text = "Imprimir Nota Fiscal " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F12)"
        Me.btnImp.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Controls.Add(Me.lblData)
        Me.Panel1.Controls.Add(Me.lblFun)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(934, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 87)
        Me.Panel1.TabIndex = 13
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(61, 62)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(50, 19)
        Me.lblHora.TabIndex = 17
        Me.lblHora.Text = "Hora:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblData.Location = New System.Drawing.Point(60, 35)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(50, 19)
        Me.lblData.TabIndex = 16
        Me.lblData.Text = "Data:"
        '
        'lblFun
        '
        Me.lblFun.AutoSize = True
        Me.lblFun.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblFun.Location = New System.Drawing.Point(116, 6)
        Me.lblFun.Name = "lblFun"
        Me.lblFun.Size = New System.Drawing.Size(105, 19)
        Me.lblFun.TabIndex = 15
        Me.lblFun.Text = "Funcionário:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Data:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hora:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Funcionário:"
        '
        'grpCliente
        '
        Me.grpCliente.Controls.Add(Me.Button1)
        Me.grpCliente.Controls.Add(Me.TextBox1)
        Me.grpCliente.Controls.Add(Me.PictureBox1)
        Me.grpCliente.Location = New System.Drawing.Point(12, 555)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(203, 200)
        Me.grpCliente.TabIndex = 14
        Me.grpCliente.TabStop = False
        Me.grpCliente.Text = "Dados do Cliente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 141)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmPdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 767)
        Me.Controls.Add(Me.grpCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.pctCoupon)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPes)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnEcr)
        Me.Controls.Add(Me.btnRmv)
        Me.Controls.Add(Me.btnDsc)
        Me.Controls.Add(Me.btnQtd)
        Me.Controls.Add(Me.btnVnd)
        Me.Controls.Add(Me.lstCup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPdv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pctCoupon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCup As ListBox
    Friend WithEvents btnVnd As Button
    Friend WithEvents btnQtd As Button
    Friend WithEvents btnRmv As Button
    Friend WithEvents btnDsc As Button
    Friend WithEvents btnEcr As Button
    Friend WithEvents txtCod As TextBox
    Friend WithEvents btnPes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents pctCoupon As PictureBox
    Friend WithEvents btnImp As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblFun As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblPreUnt As Label
    Friend WithEvents lblQua As Label
    Friend WithEvents lblPro As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents grpCliente As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
