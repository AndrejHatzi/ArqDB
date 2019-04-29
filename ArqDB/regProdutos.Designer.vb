<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regProdutos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unidade = New System.Windows.Forms.TextBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.descricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.codprod = New System.Windows.Forms.TextBox()
        Me.metrocliente = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.preco = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.stockmin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.stock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.iva = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.RadNome = New System.Windows.Forms.RadioButton()
        Me.RadNif = New System.Windows.Forms.RadioButton()
        Me.BtnPesquisarProduto = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.resultados = New System.Windows.Forms.ComboBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Unidade"
        '
        'unidade
        '
        Me.unidade.Location = New System.Drawing.Point(187, 154)
        Me.unidade.Name = "unidade"
        Me.unidade.Size = New System.Drawing.Size(46, 20)
        Me.unidade.TabIndex = 70
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Registar Produto"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 0.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(63, 398)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(316, 44)
        Me.BunifuFlatButton1.TabIndex = 69
        Me.BunifuFlatButton1.Text = "Registar Produto"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(426, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Descrição"
        '
        'descricao
        '
        Me.descricao.Location = New System.Drawing.Point(522, 109)
        Me.descricao.Multiline = True
        Me.descricao.Name = "descricao"
        Me.descricao.Size = New System.Drawing.Size(197, 100)
        Me.descricao.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Código Produto"
        '
        'codprod
        '
        Me.codprod.Location = New System.Drawing.Point(187, 111)
        Me.codprod.Name = "codprod"
        Me.codprod.Size = New System.Drawing.Size(187, 20)
        Me.codprod.TabIndex = 65
        '
        'metrocliente
        '
        Me.metrocliente.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.metrocliente.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.metrocliente.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.metrocliente.BorderThickness = 3
        Me.metrocliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.metrocliente.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.metrocliente.ForeColor = System.Drawing.Color.White
        Me.metrocliente.isPassword = False
        Me.metrocliente.Location = New System.Drawing.Point(63, 57)
        Me.metrocliente.Margin = New System.Windows.Forms.Padding(4)
        Me.metrocliente.Name = "metrocliente"
        Me.metrocliente.Size = New System.Drawing.Size(288, 44)
        Me.metrocliente.TabIndex = 64
        Me.metrocliente.Text = "Registo de Produtos"
        Me.metrocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(112, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Preço"
        '
        'preco
        '
        Me.preco.Location = New System.Drawing.Point(187, 191)
        Me.preco.Name = "preco"
        Me.preco.Size = New System.Drawing.Size(99, 20)
        Me.preco.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(301, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "€"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(77, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Stock Mínimo"
        '
        'stockmin
        '
        Me.stockmin.Location = New System.Drawing.Point(187, 231)
        Me.stockmin.Name = "stockmin"
        Me.stockmin.Size = New System.Drawing.Size(99, 20)
        Me.stockmin.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(131, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Stock"
        '
        'stock
        '
        Me.stock.Location = New System.Drawing.Point(187, 267)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(99, 20)
        Me.stock.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(151, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Iva"
        '
        'iva
        '
        Me.iva.Location = New System.Drawing.Point(187, 303)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(46, 20)
        Me.iva.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(248, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 20)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "%"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(430, 231)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(288, 44)
        Me.BunifuMetroTextbox1.TabIndex = 88
        Me.BunifuMetroTextbox1.Text = "Pesquisar Produtos"
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadNome
        '
        Me.RadNome.AutoSize = True
        Me.RadNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNome.ForeColor = System.Drawing.SystemColors.Control
        Me.RadNome.Location = New System.Drawing.Point(593, 282)
        Me.RadNome.Name = "RadNome"
        Me.RadNome.Size = New System.Drawing.Size(74, 24)
        Me.RadNome.TabIndex = 90
        Me.RadNome.TabStop = True
        Me.RadNome.Text = "NOME"
        Me.RadNome.UseVisualStyleBackColor = True
        '
        'RadNif
        '
        Me.RadNif.AutoSize = True
        Me.RadNif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNif.ForeColor = System.Drawing.SystemColors.Control
        Me.RadNif.Location = New System.Drawing.Point(470, 282)
        Me.RadNif.Name = "RadNif"
        Me.RadNif.Size = New System.Drawing.Size(108, 24)
        Me.RadNif.TabIndex = 89
        Me.RadNif.TabStop = True
        Me.RadNif.Text = "CODPROD"
        Me.RadNif.UseVisualStyleBackColor = True
        '
        'BtnPesquisarProduto
        '
        Me.BtnPesquisarProduto.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnPesquisarProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPesquisarProduto.BorderRadius = 0
        Me.BtnPesquisarProduto.ButtonText = "Pesquisar Produto"
        Me.BtnPesquisarProduto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPesquisarProduto.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPesquisarProduto.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPesquisarProduto.Iconimage = CType(resources.GetObject("BtnPesquisarProduto.Iconimage"), System.Drawing.Image)
        Me.BtnPesquisarProduto.Iconimage_right = Nothing
        Me.BtnPesquisarProduto.Iconimage_right_Selected = Nothing
        Me.BtnPesquisarProduto.Iconimage_Selected = Nothing
        Me.BtnPesquisarProduto.IconMarginLeft = 0
        Me.BtnPesquisarProduto.IconMarginRight = 0
        Me.BtnPesquisarProduto.IconRightVisible = True
        Me.BtnPesquisarProduto.IconRightZoom = 0.0R
        Me.BtnPesquisarProduto.IconVisible = True
        Me.BtnPesquisarProduto.IconZoom = 0.0R
        Me.BtnPesquisarProduto.IsTab = False
        Me.BtnPesquisarProduto.Location = New System.Drawing.Point(430, 398)
        Me.BtnPesquisarProduto.Name = "BtnPesquisarProduto"
        Me.BtnPesquisarProduto.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnPesquisarProduto.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnPesquisarProduto.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPesquisarProduto.selected = False
        Me.BtnPesquisarProduto.Size = New System.Drawing.Size(288, 44)
        Me.BtnPesquisarProduto.TabIndex = 91
        Me.BtnPesquisarProduto.Text = "Pesquisar Produto"
        Me.BtnPesquisarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPesquisarProduto.Textcolor = System.Drawing.Color.White
        Me.BtnPesquisarProduto.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'resultados
        '
        Me.resultados.FormattingEnabled = True
        Me.resultados.Location = New System.Drawing.Point(470, 324)
        Me.resultados.Name = "resultados"
        Me.resultados.Size = New System.Drawing.Size(197, 21)
        Me.resultados.TabIndex = 92
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(798, 499)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(32, 32)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BunifuImageButton1.TabIndex = 93
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'regProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.resultados)
        Me.Controls.Add(Me.BtnPesquisarProduto)
        Me.Controls.Add(Me.RadNome)
        Me.Controls.Add(Me.RadNif)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.stock)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.stockmin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.preco)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.unidade)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.descricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codprod)
        Me.Controls.Add(Me.metrocliente)
        Me.Name = "regProdutos"
        Me.Size = New System.Drawing.Size(833, 534)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents unidade As System.Windows.Forms.TextBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents descricao As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codprod As System.Windows.Forms.TextBox
    Friend WithEvents metrocliente As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents preco As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents stockmin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents stock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents iva As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents RadNome As System.Windows.Forms.RadioButton
    Friend WithEvents RadNif As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPesquisarProduto As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents resultados As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton

End Class
