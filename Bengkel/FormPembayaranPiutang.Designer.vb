<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembayaranpiutang
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvTrx = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPlg = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbKodePlg = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNamaPlg = New System.Windows.Forms.TextBox()
        Me.tbKodePiutang = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.tbTotalKredit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(647, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 133)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Pembayaran Piutang"
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvTrx.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPlg)
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
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pelanggan"
        '
        'btnPlg
        '
        Me.btnPlg.Location = New System.Drawing.Point(202, 21)
        Me.btnPlg.Name = "btnPlg"
        Me.btnPlg.Size = New System.Drawing.Size(37, 23)
        Me.btnPlg.TabIndex = 1
        Me.btnPlg.Text = "..."
        Me.btnPlg.UseVisualStyleBackColor = True
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
        Me.tbKodePlg.TabIndex = 0
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
        Me.tbNamaPlg.TabIndex = 2
        '
        'tbKodePiutang
        '
        Me.tbKodePiutang.Location = New System.Drawing.Point(112, 49)
        Me.tbKodePiutang.Name = "tbKodePiutang"
        Me.tbKodePiutang.ReadOnly = True
        Me.tbKodePiutang.Size = New System.Drawing.Size(190, 20)
        Me.tbKodePiutang.TabIndex = 1
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Enabled = False
        Me.dtpTanggal.Location = New System.Drawing.Point(112, 23)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(190, 20)
        Me.dtpTanggal.TabIndex = 0
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
        Me.GroupBox1.Controls.Add(Me.tbKodePiutang)
        Me.GroupBox1.Controls.Add(Me.dtpTanggal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran Piutang"
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
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(943, 503)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Total Kredit :"
        '
        'FormPembayaranpiutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvTrx)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.tbTotalKredit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPembayaranpiutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembayaranPiutang"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents dgvTrx As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPlg As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tbNoTelepon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbKodePlg As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbNamaPlg As TextBox
    Friend WithEvents tbKodePiutang As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents tbTotalKredit As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label20 As Label
End Class
