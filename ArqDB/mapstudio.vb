Public Class mapstudio

    Private Sub pBox_Click(sender As Object, e As EventArgs) Handles pBox.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath As String
        'F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\gem.cfg")
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pBox.Image = Image.FromFile(opf.FileName)
            MessageBox.Show(opf.FileName)
            My.Computer.FileSystem.WriteAllText(relpath, opf.FileName, True)
        End If
    End Sub
End Class
