<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDaftarpiutang
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
        Me.dgvPelanggan = New System.Windows.Forms.DataGridView()
        Me.dgvTrx = New System.Windows.Forms.DataGridView()
        Me.gbPelanggan = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.tbCaripelanggan = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbCariTrx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPelanggan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPelanggan
        '
        Me.dgvPelanggan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPelanggan.Location = New System.Drawing.Point(6, 74)
        Me.dgvPelanggan.Name = "dgvPelanggan"
        Me.dgvPelanggan.Size = New System.Drawing.Size(388, 457)
        Me.dgvPelanggan.TabIndex = 0
        '
        'dgvTrx
        '
        Me.dgvTrx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTrx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrx.Location = New System.Drawing.Point(6, 45)
        Me.dgvTrx.Name = "dgvTrx"
        Me.dgvTrx.Size = New System.Drawing.Size(742, 486)
        Me.dgvTrx.TabIndex = 1
        '
        'gbPelanggan
        '
        Me.gbPelanggan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbPelanggan.Controls.Add(Me.btnRefresh)
        Me.gbPelanggan.Controls.Add(Me.lblSupplier)
        Me.gbPelanggan.Controls.Add(Me.tbCaripelanggan)
        Me.gbPelanggan.Controls.Add(Me.dgvPelanggan)
        Me.gbPelanggan.Location = New System.Drawing.Point(12, 12)
        Me.gbPelanggan.Name = "gbPelanggan"
        Me.gbPelanggan.Size = New System.Drawing.Size(400, 537)
        Me.gbPelanggan.TabIndex = 5
        Me.gbPelanggan.TabStop = False
        Me.gbPelanggan.Text = "Pelanggan"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(6, 45)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(21, 22)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(64, 13)
        Me.lblSupplier.TabIndex = 2
        Me.lblSupplier.Text = "Pelanggan :"
        '
        'tbCaripelanggan
        '
        Me.tbCaripelanggan.Location = New System.Drawing.Point(91, 19)
        Me.tbCaripelanggan.Name = "tbCaripelanggan"
        Me.tbCaripelanggan.Size = New System.Drawing.Size(303, 20)
        Me.tbCaripelanggan.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tbCariTrx)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvTrx)
        Me.GroupBox1.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 537)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Piutang"
        '
        'tbCariTrx
        '
        Me.tbCariTrx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCariTrx.Location = New System.Drawing.Point(73, 19)
        Me.tbCariTrx.Name = "tbCariTrx"
        Me.tbCariTrx.Size = New System.Drawing.Size(675, 20)
        Me.tbCariTrx.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pencarian :"
        '
        'FormDaftarpiutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.gbPelanggan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormDaftarpiutang"
        Me.Text = "FormDaftarPiutang"
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPelanggan.ResumeLayout(False)
        Me.gbPelanggan.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents dgvTrx As DataGridView
    Friend WithEvents gbPelanggan As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblSupplier As Label
    Friend WithEvents tbCaripelanggan As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbCariTrx As TextBox
    Friend WithEvents Label1 As Label
End Class
