<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFun
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
        Me.lblCadFun = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcod2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCargo = New System.Windows.Forms.ComboBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCadFun
        '
        Me.lblCadFun.BackColor = System.Drawing.Color.White
        Me.lblCadFun.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadFun.Location = New System.Drawing.Point(65, 10)
        Me.lblCadFun.Name = "lblCadFun"
        Me.lblCadFun.Size = New System.Drawing.Size(271, 26)
        Me.lblCadFun.TabIndex = 5
        Me.lblCadFun.Text = "CADASTRO DE FUNCIONÁRIOS"
        Me.lblCadFun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtcod2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCod)
        Me.Panel1.Controls.Add(Me.btnVol)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblCadFun)
        Me.Panel1.Controls.Add(Me.cmbCargo)
        Me.Panel1.Controls.Add(Me.txtNome)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnConf)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 271)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "CONFIRMAR CÓDIGO"
        '
        'txtcod2
        '
        Me.txtcod2.Location = New System.Drawing.Point(121, 182)
        Me.txtcod2.Name = "txtcod2"
        Me.txtcod2.Size = New System.Drawing.Size(159, 20)
        Me.txtcod2.TabIndex = 18
        Me.txtcod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CÓDIGO"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(121, 138)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(159, 20)
        Me.txtCod.TabIndex = 16
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVol
        '
        Me.btnVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVol.Location = New System.Drawing.Point(87, 225)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(111, 37)
        Me.btnVol.TabIndex = 15
        Me.btnVol.Text = "VOLTAR"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CARGO"
        '
        'cmbCargo
        '
        Me.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCargo.FormattingEnabled = True
        Me.cmbCargo.IntegralHeight = False
        Me.cmbCargo.Items.AddRange(New Object() {"Administrador", "Vendedor", "Estoquista"})
        Me.cmbCargo.Location = New System.Drawing.Point(121, 93)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(159, 21)
        Me.cmbCargo.TabIndex = 13
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(121, 51)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(159, 20)
        Me.txtNome.TabIndex = 12
        Me.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "NOME"
        '
        'btnConf
        '
        Me.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConf.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConf.Location = New System.Drawing.Point(204, 225)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(111, 37)
        Me.btnConf.TabIndex = 10
        Me.btnConf.Text = "CONFIRMAR"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'frmFun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 324)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFun"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCadFun As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCargo As ComboBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConf As Button
    Friend WithEvents btnVol As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcod2 As TextBox
End Class
