<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printform))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.zoom_plus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.zoom_minus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BunifuImageButton3)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(-8, -8)
        Me.header.Name = "header"
        Me.header.Quality = 10
        Me.header.Size = New System.Drawing.Size(547, 42)
        Me.header.TabIndex = 1
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(778, 3)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(17, 20)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 8
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(801, 3)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(17, 20)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 7
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(824, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(17, 20)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(12, 40)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(508, 339)
        Me.PrintPreviewControl1.TabIndex = 2
        '
        'zoom_plus
        '
        Me.zoom_plus.Activecolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.zoom_plus.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.zoom_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.zoom_plus.BorderRadius = 0
        Me.zoom_plus.ButtonText = "Zoom"
        Me.zoom_plus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.zoom_plus.DisabledColor = System.Drawing.Color.Gray
        Me.zoom_plus.Iconcolor = System.Drawing.Color.Transparent
        Me.zoom_plus.Iconimage = CType(resources.GetObject("zoom_plus.Iconimage"), System.Drawing.Image)
        Me.zoom_plus.Iconimage_right = Nothing
        Me.zoom_plus.Iconimage_right_Selected = Nothing
        Me.zoom_plus.Iconimage_Selected = Nothing
        Me.zoom_plus.IconMarginLeft = 0
        Me.zoom_plus.IconMarginRight = 0
        Me.zoom_plus.IconRightVisible = True
        Me.zoom_plus.IconRightZoom = 0.0R
        Me.zoom_plus.IconVisible = True
        Me.zoom_plus.IconZoom = 50.0R
        Me.zoom_plus.IsTab = False
        Me.zoom_plus.Location = New System.Drawing.Point(193, 386)
        Me.zoom_plus.Name = "zoom_plus"
        Me.zoom_plus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.zoom_plus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.zoom_plus.OnHoverTextColor = System.Drawing.Color.White
        Me.zoom_plus.selected = False
        Me.zoom_plus.Size = New System.Drawing.Size(105, 48)
        Me.zoom_plus.TabIndex = 9
        Me.zoom_plus.Text = "Zoom"
        Me.zoom_plus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.zoom_plus.Textcolor = System.Drawing.Color.White
        Me.zoom_plus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Sair"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(415, 386)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(105, 48)
        Me.BunifuFlatButton2.TabIndex = 8
        Me.BunifuFlatButton2.Text = "Sair"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'zoom_minus
        '
        Me.zoom_minus.Activecolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.zoom_minus.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.zoom_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.zoom_minus.BorderRadius = 0
        Me.zoom_minus.ButtonText = "Zoom"
        Me.zoom_minus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.zoom_minus.DisabledColor = System.Drawing.Color.Gray
        Me.zoom_minus.Iconcolor = System.Drawing.Color.Transparent
        Me.zoom_minus.Iconimage = CType(resources.GetObject("zoom_minus.Iconimage"), System.Drawing.Image)
        Me.zoom_minus.Iconimage_right = Nothing
        Me.zoom_minus.Iconimage_right_Selected = Nothing
        Me.zoom_minus.Iconimage_Selected = Nothing
        Me.zoom_minus.IconMarginLeft = 0
        Me.zoom_minus.IconMarginRight = 0
        Me.zoom_minus.IconRightVisible = True
        Me.zoom_minus.IconRightZoom = 0.0R
        Me.zoom_minus.IconVisible = True
        Me.zoom_minus.IconZoom = 50.0R
        Me.zoom_minus.IsTab = False
        Me.zoom_minus.Location = New System.Drawing.Point(304, 386)
        Me.zoom_minus.Name = "zoom_minus"
        Me.zoom_minus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.zoom_minus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.zoom_minus.OnHoverTextColor = System.Drawing.Color.White
        Me.zoom_minus.selected = False
        Me.zoom_minus.Size = New System.Drawing.Size(105, 48)
        Me.zoom_minus.TabIndex = 7
        Me.zoom_minus.Text = "Zoom"
        Me.zoom_minus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.zoom_minus.Textcolor = System.Drawing.Color.White
        Me.zoom_minus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'printform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 446)
        Me.Controls.Add(Me.zoom_plus)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.zoom_minus)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "printform"
        Me.Text = "printform"
        Me.header.ResumeLayout(False)
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents zoom_plus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents zoom_minus As Bunifu.Framework.UI.BunifuFlatButton
End Class
