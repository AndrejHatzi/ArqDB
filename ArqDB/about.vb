Public Class about

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim webAddress As String = "https://github.com/AndrejHatzi/ArqDB"
        Process.Start(webAddress)
    End Sub
End Class
