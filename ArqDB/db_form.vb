Imports System.IO
Imports MySql.Data.MySqlClient
'resto de talhe - desperdicio - lascas que saltam pequeninas
'nome
'

Public Class db_form

    Private Sub db_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColourSelector.Visible = 0
        ImgIndicator.Visible = 0

        'Dim path As String = My.Application.Info.DirectoryPath
        'Dim relpath, primeira_linha As String
        'Dim fileReader As System.IO.StreamReader
        'relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\lastitem.item")
        'fileReader = My.Computer.FileSystem.OpenTextFileReader(relpath)
        'primeira_linha = fileReader.ReadLine()
        'If File.Exists(relpath) Then
        'If Form1.Options1.language = 0 Then
        ' tBoxCodigo.Text = "Ultimo Código foi " & primeira_linha
        ' Else
        ' tBoxCodigo.Text = "Last written code was " & primeira_linha
        'End If
        'Else
        'tBoxCodigo.Text = ""
        'End If




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

    Private Sub tBoxCodigo_GotFocus(sender As Object, e As EventArgs) Handles tBoxCodigo.GotFocus
        If Form1.Options1.language = 0 Then
            If tBoxCodigo.Text.Contains("Ultimo Código foi ") Then
                tBoxCodigo.Text = ""
            End If
        Else
            If tBoxCodigo.Text.Contains("Last written code was ") Then
                tBoxCodigo.Text = ""
            End If
        End If

        'If tBoxCodigo.Text.Length  Then
        'tBoxCodigo.Text = ""
        'End If
    End Sub

    Private Sub tBoxCodigo_LostFocus(sender As Object, e As EventArgs) Handles tBoxCodigo.LostFocus
        Dim fileReader As System.IO.StreamReader
        Dim primeira_linha As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath As String
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\lastitem.item")
        fileReader = My.Computer.FileSystem.OpenTextFileReader(relpath)
        primeira_linha = fileReader.ReadLine()
        If Form1.Options1.language = 0 Then
            If tBoxCodigo.Text = "" Then
                tBoxCodigo.Text = "Ultimo Código foi " & primeira_linha
            End If
        Else
            If tBoxCodigo.Text = "" Then
                tBoxCodigo.Text = "Last written code was " & primeira_linha
            End If
        End If

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

    Private Sub tBoxLegenda_OnValueChanged(sender As Object, e As EventArgs) Handles tBoxLegenda.OnValueChanged
        tBoxLegenda.HintForeColor = Color.White
        tBoxLegenda.ForeColor = Color.White
    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim sqrColour
        'Dim file As System.IO.StreamWriter
        'Dim path As String = My.Application.Info.DirectoryPath
        'Dim relpath As String
        ''F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        'relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\lastitem.item")
        'Try
        '    My.Computer.FileSystem.DeleteFile(relpath)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try

        'file = My.Computer.FileSystem.OpenTextFileWriter(relpath, True)
        'file.WriteLine(tBoxCodigo.Text)
        'file.Close()
        ', Message As String
        'Message = "Escolha uma cor para o Icone"
        'DescricaoCombo.selectedValue.ToString()
        'Dim objStreamWriter As StreamWriter
        'Dim path As String = My.Application.Info.DirectoryPath
        'Dim relpath As String
        'F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        'relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\gem.cfg")
        'Debug.Print(path)
        'MessageBox.Show(path)
        'MessageBox.Show(relpath)
        'MessageBox.Show(path.Replace)
        'objStreamWriter = New StreamWriter(relpath)
        'objStreamWriter.WriteLine(tBoxCodigo.Text & "," & tBoxLongitude.Text & "," & tBoxLatitude.Text)
        'objStreamWriter.WriteLine("From the StreamWriter class")
        'objStreamWriter.Close()
        'InsertItem(pBox, tBoxCodigo, DateDate, tBoxConcelho, tBoxFreguesia, tBoxLugar, PeriodoCombo, MateriaPrimaCombo, MateriaPrimaCombo, tBoxSuporte, tBoxTecnologia, tBoxComprimento, tBoxLargura, tBoxEspessura, tBoxLatitude, tBoxLongitude, tBoxBibliografia, "Sucesso")
        'My.Computer.FileSystem.WriteAllText(relpath, tBoxCodigo.Text & "," & tBoxLongitude.Text & "," & tBoxLatitude.Text, True)
        'InsertItems(pBox.Image, tBoxCodigo, tBoxFreguesia)
        'InsertItemsV2(pBox, tBoxCodigo, tBoxFreguesia)

        


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

            tBoxLatitude.Text = Message
            tBoxLatitude.HintForeColor = Color.Red
            tBoxLatitude.ForeColor = Color.Red
        End If
        If tBoxLongitude.Text.Length = 0 Then
            tBoxLongitude.Text = Message
            tBoxLongitude.HintForeColor = Color.Red
            tBoxLongitude.ForeColor = Color.Red
        End If
        If tBoxLegenda.Text.Length = 0 Then
            tBoxLegenda.Text = Message
            tBoxLegenda.HintForeColor = Color.Red
            tBoxLegenda.ForeColor = Color.Red
        End If
        If pBox.Image Is Nothing Then
            ImgIndicator.Visible = 1
        End If

        If (tBoxCodigo.Text <> "" And tBoxConcelho.Text <> "" And tBoxFreguesia.Text <> "" And tBoxLugar.Text <> "" And tBoxSuporte.Text <> "" And tBoxTecnologia.Text <> "" And tBoxComprimento.Text <> "" And tBoxLargura.Text <> "" And tBoxEspessura.Text <> "" And tBoxLatitude.Text <> "" And tBoxLongitude.Text <> "") Then
            If (PeriodoCombo.selectedIndex <> -1 And MateriaPrimaCombo.selectedIndex <> -1 And DescricaoCombo.selectedIndex <> -1 And pBox.Image Is Nothing = False) Then
                InsertItemsDatabase(pBox, tBoxCodigo, DateDate.Value.ToString("yyyy-MM-dd"), tBoxConcelho, tBoxFreguesia, tBoxLugar, PeriodoCombo, MateriaPrimaCombo, DescricaoCombo, tBoxSuporte, tBoxTecnologia, tBoxComprimento, tBoxLargura, tBoxEspessura, tBoxLatitude, tBoxLongitude, "Erro ao Inserir Dados")
                If ColourSelector.Location.X = ColourBlue.Location.X Then
                    sqrColour = "cadetblue"
                ElseIf ColourSelector.Location.X = ColourOrange.Location.X Then
                    sqrColour = "orange"
                ElseIf ColourSelector.Location.X = ColourRed.Location.X Then
                    sqrColour = "red"
                ElseIf ColourSelector.Location.X = ColourPurple.Location.X Then
                    sqrColour = "purple"
                ElseIf ColourSelector.Location.X = ColourPink.Location.X Then
                    sqrColour = "pink"
                End If
                If sqrColour <> "" Then
                    InsertMarkersDatabase(tBoxCodigo, tBoxLatitude, tBoxLongitude, sqrColour, tBoxLegenda, "Generico")
                End If
            End If
        End If



    End Sub


    'tBoxCodigo, tBoxConcelho, tBoxFreguesia, tBoxLugar, tBoxSuporte, 
    'tBoxTecnologia, tBoxComprimento, tBoxLargura, tBoxEspessura, tBoxLatitude, tBoxLongitude, BibliografiaTextBox

    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        Dim sqrColour, Message, aviso, NotFilled As String
        Dim latP, logP, legP As Integer

        latP = logP = legP = 0

        If Form1.Options1.language = 0 Then
            Message = "Escolha uma cor para o Icone!"
            aviso = "Aviso"
        Else
            Message = "Choose a colour for the Icon"
            aviso = "Warning"
        End If

        If Form1.Options1.language = 0 Then
            NotFilled = "Não Preenchido"
        ElseIf Form1.Options1.language = 1 Then
            NotFilled = "Not Filled"
        End If

        If ColourSelector.Location.X = ColourBlue.Location.X Then
            sqrColour = "cadetblue"
        ElseIf ColourSelector.Location.X = ColourOrange.Location.X Then
            sqrColour = "orange"
        ElseIf ColourSelector.Location.X = ColourRed.Location.X Then
            sqrColour = "red"
        ElseIf ColourSelector.Location.X = ColourPurple.Location.X Then
            sqrColour = "purple"
        ElseIf ColourSelector.Location.X = ColourPink.Location.X Then
            sqrColour = "pink"
        Else
            MessageBox.Show(Message, aviso)
        End If

        If tBoxLatitude.Text.Length = 0 Then
            tBoxLatitude.Text = NotFilled
            tBoxLatitude.HintForeColor = Color.Red
            tBoxLatitude.ForeColor = Color.Red
        Else
            latP = 1
        End If

        If tBoxLongitude.Text.Length = 0 Then
            tBoxLongitude.Text = NotFilled
            tBoxLongitude.HintForeColor = Color.Red
            tBoxLongitude.ForeColor = Color.Red
        Else
            logP = 1
        End If
        If tBoxLegenda.Text.Length = 0 Then
            tBoxLegenda.Text = NotFilled
            tBoxLegenda.HintForeColor = Color.Red
            tBoxLegenda.ForeColor = Color.Red
        Else
            legP = 1
        End If

        If logP = 1 And latP = 1 And legP = 1 Then
            CreateMapHTML(tBoxLatitude.Text, tBoxLongitude.Text, sqrColour, tBoxLegenda.Text)
        End If
    End Sub

    Private Sub pBox_Click(sender As Object, e As EventArgs) Handles pBox.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pBox.Image = Image.FromFile(opf.FileName)
            MessageBox.Show(opf.FileName)

        End If
    End Sub

    Private Sub ColourPink_Click(sender As Object, e As EventArgs) Handles ColourPink.Click
        ColourSelector.Visible = 1
        ColourSelector.Width = ColourPink.Width
        ColourSelector.Top = ColourPink.Top
        ColourSelector.Location = New Point(ColourPink.Location.X, ColourPink.Location.Y)
    End Sub

    Private Sub ColourPurple_Click(sender As Object, e As EventArgs) Handles ColourPurple.Click
        ColourSelector.Visible = 1
        ColourSelector.Width = ColourPurple.Width
        ColourSelector.Top = ColourPurple.Top
        ColourSelector.Location = New Point(ColourPurple.Location.X, ColourPurple.Location.Y)
    End Sub

    Private Sub ColourRed_Click(sender As Object, e As EventArgs) Handles ColourRed.Click
        ColourSelector.Visible = 1
        ColourSelector.Width = ColourRed.Width
        ColourSelector.Top = ColourRed.Top
        ColourSelector.Location = New Point(ColourRed.Location.X, ColourRed.Location.Y)
    End Sub

    Private Sub ColourOrange_Click(sender As Object, e As EventArgs) Handles ColourOrange.Click
        ColourSelector.Visible = 1
        ColourSelector.Width = ColourOrange.Width
        ColourSelector.Top = ColourOrange.Top
        ColourSelector.Location = New Point(ColourOrange.Location.X, ColourOrange.Location.Y)
    End Sub

    Private Sub ColourBlue_Click(sender As Object, e As EventArgs) Handles ColourBlue.Click
        ColourSelector.Visible = 1
        ColourSelector.Width = ColourBlue.Width
        ColourSelector.Top = ColourBlue.Top
        ColourSelector.Location = New Point(ColourBlue.Location.X, ColourBlue.Location.Y)
    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        'MessageBox.Show(DateDate.Value.ToString("yyyy-MM-dd"))
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath, primeira_linha As String
        Dim fileReader As System.IO.StreamReader
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\lastcode.cd")
        fileReader = My.Computer.FileSystem.OpenTextFileReader(relpath)
        primeira_linha = fileReader.ReadLine()
        MessageBox.Show(primeira_linha)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand
        Try
            con.ConnectionString = "SERVER=localhost; user=root; password=''; database=arq_db"
            con.Open()
            comando.Connection = con
            comando.CommandText = "INSERT INTO teste(code, freguesia, Date) VALUES(" & tBoxCodigo.Text & ",'" & tBoxFreguesia.Text & "','" & DateDate.Value.ToString("yyyy-MM-dd") & "')"
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro de teste" & ex.Message, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnLocalizarTodos_Click(sender As Object, e As EventArgs) Handles BtnLocalizarTodos.Click
        CreateMapMultipleLocations()
    End Sub
End Class
