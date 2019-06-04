Public Class mapstudio
    Dim photopath As String
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
            photopath = opf.FileName
            My.Computer.FileSystem.WriteAllText(relpath, opf.FileName, True)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath, colorMapPath, ImagePath As String
        'F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\image.nm")

        Try
            My.Computer.FileSystem.DeleteFile(relpath)
        Catch ex As Exception
        End Try


        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(relpath, True)
        file.WriteLine(tBoxNome.Text)
        file.WriteLine(photopath)
        file.Close()

        colorMapPath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\color_maps.exe")
        ImagePath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\config\" & tBoxNome.Text & ".png")
        'Dim proc As New System.Diagnostics.Process()
        'proc = Process.Start(colorMapPath, "")
        'wait(10000)
        Process.Start("cmd", "/k cd F:\UI_ARQDB\config\ && color_maps.exe && exit()")
        wait(2000)
        pBox.Image = Image.FromFile(ImagePath)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'System.Diagnostics.Process.Start("F:\UI_ARQDB\config\color_maps.exe")
        'Threading.Thread.Sleep(6000)


    End Sub

    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click

    End Sub
End Class
