Imports MySql.Data.MySqlClient

Public Class FormPembelian
    Public kodeBarang As String
    Function kode_pembelian()
        Try
            Dim kode As String = "000"
            Dim hitung As String = "1"
            Dim user As String = FormUtama.user
            Dim tanggal As String = Date.Now.ToString("MMyy")
            Dim sql As String = "SELECT kd_pembelian FROM tb_pembelian ORDER BY kd_pembelian DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Left(dr.Item("kd_pembelian").ToString, 4)) + 1
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
            Return kode & hitung & "/PB/" & user & "/" & tanggal
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return ""
        End Try
    End Function

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If koneksi() Then
            reset()
        End If
    End Sub

    Sub hitungTotal()
        Try
            Dim total As Integer
            Dim jumlahItem As Integer
            For i = 0 To dgvKeranjang.RowCount - 1
                total += dgvKeranjang.Rows(i).Cells(7).Value
                jumlahItem += dgvKeranjang.Rows(i).Cells(3).Value
            Next
            tbJumlahItem.Text = jumlahItem
            tbSubtotal.Text = FormatCurrency(total)
            tbPotongan.Text = FormatCurrency((Val(tbDiskonAll.Text) / 100) * total)
            lblTotal.Text = FormatCurrency(total - tbPotongan.Text)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub
    Sub clearInput()
        hitungTotal()
        kodeBarang = ""
        tbKodeBarang.Clear()
        tbNamaBarang.Clear()
        tbSatuan.Clear()
        tbQty.Clear()
        tbHargaBeli.Clear()
        tbDiskonBarang.Clear()
        tbTotal.Clear()
    End Sub
    Sub reset()
        dtpTanggal.Value = Date.Now
        tbKodePembelian.Text = kode_pembelian()
        tbKodeBukti.Clear()
        tbKodeSupplier.Clear()
        tbNamaSupplier.Clear()
        tbAlamat.Clear()
        tbNoTelepon.Clear()
        lblTotal.Text = FormatCurrency(0)
        gbBarang.Enabled = False
        clearInput()
        'dgvKeranjang.Columns(6).Visible = False
        dgvKeranjang.Columns(4).DefaultCellStyle.Format = "c0"
        dgvKeranjang.Columns(5).DefaultCellStyle.Format = "n2"
        dgvKeranjang.Columns(7).DefaultCellStyle.Format = "c0"
        dgvKeranjang.Rows.Clear()
        tbJumlahItem.Text = 0
        tbSubtotal.Text = FormatCurrency(0)
        tbDiskonAll.Text = 0
        tbPotongan.Text = FormatCurrency(0)
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FormSupplier.from = "pembelian"
        FormSupplier.ShowDialog()
    End Sub

    Private Sub tbKodeSupplier_TextChanged(sender As Object, e As EventArgs) Handles tbKodeSupplier.TextChanged
        If tbKodeSupplier.Text <> "" Then
            gbBarang.Enabled = True
        End If
    End Sub

    Private Sub tbKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            FormBarang.from = "pembelian"
            FormBarang.Show()
            FormBarang.tbCari.Text = tbKodeBarang.Text
        End If
    End Sub

    Private Sub tbQty_TextChanged(sender As Object, e As EventArgs) Handles tbQty.TextChanged
        Try
            tbTotal.Text = FormatCurrency(tbQty.Text * tbHargaBeli.Text * ((100 - Val(tbDiskonBarang.Text)) / 100))
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbHargaBeli_TextChanged(sender As Object, e As EventArgs) Handles tbHargaBeli.TextChanged
        Try
            tbTotal.Text = FormatCurrency(tbQty.Text * tbHargaBeli.Text * ((100 - Val(tbDiskonBarang.Text)) / 100))
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbDiskonBarang_TextChanged(sender As Object, e As EventArgs) Handles tbDiskonBarang.TextChanged
        Try
            tbTotal.Text = FormatCurrency(tbQty.Text * tbHargaBeli.Text * ((100 - Val(tbDiskonBarang.Text)) / 100))
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Try
            If kodeBarang = "" Then
                MsgBox("Masukkan Barang Terlebih Dahulu!", 16, "Perhatian")
            Else
                If tbQty.Text = "" Or tbHargaBeli.Text = "" Then
                    MsgBox("Kolom Qty / Harga Beli Masih Kosong!", 16, "Perhatian")
                Else
                    With dgvKeranjang
                        Dim baris As Integer = .Rows.Add()
                        .Rows.Item(baris).Cells(0).Value = kodeBarang
                        .Rows.Item(baris).Cells(1).Value = tbNamaBarang.Text
                        .Rows.Item(baris).Cells(2).Value = tbSatuan.Text
                        .Rows.Item(baris).Cells(3).Value = tbQty.Text
                        .Rows.Item(baris).Cells(4).Value = Val(tbHargaBeli.Text)
                        .Rows.Item(baris).Cells(5).Value = Val(tbDiskonBarang.Text)
                        .Rows.Item(baris).Cells(6).Value = tbIsi.Text * tbQty.Text
                        .Rows.Item(baris).Cells(7).Value = tbQty.Text * tbHargaBeli.Text * ((100 - Val(tbDiskonBarang.Text)) / 100)
                    End With
                    clearInput()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            Dim pilih As Integer
            Dim namaBarang As String = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(1).Value
            pilih = MsgBox("Hapus Item " & namaBarang & " dari Keranjang?", 48 + 4 + 256, "Konfirmasi")
            If pilih = 6 Then
                dgvKeranjang.Rows.Remove(dgvKeranjang.CurrentRow)
                hitungTotal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbDiskonAll_TextChanged(sender As Object, e As EventArgs) Handles tbDiskonAll.TextChanged
        Try
            hitungTotal()
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub
End Class