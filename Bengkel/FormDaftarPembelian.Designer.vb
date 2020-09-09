<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarPembelian
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
        Me.dgvTrx = New System.Windows.Forms.DataGridView()
        Me.gbSupplier = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.CRVBuktiPembelian = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRBuktiPembelian1 = New Bengkel.CRBuktiPembelian()
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTrx
        '
        Me.dgvTrx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvTrx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrx.Location = New System.Drawing.Point(6, 74)
        Me.dgvTrx.Name = "dgvTrx"
        Me.dgvTrx.Size = New System.Drawing.Size(452, 457)
        Me.dgvTrx.TabIndex = 0
        '
        'gbSupplier
        '
        Me.gbSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbSupplier.Controls.Add(Me.lblTotal)
        Me.gbSupplier.Controls.Add(Me.lblPage)
        Me.gbSupplier.Controls.Add(Me.btnNext)
        Me.gbSupplier.Controls.Add(Me.btnPrev)
        Me.gbSupplier.Controls.Add(Me.btnRefresh)
        Me.gbSupplier.Controls.Add(Me.lblSupplier)
        Me.gbSupplier.Controls.Add(Me.tbCari)
        Me.gbSupplier.Controls.Add(Me.dgvTrx)
        Me.gbSupplier.Location = New System.Drawing.Point(12, 12)
        Me.gbSupplier.Name = "gbSupplier"
        Me.gbSupplier.Size = New System.Drawing.Size(464, 537)
        Me.gbSupplier.TabIndex = 5
        Me.gbSupplier.TabStop = False
        Me.gbSupplier.Text = "Daftar Pembelian"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(87, 50)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(104, 13)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "Jumlah Transaksi : 0"
        '
        'lblPage
        '
        Me.lblPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPage.Location = New System.Drawing.Point(368, 50)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(54, 13)
        Me.lblPage.TabIndex = 19
        Me.lblPage.Text = "999 / 999"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(428, 45)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(30, 23)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.Location = New System.Drawing.Point(332, 45)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(30, 23)
        Me.btnPrev.TabIndex = 17
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
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
        Me.lblSupplier.Location = New System.Drawing.Point(6, 22)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(61, 13)
        Me.lblSupplier.TabIndex = 2
        Me.lblSupplier.Text = "Pencarian :"
        '
        'tbCari
        '
        Me.tbCari.Location = New System.Drawing.Point(90, 19)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(368, 20)
        Me.tbCari.TabIndex = 1
        '
        'CRVBuktiPembelian
        '
        Me.CRVBuktiPembelian.ActiveViewIndex = -1
        Me.CRVBuktiPembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRVBuktiPembelian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVBuktiPembelian.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVBuktiPembelian.Location = New System.Drawing.Point(482, 12)
        Me.CRVBuktiPembelian.Name = "CRVBuktiPembelian"
        Me.CRVBuktiPembelian.ShowCloseButton = False
        Me.CRVBuktiPembelian.ShowGroupTreeButton = False
        Me.CRVBuktiPembelian.ShowLogo = False
        Me.CRVBuktiPembelian.ShowParameterPanelButton = False
        Me.CRVBuktiPembelian.Size = New System.Drawing.Size(690, 537)
        Me.CRVBuktiPembelian.TabIndex = 6
        Me.CRVBuktiPembelian.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormDaftarPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.CRVBuktiPembelian)
        Me.Controls.Add(Me.gbSupplier)
        Me.Name = "FormDaftarPembelian"
        Me.Text = "FormDaftarPembelian"
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSupplier.ResumeLayout(False)
        Me.gbSupplier.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTrx As DataGridView
    Friend WithEvents gbSupplier As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblSupplier As Label
    Friend WithEvents tbCari As TextBox
    Friend WithEvents CRVBuktiPembelian As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRBuktiPembelian1 As CRBuktiPembelian
    Friend WithEvents lblPage As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblTotal As Label
End Class
