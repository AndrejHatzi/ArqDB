Imports System.IO
Imports System
Public Class printform
    'Dim caminho As String = System.Reflection.Assembly.GetExecutingAssembly().Location
    'Private Sub PrintPreviewControl1_Click(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintPreviewControl1.Click
    '    Dim numerovenda As Integer = Form1.Reg_vendas1.nvenda.Text
    '    Dim nif As Integer = Form1.Reg_vendas1.nif.Text
    '    'Dim sql As String
    '    Dim d As DateTime = Now
    '    Dim reportFront As Font = New Drawing.Font("Times New Roman", 12)
    '    e.Graphics.DrawString("Loja ABC", reportFront, Brushes.Black, 100, 100)
    '    e.Graphics.DrawString("Consumidor Final", reportFront, Brushes.Black, 100, 120)
    '    e.Graphics.DrawString("NiF: " & nif, reportFront, Brushes.Black, 100, 140)
    '    e.Graphics.DrawString("Tipo documento Fatura Simplificada", reportFront, Brushes.Black, 100, 160)
    '    'd.ToString("yyyy-MM-dd")
    '    e.Graphics.DrawString("Data " & d.ToString("yyyy-MM-dd"), reportFront, Brushes.Black, 100, 180)
    '    e.Graphics.DrawString("Numero de Venda " & numerovenda, reportFront, Brushes.Black, 100, 140)



    'End Sub

    Private Sub zoom_plus_Click(sender As Object, e As EventArgs) Handles zoom_plus.Click
        Me.PrintPreviewControl1.Zoom = Me.PrintPreviewControl1.Zoom + 0.2
    End Sub

    Private Sub zoom_minus_Click(sender As Object, e As EventArgs) Handles zoom_minus.Click
        Me.PrintPreviewControl1.Zoom = Me.PrintPreviewControl1.Zoom - 0.2
    End Sub
End Class