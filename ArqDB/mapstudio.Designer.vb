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
        Me.BtnSave = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tBoxNome = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LabelNome = New System.Windows.Forms.Label()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBox
        '
        Me.pBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pBox.Location = New System.Drawing.Point(222, 76)
        Me.pBox.Name = "pBox"
        Me.pBox.Size = New System.Drawing.Size(389, 259)
        Me.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBox.TabIndex = 82
        Me.pBox.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageActive = Nothing
        Me.BtnSave.Location = New System.Drawing.Point(567, 342)
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
        Me.tBoxNome.Location = New System.Drawing.Point(287, 358)
        Me.tBoxNome.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxNome.Name = "tBoxNome"
        Me.tBoxNome.Size = New System.Drawing.Size(264, 31)
        Me.tBoxNome.TabIndex = 88
        Me.tBoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNome.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelNome.Location = New System.Drawing.Point(218, 365)
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
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.pBox)
        Me.Name = "mapstudio"
        Me.Size = New System.Drawing.Size(895, 600)
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pBox As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tBoxNome As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LabelNome As System.Windows.Forms.Label

End Class
