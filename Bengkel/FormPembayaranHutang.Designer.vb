<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembayaranHutang
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
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.tbTotalKredit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbKodeHutang = New System.Windows.Forms.TextBox()
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
        Me.dgvTrx = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(943, 503)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Total Kredit :"
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(1097, 526)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.Location = New System.Drawing.Point(1016, 526)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'tbTotalKredit
        '
        Me.tbTotalKredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotalKredit.Location = New System.Drawing.Point(1016, 500)
        Me.tbTotalKredit.Name = "tbTotalKredit"
        Me.tbTotalKredit.ReadOnly = True
        Me.tbTotalKredit.Size = New System.Drawing.Size(156, 20)
        Me.tbTotalKredit.TabIndex = 3
        Me.tbTotalKredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbKodeHutang)
        Me.GroupBox1.Controls.Add(Me.dtpTanggal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran Hutang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Kode Pembayaran :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Tanggal :"
        '
        'tbKodeHutang
        '
        Me.tbKodeHutang.Location = New System.Drawing.Point(112, 49)
        Me.tbKodeHutang.Name = "tbKodeHutang"
        Me.tbKodeHutang.ReadOnly = True
        Me.tbKodeHutang.Size = New System.Drawing.Size(190, 20)
        Me.tbKodeHutang.TabIndex = 1
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Enabled = False
        Me.dtpTanggal.Location = New System.Drawing.Point(112, 23)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(190, 20)
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
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Pembayaran Hutang"
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
        'dgvTrx
        '
        Me.dgvTrx.AllowUserToAddRows = False
        Me.dgvTrx.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvTrx.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTrx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTrx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrx.Location = New System.Drawing.Point(12, 151)
        Me.dgvTrx.Name = "dgvTrx"
        Me.dgvTrx.ReadOnly = True
        Me.dgvTrx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrx.Size = New System.Drawing.Size(1160, 343)
        Me.dgvTrx.TabIndex = 2
        '
        'FormPembayaranHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.tbTotalKredit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvTrx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPembayaranHutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembayaranHutang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label20 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents tbTotalKredit As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbKodeHutang As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSupplier As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tbNoTelepon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbKodeSupplier As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbNamaSupplier As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents dgvTrx As DataGridView
End Class
