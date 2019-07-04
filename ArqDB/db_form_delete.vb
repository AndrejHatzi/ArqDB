Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class db_form_delete

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles updatebutton.Click
        Dim code As String
        Dim materiaprima, periodo, descricao, colour As String

        If Form1.Options1.language = 0 Then
            Dim MateriasPrimas() As String = {"Quartzo", "Quartzo Hialino", "Quartzo Leitoso", "Quartzito", "Sílex", "Granito", "Xisto", "Calcário", "Obsidiana"}
            Dim PeriodoArray() As String = {"Alta Idade Média", "Baixa Idade Média", "Calcolítico", "Contemporâneo", "Epipaleolítico", "Idade Média", "Idade do Bronze", "Idade do Ferro", "Medieval Cristão", "Medieval Islâmico", "Mesolítico", "Moderno", "Neolítico", "Paleolítico", "Paleolítico Inferior", "Paleolítico Médio", "Paleolítico Superior", "Romano", "Indeterminado"}
            Dim descricaoArray() As String = {"Lasca", "Seixo Talhado", "Núcleo", "Movente", "Resto de Talhe", "Esquírola", "Indeterminado"}
            'Try
            code = DataItems.CurrentRow.Cells(0).Value.ToString()

            Form1.Db_form1.tBoxCodigo.Text = Add_Single_Value("SELECT Cod from items where Cod='" & code & "'", "cod")
            Form1.Db_form1.DateDate.Value = Add_Single_Value("SELECT Date from items where Cod='" & code & "'", "Date")
            Form1.Db_form1.tBoxConcelho.Text = Add_Single_Value("SELECT TownHall from items where Cod='" & code & "'", "TownHall")
            Form1.Db_form1.tBoxFreguesia.Text = Add_Single_Value("SELECT Parish from items where Cod='" & code & "'", "Parish")
            Form1.Db_form1.tBoxLugar.Text = Add_Single_Value("SELECT Place from items where Cod='" & code & "'", "Place")
            Form1.Db_form1.tBoxSuporte.Text = Add_Single_Value("SELECT Base from items where Cod='" & code & "'", "Base")
            Form1.Db_form1.tBoxTecnologia.Text = Add_Single_Value("SELECT Technology from items where Cod='" & code & "'", "Technology")
            Form1.Db_form1.tBoxComprimento.Text = Add_Single_Value("SELECT Length from items where Cod='" & code & "'", "Length")
            Form1.Db_form1.tBoxLargura.Text = Add_Single_Value("SELECT Width from items where Cod='" & code & "'", "Width")
            Form1.Db_form1.tBoxEspessura.Text = Add_Single_Value("SELECT Thickness from items where Cod='" & code & "'", "Thickness")
            Form1.Db_form1.tBoxLatitude.Text = Add_Single_Value("SELECT Latitude from items where Cod='" & code & "'", "Latitude")
            Form1.Db_form1.tBoxLongitude.Text = Add_Single_Value("SELECT Longitude from items where Cod='" & code & "'", "Longitude")

            materiaprima = Add_Single_Value("SELECT RawMaterial from items where Cod='" & code & "'", "RawMaterial")
            periodo = Add_Single_Value("SELECT Epoch from items where Cod='" & code & "'", "Epoch")
            descricao = Add_Single_Value("SELECT Description from items where Cod='" & code & "'", "Description")

            For m As Integer = 0 To MateriasPrimas.Length - 1
                If materiaprima = MateriasPrimas(m).ToString Then
                    Form1.Db_form1.MateriaPrimaCombo.selectedIndex = m
                End If
            Next

            For p As Integer = 0 To PeriodoArray.Length - 1
                If periodo = PeriodoArray(p).ToString Then
                    Form1.Db_form1.PeriodoCombo.selectedIndex = p
                End If
            Next

            For d As Integer = 0 To descricaoArray.Length - 1
                If descricao = descricaoArray(d).ToString Then
                    Form1.Db_form1.DescricaoCombo.selectedIndex = d
                End If
            Next

            RetrieveImageV3(Form1.Db_form1.pBox, "SELECT Image from items where Cod='" & code & "'")
            colour = Add_Single_Value("SELECT Colour from markers where Cod='" & code & "'", "Colour")

            If colour = "cadetblue" Then
                Form1.Db_form1.ColourSelector.Visible = 1
                Form1.Db_form1.ColourSelector.Width = Form1.Db_form1.ColourBlue.Width
                Form1.Db_form1.ColourSelector.Top = Form1.Db_form1.ColourBlue.Top
                Form1.Db_form1.ColourSelector.Location = New Point(Form1.Db_form1.ColourBlue.Location.X, Form1.Db_form1.ColourBlue.Location.Y)
            End If
            If colour = "red" Then
                Form1.Db_form1.ColourSelector.Visible = 1
                Form1.Db_form1.ColourSelector.Width = Form1.Db_form1.ColourRed.Width
                Form1.Db_form1.ColourSelector.Top = Form1.Db_form1.ColourRed.Top
                Form1.Db_form1.ColourSelector.Location = New Point(Form1.Db_form1.ColourRed.Location.X, Form1.Db_form1.ColourRed.Location.Y)
            End If
            If colour = "orange" Then
                Form1.Db_form1.ColourSelector.Visible = 1
                Form1.Db_form1.ColourSelector.Width = Form1.Db_form1.ColourOrange.Width
                Form1.Db_form1.ColourSelector.Top = Form1.Db_form1.ColourOrange.Top
                Form1.Db_form1.ColourSelector.Location = New Point(Form1.Db_form1.ColourOrange.Location.X, Form1.Db_form1.ColourOrange.Location.Y)
            End If
            If colour = "pink" Then
                Form1.Db_form1.ColourSelector.Visible = 1
                Form1.Db_form1.ColourSelector.Width = Form1.Db_form1.ColourPink.Width
                Form1.Db_form1.ColourSelector.Top = Form1.Db_form1.ColourPink.Top
                Form1.Db_form1.ColourSelector.Location = New Point(Form1.Db_form1.ColourPink.Location.X, Form1.Db_form1.ColourPink.Location.Y)
            End If
            If colour = "purple" Then
                Form1.Db_form1.ColourSelector.Visible = 1
                Form1.Db_form1.ColourSelector.Width = Form1.Db_form1.ColourPurple.Width
                Form1.Db_form1.ColourSelector.Top = Form1.Db_form1.ColourPurple.Top
                Form1.Db_form1.ColourSelector.Location = New Point(Form1.Db_form1.ColourPurple.Location.X, Form1.Db_form1.ColourPurple.Location.Y)
            End If

            Form1.Db_form1.tBoxLegenda.Text = Add_Single_Value("SELECT Label from markers where Cod='" & code & "'", "Label")
        ElseIf Form1.Options1.language = 1 Then
            MessageBox.Show("English is not supported to Update")
        End If

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim code As String
        code = DataItems.CurrentRow.Cells(0).Value.ToString()
        If Form1.Options1.language = 0 Then
            DeleteItem(code, "Quer eliminar esta peça?")
            DeleteMarker(code)
        End If
        If Form1.Options1.language = 1 Then
            DeleteItem(code, "Do you really want to Delete this Record?")
            DeleteMarker(code)
        End If
        DataItems.DataSource = Nothing
        Dim connection As New MySqlConnection()
        Dim table As New DataTable()
        connection.ConnectionString = "SERVER=localhost; user=root; password=''; database=arq_db"
        Dim sql As String
        If Form1.Options1.language = 0 Then
            sql = "SELECT Cod as 'Codigo', Date as 'Data', TownHall as 'Concelho', Parish as 'Freguesia', Place as 'Lugar', Epoch as 'Periodo', RawMaterial as 'Materia Prima', Description as 'Descricao', Base as 'Suporte', Technology as 'Tecnologia', Length as 'Comprimento', Width as 'Largura', Thickness as 'Espessura', Latitude, Longitude from items"
        Else
            sql = "SELECT Cod, Date, TownHall, Parish, Place, Epoch, RawMaterial, Description, Base, Technology, Length, Width, Thickness, Latitude, Longitude from items"
        End If
        Dim adapter As New MySqlDataAdapter(sql, connection)
        adapter.Fill(table)
        DataItems.DataSource = table
    End Sub
End Class