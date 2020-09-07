<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarHutang
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
        Me.dgvTrx = New System.Windows.Forms.DataGridView()
        Me.gbSupplier = New System.Windows.Forms.GroupBox()
        Me.tbCariSupplier = New System.Windows.Forms.TextBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSupplier.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSupplier
        '
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Location = New System.Drawing.Point(6, 45)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.Size = New System.Drawing.Size(388, 486)
        Me.dgvSupplier.TabIndex = 0
        '
        'dgvTrx
        '
        Me.dgvTrx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrx.Location = New System.Drawing.Point(6, 45)
        Me.dgvTrx.Name = "dgvTrx"
        Me.dgvTrx.Size = New System.Drawing.Size(742, 486)
        Me.dgvTrx.TabIndex = 1
        '
        'gbSupplier
        '
        Me.gbSupplier.Controls.Add(Me.lblSupplier)
        Me.gbSupplier.Controls.Add(Me.tbCariSupplier)
        Me.gbSupplier.Controls.Add(Me.dgvSupplier)
        Me.gbSupplier.Location = New System.Drawing.Point(12, 12)
        Me.gbSupplier.Name = "gbSupplier"
        Me.gbSupplier.Size = New System.Drawing.Size(400, 537)
        Me.gbSupplier.TabIndex = 3
        Me.gbSupplier.TabStop = False
        Me.gbSupplier.Text = "Supplier"
        '
        'tbCariSupplier
        '
        Me.tbCariSupplier.Location = New System.Drawing.Point(91, 19)
        Me.tbCariSupplier.Name = "tbCariSupplier"
        Me.tbCariSupplier.Size = New System.Drawing.Size(303, 20)
        Me.tbCariSupplier.TabIndex = 1
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(6, 22)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(79, 13)
        Me.lblSupplier.TabIndex = 2
        Me.lblSupplier.Text = "Kode Supplier :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvTrx)
        Me.GroupBox1.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 537)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Hutang"
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(675, 20)
        Me.TextBox1.TabIndex = 3
        '
        'FormDaftarHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSupplier)
        Me.Name = "FormDaftarHutang"
        Me.Text = "FormDaftarHutang"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTrx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSupplier.ResumeLayout(False)
        Me.gbSupplier.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents dgvTrx As DataGridView
    Friend WithEvents gbSupplier As GroupBox
    Friend WithEvents lblSupplier As Label
    Friend WithEvents tbCariSupplier As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
