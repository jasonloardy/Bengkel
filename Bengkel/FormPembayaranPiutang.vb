Imports MySql.Data.MySqlClient

Public Class FormPembayaranpiutang
    Private Sub FormPembayaranpiutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        reset()
    End Sub

    Function kode_piutang()
        Try
            Dim kode As String = "000"
            Dim hitung As String = "1"
            Dim user As String = FormUtama.user
            Dim tanggal As String = Date.Now.ToString("MMyy")
            Dim sql As String = "SELECT kd_pembayaran_piutang FROM tb_pembayaran_piutang
                                 WHERE RIGHT(kd_pembayaran_piutang, 4) = '" & tanggal & "'
                                 ORDER BY kd_pembayaran_piutang DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Left(dr.Item("kd_pembayaran_piutang").ToString, 4)) + 1
                        End While
                        If Len(hitung) = 1 Then
                            kode = "000"
                        ElseIf Len(hitung) = 2 Then
                            kode = "00"
                        ElseIf Len(hitung) = 3 Then
                            kode = "0"
                        ElseIf Len(hitung) = 4 Then
                            kode = ""
                        End If
                    End If
                End Using
            End Using
            Return kode & hitung & "/PP/" & user & "/" & tanggal
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return ""
        End Try
    End Function

    Sub hitungTotal()
        Try
            Dim totalBayar As Integer
            Dim totalKredit As Integer
            For i = 0 To dgvTrx.RowCount - 1
                totalBayar += dgvTrx.Rows(i).Cells(4).Value
                totalKredit += dgvTrx.Rows(i).Cells(5).Value
            Next
            lblTotal.Text = FormatCurrency(totalBayar)
            tbTotalKredit.Text = FormatCurrency(totalKredit)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub reset()
        dtpTanggal.Value = Date.Now
        tbKodepiutang.Text = kode_piutang()
        tbKodePlg.Clear()
        tbNamaPlg.Clear()
        tbAlamat.Clear()
        tbNoTelepon.Clear()
        lblTotal.Text = FormatCurrency(0)
        dgvTrx.Rows.Clear()
        tbTotalKredit.Text = FormatCurrency(0)
    End Sub

    Private Sub btnpelanggan_Click(sender As Object, e As EventArgs) Handles btnPlg.Click
        FormDaftarpiutang.from = "piutang-pelanggan"
        FormDaftarpiutang.ShowDialog()
    End Sub

    Sub isiGridTrx(ByVal kd_pelanggan As String)
        Try
            Dim sql As String = "SELECT tb.kd_penjualan, tanggal,
                                    FLOOR(SUM(tbd.qty*tbd.harga_jual*(100-tbd.diskon)/100)*(100-tb.diskon)/100) nominal,
                                    sisa, '0', sisa
                                    FROM tb_penjualan tb
                                    JOIN tb_penjualan_detail tbd ON tb.kd_penjualan = tbd.kd_penjualan
                                    WHERE kd_pelanggan = '" & kd_pelanggan & "' AND sisa > 0 AND status = '1'
                                    GROUP BY tb.kd_penjualan"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvTrx.DataSource = ds.Tables(0)
                judulGridTrx()
            Else
                dgvTrx.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGridTrx()
        With dgvTrx
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            .AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Penjualan"
            .Columns(1).HeaderText = "Tgl. Transaksi"
            .Columns(2).HeaderText = "Nominal"
            .Columns(3).HeaderText = "Sisa"
            .Columns(4).HeaderText = "Bayar"
            .Columns(5).HeaderText = "Kredit"
            .Columns(0).Width = 150
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 100
            .Columns(2).DefaultCellStyle.Format = "c0"
            .Columns(3).DefaultCellStyle.Format = "c0"
            .Columns(5).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Private Sub tbKodepelanggan_TextChanged(sender As Object, e As EventArgs) Handles tbKodePlg.TextChanged
        isiGridTrx(tbKodePlg.Text)
        hitungTotal()
    End Sub

    Private Sub dgvTrx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrx.CellDoubleClick
        Try
            If e.ColumnIndex = 4 And e.RowIndex > -1 Then
                With FormInputBox
                    .dgv = dgvTrx
                    .from = "hutang"
                    .columnSisa = 3
                    .columnKredit = 5
                    .columnValue = e.ColumnIndex
                    .row = e.RowIndex
                    .Text = "Nominal Bayar"
                    .lblMessage.Text = "Masukkan Nominal Bayar"
                    .tbValue.Mask = ""
                    .tbValue.Text = CDec(dgvTrx.Item(e.ColumnIndex, e.RowIndex).Value)
                    .ShowDialog()
                    hitungTotal()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub querySimpan()
        Try
            Dim kode As String = kode_piutang()
            trans = conn.BeginTransaction
            Dim sql As String = "INSERT INTO tb_pembayaran_piutang VALUES (@kd_pembayaran_piutang, NOW(), '1');"
            If queryPembayaranpiutang(sql, kode) Then
                For i As Integer = 0 To dgvTrx.RowCount - 1
                    Dim sqlDetail As String = "INSERT INTO tb_pembayaran_piutang_detail VALUES (@kd_pembayaran_piutang, @kd_penjualan, @bayar);"
                    If CDec(dgvTrx.Rows(i).Cells(4).Value) > 0 Then
                        If Not queryPembayaranPiutangDetail(sqlDetail, kode, dgvTrx.Rows(i).Cells(0).Value, CDec(dgvTrx.Rows(i).Cells(4).Value)) Then
                            trans.Rollback()
                            Exit Sub
                        End If
                    End If
                Next
                trans.Commit()
                MsgBox("Transaksi berhasil di-simpan!", MsgBoxStyle.Information, "Informasi")
                reset()
            Else
                trans.Rollback()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim pilih As Integer
        pilih = MsgBox("Simpan Transaksi Pembayaran ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            If CDec(lblTotal.Text) > 0 Then
                querySimpan()
            Else
                MsgBox("Belum Ada Transaksi Yang Dibayar!", 16, "Error")
            End If
        End If
    End Sub
End Class