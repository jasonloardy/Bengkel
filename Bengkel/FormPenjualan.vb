Imports MySql.Data.MySqlClient

Public Class FormPenjualan
    Public kodeBarang As String

    Function kode_penjualan()
        Try
            Dim kode As String = "000"
            Dim hitung As String = "1"
            Dim user As String = FormUtama.user
            Dim tanggal As String = Date.Now.ToString("MMyy")
            Dim sql As String = "SELECT kd_penjualan FROM tb_penjualan
                                 WHERE RIGHT(kd_penjualan, 4) = '" & tanggal & "'
                                 ORDER BY kd_penjualan DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Left(dr.Item("kd_penjualan").ToString, 4)) + 1
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
            Return kode & hitung & "/PJ/" & user & "/" & tanggal
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return ""
        End Try
    End Function

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        reset()
    End Sub

    Sub hitungTotal()
        Try
            Dim total As Integer
            Dim jumlahItem As Integer
            For i = 0 To dgvKeranjang.RowCount - 1
                total += dgvKeranjang.Rows(i).Cells(7).Value
                jumlahItem += dgvKeranjang.Rows(i).Cells(3).Value
            Next
            tbJumlahItem.Text = jumlahItem
            tbSubtotal.Text = FormatCurrency(total)
            tbPotongan.Text = FormatCurrency((Val(tbDiskonAll.Text) / 100) * total)
            lblTotal.Text = FormatCurrency(total - tbPotongan.Text)
            hitungKembalian()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub clearInput()
        hitungTotal()
        kodeBarang = ""
        tbKodeBarang.Clear()
        tbNamaBarang.Clear()
        tbSatuan.Clear()
        tbQty.Clear()
        tbHargaJual.Clear()
        tbDiskonBarang.Clear()
        tbTotal.Clear()
    End Sub
    Sub reset()
        dtpTanggal.Value = Date.Now
        tbKodePending.Clear()
        tbKodePembelian.Text = kode_penjualan()
        tbKodePlg.Clear()
        tbNamaPlg.Clear()
        tbAlamat.Clear()
        tbNoTelepon.Clear()
        tbKatPlg.Clear()
        lblTotal.Text = FormatCurrency(0)
        gbBarang.Enabled = False
        clearInput()
        'dgvKeranjang.Columns(6).Visible = False
        dgvKeranjang.Columns(4).DefaultCellStyle.Format = "c0"
        dgvKeranjang.Columns(5).DefaultCellStyle.Format = "n2"
        dgvKeranjang.Columns(7).DefaultCellStyle.Format = "c0"
        dgvKeranjang.Rows.Clear()
        tbJumlahItem.Text = 0
        tbSubtotal.Text = FormatCurrency(0)
        tbDiskonAll.Text = 0
        tbPotongan.Text = FormatCurrency(0)
        tbBayar.Text = 0
        hitungTotal()
        btnBatal.Enabled = False
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FormPelanggan.from = "penjualan"
        FormPelanggan.ShowDialog()
    End Sub

    Private Sub tbKodePlg_TextChanged(sender As Object, e As EventArgs) Handles tbKodePlg.TextChanged
        If tbKodePlg.Text <> "" Then
            gbBarang.Enabled = True
        Else
            gbBarang.Enabled = False
        End If
    End Sub

    Private Sub tbKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            If tbKatPlg.Text = "U" Then
                FormBarang.from = "penjualan-umum"
            ElseIf tbKatPlg.Text = "L" Then
                FormBarang.from = "penjualan-langganan"
            ElseIf tbKatPlg.Text = "P" Then
                FormBarang.from = "penjualan-partai"
            End If
            FormBarang.tbCari.Text = tbKodeBarang.Text
            FormBarang.ShowDialog()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Try
            Dim pilih As Integer
            pilih = MsgBox("Yakin Batalkan Transaksi?", 48 + 4 + 256, "Konfirmasi")
            If pilih = 6 Then
                trans = conn.BeginTransaction
                If query("DELETE FROM tb_pending_detail WHERE kd_pending = '" & tbKodePending.Text & "';
                       DELETE FROM tb_pending WHERE kd_pending = '" & tbKodePending.Text & "'") Then
                    trans.Commit()
                    reset()
                Else
                    trans.Rollback()
                End If
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub totalBarang()
        Try
            tbTotal.Text = FormatCurrency(tbQty.Text * tbHargaJual.Text * ((100 - Val(tbDiskonBarang.Text)) / 100))
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbQty_TextChanged(sender As Object, e As EventArgs) Handles tbQty.TextChanged
        formatRibuan(tbQty)
        totalBarang()
    End Sub

    Private Sub tbHargaJual_TextChanged(sender As Object, e As EventArgs) Handles tbHargaJual.TextChanged
        formatRibuan(tbHargaJual)
        totalBarang()
    End Sub

    Private Sub tbDiskonBarang_TextChanged(sender As Object, e As EventArgs) Handles tbDiskonBarang.TextChanged
        totalBarang()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Try
            If kodeBarang = "" Then
                MsgBox("Masukkan Barang Terlebih Dahulu!", 16, "Perhatian")
            Else
                If tbQty.Text = "" Then
                    MsgBox("Kolom Qty / Harga Beli Masih Kosong!", 16, "Perhatian")
                Else
                    With dgvKeranjang
                        Dim baris As Integer = .Rows.Add()
                        .Rows.Item(baris).Cells(0).Value = kodeBarang
                        .Rows.Item(baris).Cells(1).Value = tbNamaBarang.Text
                        .Rows.Item(baris).Cells(2).Value = tbSatuan.Text
                        .Rows.Item(baris).Cells(3).Value = tbQty.Text
                        .Rows.Item(baris).Cells(4).Value = FormatCurrency(tbHargaJual.Text)
                        .Rows.Item(baris).Cells(5).Value = Val(tbDiskonBarang.Text)
                        .Rows.Item(baris).Cells(6).Value = tbIsi.Text
                        .Rows.Item(baris).Cells(7).Value = tbQty.Text * tbHargaJual.Text * ((100 - Val(tbDiskonBarang.Text)) / 100)
                        .Rows.Item(baris).Cells(8).Value = FormatCurrency(tbHargaBeli.Text)
                    End With
                    clearInput()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbDiskonAll_TextChanged(sender As Object, e As EventArgs) Handles tbDiskonAll.TextChanged
        Try
            hitungTotal()
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub hitungKembalian()
        Try
            Dim total = CDec(lblTotal.Text)
            Dim bayar = Val(tbBayar.Text.Replace(".", ""))
            Dim kembalian = bayar - total
            tbKembalian.Text = FormatCurrency(kembalian)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbBayar_TextChanged(sender As Object, e As EventArgs) Handles tbBayar.TextChanged
        formatRibuan(tbBayar)
        hitungKembalian()
    End Sub

    Sub updateTotal(ByVal i As Integer)
        Try
            With dgvKeranjang
                Dim qty As Integer = .Rows(i).Cells(3).Value
                Dim hargaBeli As Integer = .Rows(i).Cells(4).Value
                Dim diskon As Decimal = Val(.Rows(i).Cells(5).Value)

                Dim total As Integer = qty * hargaBeli * (100 - diskon) / 100

                .Rows(i).Cells(7).Value = total
            End With
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub dgvKeranjang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKeranjang.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                If e.ColumnIndex = 3 Then
                    With FormInputBox
                        .dgv = dgvKeranjang
                        .from = "trx"
                        .columnValue = e.ColumnIndex
                        .row = e.RowIndex
                        .Text = "Qty Barang"
                        .lblMessage.Text = "Masukkan Qty Barang"
                        .tbValue.Mask = "0000"
                        .tbValue.Text = CDec(dgvKeranjang.Item(e.ColumnIndex, e.RowIndex).Value)
                        .ShowDialog()
                        updateTotal(e.RowIndex)
                        hitungTotal()
                    End With
                ElseIf e.ColumnIndex = 5 Then
                    With FormInputBox
                        .dgv = dgvKeranjang
                        .from = "trx"
                        .columnValue = e.ColumnIndex
                        .row = e.RowIndex
                        .Text = "Diskon Barang"
                        .lblMessage.Text = "Masukkan Diskon Barang"
                        .tbValue.Mask = "00,00"
                        .tbValue.Text = CDec(dgvKeranjang.Item(e.ColumnIndex, e.RowIndex).Value)
                        .ShowDialog()
                        updateTotal(e.RowIndex)
                        hitungTotal()
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            Dim pilih As Integer
            Dim namaBarang As String = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(1).Value
            pilih = MsgBox("Hapus Item " & namaBarang & " dari Keranjang?", 48 + 4 + 256, "Konfirmasi")
            If pilih = 6 Then
                dgvKeranjang.Rows.Remove(dgvKeranjang.CurrentRow)
                hitungTotal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub querySimpanPending()
        Try
            Dim kode As String = DateTime.Now.ToString("MMddHHmmss")
            trans = conn.BeginTransaction
            Dim sql As String = "INSERT INTO tb_pending VALUES (@kd_pending, NOW(), @kd_pelanggan, @diskon);"
            If queryPending(sql, kode, tbKodePlg.Text, Val(tbDiskonAll.Text)) Then
                Dim sqlDetail As String = "INSERT INTO tb_pending_detail VALUES (@kd_pending, @kd_barang, @kd_satuan, @qty, @harga_jual, @diskon, @unit, @harga_beli);"
                For i As Integer = 0 To dgvKeranjang.RowCount - 1
                    If queryPendingDetail(sqlDetail, kode, dgvKeranjang.Rows(i).Cells(0).Value, dgvKeranjang.Rows(i).Cells(2).Value, dgvKeranjang.Rows(i).Cells(3).Value,
                                            dgvKeranjang.Rows(i).Cells(4).Value, dgvKeranjang.Rows(i).Cells(5).Value, dgvKeranjang.Rows(i).Cells(6).Value, dgvKeranjang.Rows(i).Cells(8).Value) Then
                        'Update harga beli barang
                    Else
                        trans.Rollback()
                        Exit Sub
                    End If
                Next
                trans.Commit()
                MsgBox("Transaksi Berhasil di-Pending!", MsgBoxStyle.Information, "Informasi")
                dgvKeranjang.Rows.Clear()
                reset()
            Else
                trans.Rollback()
                Exit Sub
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub queryUpdatePending()
        Try
            trans = conn.BeginTransaction
            Dim sqlDelete As String = "DELETE FROM tb_pending_detail WHERE kd_pending = '" & tbKodePending.Text & "';
                                       DELETE FROM tb_pending WHERE kd_pending = '" & tbKodePending.Text & "';"
            If query(sqlDelete) Then
                Dim sql As String = "INSERT INTO tb_pending VALUES (@kd_pending, NOW(), @kd_pelanggan, @diskon);"
                If queryPending(sql, tbKodePending.Text, tbKodePlg.Text, Val(tbDiskonAll.Text)) Then
                    Dim sqlDetail As String = "INSERT INTO tb_pending_detail VALUES (@kd_pending, @kd_barang, @kd_satuan, @qty, @harga_jual, @diskon, @unit, @harga_beli);"
                    For i As Integer = 0 To dgvKeranjang.RowCount - 1
                        If queryPendingDetail(sqlDetail, tbKodePending.Text, dgvKeranjang.Rows(i).Cells(0).Value, dgvKeranjang.Rows(i).Cells(2).Value, dgvKeranjang.Rows(i).Cells(3).Value,
                                                dgvKeranjang.Rows(i).Cells(4).Value, dgvKeranjang.Rows(i).Cells(5).Value, dgvKeranjang.Rows(i).Cells(6).Value, dgvKeranjang.Rows(i).Cells(8).Value) Then
                            'Update harga beli barang
                        Else
                            trans.Rollback()
                            Exit Sub
                        End If
                    Next
                    trans.Commit()
                    MsgBox("Transaksi Berhasil di-Pending!", MsgBoxStyle.Information, "Informasi")
                    dgvKeranjang.Rows.Clear()
                    reset()
                Else
                    trans.Rollback()
                    Exit Sub
                End If
            Else
                trans.Rollback()
                Exit Sub
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        Dim pilih As Integer
        pilih = MsgBox("Pending Transaksi Penjualan ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            If dgvKeranjang.RowCount > 0 Then
                If tbKodePending.Text <> "" Then
                    queryUpdatePending()
                Else
                    querySimpanPending()
                End If
            Else
                MsgBox("Barang yang dimasukkan belum ada!", 16, "Error")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormListPending.ShowDialog()
    End Sub

    Private Sub tbKodePending_TextChanged(sender As Object, e As EventArgs) Handles tbKodePending.TextChanged
        If tbKodePending.Text = "" Then
            btnBatal.Enabled = False
        Else
            isiGridPending()
            btnBatal.Enabled = True
        End If
    End Sub

    Sub isiGridPending()
        Try
            Dim sql As String = "SELECT tpd.kd_barang kd_barang, tb.nama_barang nama_barang, tpd.kd_satuan kd_satuan,
                                    tpd.qty qty, tpd.harga_jual harga_jual, tpd.diskon diskon, tpd.unit unit,
                                    tpd.qty*tpd.harga_jual*(100-tpd.diskon)/100 total, tpd.harga_beli harga_beli
                                 FROM tb_pending_detail tpd
                                 JOIN tb_barang tb ON tpd.kd_barang = tb.kd_barang
                                 WHERE tpd.kd_pending = '" & tbKodePending.Text & "'"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            With dgvKeranjang
                                Dim baris As Integer = .Rows.Add()
                                .Rows.Item(baris).Cells(0).Value = dr.Item("kd_barang").ToString
                                .Rows.Item(baris).Cells(1).Value = dr.Item("nama_barang").ToString
                                .Rows.Item(baris).Cells(2).Value = dr.Item("kd_satuan").ToString
                                .Rows.Item(baris).Cells(3).Value = dr.Item("qty").ToString
                                .Rows.Item(baris).Cells(4).Value = FormatCurrency(dr.Item("harga_jual").ToString)
                                .Rows.Item(baris).Cells(5).Value = Val(dr.Item("diskon").ToString)
                                .Rows.Item(baris).Cells(6).Value = dr.Item("unit").ToString
                                .Rows.Item(baris).Cells(7).Value = FormatCurrency(dr.Item("total").ToString)
                                .Rows.Item(baris).Cells(8).Value = FormatCurrency(dr.Item("harga_beli").ToString)
                            End With
                        End While
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Try
            Dim pilih As Integer
            pilih = MsgBox("Buat Transaksi Baru?", 48 + 4 + 256, "Konfirmasi")
            If pilih = 6 Then
                reset()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub querySimpan()
        Try
            Dim sisa As Integer = 0
            If tbKembalian.Text < 0 Then
                sisa = Math.Abs(CInt(tbKembalian.Text))
            End If
            Dim kode As String = kode_penjualan()
            trans = conn.BeginTransaction
            Dim sql As String = "INSERT INTO tb_penjualan VALUES (@kd_penjualan, NOW(), @kd_pelanggan, @diskon, @bayar, @sisa, '1');"
            If queryPenjualan(sql, kode, tbKodePlg.Text, Val(tbDiskonAll.Text), tbBayar.Text, sisa) Then
                Dim sqlDetail As String = "INSERT INTO tb_penjualan_detail VALUES (@kd_penjualan, @kd_barang, @kd_satuan, @qty, @harga_jual, @diskon, @unit, @harga_beli);"
                For i As Integer = 0 To dgvKeranjang.RowCount - 1
                    If queryPenjualanDetail(sqlDetail, kode, dgvKeranjang.Rows(i).Cells(0).Value, dgvKeranjang.Rows(i).Cells(2).Value, dgvKeranjang.Rows(i).Cells(3).Value,
                                            dgvKeranjang.Rows(i).Cells(4).Value, dgvKeranjang.Rows(i).Cells(5).Value, dgvKeranjang.Rows(i).Cells(6).Value * dgvKeranjang.Rows(i).Cells(3).Value, dgvKeranjang.Rows(i).Cells(8).Value) Then
                        'Update harga beli barang
                    Else
                        trans.Rollback()
                        Exit Sub
                    End If
                Next
                trans.Commit()
                Dim pilih As Integer
                pilih = MsgBox("Transaksi Berhasil di-Simpan! Cetak Nota?", 48 + 4 + 256, "Konfirmasi")
                If pilih = 6 Then
                    FormViewCR.printNotaPenjualan(kode)
                    FormViewCR.cryReport.Close()
                End If
                dgvKeranjang.Rows.Clear()
                reset()
            Else
                trans.Rollback()
                Exit Sub
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim pilih As Integer

        If tbKembalian.Text < 0 Then
            pilih = MsgBox("Nominal bayar kurang, transaksi akan terhitung Kredit. Lanjutkan ?", 48 + 4 + 256, "Konfirmasi")
        Else
            pilih = MsgBox("Simpan Transaksi Penjualan ?", 48 + 4 + 256, "Konfirmasi")
        End If
        'pilih = MsgBox("Simpan Transaksi Penjualan ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            If dgvKeranjang.RowCount > 0 Then
                If tbKodePending.Text <> "" Then
                    'delete dlu baru simpan
                    trans = conn.BeginTransaction
                    If query("DELETE FROM tb_pending_detail WHERE kd_pending = '" & tbKodePending.Text & "';
                       DELETE FROM tb_pending WHERE kd_pending = '" & tbKodePending.Text & "'") Then
                        trans.Commit()
                        querySimpan()
                        reset()
                    Else
                        trans.Rollback()
                    End If
                Else
                    'langsung simpan
                    querySimpan()
                End If
            Else
                MsgBox("Barang yang dimasukkan belum ada!", 16, "Error")
            End If
        End If
    End Sub
End Class