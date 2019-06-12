<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnMaximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelHomeOne = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnBD = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDetetor = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnMapStudio = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnOptions = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BtnAbout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelHomeTwo = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PanelHomeExpanded = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnBDSmall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDetetorSmall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnMapStudioSmall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnOptionsSmall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAboutSmall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnHomeSmall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SelectorPanel = New System.Windows.Forms.Panel()
        Me.Mapstudio1 = New ArqDB.mapstudio()
        Me.Db_form1 = New ArqDB.db_form()
        Me.Options1 = New ArqDB.options()
        Me.header.SuspendLayout()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BtnMenu)
        Me.header.Controls.Add(Me.Panel1)
        Me.header.Controls.Add(Me.BtnClose)
        Me.header.Controls.Add(Me.BtnMaximize)
        Me.header.Controls.Add(Me.BtnMinimize)
        Me.header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Quality = 10
        Me.header.Size = New System.Drawing.Size(900, 32)
        Me.header.TabIndex = 0
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.Transparent
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.ImageActive = Nothing
        Me.BtnMenu.Location = New System.Drawing.Point(12, 10)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(16, 16)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMenu.TabIndex = 9
        Me.BtnMenu.TabStop = False
        Me.BtnMenu.Zoom = 40
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(36, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 32)
        Me.Panel1.TabIndex = 7
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageActive = Nothing
        Me.BtnClose.Location = New System.Drawing.Point(856, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(41, 37)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.TabStop = False
        Me.BtnClose.Zoom = 10
        '
        'BtnMaximize
        '
        Me.BtnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.BtnMaximize.Image = CType(resources.GetObject("BtnMaximize.Image"), System.Drawing.Image)
        Me.BtnMaximize.ImageActive = Nothing
        Me.BtnMaximize.Location = New System.Drawing.Point(809, 0)
        Me.BtnMaximize.Name = "BtnMaximize"
        Me.BtnMaximize.Size = New System.Drawing.Size(41, 37)
        Me.BtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnMaximize.TabIndex = 10
        Me.BtnMaximize.TabStop = False
        Me.BtnMaximize.Zoom = 10
        '
        'BtnMinimize
        '
        Me.BtnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.ImageActive = Nothing
        Me.BtnMinimize.Location = New System.Drawing.Point(762, 0)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(41, 37)
        Me.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnMinimize.TabIndex = 9
        Me.BtnMinimize.TabStop = False
        Me.BtnMinimize.Zoom = 10
        '
        'BtnHome
        '
        Me.BtnHome.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHome.BorderRadius = 0
        Me.BtnHome.ButtonText = "Home"
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.DisabledColor = System.Drawing.Color.Gray
        Me.BtnHome.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnHome.Iconimage = CType(resources.GetObject("BtnHome.Iconimage"), System.Drawing.Image)
        Me.BtnHome.Iconimage_right = Nothing
        Me.BtnHome.Iconimage_right_Selected = Nothing
        Me.BtnHome.Iconimage_Selected = Nothing
        Me.BtnHome.IconMarginLeft = 0
        Me.BtnHome.IconMarginRight = 0
        Me.BtnHome.IconRightVisible = True
        Me.BtnHome.IconRightZoom = 0.0R
        Me.BtnHome.IconVisible = True
        Me.BtnHome.IconZoom = 60.0R
        Me.BtnHome.IsTab = False
        Me.BtnHome.Location = New System.Drawing.Point(0, 96)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnHome.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnHome.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnHome.selected = False
        Me.BtnHome.Size = New System.Drawing.Size(194, 60)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.Text = "Home"
        Me.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHome.Textcolor = System.Drawing.Color.White
        Me.BtnHome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelHomeOne
        '
        Me.PanelHomeOne.BackgroundImage = CType(resources.GetObject("PanelHomeOne.BackgroundImage"), System.Drawing.Image)
        Me.PanelHomeOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelHomeOne.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeOne.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeOne.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeOne.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeOne.Location = New System.Drawing.Point(0, 162)
        Me.PanelHomeOne.Name = "PanelHomeOne"
        Me.PanelHomeOne.Quality = 10
        Me.PanelHomeOne.Size = New System.Drawing.Size(194, 14)
        Me.PanelHomeOne.TabIndex = 1
        '
        'BtnBD
        '
        Me.BtnBD.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnBD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBD.BorderRadius = 0
        Me.BtnBD.ButtonText = "Base de Dados"
        Me.BtnBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBD.DisabledColor = System.Drawing.Color.Gray
        Me.BtnBD.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnBD.Iconimage = CType(resources.GetObject("BtnBD.Iconimage"), System.Drawing.Image)
        Me.BtnBD.Iconimage_right = Nothing
        Me.BtnBD.Iconimage_right_Selected = Nothing
        Me.BtnBD.Iconimage_Selected = Nothing
        Me.BtnBD.IconMarginLeft = 0
        Me.BtnBD.IconMarginRight = 0
        Me.BtnBD.IconRightVisible = True
        Me.BtnBD.IconRightZoom = 0.0R
        Me.BtnBD.IconVisible = True
        Me.BtnBD.IconZoom = 60.0R
        Me.BtnBD.IsTab = False
        Me.BtnBD.Location = New System.Drawing.Point(0, 182)
        Me.BtnBD.Name = "BtnBD"
        Me.BtnBD.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnBD.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnBD.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnBD.selected = False
        Me.BtnBD.Size = New System.Drawing.Size(194, 60)
        Me.BtnBD.TabIndex = 2
        Me.BtnBD.Text = "Base de Dados"
        Me.BtnBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBD.Textcolor = System.Drawing.Color.White
        Me.BtnBD.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnDetetor
        '
        Me.BtnDetetor.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnDetetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnDetetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDetetor.BorderRadius = 0
        Me.BtnDetetor.ButtonText = "Detetor de Minerais"
        Me.BtnDetetor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDetetor.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDetetor.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDetetor.Iconimage = CType(resources.GetObject("BtnDetetor.Iconimage"), System.Drawing.Image)
        Me.BtnDetetor.Iconimage_right = Nothing
        Me.BtnDetetor.Iconimage_right_Selected = Nothing
        Me.BtnDetetor.Iconimage_Selected = Nothing
        Me.BtnDetetor.IconMarginLeft = 0
        Me.BtnDetetor.IconMarginRight = 0
        Me.BtnDetetor.IconRightVisible = True
        Me.BtnDetetor.IconRightZoom = 0.0R
        Me.BtnDetetor.IconVisible = True
        Me.BtnDetetor.IconZoom = 60.0R
        Me.BtnDetetor.IsTab = False
        Me.BtnDetetor.Location = New System.Drawing.Point(0, 248)
        Me.BtnDetetor.Name = "BtnDetetor"
        Me.BtnDetetor.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnDetetor.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnDetetor.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDetetor.selected = False
        Me.BtnDetetor.Size = New System.Drawing.Size(194, 60)
        Me.BtnDetetor.TabIndex = 3
        Me.BtnDetetor.Text = "Detetor de Minerais"
        Me.BtnDetetor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetetor.Textcolor = System.Drawing.Color.White
        Me.BtnDetetor.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnMapStudio
        '
        Me.BtnMapStudio.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnMapStudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnMapStudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMapStudio.BorderRadius = 0
        Me.BtnMapStudio.ButtonText = "Map Studio"
        Me.BtnMapStudio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMapStudio.DisabledColor = System.Drawing.Color.Gray
        Me.BtnMapStudio.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnMapStudio.Iconimage = CType(resources.GetObject("BtnMapStudio.Iconimage"), System.Drawing.Image)
        Me.BtnMapStudio.Iconimage_right = Nothing
        Me.BtnMapStudio.Iconimage_right_Selected = Nothing
        Me.BtnMapStudio.Iconimage_Selected = Nothing
        Me.BtnMapStudio.IconMarginLeft = 0
        Me.BtnMapStudio.IconMarginRight = 0
        Me.BtnMapStudio.IconRightVisible = True
        Me.BtnMapStudio.IconRightZoom = 0.0R
        Me.BtnMapStudio.IconVisible = True
        Me.BtnMapStudio.IconZoom = 60.0R
        Me.BtnMapStudio.IsTab = False
        Me.BtnMapStudio.Location = New System.Drawing.Point(0, 314)
        Me.BtnMapStudio.Name = "BtnMapStudio"
        Me.BtnMapStudio.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnMapStudio.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnMapStudio.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnMapStudio.selected = False
        Me.BtnMapStudio.Size = New System.Drawing.Size(194, 60)
        Me.BtnMapStudio.TabIndex = 4
        Me.BtnMapStudio.Text = "Map Studio"
        Me.BtnMapStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMapStudio.Textcolor = System.Drawing.Color.White
        Me.BtnMapStudio.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnOptions
        '
        Me.BtnOptions.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOptions.BorderRadius = 0
        Me.BtnOptions.ButtonText = "Opções"
        Me.BtnOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOptions.DisabledColor = System.Drawing.Color.Gray
        Me.BtnOptions.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnOptions.Iconimage = CType(resources.GetObject("BtnOptions.Iconimage"), System.Drawing.Image)
        Me.BtnOptions.Iconimage_right = Nothing
        Me.BtnOptions.Iconimage_right_Selected = Nothing
        Me.BtnOptions.Iconimage_Selected = Nothing
        Me.BtnOptions.IconMarginLeft = 0
        Me.BtnOptions.IconMarginRight = 0
        Me.BtnOptions.IconRightVisible = True
        Me.BtnOptions.IconRightZoom = 0.0R
        Me.BtnOptions.IconVisible = True
        Me.BtnOptions.IconZoom = 60.0R
        Me.BtnOptions.IsTab = False
        Me.BtnOptions.Location = New System.Drawing.Point(0, 380)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnOptions.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnOptions.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnOptions.selected = False
        Me.BtnOptions.Size = New System.Drawing.Size(194, 60)
        Me.BtnOptions.TabIndex = 5
        Me.BtnOptions.Text = "Opções"
        Me.BtnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOptions.Textcolor = System.Drawing.Color.White
        Me.BtnOptions.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'BtnAbout
        '
        Me.BtnAbout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbout.BorderRadius = 0
        Me.BtnAbout.ButtonText = "Acerca de"
        Me.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAbout.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAbout.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAbout.Iconimage = CType(resources.GetObject("BtnAbout.Iconimage"), System.Drawing.Image)
        Me.BtnAbout.Iconimage_right = Nothing
        Me.BtnAbout.Iconimage_right_Selected = Nothing
        Me.BtnAbout.Iconimage_Selected = Nothing
        Me.BtnAbout.IconMarginLeft = 0
        Me.BtnAbout.IconMarginRight = 0
        Me.BtnAbout.IconRightVisible = True
        Me.BtnAbout.IconRightZoom = 0.0R
        Me.BtnAbout.IconVisible = True
        Me.BtnAbout.IconZoom = 60.0R
        Me.BtnAbout.IsTab = False
        Me.BtnAbout.Location = New System.Drawing.Point(0, 446)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnAbout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnAbout.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAbout.selected = False
        Me.BtnAbout.Size = New System.Drawing.Size(194, 60)
        Me.BtnAbout.TabIndex = 6
        Me.BtnAbout.Text = "Acerca de"
        Me.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAbout.Textcolor = System.Drawing.Color.White
        Me.BtnAbout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelHomeTwo
        '
        Me.PanelHomeTwo.BackgroundImage = CType(resources.GetObject("PanelHomeTwo.BackgroundImage"), System.Drawing.Image)
        Me.PanelHomeTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelHomeTwo.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeTwo.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeTwo.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeTwo.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeTwo.Location = New System.Drawing.Point(0, 512)
        Me.PanelHomeTwo.Name = "PanelHomeTwo"
        Me.PanelHomeTwo.Quality = 10
        Me.PanelHomeTwo.Size = New System.Drawing.Size(194, 14)
        Me.PanelHomeTwo.TabIndex = 2
        '
        'PanelHomeExpanded
        '
        Me.PanelHomeExpanded.BackgroundImage = CType(resources.GetObject("PanelHomeExpanded.BackgroundImage"), System.Drawing.Image)
        Me.PanelHomeExpanded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelHomeExpanded.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeExpanded.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeExpanded.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeExpanded.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeExpanded.Location = New System.Drawing.Point(0, 76)
        Me.PanelHomeExpanded.Name = "PanelHomeExpanded"
        Me.PanelHomeExpanded.Quality = 10
        Me.PanelHomeExpanded.Size = New System.Drawing.Size(900, 14)
        Me.PanelHomeExpanded.TabIndex = 11
        '
        'BtnBDSmall
        '
        Me.BtnBDSmall.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnBDSmall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnBDSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBDSmall.BorderRadius = 0
        Me.BtnBDSmall.ButtonText = "Base de Dados"
        Me.BtnBDSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBDSmall.DisabledColor = System.Drawing.Color.Gray
        Me.BtnBDSmall.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnBDSmall.Iconimage = CType(resources.GetObject("BtnBDSmall.Iconimage"), System.Drawing.Image)
        Me.BtnBDSmall.Iconimage_right = Nothing
        Me.BtnBDSmall.Iconimage_right_Selected = Nothing
        Me.BtnBDSmall.Iconimage_Selected = Nothing
        Me.BtnBDSmall.IconMarginLeft = 0
        Me.BtnBDSmall.IconMarginRight = 0
        Me.BtnBDSmall.IconRightVisible = True
        Me.BtnBDSmall.IconRightZoom = 0.0R
        Me.BtnBDSmall.IconVisible = True
        Me.BtnBDSmall.IconZoom = 90.0R
        Me.BtnBDSmall.IsTab = False
        Me.BtnBDSmall.Location = New System.Drawing.Point(155, 38)
        Me.BtnBDSmall.Name = "BtnBDSmall"
        Me.BtnBDSmall.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnBDSmall.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnBDSmall.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnBDSmall.selected = False
        Me.BtnBDSmall.Size = New System.Drawing.Size(142, 31)
        Me.BtnBDSmall.TabIndex = 12
        Me.BtnBDSmall.Text = "Base de Dados"
        Me.BtnBDSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBDSmall.Textcolor = System.Drawing.Color.White
        Me.BtnBDSmall.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnDetetorSmall
        '
        Me.BtnDetetorSmall.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnDetetorSmall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnDetetorSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDetetorSmall.BorderRadius = 0
        Me.BtnDetetorSmall.ButtonText = "Detetor Minerais"
        Me.BtnDetetorSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDetetorSmall.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDetetorSmall.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDetetorSmall.Iconimage = CType(resources.GetObject("BtnDetetorSmall.Iconimage"), System.Drawing.Image)
        Me.BtnDetetorSmall.Iconimage_right = Nothing
        Me.BtnDetetorSmall.Iconimage_right_Selected = Nothing
        Me.BtnDetetorSmall.Iconimage_Selected = Nothing
        Me.BtnDetetorSmall.IconMarginLeft = 0
        Me.BtnDetetorSmall.IconMarginRight = 0
        Me.BtnDetetorSmall.IconRightVisible = True
        Me.BtnDetetorSmall.IconRightZoom = 0.0R
        Me.BtnDetetorSmall.IconVisible = True
        Me.BtnDetetorSmall.IconZoom = 90.0R
        Me.BtnDetetorSmall.IsTab = False
        Me.BtnDetetorSmall.Location = New System.Drawing.Point(303, 38)
        Me.BtnDetetorSmall.Name = "BtnDetetorSmall"
        Me.BtnDetetorSmall.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnDetetorSmall.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnDetetorSmall.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDetetorSmall.selected = False
        Me.BtnDetetorSmall.Size = New System.Drawing.Size(142, 31)
        Me.BtnDetetorSmall.TabIndex = 13
        Me.BtnDetetorSmall.Text = "Detetor Minerais"
        Me.BtnDetetorSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetetorSmall.Textcolor = System.Drawing.Color.White
        Me.BtnDetetorSmall.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnMapStudioSmall
        '
        Me.BtnMapStudioSmall.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnMapStudioSmall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnMapStudioSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMapStudioSmall.BorderRadius = 0
        Me.BtnMapStudioSmall.ButtonText = "Map Studio"
        Me.BtnMapStudioSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMapStudioSmall.DisabledColor = System.Drawing.Color.Gray
        Me.BtnMapStudioSmall.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnMapStudioSmall.Iconimage = CType(resources.GetObject("BtnMapStudioSmall.Iconimage"), System.Drawing.Image)
        Me.BtnMapStudioSmall.Iconimage_right = Nothing
        Me.BtnMapStudioSmall.Iconimage_right_Selected = Nothing
        Me.BtnMapStudioSmall.Iconimage_Selected = Nothing
        Me.BtnMapStudioSmall.IconMarginLeft = 0
        Me.BtnMapStudioSmall.IconMarginRight = 0
        Me.BtnMapStudioSmall.IconRightVisible = True
        Me.BtnMapStudioSmall.IconRightZoom = 0.0R
        Me.BtnMapStudioSmall.IconVisible = True
        Me.BtnMapStudioSmall.IconZoom = 90.0R
        Me.BtnMapStudioSmall.IsTab = False
        Me.BtnMapStudioSmall.Location = New System.Drawing.Point(451, 38)
        Me.BtnMapStudioSmall.Name = "BtnMapStudioSmall"
        Me.BtnMapStudioSmall.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnMapStudioSmall.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnMapStudioSmall.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnMapStudioSmall.selected = False
        Me.BtnMapStudioSmall.Size = New System.Drawing.Size(142, 31)
        Me.BtnMapStudioSmall.TabIndex = 14
        Me.BtnMapStudioSmall.Text = "Map Studio"
        Me.BtnMapStudioSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMapStudioSmall.Textcolor = System.Drawing.Color.White
        Me.BtnMapStudioSmall.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnOptionsSmall
        '
        Me.BtnOptionsSmall.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnOptionsSmall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnOptionsSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOptionsSmall.BorderRadius = 0
        Me.BtnOptionsSmall.ButtonText = "Opções"
        Me.BtnOptionsSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOptionsSmall.DisabledColor = System.Drawing.Color.Gray
        Me.BtnOptionsSmall.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnOptionsSmall.Iconimage = CType(resources.GetObject("BtnOptionsSmall.Iconimage"), System.Drawing.Image)
        Me.BtnOptionsSmall.Iconimage_right = Nothing
        Me.BtnOptionsSmall.Iconimage_right_Selected = Nothing
        Me.BtnOptionsSmall.Iconimage_Selected = Nothing
        Me.BtnOptionsSmall.IconMarginLeft = 0
        Me.BtnOptionsSmall.IconMarginRight = 0
        Me.BtnOptionsSmall.IconRightVisible = True
        Me.BtnOptionsSmall.IconRightZoom = 0.0R
        Me.BtnOptionsSmall.IconVisible = True
        Me.BtnOptionsSmall.IconZoom = 90.0R
        Me.BtnOptionsSmall.IsTab = False
        Me.BtnOptionsSmall.Location = New System.Drawing.Point(599, 38)
        Me.BtnOptionsSmall.Name = "BtnOptionsSmall"
        Me.BtnOptionsSmall.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnOptionsSmall.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnOptionsSmall.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnOptionsSmall.selected = False
        Me.BtnOptionsSmall.Size = New System.Drawing.Size(142, 31)
        Me.BtnOptionsSmall.TabIndex = 15
        Me.BtnOptionsSmall.Text = "Opções"
        Me.BtnOptionsSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOptionsSmall.Textcolor = System.Drawing.Color.White
        Me.BtnOptionsSmall.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnAboutSmall
        '
        Me.BtnAboutSmall.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnAboutSmall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnAboutSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAboutSmall.BorderRadius = 0
        Me.BtnAboutSmall.ButtonText = "Acerca de"
        Me.BtnAboutSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAboutSmall.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAboutSmall.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAboutSmall.Iconimage = CType(resources.GetObject("BtnAboutSmall.Iconimage"), System.Drawing.Image)
        Me.BtnAboutSmall.Iconimage_right = Nothing
        Me.BtnAboutSmall.Iconimage_right_Selected = Nothing
        Me.BtnAboutSmall.Iconimage_Selected = Nothing
        Me.BtnAboutSmall.IconMarginLeft = 0
        Me.BtnAboutSmall.IconMarginRight = 0
        Me.BtnAboutSmall.IconRightVisible = True
        Me.BtnAboutSmall.IconRightZoom = 0.0R
        Me.BtnAboutSmall.IconVisible = True
        Me.BtnAboutSmall.IconZoom = 90.0R
        Me.BtnAboutSmall.IsTab = False
        Me.BtnAboutSmall.Location = New System.Drawing.Point(747, 38)
        Me.BtnAboutSmall.Name = "BtnAboutSmall"
        Me.BtnAboutSmall.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnAboutSmall.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnAboutSmall.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAboutSmall.selected = False
        Me.BtnAboutSmall.Size = New System.Drawing.Size(153, 31)
        Me.BtnAboutSmall.TabIndex = 16
        Me.BtnAboutSmall.Text = "Acerca de"
        Me.BtnAboutSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAboutSmall.Textcolor = System.Drawing.Color.White
        Me.BtnAboutSmall.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnHomeSmall
        '
        Me.BtnHomeSmall.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnHomeSmall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnHomeSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHomeSmall.BorderRadius = 0
        Me.BtnHomeSmall.ButtonText = "Home"
        Me.BtnHomeSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHomeSmall.DisabledColor = System.Drawing.Color.Gray
        Me.BtnHomeSmall.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnHomeSmall.Iconimage = CType(resources.GetObject("BtnHomeSmall.Iconimage"), System.Drawing.Image)
        Me.BtnHomeSmall.Iconimage_right = Nothing
        Me.BtnHomeSmall.Iconimage_right_Selected = Nothing
        Me.BtnHomeSmall.Iconimage_Selected = Nothing
        Me.BtnHomeSmall.IconMarginLeft = 0
        Me.BtnHomeSmall.IconMarginRight = 0
        Me.BtnHomeSmall.IconRightVisible = True
        Me.BtnHomeSmall.IconRightZoom = 0.0R
        Me.BtnHomeSmall.IconVisible = True
        Me.BtnHomeSmall.IconZoom = 90.0R
        Me.BtnHomeSmall.IsTab = False
        Me.BtnHomeSmall.Location = New System.Drawing.Point(0, 38)
        Me.BtnHomeSmall.Name = "BtnHomeSmall"
        Me.BtnHomeSmall.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnHomeSmall.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnHomeSmall.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnHomeSmall.selected = False
        Me.BtnHomeSmall.Size = New System.Drawing.Size(149, 31)
        Me.BtnHomeSmall.TabIndex = 17
        Me.BtnHomeSmall.Text = "Home"
        Me.BtnHomeSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHomeSmall.Textcolor = System.Drawing.Color.White
        Me.BtnHomeSmall.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SelectorPanel
        '
        Me.SelectorPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SelectorPanel.Location = New System.Drawing.Point(184, 96)
        Me.SelectorPanel.Name = "SelectorPanel"
        Me.SelectorPanel.Size = New System.Drawing.Size(10, 59)
        Me.SelectorPanel.TabIndex = 18
        '
        'Mapstudio1
        '
        Me.Mapstudio1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Mapstudio1.Location = New System.Drawing.Point(138, 94)
        Me.Mapstudio1.Name = "Mapstudio1"
        Me.Mapstudio1.Size = New System.Drawing.Size(695, 600)
        Me.Mapstudio1.TabIndex = 20
        '
        'Db_form1
        '
        Me.Db_form1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Db_form1.Location = New System.Drawing.Point(133, 94)
        Me.Db_form1.Name = "Db_form1"
        Me.Db_form1.Size = New System.Drawing.Size(700, 600)
        Me.Db_form1.TabIndex = 19
        '
        'Options1
        '
        Me.Options1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Options1.Location = New System.Drawing.Point(155, 94)
        Me.Options1.Name = "Options1"
        Me.Options1.Size = New System.Drawing.Size(547, 594)
        Me.Options1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.Mapstudio1)
        Me.Controls.Add(Me.Db_form1)
        Me.Controls.Add(Me.SelectorPanel)
        Me.Controls.Add(Me.BtnHomeSmall)
        Me.Controls.Add(Me.BtnAboutSmall)
        Me.Controls.Add(Me.BtnOptionsSmall)
        Me.Controls.Add(Me.BtnMapStudioSmall)
        Me.Controls.Add(Me.BtnDetetorSmall)
        Me.Controls.Add(Me.BtnBDSmall)
        Me.Controls.Add(Me.PanelHomeExpanded)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.Options1)
        Me.Controls.Add(Me.PanelHomeTwo)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.BtnMapStudio)
        Me.Controls.Add(Me.BtnDetetor)
        Me.Controls.Add(Me.BtnBD)
        Me.Controls.Add(Me.PanelHomeOne)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "-"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BtnHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelHomeOne As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BtnOptions As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnMapStudio As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnDetetor As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnBD As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BtnAbout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnMaximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PanelHomeTwo As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Options1 As ArqDB.options
    Friend WithEvents PanelHomeExpanded As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BtnHomeSmall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAboutSmall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnOptionsSmall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnMapStudioSmall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnDetetorSmall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnBDSmall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SelectorPanel As System.Windows.Forms.Panel
    Friend WithEvents Db_form1 As ArqDB.db_form
    Friend WithEvents Mapstudio1 As ArqDB.mapstudio

End Class
