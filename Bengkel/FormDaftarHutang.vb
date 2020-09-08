Imports MySql.Data.MySqlClient

Public Class FormDaftarHutang
    Public from As String
    Public dtTrx As DataTable
    Private Sub FormDaftarHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If koneksi() Then
            reset()
            isiGridSupplier()
        End If
    End Sub

    Sub reset()
        tbCariSupplier.Clear()
        dgvSupplier.DataSource = Nothing
        tbCariTrx.Clear()
        dgvTrx.DataSource = Nothing
    End Sub

    Sub isiGridSupplier()
        Try
            Dim sql As String = "SELECT tb.kd_supplier, ts.nama, ts.alamat, ts.no_telepon, SUM(tb.sisa) total_hutang
                                    FROM tb_pembelian tb
                                    JOIN tb_supplier ts ON tb.kd_supplier = ts.kd_supplier
                                    WHERE tb.sisa>0 AND (tb.kd_supplier LIKE @kd_supplier)
                                    GROUP BY tb.kd_supplier"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kd_supplier", "%" & tbCariSupplier.Text & "%")
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        Using dt As New DataTable
                            dt.Load(dr)
                            dgvSupplier.DataSource = dt
                        End Using
                        judulGridSupplier()
                    Else
                        dgvSupplier.DataSource = Nothing
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGridSupplier()
        With dgvSupplier
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvSupplier.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Supplier"
            .Columns(1).HeaderText = "Nama Supplier"
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).HeaderText = "Total Hutang"
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

    Sub isiGridTrx(ByVal kd_supplier As String)
        Try
            Dim sql As String = "SELECT tb.kd_pembelian, kd_bukti, sales, tanggal_jt,
                                    SUM(tbd.qty*tbd.harga_beli*(100-tbd.diskon)/100)*(100-tb.diskon)/100 nominal, sisa
                                    FROM tb_pembelian tb
                                    JOIN tb_pembelian_detail tbd ON tb.kd_pembelian = tbd.kd_pembelian
                                    WHERE kd_supplier = '" & kd_supplier & "' AND sisa > 0
                                    GROUP BY tb.kd_pembelian"
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
            .Columns(0).HeaderText = "Kode Pembelian"
            .Columns(1).HeaderText = "Kode Bukti"
            .Columns(2).HeaderText = "Sales"
            .Columns(3).HeaderText = "Jatuh Tempo"
            .Columns(4).HeaderText = "Nominal"
            .Columns(5).HeaderText = "Sisa"
            .Columns(0).Width = 150
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 100
            .Columns(4).DefaultCellStyle.Format = "c0"
            .Columns(5).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Private Sub dgvSupplier_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellEnter
        isiGridTrx(dgvSupplier.Item(0, e.RowIndex).Value)
    End Sub

    Sub isiSupplier()
        FormPembayaranHutang.reset()
        Dim baris As Integer
        With dgvSupplier
            baris = .CurrentRow.Index
            FormPembayaranHutang.tbKodeSupplier.Text = .Item(0, baris).Value
            FormPembayaranHutang.tbNamaSupplier.Text = .Item(1, baris).Value
            FormPembayaranHutang.tbAlamat.Text = .Item(2, baris).Value
            FormPembayaranHutang.tbNoTelepon.Text = .Item(3, baris).Value
        End With
        Me.Close()
    End Sub

    'dgvSupplier.Item(0, dgvSupplier.CurrentRow.Index).Value
    Private Sub dgvSupplier_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellDoubleClick
        If from = "hutang-supplier" Then
            If FormPembayaranHutang.tbKodeSupplier.Text <> "" Then
                If FormPembayaranHutang.tbKodeSupplier.Text = dgvSupplier.Item(0, dgvSupplier.CurrentRow.Index).Value Then
                    Me.Close()
                Else
                    Dim pilih As Integer
                    pilih = MsgBox("Yakin Ganti Supplier? (Keranjang Transaksi Akan Di-Reset)", 48 + 4 + 256, "Konfirmasi")
                    If pilih = 6 Then
                        isiSupplier()
                    End If
                End If
            Else
                isiSupplier()
            End If
        End If
    End Sub

    Private Sub tbCariSupplier_TextChanged(sender As Object, e As EventArgs) Handles tbCariSupplier.TextChanged
        isiGridSupplier()
    End Sub

    Private Sub tbCariTrx_TextChanged(sender As Object, e As EventArgs) Handles tbCariTrx.TextChanged
        Try
            dtTrx.DefaultView.RowFilter = "kd_pembelian LIKE '%" & tbCariTrx.Text & "%' OR kd_bukti LIKE '%" & tbCariTrx.Text & "%' OR sales LIKE '%" & tbCariTrx.Text & "%'"
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Function cek_keranjang_hutang(ByVal kd_pembelian As String)
        For Each row As DataGridViewRow In FormPembayaranHutang.dgvTrx.Rows
            If row.Cells(0).Value = kd_pembelian Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGridSupplier()
    End Sub
End Class