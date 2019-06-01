<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options))
        Me.LabelLanguage = New System.Windows.Forms.Label()
        Me.OptionPortuguese = New Bunifu.Framework.UI.BunifuImageButton()
        Me.OptionEnglish = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MenuTopo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.SempreTopo = New System.Windows.Forms.Label()
        CType(Me.OptionPortuguese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptionEnglish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLanguage
        '
        Me.LabelLanguage.AutoSize = True
        Me.LabelLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLanguage.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelLanguage.Location = New System.Drawing.Point(112, 102)
        Me.LabelLanguage.Name = "LabelLanguage"
        Me.LabelLanguage.Size = New System.Drawing.Size(86, 29)
        Me.LabelLanguage.TabIndex = 2
        Me.LabelLanguage.Text = "Idioma"
        '
        'OptionPortuguese
        '
        Me.OptionPortuguese.BackColor = System.Drawing.Color.Transparent
        Me.OptionPortuguese.Image = CType(resources.GetObject("OptionPortuguese.Image"), System.Drawing.Image)
        Me.OptionPortuguese.ImageActive = Nothing
        Me.OptionPortuguese.Location = New System.Drawing.Point(242, 84)
        Me.OptionPortuguese.Name = "OptionPortuguese"
        Me.OptionPortuguese.Size = New System.Drawing.Size(71, 71)
        Me.OptionPortuguese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OptionPortuguese.TabIndex = 3
        Me.OptionPortuguese.TabStop = False
        Me.OptionPortuguese.Zoom = 10
        '
        'OptionEnglish
        '
        Me.OptionEnglish.BackColor = System.Drawing.Color.Transparent
        Me.OptionEnglish.Image = CType(resources.GetObject("OptionEnglish.Image"), System.Drawing.Image)
        Me.OptionEnglish.ImageActive = Nothing
        Me.OptionEnglish.Location = New System.Drawing.Point(340, 84)
        Me.OptionEnglish.Name = "OptionEnglish"
        Me.OptionEnglish.Size = New System.Drawing.Size(71, 71)
        Me.OptionEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OptionEnglish.TabIndex = 4
        Me.OptionEnglish.TabStop = False
        Me.OptionEnglish.Zoom = 10
        '
        'MenuTopo
        '
        Me.MenuTopo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MenuTopo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MenuTopo.Checked = True
        Me.MenuTopo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MenuTopo.ForeColor = System.Drawing.Color.White
        Me.MenuTopo.Location = New System.Drawing.Point(311, 207)
        Me.MenuTopo.Name = "MenuTopo"
        Me.MenuTopo.Size = New System.Drawing.Size(20, 20)
        Me.MenuTopo.TabIndex = 5
        '
        'SempreTopo
        '
        Me.SempreTopo.AutoSize = True
        Me.SempreTopo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SempreTopo.ForeColor = System.Drawing.SystemColors.Control
        Me.SempreTopo.Location = New System.Drawing.Point(112, 207)
        Me.SempreTopo.Name = "SempreTopo"
        Me.SempreTopo.Size = New System.Drawing.Size(170, 29)
        Me.SempreTopo.TabIndex = 6
        Me.SempreTopo.Text = "Menu no Topo"
        '
        'options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.SempreTopo)
        Me.Controls.Add(Me.MenuTopo)
        Me.Controls.Add(Me.OptionEnglish)
        Me.Controls.Add(Me.OptionPortuguese)
        Me.Controls.Add(Me.LabelLanguage)
        Me.Name = "options"
        Me.Size = New System.Drawing.Size(895, 650)
        CType(Me.OptionPortuguese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptionEnglish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelLanguage As System.Windows.Forms.Label
    Friend WithEvents OptionPortuguese As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents OptionEnglish As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MenuTopo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents SempreTopo As System.Windows.Forms.Label

End Class
