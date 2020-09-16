Imports MySql.Data.MySqlClient

Public Class FormDaftarpiutang
    Public from As String
    Public dtTrx As DataTable
    Public dtpelanggan As DataTable
    Private Sub FormDaftarpiutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        reset()
        isiGridpelanggan()
    End Sub

    Sub reset()
        tbCaripelanggan.Clear()
        dgvPelanggan.DataSource = Nothing
        tbCariTrx.Clear()
        dgvTrx.DataSource = Nothing
    End Sub

    Sub isiGridpelanggan()
        Try
            Dim sql As String = "SELECT tb.kd_pelanggan, ts.nama, ts.alamat, ts.no_telepon, SUM(tb.sisa) total_piutang
                                    FROM tb_penjualan tb
                                    JOIN tb_pelanggan ts ON tb.kd_pelanggan = ts.kd_pelanggan
                                    WHERE tb.sisa > 0 AND tb.status = '1'
                                    GROUP BY tb.kd_pelanggan"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvPelanggan.DataSource = ds.Tables(0)
                dtpelanggan = ds.Tables(0)
                judulGridpelanggan()
            Else
                dgvPelanggan.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGridpelanggan()
        With dgvPelanggan
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvPelanggan.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode pelanggan"
            .Columns(1).HeaderText = "Nama pelanggan"
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).HeaderText = "Total piutang"
            .Columns(0).Width = 100
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).Width = 100
            .Columns(4).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub isiGridTrx(ByVal kd_pelanggan As String)
        Try
            Dim sql As String = "SELECT tb.kd_penjualan, tanggal,
                                    SUM(tbd.qty*tbd.harga_jual*(100-tbd.diskon)/100)*(100-tb.diskon)/100 nominal, sisa
                                    FROM tb_penjualan tb
                                    JOIN tb_penjualan_detail tbd ON tb.kd_penjualan = tbd.kd_penjualan
                                    WHERE kd_pelanggan = '" & kd_pelanggan & "' AND sisa > 0 AND status = '1'
                                    GROUP BY tb.kd_penjualan"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvTrx.DataSource = ds.Tables(0)
                dtTrx = ds.Tables(0)
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
            .Columns(0).HeaderText = "Kode penjualan"
            .Columns(1).HeaderText = "Jatuh Tempo"
            .Columns(2).HeaderText = "Nominal"
            .Columns(3).HeaderText = "Sisa"
            .Columns(0).Width = 150
            .Columns(1).Width = 100
            .Columns(2).DefaultCellStyle.Format = "c0"
            .Columns(3).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub isipelanggan()
        FormPembayaranpiutang.reset()
        Dim baris As Integer
        With dgvPelanggan
            baris = .CurrentRow.Index
            FormPembayaranpiutang.tbKodePlg.Text = .Item(0, baris).Value
            FormPembayaranpiutang.tbNamaPlg.Text = .Item(1, baris).Value
            FormPembayaranpiutang.tbAlamat.Text = .Item(2, baris).Value
            FormPembayaranpiutang.tbNoTelepon.Text = .Item(3, baris).Value
        End With
        Me.Close()
    End Sub

    Private Sub dgvpelanggan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellDoubleClick
        If e.RowIndex > -1 Then
            If from = "piutang-pelanggan" Then
                If FormPembayaranpiutang.tbKodePlg.Text <> "" Then
                    If FormPembayaranpiutang.tbKodePlg.Text = dgvPelanggan.Item(0, dgvPelanggan.CurrentRow.Index).Value Then
                        Me.Close()
                    Else
                        Dim pilih As Integer
                        pilih = MsgBox("Yakin Ganti pelanggan? (Keranjang Transaksi Akan Di-Reset)", 48 + 4 + 256, "Konfirmasi")
                        If pilih = 6 Then
                            isipelanggan()
                        End If
                    End If
                Else
                    isipelanggan()
                End If
            End If
        End If
    End Sub

    Private Sub tbCaripelanggan_TextChanged(sender As Object, e As EventArgs) Handles tbCaripelanggan.TextChanged
        Try
            dtpelanggan.DefaultView.RowFilter = "kd_pelanggan LIKE '%" & tbCaripelanggan.Text & "%' OR nama LIKE '%" & tbCaripelanggan.Text & "%'"
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbCariTrx_TextChanged(sender As Object, e As EventArgs) Handles tbCariTrx.TextChanged
        Try
            dtTrx.DefaultView.RowFilter = "kd_penjualan LIKE '%" & tbCariTrx.Text & "%' OR kd_bukti LIKE '%" & tbCariTrx.Text & "%' OR sales LIKE '%" & tbCariTrx.Text & "%'"
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGridpelanggan()
    End Sub

    Private Sub dgvpelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        If e.RowIndex > -1 Then
            isiGridTrx(dgvPelanggan.Item(0, e.RowIndex).Value)
        End If
    End Sub
End Class