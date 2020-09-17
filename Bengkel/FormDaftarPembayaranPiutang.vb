Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class FormDaftarPembayaranpiutang
    Public page As Integer = 1
    Public totalPage As Integer = 1
    Public offset As Integer = 50
    Public kodeTrx As String
    Public cryReport As New ReportDocument

    Private Sub FormDaftarPembayaranpiutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        isiGrid()
    End Sub

    Sub paging()
        Dim sqlCount As String = "SELECT COUNT(DISTINCT tbh.kd_pembayaran_piutang) FROM tb_pembayaran_piutang tbh
                                    JOIN tb_pembayaran_piutang_detail tbhd ON tbh.kd_pembayaran_piutang = tbhd.kd_pembayaran_piutang
                                    JOIN tb_penjualan tbe ON tbhd.kd_penjualan = tbe.kd_penjualan
                                    JOIN tb_pelanggan ts ON tbe.kd_pelanggan = ts.kd_pelanggan
                                    WHERE (tbh.kd_pembayaran_piutang LIKE @kd_pembayaran_piutang OR ts.nama LIKE @nama_pelanggan)"
        Using cmdCount As New MySqlCommand(sqlCount, conn)
            cmdCount.Parameters.AddWithValue("@kd_pembayaran_piutang", "%" & tbCari.Text & "%")
            cmdCount.Parameters.AddWithValue("@nama_pelanggan", "%" & tbCari.Text & "%")
            Using drCount = cmdCount.ExecuteReader
                While drCount.Read
                    lblTotal.Text = "Jumlah Transaksi : " & drCount.Item(0)
                    totalPage = Math.Ceiling(drCount.Item(0) / offset)
                    lblPage.Text = page & " / " & totalPage
                End While
            End Using
        End Using
        If page >= totalPage Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
        If page = 1 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If
    End Sub

    Sub isiGrid()
        Try
            Dim limit As Integer = offset * (page - 1)
            Dim sql As String = "SELECT tbh.kd_pembayaran_piutang, DATE(tbh.tanggal), GROUP_CONCAT(DISTINCT ts.nama), tbh.status FROM tb_pembayaran_piutang tbh
                                    JOIN tb_pembayaran_piutang_detail tbhd ON tbh.kd_pembayaran_piutang = tbhd.kd_pembayaran_piutang
                                    JOIN tb_penjualan tbe ON tbhd.kd_penjualan = tbe.kd_penjualan
                                    JOIN tb_pelanggan ts ON tbe.kd_pelanggan = ts.kd_pelanggan                                    
                                    GROUP BY tbh.kd_pembayaran_piutang
                                    HAVING (tbh.kd_pembayaran_piutang LIKE @kd_pembayaran_piutang OR GROUP_CONCAT(DISTINCT ts.nama) LIKE @nama_pelanggan)
                                    ORDER BY tbh.tanggal DESC
                                    LIMIT " & limit & ", " & offset
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kd_pembayaran_piutang", "%" & tbCari.Text & "%")
                cmd.Parameters.AddWithValue("@nama_pelanggan", "%" & tbCari.Text & "%")
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        Using dt As New DataTable
                            dt.Load(dr)
                            dgvTrx.DataSource = dt
                        End Using
                        judulGrid()
                    Else
                        dgvTrx.DataSource = Nothing
                    End If
                End Using
            End Using
            paging()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGrid()
        With dgvTrx
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            .AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Pembayaran"
            .Columns(1).HeaderText = "Tanggal"
            .Columns(2).HeaderText = "pelanggan"
            .Columns(3).Visible = False
            .Columns(0).Width = 150
            .Columns(1).Width = 100
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        page -= 1
        isiGrid()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        page += 1
        isiGrid()
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        page = 1
        isiGrid()
    End Sub

    Sub viewBuktiPembayaran(ByVal kd_pembayaran As String)
        Try
            kodeTrx = kd_pembayaran
            Dim RepLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\"))
            cryReport.Load(RepLocation & "CRBuktiPembayaranPiutang.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("kd_pembayaran", kd_pembayaran)
            CRVBuktiPembayaran.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub dgvTrx_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrx.CellClick
        If e.RowIndex > -1 Then
            viewBuktiPembayaran(dgvTrx.Item(0, e.RowIndex).Value)
            If dgvTrx.Item(3, e.RowIndex).Value = "0" Then
                btnVoid.Enabled = False
            ElseIf dgvTrx.Item(3, e.RowIndex).Value = "1" Then
                btnVoid.Enabled = True
            End If
        End If
    End Sub

    Private Sub dgvTrx_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTrx.CellFormatting
        If dgvTrx.Item(3, e.RowIndex).Value = "0" Then
            e.CellStyle.BackColor = Color.Salmon
            e.CellStyle.SelectionBackColor = Color.Red
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Try
            Dim pilih As Integer
            pilih = MsgBox("Yakin Batalkan Transaksi " & kodeTrx & " ?", 48 + 4 + 256, "Konfirmasi")
            If pilih = 6 Then
                query("UPDATE tb_pembayaran_piutang SET status = '0' WHERE kd_pembayaran_piutang = '" & kodeTrx & "'")
                MsgBox("Transaksi " & kodeTrx & " berhasil dibatalkan!", MsgBoxStyle.Information, "Informasi")
                btnVoid.Enabled = False
                isiGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub FormDaftarPembayaranpiutang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cryReport.Close()
    End Sub
End Class