Public Class homepage

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles WelcomeSentence.Click

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        Dim webAddress As String = "https://github.com/AndrejHatzi/ArqDB"
        Process.Start(webAddress)
    End Sub
End Class
