<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewBarcode
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
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer.Location = New System.Drawing.Point(12, 12)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.ShowCloseButton = False
        Me.CRViewer.ShowCopyButton = False
        Me.CRViewer.ShowGotoPageButton = False
        Me.CRViewer.ShowGroupTreeButton = False
        Me.CRViewer.ShowLogo = False
        Me.CRViewer.ShowPageNavigateButtons = False
        Me.CRViewer.ShowParameterPanelButton = False
        Me.CRViewer.ShowPrintButton = False
        Me.CRViewer.ShowRefreshButton = False
        Me.CRViewer.ShowTextSearchButton = False
        Me.CRViewer.ShowZoomButton = False
        Me.CRViewer.Size = New System.Drawing.Size(960, 408)
        Me.CRViewer.TabIndex = 0
        Me.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(12, 426)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 23)
        Me.btnCetak.TabIndex = 1
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'FormViewBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.CRViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormViewBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormViewBarcode"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnCetak As Button
End Class
