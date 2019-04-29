<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class embLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(embLogin))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PassForm = New System.Windows.Forms.TextBox()
        Me.LoginForm = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.metronvenda = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.regcoduser = New System.Windows.Forms.TextBox()
        Me.regnome = New System.Windows.Forms.TextBox()
        Me.reglogin = New System.Windows.Forms.TextBox()
        Me.regsenha = New System.Windows.Forms.TextBox()
        Me.registar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(52, 247)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 10)
        Me.Panel2.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(52, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 10)
        Me.Panel1.TabIndex = 40
        '
        'PassForm
        '
        Me.PassForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PassForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PassForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassForm.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.PassForm.Location = New System.Drawing.Point(52, 212)
        Me.PassForm.Name = "PassForm"
        Me.PassForm.Size = New System.Drawing.Size(212, 19)
        Me.PassForm.TabIndex = 39
        Me.PassForm.Text = "Palavra-Passe"
        '
        'LoginForm
        '
        Me.LoginForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LoginForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LoginForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginForm.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.LoginForm.Location = New System.Drawing.Point(52, 139)
        Me.LoginForm.Name = "LoginForm"
        Me.LoginForm.Size = New System.Drawing.Size(212, 19)
        Me.LoginForm.TabIndex = 38
        Me.LoginForm.Text = "Email"
        '
        'LoginBtn
        '
        Me.LoginBtn.ActiveBorderThickness = 1
        Me.LoginBtn.ActiveCornerRadius = 20
        Me.LoginBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LoginBtn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LoginBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LoginBtn.BackgroundImage = CType(resources.GetObject("LoginBtn.BackgroundImage"), System.Drawing.Image)
        Me.LoginBtn.ButtonText = "Login"
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.IdleBorderThickness = 1
        Me.LoginBtn.IdleCornerRadius = 20
        Me.LoginBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LoginBtn.IdleForecolor = System.Drawing.Color.White
        Me.LoginBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LoginBtn.Location = New System.Drawing.Point(52, 324)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(212, 49)
        Me.LoginBtn.TabIndex = 26
        Me.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'metronvenda
        '
        Me.metronvenda.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.metronvenda.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.metronvenda.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.metronvenda.BorderThickness = 3
        Me.metronvenda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.metronvenda.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.metronvenda.ForeColor = System.Drawing.Color.White
        Me.metronvenda.isPassword = False
        Me.metronvenda.Location = New System.Drawing.Point(52, 65)
        Me.metronvenda.Margin = New System.Windows.Forms.Padding(4)
        Me.metronvenda.Name = "metronvenda"
        Me.metronvenda.Size = New System.Drawing.Size(212, 44)
        Me.metronvenda.TabIndex = 42
        Me.metronvenda.Text = "Fazer Login"
        Me.metronvenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(485, 65)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(212, 44)
        Me.BunifuMetroTextbox1.TabIndex = 43
        Me.BunifuMetroTextbox1.Text = "Registar"
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'regcoduser
        '
        Me.regcoduser.Location = New System.Drawing.Point(542, 138)
        Me.regcoduser.Name = "regcoduser"
        Me.regcoduser.Size = New System.Drawing.Size(155, 20)
        Me.regcoduser.TabIndex = 44
        '
        'regnome
        '
        Me.regnome.Location = New System.Drawing.Point(540, 173)
        Me.regnome.Name = "regnome"
        Me.regnome.Size = New System.Drawing.Size(155, 20)
        Me.regnome.TabIndex = 45
        '
        'reglogin
        '
        Me.reglogin.Location = New System.Drawing.Point(540, 211)
        Me.reglogin.Name = "reglogin"
        Me.reglogin.Size = New System.Drawing.Size(155, 20)
        Me.reglogin.TabIndex = 46
        '
        'regsenha
        '
        Me.regsenha.Location = New System.Drawing.Point(542, 247)
        Me.regsenha.Name = "regsenha"
        Me.regsenha.Size = New System.Drawing.Size(155, 20)
        Me.regsenha.TabIndex = 47
        '
        'registar
        '
        Me.registar.ActiveBorderThickness = 1
        Me.registar.ActiveCornerRadius = 20
        Me.registar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.registar.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.registar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.registar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.registar.BackgroundImage = CType(resources.GetObject("registar.BackgroundImage"), System.Drawing.Image)
        Me.registar.ButtonText = "Registar"
        Me.registar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registar.ForeColor = System.Drawing.Color.White
        Me.registar.IdleBorderThickness = 1
        Me.registar.IdleCornerRadius = 20
        Me.registar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.registar.IdleForecolor = System.Drawing.Color.White
        Me.registar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.registar.Location = New System.Drawing.Point(485, 324)
        Me.registar.Margin = New System.Windows.Forms.Padding(5)
        Me.registar.Name = "registar"
        Me.registar.Size = New System.Drawing.Size(212, 49)
        Me.registar.TabIndex = 48
        Me.registar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(465, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "CodUser"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(486, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(486, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(481, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Senha"
        '
        'embLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.registar)
        Me.Controls.Add(Me.regsenha)
        Me.Controls.Add(Me.reglogin)
        Me.Controls.Add(Me.regnome)
        Me.Controls.Add(Me.regcoduser)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.metronvenda)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PassForm)
        Me.Controls.Add(Me.LoginForm)
        Me.Name = "embLogin"
        Me.Size = New System.Drawing.Size(833, 534)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PassForm As System.Windows.Forms.TextBox
    Friend WithEvents LoginForm As System.Windows.Forms.TextBox
    Friend WithEvents LoginBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents metronvenda As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents regcoduser As System.Windows.Forms.TextBox
    Friend WithEvents regnome As System.Windows.Forms.TextBox
    Friend WithEvents reglogin As System.Windows.Forms.TextBox
    Friend WithEvents regsenha As System.Windows.Forms.TextBox
    Friend WithEvents registar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
