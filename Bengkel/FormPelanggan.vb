﻿Imports MySql.Data.MySqlClient

Public Class FormPelanggan
    Public mode, id_data As String
    Public dt As DataTable

    Private Sub Formpelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If koneksi() Then
            reset()
            isiGrid()
        End If
    End Sub

    Sub isiGrid()
        Try
            Dim sql As String = "SELECT kd_pelanggan, nama, alamat, no_telepon,
                                CASE
                                WHEN kategori = 'U' THEN 'Umum'
                                WHEN kategori = 'L' THEN 'Langganan'
                                WHEN kategori = 'B' THEN 'Bengkel'
                                END kategori
                                FROM tb_pelanggan"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvpelanggan.DataSource = ds.Tables(0)
                dt = ds.Tables(0)
                judulGrid()
            Else
                dgvpelanggan.DataSource = Nothing
            End If
            lblTotal.Text = "Jumlah Pelanggan : " & dgvPelanggan.RowCount
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGrid()
        With dgvpelanggan
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvpelanggan.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode pelanggan"
            .Columns(1).HeaderText = "Nama pelanggan"
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).HeaderText = "No. Telepon"
            .Columns(4).HeaderText = "Kategori"
            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub gridDetail()
        Dim baris As Integer
        With dgvpelanggan
            baris = .CurrentRow.Index
            id_data = .Item(0, baris).Value
            tbKode.Text = .Item(0, baris).Value
            tbNama.Text = .Item(1, baris).Value
            tbAlamat.Text = .Item(2, baris).Value
            tbTelepon.Text = .Item(3, baris).Value
            cbKategori.Text = .Item(4, baris).Value
        End With
    End Sub

    Private Sub dgvpelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpelanggan.CellClick
        reset()
        gridDetail()
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Sub clear()
        tbKode.Clear()
        tbNama.Clear()
        tbAlamat.Clear()
        tbTelepon.Clear()
        cbKategori.SelectedIndex = -1
    End Sub

    Sub reset()
        gbpelanggan.Enabled = False
        clear()
        btnTambah.Text = "Tambah"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub modeSimpan()
        gbpelanggan.Enabled = True
        tbNama.Focus()
        btnTambah.Text = "Simpan"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Function kode_pelanggan()
        Try
            Dim kode As String = "PL00000"
            Dim hitung As String = "1"
            Dim sql As String = "SELECT kd_pelanggan FROM tb_pelanggan WHERE kd_pelanggan LIKE 'PL%'" _
                                 & "ORDER BY kd_pelanggan DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Right(dr.Item("kd_pelanggan").ToString, 6)) + 1
                        End While
                        If Len(hitung) = 1 Then
                            kode = "PL00000"
                        ElseIf Len(hitung) = 2 Then
                            kode = "PL0000"
                        ElseIf Len(hitung) = 3 Then
                            kode = "PL000"
                        ElseIf Len(hitung) = 4 Then
                            kode = "PL00"
                        ElseIf Len(hitung) = 5 Then
                            kode = "PL0"
                        ElseIf Len(hitung) = 6 Then
                            kode = "PL"
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
        Dim sql As String = "INSERT INTO tb_pelanggan VALUES (@kode, @nama, @alamat, @telepon, @kategori)"
        If queryPelanggan(sql, kode_pelanggan, tbNama.Text.ToUpper, tbAlamat.Text.ToUpper, tbTelepon.Text, cbKategori.Text(0)) Then
            isiGrid()
            MsgBox("Data berhasil di-tambah!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryEdit()
        Dim sql As String = "UPDATE tb_pelanggan SET nama = @nama, alamat = @alamat,
                            no_telepon = @telepon, kategori = @kategori WHERE kd_pelanggan = '" & id_data & "'"
        If queryPelanggan(sql, tbKode.Text, tbNama.Text.ToUpper, tbAlamat.Text.ToUpper, tbTelepon.Text, cbKategori.Text(0)) Then
            isiGrid()
            MsgBox("Data berhasil di-edit!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryHapus()
        Dim sql As String = "DELETE FROM tb_pelanggan WHERE kd_pelanggan = '" & id_data & "'"
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
            tbKode.Text = kode_pelanggan()
        Else
            If tbKode.Text = "" Or tbNama.Text = "" Or tbAlamat.Text = "" Or tbTelepon.Text = "" Or cbKategori.SelectedIndex = -1 Then
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
        pilih = MsgBox("Yakin hapus pelanggan " & id_data & " - " & tbNama.Text & " ?", 48 + 4 + 256, "Konfirmasi")
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
            dt.DefaultView.RowFilter = "kd_pelanggan LIKE '%" & tbCari.Text & "%' OR nama LIKE '%" & tbCari.Text & "%'"
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGrid()
    End Sub
End Class