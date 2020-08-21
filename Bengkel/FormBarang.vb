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

    Sub isiGrid()
        Try
            Dim sql As String = "SELECT kd_barang, nama_barang, harga_beli,
                                    harga_jual_u, harga_jual_l, harga_jual_b, stok,
                                    CASE
                                    WHEN status = 'A' THEN 'Aktif'
                                    WHEN status = 'N' THEN 'Non Aktif'
                                    END status FROM tb_barang"
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
            .Columns(2).HeaderText = "Hrg. Beli"
            .Columns(3).HeaderText = "Hrg. Jual"
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).HeaderText = "Stok"
            .Columns(7).HeaderText = "Status"
            .Columns(0).Width = 100
            .Columns(1).Width = 200
            .Columns(2).Width = 100
            .Columns(3).Width = 100
            .Columns(6).Width = 75
            .Columns(7).Width = 75
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
            tbKode.Text = .Item(0, baris).Value
            tbNama.Text = .Item(1, baris).Value
            tbHrgBeli.Text = .Item(2, baris).Value
            tbHrgJualU.Text = .Item(3, baris).Value
            tbHrgJualL.Text = .Item(4, baris).Value
            tbHrgJualB.Text = .Item(5, baris).Value
            cbStatus.Text = .Item(7, baris).Value
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
        tbIsiStn.Clear()
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
        gbbarang.Enabled = True
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
        Dim kode As String = ""
        Dim sql As String = "INSERT INTO tb_barang VALUES (@kode, @nama, @harga_beli, @harga_jual_u, @harga_jual_l,
                                @harga_jual_b, @stok, @status)"
        If cbCustom.Checked Then
            kode = tbKode.Text
        Else
            kode = kode_barang()
        End If
        If queryBarang(sql, kode, tbNama.Text.ToUpper, tbHrgBeli.Text, tbHrgJualU.Text, tbHrgJualL.Text, tbHrgJualB.Text,
                       0, cbStatus.Text(0)) Then
            isiGrid()
            MsgBox("Data berhasil di-tambah!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryEdit()
        Dim sql As String = "UPDATE tb_barang SET nama = @nama, alamat = @alamat,
                            no_telepon = @telepon, kategori = @kategori WHERE kd_barang = '" & id_data & "'"
        'If querybarang(sql, tbKode.Text, tbNama.Text.ToUpper, tbAlamat.Text.ToUpper, tbTelepon.Text, cbKategori.Text(0)) Then
        isiGrid()
            MsgBox("Data berhasil di-edit!", MsgBoxStyle.Information, "Informasi")
            reset()
        'End If
    End Sub

    Sub queryHapus()
        Dim sql As String = "DELETE FROM tb_barang WHERE kd_barang = '" & id_data & "'"
        If query(sql) Then
            isiGrid()
            MsgBox("Data berhasil di-hapus!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
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
            'dt.DefaultView.RowFilter = "kd_barang LIKE '%" & tbCari.Text & "%' OR nama_barang LIKE '%" & tbCari.Text & "%'"
            dt.DefaultView.RowFilter = String.Format("nama_barang LIKE '%{0}%'", tbCari.Text)
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub cbCustom_CheckedChanged(sender As Object, e As EventArgs) Handles cbCustom.CheckedChanged
        If cbCustom.Checked Then
            tbKode.Clear()
        Else
            tbKode.Text = kode_barang()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGrid()
    End Sub
End Class