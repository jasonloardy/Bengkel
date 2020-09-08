Public Class FormUtama
    Public user As String
    Sub closeAll()
        For Each aform As Form In Me.MdiChildren
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
        FormSupplier.MdiParent = Me
        FormSupplier.Dock = DockStyle.Fill
        FormSupplier.Show()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        closeAll()
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
End Class