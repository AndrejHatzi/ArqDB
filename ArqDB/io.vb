Imports System.IO
Module io
    Public Function CreateOptions(ByVal ParamArray args As String()) As Integer
        ''Dim file As System.IO.StreamWriter
        ' ''Dim path As String = Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "").Replace("\ArqDB-master\ArqDB", "")
        ''Dim path As String = Application.StartupPath.Replace("\ArqDB\bin\Debug", "")
        ''path = path.Replace("\ArqDB\bin\Debug", "")
        ''MessageBox.Show(path)
        ''file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        ''For Each i As String In args
        ''    file.WriteLine(i)
        ''Next
        ''file.Close()
        ''Return 1
        'Dim sTextFile As New System.Text.StringBuilder

        'sTextFile.AppendLine("The")
        'sTextFile.AppendLine("brown")
        'sTextFile.AppendLine("fox")
        'sTextFile.AppendLine("jumps")
        'Dim path As String = Application.StartupPath.Replace("\ArqDB\bin\Debug", "")
        'path = path.Replace("\ArqDB\bin\Debug", "")
        ''Dim sFileName As String = "C:\test.txt"

        'System.IO.File.AppendAllText(path, sTextFile.ToString)
        Return 1
    End Function
    Public Sub LacksText()

    End Sub
End Module
'Dim file As System.IO.StreamWriter
'file = My.Computer.FileSystem.OpenTextFileWriter("c:\test.txt", True)
'file.WriteLine("Here is the first string.")
'file.Close()
