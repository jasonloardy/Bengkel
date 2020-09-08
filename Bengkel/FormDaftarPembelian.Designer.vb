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
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.gbSupplier = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.tbCariSupplier = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSupplier
        '
        Me.dgvSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Location = New System.Drawing.Point(6, 74)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.Size = New System.Drawing.Size(388, 457)
        Me.dgvSupplier.TabIndex = 0
        '
        'gbSupplier
        '
        Me.gbSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbSupplier.Controls.Add(Me.btnRefresh)
        Me.gbSupplier.Controls.Add(Me.lblSupplier)
        Me.gbSupplier.Controls.Add(Me.tbCariSupplier)
        Me.gbSupplier.Controls.Add(Me.dgvSupplier)
        Me.gbSupplier.Location = New System.Drawing.Point(12, 12)
        Me.gbSupplier.Name = "gbSupplier"
        Me.gbSupplier.Size = New System.Drawing.Size(400, 537)
        Me.gbSupplier.TabIndex = 5
        Me.gbSupplier.TabStop = False
        Me.gbSupplier.Text = "Daftar Pembelian"
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
        'tbCariSupplier
        '
        Me.tbCariSupplier.Location = New System.Drawing.Point(73, 19)
        Me.tbCariSupplier.Name = "tbCariSupplier"
        Me.tbCariSupplier.Size = New System.Drawing.Size(321, 20)
        Me.tbCariSupplier.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 537)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'FormDaftarPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.gbSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormDaftarPembelian"
        Me.Text = "FormDaftarPembelian"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSupplier.ResumeLayout(False)
        Me.gbSupplier.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents gbSupplier As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblSupplier As Label
    Friend WithEvents tbCariSupplier As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
