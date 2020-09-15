<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbBarang = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbDiskonBarang = New System.Windows.Forms.TextBox()
        Me.tbIsi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbSatuan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHargaJual = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbBayar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbDiskonAll = New System.Windows.Forms.TextBox()
        Me.tbJumlahItem = New System.Windows.Forms.TextBox()
        Me.tbPotongan = New System.Windows.Forms.TextBox()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        Me.tbKembalian = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbKodePembelian = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbKatPlg = New System.Windows.Forms.TextBox()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbKodePlg = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNamaPlg = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbHargaBeli = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.btnPending = New System.Windows.Forms.Button()
        Me.tbKodePending = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbBarang.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(910, 503)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Kembalian / Kredit :"
        '
        'gbBarang
        '
        Me.gbBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBarang.Controls.Add(Me.Label14)
        Me.gbBarang.Controls.Add(Me.tbDiskonBarang)
        Me.gbBarang.Controls.Add(Me.tbIsi)
        Me.gbBarang.Controls.Add(Me.Label6)
        Me.gbBarang.Controls.Add(Me.tbNamaBarang)
        Me.gbBarang.Controls.Add(Me.Label5)
        Me.gbBarang.Controls.Add(Me.tbKodeBarang)
        Me.gbBarang.Controls.Add(Me.Label4)
        Me.gbBarang.Controls.Add(Me.Label3)
        Me.gbBarang.Controls.Add(Me.tbSatuan)
        Me.gbBarang.Controls.Add(Me.Label2)
        Me.gbBarang.Controls.Add(Me.tbQty)
        Me.gbBarang.Controls.Add(Me.Label1)
        Me.gbBarang.Controls.Add(Me.tbHargaJual)
        Me.gbBarang.Controls.Add(Me.btnInput)
        Me.gbBarang.Controls.Add(Me.tbTotal)
        Me.gbBarang.Location = New System.Drawing.Point(12, 151)
        Me.gbBarang.Name = "gbBarang"
        Me.gbBarang.Size = New System.Drawing.Size(1160, 62)
        Me.gbBarang.TabIndex = 41
        Me.gbBarang.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(736, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Diskon (%)"
        '
        'tbDiskonBarang
        '
        Me.tbDiskonBarang.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDiskonBarang.Location = New System.Drawing.Point(739, 32)
        Me.tbDiskonBarang.Name = "tbDiskonBarang"
        Me.tbDiskonBarang.Size = New System.Drawing.Size(75, 20)
        Me.tbDiskonBarang.TabIndex = 37
        '
        'tbIsi
        '
        Me.tbIsi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbIsi.Location = New System.Drawing.Point(923, 32)
        Me.tbIsi.Name = "tbIsi"
        Me.tbIsi.Size = New System.Drawing.Size(75, 20)
        Me.tbIsi.TabIndex = 36
        Me.tbIsi.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1001, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Total"
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNamaBarang.Location = New System.Drawing.Point(140, 32)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.ReadOnly = True
        Me.tbNamaBarang.Size = New System.Drawing.Size(300, 20)
        Me.tbNamaBarang.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(605, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Harga Jual"
        '
        'tbKodeBarang
        '
        Me.tbKodeBarang.Location = New System.Drawing.Point(9, 32)
        Me.tbKodeBarang.Name = "tbKodeBarang"
        Me.tbKodeBarang.Size = New System.Drawing.Size(125, 20)
        Me.tbKodeBarang.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(524, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Qty"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Satuan"
        '
        'tbSatuan
        '
        Me.tbSatuan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSatuan.Location = New System.Drawing.Point(446, 32)
        Me.tbSatuan.Name = "tbSatuan"
        Me.tbSatuan.ReadOnly = True
        Me.tbSatuan.Size = New System.Drawing.Size(75, 20)
        Me.tbSatuan.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nama Barang"
        '
        'tbQty
        '
        Me.tbQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbQty.Location = New System.Drawing.Point(527, 32)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(75, 20)
        Me.tbQty.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Kode Barang"
        '
        'tbHargaJual
        '
        Me.tbHargaJual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHargaJual.Location = New System.Drawing.Point(608, 32)
        Me.tbHargaJual.Name = "tbHargaJual"
        Me.tbHargaJual.Size = New System.Drawing.Size(125, 20)
        Me.tbHargaJual.TabIndex = 27
        '
        'btnInput
        '
        Me.btnInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInput.Location = New System.Drawing.Point(820, 30)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 29
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotal.Location = New System.Drawing.Point(1004, 32)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(150, 20)
        Me.tbTotal.TabIndex = 28
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(1097, 526)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 40
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.Location = New System.Drawing.Point(1016, 526)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 39
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(970, 477)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Bayar :"
        '
        'tbBayar
        '
        Me.tbBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBayar.Location = New System.Drawing.Point(1016, 474)
        Me.tbBayar.Name = "tbBayar"
        Me.tbBayar.Size = New System.Drawing.Size(156, 20)
        Me.tbBayar.TabIndex = 48
        Me.tbBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(891, 451)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Diskon (%) :"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(895, 425)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Sub Total :"
        '
        'tbDiskonAll
        '
        Me.tbDiskonAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDiskonAll.Location = New System.Drawing.Point(960, 448)
        Me.tbDiskonAll.Name = "tbDiskonAll"
        Me.tbDiskonAll.Size = New System.Drawing.Size(50, 20)
        Me.tbDiskonAll.TabIndex = 45
        '
        'tbJumlahItem
        '
        Me.tbJumlahItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbJumlahItem.Location = New System.Drawing.Point(960, 422)
        Me.tbJumlahItem.Name = "tbJumlahItem"
        Me.tbJumlahItem.ReadOnly = True
        Me.tbJumlahItem.Size = New System.Drawing.Size(50, 20)
        Me.tbJumlahItem.TabIndex = 44
        '
        'tbPotongan
        '
        Me.tbPotongan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPotongan.Location = New System.Drawing.Point(1016, 448)
        Me.tbPotongan.Name = "tbPotongan"
        Me.tbPotongan.ReadOnly = True
        Me.tbPotongan.Size = New System.Drawing.Size(156, 20)
        Me.tbPotongan.TabIndex = 43
        Me.tbPotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSubtotal.Location = New System.Drawing.Point(1016, 422)
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.ReadOnly = True
        Me.tbSubtotal.Size = New System.Drawing.Size(156, 20)
        Me.tbSubtotal.TabIndex = 42
        Me.tbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbKembalian
        '
        Me.tbKembalian.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKembalian.Location = New System.Drawing.Point(1016, 500)
        Me.tbKembalian.Name = "tbKembalian"
        Me.tbKembalian.ReadOnly = True
        Me.tbKembalian.Size = New System.Drawing.Size(156, 20)
        Me.tbKembalian.TabIndex = 50
        Me.tbKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.Location = New System.Drawing.Point(12, 425)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 38
        Me.btnHapus.Text = "Hapus Item"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbKodePembelian)
        Me.GroupBox1.Controls.Add(Me.dtpTanggal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 133)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Penjualan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Kode Penjualan :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Tanggal :"
        '
        'tbKodePembelian
        '
        Me.tbKodePembelian.Location = New System.Drawing.Point(102, 49)
        Me.tbKodePembelian.Name = "tbKodePembelian"
        Me.tbKodePembelian.ReadOnly = True
        Me.tbKodePembelian.Size = New System.Drawing.Size(200, 20)
        Me.tbKodePembelian.TabIndex = 1
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Enabled = False
        Me.dtpTanggal.Location = New System.Drawing.Point(102, 23)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbKatPlg)
        Me.GroupBox2.Controls.Add(Me.btnSupplier)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tbNoTelepon)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbAlamat)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbKodePlg)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbNamaPlg)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 133)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pelanggan"
        '
        'tbKatPlg
        '
        Me.tbKatPlg.Location = New System.Drawing.Point(245, 23)
        Me.tbKatPlg.Name = "tbKatPlg"
        Me.tbKatPlg.ReadOnly = True
        Me.tbKatPlg.Size = New System.Drawing.Size(51, 20)
        Me.tbKatPlg.TabIndex = 37
        '
        'btnSupplier
        '
        Me.btnSupplier.Location = New System.Drawing.Point(202, 21)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(37, 23)
        Me.btnSupplier.TabIndex = 36
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "No. Telepon :"
        '
        'tbNoTelepon
        '
        Me.tbNoTelepon.Location = New System.Drawing.Point(96, 101)
        Me.tbNoTelepon.Name = "tbNoTelepon"
        Me.tbNoTelepon.ReadOnly = True
        Me.tbNoTelepon.Size = New System.Drawing.Size(200, 20)
        Me.tbNoTelepon.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Alamat :"
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(96, 75)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.ReadOnly = True
        Me.tbAlamat.Size = New System.Drawing.Size(200, 20)
        Me.tbAlamat.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nama Plg :"
        '
        'tbKodePlg
        '
        Me.tbKodePlg.Location = New System.Drawing.Point(96, 23)
        Me.tbKodePlg.Name = "tbKodePlg"
        Me.tbKodePlg.ReadOnly = True
        Me.tbKodePlg.Size = New System.Drawing.Size(100, 20)
        Me.tbKodePlg.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Kode Plg :"
        '
        'tbNamaPlg
        '
        Me.tbNamaPlg.Location = New System.Drawing.Point(96, 49)
        Me.tbNamaPlg.Name = "tbNamaPlg"
        Me.tbNamaPlg.ReadOnly = True
        Me.tbNamaPlg.Size = New System.Drawing.Size(200, 20)
        Me.tbNamaPlg.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.tbHargaBeli)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(647, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 133)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Penjualan"
        '
        'tbHargaBeli
        '
        Me.tbHargaBeli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHargaBeli.Location = New System.Drawing.Point(6, 107)
        Me.tbHargaBeli.Name = "tbHargaBeli"
        Me.tbHargaBeli.Size = New System.Drawing.Size(125, 20)
        Me.tbHargaBeli.TabIndex = 39
        Me.tbHargaBeli.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(6, 21)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(513, 96)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Rp999.999.999"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.AllowUserToAddRows = False
        Me.dgvKeranjang.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvKeranjang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKeranjang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvKeranjang.Location = New System.Drawing.Point(12, 219)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.ReadOnly = True
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(1160, 197)
        Me.dgvKeranjang.TabIndex = 37
        '
        'btnPending
        '
        Me.btnPending.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPending.Location = New System.Drawing.Point(12, 526)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Size = New System.Drawing.Size(75, 23)
        Me.btnPending.TabIndex = 52
        Me.btnPending.Text = "Pending"
        Me.btnPending.UseVisualStyleBackColor = True
        '
        'tbKodePending
        '
        Me.tbKodePending.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbKodePending.Location = New System.Drawing.Point(12, 500)
        Me.tbKodePending.Name = "tbKodePending"
        Me.tbKodePending.ReadOnly = True
        Me.tbKodePending.Size = New System.Drawing.Size(100, 20)
        Me.tbKodePending.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(93, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "List Pending"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBaru
        '
        Me.btnBaru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBaru.Location = New System.Drawing.Point(935, 526)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnBaru.TabIndex = 55
        Me.btnBaru.Text = "Baru"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Satuan"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga Jual"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Diskon (%)"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Unit"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "Total"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Harga Beli"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbKodePending)
        Me.Controls.Add(Me.btnPending)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.gbBarang)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbBayar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbDiskonAll)
        Me.Controls.Add(Me.tbJumlahItem)
        Me.Controls.Add(Me.tbPotongan)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.tbKembalian)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvKeranjang)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        Me.gbBarang.ResumeLayout(False)
        Me.gbBarang.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label20 As Label
    Friend WithEvents gbBarang As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbDiskonBarang As TextBox
    Friend WithEvents tbIsi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNamaBarang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbKodeBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSatuan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbHargaJual As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents tbBayar As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tbDiskonAll As TextBox
    Friend WithEvents tbJumlahItem As TextBox
    Friend WithEvents tbPotongan As TextBox
    Friend WithEvents tbSubtotal As TextBox
    Friend WithEvents tbKembalian As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbKodePembelian As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSupplier As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tbNoTelepon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbKodePlg As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbNamaPlg As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents btnPending As Button
    Friend WithEvents tbKatPlg As TextBox
    Friend WithEvents tbKodePending As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents tbHargaBeli As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
