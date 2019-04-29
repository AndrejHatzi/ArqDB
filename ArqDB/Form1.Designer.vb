<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelHomeOne = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnBD = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDetetor = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnMapStudio = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnOptions = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BtnAbout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnMaximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PanelHomeTwo = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnHome.Location = New System.Drawing.Point(0, 43)
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
        Me.PanelHomeOne.Location = New System.Drawing.Point(0, 109)
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
        Me.BtnBD.Location = New System.Drawing.Point(0, 129)
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
        Me.BtnDetetor.Location = New System.Drawing.Point(0, 195)
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
        Me.BtnMapStudio.Location = New System.Drawing.Point(0, 261)
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
        Me.BtnOptions.Location = New System.Drawing.Point(0, 327)
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
        Me.BtnAbout.Location = New System.Drawing.Point(0, 393)
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
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(580, 109)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(41, 37)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton5.TabIndex = 8
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 40
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(36, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 32)
        Me.Panel1.TabIndex = 7
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
        'PanelHomeTwo
        '
        Me.PanelHomeTwo.BackgroundImage = CType(resources.GetObject("PanelHomeTwo.BackgroundImage"), System.Drawing.Image)
        Me.PanelHomeTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelHomeTwo.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeTwo.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeTwo.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHomeTwo.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PanelHomeTwo.Location = New System.Drawing.Point(0, 459)
        Me.PanelHomeTwo.Name = "PanelHomeTwo"
        Me.PanelHomeTwo.Quality = 10
        Me.PanelHomeTwo.Size = New System.Drawing.Size(194, 14)
        Me.PanelHomeTwo.TabIndex = 2
        '
        'S
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.PanelHomeTwo)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.BtnMapStudio)
        Me.Controls.Add(Me.BtnDetetor)
        Me.Controls.Add(Me.BtnBD)
        Me.Controls.Add(Me.BunifuImageButton5)
        Me.Controls.Add(Me.PanelHomeOne)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "S"
        Me.Text = "-"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PanelHomeTwo As Bunifu.Framework.UI.BunifuGradientPanel

End Class
