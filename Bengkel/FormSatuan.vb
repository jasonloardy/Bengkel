Imports MySql.Data.MySqlClient

Public Class FormSatuan
    Public mode, id_data As String

    Private Sub Formsatuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If koneksi() Then
            reset()
            isiGrid()
        End If
    End Sub

    Sub isiGrid()
        Try
            Dim sql As String = "SELECT * FROM tb_satuan"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvSatuan.DataSource = ds.Tables(0)
                judulGrid()
            Else
                dgvSatuan.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGrid()
        With dgvSatuan
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvSatuan.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Satuan"
            .Columns(1).HeaderText = "Nama Satuan"
            .Columns(0).Width = 150
            .Columns(1).Width = 200
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub gridDetail()
        Dim baris As Integer
        With dgvSatuan
            baris = .CurrentRow.Index
            id_data = .Item(0, baris).Value
            tbKodeSatuan.Text = .Item(0, baris).Value
            tbNamaSatuan.Text = .Item(1, baris).Value
        End With
    End Sub

    Private Sub dgvsatuan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSatuan.CellClick
        reset()
        gridDetail()
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Sub clear()
        tbKodeSatuan.Clear()
        tbNamaSatuan.Clear()
    End Sub

    Sub reset()
        gbSatuan.Enabled = False
        clear()
        btnTambah.Text = "Tambah"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub modeSimpan()
        gbSatuan.Enabled = True
        tbKodeSatuan.Focus()
        btnTambah.Text = "Simpan"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub queryTambah()
        Dim sql As String = "INSERT INTO tb_satuan VALUES (@kode, @nama)"
        If querySatuan(sql, tbKodeSatuan.Text.ToUpper, tbNamaSatuan.Text.ToUpper) Then
            isiGrid()
            MsgBox("Data berhasil di-tambah!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryEdit()
        Dim sql As String = "UPDATE tb_satuan SET kd_satuan = @kode, nama_satuan = @nama
                            WHERE kd_satuan = '" & id_data & "'"
        If querySatuan(sql, tbKodeSatuan.Text.ToUpper, tbNamaSatuan.Text.ToUpper) Then
            isiGrid()
            MsgBox("Data berhasil di-edit!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryHapus()
        Dim sql As String = "DELETE FROM tb_satuan WHERE kd_satuan = '" & id_data & "'"
        If query(sql) Then
            isiGrid()
            MsgBox("Data berhasil di-hapus!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        mode = "edit"
        modeSimpan()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        reset()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim pilih As Integer
        pilih = MsgBox("Yakin hapus satuan " & id_data & " ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            queryHapus()
            reset()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            mode = "tambah"
            modeSimpan()
            clear()
        Else
            If tbKodeSatuan.Text = "" Or tbNamaSatuan.Text = "" Then
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
End Class