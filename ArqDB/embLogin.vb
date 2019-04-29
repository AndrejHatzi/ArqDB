Public Class embLogin
    Public entrou As Boolean = False
    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub registar_Click(sender As Object, e As EventArgs) Handles registar.Click
    '    Dim regutilizador As Boolean
    '    regutilizador = RegistarUtilizador(regcoduser.Text, regnome.Text, reglogin.Text, regsenha.Text)
    '    If regutilizador Then
    '        regcoduser.Text = ""
    '        regnome.Text = ""
    '        reglogin.Text = ""
    '        regsenha.Text = ""
    '    End If
    'End Sub
    'Private Sub LoginForm_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginForm.GotFocus
    '    If LoginForm.Text = "Login" Then
    '        LoginForm.Text = ""

    '        'nvenda.ForeColor = Color.Black
    '    End If
    'End Sub
    'Private Sub LoginForm_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginForm.LostFocus
    '    If LoginForm.Text = "" Then
    '        LoginForm.Text = "Login"
    '        'LoginForm.ForeColor = Color.Gray
    '    End If
    'End Sub
    'Private Sub nvenda_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassForm.GotFocus
    '    If PassForm.Text = "Palavra-Passe" Then
    '        PassForm.Text = ""

    '        'nvenda.ForeColor = Color.Black
    '    End If
    'End Sub
    'Private Sub nvenda_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassForm.LostFocus
    '    If PassForm.Text = "" Then
    '        PassForm.Text = "Palavra-Passe"
    '        'PassForm.ForeColor = Color.Gray
    '    End If
    'End Sub

    'Private Sub embLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    PassForm.Text = "Palavra-Passe"
    '    LoginForm.Text = "Login"
    'End Sub

    'Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
    '    Dim sql As String = "SELECT senha from utilizador where senha = '" & PassForm.Text & "'"
    '    Dim login As String
    '    login = Add_Single_Value(sql, "senha")
    '    If PassForm.Text = login Then
    '        MessageBox.Show("Login", "Login Feito com Sucesso")
    '        entrou = True
    '        Form1.PagIni1.meu_vendedor.LabelText = LoginForm.Text
    '        Me.Hide()
    '        Form1.PagIni1.BringToFront()
    '    End If
    'End Sub
End Class
