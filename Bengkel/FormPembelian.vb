Imports MySql.Data.MySqlClient

Public Class FormPembelian
    Public kodeBarang As String
    Function kode_pembelian()
        Try
            Dim kode As String = "000"
            Dim hitung As String = "1"
            Dim user As String = FormUtama.user
            Dim tanggal As String = Date.Now.ToString("MMyy")
            Dim sql As String = "SELECT kd_pembelian FROM tb_pembelian
                                 WHERE RIGHT(kd_pembelian, 4) = '" & tanggal & "'
                                 ORDER BY kd_pembelian DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Left(dr.Item("kd_pembelian").ToString, 4)) + 1
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
            Return kode & hitung & "/PB/" & user & "/" & tanggal
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return ""
        End Try
    End Function

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        tbHargaBeli.Clear()
        tbDiskonBarang.Clear()
        tbTotal.Clear()
    End Sub
    Sub reset()
        dtpTanggal.Value = Date.Now
        tbKodePembelian.Text = kode_pembelian()
        tbKodeBukti.Clear()
        tbKodeSupplier.Clear()
        tbNamaSupplier.Clear()
        tbAlamat.Clear()
        tbNoTelepon.Clear()
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
        tbTunai.Text = FormatCurrency(0)
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FormSupplier.from = "pembelian"
        FormSupplier.ShowDialog()
    End Sub

    Private Sub tbKodeSupplier_TextChanged(sender As Object, e As EventArgs) Handles tbKodeSupplier.TextChanged
        If tbKodeSupplier.Text <> "" Then
            gbBarang.Enabled = True
        End If
    End Sub

    Private Sub tbKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            FormBarang.from = "pembelian"
            FormBarang.tbCari.Text = tbKodeBarang.Text
            FormBarang.ShowDialog()
        End If
    End Sub

    Sub totalBarang()
        Try
            tbTotal.Text = FormatCurrency(tbQty.Text * tbHargaBeli.Text * ((100 - Val(tbDiskonBarang.Text)) / 100))
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbQty_TextChanged(sender As Object, e As EventArgs) Handles tbQty.TextChanged
        formatRibuan(tbQty)
        totalBarang()
    End Sub

    Private Sub tbHargaBeli_TextChanged(sender As Object, e As EventArgs) Handles tbHargaBeli.TextChanged
        formatRibuan(tbHargaBeli)
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
                If tbQty.Text = "" Or tbHargaBeli.Text = "" Then
                    MsgBox("Kolom Qty / Harga Beli Masih Kosong!", 16, "Perhatian")
                Else
                    With dgvKeranjang
                        Dim baris As Integer = .Rows.Add()
                        .Rows.Item(baris).Cells(0).Value = kodeBarang
                        .Rows.Item(baris).Cells(1).Value = tbNamaBarang.Text
                        .Rows.Item(baris).Cells(2).Value = tbSatuan.Text
                        .Rows.Item(baris).Cells(3).Value = tbQty.Text
                        .Rows.Item(baris).Cells(4).Value = FormatCurrency(tbHargaBeli.Text)
                        .Rows.Item(baris).Cells(5).Value = Val(tbDiskonBarang.Text)
                        .Rows.Item(baris).Cells(6).Value = tbIsi.Text
                        .Rows.Item(baris).Cells(7).Value = tbQty.Text * tbHargaBeli.Text * ((100 - Val(tbDiskonBarang.Text)) / 100)
                    End With
                    clearInput()
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

    Private Sub tbDiskonAll_TextChanged(sender As Object, e As EventArgs) Handles tbDiskonAll.TextChanged
        Try
            hitungTotal()
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub querySimpan()
        Try
            Dim kode As String = kode_pembelian()
            Dim tanggalJT As String
            Dim tunai As Integer
            If dtpJatuhTempo.Visible = True Then
                tanggalJT = dtpJatuhTempo.Value.ToString("yyyy-MM-dd")
                tunai = Val(tbTunai.Text)
            Else
                tanggalJT = Nothing
                tunai = lblTotal.Text
            End If
            trans = conn.BeginTransaction
            Dim sql As String = "INSERT INTO tb_pembelian VALUES (@kd_pembelian, NOW(), @kd_supplier, @kd_bukti, @sales, @diskon, @tanggal_jt, @tunai, @sisa, '1');"
            If queryPembelian(sql, kode, tbKodeSupplier.Text, tbKodeBukti.Text, tbSales.Text, Val(tbDiskonAll.Text), tanggalJT, tunai, tbKredit.Text) Then
                Dim sqlDetail As String = "INSERT INTO tb_pembelian_detail VALUES (@kd_pembelian, @kd_barang, @kd_satuan, @qty, @harga_beli, @diskon, @unit);"
                For i As Integer = 0 To dgvKeranjang.RowCount - 1
                    If queryPembelianDetail(sqlDetail, kode, dgvKeranjang.Rows(i).Cells(0).Value, dgvKeranjang.Rows(i).Cells(2).Value, dgvKeranjang.Rows(i).Cells(3).Value,
                                            dgvKeranjang.Rows(i).Cells(4).Value, dgvKeranjang.Rows(i).Cells(5).Value, dgvKeranjang.Rows(i).Cells(6).Value * dgvKeranjang.Rows(i).Cells(3).Value) Then
                        'update harga beli barang
                        query("UPDATE tb_barang SET harga_beli = harga_beli * (100 - " & Val(tbDiskonAll.Text) & ") / 100 WHERE kd_barang = '" & dgvKeranjang.Rows(i).Cells(0).Value & "'")
                    Else
                        trans.Rollback()
                        Exit Sub
                    End If
                Next
                trans.Commit()
                MsgBox("Transaksi berhasil di-simpan!", MsgBoxStyle.Information, "Informasi")
                FormViewCR.viewBuktiPembelian(kode)
                FormViewCR.ShowDialog()
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
        pilih = MsgBox("Simpan Transaksi Pembelian ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            If dgvKeranjang.RowCount > 0 Then
                querySimpan()
            Else
                MsgBox("Barang yang dimasukkan belum ada!", 16, "Error")
            End If
        End If
    End Sub
    Sub cekJatuhTempo()
        Try
            Dim total = CDec(lblTotal.Text)
            Dim bayar = Val(tbTunai.Text.Replace(".", ""))
            If total <= bayar Then
                lblJatuhTempo.Visible = False
                dtpJatuhTempo.Visible = False
            Else
                lblJatuhTempo.Visible = True
                dtpJatuhTempo.Visible = True
            End If
            Dim kredit = total - bayar
            If kredit >= 0 Then
                tbKredit.Text = FormatCurrency(kredit)
            Else
                tbKredit.Text = FormatCurrency(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub


    Private Sub tbTunai_TextChanged(sender As Object, e As EventArgs) Handles tbTunai.TextChanged
        formatRibuan(tbTunai)
        cekJatuhTempo()
    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        cekJatuhTempo()
    End Sub

    Sub updateTotal(ByVal i As Integer)
        Try
            With dgvKeranjang
                Dim qty As Integer = .Rows(i).Cells(3).Value
                Dim hargaBeli As Integer = .Rows(i).Cells(4).Value
                Dim diskon As Decimal = Val(.Rows(i).Cells(5).Value)

                Dim total As Integer = qty * hargaBeli * (100 - diskon) / 100

                .Rows(i).Cells(7).Value = total
                'MsgBox(total)
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

    Private Sub tbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbHargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHargaBeli.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbDiskonBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDiskonBarang.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbDiskonAll_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDiskonAll.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbTunai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTunai.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class