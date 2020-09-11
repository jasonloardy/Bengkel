Imports MySql.Data.MySqlClient

Public Class FormPembayaranHutang
    Private Sub FormPembayaranHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        reset()
    End Sub

    Function kode_hutang()
        Try
            Dim kode As String = "000"
            Dim hitung As String = "1"
            Dim user As String = FormUtama.user
            Dim tanggal As String = Date.Now.ToString("MMyy")
            Dim sql As String = "SELECT kd_pembayaran_hutang FROM tb_pembayaran_hutang
                                 WHERE RIGHT(kd_pembayaran_hutang, 4) = '" & tanggal & "'
                                 ORDER BY kd_pembayaran_hutang DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Left(dr.Item("kd_pembayaran_hutang").ToString, 4)) + 1
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
            Return kode & hitung & "/PH/" & user & "/" & tanggal
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return ""
        End Try
    End Function

    Sub hitungTotal()
        Try
            Dim totalBayar As Integer
            Dim totalKredit As Integer
            For i = 0 To dgvTrx.RowCount - 1
                totalBayar += dgvTrx.Rows(i).Cells(6).Value
                totalKredit += dgvTrx.Rows(i).Cells(7).Value
            Next
            lblTotal.Text = FormatCurrency(totalBayar)
            tbTotalKredit.Text = FormatCurrency(totalKredit)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub reset()
        dtpTanggal.Value = Date.Now
        tbKodeHutang.Text = kode_hutang()
        tbKodeSupplier.Clear()
        tbNamaSupplier.Clear()
        tbAlamat.Clear()
        tbNoTelepon.Clear()
        lblTotal.Text = FormatCurrency(0)
        dgvTrx.Rows.Clear()
        tbTotalKredit.Text = FormatCurrency(0)
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FormDaftarHutang.from = "hutang-supplier"
        FormDaftarHutang.ShowDialog()
    End Sub

    Private Sub btnHutang_Click(sender As Object, e As EventArgs)
        FormDaftarHutang.from = "hutang-trx"
        FormDaftarHutang.tbCariSupplier.Text = tbKodeSupplier.Text
        FormDaftarHutang.tbCariSupplier.ReadOnly = True
        FormDaftarHutang.ShowDialog()
    End Sub

    Sub isiGridTrx(ByVal kd_supplier As String)
        Try
            Dim sql As String = "SELECT tb.kd_pembelian, kd_bukti, sales, tanggal_jt,
                                    SUM(tbd.qty*tbd.harga_beli*(100-tbd.diskon)/100)*(100-tb.diskon)/100 nominal,
                                    sisa, '0', sisa
                                    FROM tb_pembelian tb
                                    JOIN tb_pembelian_detail tbd ON tb.kd_pembelian = tbd.kd_pembelian
                                    WHERE kd_supplier = '" & kd_supplier & "' AND sisa > 0 AND status = '1'
                                    GROUP BY tb.kd_pembelian"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvTrx.DataSource = ds.Tables(0)
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
            .Columns(6).HeaderText = "Bayar"
            .Columns(7).HeaderText = "Kredit"
            .Columns(0).Width = 150
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 100
            .Columns(4).DefaultCellStyle.Format = "c0"
            .Columns(5).DefaultCellStyle.Format = "c0"
            .Columns(7).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Private Sub tbKodeSupplier_TextChanged(sender As Object, e As EventArgs) Handles tbKodeSupplier.TextChanged
        isiGridTrx(tbKodeSupplier.Text)
        hitungTotal()
    End Sub

    Private Sub dgvTrx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrx.CellDoubleClick
        Try
            If e.ColumnIndex = 6 And e.RowIndex > -1 Then
                With FormInputBox
                    .dgv = dgvTrx
                    .columnSisa = 5
                    .columnKredit = 7
                    .columnValue = e.ColumnIndex
                    .row = e.RowIndex
                    .Text = "Nominal Bayar"
                    .lblMessage.Text = "Masukkan Nominal Bayar"
                    .tbValue.Text = CDec(dgvTrx.Item(e.ColumnIndex, e.RowIndex).Value)
                    .ShowDialog()
                    hitungTotal()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub querySimpan()
        Try
            Dim kode As String = kode_hutang()
            trans = conn.BeginTransaction
            Dim sql As String = "INSERT INTO tb_pembayaran_hutang VALUES (@kd_pembayaran_hutang, NOW(), '1');"
            If queryPembayaranHutang(sql, kode) Then
                For i As Integer = 0 To dgvTrx.RowCount - 1
                    Dim sqlDetail As String = "INSERT INTO tb_pembayaran_hutang_detail VALUES (@kd_pembayaran_hutang, @kd_pembelian, @bayar);"
                    If CDec(dgvTrx.Rows(i).Cells(6).Value) > 0 Then
                        If Not queryPembayaranHutangDetail(sqlDetail, kode, dgvTrx.Rows(i).Cells(0).Value, CDec(dgvTrx.Rows(i).Cells(6).Value)) Then
                            trans.Rollback()
                            Exit Sub
                        End If
                    End If
                Next
                trans.Commit()
                MsgBox("Transaksi berhasil di-simpan!", MsgBoxStyle.Information, "Informasi")
                reset()
            Else
                trans.Rollback()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim pilih As Integer
        pilih = MsgBox("Simpan Transaksi Pembayaran ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            If CDec(lblTotal.Text) > 0 Then
                querySimpan()
            Else
                MsgBox("Belum Ada Transaksi Yang Dibayar!", 16, "Error")
            End If
        End If
    End Sub
End Class