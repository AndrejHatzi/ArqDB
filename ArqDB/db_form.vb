Imports System.IO
Imports MySql.Data.MySqlClient
Public Class db_form

    Private Sub db_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tBoxCodigo.ForeColor = Color.Coral
        'tBoxCodigo.HintForeColor = Color.Red
        'Dim items As IList(Of String) = New List(Of String)()
        'items.Add("L-Male")
        'items.Add("L-Female")
        'items.Add("L-Other")

        'For Each item In items
        '    PeriodoCombo.Items.Add(item)
        'Next



        'PeriodoCombo.Items.SetValue = ("Alta Idade Média")
        'periodo.Items.Add("Baixa Idade Média")
        'periodo.Items.Add("Calcolítico")
        'periodo.Items.Add("Contemporâneo")
        'periodo.Items.Add("Epipaleolítico")
        'periodo.Items.Add("Idade Média")
        'periodo.Items.Add("Idade do Bronze")
        'periodo.Items.Add("Idade do Ferro")
        'periodo.Items.Add("Medieval Cristão")
        'periodo.Items.Add("Medieval Islâmico")
        'periodo.Items.Add("Mesolítico")
        'periodo.Items.Add("Moderno")
        'periodo.Items.Add("Neolítico")
        'periodo.Items.Add("Paleolítico")
        'periodo.Items.Add("Paleolítico Inferior")
        'periodo.Items.Add("Paleolítico Médio")
        'periodo.Items.Add("Paleolítico Superior")
        'periodo.Items.Add("Romano")
        'periodo.Items.Add("Indeterminado")

        'MateriaPrimaCombo.AddItem("Nietzsche")





    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    'Dim index As String
    'Dim x As String

    'index = check_disc.CurrentCell.RowIndex  'CurrentCell. (before RowIndex)
    'x = check_disc.Rows(index).Cells(0).Value

    'Dim sql As String
    'Dim adaptador As New MySqlDataAdapter
    'Dim dados As New DataTable
    'Dim bsource As New BindingSource
    'Dim conexao As New MySqlConnection()
    '    conexao.ConnectionString = "SERVER=localhost; user=root; password='';database=bd_escola" ' atribui a string de ligação a conexão a BD

    '    sql = "SELECT disciplinas.disciplinaID, disciplinas.disciplina, disciplinas.nmodulos FROM disciplinas"

    '    Try
    '        conexao.Open()

    'Dim comando As MySqlCommand = New MySqlCommand(Sql, conexao)

    '        adaptador.SelectCommand = comando
    '        adaptador.Fill(dados)
    '        bsource.DataSource = dados
    '        check_disc.DataSource = bsource
    '        adaptador.Update(dados)

    '        conexao.Close()

    '    Catch ex As Exception
    '        MessageBox.Show("Erro ao tentar ler a DB", ex.Message)
    '    Finally
    '        conexao.Dispose()
    '    End Try

    Private Sub PeriodoCombo_onItemSelected(sender As Object, e As EventArgs) Handles PeriodoCombo.onItemSelected
    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs)
        'InsertItem(Codi
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        'tBoxCodigo.Text
        'Dim Components() As String = {tBoxCodigo.Text, tBoxConcelho.Text, tBoxFreguesia.Text, tBoxLugar.Text, tBoxSuporte.Text, tBoxTecnologia.Text, tBoxComprimento.Text, tBoxLargura.Text, tBoxEspessura.Text, tBoxLatitude.Text, tBoxLongitude.Text, BibliografiaTextBox.Text}
        'MessageBox.Show(UBound(Components))
        'For i = 0 To UBound(Components)
        'MessageBox.Show(Components(i))
        'If Components(i).ToString.Length = 0 Then
        'MessageBox.Show(Components(i).ToString.Length)
        'End If
        'Next



        'MsgBox(PeriodoCombo.selectedValue)
        'For i in Components()

        'Next
        'For index As Integer = 1 To 5
        'Debug.Write(index.ToString & " ")
        'Next
        'z<<tBoxCodigo.Text.Length
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'Dim Components() As Object = {tBoxCodigo, tBoxConcelho, tBoxFreguesia, tBoxLugar, tBoxSuporte, 
        'tBoxTecnologia, tBoxComprimento, tBoxLargura, tBoxEspessura, tBoxLatitude, tBoxLongitude, BibliografiaTextBox}
        'MessageBox.Show(UBound(Components))
        'tBoxCodigo.ForeColor = Color.Red
        'For i = 0 To UBound(Components)
        '    If Components(i).Text.Length = 0 Then
        '        Components(i).HintForeColor = Color.Red
        '        Components(i).Text = "Error"
        '    End If
        'Next
        Dim Message As String
        If Form1.Options1.language = 0 Then
            Message = "Não Preenchido"
        ElseIf Form1.Options1.language = 1 Then
            Message = "Not Filled"
        End If

        MessageBox.Show(Form1.Options1.language)
        If tBoxCodigo.Text.Length = 0 Then
            tBoxCodigo.Text = Message
            tBoxCodigo.HintForeColor = Color.Red
            tBoxCodigo.ForeColor = Color.Red
        End If
        If tBoxConcelho.Text.Length = 0 Then

            tBoxConcelho.Text = Message
            tBoxConcelho.HintForeColor = Color.Red
            tBoxConcelho.ForeColor = Color.Red
        End If
        If tBoxFreguesia.Text.Length = 0 Then

            tBoxFreguesia.Text = Message
            tBoxFreguesia.HintForeColor = Color.Red
            tBoxFreguesia.ForeColor = Color.Red
        End If
        If tBoxLugar.Text.Length = 0 Then

            tBoxLugar.Text = Message
            tBoxLugar.HintForeColor = Color.Red
            tBoxLugar.ForeColor = Color.Red
        End If
        If tBoxSuporte.Text.Length = 0 Then

            tBoxSuporte.Text = Message
            tBoxSuporte.HintForeColor = Color.Red
            tBoxSuporte.ForeColor = Color.Red
        End If
        If tBoxTecnologia.Text.Length = 0 Then

            tBoxTecnologia.Text = Message
            tBoxTecnologia.HintForeColor = Color.Red
            tBoxTecnologia.ForeColor = Color.Red
        End If
        If tBoxComprimento.Text.Length = 0 Then

            tBoxComprimento.Text = Message
            tBoxComprimento.HintForeColor = Color.Red
            tBoxComprimento.ForeColor = Color.Red
        End If
        If tBoxLargura.Text.Length = 0 Then

            tBoxLargura.Text = Message
            tBoxLargura.HintForeColor = Color.Red
            tBoxLargura.ForeColor = Color.Red
        End If
        If tBoxEspessura.Text.Length = 0 Then

            tBoxEspessura.Text = Message
            tBoxEspessura.HintForeColor = Color.Red
            tBoxEspessura.ForeColor = Color.Red
        End If
        If tBoxLatitude.Text.Length = 0 Then

            tBoxLatitude.Text = "Latitude"
            tBoxLatitude.HintForeColor = Color.Red
            tBoxLatitude.ForeColor = Color.Red
        End If
        If tBoxLongitude.Text.Length = 0 Then

            tBoxLongitude.Text = "Longitude"
            tBoxLongitude.HintForeColor = Color.Red
            tBoxLongitude.ForeColor = Color.Red
        End If
        'If BibliografiaTextBox.Text.Length = 0 Then
        '    BibliografiaTextBox.ForeColor = Color.Red
        '    BibliografiaTextBox.Text = Message
        'End If
    End Sub
    'tBoxCodigo, tBoxConcelho, tBoxFreguesia, tBoxLugar, tBoxSuporte, 
    'tBoxTecnologia, tBoxComprimento, tBoxLargura, tBoxEspessura, tBoxLatitude, tBoxLongitude, BibliografiaTextBox
    Private Sub tBoxCodigo_Click(sender As Object, e As EventArgs) Handles tBoxCodigo.Click
        tBoxCodigo.HintForeColor = Color.White
        tBoxCodigo.ForeColor = Color.White
    End Sub
    Private Sub tBoxCodigo_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxCodigo.OnValueChanged
        tBoxCodigo.HintForeColor = Color.White
        tBoxCodigo.ForeColor = Color.White
    End Sub

    Private Sub tBoxConcelho_Click(sender As Object, e As EventArgs) Handles tBoxConcelho.Click
        tBoxConcelho.HintForeColor = Color.White
        tBoxConcelho.ForeColor = Color.White
    End Sub
    Private Sub tBoxConcelho_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxConcelho.OnValueChanged
        tBoxConcelho.HintForeColor = Color.White
        tBoxConcelho.ForeColor = Color.White
    End Sub


    Private Sub tBoxFreguesia_Click(sender As Object, e As EventArgs) Handles tBoxFreguesia.Click
        tBoxFreguesia.HintForeColor = Color.White
        tBoxFreguesia.ForeColor = Color.White
    End Sub
    Private Sub tBoxFreguesia_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxFreguesia.OnValueChanged
        tBoxFreguesia.HintForeColor = Color.White
        tBoxFreguesia.ForeColor = Color.White
    End Sub


    Private Sub tBoxLugar_Click(sender As Object, e As EventArgs) Handles tBoxLugar.Click
        tBoxLugar.HintForeColor = Color.White
        tBoxLugar.ForeColor = Color.White
    End Sub
    Private Sub tBoxLugar_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxLugar.OnValueChanged
        tBoxLugar.HintForeColor = Color.White
        tBoxLugar.ForeColor = Color.White
    End Sub


    Private Sub tBoxSuporte_Click(sender As Object, e As EventArgs) Handles tBoxSuporte.Click
        tBoxSuporte.HintForeColor = Color.White
        tBoxSuporte.ForeColor = Color.White
    End Sub
    Private Sub tBoxSuporte_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxSuporte.OnValueChanged
        tBoxSuporte.HintForeColor = Color.White
        tBoxSuporte.ForeColor = Color.White
    End Sub


    Private Sub tBoxTecnologia_Click(sender As Object, e As EventArgs) Handles tBoxTecnologia.Click
        tBoxTecnologia.HintForeColor = Color.White
        tBoxTecnologia.ForeColor = Color.White
    End Sub
    Private Sub tBoxTecnologia_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxTecnologia.OnValueChanged
        tBoxTecnologia.HintForeColor = Color.White
        tBoxTecnologia.ForeColor = Color.White
    End Sub


    Private Sub tBoxComprimento_Click(sender As Object, e As EventArgs) Handles tBoxComprimento.Click
        tBoxComprimento.HintForeColor = Color.White
        tBoxComprimento.ForeColor = Color.White
    End Sub
    Private Sub tBoxComprimento_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxComprimento.OnValueChanged
        tBoxComprimento.HintForeColor = Color.White
        tBoxComprimento.ForeColor = Color.White
    End Sub


    Private Sub tBoxEspessura_Click(sender As Object, e As EventArgs) Handles tBoxEspessura.Click
        tBoxEspessura.HintForeColor = Color.White
        tBoxEspessura.ForeColor = Color.White
    End Sub
    Private Sub tBoxEspessura_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxEspessura.OnValueChanged
        tBoxEspessura.HintForeColor = Color.White
        tBoxEspessura.ForeColor = Color.White
    End Sub

    Private Sub tBoxLargura_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxLargura.OnValueChanged
        tBoxLargura.HintForeColor = Color.White
        tBoxLargura.ForeColor = Color.White
    End Sub
    Private Sub tBoxLargura_Click(sender As Object, e As EventArgs) Handles tBoxLargura.Click
        tBoxLargura.HintForeColor = Color.White
        tBoxLargura.ForeColor = Color.White
    End Sub

    Private Sub tBoxLatitude_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxLatitude.OnValueChanged
        tBoxLatitude.HintForeColor = Color.White
        tBoxLatitude.ForeColor = Color.White
    End Sub
    Private Sub tBoxLatitude_Click(sender As Object, e As EventArgs) Handles tBoxLatitude.Click
        tBoxLatitude.HintForeColor = Color.White
        tBoxLatitude.ForeColor = Color.White
    End Sub

    Private Sub tBoxLongitude_Click(sender As Object, e As EventArgs) Handles tBoxLongitude.Click
        tBoxLongitude.HintForeColor = Color.White
        tBoxLongitude.ForeColor = Color.White
    End Sub
    Private Sub tBoxLongitude_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxLongitude.OnValueChanged
        tBoxLongitude.HintForeColor = Color.White
        tBoxLongitude.ForeColor = Color.White
    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Dim objStreamWriter As StreamWriter
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath As String
        'F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\gem.cfg")
        'Debug.Print(path)
        MessageBox.Show(path)
        MessageBox.Show(relpath)
        'MessageBox.Show(path.Replace)
        'objStreamWriter = New StreamWriter(relpath)

        'objStreamWriter.WriteLine(tBoxCodigo.Text & "," & tBoxLongitude.Text & "," & tBoxLatitude.Text)

        'objStreamWriter.WriteLine("From the StreamWriter class")

        'objStreamWriter.Close()

        'InsertItem(pBox, tBoxCodigo, DateDate, tBoxConcelho, tBoxFreguesia, tBoxLugar, PeriodoCombo, MateriaPrimaCombo, MateriaPrimaCombo, tBoxSuporte, tBoxTecnologia, tBoxComprimento, tBoxLargura, tBoxEspessura, tBoxLatitude, tBoxLongitude, tBoxBibliografia, "Sucesso")
        My.Computer.FileSystem.WriteAllText(relpath, tBoxCodigo.Text & "," & tBoxLongitude.Text & "," & tBoxLatitude.Text, True)
        'InsertItems(pBox.Image, tBoxCodigo, tBoxFreguesia)
        InsertItemsV2(pBox, tBoxCodigo, tBoxFreguesia)
    End Sub


    'tBoxCodigo, tBoxConcelho, tBoxFreguesia, tBoxLugar, tBoxSuporte, 
    'tBoxTecnologia, tBoxComprimento, tBoxLargura, tBoxEspessura, tBoxLatitude, tBoxLongitude, BibliografiaTextBox

    Private Sub CorIconComboBox_onItemSelected(sender As Object, e As EventArgs) Handles CorIconComboBox.onItemSelected
        If CorIconComboBox.selectedValue.ToString = "Verde Claro" Or CorIconComboBox.selectedValue.ToString = "LightGreen" Then
            CorIconComboBox.NomalColor = Color.LightGreen
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Vermelho Escuro" Or CorIconComboBox.selectedValue.ToString = "DarkRed" Then
            CorIconComboBox.NomalColor = Color.DarkRed
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Branco" Or CorIconComboBox.selectedValue.ToString = "White" Then
            CorIconComboBox.NomalColor = Color.White
            CorIconComboBox.ForeColor = Color.Black
        ElseIf CorIconComboBox.selectedValue.ToString = "Roxo" Or CorIconComboBox.selectedValue.ToString = "Purple" Then
            CorIconComboBox.NomalColor = Color.Purple
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Laranja" Or CorIconComboBox.selectedValue.ToString = "Orange" Then
            CorIconComboBox.NomalColor = Color.Orange
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Azul" Or CorIconComboBox.selectedValue.ToString = "Blue" Then
            CorIconComboBox.NomalColor = Color.Blue
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Cinzento Claro" Or CorIconComboBox.selectedValue.ToString = "LightGray" Then
            CorIconComboBox.NomalColor = Color.LightGray
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Azul Claro" Or CorIconComboBox.selectedValue.ToString = "LightBlue" Then
            CorIconComboBox.NomalColor = Color.LightBlue
            CorIconComboBox.ForeColor = Color.Black
        ElseIf CorIconComboBox.selectedValue.ToString = "Cinzento" Or CorIconComboBox.selectedValue.ToString = "Gray" Then
            CorIconComboBox.NomalColor = Color.Gray
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Vermelho" Or CorIconComboBox.selectedValue.ToString = "Red" Then
            CorIconComboBox.NomalColor = Color.Red
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Verde" Or CorIconComboBox.selectedValue.ToString = "Green" Then
            CorIconComboBox.NomalColor = Color.Green
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Roxo Escuro" Or CorIconComboBox.selectedValue.ToString = "DarkPurple" Then
            CorIconComboBox.NomalColor = Color.MediumPurple
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Verde Escuro" Or CorIconComboBox.selectedValue.ToString = "DarkGreen" Then
            CorIconComboBox.NomalColor = Color.DarkGreen
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Azul Cadete" Or CorIconComboBox.selectedValue.ToString = "CadetBlue" Then
            CorIconComboBox.NomalColor = Color.CadetBlue
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Rosa" Or CorIconComboBox.selectedValue.ToString = "Pink" Then
            CorIconComboBox.NomalColor = Color.Pink
            CorIconComboBox.ForeColor = Color.White
        ElseIf CorIconComboBox.selectedValue.ToString = "Bege" Or CorIconComboBox.selectedValue.ToString = "Beige" Then
            CorIconComboBox.NomalColor = Color.Beige
            CorIconComboBox.ForeColor = Color.Black
        ElseIf CorIconComboBox.selectedValue.ToString = "Vermelho Claro" Or CorIconComboBox.selectedValue.ToString = "LightRed" Then
            CorIconComboBox.NomalColor = Color.IndianRed
            CorIconComboBox.ForeColor = Color.White
        Else
        End If
    End Sub

    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        Dim file As System.IO.StreamWriter
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath As String
        'F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\current_loc.lc")
        file = My.Computer.FileSystem.OpenTextFileWriter(relpath, True)
        file.WriteLine(tBoxLatitude.Text & "," & tBoxLongitude.Text & "," & CorIconComboBox.selectedValue.ToString & "," & tBoxLegenda.Text)
        file.Close()
    End Sub

    Private Sub pBox_Click(sender As Object, e As EventArgs) Handles pBox.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pBox.Image = Image.FromFile(opf.FileName)
            MessageBox.Show(opf.FileName)

        End If
    End Sub
End Class
