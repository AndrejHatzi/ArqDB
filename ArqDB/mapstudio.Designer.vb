<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mapstudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mapstudio))
        Me.pBox = New System.Windows.Forms.PictureBox()
        Me.ButtonSettings = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnLocalizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnUpdate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tBoxNome = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LabelNome = New System.Windows.Forms.Label()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLocalizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBox
        '
        Me.pBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pBox.Location = New System.Drawing.Point(453, 3)
        Me.pBox.Name = "pBox"
        Me.pBox.Size = New System.Drawing.Size(389, 259)
        Me.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBox.TabIndex = 82
        Me.pBox.TabStop = False
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
        Me.ButtonSettings.TabIndex = 87
        Me.ButtonSettings.TabStop = False
        Me.ButtonSettings.Zoom = 20
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
        Me.BtnLocalizar.TabIndex = 86
        Me.BtnLocalizar.TabStop = False
        Me.BtnLocalizar.Zoom = 20
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
        Me.BtnDelete.TabIndex = 85
        Me.BtnDelete.TabStop = False
        Me.BtnDelete.Zoom = 20
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
        Me.BtnUpdate.TabIndex = 84
        Me.BtnUpdate.TabStop = False
        Me.BtnUpdate.Zoom = 20
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
        Me.BtnSave.TabIndex = 83
        Me.BtnSave.TabStop = False
        Me.BtnSave.Zoom = 20
        '
        'tBoxNome
        '
        Me.tBoxNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBoxNome.ForeColor = System.Drawing.SystemColors.Control
        Me.tBoxNome.HintForeColor = System.Drawing.SystemColors.Control
        Me.tBoxNome.HintText = ""
        Me.tBoxNome.isPassword = False
        Me.tBoxNome.LineFocusedColor = System.Drawing.SystemColors.Control
        Me.tBoxNome.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.tBoxNome.LineMouseHoverColor = System.Drawing.SystemColors.Control
        Me.tBoxNome.LineThickness = 3
        Me.tBoxNome.Location = New System.Drawing.Point(527, 280)
        Me.tBoxNome.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxNome.Name = "tBoxNome"
        Me.tBoxNome.Size = New System.Drawing.Size(315, 31)
        Me.tBoxNome.TabIndex = 88
        Me.tBoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNome.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelNome.Location = New System.Drawing.Point(449, 287)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(62, 24)
        Me.LabelNome.TabIndex = 89
        Me.LabelNome.Text = "Nome"
        '
        'mapstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.tBoxNome)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.BtnLocalizar)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.pBox)
        Me.Name = "mapstudio"
        Me.Size = New System.Drawing.Size(895, 600)
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLocalizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pBox As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonSettings As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnLocalizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnDelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tBoxNome As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LabelNome As System.Windows.Forms.Label

End Class
