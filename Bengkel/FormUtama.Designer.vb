<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSatuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarHutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranHutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranHutangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.DaftarTransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataPelangganToolStripMenuItem, Me.DataSupplierToolStripMenuItem, Me.DataUserToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSatuanToolStripMenuItem})
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataSatuanToolStripMenuItem
        '
        Me.DataSatuanToolStripMenuItem.Name = "DataSatuanToolStripMenuItem"
        Me.DataSatuanToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DataSatuanToolStripMenuItem.Text = "Data Satuan"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarHutangToolStripMenuItem, Me.PembayaranHutangToolStripMenuItem, Me.TransaksiPembelianToolStripMenuItem})
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'DaftarHutangToolStripMenuItem
        '
        Me.DaftarHutangToolStripMenuItem.Name = "DaftarHutangToolStripMenuItem"
        Me.DaftarHutangToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DaftarHutangToolStripMenuItem.Text = "Daftar Hutang"
        '
        'PembayaranHutangToolStripMenuItem
        '
        Me.PembayaranHutangToolStripMenuItem.Name = "PembayaranHutangToolStripMenuItem"
        Me.PembayaranHutangToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PembayaranHutangToolStripMenuItem.Text = "Pembayaran Hutang"
        '
        'TransaksiPembelianToolStripMenuItem
        '
        Me.TransaksiPembelianToolStripMenuItem.Name = "TransaksiPembelianToolStripMenuItem"
        Me.TransaksiPembelianToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TransaksiPembelianToolStripMenuItem.Text = "Transaksi Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'DaftarTransaksiToolStripMenuItem
        '
        Me.DaftarTransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem1, Me.PembayaranHutangToolStripMenuItem1})
        Me.DaftarTransaksiToolStripMenuItem.Name = "DaftarTransaksiToolStripMenuItem"
        Me.DaftarTransaksiToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.DaftarTransaksiToolStripMenuItem.Text = "Daftar Transaksi"
        '
        'PembelianToolStripMenuItem1
        '
        Me.PembelianToolStripMenuItem1.Name = "PembelianToolStripMenuItem1"
        Me.PembelianToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.PembelianToolStripMenuItem1.Text = "Pembelian"
        '
        'PembayaranHutangToolStripMenuItem1
        '
        Me.PembayaranHutangToolStripMenuItem1.Name = "PembayaranHutangToolStripMenuItem1"
        Me.PembayaranHutangToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.PembayaranHutangToolStripMenuItem1.Text = "Pembayaran Hutang"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "FormUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSatuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarHutangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranHutangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PembayaranHutangToolStripMenuItem1 As ToolStripMenuItem
End Class
