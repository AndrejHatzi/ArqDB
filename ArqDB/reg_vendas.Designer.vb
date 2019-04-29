<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reg_vendas
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reg_vendas))
        Me.metronvenda = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.nvenda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.quantidade = New System.Windows.Forms.TextBox()
        Me.pagamento = New System.Windows.Forms.ComboBox()
        Me.cod_prod = New System.Windows.Forms.ComboBox()
        Me.preco_to_mudar = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataProdutos = New System.Windows.Forms.DataGridView()
        Me.codv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nvend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codprod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.a_pagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoTotal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.codvendedor = New System.Windows.Forms.ComboBox()
        Me.Imprimir = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.nif = New System.Windows.Forms.ComboBox()
        Me.nome_prod = New System.Windows.Forms.Label()
        Me.AddProduto = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.iva = New System.Windows.Forms.Label()
        Me.iva_to_mudar = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.DataProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'metronvenda
        '
        Me.metronvenda.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.metronvenda.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.metronvenda.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.metronvenda.BorderThickness = 3
        Me.metronvenda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.metronvenda.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.metronvenda.ForeColor = System.Drawing.Color.White
        Me.metronvenda.isPassword = False
        Me.metronvenda.Location = New System.Drawing.Point(20, 37)
        Me.metronvenda.Margin = New System.Windows.Forms.Padding(4)
        Me.metronvenda.Name = "metronvenda"
        Me.metronvenda.Size = New System.Drawing.Size(288, 44)
        Me.metronvenda.TabIndex = 1
        Me.metronvenda.Text = "Registo de Vendas"
        Me.metronvenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nvenda
        '
        Me.nvenda.Location = New System.Drawing.Point(121, 115)
        Me.nvenda.Name = "nvenda"
        Me.nvenda.Size = New System.Drawing.Size(187, 20)
        Me.nvenda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nº de Venda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome"
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(121, 167)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(187, 20)
        Me.nome.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo de Pagamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(120, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CodProd"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(141, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Preço"
        '
        'quantidade
        '
        Me.quantidade.Location = New System.Drawing.Point(201, 276)
        Me.quantidade.Name = "quantidade"
        Me.quantidade.Size = New System.Drawing.Size(135, 20)
        Me.quantidade.TabIndex = 14
        '
        'pagamento
        '
        Me.pagamento.FormattingEnabled = True
        Me.pagamento.Location = New System.Drawing.Point(169, 192)
        Me.pagamento.Name = "pagamento"
        Me.pagamento.Size = New System.Drawing.Size(139, 21)
        Me.pagamento.TabIndex = 16
        '
        'cod_prod
        '
        Me.cod_prod.FormattingEnabled = True
        Me.cod_prod.Location = New System.Drawing.Point(197, 217)
        Me.cod_prod.Name = "cod_prod"
        Me.cod_prod.Size = New System.Drawing.Size(139, 21)
        Me.cod_prod.TabIndex = 17
        '
        'preco_to_mudar
        '
        Me.preco_to_mudar.AutoSize = True
        Me.preco_to_mudar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preco_to_mudar.ForeColor = System.Drawing.Color.White
        Me.preco_to_mudar.Location = New System.Drawing.Point(207, 249)
        Me.preco_to_mudar.Name = "preco_to_mudar"
        Me.preco_to_mudar.Size = New System.Drawing.Size(0, 20)
        Me.preco_to_mudar.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(105, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Quantidade"
        '
        'DataProdutos
        '
        Me.DataProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codv, Me.nvend, Me.codprod, Me.desc, Me.Preco, Me.quant, Me.iv, Me.a_pagar})
        Me.DataProdutos.Location = New System.Drawing.Point(20, 350)
        Me.DataProdutos.Name = "DataProdutos"
        Me.DataProdutos.Size = New System.Drawing.Size(800, 125)
        Me.DataProdutos.TabIndex = 21
        '
        'codv
        '
        Me.codv.HeaderText = "CodVendedor"
        Me.codv.Name = "codv"
        '
        'nvend
        '
        Me.nvend.HeaderText = "NºVenda"
        Me.nvend.Name = "nvend"
        '
        'codprod
        '
        Me.codprod.HeaderText = "CodProd"
        Me.codprod.Name = "codprod"
        '
        'desc
        '
        Me.desc.HeaderText = "Descrição"
        Me.desc.Name = "desc"
        '
        'Preco
        '
        Me.Preco.HeaderText = "Preço"
        Me.Preco.Name = "Preco"
        '
        'quant
        '
        Me.quant.HeaderText = "Quantidade"
        Me.quant.Name = "quant"
        '
        'iv
        '
        Me.iv.HeaderText = "Iva"
        Me.iv.Name = "iv"
        Me.iv.Width = 55
        '
        'a_pagar
        '
        Me.a_pagar.HeaderText = "A Pagar"
        Me.a_pagar.Name = "a_pagar"
        '
        'PrecoTotal
        '
        Me.PrecoTotal.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PrecoTotal.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PrecoTotal.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PrecoTotal.BorderThickness = 3
        Me.PrecoTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrecoTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PrecoTotal.ForeColor = System.Drawing.Color.White
        Me.PrecoTotal.isPassword = False
        Me.PrecoTotal.Location = New System.Drawing.Point(633, 482)
        Me.PrecoTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecoTotal.Name = "PrecoTotal"
        Me.PrecoTotal.Size = New System.Drawing.Size(187, 44)
        Me.PrecoTotal.TabIndex = 22
        Me.PrecoTotal.Text = "Total: "
        Me.PrecoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Código Vendedor"
        '
        'codvendedor
        '
        Me.codvendedor.FormattingEnabled = True
        Me.codvendedor.Location = New System.Drawing.Point(155, 87)
        Me.codvendedor.Name = "codvendedor"
        Me.codvendedor.Size = New System.Drawing.Size(153, 21)
        Me.codvendedor.TabIndex = 25
        '
        'Imprimir
        '
        Me.Imprimir.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Imprimir.BorderRadius = 0
        Me.Imprimir.ButtonText = "Imprimir"
        Me.Imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Imprimir.DisabledColor = System.Drawing.Color.Gray
        Me.Imprimir.Iconcolor = System.Drawing.Color.Transparent
        Me.Imprimir.Iconimage = CType(resources.GetObject("Imprimir.Iconimage"), System.Drawing.Image)
        Me.Imprimir.Iconimage_right = Nothing
        Me.Imprimir.Iconimage_right_Selected = Nothing
        Me.Imprimir.Iconimage_Selected = Nothing
        Me.Imprimir.IconMarginLeft = 0
        Me.Imprimir.IconMarginRight = 0
        Me.Imprimir.IconRightVisible = True
        Me.Imprimir.IconRightZoom = 0.0R
        Me.Imprimir.IconVisible = True
        Me.Imprimir.IconZoom = 0.0R
        Me.Imprimir.IsTab = False
        Me.Imprimir.Location = New System.Drawing.Point(512, 482)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Imprimir.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Imprimir.OnHoverTextColor = System.Drawing.Color.White
        Me.Imprimir.selected = False
        Me.Imprimir.Size = New System.Drawing.Size(114, 44)
        Me.Imprimir.TabIndex = 29
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Imprimir.Textcolor = System.Drawing.Color.White
        Me.Imprimir.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'nif
        '
        Me.nif.FormattingEnabled = True
        Me.nif.Location = New System.Drawing.Point(121, 141)
        Me.nif.Name = "nif"
        Me.nif.Size = New System.Drawing.Size(187, 21)
        Me.nif.TabIndex = 31
        '
        'nome_prod
        '
        Me.nome_prod.AutoSize = True
        Me.nome_prod.ForeColor = System.Drawing.SystemColors.Control
        Me.nome_prod.Location = New System.Drawing.Point(343, 224)
        Me.nome_prod.Name = "nome_prod"
        Me.nome_prod.Size = New System.Drawing.Size(0, 13)
        Me.nome_prod.TabIndex = 34
        '
        'AddProduto
        '
        Me.AddProduto.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.AddProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.AddProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddProduto.BorderRadius = 0
        Me.AddProduto.ButtonText = "Adicionar Produto"
        Me.AddProduto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddProduto.DisabledColor = System.Drawing.Color.Gray
        Me.AddProduto.Iconcolor = System.Drawing.Color.Transparent
        Me.AddProduto.Iconimage = CType(resources.GetObject("AddProduto.Iconimage"), System.Drawing.Image)
        Me.AddProduto.Iconimage_right = Nothing
        Me.AddProduto.Iconimage_right_Selected = Nothing
        Me.AddProduto.Iconimage_Selected = Nothing
        Me.AddProduto.IconMarginLeft = 0
        Me.AddProduto.IconMarginRight = 0
        Me.AddProduto.IconRightVisible = True
        Me.AddProduto.IconRightZoom = 0.0R
        Me.AddProduto.IconVisible = True
        Me.AddProduto.IconZoom = 0.0R
        Me.AddProduto.IsTab = False
        Me.AddProduto.Location = New System.Drawing.Point(653, 300)
        Me.AddProduto.Name = "AddProduto"
        Me.AddProduto.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.AddProduto.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.AddProduto.OnHoverTextColor = System.Drawing.Color.White
        Me.AddProduto.selected = False
        Me.AddProduto.Size = New System.Drawing.Size(167, 44)
        Me.AddProduto.TabIndex = 35
        Me.AddProduto.Text = "Adicionar Produto"
        Me.AddProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddProduto.Textcolor = System.Drawing.Color.White
        Me.AddProduto.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'iva
        '
        Me.iva.AutoSize = True
        Me.iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iva.ForeColor = System.Drawing.Color.White
        Me.iva.Location = New System.Drawing.Point(306, 249)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(30, 20)
        Me.iva.TabIndex = 36
        Me.iva.Text = "Iva"
        '
        'iva_to_mudar
        '
        Me.iva_to_mudar.AutoSize = True
        Me.iva_to_mudar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iva_to_mudar.ForeColor = System.Drawing.Color.White
        Me.iva_to_mudar.Location = New System.Drawing.Point(342, 249)
        Me.iva_to_mudar.Name = "iva_to_mudar"
        Me.iva_to_mudar.Size = New System.Drawing.Size(0, 20)
        Me.iva_to_mudar.TabIndex = 37
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(798, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(32, 32)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BunifuImageButton1.TabIndex = 38
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'reg_vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.iva_to_mudar)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.AddProduto)
        Me.Controls.Add(Me.nome_prod)
        Me.Controls.Add(Me.nif)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.codvendedor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PrecoTotal)
        Me.Controls.Add(Me.DataProdutos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.preco_to_mudar)
        Me.Controls.Add(Me.cod_prod)
        Me.Controls.Add(Me.pagamento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.quantidade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nvenda)
        Me.Controls.Add(Me.metronvenda)
        Me.Name = "reg_vendas"
        Me.Size = New System.Drawing.Size(833, 534)
        CType(Me.DataProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents metronvenda As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents nvenda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nome As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents quantidade As System.Windows.Forms.TextBox
    Friend WithEvents pagamento As System.Windows.Forms.ComboBox
    Friend WithEvents cod_prod As System.Windows.Forms.ComboBox
    Friend WithEvents preco_to_mudar As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents PrecoTotal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents codvendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Imprimir As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents nif As System.Windows.Forms.ComboBox
    Friend WithEvents nome_prod As System.Windows.Forms.Label
    Friend WithEvents AddProduto As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents iva As System.Windows.Forms.Label
    Friend WithEvents iva_to_mudar As System.Windows.Forms.Label
    Friend WithEvents codv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nvend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codprod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents a_pagar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton

End Class
