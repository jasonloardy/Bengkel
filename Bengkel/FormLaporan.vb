Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_tahun()
    End Sub

    Sub cb_tahun()
        Dim q As String = "(SELECT YEAR(tanggal) tahun FROM tb_pembelian) " _
                        & "UNION " _
                        & "(SELECT YEAR(tanggal) tahun FROM tb_penjualan) " _
                        & "ORDER BY tahun DESC"
        cbTahunan.DataSource = queryCb(q)
        cbTahunan.ValueMember = "tahun"
        cbTahunan.DisplayMember = "tahun"
    End Sub
End Class