Public Class rascunho
    'mudar t
    'nao esta a renderizar mudar resolucao
    'mudar res com side panel para encolher
    'wikipedia
    'criar metodo simples de storage de local que apresente tudo e as foto com html
    'https://www.youtube.com/watch?v=1NiJcZrPHvA php retieve image

    Private Sub rascunho_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        'WebBrowser1.Navigate("")
        Dim webAddress As String = "file:///F:/UI_ARQDB/maps/index.html"
        Process.Start(webAddress)
    End Sub
End Class