<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regCliente))
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nif = New System.Windows.Forms.TextBox()
        Me.metrocliente = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.morada = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.localidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.telemovel = New System.Windows.Forms.MaskedTextBox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.RadNif = New System.Windows.Forms.RadioButton()
        Me.RadNome = New System.Windows.Forms.RadioButton()
        Me.resultados = New System.Windows.Forms.ComboBox()
        Me.BtnEliminaClientes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cpostal = New System.Windows.Forms.MaskedTextBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Registar Cliente"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(46, 376)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(288, 44)
        Me.BunifuFlatButton1.TabIndex = 53
        Me.BunifuFlatButton1.Text = "Registar Cliente"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nome"
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(150, 115)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(187, 20)
        Me.nome.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(45, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "NIF"
        '
        'nif
        '
        Me.nif.Location = New System.Drawing.Point(150, 89)
        Me.nif.Name = "nif"
        Me.nif.Size = New System.Drawing.Size(187, 20)
        Me.nif.TabIndex = 34
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
        Me.metrocliente.Location = New System.Drawing.Point(46, 35)
        Me.metrocliente.Margin = New System.Windows.Forms.Padding(4)
        Me.metrocliente.Name = "metrocliente"
        Me.metrocliente.Size = New System.Drawing.Size(288, 44)
        Me.metrocliente.TabIndex = 31
        Me.metrocliente.Text = "Registo de Clientes"
        Me.metrocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Morada"
        '
        'morada
        '
        Me.morada.Location = New System.Drawing.Point(150, 141)
        Me.morada.Name = "morada"
        Me.morada.Size = New System.Drawing.Size(187, 20)
        Me.morada.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "CPostal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(42, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Localidade"
        '
        'localidade
        '
        Me.localidade.Location = New System.Drawing.Point(150, 195)
        Me.localidade.Name = "localidade"
        Me.localidade.Size = New System.Drawing.Size(187, 20)
        Me.localidade.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Telemóvel"
        '
        'telemovel
        '
        Me.telemovel.Location = New System.Drawing.Point(150, 221)
        Me.telemovel.Mask = "999000000"
        Me.telemovel.Name = "telemovel"
        Me.telemovel.Size = New System.Drawing.Size(67, 20)
        Me.telemovel.TabIndex = 63
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
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(452, 35)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(288, 44)
        Me.BunifuMetroTextbox1.TabIndex = 64
        Me.BunifuMetroTextbox1.Text = "Pesquisar e Eliminar Clientes"
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadNif
        '
        Me.RadNif.AutoSize = True
        Me.RadNif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNif.ForeColor = System.Drawing.SystemColors.Control
        Me.RadNif.Location = New System.Drawing.Point(516, 89)
        Me.RadNif.Name = "RadNif"
        Me.RadNif.Size = New System.Drawing.Size(53, 24)
        Me.RadNif.TabIndex = 65
        Me.RadNif.TabStop = True
        Me.RadNif.Text = "NIF"
        Me.RadNif.UseVisualStyleBackColor = True
        '
        'RadNome
        '
        Me.RadNome.AutoSize = True
        Me.RadNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNome.ForeColor = System.Drawing.SystemColors.Control
        Me.RadNome.Location = New System.Drawing.Point(614, 89)
        Me.RadNome.Name = "RadNome"
        Me.RadNome.Size = New System.Drawing.Size(74, 24)
        Me.RadNome.TabIndex = 66
        Me.RadNome.TabStop = True
        Me.RadNome.Text = "NOME"
        Me.RadNome.UseVisualStyleBackColor = True
        '
        'resultados
        '
        Me.resultados.FormattingEnabled = True
        Me.resultados.Location = New System.Drawing.Point(506, 119)
        Me.resultados.Name = "resultados"
        Me.resultados.Size = New System.Drawing.Size(172, 21)
        Me.resultados.TabIndex = 67
        '
        'BtnEliminaClientes
        '
        Me.BtnEliminaClientes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnEliminaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnEliminaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminaClientes.BorderRadius = 0
        Me.BtnEliminaClientes.ButtonText = "Eliminar Cliente"
        Me.BtnEliminaClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminaClientes.DisabledColor = System.Drawing.Color.Gray
        Me.BtnEliminaClientes.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnEliminaClientes.Iconimage = CType(resources.GetObject("BtnEliminaClientes.Iconimage"), System.Drawing.Image)
        Me.BtnEliminaClientes.Iconimage_right = Nothing
        Me.BtnEliminaClientes.Iconimage_right_Selected = Nothing
        Me.BtnEliminaClientes.Iconimage_Selected = Nothing
        Me.BtnEliminaClientes.IconMarginLeft = 0
        Me.BtnEliminaClientes.IconMarginRight = 0
        Me.BtnEliminaClientes.IconRightVisible = True
        Me.BtnEliminaClientes.IconRightZoom = 0.0R
        Me.BtnEliminaClientes.IconVisible = True
        Me.BtnEliminaClientes.IconZoom = 0.0R
        Me.BtnEliminaClientes.IsTab = False
        Me.BtnEliminaClientes.Location = New System.Drawing.Point(452, 171)
        Me.BtnEliminaClientes.Name = "BtnEliminaClientes"
        Me.BtnEliminaClientes.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnEliminaClientes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnEliminaClientes.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnEliminaClientes.selected = False
        Me.BtnEliminaClientes.Size = New System.Drawing.Size(288, 44)
        Me.BtnEliminaClientes.TabIndex = 70
        Me.BtnEliminaClientes.Text = "Eliminar Cliente"
        Me.BtnEliminaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEliminaClientes.Textcolor = System.Drawing.Color.White
        Me.BtnEliminaClientes.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cpostal
        '
        Me.cpostal.Location = New System.Drawing.Point(150, 167)
        Me.cpostal.Mask = "0000-999"
        Me.cpostal.Name = "cpostal"
        Me.cpostal.Size = New System.Drawing.Size(52, 20)
        Me.cpostal.TabIndex = 71
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
        Me.BunifuImageButton1.TabIndex = 94
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'regCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.cpostal)
        Me.Controls.Add(Me.BtnEliminaClientes)
        Me.Controls.Add(Me.resultados)
        Me.Controls.Add(Me.RadNome)
        Me.Controls.Add(Me.RadNif)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.telemovel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.localidade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.morada)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nif)
        Me.Controls.Add(Me.metrocliente)
        Me.Name = "regCliente"
        Me.Size = New System.Drawing.Size(833, 534)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nif As System.Windows.Forms.TextBox
    Friend WithEvents metrocliente As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents morada As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents localidade As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents telemovel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents RadNif As System.Windows.Forms.RadioButton
    Friend WithEvents RadNome As System.Windows.Forms.RadioButton
    Friend WithEvents resultados As System.Windows.Forms.ComboBox
    Friend WithEvents BtnEliminaClientes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cpostal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton

End Class
