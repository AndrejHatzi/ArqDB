<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class db_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(db_form))
        Me.Labelcodigo = New System.Windows.Forms.Label()
        Me.Labeldata = New System.Windows.Forms.Label()
        Me.LabelConcelho = New System.Windows.Forms.Label()
        Me.LabelLugar = New System.Windows.Forms.Label()
        Me.LabelPeriodo = New System.Windows.Forms.Label()
        Me.LabelMateriaPrima = New System.Windows.Forms.Label()
        Me.LabelDescricao = New System.Windows.Forms.Label()
        Me.LabelSuporte = New System.Windows.Forms.Label()
        Me.LabelTecnologia = New System.Windows.Forms.Label()
        Me.LabelComprimento = New System.Windows.Forms.Label()
        Me.labelLargura = New System.Windows.Forms.Label()
        Me.labelEspessura = New System.Windows.Forms.Label()
        Me.labelcoordenadas = New System.Windows.Forms.Label()
        Me.labelbibliografia = New System.Windows.Forms.Label()
        Me.DateDate = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.LabelFreguesia = New System.Windows.Forms.Label()
        Me.MateriaPrimaCombo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.PeriodoCombo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.DescricaoCombo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnUpdate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnLocalizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ButtonSettings = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tBoxCodigo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxConcelho = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxLugar = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxSuporte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxFreguesia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxTecnologia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxComprimento = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxLargura = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxEspessura = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxLatitude = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxLongitude = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LblCorIcon = New System.Windows.Forms.Label()
        Me.pBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tBoxLegenda = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tBoxBibliografia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ColourPurple = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ColourOrange = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ColourBlue = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ColourPink = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ColourRed = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ColourSelector = New System.Windows.Forms.Panel()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLocalizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelcodigo
        '
        Me.Labelcodigo.AutoSize = True
        Me.Labelcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcodigo.ForeColor = System.Drawing.SystemColors.Control
        Me.Labelcodigo.Location = New System.Drawing.Point(112, 65)
        Me.Labelcodigo.Name = "Labelcodigo"
        Me.Labelcodigo.Size = New System.Drawing.Size(71, 24)
        Me.Labelcodigo.TabIndex = 3
        Me.Labelcodigo.Text = "Código"
        '
        'Labeldata
        '
        Me.Labeldata.AutoSize = True
        Me.Labeldata.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldata.ForeColor = System.Drawing.SystemColors.Control
        Me.Labeldata.Location = New System.Drawing.Point(520, 65)
        Me.Labeldata.Name = "Labeldata"
        Me.Labeldata.Size = New System.Drawing.Size(47, 24)
        Me.Labeldata.TabIndex = 8
        Me.Labeldata.Text = "Data"
        '
        'LabelConcelho
        '
        Me.LabelConcelho.AutoSize = True
        Me.LabelConcelho.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConcelho.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelConcelho.Location = New System.Drawing.Point(91, 106)
        Me.LabelConcelho.Name = "LabelConcelho"
        Me.LabelConcelho.Size = New System.Drawing.Size(92, 24)
        Me.LabelConcelho.TabIndex = 9
        Me.LabelConcelho.Text = "Concelho"
        '
        'LabelLugar
        '
        Me.LabelLugar.AutoSize = True
        Me.LabelLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLugar.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelLugar.Location = New System.Drawing.Point(125, 149)
        Me.LabelLugar.Name = "LabelLugar"
        Me.LabelLugar.Size = New System.Drawing.Size(58, 24)
        Me.LabelLugar.TabIndex = 11
        Me.LabelLugar.Text = "Lugar"
        '
        'LabelPeriodo
        '
        Me.LabelPeriodo.AutoSize = True
        Me.LabelPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPeriodo.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelPeriodo.Location = New System.Drawing.Point(491, 149)
        Me.LabelPeriodo.Name = "LabelPeriodo"
        Me.LabelPeriodo.Size = New System.Drawing.Size(76, 24)
        Me.LabelPeriodo.TabIndex = 12
        Me.LabelPeriodo.Text = "Periodo"
        '
        'LabelMateriaPrima
        '
        Me.LabelMateriaPrima.AutoSize = True
        Me.LabelMateriaPrima.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMateriaPrima.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelMateriaPrima.Location = New System.Drawing.Point(59, 195)
        Me.LabelMateriaPrima.Name = "LabelMateriaPrima"
        Me.LabelMateriaPrima.Size = New System.Drawing.Size(124, 24)
        Me.LabelMateriaPrima.TabIndex = 13
        Me.LabelMateriaPrima.Text = "Matéria Prima"
        '
        'LabelDescricao
        '
        Me.LabelDescricao.AutoSize = True
        Me.LabelDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescricao.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelDescricao.Location = New System.Drawing.Point(473, 195)
        Me.LabelDescricao.Name = "LabelDescricao"
        Me.LabelDescricao.Size = New System.Drawing.Size(94, 24)
        Me.LabelDescricao.TabIndex = 14
        Me.LabelDescricao.Text = "Descrição"
        '
        'LabelSuporte
        '
        Me.LabelSuporte.AutoSize = True
        Me.LabelSuporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSuporte.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelSuporte.Location = New System.Drawing.Point(100, 239)
        Me.LabelSuporte.Name = "LabelSuporte"
        Me.LabelSuporte.Size = New System.Drawing.Size(76, 24)
        Me.LabelSuporte.TabIndex = 15
        Me.LabelSuporte.Text = "Suporte"
        '
        'LabelTecnologia
        '
        Me.LabelTecnologia.AutoSize = True
        Me.LabelTecnologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTecnologia.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelTecnologia.Location = New System.Drawing.Point(462, 239)
        Me.LabelTecnologia.Name = "LabelTecnologia"
        Me.LabelTecnologia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelTecnologia.Size = New System.Drawing.Size(105, 24)
        Me.LabelTecnologia.TabIndex = 16
        Me.LabelTecnologia.Text = "Tecnologia"
        '
        'LabelComprimento
        '
        Me.LabelComprimento.AutoSize = True
        Me.LabelComprimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComprimento.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelComprimento.Location = New System.Drawing.Point(77, 332)
        Me.LabelComprimento.Name = "LabelComprimento"
        Me.LabelComprimento.Size = New System.Drawing.Size(124, 24)
        Me.LabelComprimento.TabIndex = 17
        Me.LabelComprimento.Text = "Comprimento"
        '
        'labelLargura
        '
        Me.labelLargura.AutoSize = True
        Me.labelLargura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLargura.ForeColor = System.Drawing.SystemColors.Control
        Me.labelLargura.Location = New System.Drawing.Point(301, 332)
        Me.labelLargura.Name = "labelLargura"
        Me.labelLargura.Size = New System.Drawing.Size(74, 24)
        Me.labelLargura.TabIndex = 18
        Me.labelLargura.Text = "Largura"
        '
        'labelEspessura
        '
        Me.labelEspessura.AutoSize = True
        Me.labelEspessura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEspessura.ForeColor = System.Drawing.SystemColors.Control
        Me.labelEspessura.Location = New System.Drawing.Point(475, 332)
        Me.labelEspessura.Name = "labelEspessura"
        Me.labelEspessura.Size = New System.Drawing.Size(99, 24)
        Me.labelEspessura.TabIndex = 19
        Me.labelEspessura.Text = "Espessura"
        '
        'labelcoordenadas
        '
        Me.labelcoordenadas.AutoSize = True
        Me.labelcoordenadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcoordenadas.ForeColor = System.Drawing.SystemColors.Control
        Me.labelcoordenadas.Location = New System.Drawing.Point(77, 391)
        Me.labelcoordenadas.Name = "labelcoordenadas"
        Me.labelcoordenadas.Size = New System.Drawing.Size(124, 24)
        Me.labelcoordenadas.TabIndex = 20
        Me.labelcoordenadas.Text = "Coordenadas"
        '
        'labelbibliografia
        '
        Me.labelbibliografia.AutoSize = True
        Me.labelbibliografia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbibliografia.ForeColor = System.Drawing.SystemColors.Control
        Me.labelbibliografia.Location = New System.Drawing.Point(93, 526)
        Me.labelbibliografia.Name = "labelbibliografia"
        Me.labelbibliografia.Size = New System.Drawing.Size(101, 24)
        Me.labelbibliografia.TabIndex = 22
        Me.labelbibliografia.Text = "Bibliografia"
        '
        'DateDate
        '
        Me.DateDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DateDate.BorderRadius = 0
        Me.DateDate.ForeColor = System.Drawing.Color.White
        Me.DateDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateDate.FormatCustom = Nothing
        Me.DateDate.Location = New System.Drawing.Point(573, 45)
        Me.DateDate.Name = "DateDate"
        Me.DateDate.Size = New System.Drawing.Size(209, 45)
        Me.DateDate.TabIndex = 23
        Me.DateDate.Value = New Date(2019, 5, 17, 11, 29, 19, 959)
        '
        'LabelFreguesia
        '
        Me.LabelFreguesia.AutoSize = True
        Me.LabelFreguesia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFreguesia.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelFreguesia.Location = New System.Drawing.Point(472, 106)
        Me.LabelFreguesia.Name = "LabelFreguesia"
        Me.LabelFreguesia.Size = New System.Drawing.Size(95, 24)
        Me.LabelFreguesia.TabIndex = 29
        Me.LabelFreguesia.Text = "Freguesia"
        '
        'MateriaPrimaCombo
        '
        Me.MateriaPrimaCombo.BackColor = System.Drawing.Color.Transparent
        Me.MateriaPrimaCombo.BorderRadius = 3
        Me.MateriaPrimaCombo.DisabledColor = System.Drawing.Color.Gray
        Me.MateriaPrimaCombo.ForeColor = System.Drawing.Color.White
        Me.MateriaPrimaCombo.Items = New String() {"Quartzo", "Quartzo Hialino", "Quartzo Leitoso", "Quartzito", "Sílex", "Granito", "Xisto", "Calcário", "Obsidiana"}
        Me.MateriaPrimaCombo.Location = New System.Drawing.Point(189, 197)
        Me.MateriaPrimaCombo.Name = "MateriaPrimaCombo"
        Me.MateriaPrimaCombo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MateriaPrimaCombo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MateriaPrimaCombo.selectedIndex = -1
        Me.MateriaPrimaCombo.Size = New System.Drawing.Size(185, 22)
        Me.MateriaPrimaCombo.TabIndex = 33
        '
        'PeriodoCombo
        '
        Me.PeriodoCombo.BackColor = System.Drawing.Color.Transparent
        Me.PeriodoCombo.BorderRadius = 3
        Me.PeriodoCombo.DisabledColor = System.Drawing.Color.Gray
        Me.PeriodoCombo.ForeColor = System.Drawing.Color.White
        Me.PeriodoCombo.Items = New String() {"Alta Idade Média", "Baixa Idade Média", "Calcolítico", "Contemporâneo", "Epipaleolítico", "Idade Média", "Idade do Bronze", "Idade do Ferro", "Medieval Cristão", "Medieval Islâmico", "Mesolítico", "Moderno", "Neolítico", "Paleolítico", "Paleolítico Inferior", "Paleolítico Médio", "Paleolítico Superior", "Romano", "Indeterminado"}
        Me.PeriodoCombo.Location = New System.Drawing.Point(573, 149)
        Me.PeriodoCombo.Name = "PeriodoCombo"
        Me.PeriodoCombo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PeriodoCombo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PeriodoCombo.selectedIndex = -1
        Me.PeriodoCombo.Size = New System.Drawing.Size(186, 22)
        Me.PeriodoCombo.TabIndex = 44
        '
        'DescricaoCombo
        '
        Me.DescricaoCombo.BackColor = System.Drawing.Color.Transparent
        Me.DescricaoCombo.BorderRadius = 3
        Me.DescricaoCombo.DisabledColor = System.Drawing.Color.Gray
        Me.DescricaoCombo.ForeColor = System.Drawing.Color.White
        Me.DescricaoCombo.Items = New String() {"Lasca", "Seixo Talhado", "Núcleo", "Movente", "Resto de Talhe", "Esquírola", "Indeterminado"}
        Me.DescricaoCombo.Location = New System.Drawing.Point(574, 195)
        Me.DescricaoCombo.Name = "DescricaoCombo"
        Me.DescricaoCombo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DescricaoCombo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DescricaoCombo.selectedIndex = -1
        Me.DescricaoCombo.Size = New System.Drawing.Size(185, 22)
        Me.DescricaoCombo.TabIndex = 45
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageActive = Nothing
        Me.BtnSave.Location = New System.Drawing.Point(848, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(44, 47)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnSave.TabIndex = 62
        Me.BtnSave.TabStop = False
        Me.BtnSave.Zoom = 20
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnUpdate.Image = CType(resources.GetObject("BtnUpdate.Image"), System.Drawing.Image)
        Me.BtnUpdate.ImageActive = Nothing
        Me.BtnUpdate.Location = New System.Drawing.Point(848, 56)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(44, 47)
        Me.BtnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnUpdate.TabIndex = 63
        Me.BtnUpdate.TabStop = False
        Me.BtnUpdate.Zoom = 20
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageActive = Nothing
        Me.BtnDelete.Location = New System.Drawing.Point(848, 109)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(44, 47)
        Me.BtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnDelete.TabIndex = 64
        Me.BtnDelete.TabStop = False
        Me.BtnDelete.Zoom = 20
        '
        'BtnLocalizar
        '
        Me.BtnLocalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnLocalizar.Image = CType(resources.GetObject("BtnLocalizar.Image"), System.Drawing.Image)
        Me.BtnLocalizar.ImageActive = Nothing
        Me.BtnLocalizar.Location = New System.Drawing.Point(848, 162)
        Me.BtnLocalizar.Name = "BtnLocalizar"
        Me.BtnLocalizar.Size = New System.Drawing.Size(44, 47)
        Me.BtnLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnLocalizar.TabIndex = 65
        Me.BtnLocalizar.TabStop = False
        Me.BtnLocalizar.Zoom = 20
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ButtonSettings.Image = CType(resources.GetObject("ButtonSettings.Image"), System.Drawing.Image)
        Me.ButtonSettings.ImageActive = Nothing
        Me.ButtonSettings.Location = New System.Drawing.Point(848, 215)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(44, 47)
        Me.ButtonSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonSettings.TabIndex = 66
        Me.ButtonSettings.TabStop = False
        Me.ButtonSettings.Zoom = 20
        '
        'tBoxCodigo
        '
        Me.tBoxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxCodigo.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxCodigo.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxCodigo.HintText = ""
        Me.tBoxCodigo.isPassword = False
        Me.tBoxCodigo.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxCodigo.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxCodigo.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxCodigo.LineThickness = 3
        Me.tBoxCodigo.Location = New System.Drawing.Point(189, 56)
        Me.tBoxCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxCodigo.Name = "tBoxCodigo"
        Me.tBoxCodigo.Size = New System.Drawing.Size(185, 31)
        Me.tBoxCodigo.TabIndex = 67
        Me.tBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxConcelho
        '
        Me.tBoxConcelho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxConcelho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxConcelho.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxConcelho.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxConcelho.HintText = ""
        Me.tBoxConcelho.isPassword = False
        Me.tBoxConcelho.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxConcelho.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxConcelho.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxConcelho.LineThickness = 3
        Me.tBoxConcelho.Location = New System.Drawing.Point(190, 99)
        Me.tBoxConcelho.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxConcelho.Name = "tBoxConcelho"
        Me.tBoxConcelho.Size = New System.Drawing.Size(185, 31)
        Me.tBoxConcelho.TabIndex = 69
        Me.tBoxConcelho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxLugar
        '
        Me.tBoxLugar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxLugar.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLugar.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLugar.HintText = ""
        Me.tBoxLugar.isPassword = False
        Me.tBoxLugar.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxLugar.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxLugar.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxLugar.LineThickness = 3
        Me.tBoxLugar.Location = New System.Drawing.Point(190, 142)
        Me.tBoxLugar.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxLugar.Name = "tBoxLugar"
        Me.tBoxLugar.Size = New System.Drawing.Size(185, 31)
        Me.tBoxLugar.TabIndex = 70
        Me.tBoxLugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxSuporte
        '
        Me.tBoxSuporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxSuporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxSuporte.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxSuporte.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxSuporte.HintText = ""
        Me.tBoxSuporte.isPassword = False
        Me.tBoxSuporte.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxSuporte.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxSuporte.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxSuporte.LineThickness = 3
        Me.tBoxSuporte.Location = New System.Drawing.Point(189, 232)
        Me.tBoxSuporte.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxSuporte.Name = "tBoxSuporte"
        Me.tBoxSuporte.Size = New System.Drawing.Size(185, 31)
        Me.tBoxSuporte.TabIndex = 71
        Me.tBoxSuporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxFreguesia
        '
        Me.tBoxFreguesia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxFreguesia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxFreguesia.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxFreguesia.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxFreguesia.HintText = ""
        Me.tBoxFreguesia.isPassword = False
        Me.tBoxFreguesia.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxFreguesia.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxFreguesia.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxFreguesia.LineThickness = 3
        Me.tBoxFreguesia.Location = New System.Drawing.Point(574, 97)
        Me.tBoxFreguesia.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxFreguesia.Name = "tBoxFreguesia"
        Me.tBoxFreguesia.Size = New System.Drawing.Size(185, 31)
        Me.tBoxFreguesia.TabIndex = 72
        Me.tBoxFreguesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxTecnologia
        '
        Me.tBoxTecnologia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxTecnologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxTecnologia.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxTecnologia.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxTecnologia.HintText = ""
        Me.tBoxTecnologia.isPassword = False
        Me.tBoxTecnologia.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxTecnologia.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxTecnologia.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxTecnologia.LineThickness = 3
        Me.tBoxTecnologia.Location = New System.Drawing.Point(574, 232)
        Me.tBoxTecnologia.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxTecnologia.Name = "tBoxTecnologia"
        Me.tBoxTecnologia.Size = New System.Drawing.Size(185, 31)
        Me.tBoxTecnologia.TabIndex = 73
        Me.tBoxTecnologia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxComprimento
        '
        Me.tBoxComprimento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxComprimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxComprimento.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxComprimento.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxComprimento.HintText = ""
        Me.tBoxComprimento.isPassword = False
        Me.tBoxComprimento.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxComprimento.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxComprimento.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxComprimento.LineThickness = 3
        Me.tBoxComprimento.Location = New System.Drawing.Point(199, 325)
        Me.tBoxComprimento.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxComprimento.Name = "tBoxComprimento"
        Me.tBoxComprimento.Size = New System.Drawing.Size(86, 31)
        Me.tBoxComprimento.TabIndex = 74
        Me.tBoxComprimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxLargura
        '
        Me.tBoxLargura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxLargura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxLargura.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLargura.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLargura.HintText = ""
        Me.tBoxLargura.isPassword = False
        Me.tBoxLargura.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxLargura.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxLargura.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxLargura.LineThickness = 3
        Me.tBoxLargura.Location = New System.Drawing.Point(372, 325)
        Me.tBoxLargura.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxLargura.Name = "tBoxLargura"
        Me.tBoxLargura.Size = New System.Drawing.Size(86, 31)
        Me.tBoxLargura.TabIndex = 75
        Me.tBoxLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxEspessura
        '
        Me.tBoxEspessura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxEspessura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxEspessura.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxEspessura.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxEspessura.HintText = ""
        Me.tBoxEspessura.isPassword = False
        Me.tBoxEspessura.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxEspessura.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxEspessura.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxEspessura.LineThickness = 3
        Me.tBoxEspessura.Location = New System.Drawing.Point(574, 325)
        Me.tBoxEspessura.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxEspessura.Name = "tBoxEspessura"
        Me.tBoxEspessura.Size = New System.Drawing.Size(86, 31)
        Me.tBoxEspessura.TabIndex = 76
        Me.tBoxEspessura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxLatitude
        '
        Me.tBoxLatitude.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxLatitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxLatitude.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLatitude.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLatitude.HintText = ""
        Me.tBoxLatitude.isPassword = False
        Me.tBoxLatitude.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxLatitude.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxLatitude.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxLatitude.LineThickness = 3
        Me.tBoxLatitude.Location = New System.Drawing.Point(201, 384)
        Me.tBoxLatitude.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxLatitude.Name = "tBoxLatitude"
        Me.tBoxLatitude.Size = New System.Drawing.Size(84, 31)
        Me.tBoxLatitude.TabIndex = 77
        Me.tBoxLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxLongitude
        '
        Me.tBoxLongitude.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxLongitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxLongitude.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLongitude.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLongitude.HintText = ""
        Me.tBoxLongitude.isPassword = False
        Me.tBoxLongitude.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxLongitude.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxLongitude.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxLongitude.LineThickness = 3
        Me.tBoxLongitude.Location = New System.Drawing.Point(293, 384)
        Me.tBoxLongitude.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxLongitude.Name = "tBoxLongitude"
        Me.tBoxLongitude.Size = New System.Drawing.Size(86, 31)
        Me.tBoxLongitude.TabIndex = 78
        Me.tBoxLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LblCorIcon
        '
        Me.LblCorIcon.AutoSize = True
        Me.LblCorIcon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorIcon.ForeColor = System.Drawing.SystemColors.Control
        Me.LblCorIcon.Location = New System.Drawing.Point(87, 449)
        Me.LblCorIcon.Name = "LblCorIcon"
        Me.LblCorIcon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCorIcon.Size = New System.Drawing.Size(108, 24)
        Me.LblCorIcon.TabIndex = 80
        Me.LblCorIcon.Text = "Cor do Icon"
        '
        'pBox
        '
        Me.pBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pBox.Location = New System.Drawing.Point(541, 391)
        Me.pBox.Name = "pBox"
        Me.pBox.Size = New System.Drawing.Size(241, 160)
        Me.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBox.TabIndex = 81
        Me.pBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(109, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Legenda"
        '
        'tBoxLegenda
        '
        Me.tBoxLegenda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxLegenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxLegenda.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLegenda.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxLegenda.HintText = ""
        Me.tBoxLegenda.isPassword = False
        Me.tBoxLegenda.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxLegenda.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxLegenda.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxLegenda.LineThickness = 3
        Me.tBoxLegenda.Location = New System.Drawing.Point(201, 480)
        Me.tBoxLegenda.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxLegenda.Name = "tBoxLegenda"
        Me.tBoxLegenda.Size = New System.Drawing.Size(185, 31)
        Me.tBoxLegenda.TabIndex = 83
        Me.tBoxLegenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tBoxBibliografia
        '
        Me.tBoxBibliografia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxBibliografia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxBibliografia.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxBibliografia.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxBibliografia.HintText = ""
        Me.tBoxBibliografia.isPassword = False
        Me.tBoxBibliografia.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxBibliografia.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxBibliografia.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxBibliografia.LineThickness = 3
        Me.tBoxBibliografia.Location = New System.Drawing.Point(201, 519)
        Me.tBoxBibliografia.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxBibliografia.Name = "tBoxBibliografia"
        Me.tBoxBibliografia.Size = New System.Drawing.Size(185, 31)
        Me.tBoxBibliografia.TabIndex = 84
        Me.tBoxBibliografia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ColourPurple
        '
        Me.ColourPurple.BackColor = System.Drawing.Color.Purple
        Me.ColourPurple.color = System.Drawing.Color.Purple
        Me.ColourPurple.colorActive = System.Drawing.Color.Purple
        Me.ColourPurple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColourPurple.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ColourPurple.ForeColor = System.Drawing.Color.White
        Me.ColourPurple.Image = CType(resources.GetObject("ColourPurple.Image"), System.Drawing.Image)
        Me.ColourPurple.ImagePosition = 20
        Me.ColourPurple.ImageZoom = 0
        Me.ColourPurple.LabelPosition = 41
        Me.ColourPurple.LabelText = ""
        Me.ColourPurple.Location = New System.Drawing.Point(236, 449)
        Me.ColourPurple.Margin = New System.Windows.Forms.Padding(6)
        Me.ColourPurple.Name = "ColourPurple"
        Me.ColourPurple.Size = New System.Drawing.Size(24, 24)
        Me.ColourPurple.TabIndex = 85
        '
        'ColourOrange
        '
        Me.ColourOrange.BackColor = System.Drawing.Color.Orange
        Me.ColourOrange.color = System.Drawing.Color.Orange
        Me.ColourOrange.colorActive = System.Drawing.Color.Orange
        Me.ColourOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColourOrange.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ColourOrange.ForeColor = System.Drawing.Color.White
        Me.ColourOrange.Image = CType(resources.GetObject("ColourOrange.Image"), System.Drawing.Image)
        Me.ColourOrange.ImagePosition = 20
        Me.ColourOrange.ImageZoom = 0
        Me.ColourOrange.LabelPosition = 41
        Me.ColourOrange.LabelText = ""
        Me.ColourOrange.Location = New System.Drawing.Point(303, 449)
        Me.ColourOrange.Margin = New System.Windows.Forms.Padding(6)
        Me.ColourOrange.Name = "ColourOrange"
        Me.ColourOrange.Size = New System.Drawing.Size(24, 24)
        Me.ColourOrange.TabIndex = 86
        '
        'ColourBlue
        '
        Me.ColourBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ColourBlue.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ColourBlue.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ColourBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColourBlue.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ColourBlue.ForeColor = System.Drawing.Color.White
        Me.ColourBlue.Image = CType(resources.GetObject("ColourBlue.Image"), System.Drawing.Image)
        Me.ColourBlue.ImagePosition = 20
        Me.ColourBlue.ImageZoom = 0
        Me.ColourBlue.LabelPosition = 41
        Me.ColourBlue.LabelText = ""
        Me.ColourBlue.Location = New System.Drawing.Point(339, 449)
        Me.ColourBlue.Margin = New System.Windows.Forms.Padding(6)
        Me.ColourBlue.Name = "ColourBlue"
        Me.ColourBlue.Size = New System.Drawing.Size(24, 24)
        Me.ColourBlue.TabIndex = 87
        '
        'ColourPink
        '
        Me.ColourPink.BackColor = System.Drawing.Color.Pink
        Me.ColourPink.color = System.Drawing.Color.Pink
        Me.ColourPink.colorActive = System.Drawing.Color.Pink
        Me.ColourPink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColourPink.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ColourPink.ForeColor = System.Drawing.Color.White
        Me.ColourPink.Image = CType(resources.GetObject("ColourPink.Image"), System.Drawing.Image)
        Me.ColourPink.ImagePosition = 20
        Me.ColourPink.ImageZoom = 0
        Me.ColourPink.LabelPosition = 41
        Me.ColourPink.LabelText = ""
        Me.ColourPink.Location = New System.Drawing.Point(204, 449)
        Me.ColourPink.Margin = New System.Windows.Forms.Padding(6)
        Me.ColourPink.Name = "ColourPink"
        Me.ColourPink.Size = New System.Drawing.Size(24, 24)
        Me.ColourPink.TabIndex = 88
        '
        'ColourRed
        '
        Me.ColourRed.BackColor = System.Drawing.Color.Red
        Me.ColourRed.color = System.Drawing.Color.Red
        Me.ColourRed.colorActive = System.Drawing.Color.Red
        Me.ColourRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColourRed.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ColourRed.ForeColor = System.Drawing.Color.White
        Me.ColourRed.Image = CType(resources.GetObject("ColourRed.Image"), System.Drawing.Image)
        Me.ColourRed.ImagePosition = 20
        Me.ColourRed.ImageZoom = 0
        Me.ColourRed.LabelPosition = 41
        Me.ColourRed.LabelText = ""
        Me.ColourRed.Location = New System.Drawing.Point(268, 449)
        Me.ColourRed.Margin = New System.Windows.Forms.Padding(6)
        Me.ColourRed.Name = "ColourRed"
        Me.ColourRed.Size = New System.Drawing.Size(24, 24)
        Me.ColourRed.TabIndex = 89
        '
        'ColourSelector
        '
        Me.ColourSelector.BackColor = System.Drawing.Color.White
        Me.ColourSelector.Location = New System.Drawing.Point(339, 430)
        Me.ColourSelector.Name = "ColourSelector"
        Me.ColourSelector.Size = New System.Drawing.Size(24, 10)
        Me.ColourSelector.TabIndex = 90
        '
        'db_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.ColourSelector)
        Me.Controls.Add(Me.ColourRed)
        Me.Controls.Add(Me.ColourPink)
        Me.Controls.Add(Me.ColourBlue)
        Me.Controls.Add(Me.ColourOrange)
        Me.Controls.Add(Me.ColourPurple)
        Me.Controls.Add(Me.tBoxBibliografia)
        Me.Controls.Add(Me.tBoxLegenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pBox)
        Me.Controls.Add(Me.LblCorIcon)
        Me.Controls.Add(Me.tBoxLongitude)
        Me.Controls.Add(Me.tBoxLatitude)
        Me.Controls.Add(Me.tBoxEspessura)
        Me.Controls.Add(Me.tBoxLargura)
        Me.Controls.Add(Me.tBoxComprimento)
        Me.Controls.Add(Me.tBoxTecnologia)
        Me.Controls.Add(Me.tBoxFreguesia)
        Me.Controls.Add(Me.tBoxSuporte)
        Me.Controls.Add(Me.tBoxLugar)
        Me.Controls.Add(Me.tBoxConcelho)
        Me.Controls.Add(Me.tBoxCodigo)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.BtnLocalizar)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DescricaoCombo)
        Me.Controls.Add(Me.PeriodoCombo)
        Me.Controls.Add(Me.MateriaPrimaCombo)
        Me.Controls.Add(Me.LabelFreguesia)
        Me.Controls.Add(Me.DateDate)
        Me.Controls.Add(Me.labelbibliografia)
        Me.Controls.Add(Me.labelcoordenadas)
        Me.Controls.Add(Me.labelEspessura)
        Me.Controls.Add(Me.labelLargura)
        Me.Controls.Add(Me.LabelComprimento)
        Me.Controls.Add(Me.LabelTecnologia)
        Me.Controls.Add(Me.LabelSuporte)
        Me.Controls.Add(Me.LabelDescricao)
        Me.Controls.Add(Me.LabelMateriaPrima)
        Me.Controls.Add(Me.LabelPeriodo)
        Me.Controls.Add(Me.LabelLugar)
        Me.Controls.Add(Me.LabelConcelho)
        Me.Controls.Add(Me.Labeldata)
        Me.Controls.Add(Me.Labelcodigo)
        Me.Name = "db_form"
        Me.Size = New System.Drawing.Size(895, 600)
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLocalizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labelcodigo As System.Windows.Forms.Label
    Friend WithEvents Labeldata As System.Windows.Forms.Label
    Friend WithEvents LabelConcelho As System.Windows.Forms.Label
    Friend WithEvents LabelLugar As System.Windows.Forms.Label
    Friend WithEvents LabelPeriodo As System.Windows.Forms.Label
    Friend WithEvents LabelMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents LabelDescricao As System.Windows.Forms.Label
    Friend WithEvents LabelSuporte As System.Windows.Forms.Label
    Friend WithEvents LabelTecnologia As System.Windows.Forms.Label
    Friend WithEvents LabelComprimento As System.Windows.Forms.Label
    Friend WithEvents labelLargura As System.Windows.Forms.Label
    Friend WithEvents labelEspessura As System.Windows.Forms.Label
    Friend WithEvents labelcoordenadas As System.Windows.Forms.Label
    Friend WithEvents labelbibliografia As System.Windows.Forms.Label
    Friend WithEvents DateDate As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents LabelFreguesia As System.Windows.Forms.Label
    Friend WithEvents MateriaPrimaCombo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents PeriodoCombo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents DescricaoCombo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnDelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnLocalizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ButtonSettings As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tBoxCodigo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxConcelho As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxLugar As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxSuporte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxFreguesia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxTecnologia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxComprimento As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxLargura As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxEspessura As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxLatitude As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxLongitude As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LblCorIcon As System.Windows.Forms.Label
    Friend WithEvents pBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tBoxLegenda As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tBoxBibliografia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ColourPurple As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ColourOrange As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ColourBlue As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ColourPink As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ColourRed As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ColourSelector As System.Windows.Forms.Panel

End Class
