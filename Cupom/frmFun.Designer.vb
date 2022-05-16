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
        Me.lblCadFun.Location = New System.Drawing.Point(38, 13)
        Me.lblCadFun.Name = "lblCadFun"
        Me.lblCadFun.Size = New System.Drawing.Size(271, 42)
        Me.lblCadFun.TabIndex = 5
        Me.lblCadFun.Text = "CADASTRO DE FUNCIONÁRIOS"
        Me.lblCadFun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnVol)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblCadFun)
        Me.Panel1.Controls.Add(Me.cmbCargo)
        Me.Panel1.Controls.Add(Me.txtNome)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnConf)
        Me.Panel1.Location = New System.Drawing.Point(23, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 289)
        Me.Panel1.TabIndex = 6
        '
        'btnVol
        '
        Me.btnVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVol.Location = New System.Drawing.Point(62, 242)
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
        Me.Label2.Location = New System.Drawing.Point(39, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CARGO"
        '
        'cmbCargo
        '
        Me.cmbCargo.FormattingEnabled = True
        Me.cmbCargo.IntegralHeight = False
        Me.cmbCargo.Items.AddRange(New Object() {"Administrador", "Vendedor", "Estoquista"})
        Me.cmbCargo.Location = New System.Drawing.Point(42, 134)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(159, 21)
        Me.cmbCargo.TabIndex = 13
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(42, 85)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(159, 20)
        Me.txtNome.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "NOME"
        '
        'btnConf
        '
        Me.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConf.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConf.Location = New System.Drawing.Point(179, 242)
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
        Me.ClientSize = New System.Drawing.Size(353, 366)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFun"
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
End Class
