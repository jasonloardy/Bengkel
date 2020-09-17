<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPelanggan = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.tbTelepon = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.gbPelanggan = New System.Windows.Forms.GroupBox()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPelanggan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.Location = New System.Drawing.Point(1097, 177)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.Location = New System.Drawing.Point(1016, 177)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(935, 177)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.Location = New System.Drawing.Point(854, 177)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "No. Telepon :"
        '
        'tbKode
        '
        Me.tbKode.Enabled = False
        Me.tbKode.Location = New System.Drawing.Point(107, 19)
        Me.tbKode.MaxLength = 8
        Me.tbKode.Name = "tbKode"
        Me.tbKode.Size = New System.Drawing.Size(131, 20)
        Me.tbKode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Pelanggan :"
        '
        'dgvPelanggan
        '
        Me.dgvPelanggan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPelanggan.Location = New System.Drawing.Point(6, 74)
        Me.dgvPelanggan.Name = "dgvPelanggan"
        Me.dgvPelanggan.Size = New System.Drawing.Size(742, 457)
        Me.dgvPelanggan.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cari Kode / Nama Pelanggan :"
        '
        'tbCari
        '
        Me.tbCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCari.Location = New System.Drawing.Point(164, 19)
        Me.tbCari.MaxLength = 64
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(584, 20)
        Me.tbCari.TabIndex = 0
        '
        'tbTelepon
        '
        Me.tbTelepon.Location = New System.Drawing.Point(107, 97)
        Me.tbTelepon.MaxLength = 64
        Me.tbTelepon.Name = "tbTelepon"
        Me.tbTelepon.Size = New System.Drawing.Size(287, 20)
        Me.tbTelepon.TabIndex = 3
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(107, 45)
        Me.tbNama.MaxLength = 64
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(287, 20)
        Me.tbNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Pelanggan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alamat :"
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(107, 71)
        Me.tbAlamat.MaxLength = 64
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(287, 20)
        Me.tbAlamat.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(161, 48)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(109, 13)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Jumlah Pelanggan : 0"
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
        'gbPelanggan
        '
        Me.gbPelanggan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPelanggan.Controls.Add(Me.cbKategori)
        Me.gbPelanggan.Controls.Add(Me.Label6)
        Me.gbPelanggan.Controls.Add(Me.Label4)
        Me.gbPelanggan.Controls.Add(Me.tbKode)
        Me.gbPelanggan.Controls.Add(Me.Label1)
        Me.gbPelanggan.Controls.Add(Me.tbTelepon)
        Me.gbPelanggan.Controls.Add(Me.tbNama)
        Me.gbPelanggan.Controls.Add(Me.Label2)
        Me.gbPelanggan.Controls.Add(Me.Label3)
        Me.gbPelanggan.Controls.Add(Me.tbAlamat)
        Me.gbPelanggan.Location = New System.Drawing.Point(772, 12)
        Me.gbPelanggan.Name = "gbPelanggan"
        Me.gbPelanggan.Size = New System.Drawing.Size(400, 159)
        Me.gbPelanggan.TabIndex = 1
        Me.gbPelanggan.TabStop = False
        Me.gbPelanggan.Text = "Data Pelanggan"
        '
        'cbKategori
        '
        Me.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Items.AddRange(New Object() {"Umum", "Langganan", "Partai"})
        Me.cbKategori.Location = New System.Drawing.Point(107, 123)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(131, 21)
        Me.cbKategori.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Kategori :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblPage)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnPrev)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.dgvPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 537)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Pelanggan"
        '
        'lblPage
        '
        Me.lblPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPage.Location = New System.Drawing.Point(658, 50)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(54, 13)
        Me.lblPage.TabIndex = 22
        Me.lblPage.Text = "999 / 999"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(718, 45)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(30, 23)
        Me.btnNext.TabIndex = 21
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.Location = New System.Drawing.Point(622, 45)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(30, 23)
        Me.btnPrev.TabIndex = 20
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.gbPelanggan)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPelanggan"
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPelanggan.ResumeLayout(False)
        Me.gbPelanggan.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCari As TextBox
    Friend WithEvents tbTelepon As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents gbPelanggan As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPage As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
End Class
