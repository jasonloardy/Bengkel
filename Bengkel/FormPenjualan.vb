Imports MySql.Data.MySqlClient

Public Class FormPenjualan
    Public kodeBarang As String

    Function kode_penjualan()
        Try
            Dim kode As String = "000"
            Dim hitung As String = "1"
            Dim user As String = FormUtama.user
            Dim tanggal As String = Date.Now.ToString("MMyy")
            Dim sql As String = "SELECT kd_penjualan FROM tb_penjualan
                                 WHERE RIGHT(kd_penjualan, 4) = '" & tanggal & "'
                                 ORDER BY kd_penjualan DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            hitung = Val(Microsoft.VisualBasic.Left(dr.Item("kd_penjualan").ToString, 4)) + 1
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
            Return kode & hitung & "/PJ/" & user & "/" & tanggal
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return ""
        End Try
    End Function

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        reset()
    End Sub

    Sub clearInput()
        'hitungTotal()
        kodeBarang = ""
        tbKodeBarang.Clear()
        tbNamaBarang.Clear()
        tbSatuan.Clear()
        tbQty.Clear()
        tbHargaJual.Clear()
        tbDiskonBarang.Clear()
        tbTotal.Clear()
    End Sub
    Sub reset()
        dtpTanggal.Value = Date.Now
        tbKodePembelian.Text = kode_penjualan()
        tbKodePlg.Clear()
        tbNamaPlg.Clear()
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
        tbBayar.Text = FormatCurrency(0)
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FormPelanggan.from = "penjualan"
        FormPelanggan.ShowDialog()
    End Sub

    Private Sub tbKodePlg_TextChanged(sender As Object, e As EventArgs) Handles tbKodePlg.TextChanged
        If tbKodePlg.Text <> "" Then
            gbBarang.Enabled = True
        Else
            gbBarang.Enabled = False
        End If
    End Sub

    Private Sub tbKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            If tbKatPlg.Text = "U" Then
                FormBarang.from = "penjualan-umum"
            ElseIf tbKatPlg.Text = "L" Then
                FormBarang.from = "penjualan-langganan"
            ElseIf tbKatPlg.Text = "P" Then
                FormBarang.from = "penjualan-partai"
            End If
            FormBarang.tbCari.Text = tbKodeBarang.Text
            FormBarang.ShowDialog()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        reset()
    End Sub
End Class