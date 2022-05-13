<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArea))
        Me.btnPDV = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnEstoque = New System.Windows.Forms.Button()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPDV
        '
        Me.btnPDV.FlatAppearance.BorderSize = 0
        Me.btnPDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDV.Font = New System.Drawing.Font("Century Gothic", 15.25!, System.Drawing.FontStyle.Bold)
        Me.btnPDV.Location = New System.Drawing.Point(12, 12)
        Me.btnPDV.Name = "btnPDV"
        Me.btnPDV.Size = New System.Drawing.Size(216, 62)
        Me.btnPDV.TabIndex = 0
        Me.btnPDV.Text = "Ponto de venda"
        Me.btnPDV.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Webdings", 15.0!)
        Me.Button4.Location = New System.Drawing.Point(572, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(33, 33)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "r"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnEstoque
        '
        Me.btnEstoque.FlatAppearance.BorderSize = 0
        Me.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstoque.Font = New System.Drawing.Font("Century Gothic", 15.25!, System.Drawing.FontStyle.Bold)
        Me.btnEstoque.Location = New System.Drawing.Point(12, 122)
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.Size = New System.Drawing.Size(216, 62)
        Me.btnEstoque.TabIndex = 4
        Me.btnEstoque.Text = "Estoque"
        Me.btnEstoque.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.FlatAppearance.BorderSize = 0
        Me.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorio.Font = New System.Drawing.Font("Century Gothic", 15.25!, System.Drawing.FontStyle.Bold)
        Me.btnRelatorio.Location = New System.Drawing.Point(12, 232)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(216, 62)
        Me.btnRelatorio.TabIndex = 5
        Me.btnRelatorio.Text = "Relatório"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(620, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(21, 307)
        Me.Panel1.TabIndex = 7
        '
        'frmArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 307)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(Me.btnEstoque)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnPDV)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPDV As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnEstoque As Button
    Friend WithEvents btnRelatorio As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
