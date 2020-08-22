Imports MySql.Data.MySqlClient

Public Class FormBarang
    Public mode, id_data As String
    Public dt As DataTable

    Private Sub Formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If koneksi() Then
            reset()
            isiGrid()
        End If
    End Sub

    Sub isiCb()
        Dim sqlStn As String = "SELECT * FROM tb_satuan"

        cbStnDasar.DataSource = queryCb(sqlStn)
        cbStnDasar.DisplayMember = "kd_satuan"
        cbStnDasar.SelectedIndex = -1

        cbStnMulti.DataSource = queryCb(sqlStn)
        cbStnMulti.DisplayMember = "kd_satuan"
        cbStnMulti.SelectedIndex = -1
    End Sub

    Sub isiDetailBarang(ByVal kd_barang As String)
        Try
            Dim sql As String = "SELECT tb.kd_barang, tb.nama_barang, tbs.kd_satuan,
                                tb.harga_beli*tbs.isi harga_beli, tb.harga_jual_u*tbs.isi harga_jual_u,
                                tb.harga_jual_l*tbs.isi harga_jual_l, tb.harga_jual_b*tbs.isi harga_jual_b,
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
                            tbHrgJualB.Text = dr.Item("harga_jual_b")
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
                dt = ds.Tables(0)
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
        colKdSatuan.HeaderText = "Kode Satuan"
        dgvSatuan.Columns.Add(colKdSatuan)
        Dim colIsi As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        colIsi.HeaderText = "Isi"
        dgvSatuan.Columns.Add(colIsi)
    End Sub

    Sub isiGridStn(ByVal kd_barang As String)
        Try
            Dim sql As String = "SELECT kd_satuan, isi FROM tb_barang_satuan
                                WHERE kd_barang = '" & kd_barang & "' AND jenis_satuan = 'M'"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                isiColStn()

                dt = ds.Tables(0)
                For Each dr As DataRow In ds.Tables(0).Rows
                    With dgvSatuan
                        Dim baris As Integer = .Rows.Add()
                        .Rows.Item(baris).Cells(0).Value = dr("kd_satuan")
                        .Rows.Item(baris).Cells(1).Value = dr("isi")
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
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub isiGrid()
        Try
            Dim sql As String = "SELECT tb.kd_barang, tb.nama_barang, tbs.kd_satuan,
                                tb.harga_beli*tbs.isi, tb.harga_jual_u*tbs.isi, tb.harga_jual_l*tbs.isi,
                                tb.harga_jual_b*tbs.isi, tb.stok/tbs.isi,
                                CASE
                                WHEN tb.status = 'A' THEN 'Aktif'
                                WHEN tb.status = 'N' THEN 'Non Aktif'
                                END status FROM tb_barang tb
                                JOIN tb_barang_satuan tbs ON tb.kd_barang = tbs.kd_barang
                                ORDER BY tb.status, tb.kd_barang"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvBarang.DataSource = ds.Tables(0)
                dt = ds.Tables(0)
                judulGrid()
            Else
                dgvBarang.DataSource = Nothing
            End If
            lblTotal.Text = "Jumlah Item : " & dgvBarang.RowCount
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
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).HeaderText = "Stok"
            .Columns(8).HeaderText = "Status"
            .Columns(0).Width = 100
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 75
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(7).Width = 75
            .Columns(8).Width = 75
            .Columns(3).DefaultCellStyle.Format = "c0"
            .Columns(4).DefaultCellStyle.Format = "c0"
            .Columns(7).DefaultCellStyle.Format = "n2"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub gridDetail()
        Dim baris As Integer
        With dgvBarang
            baris = .CurrentRow.Index
            id_data = .Item(0, baris).Value
            isiDetailBarang(.Item(0, baris).Value)
        End With
    End Sub

    Private Sub dgvbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        reset()
        gridDetail()
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Sub clear()
        isiCb()
        tbKode.Clear()
        tbNama.Clear()
        tbHrgBeli.Clear()
        tbHrgJualU.Clear()
        tbHrgJualL.Clear()
        tbHrgJualB.Clear()
        cbStnMulti.SelectedIndex = -1
        tbIsiStn.Clear()
        dgvSatuan.Columns.Clear()
        dgvSatuan.Rows.Clear()
        cbStatus.SelectedIndex = -1
    End Sub

    Sub reset()
        gbBarang.Enabled = False
        gbStnMulti.Enabled = False
        clear()
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
            Dim sql As String = "SELECT kd_barang FROM tb_barang WHERE kd_barang LIKE 'B%'" _
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
            Dim sql As String = "INSERT INTO tb_barang VALUES (@kode, @nama, @harga_beli, @harga_jual_u, @harga_jual_l, @harga_jual_b, @stok, @status);
                                 INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan);"
            If queryBarang(sql, kode, tbNama.Text.ToUpper, tbHrgBeli.Text, tbHrgJualU.Text, tbHrgJualL.Text, tbHrgJualB.Text,
                        0, cbStatus.Text(0), cbStnDasar.Text, 1, "D") Then
                Dim sqlStn As String = "INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan);"
                For i As Integer = 0 To dgvSatuan.RowCount - 1
                    queryBarangStnMulti(sqlStn, kode, dgvSatuan.Rows(i).Cells(0).Value, dgvSatuan.Rows(i).Cells(1).Value, "M")
                Next
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
            Dim sql As String = "UPDATE tb_barang SET kd_barang = @kode, nama_barang = @nama, harga_beli = @harga_beli, 
                                  harga_jual_u = @harga_jual_u, harga_jual_b = @harga_jual_b, status = @status WHERE kd_barang = '" & id_data & "';
                                 DELETE FROM tb_barang_satuan WHERE kd_barang = '" & id_data & "';
                                 INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan);"
            If queryBarang(sql, tbKode.Text, tbNama.Text.ToUpper, tbHrgBeli.Text, tbHrgJualU.Text, tbHrgJualL.Text, tbHrgJualB.Text,
                        0, cbStatus.Text(0), cbStnDasar.Text, 1, "D") Then
                Dim sqlStn As String = "INSERT INTO tb_barang_satuan VALUES (@kode, @kd_satuan, @isi, @jenis_satuan);"
                For i As Integer = 0 To dgvSatuan.RowCount - 1
                    queryBarangStnMulti(sqlStn, tbKode.Text, dgvSatuan.Rows(i).Cells(0).Value, dgvSatuan.Rows(i).Cells(1).Value, "M")
                Next
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
            cbStatus.SelectedIndex = 0
        Else
            If tbKode.Text = "" Or tbNama.Text = "" Or cbStnDasar.SelectedIndex = -1 Or tbHrgBeli.Text = "" Or tbHrgJualU.Text = "" Or
                tbHrgJualL.Text = "" Or tbHrgJualB.Text = "" Then
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
        Try
            dt.DefaultView.RowFilter = "kd_barang LIKE '%" & tbCari.Text & "%' OR nama_barang LIKE '%" & tbCari.Text & "%'"
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub cbCustom_CheckedChanged(sender As Object, e As EventArgs) Handles cbCustom.CheckedChanged
        If cbCustom.Checked Then
            tbKode.Clear()
            tbKode.Enabled = True
        Else
            tbKode.Text = kode_barang()
        End If
    End Sub

    Private Sub cbStnDasar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStnDasar.SelectedIndexChanged
        Dim stnDasar As String = "/ " & cbStnDasar.Text
        lblStnBeli.Text = stnDasar
        lblStnJualU.Text = stnDasar
        lblStnJualL.Text = stnDasar
        lblStnJualB.Text = stnDasar
        lblStnMulti.Text = stnDasar
    End Sub

    Private Sub btnTambahStn_Click(sender As Object, e As EventArgs) Handles btnTambahStn.Click
        Try
            If cbStnMulti.SelectedIndex = -1 Or tbIsiStn.Text = "" Then
                MsgBox("Masukkan Satuan & Isi", 16, "Perhatian")
            Else
                If dgvSatuan.ColumnCount = 0 Then
                    isiColStn()
                    judulGridSatuan()
                End If
                With dgvSatuan
                    Dim baris As Integer = .Rows.Add()
                    .Rows.Item(baris).Cells(0).Value = cbStnMulti.Text
                    .Rows.Item(baris).Cells(1).Value = tbIsiStn.Text
                End With
                cbStnMulti.SelectedIndex = -1
                tbIsiStn.Clear()
            End If
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