Public Class regCliente

    Private Sub regCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim genericVar As Boolean
        Dim sMsk As String
        genericVar = RegistarCliente(nif.Text, nome.Text, morada.Text, cpostal.Text, localidade.Text, telemovel.Text)
        If genericVar Then
            nif.Text = ""
            nome.Text = ""
            morada.Text = ""
            sMsk = cpostal.Mask
            cpostal.Mask = ""
            cpostal.Text = ""
            cpostal.Mask = sMsk
            localidade.Text = ""
            sMsk = telemovel.Mask
            telemovel.Mask = ""
            telemovel.Text = ""
            telemovel.Mask = sMsk
        End If
    End Sub

    Private Sub RadNif_CheckedChanged(sender As Object, e As EventArgs) Handles RadNif.CheckedChanged
        Dim sql As String
        Dim stobject As Boolean
        sql = "SELECT nif from clientes"
        resultados.Items.Clear()
        stobject = procurar_e_apresentar(sql, resultados, "nif")
    End Sub

    Private Sub RadNome_CheckedChanged(sender As Object, e As EventArgs) Handles RadNome.CheckedChanged
        Dim sql As String
        Dim stobject As Boolean
        sql = "SELECT nome from clientes"
        resultados.Items.Clear()
        stobject = procurar_e_apresentar(sql, resultados, "nome")
    End Sub

    Private Sub BtnEliminaClientes_Click(sender As Object, e As EventArgs) Handles BtnEliminaClientes.Click
        Dim cliente_na_base_de_dados As String
        Dim sql As String
        'SELECT vendas.nifcliente from vendas, clientes where clientes.nif = vendas.nifcliente

        If RadNif.Checked Then
            sql = "SELECT nifcliente from vendas where nifcliente = '" & resultados.Text & "'"
            cliente_na_base_de_dados = Add_Single_Value(sql, "nifcliente")
            'MessageBox.Show(cliente_na_base_de_dados)
            If cliente_na_base_de_dados = resultados.Text Then
                MessageBox.Show("ALERTA", "Não é possivel eliminar o cliente!!")
            Else
                sql = "DELETE FROM clientes where nif='" & resultados.Text & "'"
                Dim eliminar_from_database As Boolean
                eliminar_from_database = Delete_From_Base_de_dados(sql)
                MessageBox.Show("Alerta", "Cliente eliminado!")
            End If
        End If
        If RadNome.Checked Then
            sql = "SELECT nifcliente from vendas, clientes where nifcliente = clientes.nif and clientes.nome ='" & resultados.Text & "'"
            cliente_na_base_de_dados = Add_Single_Value(sql, "nifcliente")
            'MessageBox.Show(cliente_na_base_de_dados)
            If cliente_na_base_de_dados <> "" Then
                MessageBox.Show("ALERTA", "Não é possivel eliminar o cliente!!")
            Else
                sql = "DELETE FROM clientes where nome='" & resultados.Text & "'"
                Dim eliminar_from_database As Boolean
                eliminar_from_database = Delete_From_Base_de_dados(sql)
                MessageBox.Show("Alerta", "Cliente eliminado!")
            End If

        End If
        resultados.Text = ""
        nif.Text = ""
        nome.Text = ""
        morada.Text = ""
        cpostal.Text = ""
        localidade.Text = ""
        telemovel.Text = ""

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub resultados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles resultados.SelectedIndexChanged
        If RadNif.Checked Then
            nif.Text = resultados.Text
            'descricao.Text = Add_Single_Value("SELECT descricao from produtos where codprod= '" & resultados.Text & "'", "descricao")
            nome.Text = Add_Single_Value("SELECT nome from clientes where nif='" & resultados.Text & "'", "nome")
            morada.Text = Add_Single_Value("SELECT morada from clientes where nif='" & resultados.Text & "'", "morada")
            cpostal.Text = Add_Single_Value("SELECT cpostal from clientes where nif='" & resultados.Text & "'", "cpostal")
            localidade.Text = Add_Single_Value("SELECT localidade from clientes where nif='" & resultados.Text & "'", "localidade")
            telemovel.Text = Add_Single_Value("SELECT telemovel from clientes where nif='" & resultados.Text & "'", "telemovel")

        ElseIf RadNome.Checked Then
            nome.Text = resultados.Text
            nif.Text = Add_Single_Value("SELECT nif from clientes where nome='" & resultados.Text & "'", "nif")
            morada.Text = Add_Single_Value("SELECT morada from clientes where nome='" & resultados.Text & "'", "morada")
            cpostal.Text = Add_Single_Value("SELECT cpostal from clientes where nome='" & resultados.Text & "'", "cpostal")
            localidade.Text = Add_Single_Value("SELECT localidade from clientes where nome='" & resultados.Text & "'", "localidade")
            telemovel.Text = Add_Single_Value("SELECT telemovel from clientes where nome='" & resultados.Text & "'", "telemovel")
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim lista_items As Boolean
        lista_items = Listar_Items("SELECT * FROM clientes", complete_list.FullDataGrid)
        complete_list.Show()
    End Sub
End Class
