Imports MySql.Data.MySqlClient

Public Class FormBarang
    Public mode, id_data, temp_kode, from As String
    Public page As Integer = 1
    Public totalPage As Integer = 1
    Public offset As Integer = 50
    Public sortBy As String = "kd_barang ASC"

    Private Sub Formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        reset()
        isiGrid()
        If FormUtama.level = "A" Then
            gbBarang.Visible = True
            btnBarcode.Visible = True
            btnTambah.Visible = True
            btnEdit.Visible = True
            btnHapus.Visible = True
            btnBatal.Visible = True
        ElseIf FormUtama.level = "K" Then
            gbBarang.Visible = False
            btnBarcode.Visible = False
            btnTambah.Visible = False
            btnEdit.Visible = False
            btnHapus.Visible = False
            btnBatal.Visible = False
            GroupBox1.Width = 1160
        End If
    End Sub

    Sub isiCb()
        Try
            Dim sqlStn As String = "SELECT * FROM tb_satuan"
            cbStnDasar.DataSource = queryCb(sqlStn)
            cbStnDasar.DisplayMember = "kd_satuan"
            cbStnDasar.SelectedIndex = -1

            FormMultiSatuan.cbStnMulti.DataSource = queryCb(sqlStn)
            FormMultiSatuan.cbStnMulti.DisplayMember = "kd_satuan"
            FormMultiSatuan.cbStnMulti.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub isiDetailBarang(ByVal kd_barang As String)
        Try
            Dim sql As String = "SELECT tb.kd_barang, tb.nama_barang, tbs.kd_satuan,
                                tb.harga_beli*tbs.isi harga_beli, tbs.harga_jual_u*tbs.isi harga_jual_u,
                                tbs.harga_jual_l*tbs.isi harga_jual_l, tbs.harga_jual_p*tbs.isi harga_jual_p, tb.stok,
                                CASE
                                WHEN tb.status = 'A' THEN 'Aktif'
                                WHEN tb.status = 'N' THEN 'Non Aktif'
                                END status FROM tb_barang tb
                                JOIN tb_barang_satuan tbs ON tb.kd_barang = tbs.kd_barang
                                WHERE tb.kd_barang = '" & kd_barang & "' AND tbs.jenis_satuan = 'D'"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            tbKode.Text = dr.Item("kd_barang")
                            tbNama.Text = dr.Item("nama_barang")
                            cbStnDasar.Text = dr.Item("kd_satuan")
                            tbHrgBeli.Text = dr.Item("harga_beli")
                            tbHrgJualU.Text = dr.Item("harga_jual_u")
                            tbHrgJualL.Text = dr.Item("harga_jual_l")
                            tbHrgJualP.Text = dr.Item("harga_jual_p")
                            tbStok.Text = dr.Item("stok")
                            tbStokFisik.Text = dr.Item("stok")
                            cbStatus.Text = dr.Item("status")
                        End While
                    End If
                End Using
            End Using
            isiGridStn(kd_barang)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub isiGridSatuan(ByVal kd_barang As String)
        Try
            Dim sql As String = "SELECT kd_satuan, isi FROM tb_barang_satuan
                                WHERE kd_barang = '" & kd_barang & "' AND jenis_satuan = 'M'"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvSatuan.DataSource = ds.Tables(0)
                judulGridSatuan()
            Else
                dgvSatuan.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub
    Sub isiColStn()
        dgvSatuan.Columns.Clear()
        Dim colKdSatuan As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        colKdSatuan.HeaderText = "Satuan"
        dgvSatuan.Columns.Add(colKdSatuan)
        Dim colIsi As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        colIsi.HeaderText = "Isi"
        dgvSatuan.Columns.Add(colIsi)
        Dim colHargaU As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        colHargaU.HeaderText = "Umum"
        dgvSatuan.Columns.Add(colHargaU)
        Dim colHargaL As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        colHargaL.HeaderText = "Langganan"
        dgvSatuan.Columns.Add(colHargaL)
        Dim colHargaP As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        colHargaP.HeaderText = "Partai"
        dgvSatuan.Columns.Add(colHargaP)
    End Sub

    Sub isiGridStn(ByVal kd_barang As String)
        Try
            Dim sql As String = "SELECT kd_satuan, isi, harga_jual_u, harga_jual_l, harga_jual_p FROM tb_barang_satuan
                                WHERE kd_barang = '" & kd_barang & "' AND jenis_satuan = 'M'"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                isiColStn()
                For Each dr As DataRow In ds.Tables(0).Rows
                    With dgvSatuan
                        Dim baris As Integer = .Rows.Add()
                        .Rows.Item(baris).Cells(0).Value = dr("kd_satuan")
                        .Rows.Item(baris).Cells(1).Value = dr("isi")
                        .Rows.Item(baris).Cells(2).Value = dr("harga_jual_u")
                        .Rows.Item(baris).Cells(3).Value = dr("harga_jual_l")
                        .Rows.Item(baris).Cells(4).Value = dr("harga_jual_p")
                    End With
                Next
                judulGridSatuan()
            Else
                dgvSatuan.Columns.Clear()
                dgvSatuan.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGridSatuan()
        With dgvSatuan
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            .AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .RowHeadersVisible = False
            .Columns(0).Width = 50
            .Columns(1).Width = 40
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(2).DefaultCellStyle.Format = "c0"
            .Columns(3).DefaultCellStyle.Format = "c0"
            .Columns(4).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub isiGrid()
        Try
            Dim harga_jual As String = "harga_jual_u"
            If from = "penjualan-langganan" Then
                harga_jual = "harga_jual_l"
            ElseIf from = "penjualan-partai" Then
                harga_jual = "harga_jual_p"
            End If
            Dim status As String = ""
            If from.Contains("penjualan") Then
                status = " AND tb.status = 'A'"
            End If
            Dim limit As Integer = offset * (page - 1)
            Dim sql As String = "SELECT tb.kd_barang, tb.nama_barang, tbs.kd_satuan,
                                tb.harga_beli*tbs.isi, tbs." & harga_jual & ", (tbs.harga_jual_p) - (tb.harga_beli*tbs.isi),
                                tbs.harga_jual_l, tb.stok/tbs.isi,
                                CASE
                                WHEN tb.status = 'A' THEN 'Aktif'
                                WHEN tb.status = 'N' THEN 'Non Aktif'
                                END status, tbs.isi FROM tb_barang tb
                                JOIN tb_barang_satuan tbs ON tb.kd_barang = tbs.kd_barang
                                WHERE (tb.kd_barang LIKE @kd_barang OR tb.nama_barang LIKE @nama_barang)" & status & "
                                ORDER BY tb.status, " & sortBy & "
                                LIMIT " & limit & ", " & offset
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kd_barang", "%" & tbCari.Text & "%")
                cmd.Parameters.AddWithValue("@nama_barang", "%" & tbCari.Text & "%")
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        Using dt As New DataTable
                            dt.Load(dr)
                            dgvBarang.DataSource = dt
                        End Using
                        judulGrid()
                    Else
                        dgvBarang.DataSource = Nothing
                    End If
                End Using
            End Using
            paging()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGrid()
        With dgvBarang
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvBarang.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Barang"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Satuan"
            .Columns(3).HeaderText = "Hrg. Beli"
            .Columns(4).HeaderText = "Hrg. Jual"
            .Columns(5).HeaderText = "Margin"
            .Columns(6).HeaderText = "Hrg. Minimum"
            .Columns(6).Visible = False
            .Columns(7).HeaderText = "Stok"
            .Columns(8).HeaderText = "Status"
            .Columns(9).Visible = False
            .Columns(0).Width = 80
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 50
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 80
            .Columns(7).Width = 60
            .Columns(8).Width = 50
            .Columns(3).DefaultCellStyle.Format = "c0"
            .Columns(4).DefaultCellStyle.Format = "c0"
            .Columns(5).DefaultCellStyle.Format = "c0"
            .Columns(6).DefaultCellStyle.Format = "c0"
            .Columns(7).DefaultCellStyle.Format = "n2"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
        If from.Contains("penjualan") Then
            With dgvBarang
                .Columns(3).Visible = False
                .Columns(5).Visible = False
                If from = "penjualan-umum" Then
                    .Columns(6).Visible = True
                Else
                    .Columns(6).Visible = False
                End If
                .Columns(8).Visible = False
            End With
        Else
            With dgvBarang
                .Columns(3).Visible = True
                .Columns(5).Visible = True
                .Columns(6).Visible = False
                .Columns(8).Visible = True
            End With
        End If
    End Sub

    Sub gridDetail()
        Dim baris As Integer
        With dgvBarang
            baris = .CurrentRow.Index
            id_data = .Item(0, baris).Value
            isiDetailBarang(.Item(0, baris).Value)
        End With
    End Sub

    Sub clear()
        isiCb()
        tbKode.Clear()
        tbNama.Clear()
        tbHrgBeli.Clear()
        tbHrgJualU.Clear()
        tbHrgJualL.Clear()
        tbHrgJualP.Clear()
        dgvSatuan.Columns.Clear()
        dgvSatuan.Rows.Clear()
        tbStok.Clear()
        tbStokFisik.Clear()
        cbStatus.SelectedIndex = -1
    End Sub

    Sub reset()
        tbKode.ReadOnly = True
        cbCustom.Checked = False
        gbBarang.Enabled = False
        gbStnMulti.Enabled = False
        lblStok.Visible = False
        tbStokFisik.Visible = False
        clear()
        btnBarcode.Enabled = False
        btnTambah.Text = "Tambah"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub modeSimpan()
        gbBarang.Enabled = True
        gbStnMulti.Enabled = True
        tbNama.Focus()
        btnTambah.Text = "Simpan"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Function kode_barang()
        Try
            Dim kode As String = "B000000"
            Dim hitung As String = "1"
            Dim sql As String = "SELECT kd_barang FROM tb_barang WHERE kd_barang Like 'B%'" _
                                 & "ORDER BY kd_barang DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Right(dr.Item("kd_barang").ToString, 6)) + 1
                        End While
                        If Len(hitung) = 1 Then
                            kode = "B000000"
                        ElseIf Len(hitung) = 2 Then
                            kode = "B00000"
                        ElseIf Len(hitung) = 3 Then
                            kode = "B0000"
                        ElseIf Len(hitung) = 4 Then
                            kode = "B000"
                        ElseIf Len(hitung) = 5 Then
                            kode = "B00"
                        ElseIf Len(hitung) = 6 Then
                            kode = "B0"
                        ElseIf Len(hitung) = 7 Then
                            kode = "B"
                        End If
                    End If
                End Using
            End Using
            Return kode & hitung
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return ""
        End Try
    End Function

    Sub queryTambah()
        Try
            Dim kode As String = ""
            If cbCustom.Checked Then
                kode = tbKode.Text
            Else
                kode = kode_barang()
            End If
            trans = conn.BeginTransaction
            Dim sql As String = "INSERT INTO tb_barang VALUES (@kode, @nama, @harga_beli, @stok, @status);
                                 INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan, @harga_jual_u, @harga_jual_l, @harga_jual_p);"
            If queryBarang(sql, kode, tbNama.Text.ToUpper, tbHrgBeli.Text, tbHrgJualU.Text, tbHrgJualL.Text, tbHrgJualP.Text,
                        0, cbStatus.Text(0), cbStnDasar.Text, 1, "D") Then
                Dim sqlStn As String = "INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan, @harga_jual_u, @harga_jual_l, @harga_jual_p);"
                For i As Integer = 0 To dgvSatuan.RowCount - 1
                    queryBarangStnMulti(sqlStn, kode, dgvSatuan.Rows(i).Cells(0).Value, dgvSatuan.Rows(i).Cells(1).Value, "M", dgvSatuan.Rows(i).Cells(2).Value, dgvSatuan.Rows(i).Cells(3).Value, dgvSatuan.Rows(i).Cells(4).Value)
                Next
                Dim sqlHistory As String = "INSERT INTO tb_barang_history VALUES(@kode, @kd_transaksi, @tanggal, @harga_beli, @stok_masuk, @stok_keluar);"
                queryBarangHistory(sqlHistory, kode, "SA", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"), tbHrgBeli.Text, tbStok.Text, 0)
                trans.Commit()
                isiGrid()
                MsgBox("Data berhasil di-tambah!", MsgBoxStyle.Information, "Informasi")
                reset()
            Else
                trans.Rollback()
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub queryEdit()
        Try
            trans = conn.BeginTransaction
            Dim sql As String = "UPDATE tb_barang SET kd_barang = @kode, nama_barang = @nama, harga_beli = @harga_beli, status = @status WHERE kd_barang = '" & id_data & "';
                                 DELETE FROM tb_barang_satuan WHERE kd_barang = '" & id_data & "';
                                 INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan, @harga_jual_u, @harga_jual_l, @harga_jual_p);"
            If queryBarang(sql, tbKode.Text, tbNama.Text.ToUpper, tbHrgBeli.Text, tbHrgJualU.Text, tbHrgJualL.Text, tbHrgJualP.Text,
                        0, cbStatus.Text(0), cbStnDasar.Text, 1, "D") Then
                Dim sqlStn As String = "INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan, @harga_jual_u, @harga_jual_l, @harga_jual_p);"
                For i As Integer = 0 To dgvSatuan.RowCount - 1
                    queryBarangStnMulti(sqlStn, tbKode.Text, dgvSatuan.Rows(i).Cells(0).Value, dgvSatuan.Rows(i).Cells(1).Value, "M", dgvSatuan.Rows(i).Cells(2).Value, dgvSatuan.Rows(i).Cells(3).Value, dgvSatuan.Rows(i).Cells(4).Value)
                Next
                Dim sqlHistory As String = "INSERT INTO tb_barang_history VALUES(@kode, @kd_transaksi, @tanggal, @harga_beli, @stok_masuk, @stok_keluar);"
                Dim selisih As Integer = tbStokFisik.Text - tbStok.Text
                If selisih > 0 Then
                    queryBarangHistory(sqlHistory, tbKode.Text, "SS", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"), tbHrgBeli.Text, selisih, 0)
                ElseIf selisih < 0 Then
                    queryBarangHistory(sqlHistory, tbKode.Text, "SS", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"), tbHrgBeli.Text, 0, Math.Abs(selisih))
                End If
                trans.Commit()
                isiGrid()
                MsgBox("Data berhasil di-edit!", MsgBoxStyle.Information, "Informasi")
                reset()
            Else
                trans.Rollback()
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub queryHapus()
        Try
            trans = conn.BeginTransaction
            Dim sql As String = "DELETE FROM tb_barang WHERE kd_barang = '" & id_data & "';
                                 DELETE FROM tb_barang_satuan WHERE kd_barang = '" & id_data & "';"
            If query(sql) Then
                trans.Commit()
                isiGrid()
                MsgBox("Data berhasil di-hapus!", MsgBoxStyle.Information, "Informasi")
                reset()
            Else
                trans.Rollback()
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            mode = "tambah"
            modeSimpan()
            clear()
            tbKode.Text = kode_barang()
            tbStok.ReadOnly = False
            cbStatus.SelectedIndex = 0
        Else
            If tbKode.Text = "" Or tbNama.Text = "" Or cbStnDasar.SelectedIndex = -1 Or tbHrgBeli.Text = "" Or tbHrgJualU.Text = "" Or
                tbHrgJualL.Text = "" Or tbHrgJualP.Text = "" Then
                MsgBox("Lengkapi data yang kosong!", 16, "Perhatian")
            Else
                If mode = "tambah" Then
                    queryTambah()
                Else
                    queryEdit()
                End If
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        mode = "edit"
        modeSimpan()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim pilih As Integer
        pilih = MsgBox("Yakin hapus barang " & id_data & " - " & tbNama.Text & " ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            queryHapus()
            reset()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        reset()
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        page = 1
        isiGrid()
    End Sub

    Private Sub cbCustom_CheckedChanged(sender As Object, e As EventArgs) Handles cbCustom.CheckedChanged
        If cbCustom.Checked Then
            If mode = "edit" Then
                'temp_kode = tbKode.Text
                temp_kode = kode_barang()
            Else
                temp_kode = kode_barang()
            End If
            tbKode.Clear()
            tbKode.ReadOnly = False
        Else
            tbKode.ReadOnly = True
            tbKode.Text = temp_kode
        End If
    End Sub

    Private Sub cbStnDasar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStnDasar.SelectedIndexChanged
        Dim stnDasar As String = "/ " & cbStnDasar.Text
        lblStnBeli.Text = stnDasar
        lblStnJualU.Text = stnDasar
        lblStnJualL.Text = stnDasar
        lblStnJualB.Text = stnDasar
        FormMultiSatuan.lblStnMulti.Text = stnDasar
        FormMultiSatuan.lblStnJualU.Text = stnDasar
        FormMultiSatuan.lblStnJualL.Text = stnDasar
        FormMultiSatuan.lblStnJualB.Text = stnDasar
        labelStok.Text = "Stok " & cbStnDasar.Text & " :"
    End Sub

    Private Sub tbHrgJualU_TextChanged(sender As Object, e As EventArgs) Handles tbHrgJualU.TextChanged
        formatRibuan(tbHrgJualU)
    End Sub

    Private Sub tbHrgBeli_TextChanged(sender As Object, e As EventArgs) Handles tbHrgBeli.TextChanged
        formatRibuan(tbHrgBeli)
    End Sub

    Private Sub tbHrgJualL_TextChanged(sender As Object, e As EventArgs) Handles tbHrgJualL.TextChanged
        formatRibuan(tbHrgJualL)
    End Sub

    Private Sub tbHrgJualB_TextChanged(sender As Object, e As EventArgs) Handles tbHrgJualP.TextChanged
        formatRibuan(tbHrgJualP)
    End Sub

    Sub paging()
        Dim status As String = ""
        If from.Contains("penjualan") Then
            status = " AND tb.status = 'A'"
        End If
        Dim sqlCount As String = "SELECT COUNT(*) FROM tb_barang tb
                                                  JOIN tb_barang_satuan tbs ON tb.kd_barang = tbs.kd_barang 
                                                  WHERE (tb.kd_barang LIKE @kd_barang OR tb.nama_barang LIKE @nama_barang)" & status
        Using cmdCount As New MySqlCommand(sqlCount, conn)
            cmdCount.Parameters.AddWithValue("@kd_barang", "%" & tbCari.Text & "%")
            cmdCount.Parameters.AddWithValue("@nama_barang", "%" & tbCari.Text & "%")
            Using drCount = cmdCount.ExecuteReader
                While drCount.Read
                    lblTotal.Text = "Jumlah Item : " & drCount.Item(0)
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        page += 1
        isiGrid()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        page -= 1
        isiGrid()
    End Sub

    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        reset()
        tbStok.ReadOnly = True
        lblStok.Visible = True
        tbStokFisik.Visible = True
        gridDetail()
        btnBarcode.Enabled = True
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub dgvBarang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellDoubleClick
        If e.RowIndex > -1 Then
            If from = "pembelian" Then
                Dim baris As Integer
                With dgvBarang
                    baris = .CurrentRow.Index
                    FormPembelian.kodeBarang = .Item(0, baris).Value
                    FormPembelian.tbKodeBarang.Text = .Item(0, baris).Value
                    FormPembelian.tbNamaBarang.Text = .Item(1, baris).Value
                    FormPembelian.tbSatuan.Text = .Item(2, baris).Value
                    FormPembelian.tbIsi.Text = .Item(9, baris).Value
                End With
                Me.Close()
            ElseIf from.Contains("penjualan") Then
                Dim baris As Integer
                With dgvBarang
                    baris = .CurrentRow.Index
                    FormPenjualan.kodeBarang = .Item(0, baris).Value
                    FormPenjualan.hrgMin = .Item(6, baris).Value
                    FormPenjualan.tbKodeBarang.Text = .Item(0, baris).Value
                    FormPenjualan.tbNamaBarang.Text = .Item(1, baris).Value
                    FormPenjualan.tbSatuan.Text = .Item(2, baris).Value
                    FormPenjualan.tbHargaJual.Text = FormatCurrency(.Item(4, baris).Value)
                    FormPenjualan.tbIsi.Text = .Item(9, baris).Value
                    FormPenjualan.tbHargaBeli.Text = .Item(3, baris).Value
                End With
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FormBarang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub tbHrgBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHrgBeli.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbHrgJualU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHrgJualU.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbHrgJualL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHrgJualL.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbHrgJualP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHrgJualP.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbIsiStn_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStok.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbStokFisik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStokFisik.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnBarcode_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        FormViewBarcode.viewBarcode(tbKode.Text)
        FormViewBarcode.ShowDialog()
    End Sub

    Private Sub dgvSatuan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSatuan.CellDoubleClick
        Try
            Dim baris As Integer
            With dgvSatuan
                baris = .CurrentRow.Index
                FormMultiSatuan.cbStnMulti.Text = .Item(0, baris).Value
                FormMultiSatuan.tbIsiStn.Text = .Item(1, baris).Value
                FormMultiSatuan.tbHrgJualU.Text = CInt(.Item(2, baris).Value)
                FormMultiSatuan.tbHrgJualL.Text = CInt(.Item(3, baris).Value)
                FormMultiSatuan.tbHrgJualP.Text = CInt(.Item(4, baris).Value)
            End With
            FormMultiSatuan.from = "edit"
            FormMultiSatuan.editRow = baris
            FormMultiSatuan.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAsc.Click
        If cbSort.SelectedIndex <> -1 Then
            If cbSort.Text.Contains("Kode") Then
                sortBy = "kd_barang ASC"
            ElseIf cbSort.Text.Contains("Nama") Then
                sortBy = "nama_barang ASC"
            ElseIf cbSort.Text.Contains("Beli") Then
                sortBy = "tb.harga_beli*tbs.isi ASC"
            ElseIf cbSort.Text.Contains("Jual") Then
                sortBy = "harga_jual_u ASC"
            ElseIf cbSort.Text.Contains("Margin") Then
                sortBy = "(tbs.harga_jual_p) - (tb.harga_beli*tbs.isi) ASC"
            ElseIf cbSort.Text.Contains("Stok") Then
                sortBy = "tb.stok/tbs.isi ASC"
            End If
            isiGrid()
        End If
    End Sub

    Private Sub btnDesc_Click(sender As Object, e As EventArgs) Handles btnDesc.Click
        If cbSort.SelectedIndex <> -1 Then
            If cbSort.Text.Contains("Kode") Then
                sortBy = "kd_barang DESC"
            ElseIf cbSort.Text.Contains("Nama") Then
                sortBy = "nama_barang DESC"
            ElseIf cbSort.Text.Contains("Beli") Then
                sortBy = "tb.harga_beli*tbs.isi DESC"
            ElseIf cbSort.Text.Contains("Jual") Then
                sortBy = "harga_jual_u DESC"
            ElseIf cbSort.Text.Contains("Margin") Then
                sortBy = "(tbs.harga_jual_p) - (tb.harga_beli*tbs.isi) DESC"
            ElseIf cbSort.Text.Contains("Stok") Then
                sortBy = "tb.stok/tbs.isi DESC"
            End If
            isiGrid()
        End If
    End Sub

    Private Sub btnTambahStn_Click(sender As Object, e As EventArgs) Handles btnTambahStn.Click
        Try
            FormMultiSatuan.reset()
            FormMultiSatuan.from = "tambah"
            FormMultiSatuan.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnHapusStn_Click(sender As Object, e As EventArgs) Handles btnHapusStn.Click
        Try
            dgvSatuan.Rows.Remove(dgvSatuan.CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGrid()
    End Sub
End Class