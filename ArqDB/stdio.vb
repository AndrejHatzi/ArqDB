Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient

Module stdio
    'coduser automatico, data automatica
    'reduzir a quantidade do stock, fazer aba de adicionar mais stock nos produtos
    Private Function CheckUser(combobox As Object, sql As String) As Boolean
        Return 0
    End Function


    Public Function Add_to_ComboBox(sql As String, comboBox As Object, dname As String) As Boolean
        Dim conexao As New MySqlConnection()
        Dim adaptador As New MySqlDataAdapter
        Dim registos As MySqlDataReader
        conexao = New MySqlConnection
        conexao.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
        Dim comando As MySqlCommand = New MySqlCommand(sql, conexao)
        Try
            conexao.Open()
            Try
                registos = comando.ExecuteReader
                While registos.Read
                    comboBox.Items.add(registos(CStr(dname)).ToString)
                End While
                conexao.Close()
                Return 1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro1")
                Return 0
            End Try
        Catch ex As Exception
            MessageBox.Show("Erro2", ex.Message)
            Return 0
        End Try
    End Function

    Public Function Add_Single_Value(sql As String, dname As String) As String
        Dim conexao As New MySqlConnection()
        Dim adaptador As New MySqlDataAdapter
        Dim registos As MySqlDataReader
        Dim result As String
        conexao = New MySqlConnection
        conexao.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
        Dim comando As MySqlCommand = New MySqlCommand(sql, conexao)
        Try
            conexao.Open()
            Try
                registos = comando.ExecuteReader
                While registos.Read
                    'comboBox.Items.add(registos(CStr(dname)).ToString)
                    result = registos(CStr(dname)).ToString
                End While
                conexao.Close()
                Return result
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro1")
                Return "erro"

            End Try
        Catch ex As Exception
            MessageBox.Show("Erro2", ex.Message)
            Return "erro"
        End Try
    End Function
    Public Function RegistarCliente(nif As Object, nome As Object, morada As Object, cpostal As Object, localidade As Object, telemovel As Object) As Boolean
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand
        Try
            con.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
            con.Open()
            comando.Connection = con
            comando.CommandText = "INSERT INTO clientes(nif, nome, morada, cpostal, localidade, telemovel) VALUES(" & nif & ",'" & nome & "','" & morada & "','" & cpostal & "','" & localidade & "'," & telemovel & ")"
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Problema a guardar na Base de Dados!" & ex.Message, "Inserir Dados")
            Return 0
        Finally
            con.Close()
        End Try
        MessageBox.Show("Dados Inseridos com sucesso")
        Return 1
    End Function
    Public Function RegistarProduto(codprod As Object, descricao As Object, unidade As Object, preco As Object, stockmin As Object, stock As Object, iva As Object) As Boolean
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand
        Try
            con.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
            con.Open()
            comando.Connection = con
            comando.CommandText = "INSERT INTO produtos(codprod, descricao, unidade, preco, stockmin, stock, iva) VALUES('" & codprod & "','" & descricao & "','" & unidade & "'," & preco & "," & stockmin & "," & stock & "," & iva & ")"
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Problema a guardar na Base de Dados!" & ex.Message, "Inserir Dados")
            Return 0
        Finally
            con.Close()
        End Try
        MessageBox.Show("Dados Inseridos com sucesso")
        Return 1
    End Function

    Public Function Add_Vendas_Produtos(nvenda As String, codprod As String, qtd As Double, preco As Double) As Boolean
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand
        Try
            con.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
            con.Open()
            comando.Connection = con
            'MsgBox("INSERT INTO vendasprodutos(nvenda, codprod, qtd, preco) VALUES(" & nvenda & ",'" & codprod & "'," & qtd & "," & preco & ")")
            comando.CommandText = "INSERT INTO vendasprodutos(nvenda, codprod, qtd, preco) VALUES(" & nvenda & ",'" & codprod & "'," & qtd & ",'" & CStr(preco).Replace(",", ".") & "')"
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Problema a guardar na Base de Dados!" & ex.Message, "Inserir Dados")
            Return 0
        Finally
            con.Close()
        End Try
        MessageBox.Show("Dados Inseridos com sucesso")
        Return 1
    End Function
    Public Function Add_Process_Venda_Final(nvenda As String, coduser As String, nifcliente As String, tipopagamento As String, vtotal As Double) As Boolean
        'MessageBox.Show(FormatDateTime(Now, DateFormat.ShortDate))
        Dim d As DateTime = Now
        'MessageBox.Show(d.ToString("yyyy-MM-dd"))
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand
        Try
            'INSERT INTO vendas(nvenda, coduser, data, nifcliente, tipopagamento, vtotal) VALUES(1, 1, '21:21:57', 123, 'credito', 87.99)
            con.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
            con.Open()
            comando.Connection = con
            comando.CommandText = "INSERT INTO vendas(nvenda, coduser, data, nifcliente, tipopagamento, vtotal) VALUES(" & nvenda & "," & coduser & ",'" & d.ToString("yyyy-MM-dd") & "','" & nifcliente & "','" & tipopagamento & "','" & CStr(vtotal).Replace(",", ".") & "')"
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Problema a guardar na Base de Dados!" & ex.Message, "Inserir Dados")
            Return 0
        Finally
            con.Close()
        End Try
        MessageBox.Show("Dados Inseridos com sucesso")
        Return 1
    End Function
    Public Function RegistarUtilizador(coduser As Integer, nome As String, login As String, senha As String) As Boolean
        Dim d As DateTime = Now
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand
        Try
            con.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
            con.Open()
            comando.Connection = con
            comando.CommandText = "INSERT INTO utilizador(coduser, nome, login, senha) VALUES(" & coduser & ",'" & nome & "','" & login & "','" & senha & "')"
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Problema a guardar na Base de Dados!" & ex.Message, "Inserir Dados")
            Return 0
        Finally
            con.Close()
        End Try
        MessageBox.Show("Dados Inseridos com sucesso")
        Return 1
    End Function
    Public Function procurar_e_apresentar(sql As String, comboBox As Object, dname As String) As Boolean
        Dim conexao As New MySqlConnection()
        Dim adaptador As New MySqlDataAdapter
        Dim registos As MySqlDataReader
        conexao = New MySqlConnection
        conexao.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
        Dim comando As MySqlCommand = New MySqlCommand(sql, conexao)
        Try
            conexao.Open()
            Try
                registos = comando.ExecuteReader
                While registos.Read
                    comboBox.Items.add(registos(CStr(dname)).ToString)
                End While
                conexao.Close()
                Return 1
            Catch ex As Exception
                MessageBox.Show("Erro1", ex.Message)
                Return 0
            End Try
        Catch ex As Exception
            MessageBox.Show("Erro2", ex.Message)
            Return 0
        End Try
    End Function
    Public Function Delete_From_Base_de_dados(sql) As Boolean
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Try
            con.ConnectionString = "SERVER=localhost; user=root; password=''; database=loja_abc"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
            Return 0
        Finally

            con.Close()
        End Try
        Return 1
    End Function
    Public Function Listar_Items(sql As String, datagridview As Object) As Boolean
        Dim registos As MySqlDataReader
        Dim adaptador As New MySqlDataAdapter
        Dim dados As New DataTable
        Dim bsource As New BindingSource
        Dim conexao As New MySqlConnection()
        conexao.ConnectionString = "SERVER=localhost; user=root; password='';database=loja_abc"
        Try
            conexao.Open()

            Dim comando As MySqlCommand = New MySqlCommand(sql, conexao)

            adaptador.SelectCommand = comando
            adaptador.Fill(dados)
            bsource.DataSource = dados
            datagridview.DataSource = bsource
            adaptador.Update(dados)

            conexao.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao tentar ler a DB", ex.Message)
            Return 0
        Finally
            conexao.Dispose()
        End Try
        Return 1
    End Function
    ''https://www.youtube.com/watch?v=3ZjsimNLdLY
    Public Function InsertItem(pBox As Object, Code As Object, DateDate As Object, TownHall As Object, Parish As Object, Place As Object, Epoch As Object, RawMaterial As Object, Description As Object, Base As Object, Technology As Object, Length As Object, Width As Object, Thickness As Object, Latitude As Object, Longitude As Object, Bibliography As Object, Message As String) As Boolean
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand



        'Code As String, DateDate As String, TownHall As String, Parish As String, Place As String, Epoch As String, RawMaterial As String, Description As String, Base As String, Technology As String, Length As String, Width As String, Thickness As String, Latitude As String, Longitude As String, Bibliography As String, Message As String
        Dim connection As New MySqlConnection("SERVER=localhost; user=root; password=''; database=arq_db")
        Dim ms As New MemoryStream
        pBox.Image.Save(ms, pBox.Image.RawFormat)
        '"INSERT INTO items(Cod, Date, TownHall, Parish, Place, Epoch, RawMaterial, Description, Base, Technology, Length, Width, Thickness, Latitude, Longitude, Bibliografia) VALUES(" & Code & ",'" & DateDate & "','" & TownHall & "','" & Parish & "','" & Place & "','" & Epoch & "','" & RawMaterial & "','" & Description & "','" & Base & "','" & Technology & "'," & Length & "," & Width & "," & Thickness & "," & Latitude & "," & Longitude & ",'" & Bibliography & "')"
        Dim command As New MySqlCommand("INSERT INTO items(Cod, Date, TownHall, Parish, Place, Epoch, RawMaterial, Description, Base, Technology, Length, Width, Thickness, Latitude, Longitude, Bibliografia, Image)" _
        & "VALUES (@cod,@Date,@TH,@Par,@Pl,@Epoch,@RM,@Des,@Bs,@Tech,@Lth,@Wth,@Thk,@Lat,@Lon,@Bib,@Img)", connection)

        'command.Parameters.Add("@nm", MySqlDbType.Int16).Value = Code.Text
        'command.Parameters.Add("@Date", MySqlDbType.Date).Value = DateDate.Value.ToString("yyyy-MM-dd")
        'command.Parameters.Add("@TH", MySqlDbType.VarChar).Value = TownHall.Text
        'command.Parameters.Add("@Par", MySqlDbType.VarChar).Value = Parish.Text
        'command.Parameters.Add("@Pl", MySqlDbType.VarChar).Value = Place.Text
        'command.Parameters.Add("@Epoch", MySqlDbType.VarChar).Value = Epoch.Text
        'command.Parameters.Add("@RM", MySqlDbType.VarChar).Value = RawMaterial.Text
        'command.Parameters.Add("@Des", MySqlDbType.VarChar).Value = Description.Text
        'command.Parameters.Add("@Bs", MySqlDbType.VarChar).Value = Base.Text
        'command.Parameters.Add("@Tech", MySqlDbType.VarChar).Value = Technology.Text
        'command.Parameters.Add("@Lth", MySqlDbType.Double).Value = Length.Text
        'command.Parameters.Add("@Wth", MySqlDbType.Double).Value = Width.Text
        'command.Parameters.Add("@Thk", MySqlDbType.Double).Value = Thickness.Text
        'command.Parameters.Add("@Lat", MySqlDbType.Double).Value = Latitude.Text
        'command.Parameters.Add("@Lon", MySqlDbType.Double).Value = Longitude.Text
        'command.Parameters.Add("@Bib", MySqlDbType.VarChar).Value = Bibliography.Text
        'command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()



        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Image Inserted")
            MessageBox.Show(Message)
            Return 1
        Else
            MessageBox.Show("Image Not Inserted")
            Return 0
        End If

        connection.Close()

    End Function





    '    Try
    '        con.ConnectionString = "SERVER=localhost; user=root; password=''; database=arq_db"
    '        con.Open()
    '        comando.Connection = con
    '        comando.CommandText = "INSERT INTO items(Cod, Date, TownHall, Parish, Place, Epoch, RawMaterial, Description, Base, Technology, Length, Width, Thickness, Latitude, Longitude, Bibliografia) VALUES(" & Code & ",'" & DateDate & "','" & TownHall & "','" & Parish & "','" & Place & "','" & Epoch & "','" & RawMaterial & "','" & Description & "','" & Base & "','" & Technology & "'," & Length & "," & Width & "," & Thickness & "," & Latitude & "," & Longitude & ",'" & Bibliography & "')"
    '        comando.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MessageBox.Show("Problema a guardar na Base de Dados!" & ex.Message, "Inserir Dados")
    '        Return 0
    '    Finally
    '        con.Close()
    '    End Try
    '    MessageBox.Show(Message)
    '    Return 1
    'End Function

    Public Sub store_pic_Sql(ByVal img As Image)

        'for sql server
        Dim conn As SqlConnection = New SqlConnection()
        conn.ConnectionString = "SERVER=localhost; user=root; password=''; database=arq_db"

        'for SQL 
        Dim sql As String = "insert into picture values(1,@imgData)"
        Dim command1 As SqlCommand = New SqlCommand(sql, conn)
        Dim sqlpara As New SqlParameter("imgData", SqlDbType.Image)

        Dim mStream As MemoryStream = New MemoryStream()
        img.Save(mStream, ImageFormat.Jpeg)
        sqlpara.SqlValue = mStream.GetBuffer

        command1.Parameters.Add(sqlpara)
        conn.Open()
        command1.ExecuteNonQuery()
        conn.Close()
    End Sub
    'Public Sub InsertItems(ByVal img As Image, Code As Object, Freguesia As Object)
    '    Dim conn As SqlConnection = New SqlConnection()
    '    conn.ConnectionString = "SERVER=localhost; user=root; password=''; database=bd_exe"
    '    Dim sql As String = "insert into teste(" & Code.text & ",'" & Freguesia.text & "',@foto)"

    '    Dim command1 As SqlCommand = New SqlCommand(sql, conn)
    '    Dim sqlpara As New SqlParameter("foto", SqlDbType.Image)

    '    Dim mStream As MemoryStream = New MemoryStream()
    '    img.Save(mStream, ImageFormat.Jpeg)

    '    sqlpara.SqlValue = mStream.GetBuffer
    '    command1.Parameters.Add(sqlpara)
    '    conn.Open()
    '    command1.ExecuteNonQuery()
    '    conn.Close()

    'End Sub
    Public Sub InsertItemsV2(pbox As Object, code As Object, freguesia As Object)
        Dim con As New MySqlConnection()
        Dim comando As New MySqlCommand

        Dim connection As New MySqlConnection("SERVER=localhost; user=root; password=''; database=arq_db")
        Dim ms As New MemoryStream
        pbox.Image.Save(ms, pbox.Image.RawFormat)
        Dim command As New MySqlCommand("INSERT INTO teste(code, freguesia, foto) VALUES (" & code.text & ",'" & freguesia.text & "',@img)", connection)
        command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()
        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Image Inserted")
        Else
            MessageBox.Show("Image Not Inserted")
        End If

        connection.Close()
    End Sub
    Public Sub RetrieveImage(pbox As Object)
        Dim cnn As SqlConnection
        Dim connectionString As String
        connectionString = "SERVER=localhost; user=root; password=''; database=bd_exe"
        cnn = New SqlConnection(connectionString)

        Dim stream As New MemoryStream()
        cnn.Open()
        Dim command As New SqlCommand("select img from imgtable where id=1", cnn)
        Dim image As Byte() = DirectCast(command.ExecuteScalar(), Byte())
        stream.Write(image, 0, image.Length)
        cnn.Close()
        Dim bitmap As New Bitmap(stream)
        pbox.Image = bitmap
    End Sub

    'Public Sub RetrieveImageV2()
    '    Dim sql As String
    '    Dim registos As MySqlDataReader
    '    Dim conexao = New MySqlConnection
    '    conexao.ConnectionString = "SERVER=localhost; user=root; password=''; database=bd_exe"
    '    sql = "SELECT * FROM disciplinas WHERE disciplinaID = '" + cod_disc.Text + "'"
    'End Sub

    'If (Not (cod_disc.Text = "")) Then
    ''ligacao á bd procura da disciplina
    'Dim sql As String
    'Dim registos As MySqlDataReader
    'Dim conexao = New MySqlConnection
    'Dim dados As New DataTable
    '        conexao.ConnectionString = "SERVER=localhost; user=root; password=''; database=escola"




    '        sql = "SELECT * FROM disciplinas WHERE disciplinaID = '" + cod_disc.Text + "'"
    'Dim comando As MySqlCommand = New MySqlCommand(Sql, conexao)
    '        Try
    '            conexao.Close()
    '            conexao.Open()

    '            registos = comando.ExecuteReader


    '            While registos.Read

    '                nome_disc.Text = registos("disciplina").ToString

    '                nr_mods.Value = CInt(registos("nmodulos").ToString)

    '            End While


    '        Catch erro As MySqlException
    '            MessageBox.Show("Erro ao tentar ligar com o banco de dados", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            conexao.Dispose()
    '        End Try
    '    End If
End Module
