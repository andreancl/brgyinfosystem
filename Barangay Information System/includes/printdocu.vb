Imports System.Drawing.Printing
Module printdocu
    Public Sub printset(ByVal obj As Object)
        Resident.PrintDialog1.PrinterSettings = Resident.PrintDocument1.PrinterSettings
        If Resident.PrintDialog1.ShowDialog() = DialogResult.OK Then
            Resident.PrintDocument1.PrinterSettings = Resident.PrintDialog1.PrinterSettings
            Dim xCustomSize As New PaperSize("Letter", 850, 1100)
            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Right = 50
                .Margins.Left = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
            End With
            Resident.PrintDocument1.DefaultPageSettings = pagesetup
            Resident.PrintDocument1.DefaultPageSettings.PaperSize = xCustomSize
        End If
        Resident.PrintPreviewDialog1.Document = Resident.PrintDocument1
        Resident.PrintPreviewDialog1.ShowDialog()
    End Sub
    Public Sub printset2(ByVal obj As Object)
        Resident.PrintDialog1.PrinterSettings = Resident.PrintDocument2.PrinterSettings
        If Resident.PrintDialog1.ShowDialog() = DialogResult.OK Then
            Resident.PrintDocument2.PrinterSettings = Resident.PrintDialog1.PrinterSettings
            Dim xCustomSize As New PaperSize("Letter", 850, 1100)
            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Right = 50
                .Margins.Left = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
            End With
            Resident.PrintDocument2.DefaultPageSettings = pagesetup
            Resident.PrintDocument2.DefaultPageSettings.PaperSize = xCustomSize
        End If
        Resident.PrintPreviewDialog1.Document = Resident.PrintDocument2
        Resident.PrintPreviewDialog1.ShowDialog()
    End Sub
    Public Sub printset3(ByVal obj As Object)
        Resident.PrintDialog1.PrinterSettings = Resident.PrintDocument3.PrinterSettings
        If Resident.PrintDialog1.ShowDialog() = DialogResult.OK Then
            Resident.PrintDocument3.PrinterSettings = Resident.PrintDialog1.PrinterSettings
            Dim xCustomSize As New PaperSize("Letter", 850, 1100)
            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Right = 50
                .Margins.Left = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
            End With
            Resident.PrintDocument3.DefaultPageSettings = pagesetup
            Resident.PrintDocument3.DefaultPageSettings.PaperSize = xCustomSize
        End If
        Resident.PrintPreviewDialog1.Document = Resident.PrintDocument3
        Resident.PrintPreviewDialog1.ShowDialog()
    End Sub
End Module
