Imports MySql.Data.MySqlClient
Imports System.IO
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
End Module
