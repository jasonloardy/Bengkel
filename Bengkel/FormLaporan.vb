Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormLaporan
    Public cryReport As New ReportDocument
    Public RepLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\"))

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_tahun()
    End Sub

    Sub cb_tahun()
        Try
            Dim q As String = "(SELECT YEAR(tanggal) tahun FROM tb_pembelian) " _
                        & "UNION " _
                        & "(SELECT YEAR(tanggal) tahun FROM tb_penjualan) " _
                        & "ORDER BY tahun DESC"
            cbTahunan.DataSource = queryCb(q)
            cbTahunan.ValueMember = "tahun"
            cbTahunan.DisplayMember = "tahun"
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Try
            cryReport.Close()
            If rbHarian.Checked And rbPembelian.Checked Then
                pembelianHarian(dtpHarian1.Value.ToString("yyyy-MM-dd"), dtpHarian2.Value.ToString("yyyy-MM-dd"))
            ElseIf rbBulanan.Checked And rbPembelian.Checked Then
                pembelianBulanan(dtpBulanan.Value.ToString("MM"), dtpBulanan.Value.ToString("yyyy"))
            ElseIf rbtahunan.Checked And rbPembelian.Checked Then
                pembelianTahunan(cbTahunan.Text)
            ElseIf rbHarian.Checked And rbpenjualan.Checked Then
                penjualanHarian(dtpHarian1.Value.ToString("yyyy-MM-dd"), dtpHarian2.Value.ToString("yyyy-MM-dd"))
            ElseIf rbBulanan.Checked And rbpenjualan.Checked Then
                penjualanBulanan(dtpBulanan.Value.ToString("MM"), dtpBulanan.Value.ToString("yyyy"))
            ElseIf rbtahunan.Checked And rbpenjualan.Checked Then
                penjualanTahunan(cbTahunan.Text)
            ElseIf rbHarian.Checked And rbBarangBeli.Checked Then
                barangPembelianHarian(dtpHarian1.Value.ToString("yyyy-MM-dd"), dtpHarian2.Value.ToString("yyyy-MM-dd"))
            ElseIf rbBulanan.Checked And rbBarangBeli.Checked Then
                barangPembelianBulanan(dtpBulanan.Value.ToString("MM"), dtpBulanan.Value.ToString("yyyy"))
            ElseIf rbTahunan.Checked And rbBarangBeli.Checked Then
                barangPembelianTahunan(cbTahunan.Text)
            ElseIf rbHarian.Checked And rbBarangJual.Checked Then
                barangPenjualanHarian(dtpHarian1.Value.ToString("yyyy-MM-dd"), dtpHarian2.Value.ToString("yyyy-MM-dd"))
            ElseIf rbBulanan.Checked And rbBarangJual.Checked Then
                barangPenjualanBulanan(dtpBulanan.Value.ToString("MM"), dtpBulanan.Value.ToString("yyyy"))
            ElseIf rbTahunan.Checked And rbBarangJual.Checked Then
                barangPenjualanTahunan(cbTahunan.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub barangPembelianHarian(ByVal tgl1 As String, ByVal tgl2 As String)
        Try
            cryReport.Load(RepLocation & "CRLapBarangHarian.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("trx", "pembelian")
            cryReport.SetParameterValue("tgl1", tgl1)
            cryReport.SetParameterValue("tgl2", tgl2)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub barangPembelianBulanan(ByVal bulan As String, ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapBarangBulanan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("trx", "pembelian")
            cryReport.SetParameterValue("bulan", bulan)
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub barangPembelianTahunan(ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapBarangTahunan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("trx", "pembelian")
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub barangPenjualanHarian(ByVal tgl1 As String, ByVal tgl2 As String)
        Try
            cryReport.Load(RepLocation & "CRLapBarangHarian.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("trx", "penjualan")
            cryReport.SetParameterValue("tgl1", tgl1)
            cryReport.SetParameterValue("tgl2", tgl2)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub barangPenjualanBulanan(ByVal bulan As String, ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapBarangBulanan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("trx", "penjualan")
            cryReport.SetParameterValue("bulan", bulan)
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub barangPenjualanTahunan(ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapBarangTahunan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("trx", "penjualan")
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub pembelianHarian(ByVal tgl1 As String, ByVal tgl2 As String)
        Try
            cryReport.Load(RepLocation & "CRLapPembelianHarian.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("tanggal1", tgl1)
            cryReport.SetParameterValue("tanggal2", tgl2)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub pembelianBulanan(ByVal bulan As String, ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapPembelianBulanan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("bulan", bulan)
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub pembelianTahunan(ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapPembelianTahunan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub penjualanHarian(ByVal tgl1 As String, ByVal tgl2 As String)
        Try
            cryReport.Load(RepLocation & "CRLapPenjualanHarian.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("tanggal1", tgl1)
            cryReport.SetParameterValue("tanggal2", tgl2)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub penjualanBulanan(ByVal bulan As String, ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapPenjualanBulanan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("bulan", bulan)
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub penjualanTahunan(ByVal tahun As String)
        Try
            cryReport.Load(RepLocation & "CRLapPenjualanTahunan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("tahun", tahun)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub FormLaporan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cryReport.Close()
    End Sub
End Class