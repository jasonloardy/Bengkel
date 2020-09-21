<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporan
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
        Me.tbTahunan = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbHarian = New System.Windows.Forms.RadioButton()
        Me.rbBulanan = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.dtpHarian1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpHarian2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpBulanan = New System.Windows.Forms.DateTimePicker()
        Me.cbTahunan = New System.Windows.Forms.ComboBox()
        Me.rbPembelian = New System.Windows.Forms.RadioButton()
        Me.rbPenjualan = New System.Windows.Forms.RadioButton()
        Me.rbBarangBeli = New System.Windows.Forms.RadioButton()
        Me.rbBarangJual = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.tbTahunan.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTahunan
        '
        Me.tbTahunan.Controls.Add(Me.cbTahunan)
        Me.tbTahunan.Controls.Add(Me.dtpBulanan)
        Me.tbTahunan.Controls.Add(Me.dtpHarian2)
        Me.tbTahunan.Controls.Add(Me.dtpHarian1)
        Me.tbTahunan.Controls.Add(Me.RadioButton2)
        Me.tbTahunan.Controls.Add(Me.rbBulanan)
        Me.tbTahunan.Controls.Add(Me.rbHarian)
        Me.tbTahunan.Location = New System.Drawing.Point(12, 12)
        Me.tbTahunan.Name = "tbTahunan"
        Me.tbTahunan.Size = New System.Drawing.Size(294, 100)
        Me.tbTahunan.TabIndex = 0
        Me.tbTahunan.TabStop = False
        Me.tbTahunan.Text = "Periode"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbBarangJual)
        Me.GroupBox2.Controls.Add(Me.rbBarangBeli)
        Me.GroupBox2.Controls.Add(Me.rbPenjualan)
        Me.GroupBox2.Controls.Add(Me.rbPembelian)
        Me.GroupBox2.Location = New System.Drawing.Point(312, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan"
        '
        'rbHarian
        '
        Me.rbHarian.AutoSize = True
        Me.rbHarian.Checked = True
        Me.rbHarian.Location = New System.Drawing.Point(6, 19)
        Me.rbHarian.Name = "rbHarian"
        Me.rbHarian.Size = New System.Drawing.Size(56, 17)
        Me.rbHarian.TabIndex = 0
        Me.rbHarian.TabStop = True
        Me.rbHarian.Text = "Harian"
        Me.rbHarian.UseVisualStyleBackColor = True
        '
        'rbBulanan
        '
        Me.rbBulanan.AutoSize = True
        Me.rbBulanan.Location = New System.Drawing.Point(6, 45)
        Me.rbBulanan.Name = "rbBulanan"
        Me.rbBulanan.Size = New System.Drawing.Size(64, 17)
        Me.rbBulanan.TabIndex = 1
        Me.rbBulanan.TabStop = True
        Me.rbBulanan.Text = "Bulanan"
        Me.rbBulanan.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 71)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Tahunan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'dtpHarian1
        '
        Me.dtpHarian1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHarian1.Location = New System.Drawing.Point(80, 19)
        Me.dtpHarian1.Name = "dtpHarian1"
        Me.dtpHarian1.Size = New System.Drawing.Size(100, 20)
        Me.dtpHarian1.TabIndex = 3
        '
        'dtpHarian2
        '
        Me.dtpHarian2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHarian2.Location = New System.Drawing.Point(186, 19)
        Me.dtpHarian2.Name = "dtpHarian2"
        Me.dtpHarian2.Size = New System.Drawing.Size(100, 20)
        Me.dtpHarian2.TabIndex = 4
        '
        'dtpBulanan
        '
        Me.dtpBulanan.CustomFormat = "MMMM yyyy"
        Me.dtpBulanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBulanan.Location = New System.Drawing.Point(80, 45)
        Me.dtpBulanan.Name = "dtpBulanan"
        Me.dtpBulanan.Size = New System.Drawing.Size(206, 20)
        Me.dtpBulanan.TabIndex = 5
        '
        'cbTahunan
        '
        Me.cbTahunan.FormattingEnabled = True
        Me.cbTahunan.Location = New System.Drawing.Point(80, 71)
        Me.cbTahunan.Name = "cbTahunan"
        Me.cbTahunan.Size = New System.Drawing.Size(100, 21)
        Me.cbTahunan.TabIndex = 6
        '
        'rbPembelian
        '
        Me.rbPembelian.AutoSize = True
        Me.rbPembelian.Checked = True
        Me.rbPembelian.Location = New System.Drawing.Point(6, 19)
        Me.rbPembelian.Name = "rbPembelian"
        Me.rbPembelian.Size = New System.Drawing.Size(74, 17)
        Me.rbPembelian.TabIndex = 0
        Me.rbPembelian.TabStop = True
        Me.rbPembelian.Text = "Pembelian"
        Me.rbPembelian.UseVisualStyleBackColor = True
        '
        'rbPenjualan
        '
        Me.rbPenjualan.AutoSize = True
        Me.rbPenjualan.Location = New System.Drawing.Point(6, 45)
        Me.rbPenjualan.Name = "rbPenjualan"
        Me.rbPenjualan.Size = New System.Drawing.Size(72, 17)
        Me.rbPenjualan.TabIndex = 1
        Me.rbPenjualan.TabStop = True
        Me.rbPenjualan.Text = "Penjualan"
        Me.rbPenjualan.UseVisualStyleBackColor = True
        '
        'rbBarangBeli
        '
        Me.rbBarangBeli.AutoSize = True
        Me.rbBarangBeli.Location = New System.Drawing.Point(86, 19)
        Me.rbBarangBeli.Name = "rbBarangBeli"
        Me.rbBarangBeli.Size = New System.Drawing.Size(124, 17)
        Me.rbBarangBeli.TabIndex = 2
        Me.rbBarangBeli.TabStop = True
        Me.rbBarangBeli.Text = "Jumlah Barang Dibeli"
        Me.rbBarangBeli.UseVisualStyleBackColor = True
        '
        'rbBarangJual
        '
        Me.rbBarangJual.AutoSize = True
        Me.rbBarangJual.Location = New System.Drawing.Point(86, 45)
        Me.rbBarangJual.Name = "rbBarangJual"
        Me.rbBarangJual.Size = New System.Drawing.Size(124, 17)
        Me.rbBarangJual.TabIndex = 3
        Me.rbBarangJual.TabStop = True
        Me.rbBarangJual.Text = "Jumlah Barang Dijual"
        Me.rbBarangJual.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(536, 89)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer.Location = New System.Drawing.Point(12, 118)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.ShowCloseButton = False
        Me.CRViewer.ShowGroupTreeButton = False
        Me.CRViewer.ShowLogo = False
        Me.CRViewer.ShowParameterPanelButton = False
        Me.CRViewer.ShowRefreshButton = False
        Me.CRViewer.Size = New System.Drawing.Size(1160, 431)
        Me.CRViewer.TabIndex = 3
        Me.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tbTahunan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        Me.tbTahunan.ResumeLayout(False)
        Me.tbTahunan.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbTahunan As GroupBox
    Friend WithEvents dtpBulanan As DateTimePicker
    Friend WithEvents dtpHarian2 As DateTimePicker
    Friend WithEvents dtpHarian1 As DateTimePicker
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbBulanan As RadioButton
    Friend WithEvents rbHarian As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbTahunan As ComboBox
    Friend WithEvents rbBarangBeli As RadioButton
    Friend WithEvents rbPenjualan As RadioButton
    Friend WithEvents rbPembelian As RadioButton
    Friend WithEvents rbBarangJual As RadioButton
    Friend WithEvents btnPreview As Button
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
