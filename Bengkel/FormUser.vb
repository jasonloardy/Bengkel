Imports MySql.Data.MySqlClient

Public Class FormUser
    Public mode, id_data As String

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If koneksi() Then
            reset()
            isiGrid()
        End If
    End Sub

    Sub isiGrid()
        Try
            Dim sql As String = "SELECT username, password, nama,
                                CASE
                                WHEN level = 'A' THEN 'Admin'
                                WHEN level = 'K' THEN 'Kasir'
                                END level,
                                CASE
                                WHEN status = 'A' THEN 'Aktif'
                                WHEN status = 'N' THEN 'Non Aktif'
                                END status
                                FROM tb_user"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvUser.DataSource = ds.Tables(0)
                judulGrid()
            Else
                dgvUser.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGrid()
        With dgvUser
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvUser.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Username"
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "Nama"
            .Columns(3).HeaderText = "Level"
            .Columns(4).HeaderText = "Status"
            .Columns(0).Width = 100
            .Columns(1).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub gridDetail()
        Dim baris As Integer
        With dgvUser
            baris = .CurrentRow.Index
            id_data = .Item(0, baris).Value
            tbNama.Text = .Item(2, baris).Value
            tbUsername.Text = .Item(0, baris).Value
            tbPassword.Text = .Item(1, baris).Value
            cbLevel.Text = .Item(3, baris).Value
            cbStatus.Text = .Item(4, baris).Value
        End With
    End Sub

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        reset()
        gridDetail()
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Sub clear()
        tbNama.Clear()
        tbUsername.Clear()
        tbPassword.Clear()
        cbLevel.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        cbLihat.Checked = False
    End Sub

    Sub reset()
        gbUser.Enabled = False
        clear()
        btnTambah.Text = "Tambah"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub modeSimpan()
        gbUser.Enabled = True
        tbUsername.Focus()
        btnTambah.Text = "Simpan"
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub queryTambah()
        Dim sql As String = "INSERT INTO tb_user VALUES (@username, @password, @nama, @level, @status)"
        If queryUser(sql, tbUsername.Text.ToLower, tbPassword.Text, tbNama.Text.ToUpper, cbLevel.Text(0), cbStatus.Text(0)) Then
            isiGrid()
            MsgBox("Data berhasil di-tambah!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryEdit()
        Dim sql As String = "UPDATE tb_user SET username = @username, password = @password, nama = @nama, level = @level,
                            status = @status WHERE username = '" & id_data & "'"
        If queryUser(sql, tbUsername.Text.ToLower, tbPassword.Text, tbNama.Text.ToUpper, cbLevel.Text(0), cbStatus.Text(0)) Then
            isiGrid()
            MsgBox("Data berhasil di-edit!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Sub queryHapus()
        Dim sql As String = "DELETE FROM tb_user WHERE username = '" & id_data & "'"
        If query(sql) Then
            isiGrid()
            MsgBox("Data berhasil di-hapus!", MsgBoxStyle.Information, "Informasi")
            reset()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        mode = "edit"
        modeSimpan()
        tbUsername.Enabled = False
        tbNama.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        reset()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim pilih As Integer
        pilih = MsgBox("Yakin hapus user " & id_data & " ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            queryHapus()
            reset()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbLihat.CheckedChanged
        If cbLihat.Checked Then
            tbPassword.PasswordChar = ""
        Else
            tbPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            mode = "tambah"
            modeSimpan()
            clear()
        Else
            If tbNama.Text = "" Or tbUsername.Text = "" Or tbPassword.Text = "" Or cbLevel.SelectedIndex = -1 Or cbStatus.SelectedIndex = -1 Then
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
