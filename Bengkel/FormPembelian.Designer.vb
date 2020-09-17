<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbKodeBukti = New System.Windows.Forms.TextBox()
        Me.tbSales = New System.Windows.Forms.TextBox()
        Me.tbKodePembelian = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbKodeSupplier = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNamaSupplier = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
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
        Me.tbHargaBeli = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        Me.tbPotongan = New System.Windows.Forms.TextBox()
        Me.tbJumlahItem = New System.Windows.Forms.TextBox()
        Me.tbDiskonAll = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblJatuhTempo = New System.Windows.Forms.Label()
        Me.dtpJatuhTempo = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbTunai = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbKredit = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBarang.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbKodeBukti)
        Me.GroupBox1.Controls.Add(Me.tbSales)
        Me.GroupBox1.Controls.Add(Me.tbKodePembelian)
        Me.GroupBox1.Controls.Add(Me.dtpTanggal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembelian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Kode Bukti :"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(57, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Sales :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Kode Pembelian :"
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
        'tbKodeBukti
        '
        Me.tbKodeBukti.Location = New System.Drawing.Point(102, 75)
        Me.tbKodeBukti.MaxLength = 32
        Me.tbKodeBukti.Name = "tbKodeBukti"
        Me.tbKodeBukti.Size = New System.Drawing.Size(200, 20)
        Me.tbKodeBukti.TabIndex = 2
        '
        'tbSales
        '
        Me.tbSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSales.Location = New System.Drawing.Point(102, 101)
        Me.tbSales.MaxLength = 32
        Me.tbSales.Name = "tbSales"
        Me.tbSales.Size = New System.Drawing.Size(200, 20)
        Me.tbSales.TabIndex = 3
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
        Me.GroupBox2.Controls.Add(Me.btnSupplier)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tbNoTelepon)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbAlamat)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbKodeSupplier)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbNamaSupplier)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 133)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier"
        '
        'btnSupplier
        '
        Me.btnSupplier.Location = New System.Drawing.Point(202, 21)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(37, 23)
        Me.btnSupplier.TabIndex = 1
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
        Me.tbNoTelepon.TabIndex = 4
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
        Me.tbAlamat.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nama Supplier :"
        '
        'tbKodeSupplier
        '
        Me.tbKodeSupplier.Location = New System.Drawing.Point(96, 23)
        Me.tbKodeSupplier.Name = "tbKodeSupplier"
        Me.tbKodeSupplier.ReadOnly = True
        Me.tbKodeSupplier.Size = New System.Drawing.Size(100, 20)
        Me.tbKodeSupplier.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Kode Supplier :"
        '
        'tbNamaSupplier
        '
        Me.tbNamaSupplier.Location = New System.Drawing.Point(96, 49)
        Me.tbNamaSupplier.Name = "tbNamaSupplier"
        Me.tbNamaSupplier.ReadOnly = True
        Me.tbNamaSupplier.Size = New System.Drawing.Size(200, 20)
        Me.tbNamaSupplier.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(647, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 133)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Pembelian"
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvKeranjang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKeranjang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvKeranjang.Location = New System.Drawing.Point(12, 219)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.ReadOnly = True
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(1160, 197)
        Me.dgvKeranjang.TabIndex = 3
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
        Me.Column5.HeaderText = "Harga Beli"
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
        '
        'Column8
        '
        Me.Column8.HeaderText = "Total"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.Location = New System.Drawing.Point(12, 425)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus Item"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.Location = New System.Drawing.Point(1016, 526)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(1097, 526)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
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
        Me.gbBarang.Controls.Add(Me.tbHargaBeli)
        Me.gbBarang.Controls.Add(Me.btnInput)
        Me.gbBarang.Controls.Add(Me.tbTotal)
        Me.gbBarang.Location = New System.Drawing.Point(12, 151)
        Me.gbBarang.Name = "gbBarang"
        Me.gbBarang.Size = New System.Drawing.Size(1160, 62)
        Me.gbBarang.TabIndex = 2
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
        Me.tbDiskonBarang.MaxLength = 6
        Me.tbDiskonBarang.Name = "tbDiskonBarang"
        Me.tbDiskonBarang.Size = New System.Drawing.Size(75, 20)
        Me.tbDiskonBarang.TabIndex = 5
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
        Me.tbNamaBarang.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(605, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Harga Beli"
        '
        'tbKodeBarang
        '
        Me.tbKodeBarang.Location = New System.Drawing.Point(9, 32)
        Me.tbKodeBarang.MaxLength = 16
        Me.tbKodeBarang.Name = "tbKodeBarang"
        Me.tbKodeBarang.Size = New System.Drawing.Size(125, 20)
        Me.tbKodeBarang.TabIndex = 0
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
        Me.tbSatuan.TabIndex = 2
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
        Me.tbQty.MaxLength = 7
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(75, 20)
        Me.tbQty.TabIndex = 3
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
        'tbHargaBeli
        '
        Me.tbHargaBeli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHargaBeli.Location = New System.Drawing.Point(608, 32)
        Me.tbHargaBeli.MaxLength = 11
        Me.tbHargaBeli.Name = "tbHargaBeli"
        Me.tbHargaBeli.Size = New System.Drawing.Size(125, 20)
        Me.tbHargaBeli.TabIndex = 4
        '
        'btnInput
        '
        Me.btnInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInput.Location = New System.Drawing.Point(820, 30)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 6
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
        Me.tbTotal.TabIndex = 7
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSubtotal.Location = New System.Drawing.Point(1016, 422)
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.ReadOnly = True
        Me.tbSubtotal.Size = New System.Drawing.Size(156, 20)
        Me.tbSubtotal.TabIndex = 6
        Me.tbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPotongan
        '
        Me.tbPotongan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPotongan.Location = New System.Drawing.Point(1016, 448)
        Me.tbPotongan.Name = "tbPotongan"
        Me.tbPotongan.ReadOnly = True
        Me.tbPotongan.Size = New System.Drawing.Size(156, 20)
        Me.tbPotongan.TabIndex = 8
        Me.tbPotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbJumlahItem
        '
        Me.tbJumlahItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbJumlahItem.Location = New System.Drawing.Point(960, 422)
        Me.tbJumlahItem.Name = "tbJumlahItem"
        Me.tbJumlahItem.ReadOnly = True
        Me.tbJumlahItem.Size = New System.Drawing.Size(50, 20)
        Me.tbJumlahItem.TabIndex = 5
        '
        'tbDiskonAll
        '
        Me.tbDiskonAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDiskonAll.Location = New System.Drawing.Point(960, 448)
        Me.tbDiskonAll.MaxLength = 6
        Me.tbDiskonAll.Name = "tbDiskonAll"
        Me.tbDiskonAll.Size = New System.Drawing.Size(50, 20)
        Me.tbDiskonAll.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(895, 425)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Sub Total :"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(891, 451)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Diskon (%) :"
        '
        'lblJatuhTempo
        '
        Me.lblJatuhTempo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJatuhTempo.AutoSize = True
        Me.lblJatuhTempo.Location = New System.Drawing.Point(626, 503)
        Me.lblJatuhTempo.Name = "lblJatuhTempo"
        Me.lblJatuhTempo.Size = New System.Drawing.Size(75, 13)
        Me.lblJatuhTempo.TabIndex = 7
        Me.lblJatuhTempo.Text = "Jatuh Tempo :"
        '
        'dtpJatuhTempo
        '
        Me.dtpJatuhTempo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpJatuhTempo.Location = New System.Drawing.Point(707, 500)
        Me.dtpJatuhTempo.Name = "dtpJatuhTempo"
        Me.dtpJatuhTempo.Size = New System.Drawing.Size(200, 20)
        Me.dtpJatuhTempo.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(944, 477)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Tunai / DP :"
        '
        'tbTunai
        '
        Me.tbTunai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTunai.Location = New System.Drawing.Point(1016, 474)
        Me.tbTunai.MaxLength = 11
        Me.tbTunai.Name = "tbTunai"
        Me.tbTunai.Size = New System.Drawing.Size(156, 20)
        Me.tbTunai.TabIndex = 9
        Me.tbTunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(970, 503)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Kredit :"
        '
        'tbKredit
        '
        Me.tbKredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKredit.Location = New System.Drawing.Point(1016, 500)
        Me.tbKredit.Name = "tbKredit"
        Me.tbKredit.ReadOnly = True
        Me.tbKredit.Size = New System.Drawing.Size(156, 20)
        Me.tbKredit.TabIndex = 11
        Me.tbKredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbKredit)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbTunai)
        Me.Controls.Add(Me.lblJatuhTempo)
        Me.Controls.Add(Me.dtpJatuhTempo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbDiskonAll)
        Me.Controls.Add(Me.tbJumlahItem)
        Me.Controls.Add(Me.tbPotongan)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.gbBarang)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.dgvKeranjang)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembelian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBarang.ResumeLayout(False)
        Me.gbBarang.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents gbBarang As GroupBox
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
    Friend WithEvents tbHargaBeli As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbKodeBukti As TextBox
    Friend WithEvents tbKodePembelian As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tbNoTelepon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbKodeSupplier As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbNamaSupplier As TextBox
    Friend WithEvents btnSupplier As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents tbSubtotal As TextBox
    Friend WithEvents tbPotongan As TextBox
    Friend WithEvents tbJumlahItem As TextBox
    Friend WithEvents tbDiskonAll As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tbIsi As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbDiskonBarang As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbSales As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents lblJatuhTempo As Label
    Friend WithEvents dtpJatuhTempo As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents tbTunai As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbKredit As TextBox
End Class
