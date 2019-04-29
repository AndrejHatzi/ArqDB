Public Class reg_vendas
    Dim total As Double
    Private Sub nvenda_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nvenda.GotFocus
        If nvenda.Text = "exemplo: 12345" Then
            nvenda.Text = ""

            nvenda.ForeColor = Color.Black
        End If
    End Sub
    Private Sub nvenda_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nvenda.LostFocus
        If nvenda.Text = "" Then
            nvenda.Text = "exemplo: 12345"
            nvenda.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub reg_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vendedores As Boolean
        vendedores = Add_to_ComboBox("SELECT coduser from utilizador", codvendedor, "coduser")
        Dim clientes As Boolean
        clientes = Add_to_ComboBox("SELECT nif from clientes", nif, "nif")
        pagamento.Items.Add("Numerario")
        pagamento.Items.Add("Cheque")
        pagamento.Items.Add("Credito")
        pagamento.Items.Add("Debito")
        pagamento.Items.Add("TransfBancaria")
        Dim produtos As Boolean
        produtos = Add_to_ComboBox("SELECT codprod from produtos", cod_prod, "codprod")
        'Dim codUser As String
        'Dim sql As String
        'sql = "SELECT coduser from utilizador where login ='" & Form1.EmbLogin1.LoginForm.Text & "' and senha = '" & Form1.EmbLogin1.PassForm.Text & "'"
        'codUser = Add_Single_Value(sql, "coduser")
        'MessageBox.Show(codUser)
        'coduserlogin.Text = codUser
        'Dim genericItem As Boolean
        nvenda.Text = "exemplo: 12345"
        nvenda.ForeColor = Color.Gray
        'add_codigo_cliente.Visible = False
        'adicionar.Visible = False
        'genericItem = Add_to_ComboBox("", codcliente, "")

    End Sub

    Private Sub nif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nif.SelectedIndexChanged
        Dim sql, cliente_nome As String
        sql = "SELECT nome from clientes where nif=" & nif.Text
        cliente_nome = Add_Single_Value(sql, "nome")
        If cliente_nome = "erro" Then
            MessageBox.Show("Cliente ainda não existe na Base de Dados!", "Erro")
        Else
            nome.Text = cliente_nome
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub cod_prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod_prod.SelectedIndexChanged
        Dim prod_nome, preco, iva As String
        Dim sql As String
        sql = "SELECT descricao from produtos where codprod ='" & cod_prod.Text & "'"
        prod_nome = Add_Single_Value(sql, "descricao")
        nome_prod.Text = prod_nome
        sql = "SELECT preco from produtos where codprod= '" & cod_prod.Text & "'"
        preco = Add_Single_Value(sql, "preco")
        preco_to_mudar.Text = preco & " €"
        sql = "SELECT iva from produtos where codprod ='" & cod_prod.Text & "'"
        iva = Add_Single_Value(sql, "iva")
        iva_to_mudar.Text = iva & " %"


    End Sub

    Private Sub AddProduto_Click(sender As Object, e As EventArgs) Handles AddProduto.Click
        Dim adicionarProdutos As Boolean
        Dim sql, preco, iva As String
        Dim local_total As Double
        sql = "SELECT preco from produtos where codprod= '" & cod_prod.Text & "'"
        preco = Add_Single_Value(sql, "preco")
        sql = "SELECT iva from produtos where codprod ='" & cod_prod.Text & "'"
        iva = Add_Single_Value(sql, "iva")
        adicionarProdutos = Add_Vendas_Produtos(nvenda.Text, cod_prod.Text, quantidade.Text, preco)
        total += CDbl(quantidade.Text * CDbl(preco))
        'MessageBox.Show(total)
        local_total = quantidade.Text * CDbl(preco)
        DataProdutos.Rows.Add(codvendedor.Text, nvenda.Text, cod_prod.Text, nome_prod.Text, preco_to_mudar.Text, quantidade.Text, iva, local_total)
        PrecoTotal.Text = "Total: " & total & "€"
        cod_prod.Text = ""
        preco_to_mudar.Text = ""
        quantidade.Text = ""
        nome_prod.Text = ""
        iva_to_mudar.Text = ""
        

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        'cod_prod.Items.Clear()
        'Dim produtos As Boolean
        'Dim sql, codUser As String
        'produtos = Add_to_ComboBox("SELECT codprod from produtos", cod_prod, "codprod")
        'Sql = "SELECT coduser from utilizador where login ='" & Form1.EmbLogin1.LoginForm.Text & "' and senha = '" & Form1.EmbLogin1.PassForm.Text & "'"
        'codUser = Add_Single_Value(Sql, "coduser")
        'codvendedor.Text = codUser
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim venda_total As Boolean
        'PrecoTotal
        'MsgBox("o total e " & total)
        venda_total = Add_Process_Venda_Final(nvenda.Text, codvendedor.Text, nif.Text, pagamento.Text, total)
        DataProdutos.Rows.Clear()
        PrecoTotal.Text = "Total: "
        nvenda.Text = ""
        nif.Text = ""
        nome.Text = ""
        pagamento.Text = ""

    End Sub

    Private Sub nvenda_TextChanged(sender As Object, e As EventArgs) Handles nvenda.TextChanged

    End Sub
End Class
