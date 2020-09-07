Imports MySql.Data.MySqlClient

Public Class FormDaftarHutang
    Private Sub FormDaftarHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        isiGridSupplier()
    End Sub

    Sub isiGridSupplier()
        Try
            Dim sql As String = "SELECT tb.kd_supplier, ts.nama, SUM(tb.sisa) total_hutang
                                    FROM tb_pembelian tb
                                    JOIN tb_supplier ts ON tb.kd_supplier = ts.kd_supplier
                                    WHERE tb.sisa>0
                                    GROUP BY tb.kd_supplier"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvSupplier.DataSource = ds.Tables(0)
                judulGridSupplier()
            Else
                dgvSupplier.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGridSupplier()
        With dgvSupplier
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvSupplier.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Supplier"
            .Columns(1).HeaderText = "Nama Supplier"
            .Columns(2).HeaderText = "Total Hutang"
            .Columns(0).Width = 100
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 100
            .Columns(2).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Sub isiGridTrx(ByVal kd_supplier As String)
        Try
            Dim sql As String = "SELECT kd_pembelian, kd_bukti, sales, tanggal_jt, tunai+sisa, sisa
                                    FROM tb_pembelian
                                    WHERE kd_supplier = '" & kd_supplier & "' AND sisa > 0"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvTrx.DataSource = ds.Tables(0)
                judulGridTrx()
            Else
                dgvTrx.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGridTrx()
        With dgvTrx
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            dgvSupplier.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Pembelian"
            .Columns(1).HeaderText = "Kode Bukti"
            .Columns(2).HeaderText = "Sales"
            .Columns(3).HeaderText = "Jatuh Tempo"
            .Columns(4).HeaderText = "Nominal"
            .Columns(5).HeaderText = "Sisa"
            .Columns(0).Width = 150
            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).Width = 100
            .Columns(4).DefaultCellStyle.Format = "c0"
            .Columns(5).DefaultCellStyle.Format = "c0"
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Private Sub dgvSupplier_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellEnter
        isiGridTrx(dgvSupplier.Item(0, e.RowIndex).Value)
    End Sub
End Class