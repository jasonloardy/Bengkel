Imports MySql.Data.MySqlClient

Public Class FormSupplier
    Public mode, id_data, from As String
    Public page As Integer = 1
    Public totalPage As Integer = 1
    Public offset As Integer = 1

    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        reset()
        isiGrid()
    End Sub

    Sub paging()
        Dim sqlCount As String = "SELECT COUNT(*) FROM tb_supplier
                                    WHERE (kd_supplier LIKE @kd_supplier OR nama LIKE @nama)"
        Using cmdCount As New MySqlCommand(sqlCount, conn)
            cmdCount.Parameters.AddWithValue("@kd_supplier", "%" & tbCari.Text & "%")
            cmdCount.Parameters.AddWithValue("@nama", "%" & tbCari.Text & "%")
            Using drCount = cmdCount.ExecuteReader
                While drCount.Read
                    lblTotal.Text = "Jumlah Supplier : " & drCount.Item(0)
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
            Dim sql As String = "SELECT * FROM tb_supplier
                                WHERE (kd_supplier LIKE @kd_supplier OR nama LIKE @nama)
                                ORDER BY kd_supplier
                                LIMIT " & limit & ", " & offset
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kd_supplier", "%" & tbCari.Text & "%")
                cmd.Parameters.AddWithValue("@nama", "%" & tbCari.Text & "%")
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        Using dt As New DataTable
                            dt.Load(dr)
                            dgvSupplier.DataSource = dt
                        End Using
                        judulGrid()
                    Else
                        dgvSupplier.DataSource = Nothing
                    End If
                End Using
            End Using
            paging()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGrid()
        With dgvSupplier
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvSupplier.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Supplier"
            .Columns(1).HeaderText = "Nama Supplier"
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).HeaderText = "No. Telepon"
            .Columns(0).Width = 125
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 250
            .Columns(3).Width = 125
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub gridDetail()
        Dim baris As Integer
        With dgvSupplier
            baris = .CurrentRow.Index
            id_data = .Item(0, baris).Value
            tbKode.Text = .Item(0, baris).Value
            tbNama.Text = .Item(1, baris).Value
            tbAlamat.Text = .Item(2, baris).Value
            tbTelepon.Text = .Item(3, baris).Value
        End With
    End Sub

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
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
    End Sub

    Sub reset()
        gbSupplier.Enabled = False
        clear()
        btnTambah.Text = "Tambah"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub modeSimpan()
        gbSupplier.Enabled = True
        tbNama.Focus()
        btnTambah.Text = "Simpan"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Function kode_supplier()
        Try
            Dim kode As String = "SP00000"
            Dim hitung As String = "1"
            Dim sql As String = "SELECT kd_supplier FROM tb_supplier WHERE kd_supplier LIKE 'SP%'" _
                                 & "ORDER BY kd_supplier DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Right(dr.Item("kd_supplier").ToString, 6)) + 1
                        End While
                        If Len(hitung) = 1 Then
                            kode = "SP00000"
                        ElseIf Len(hitung) = 2 Then
                            kode = "SP0000"
                        ElseIf Len(hitung) = 3 Then
                            kode = "SP000"
                        ElseIf Len(hitung) = 4 Then
                            kode = "SP00"
                        ElseIf Len(hitung) = 5 Then
                            kode = "SP0"
                        ElseIf Len(hitung) = 6 Then
                            kode = "SP"
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
        Dim sql As String = "INSERT INTO tb_supplier VALUES (@kode, @nama, @alamat, @telepon)"
        If querySupplier(sql, kode_supplier, tbNama.Text.ToUpper, tbAlamat.Text.ToUpper, tbTelepon.Text) Then
            isiGrid()
            MsgBox("Data berhasil di-tambah!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryEdit()
        Dim sql As String = "UPDATE tb_supplier SET nama = @nama, alamat = @alamat,
                            no_telepon = @telepon WHERE kd_supplier = '" & id_data & "'"
        If querySupplier(sql, tbKode.Text, tbNama.Text.ToUpper, tbAlamat.Text.ToUpper, tbTelepon.Text) Then
            isiGrid()
            MsgBox("Data berhasil di-edit!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryHapus()
        Dim sql As String = "DELETE FROM tb_supplier WHERE kd_supplier = '" & id_data & "'"
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
            tbKode.Text = kode_supplier()
        Else
            If tbKode.Text = "" Or tbNama.Text = "" Or tbAlamat.Text = "" Or tbTelepon.Text = "" Then
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
        pilih = MsgBox("Yakin hapus supplier " & id_data & " - " & tbNama.Text & " ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            queryHapus()
            reset()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        reset()
    End Sub

    Private Sub dgvSupplier_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellDoubleClick
        If from = "pembelian" Then
            Dim baris As Integer
            With dgvSupplier
                baris = .CurrentRow.Index
                FormPembelian.tbKodeSupplier.Text = .Item(0, baris).Value
                FormPembelian.tbNamaSupplier.Text = .Item(1, baris).Value
                FormPembelian.tbAlamat.Text = .Item(2, baris).Value
                FormPembelian.tbNoTelepon.Text = .Item(3, baris).Value
            End With
            Me.Close()
        End If
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGrid()
    End Sub

End Class