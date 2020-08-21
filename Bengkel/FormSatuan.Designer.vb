<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSatuan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.tbNamaSatuan = New System.Windows.Forms.TextBox()
        Me.tbKodeSatuan = New System.Windows.Forms.TextBox()
        Me.dgvSatuan = New System.Windows.Forms.DataGridView()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.gbSatuan = New System.Windows.Forms.GroupBox()
        CType(Me.dgvSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSatuan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Satuan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kode Satuan :"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(12, 127)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(316, 98)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(235, 98)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(154, 98)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'tbNamaSatuan
        '
        Me.tbNamaSatuan.Location = New System.Drawing.Point(142, 45)
        Me.tbNamaSatuan.MaxLength = 32
        Me.tbNamaSatuan.Name = "tbNamaSatuan"
        Me.tbNamaSatuan.Size = New System.Drawing.Size(200, 20)
        Me.tbNamaSatuan.TabIndex = 1
        '
        'tbKodeSatuan
        '
        Me.tbKodeSatuan.Location = New System.Drawing.Point(142, 19)
        Me.tbKodeSatuan.MaxLength = 8
        Me.tbKodeSatuan.Name = "tbKodeSatuan"
        Me.tbKodeSatuan.Size = New System.Drawing.Size(200, 20)
        Me.tbKodeSatuan.TabIndex = 0
        '
        'dgvSatuan
        '
        Me.dgvSatuan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvSatuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSatuan.Location = New System.Drawing.Point(12, 156)
        Me.dgvSatuan.Name = "dgvSatuan"
        Me.dgvSatuan.Size = New System.Drawing.Size(460, 393)
        Me.dgvSatuan.TabIndex = 13
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(397, 98)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'gbSatuan
        '
        Me.gbSatuan.Controls.Add(Me.Label2)
        Me.gbSatuan.Controls.Add(Me.Label1)
        Me.gbSatuan.Controls.Add(Me.tbNamaSatuan)
        Me.gbSatuan.Controls.Add(Me.tbKodeSatuan)
        Me.gbSatuan.Location = New System.Drawing.Point(12, 12)
        Me.gbSatuan.Name = "gbSatuan"
        Me.gbSatuan.Size = New System.Drawing.Size(460, 80)
        Me.gbSatuan.TabIndex = 7
        Me.gbSatuan.TabStop = False
        Me.gbSatuan.Text = "Data Satuan"
        '
        'FormSatuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvSatuan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.gbSatuan)
        Me.Name = "FormSatuan"
        Me.Text = "FormSatuan"
        CType(Me.dgvSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSatuan.ResumeLayout(False)
        Me.gbSatuan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents tbNamaSatuan As TextBox
    Friend WithEvents tbKodeSatuan As TextBox
    Friend WithEvents dgvSatuan As DataGridView
    Friend WithEvents btnBatal As Button
    Friend WithEvents gbSatuan As GroupBox
End Class
