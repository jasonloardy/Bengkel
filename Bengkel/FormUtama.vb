Public Class FormUtama
    Public user, level As String
    Sub closeAll()
        For Each aform As Form In Me.MdiChildren
            aform.Close()
            aform.Dispose()
        Next
    End Sub
    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        closeAll()
        FormUser.MdiParent = Me
        FormUser.Dock = DockStyle.Fill
        FormUser.Show()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        closeAll()
        FormBarang.from = "utama"
        FormBarang.MdiParent = Me
        FormBarang.Dock = DockStyle.Fill
        FormBarang.Show()
    End Sub

    Private Sub FormUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Tutup Aplikasi ?", 48 + 4 + 256, "Konfirmasi") = 6 Then
            FormLogin.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim pilih As Integer
        pilih = MsgBox("Yakin ingin logout ?", 48 + 4 + 256, "Konfirmasi")
        If pilih = 6 Then
            closeAll()
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSupplierToolStripMenuItem.Click
        closeAll()
        FormSupplier.from = "utama"
        FormSupplier.MdiParent = Me
        FormSupplier.Dock = DockStyle.Fill
        FormSupplier.Show()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        closeAll()
        FormPelanggan.from = "utama"
        FormPelanggan.MdiParent = Me
        FormPelanggan.Dock = DockStyle.Fill
        FormPelanggan.Show()
    End Sub

    Private Sub DataSatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSatuanToolStripMenuItem.Click
        closeAll()
        FormSatuan.MdiParent = Me
        FormSatuan.Dock = DockStyle.Fill
        FormSatuan.Show()
    End Sub

    Private Sub TransaksiPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPembelianToolStripMenuItem.Click
        closeAll()
        FormPembelian.MdiParent = Me
        FormPembelian.Dock = DockStyle.Fill
        FormPembelian.Show()
    End Sub

    Private Sub DaftarHutangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarHutangToolStripMenuItem.Click
        closeAll()
        FormDaftarHutang.from = "utama"
        FormDaftarHutang.MdiParent = Me
        FormDaftarHutang.Dock = DockStyle.Fill
        FormDaftarHutang.Show()
    End Sub

    Private Sub PembayaranHutangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranHutangToolStripMenuItem.Click
        closeAll()
        FormPembayaranHutang.MdiParent = Me
        FormPembayaranHutang.Dock = DockStyle.Fill
        FormPembayaranHutang.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        closeAll()
        FormDaftarPembelian.MdiParent = Me
        FormDaftarPembelian.Dock = DockStyle.Fill
        FormDaftarPembelian.Show()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub PembayaranHutangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembayaranHutangToolStripMenuItem1.Click
        closeAll()
        FormDaftarPembayaranHutang.MdiParent = Me
        FormDaftarPembayaranHutang.Dock = DockStyle.Fill
        FormDaftarPembayaranHutang.Show()
    End Sub

    Private Sub TransaksiPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPenjualanToolStripMenuItem.Click
        closeAll()
        FormPenjualan.MdiParent = Me
        FormPenjualan.Dock = DockStyle.Fill
        FormPenjualan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        closeAll()
        FormDaftarpenjualan.from = "nota"
        FormDaftarpenjualan.MdiParent = Me
        FormDaftarpenjualan.Dock = DockStyle.Fill
        FormDaftarpenjualan.Show()
    End Sub

    Private Sub PenjualanBONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanBONToolStripMenuItem.Click
        closeAll()
        FormDaftarpenjualan.from = "bon"
        FormDaftarpenjualan.MdiParent = Me
        FormDaftarpenjualan.Dock = DockStyle.Fill
        FormDaftarpenjualan.Show()
    End Sub

    Private Sub DaftarPiutangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarPiutangToolStripMenuItem.Click
        closeAll()
        FormDaftarpiutang.from = "utama"
        FormDaftarpiutang.MdiParent = Me
        FormDaftarpiutang.Dock = DockStyle.Fill
        FormDaftarpiutang.Show()
    End Sub

    Private Sub PembayaranPiutangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranPiutangToolStripMenuItem.Click
        closeAll()
        FormPembayaranpiutang.MdiParent = Me
        FormPembayaranpiutang.Dock = DockStyle.Fill
        FormPembayaranpiutang.Show()
    End Sub

    Private Sub PembayaranPiutangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembayaranPiutangToolStripMenuItem1.Click
        closeAll()
        FormDaftarPembayaranPiutang.MdiParent = Me
        FormDaftarPembayaranPiutang.Dock = DockStyle.Fill
        FormDaftarPembayaranPiutang.Show()
    End Sub
End Class