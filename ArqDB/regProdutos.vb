Public Class regProdutos

    Private Sub regProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim registo_Prod As Boolean
        registo_Prod = RegistarProduto(codprod.Text, descricao.Text, unidade.Text, preco.Text, stockmin.Text, stock.Text, iva.Text)
        If registo_Prod Then
            codprod.Text = ""
            descricao.Text = ""
            unidade.Text = ""
            preco.Text = ""
            stockmin.Text = ""
            stock.Text = ""
            iva.Text = ""
        End If
    End Sub

    Private Sub RadNif_CheckedChanged(sender As Object, e As EventArgs) Handles RadNif.CheckedChanged
        Dim sql As String
        Dim stobject As Boolean
        sql = "SELECT codprod from produtos"
        resultados.Items.Clear()
        stobject = procurar_e_apresentar(sql, resultados, "codprod")
    End Sub

    Private Sub RadNome_CheckedChanged(sender As Object, e As EventArgs) Handles RadNome.CheckedChanged
        Dim sql As String
        Dim stobject As Boolean
        sql = "SELECT descricao from produtos"
        resultados.Items.Clear()
        stobject = procurar_e_apresentar(sql, resultados, "descricao")
    End Sub

    Private Sub BtnPesquisarProduto_Click(sender As Object, e As EventArgs) Handles BtnPesquisarProduto.Click
        If RadNif.Checked Then
            'codprod -->
            'db_codprod = Add_Single_Value("SELECT codprod from produtos where descricao= '" & resultados.Text & "'", "codprod")
            codprod.Text = resultados.Text
            descricao.Text = Add_Single_Value("SELECT descricao from produtos where codprod= '" & resultados.Text & "'", "descricao")
            unidade.Text = Add_Single_Value("SELECT unidade from produtos where codprod= '" & resultados.Text & "'", "unidade")
            preco.Text = Add_Single_Value("SELECT preco from produtos where codprod= '" & resultados.Text & "'", "preco")
            stockmin.Text = Add_Single_Value("SELECT stockmin from produtos where codprod= '" & resultados.Text & "'", "stockmin")
            stock.Text = Add_Single_Value("SELECT stock from produtos where codprod= '" & resultados.Text & "'", "stock")
            iva.Text = Add_Single_Value("SELECT iva from produtos where codprod= '" & resultados.Text & "'", "iva")
        ElseIf RadNome.Checked Then
            descricao.Text = resultados.Text
            codprod.Text = Add_Single_Value("SELECT codprod from produtos where descricao='" & resultados.Text & "'", "codprod")
            unidade.Text = Add_Single_Value("SELECT unidade from produtos where descricao='" & resultados.Text & "'", "unidade")
            preco.Text = Add_Single_Value("SELECT preco from produtos where descricao='" & resultados.Text & "'", "preco")
            stockmin.Text = Add_Single_Value("SELECT stockmin from produtos where descricao='" & resultados.Text & "'", "stockmin")
            stock.Text = Add_Single_Value("SELECT stock from produtos where descricao='" & resultados.Text & "'", "stock")
            iva.Text = Add_Single_Value("SELECT iva from produtos where descricao='" & resultados.Text & "'", "iva")
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim lista_items As Boolean
        lista_items = Listar_Items("SELECT * FROM produtos", complete_list.FullDataGrid)
        complete_list.Show()
    End Sub
End Class
