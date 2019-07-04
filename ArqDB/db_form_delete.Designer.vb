<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class db_form_delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(db_form_delete))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataItems = New System.Windows.Forms.DataGridView()
        Me.db_form_delete_header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnQuit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.deleteButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl5 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.updatebutton = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.DataItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.db_form_delete_header.SuspendLayout()
        CType(Me.BtnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'DataItems
        '
        Me.DataItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataItems.Location = New System.Drawing.Point(12, 43)
        Me.DataItems.Name = "DataItems"
        Me.DataItems.Size = New System.Drawing.Size(853, 351)
        Me.DataItems.TabIndex = 0
        '
        'db_form_delete_header
        '
        Me.db_form_delete_header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.db_form_delete_header.BackgroundImage = CType(resources.GetObject("db_form_delete_header.BackgroundImage"), System.Drawing.Image)
        Me.db_form_delete_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.db_form_delete_header.Controls.Add(Me.BtnQuit)
        Me.db_form_delete_header.Controls.Add(Me.Panel1)
        Me.db_form_delete_header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.db_form_delete_header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.db_form_delete_header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.db_form_delete_header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.db_form_delete_header.Location = New System.Drawing.Point(0, -1)
        Me.db_form_delete_header.Name = "db_form_delete_header"
        Me.db_form_delete_header.Quality = 10
        Me.db_form_delete_header.Size = New System.Drawing.Size(883, 29)
        Me.db_form_delete_header.TabIndex = 1
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Transparent
        Me.BtnQuit.Image = CType(resources.GetObject("BtnQuit.Image"), System.Drawing.Image)
        Me.BtnQuit.ImageActive = Nothing
        Me.BtnQuit.Location = New System.Drawing.Point(842, 1)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(38, 31)
        Me.BtnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnQuit.TabIndex = 9
        Me.BtnQuit.TabStop = False
        Me.BtnQuit.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(836, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 32)
        Me.Panel1.TabIndex = 7
        '
        'deleteButton
        '
        Me.deleteButton.ActiveBorderThickness = 1
        Me.deleteButton.ActiveCornerRadius = 20
        Me.deleteButton.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.deleteButton.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.deleteButton.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.deleteButton.BackgroundImage = CType(resources.GetObject("deleteButton.BackgroundImage"), System.Drawing.Image)
        Me.deleteButton.ButtonText = "Eliminar"
        Me.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.Color.White
        Me.deleteButton.IdleBorderThickness = 1
        Me.deleteButton.IdleCornerRadius = 20
        Me.deleteButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.deleteButton.IdleForecolor = System.Drawing.Color.White
        Me.deleteButton.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.deleteButton.Location = New System.Drawing.Point(788, 398)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(77, 41)
        Me.deleteButton.TabIndex = 27
        Me.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl5
        '
        Me.BunifuDragControl5.Fixed = True
        Me.BunifuDragControl5.Horizontal = True
        Me.BunifuDragControl5.TargetControl = Me
        Me.BunifuDragControl5.Vertical = True
        '
        'updatebutton
        '
        Me.updatebutton.ActiveBorderThickness = 1
        Me.updatebutton.ActiveCornerRadius = 20
        Me.updatebutton.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.updatebutton.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.updatebutton.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.updatebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.updatebutton.BackgroundImage = CType(resources.GetObject("updatebutton.BackgroundImage"), System.Drawing.Image)
        Me.updatebutton.ButtonText = "Atualizar"
        Me.updatebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatebutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebutton.ForeColor = System.Drawing.Color.White
        Me.updatebutton.IdleBorderThickness = 1
        Me.updatebutton.IdleCornerRadius = 20
        Me.updatebutton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.updatebutton.IdleForecolor = System.Drawing.Color.White
        Me.updatebutton.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.updatebutton.Location = New System.Drawing.Point(699, 398)
        Me.updatebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.updatebutton.Name = "updatebutton"
        Me.updatebutton.Size = New System.Drawing.Size(81, 41)
        Me.updatebutton.TabIndex = 28
        Me.updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'db_form_delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 446)
        Me.Controls.Add(Me.updatebutton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.db_form_delete_header)
        Me.Controls.Add(Me.DataItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "db_form_delete"
        Me.Text = "db_form_delete"
        CType(Me.DataItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.db_form_delete_header.ResumeLayout(False)
        CType(Me.BtnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DataItems As System.Windows.Forms.DataGridView
    Friend WithEvents db_form_delete_header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnQuit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents deleteButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl5 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents updatebutton As Bunifu.Framework.UI.BunifuThinButton2
End Class
