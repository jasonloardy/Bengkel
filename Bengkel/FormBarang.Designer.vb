<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.cbStnDasar = New System.Windows.Forms.ComboBox()
        Me.gbBarang = New System.Windows.Forms.GroupBox()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.tbStokFisik = New System.Windows.Forms.TextBox()
        Me.tbStok = New System.Windows.Forms.TextBox()
        Me.labelStok = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbCustom = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblStnJualB = New System.Windows.Forms.Label()
        Me.lblStnJualL = New System.Windows.Forms.Label()
        Me.lblStnJualU = New System.Windows.Forms.Label()
        Me.lblStnBeli = New System.Windows.Forms.Label()
        Me.tbHrgJualB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbHrgJualL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbHrgJualU = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbHrgBeli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbStnMulti = New System.Windows.Forms.GroupBox()
        Me.btnHapusStn = New System.Windows.Forms.Button()
        Me.lblStnMulti = New System.Windows.Forms.Label()
        Me.btnTambahStn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbIsiStn = New System.Windows.Forms.TextBox()
        Me.cbStnMulti = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvSatuan = New System.Windows.Forms.DataGridView()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBarang.SuspendLayout()
        Me.gbStnMulti.SuspendLayout()
        CType(Me.dgvSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.dgvBarang)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 537)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Barang"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(144, 48)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(78, 13)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Jumlah Item : 0"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(6, 45)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvBarang
        '
        Me.dgvBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Location = New System.Drawing.Point(6, 74)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.Size = New System.Drawing.Size(742, 457)
        Me.dgvBarang.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cari Kode / Nama Barang :"
        '
        'tbCari
        '
        Me.tbCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCari.Location = New System.Drawing.Point(147, 19)
        Me.tbCari.MaxLength = 64
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(601, 20)
        Me.tbCari.TabIndex = 0
        '
        'cbStnDasar
        '
        Me.cbStnDasar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStnDasar.FormattingEnabled = True
        Me.cbStnDasar.Location = New System.Drawing.Point(124, 71)
        Me.cbStnDasar.Name = "cbStnDasar"
        Me.cbStnDasar.Size = New System.Drawing.Size(131, 21)
        Me.cbStnDasar.TabIndex = 9
        '
        'gbBarang
        '
        Me.gbBarang.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBarang.Controls.Add(Me.lblStok)
        Me.gbBarang.Controls.Add(Me.tbStokFisik)
        Me.gbBarang.Controls.Add(Me.tbStok)
        Me.gbBarang.Controls.Add(Me.labelStok)
        Me.gbBarang.Controls.Add(Me.cbStatus)
        Me.gbBarang.Controls.Add(Me.Label11)
        Me.gbBarang.Controls.Add(Me.cbCustom)
        Me.gbBarang.Controls.Add(Me.Label16)
        Me.gbBarang.Controls.Add(Me.lblStnJualB)
        Me.gbBarang.Controls.Add(Me.lblStnJualL)
        Me.gbBarang.Controls.Add(Me.lblStnJualU)
        Me.gbBarang.Controls.Add(Me.lblStnBeli)
        Me.gbBarang.Controls.Add(Me.tbHrgJualB)
        Me.gbBarang.Controls.Add(Me.Label10)
        Me.gbBarang.Controls.Add(Me.tbHrgJualL)
        Me.gbBarang.Controls.Add(Me.Label9)
        Me.gbBarang.Controls.Add(Me.tbHrgJualU)
        Me.gbBarang.Controls.Add(Me.Label8)
        Me.gbBarang.Controls.Add(Me.tbHrgBeli)
        Me.gbBarang.Controls.Add(Me.Label7)
        Me.gbBarang.Controls.Add(Me.gbStnMulti)
        Me.gbBarang.Controls.Add(Me.cbStnDasar)
        Me.gbBarang.Controls.Add(Me.tbKode)
        Me.gbBarang.Controls.Add(Me.Label1)
        Me.gbBarang.Controls.Add(Me.tbNama)
        Me.gbBarang.Controls.Add(Me.Label2)
        Me.gbBarang.Controls.Add(Me.Label3)
        Me.gbBarang.Location = New System.Drawing.Point(772, 12)
        Me.gbBarang.Name = "gbBarang"
        Me.gbBarang.Size = New System.Drawing.Size(400, 508)
        Me.gbBarang.TabIndex = 13
        Me.gbBarang.TabStop = False
        Me.gbBarang.Text = "Data Barang"
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.Location = New System.Drawing.Point(195, 458)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(19, 13)
        Me.lblStok.TabIndex = 30
        Me.lblStok.Text = "=>"
        '
        'tbStokFisik
        '
        Me.tbStokFisik.Location = New System.Drawing.Point(220, 455)
        Me.tbStokFisik.MaxLength = 64
        Me.tbStokFisik.Name = "tbStokFisik"
        Me.tbStokFisik.Size = New System.Drawing.Size(65, 20)
        Me.tbStokFisik.TabIndex = 29
        '
        'tbStok
        '
        Me.tbStok.Location = New System.Drawing.Point(124, 455)
        Me.tbStok.MaxLength = 64
        Me.tbStok.Name = "tbStok"
        Me.tbStok.Size = New System.Drawing.Size(65, 20)
        Me.tbStok.TabIndex = 27
        '
        'labelStok
        '
        Me.labelStok.Location = New System.Drawing.Point(6, 458)
        Me.labelStok.Name = "labelStok"
        Me.labelStok.Size = New System.Drawing.Size(112, 13)
        Me.labelStok.TabIndex = 26
        Me.labelStok.Text = "Stok :"
        Me.labelStok.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Aktif", "Non Aktif"})
        Me.cbStatus.Location = New System.Drawing.Point(124, 481)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(131, 21)
        Me.cbStatus.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 484)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Status :"
        '
        'cbCustom
        '
        Me.cbCustom.AutoSize = True
        Me.cbCustom.Location = New System.Drawing.Point(264, 21)
        Me.cbCustom.Name = "cbCustom"
        Me.cbCustom.Size = New System.Drawing.Size(61, 17)
        Me.cbCustom.TabIndex = 24
        Me.cbCustom.Text = "Custom"
        Me.cbCustom.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(46, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Multi Satuan :"
        '
        'lblStnJualB
        '
        Me.lblStnJualB.AutoSize = True
        Me.lblStnJualB.Location = New System.Drawing.Point(261, 179)
        Me.lblStnJualB.Name = "lblStnJualB"
        Me.lblStnJualB.Size = New System.Drawing.Size(65, 13)
        Me.lblStnJualB.TabIndex = 22
        Me.lblStnJualB.Text = "/ Stn. Dasar"
        '
        'lblStnJualL
        '
        Me.lblStnJualL.AutoSize = True
        Me.lblStnJualL.Location = New System.Drawing.Point(261, 153)
        Me.lblStnJualL.Name = "lblStnJualL"
        Me.lblStnJualL.Size = New System.Drawing.Size(65, 13)
        Me.lblStnJualL.TabIndex = 21
        Me.lblStnJualL.Text = "/ Stn. Dasar"
        '
        'lblStnJualU
        '
        Me.lblStnJualU.AutoSize = True
        Me.lblStnJualU.Location = New System.Drawing.Point(261, 127)
        Me.lblStnJualU.Name = "lblStnJualU"
        Me.lblStnJualU.Size = New System.Drawing.Size(65, 13)
        Me.lblStnJualU.TabIndex = 20
        Me.lblStnJualU.Text = "/ Stn. Dasar"
        '
        'lblStnBeli
        '
        Me.lblStnBeli.AutoSize = True
        Me.lblStnBeli.Location = New System.Drawing.Point(261, 101)
        Me.lblStnBeli.Name = "lblStnBeli"
        Me.lblStnBeli.Size = New System.Drawing.Size(65, 13)
        Me.lblStnBeli.TabIndex = 19
        Me.lblStnBeli.Text = "/ Stn. Dasar"
        '
        'tbHrgJualB
        '
        Me.tbHrgJualB.Location = New System.Drawing.Point(124, 176)
        Me.tbHrgJualB.MaxLength = 64
        Me.tbHrgJualB.Name = "tbHrgJualB"
        Me.tbHrgJualB.Size = New System.Drawing.Size(131, 20)
        Me.tbHrgJualB.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Hrg. Jual Partai :"
        '
        'tbHrgJualL
        '
        Me.tbHrgJualL.Location = New System.Drawing.Point(124, 150)
        Me.tbHrgJualL.MaxLength = 64
        Me.tbHrgJualL.Name = "tbHrgJualL"
        Me.tbHrgJualL.Size = New System.Drawing.Size(131, 20)
        Me.tbHrgJualL.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Hrg. Jual Langganan :"
        '
        'tbHrgJualU
        '
        Me.tbHrgJualU.Location = New System.Drawing.Point(124, 124)
        Me.tbHrgJualU.MaxLength = 64
        Me.tbHrgJualU.Name = "tbHrgJualU"
        Me.tbHrgJualU.Size = New System.Drawing.Size(131, 20)
        Me.tbHrgJualU.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Hrg. Jual Umum :"
        '
        'tbHrgBeli
        '
        Me.tbHrgBeli.Location = New System.Drawing.Point(124, 98)
        Me.tbHrgBeli.MaxLength = 64
        Me.tbHrgBeli.Name = "tbHrgBeli"
        Me.tbHrgBeli.Size = New System.Drawing.Size(131, 20)
        Me.tbHrgBeli.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Hrg. Beli :"
        '
        'gbStnMulti
        '
        Me.gbStnMulti.Controls.Add(Me.btnHapusStn)
        Me.gbStnMulti.Controls.Add(Me.lblStnMulti)
        Me.gbStnMulti.Controls.Add(Me.btnTambahStn)
        Me.gbStnMulti.Controls.Add(Me.Label6)
        Me.gbStnMulti.Controls.Add(Me.tbIsiStn)
        Me.gbStnMulti.Controls.Add(Me.cbStnMulti)
        Me.gbStnMulti.Controls.Add(Me.Label4)
        Me.gbStnMulti.Controls.Add(Me.dgvSatuan)
        Me.gbStnMulti.Location = New System.Drawing.Point(124, 202)
        Me.gbStnMulti.Name = "gbStnMulti"
        Me.gbStnMulti.Size = New System.Drawing.Size(270, 247)
        Me.gbStnMulti.TabIndex = 10
        Me.gbStnMulti.TabStop = False
        Me.gbStnMulti.Text = "Konversi"
        '
        'btnHapusStn
        '
        Me.btnHapusStn.Location = New System.Drawing.Point(157, 72)
        Me.btnHapusStn.Name = "btnHapusStn"
        Me.btnHapusStn.Size = New System.Drawing.Size(75, 23)
        Me.btnHapusStn.TabIndex = 18
        Me.btnHapusStn.Text = "Hapus"
        Me.btnHapusStn.UseVisualStyleBackColor = True
        '
        'lblStnMulti
        '
        Me.lblStnMulti.AutoSize = True
        Me.lblStnMulti.Location = New System.Drawing.Point(182, 49)
        Me.lblStnMulti.Name = "lblStnMulti"
        Me.lblStnMulti.Size = New System.Drawing.Size(65, 13)
        Me.lblStnMulti.TabIndex = 23
        Me.lblStnMulti.Text = "/ Stn. Dasar"
        '
        'btnTambahStn
        '
        Me.btnTambahStn.Location = New System.Drawing.Point(76, 72)
        Me.btnTambahStn.Name = "btnTambahStn"
        Me.btnTambahStn.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahStn.TabIndex = 18
        Me.btnTambahStn.Text = "Tambah"
        Me.btnTambahStn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Isi :"
        '
        'tbIsiStn
        '
        Me.tbIsiStn.Location = New System.Drawing.Point(76, 46)
        Me.tbIsiStn.Name = "tbIsiStn"
        Me.tbIsiStn.Size = New System.Drawing.Size(100, 20)
        Me.tbIsiStn.TabIndex = 13
        '
        'cbStnMulti
        '
        Me.cbStnMulti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStnMulti.FormattingEnabled = True
        Me.cbStnMulti.Location = New System.Drawing.Point(76, 19)
        Me.cbStnMulti.Name = "cbStnMulti"
        Me.cbStnMulti.Size = New System.Drawing.Size(131, 21)
        Me.cbStnMulti.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Satuan :"
        '
        'dgvSatuan
        '
        Me.dgvSatuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSatuan.Location = New System.Drawing.Point(6, 101)
        Me.dgvSatuan.Name = "dgvSatuan"
        Me.dgvSatuan.Size = New System.Drawing.Size(258, 140)
        Me.dgvSatuan.TabIndex = 0
        '
        'tbKode
        '
        Me.tbKode.Location = New System.Drawing.Point(124, 19)
        Me.tbKode.MaxLength = 8
        Me.tbKode.Name = "tbKode"
        Me.tbKode.Size = New System.Drawing.Size(131, 20)
        Me.tbKode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Barang :"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(124, 45)
        Me.tbNama.MaxLength = 64
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(270, 20)
        Me.tbNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Barang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Satuan Dasar :"
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.Location = New System.Drawing.Point(1016, 526)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(935, 526)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.Location = New System.Drawing.Point(854, 526)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 14
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.Location = New System.Drawing.Point(1097, 526)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 17
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbBarang)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnBatal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBarang.ResumeLayout(False)
        Me.gbBarang.PerformLayout()
        Me.gbStnMulti.ResumeLayout(False)
        Me.gbStnMulti.PerformLayout()
        CType(Me.dgvSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCari As TextBox
    Friend WithEvents cbStnDasar As ComboBox
    Friend WithEvents gbBarang As GroupBox
    Friend WithEvents tbHrgJualB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbHrgJualL As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbHrgJualU As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbHrgBeli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbStnMulti As GroupBox
    Friend WithEvents btnTambahStn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbIsiStn As TextBox
    Friend WithEvents cbStnMulti As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvSatuan As DataGridView
    Friend WithEvents tbKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents lblStnJualB As Label
    Friend WithEvents lblStnJualL As Label
    Friend WithEvents lblStnJualU As Label
    Friend WithEvents lblStnBeli As Label
    Friend WithEvents lblStnMulti As Label
    Friend WithEvents cbCustom As CheckBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnHapusStn As Button
    Friend WithEvents lblStok As Label
    Friend WithEvents tbStokFisik As TextBox
    Friend WithEvents tbStok As TextBox
    Friend WithEvents labelStok As Label
End Class
